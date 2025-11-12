using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari.model.seres
{
    //Clase derivada de animal que nos permitirá especificar que el ser vivo es de tipo herviboro
    public abstract class Herviboro : Animal
    {
        //constructor con todos los atributos
        protected Herviboro(int id, int tiempoReproduccion, string representacion, int[] posicion, int maxHambre, int velocidad)
            : base(id, tiempoReproduccion, representacion, posicion, maxHambre, velocidad)
        {
        }
    }
}
