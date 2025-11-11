using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari.model.parametro
{
    //clase derivada de parametro que nos permitirá definir los parametros específicos para las gacelas, además esta si se podrá instanciar
    public class ParametroGacela : ParametroHervivoro
    {
        //constructor con todos los atributos
        public ParametroGacela(int tiempoReproduccion,String representacion, int velocidad, int maxHambre)
            : base(tiempoReproduccion, representacion, velocidad, maxHambre)
        { 
        }
        
    }
}
