using Safari.model.parametro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Safari.model
{
    //Clase derivada de planta que nos permitirá especificar que el ser vivo es de tipo arbusto, además esta si podrá ser instanciada
    public class Arbusto : Planta
    {
        //Nos permitirá acceder a los parametros de los arbustos
        ParametroArbusto ParametroArbusto;
        //constructor con todos los atributos
        public Arbusto(int id, int tiempoReproduccion, string representacion, int[] posicion) : base(id,tiempoReproduccion, representacion, posicion)
        {
        }
        //Constructor con todos los atributos utilizando ParametroArbusto para establecer los atributos correspondientes
        public Arbusto(int id, int[] posicion, ParametroArbusto parametroArbusto) :
            base(id, parametroArbusto.getTiempoReproduccion(), parametroArbusto.getRepresentacion(), posicion)
        {
        }
        override
          public String ToString()
        {
            return "0"+this.getRepresentacion()+this.getId();
        }
    }
}
