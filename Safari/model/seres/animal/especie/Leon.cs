using Safari.model.parametro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari.model.seres
{
    //Clase derivada de carnivoro que nos permitirá especificar que el ser vivo es de tipo leon. Adermás esta si podrá ser instanciada
    public class Leon : Carnivoro
    {
        //Nos permitira tener una instancia de los parametros del leon para poder establecer los atributos correspondientes
        private ParametroLeon parametroLeon;

        //Constructor con todos los atributos
        public Leon(int id, int tiempoReproduccion, string representacion, int[] posicion, int hambre, int velocidad)
            : base(id, tiempoReproduccion, representacion, posicion, hambre, velocidad)
        {
        }
        public Leon (int id,int [] posicion, ParametroLeon parametroLeon) :
            base (id,parametroLeon.getTiempoReproduccion(), parametroLeon.getRepresentacion(), posicion, parametroLeon.getHambre(), parametroLeon.getVelocidad())
        {
        }
       
    } 
}

