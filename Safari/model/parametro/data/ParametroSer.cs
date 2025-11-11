using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari.model.parametro
{
    //clase derivada de parametro que nos permitirá definir los parametros específicos para los seres vivos
    public abstract class ParametroSer : Parametro
        
    {
        //atributo que nos permitirá definir el tiempo de reproducción de un ser vivo
        private int tiempoReproduccion;
        //atributo que nos permitirá definir la representación de un ser vivo
        private String Representacion;
        //constructor con todos los atributos
        protected ParametroSer(int tiempoReproduccion, String Representacion)
        {
            this.tiempoReproduccion = tiempoReproduccion;
            this.Representacion = Representacion;
        }
        //getter y setter
        public int getTiempoReproduccion() { return this.tiempoReproduccion; }
        public void setTiempoReproduccion(int tiempoReproduccion) { this.tiempoReproduccion = tiempoReproduccion; }
        public String getRepresentacion() { return this.Representacion; }
        public void setRepresentacion(String representacion) { this.Representacion = representacion; }
    }
}
