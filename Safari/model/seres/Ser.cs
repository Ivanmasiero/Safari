using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari.model
{ 
    //Clase de la cual heredaran todos los seres vivivos del safari
    public abstract class  Ser
    {
        //identificador
        private readonly long id;
        //Nos permitirá saber si esta vivo o muerto, lo iniciamos en vivo porque al crear un ser este siempre nacerá vivo
        private String estado = "vivo";
        //Nos permitirá saber cuantos pasos serán necesario para que se reproduzca
        private int tiempoReproduccion;
        //Guardaremos la representación del ser vivo
        private String representacion;
        //Nos servirá para identificar la posicion del ser en el tablero
        private int[] posicion;
        //Nos servira para identificar si el ser se encuentra en periodo de gestación, se inicia en falso porque al nacer no puede reproducirse, tiene que esperar un tiempo
        private bool periodoGestacion = false;
        //constructor con todos los atributos
        protected Ser(int id,int tiempoReproduccion, String representacion, int[] posicion) 
        {
            this.id = id;
            this.estado = estado;
            this.tiempoReproduccion = tiempoReproduccion;
            this.representacion = representacion;
            this.posicion = posicion;  
        }
        //getters y setters
        public long getId() { return this.id; }
        public String getEstado() { return this.estado; }
        public void setEstado(String estado)  { this.estado = estado;}
        public void setTiempoReproduccion(int tiempo) { this.tiempoReproduccion = tiempo; }

        public int getTiempoReproduccion() { return this.tiempoReproduccion; }
        public void setRepresentacion(String representacion) { this.representacion = representacion; }
        public String getRepresentacion() { return this.representacion; }
        public void setPosicion(int[] posicion) { this.posicion = posicion; }
        public int []getPosicion() { return this.posicion; }
        public bool getPeriodoGestacion() { return this.periodoGestacion; }
        public void setPeriodoGestacion (bool periodoGestacion) { this.periodoGestacion = periodoGestacion; }
    }
}
