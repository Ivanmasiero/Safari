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
        private safariModel.Safari safari;
        private ArbustoService arbustoService;
        private ParametroArbusto parametroArbusto;
        private ParametroSafari parametroSafari;
        private ParametroGacela parametroGacela;
        private ParametroLeon parametroLeon;    
        private GacelaService gacelaService;
        private IRandomProvider randomProvider;
        private LeonService leonService;
        //diccionario para mapear los tipos de seres vivos con sus servicios correspondientes
        private readonly Dictionary<Type, ISerVivoService> servicesPorTipoSerVivo;
        private readonly Dictionary<Type, IAnimalService> servicesPorTipoAnimal;
        private readonly Dictionary<Type, ParametroSer> parametrosPorTipo;
        //variable para controlar si el safari está en reproducción continua o no
        private bool isPlaying = false;
        private bool isPaused = false;
        private bool isStopped = true;
        public event Action OnTableroUpdated;
        public event Action cambiarEstadoBotones;

        public TestSafariService()
        {
            //random
            this.randomProvider = new RandomProvider();
            //parametros
            this.parametroSafari = new ParametroSafari(2,2,2,new int[] {10,10}); //HARCODEADO
            this.parametroArbusto = new ParametroArbusto(2,"ARBU"); //HARCODEADO
            this.parametroGacela = new ParametroGacela(4,"GACE",5,3); //HARCODEADO
            this.parametroLeon = new ParametroLeon(6,"LEON",4,3); //HARCODEADO
            //instancia safari
            this.safari = new safariModel.Safari(parametroSafari);
            //services
            this.arbustoService = new ArbustoService(randomProvider);
            this.leonService = new LeonService(randomProvider);
            this.gacelaService = new GacelaService(randomProvider);
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
            parametrosPorTipo = new Dictionary<Type, ParametroSer>
            {
                    {typeof(Leon), parametroLeon }, //HARCODEADO
                    {typeof(Arbusto), parametroArbusto },
                    {typeof(Gacela), parametroGacela }, //HARCODEADO
            };
            //creamos un tablero vacío
            safari.setTablero(new object[parametroSafari.getTamañoTablero()[0], parametroSafari.getTamañoTablero()[1]]);
            //creamos las listas de seres vivos y muertos
            safari.setSeresVivos(new List<Ser>());
            safari.setSeresMuertos(new List<Ser>());

        }
        public void changeParameters(int[] parametrosSafari, int[] parametrosGacela, int[] parametrosLeon, int[] parametrosArbusto)
        {
            this.parametroSafari = new ParametroSafari(parametrosSafari[0], parametrosSafari[1], parametrosSafari[2], new int[] { parametrosSafari[3], parametrosSafari[3] });
            this.parametroGacela = new ParametroGacela(parametrosGacela[0], "GACE", parametrosGacela[1], parametrosGacela[2]);
            this.parametroLeon = new ParametroLeon(parametrosLeon[0], "LEON", parametrosLeon[1], parametrosLeon[2]);
            this.parametroArbusto = new ParametroArbusto(parametrosArbusto[0], "ARBU");
        }

        public void end()
        {
            throw new NotImplementedException();
        }
        public void nextStep()
        {
            hambreAnimales();
            movimientoAnimales();
            seresEnPeriodoDeGestacion();
            periodoDeReproduccion();
            OnTableroUpdated?.Invoke();
        }
        public void pause()
        {
            //paramos la reproducción continua
            isPlaying = false;
            isPaused = true;
            isStopped = false;
            cambiarEstadoBotones?.Invoke();
        }

        public void play()
        {
            isStopped = false;
            isPaused = false;
            isPlaying = true;
            cambiarEstadoBotones?.Invoke();
            //hasta que no se pare no se detendrá
            if (isPlaying)
            {
                //ejecutamos el play en un hilo aparte para no bloquear la interfaz
                Task.Run(async () =>
                {
                    while (isPlaying)
                    {
                        nextStep();
                        await Task.Delay(1000); //esperamos 1 segundo entre cada paso
                    }
                }
                );
            }
        }

        public void start()
        {
            isPaused = true;
            isStopped = false;
            isPlaying = false;
            cambiarEstadoBotones?.Invoke();
            //nacimiento de arbustos hasta la cantidad indicada en el parametro
            for (int i = 0; i < parametroSafari.getCantidadArbusto(); i++)
            {
                Ser arbusto =  arbustoService.nacer(safari.getTablero(), parametroArbusto);
                añadirSer(arbusto,safari.getSeresVivos());
            }
            //nacimiento de gacelas hasta la cantidad indicada en el parametro
            for (int i = 0; i < parametroSafari.getCantidadGacela(); i++)
            {
                Ser gacela = (Gacela)gacelaService.nacer(safari.getTablero(), parametroGacela);
                añadirSer(gacela, safari.getSeresVivos());
            }
            //nacimiento de leones hasta la cantidad indicada en el parametro
            for (int i = 0; i < parametroSafari.getCantidadLeon(); i++)
            {
                Ser leon = (Leon)leonService.nacer(safari.getTablero(), parametroLeon);
                añadirSer(leon, safari.getSeresVivos());
            }
            OnTableroUpdated?.Invoke();

        }

        public void stop()
        {
            //paramos la reproducción continua
            isPlaying = false;
            isPaused = false;
            isStopped = true;
            cambiarEstadoBotones?.Invoke();
            //volvemos al estado inicial
            resetSafari();
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
            List<Ser> auxList = new List<Ser>();

            foreach (Ser ser in safari.getSeresVivos())
            {
                Type tipoSer = ser.GetType();
                ser.setTiempoReproduccion(ser.getTiempoReproduccion() - 1);
                if (ser.getTiempoReproduccion() <= 0)
                {
                    Ser nuevoSer = servicesPorTipoSerVivo[tipoSer].reproducirse(ser, parametrosPorTipo[tipoSer], safari.getTablero());
                    if (nuevoSer != null)
                    {
                        añadirSer(nuevoSer,auxList);
                        ser.setTiempoReproduccion(parametrosPorTipo[tipoSer].getTiempoReproduccion());
                    }
                    else
                    {
                        ser.setPeriodoGestacion(true);
                    }
                }
            }
            foreach (Ser ser in auxList)
            {
                safari.getSeresVivos().Add(ser);
            }
        }

        //servirá para que los seres que esten en periodo de gestacion intenten reproducirse
        private void seresEnPeriodoDeGestacion()
        {
            //tenemos una lista auxiliar ya que no podemos añadir objetos a la misma lista que estoy recorriendo
            List<Ser> auxList = new List<Ser>();
            foreach (Ser ser in safari.getSeresVivos())
            {
                Type tipoSer = ser.GetType();
                if (ser.getPeriodoGestacion())
                {
                    Ser nuevoSer = servicesPorTipoSerVivo[tipoSer].reproducirse(ser, parametrosPorTipo[tipoSer], safari.getTablero());
                    if (nuevoSer != null)
                    {
                        añadirSer(nuevoSer,auxList);
                        ser.setTiempoReproduccion(parametrosPorTipo[tipoSer].getTiempoReproduccion());
                        ser.setPeriodoGestacion(false);
                    }
                }
            }
            //ahora si añadimos los nuevos seres a la lista de safari
            foreach (Ser ser in auxList )
            {
                safari.getSeresVivos().Add(ser);
            }
        }

       
        //método para el movimiento de los animales
        private void movimientoAnimales()
        {
            //creamos una lista auxiliar para evitar la modificación de la colección mientras se itera sobre ella
            List<Ser> seresComidos = new List<Ser>();
            //recorremos todos los seres vivos del safari
            foreach (Ser ser in safari.getSeresVivos())
            {
                //guardamos el tipo del ser
                Type tipoSer = ser.GetType();
                //si el ser es un animal lo movemos
                if (servicesPorTipoAnimal.TryGetValue(tipoSer, out var service))
                {
                    //aumentamos el hambre del animal antes de moverse porque si come se reiniciará a 0
                    ((Animal)ser).setHambre(((Animal)ser).getHambre() + 1);
                    //movemos el animal, pasandole una accion que añadirá a la lista de seres comidos el ser que coma
                    service.moverse(safari.getTablero(), ser, (comida) =>
                    {
                        seresComidos.Add(comida);
                    });
                }
            }
            //eliminamos los seres comidos de la lista de seres vivos del safari
            foreach (Ser comida in seresComidos)
            {
                safari.getSeresVivos().Remove(comida);
            }
        }
      
        //movimiento de los animales, de forma asíncrona para ir moviendo uno a uno los animales con delay
        private async Task movimientoAnimalesAsync()
        {
            
            //creamos una lista auxiliar para evitar la modificación de la colección mientras se itera sobre ella
            List<Ser> seresComidos = new List<Ser>();
            foreach (Ser ser in safari.getSeresVivos())
            {
                //quiero un delay por cada animales que se mueva para poder ver mejor el movimiento en consola
                await Task.Delay(1000);
                Type tipoSer = ser.GetType();
                if (servicesPorTipoAnimal.TryGetValue(tipoSer, out var service))
                {
                    //aumentamos el hambre del animal antes de moverse porque si come se reiniciará a 0
                    ((Animal)ser).setHambre(((Animal)ser).getHambre() + 1);
                    service.moverse(safari.getTablero(), ser, (comida) =>
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
                safari.getSeresVivos().Remove(comida);

            }
        }
        //método para añadir un ser al safari, actualizando la lista y el tablero
        private void añadirSer(Ser ser, List<Ser> lista)
        {
            lista.Add(ser);
            object[,] tableroAux = safari.getTablero();
            tableroAux[ser.getPosicion()[0], ser.getPosicion()[1]] = ser;
            safari.setTablero(tableroAux);
        }
        //método para gestionar el hambre de los animales
        private void hambreAnimales()
        {
            foreach (Ser ser in safari.getSeresVivos().ToList())
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
                            object[,] tableroAux = safari.getTablero();
                            tableroAux[serMuerto.getPosicion()[0], serMuerto.getPosicion()[1]] = null;
                            safari.setTablero(tableroAux);
                            safari.getSeresMuertos().Add(serMuerto);
                            safari.getSeresVivos().Remove(serMuerto);
                        }
                    }
                }
            }   
        }
        //método para mostrar el tablero en consola
        private void mostrarTablero()
        {
            for (int i = 0; i < safari.getTablero().GetLength(0); i++)
            {
                for (int j = 0; j < safari.getTablero().GetLength(1); j++)
                {
                    object celda = safari.getTablero()[i, j];
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
        private void resetSafari()
        {
            //reseteamos el tablero
            safari.setTablero(new object[parametroSafari.getTamañoTablero()[0], parametroSafari.getTamañoTablero()[1]]);
            //reseteamos las listas de seres vivos y muertos
            safari.setSeresVivos(new List<Ser>());
            safari.setSeresMuertos(new List<Ser>());
            leonService.resetId();
            gacelaService.resetId();
            arbustoService.resetId();
        }

        //getter and setters
        public object[,] getTablero()
        {
            return this.safari.getTablero();
        }
        public bool getIsPlaying()
        {
            return isPlaying;
        }

        public bool getIsPaused()
        {
            return isPaused;
        }

        public bool getIsStopped()
        {
            return isStopped;
        }

        //getters y setters de los parámetros
        public int cantidadGacelas()
        {
            return parametroSafari.getCantidadGacela();
        }
    }

}
