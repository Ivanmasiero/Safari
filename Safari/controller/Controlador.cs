using Safari.model;
using Safari.model.parametro;
using Safari.model.parametro.system;
using Safari.services.interfaces;
using Safari.services.seresServices.AnimalesServices;
using Safari.services.seresServices.PlantaServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using safariModel = Safari.model.safariData;

namespace Safari.controller
{
    //controlador que se encarga de comunicar el modelo de datos con los servicios (que será parte de la vista)
    public class Controlador
    {
        private safariModel.Safari safari;
        private TestSafariService service;
        //constructor del controlador, iniciamos el modelo de datos con los valores por defecto
        public Controlador()
        {
            //instanciamos el modelo de datos
            this.safari = new safariModel.Safari();
            //instanciamos el servicio
            this.service = new TestSafariService(this);
        }
        //COMUNICACIÓN DE SERVICIOS (lÓGICA) CON LA VISTA!!!!!!!!!!!

        //método para iniciar el safari con los párametros por defecto
        public void start()
        {
            service.start();
        }
        //método para avanzar un paso en el safari
        public void nextStep()
        {
            service.nextStep();
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
            service.changeParameters(parametrosSafari, parametrosGacela, parametrosLeon, parametrosArbusto);
        }
        //método para resetear todo a 0. Los parámetros vuelven a los valores por defecto
        public void reset()
        {
            service.reset();
        }

        public int[] getParametroSafari()
        {
            return service.getParametroSafari();
        }
        //el orden sera [cantidadLeones, cantidadGacelas, cantidadArbustos]
        public void setParametroSafari(int[] parametro)
        {
            service.setParametroSafari(parametro);
        }
        //el orden sera [tiempoReproduccion]
        public int[] getParametroArbusto()
        {
            return service.getParametroArbusto();
        }
        //el orden sera [tiempoReproduccion]
        public void setParametroArbusto(int[] parametro)
        {
            service.setParametroArbusto(parametro);
        }
        //el orden sera [tiempoReproduccion, maxHambre, velocidad]
        public int[] getParametroGacela()
        {
            return service.getParametroGacela();
        }
        //el orden sera [tiempoReproduccion, maxHambre, velocidad]
        public void setParametroGacela(int[] parametro)
        {
            service.setParametroGacela(parametro);
        }
        //el orden sera [tiempoReproduccion, maxHambre, velocidad]
        public int[] getParametroLeon()
        {
            return service.getParametroLeon();
        }
        //el orden sera [tiempoReproduccion, maxHambre, velocidad]
        public void setParametroLeon(int[] parametro)
        {
            service.setParametroLeon(parametro);
        }

        //COMUNICACIÓN MODELO DE DATOS CON SERVICIOS Y VISTA!!!!!!!!!!!!!!!!!!!!!!
        //único getter que necesita la vista para pintar el tablero
        public object[,] getTablero()
        {
            return this.safari.getTablero();
        }


        //COMUNICACIÓN MODELO DE DATOS CON SERVICIOS!!!!!!!!!!!!!!!!!!!!!
        //setters y getters para comunicar el modelo de datos con los servicios
        public void setTablero(object[,] tablero)
        {
            this.safari.setTablero(tablero);

        }

        public List<Ser> getSeresVivos()
        {
            return this.safari.getSeresVivos();
        }
        public void setSeresVivos(List<Ser> seresVivos)
        {
            this.safari.setSeresVivos(seresVivos);
        }
        public List<Ser> getSeresMuertos()
        {
            return this.safari.getSeresMuertos();
        }
        public void setSeresMuertos(List<Ser> seresMuertos)
        {
            this.safari.setSeresMuertos(seresMuertos);
        }
        public int getCantidadLeones()
        {
            return this.safari.cantidadLeones();
        }
        public void setCantidadLeones(int cantidadLeon)
        {
            this.safari.setCantidadLeones(cantidadLeon);
        }
        public int getCantidadArbustos()
        {
            return this.safari.cantidadArbustos();
        }
        public void setCantidadArbustos(int cantidadArbusto)
        {
            this.safari.setCantidadArbustos(cantidadArbusto);
        }
        public int getCantidadGacelas()
        {
            return this.safari.cantidadGacelas();
        }
        public void setCantidadGacelas(int cantidadGacela)
        {
            this.safari.setCantidadGacelas(cantidadGacela);
        }

    }  
}
