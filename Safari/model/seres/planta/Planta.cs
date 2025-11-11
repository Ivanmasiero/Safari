using Safari.model.parametro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Safari.model
{
    /*
     * Clase derivada de ser que nos permitirá especificar que el ser vivo es de tipo planta, de aqui se derivaran futuras clases que
     * sean de tipo planta
     */
    public abstract class Planta : Ser
    {
        //Nos permitirá acceder a los parametros de las plantas
        protected Planta(int id, int tiempoReproduccion, string representacion, int[] posicion) : base(id, tiempoReproduccion, representacion, posicion)
        {
        }
      
    }
}
