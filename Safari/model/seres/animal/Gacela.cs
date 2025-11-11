using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari.model.seres
{
    //Clase derivada de animal que nos permitirá especificar que el ser vivo es de tipo gacela. Adermás esta si podrá ser instanciada
    public class Gacela : Herviboro
    {
        //nos permitirá acceder a los parametros específicos de la gacela
        parametro.ParametroGacela parametroGacela;
        public Gacela(int id, int tiempoReproduccion, string representacion, int[] posicion, int hambre, int velocidad)
            : base(id, tiempoReproduccion, representacion, posicion, hambre, velocidad)
        {
        }
        //Constructor con todos los atributos utilizando parametroGacela para establecer los atributos correspondientes
        public Gacela(int id, int[] posicion, parametro.ParametroGacela parametroGacela) :
            base(id, parametroGacela.getTiempoReproduccion(), parametroGacela.getRepresentacion(), posicion, parametroGacela.getHambre(), parametroGacela.getVelocidad())
        {
        }
        
    }
}
