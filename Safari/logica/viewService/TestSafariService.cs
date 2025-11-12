using Safari.model.parametro;
using safariModel =  Safari.model.safariData;
using Safari.model.parametro.system;
using Safari.services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Safari.services.seresServices.PlantaServices;
using Safari.services.providers;
using Safari.model;
using Safari.model.seres;
using Safari.services.seresServices.AnimalesServices;


namespace Safari.controller
{

    public class TestSafariService : ISafariService
    {
        //Modelo de datos recibido por el controlador
        private readonly Controlador controlador;
        //servicios especificos para cada ser vivo
        private ArbustoService arbustoService;
        private GacelaService gacelaService;
        private LeonService leonService;
        //random provider para generar aleatoriedad
        private IRandomProvider randomProvider;
        //diccionario para mapear los tipos de seres vivos con sus servicios correspondientes
        private readonly Dictionary<Type, ISerVivoService> servicesPorTipoSerVivo;
        private readonly Dictionary<Type, IAnimalService> servicesPorTipoAnimal;
        private readonly Dictionary<Type, int[]> parametrosPorTipo;
        //parametros por defecto para cada tipo de ser vivo
        private int[] parametroArbusto;
        private int[] parametroGacela;
        private int[] parametroLeon;

        /*constructor del servicio, recibe el controlador para acceder al modelo de datos, que será el mismo controlador que use la vista
         *para poder comunicarse, teniendo la misma instancia del controlador en la vista y en el servicio
         */
        public TestSafariService(Controlador controlador)
        {
            //controlador
            this.controlador = controlador;
            //random
            this.randomProvider = new RandomProvider();
            //services
            this.arbustoService = new ArbustoService(randomProvider);
            this.leonService = new LeonService(randomProvider);
            this.gacelaService = new GacelaService(randomProvider);
            //inicializamos los parametros por defecto
            parametroArbusto = new int[] { 2 }; //tiempo de reproduccion por defecto 2
            parametroGacela = new int[] { 4, 3, 5 }; //tiempo de reproduccion por defecto 4, max hambre 3, velocidad 5  
            parametroLeon = new int[] { 6, 3, 5 }; //tiempo de reproduccion por defecto 6, max hambre 3, velocidad 5
            //parametros del safari por defecto
            int filas = 5;
            int columnas = 5;
            int cantidadLeones = 1;//(filas * columnas * 3) / 100;
            int cantidadGacelas = (filas * columnas * 10) / 100;
            int cantidadArbustos = (filas * columnas * 35) / 100;
            controlador.setCantidadLeones(cantidadLeones);
            controlador.setCantidadGacelas(cantidadGacelas);
            controlador.setCantidadArbustos(cantidadArbustos);
            controlador.setTablero(new object[filas, columnas]);
            //inicializamos el diccionario de servicios por tipo de ser vivo
            servicesPorTipoSerVivo = new Dictionary<Type, ISerVivoService>
            {
                    {typeof(Leon), leonService },
                    { typeof(Arbusto), arbustoService },
                    { typeof(Gacela), gacelaService }

            };
            //inicializamos el diccionario de servicios por tipo de animales
            servicesPorTipoAnimal = new Dictionary<Type, IAnimalService>
            {
                    {typeof(Leon), leonService },
                    {typeof(Gacela), gacelaService }

            };
            //inicializamos el diccionario de parametros por tipo de ser vivo
            parametrosPorTipo = new Dictionary<Type, int[]>
            {
                    {typeof(Leon), parametroLeon }, //HARCODEADO
                    {typeof(Arbusto), parametroArbusto },
                    {typeof(Gacela), parametroGacela }, //HARCODEADO
            };

        }
        /*
         * método para cambiar los parámetros del safari
         * @param parametrosSafari: array de enteros con los nuevos parámetros del safari [cantidadLeones, cantidadGacelas, cantidadArbustos]
         * @param parametrosGacela: array de enteros con los nuevos parámetros de la gacela [tiempoReproduccion, maxHambre, velocidad]
         * @param parametrosLeon: array de enteros con los nuevos parámetros del leon [tiempoReproduccion, maxHambre, velocidad]
         * @param parametrosArbusto: array de enteros con los nuevos parámetros del arbusto [tiempoReproduccion]
         */
        public void changeParameters(int[] parametrosSafari, int[] parametrosGacela, int[] parametrosLeon, int[] parametrosArbusto)
        {
            //cambiamos los parametros del safari
            controlador.setCantidadLeones(parametrosSafari[0]);
            controlador.setCantidadGacelas(parametrosSafari[1]);
            controlador.setCantidadArbustos(parametrosSafari[2]);
            //cambiamos los parametros de la gacela
            //recorremos la lista de seres vivos para actualizar los parametros de los ya existentes
            foreach (Ser ser in controlador.getSeresVivos())
            {
                if (ser is Gacela)
                {
                    ((Gacela)ser).setTiempoReproduccion(parametrosGacela[0]);
                    ((Gacela)ser).setMaxHambre(parametrosGacela[1]);
                    ((Gacela)ser).setVelocidad(parametrosGacela[2]);
                }
                else if (ser is Leon)
                {
                    ((Leon)ser).setTiempoReproduccion(parametrosLeon[0]);
                    ((Leon)ser).setMaxHambre(parametrosLeon[1]);
                    ((Leon)ser).setVelocidad(parametrosLeon[2]);
                }
                else if (ser is Arbusto)
                {
                    ((Arbusto)ser).setTiempoReproduccion(parametrosArbusto[0]);
                }
            }
        }


        public void nextStep()
        {
            hambreAnimales();
            movimientoAnimales();
            seresEnPeriodoDeGestacion();
            periodoDeReproduccion();

        }


        /*public void play()
        {
           
            bool isPlaying = true;
            
            //hasta que no se pare no se detendrá
            if (isPlaying)
            {
                //ejecutamos el play en un hilo aparte para no bloquear la interfaz
                Task.Run(async () =>
                {
                    while (isPlaying)
                    {
                        if (soloHayplantas()) isPlaying = false;
                        if (tableroVacio()) isPlaying = false;
                        nextStep();
                        await Task.Delay(1000); //esperamos 1 segundo entre cada paso
                        refresh?.Invoke();

                    }
                }
                );
            }
        }
        */
        public void start()
        {

            //nacimiento de arbustos hasta la cantidad por defecto
            for (int i = 0; i < controlador.getCantidadArbustos(); i++)
            {
                Ser arbusto = arbustoService.nacer(controlador.getTablero(), "resources/img/arbusto.png", parametroArbusto); //tiempo de reproduccion por defecto 2
                añadirSer(arbusto, controlador.getSeresVivos());
            }
            //nacimiento de gacelas hasta la cantidad por defecto
            for (int i = 0; i < controlador.getCantidadGacelas(); i++)
            {
                Ser gacela = (Gacela)gacelaService.nacer(controlador.getTablero(), "resources/img/gacela.png", parametroGacela);
                añadirSer(gacela, controlador.getSeresVivos());
            }
            //nacimiento de leones hasta la cantidad indicada en el parametro
            for (int i = 0; i < controlador.getCantidadLeones(); i++)
            {
                //tiempo de reproduccion por defecto 6, representacion "LEON", max hambre 3, velocidad 5
                Ser leon = (Leon)leonService.nacer(controlador.getTablero(), "resources/img/leon.png", parametroLeon);
                añadirSer(leon, controlador.getSeresVivos());
            }
        }

        public void reset()
        {
            //reseteamos el tablero con el valor por defecto
            controlador.setTablero(new object[controlador.getTablero().GetLength(0), controlador.getTablero().GetLength(1)]);
            //reseteamos las listas de seres vivos y muertos
            controlador.setSeresVivos(new List<Ser>());
            controlador.setSeresMuertos(new List<Ser>());
            //reseteamos los ids de los seres vivos
            leonService.resetId();
            gacelaService.resetId();
            arbustoService.resetId();
        }

        //¡¡¡¡¡¡METODOS PRIVADOS!!!!!!

        public async Task nextStepAsync()
        {
            hambreAnimales();
            await movimientoAnimalesAsync();
            seresEnPeriodoDeGestacion();
            periodoDeReproduccion();
            //mostrarTablero();

        }

        /*
         * método para gestionar el periodo de reproducción de los seres vivos, decrementando su tiempo de reproducción y 
         * haciendo que se reproduzcan cuando llegue a 0, en caso de que no puedan reproducirse en ese momento, se les
         * asigna true el periodo de gestación.
         */
        private void periodoDeReproduccion()
        {
            //tenemos una lista auxiliar ya que no podemos añadir objetos a la misma lista que estoy recorriendo
            List<Ser> auxList = new List<Ser>();
            //recorremos todos los seres vivos del safari
            foreach (Ser ser in controlador.getSeresVivos())
            {
                //guardamos el tipo del ser
                Type tipoSer = ser.GetType();
                //decrementamos el tiempo de reproducción
                ser.setTiempoReproduccion(ser.getTiempoReproduccion() - 1);
                //si el tiempo de reproducción es 0 intentamos reproducirnos
                if (ser.getTiempoReproduccion() <= 0)
                {
                    //intentamos reproducirnos
                    Ser nuevoSer = servicesPorTipoSerVivo[tipoSer].reproducirse(ser, parametrosPorTipo[tipoSer], controlador.getTablero());
                    if (nuevoSer != null) //si se ha podido reproducir
                    {
                        añadirSer(nuevoSer, auxList); //lo añadimos a la lista auxiliar
                        ser.setTiempoReproduccion(parametrosPorTipo[tipoSer][0]); //reseteamos el tiempo de reproducción
                    }
                    else
                    {
                        ser.setPeriodoGestacion(true); //si no se ha podido reproducir, lo marcamos en periodo de gestación
                    }
                }
            }
            //ahora si añadimos los nuevos seres a la lista de safari
            foreach (Ser ser in auxList)
            {
                controlador.getSeresVivos().Add(ser);
            }
        }

        //servirá para que los seres que esten en periodo de gestacion intenten reproducirse
        private void seresEnPeriodoDeGestacion()
        {
            //tenemos una lista auxiliar ya que no podemos añadir objetos a la misma lista que estoy recorriendo
            List<Ser> auxList = new List<Ser>();
            //recorremos todos los seres vivos del safari
            foreach (Ser ser in controlador.getSeresVivos())
            {
                //guardamos el tipo del ser
                Type tipoSer = ser.GetType();
                if (ser.getPeriodoGestacion()) //si el ser está en periodo de gestación
                {
                    //intentamos reproducirnos
                    Ser nuevoSer = servicesPorTipoSerVivo[tipoSer].reproducirse(ser, parametrosPorTipo[tipoSer], controlador.getTablero());
                    //si se ha podido reproducir
                    if (nuevoSer != null)
                    {
                        //lo añadimos a la lista auxiliar
                        añadirSer(nuevoSer, auxList);
                        //reseteamos el tiempo de reproducción
                        ser.setTiempoReproduccion(parametrosPorTipo[tipoSer][0]);
                        //salimos del periodo de gestación
                        ser.setPeriodoGestacion(false);
                    }
                }
            }
            //ahora si añadimos los nuevos seres a la lista de safari
            foreach (Ser ser in auxList)
            {
                controlador.getSeresVivos().Add(ser);
            }
        }


        //método para el movimiento de los animales
        private void movimientoAnimales()
        {
            //creamos una lista auxiliar para evitar la modificación de la colección mientras se itera sobre ella
            List<Ser> seresComidos = new List<Ser>();
            //recorremos todos los seres vivos del safari
            foreach (Ser ser in controlador.getSeresVivos())
            {
                //guardamos el tipo del ser
                Type tipoSer = ser.GetType();
                //si el ser es un animal lo movemos
                if (servicesPorTipoAnimal.TryGetValue(tipoSer, out var service))
                {
                    //aumentamos el hambre del animal antes de moverse porque si come se reiniciará a 0
                    ((Animal)ser).setHambre(((Animal)ser).getHambre() + 1);
                    //movemos el animal, pasandole una accion que añadirá a la lista de seres comidos el ser que coma
                    service.moverse(controlador.getTablero(), ser, (comida) =>
                    {
                        seresComidos.Add(comida);
                    });
                }
            }
            //eliminamos los seres comidos de la lista de seres vivos del safari
            foreach (Ser comida in seresComidos)
            {
                controlador.getSeresVivos().Remove(comida);
            }
        }

        //movimiento de los animales, de forma asíncrona para ir moviendo uno a uno los animales con delay
        private async Task movimientoAnimalesAsync()
        {

            //creamos una lista auxiliar para evitar la modificación de la colección mientras se itera sobre ella
            List<Ser> seresComidos = new List<Ser>();
            foreach (Ser ser in controlador.getSeresVivos())
            {
                //quiero un delay por cada animales que se mueva para poder ver mejor el movimiento en consola
                await Task.Delay(1000);
                Type tipoSer = ser.GetType();
                if (servicesPorTipoAnimal.TryGetValue(tipoSer, out var service))
                {
                    //aumentamos el hambre del animal antes de moverse porque si come se reiniciará a 0
                    ((Animal)ser).setHambre(((Animal)ser).getHambre() + 1);
                    service.moverse(controlador.getTablero(), ser, (comida) =>
                    {
                        seresComidos.Add(comida);
                    });
                    Console.Clear();
                    mostrarTablero();
                }
            }
            //eliminamos los seres comidos de la lista de seres vivos del safari
            foreach (Ser comida in seresComidos)
            {
                controlador.getSeresVivos().Remove(comida);
            }
        }
        //método para añadir un ser al safari, actualizando la lista y el tablero
        private void añadirSer(Ser ser, List<Ser> lista)
        {
            lista.Add(ser);
            object[,] tableroAux = controlador.getTablero();
            tableroAux[ser.getPosicion()[0], ser.getPosicion()[1]] = ser;
            controlador.setTablero(tableroAux);
        }
        //método para gestionar el hambre de los animales
        private void hambreAnimales()
        {
            foreach (Ser ser in controlador.getSeresVivos().ToList())
            {
                //guardamos el tipo del ser
                Type tipoSer = ser.GetType();
                //si el ser es un animal aumentamos su nivel de hambre
                if (typeof(Animal).IsAssignableFrom(tipoSer))
                {
                    if (((Animal)ser).getHambre() >= ((Animal)ser).getMaxHambre())
                    {
                        Ser serMuerto = servicesPorTipoAnimal[tipoSer].morir(ser);
                        if (serMuerto != null)
                        {
                            //eliminamos el ser del tablero y de la lista de seres vivos
                            object[,] tableroAux = controlador.getTablero();
                            tableroAux[serMuerto.getPosicion()[0], serMuerto.getPosicion()[1]] = null;
                            controlador.setTablero(tableroAux);
                            controlador.getSeresMuertos().Add(serMuerto);
                            controlador.getSeresVivos().Remove(serMuerto);
                        }
                    }
                }
            }
        }
        //método para mostrar el tablero en consola
        private void mostrarTablero()
        {
            for (int i = 0; i < controlador.getTablero().GetLength(0); i++)
            {
                for (int j = 0; j < controlador.getTablero().GetLength(1); j++)
                {
                    object celda = controlador.getTablero()[i, j];
                    if (celda == null)
                    {
                        Console.Write("[------] ");
                    }
                    else
                    {
                        Console.Write("[" + celda + "] ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------");
        }
        //nos servirá para comprobar si en el tablero solo quedan plantas
        private bool soloHayplantas()
        {
            for (int i = 0; i < getTablero().GetLength(0); i++)
            {
                for (int j = 0; j < getTablero().GetLength(1); j++)
                {
                    object celda = getTablero()[i, j];
                    if (celda != null)
                    {
                        if (typeof(Animal).IsAssignableFrom(celda.GetType())) //si hay algun animal
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
            /*foreach (Ser ser in controlador.getSeresVivos())
            {
                if (typeof(Animal).IsAssignableFrom(ser.GetType())) //si hay algun animal
                {
                    return false;
                }
            }
            return true;
            */
        }
        //nos servirá para comprobar si el tablero está vacío
        private bool tableroVacio()
        {
            return controlador.getSeresVivos().Count == 0;
        }

        //datos que necesita la vista
        public object[,] getTablero()
        {
            return controlador.getTablero();
        }
        //el orden sera [cantidadLeones, cantidadGacelas, cantidadArbustos, tamaño]
        public int[] getParametroSafari()
        {
            return new int[] { controlador.getCantidadLeones(), controlador.getCantidadGacelas(), controlador.getCantidadArbustos(), controlador.getTablero().GetLength(0) };
        }
        //el orden sera [cantidadLeones, cantidadGacelas, cantidadArbustos]
        public void setParametroSafari(int[] parametro)
        {
            controlador.setCantidadLeones(parametro[0]);
            controlador.setCantidadGacelas(parametro[1]);
            controlador.setCantidadArbustos(parametro[2]);
        }
        //el orden sera [tiempoReproduccion]
        public int[] getParametroArbusto()
        {
            return parametroArbusto;
        }
        //el orden sera [tiempoReproduccion]
        public void setParametroArbusto(int[] parametro)
        {
            parametroArbusto = parametro;
        }
        //el orden sera [tiempoReproduccion, maxHambre, velocidad]
        public int[] getParametroGacela()
        {
            return parametroGacela;
        }
        //el orden sera [tiempoReproduccion, maxHambre, velocidad]
        public void setParametroGacela(int[] parametro)
        {
            parametroGacela = parametro;
        }
        //el orden sera [tiempoReproduccion, maxHambre, velocidad]
        public int[] getParametroLeon()
        {
            return parametroLeon;
        }
        //el orden sera [tiempoReproduccion, maxHambre, velocidad]
        public void setParametroLeon(int[] parametro)
        {
            parametroLeon = parametro;
        }

    }
}
