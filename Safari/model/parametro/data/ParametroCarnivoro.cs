using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari.model.parametro
{
    //clase derivada de parametro que nos permitirá definir los parametros específicos para los animales carnivoros
    public abstract class ParametroCarnivoro : ParametroAnimal
    {
        //constructor con todos los atributos
        protected ParametroCarnivoro(int tiempoReproduccion,String representacion,int velocidad, int maxHambre)
            : base(tiempoReproduccion, representacion,velocidad, maxHambre)
        {
        }
    }
}
