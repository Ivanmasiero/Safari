using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari.model.parametro
{
    //clase derivada de parametro que nos permitirá definir los parametros específicos para los animales hervivoros
    public abstract class ParametroHervivoro : ParametroAnimal
    {
        //constructor con todos los atributos
        protected ParametroHervivoro(int tiempoReproduccion,String representacion, int velocidad, int maxHambre)
            : base(tiempoReproduccion, representacion, velocidad, maxHambre)
        {
        }
    }
}
