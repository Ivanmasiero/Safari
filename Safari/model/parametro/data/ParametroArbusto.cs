using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari.model.parametro
{
    //clase derivada de parametro que nos permitirá definir los parametros específicos para los arbustos, además esta si se podrá instanciar
    public class ParametroArbusto : ParametroPlanta
    {
        //constructor con todos los atributos
        public ParametroArbusto(int tiempoReproduccion, String representacion) : base(tiempoReproduccion, representacion)
        {
        }
    }
}
