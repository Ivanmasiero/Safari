using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari.model.parametro
{
    //clase derivada de parametro que nos permitirá definir los parametros específicos para los leones, además esta si se podrá instanciar
     public class ParametroLeon : ParametroCarnivoro
    {
        //constructor con todos los atributos
        public ParametroLeon(int tiempoReproduccion,String representacion, int velocidad, int maxHambre)
            : base(tiempoReproduccion, representacion, velocidad, maxHambre)
        {
        }
    }
    
}
