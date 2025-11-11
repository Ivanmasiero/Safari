using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari.model.parametro
{
    //clase derivada de parametro que nos permitirá definir los parametros específicos para las plantas
    public abstract class ParametroPlanta : ParametroSer
    {
        //constructor con todos los atributos
        public ParametroPlanta(int tiempoReproduccion, String representacion) : base (tiempoReproduccion, representacion)
        {
        }
    }
}
