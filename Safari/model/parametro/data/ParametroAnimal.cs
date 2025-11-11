using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari.model.parametro
{
    //clase derivada de parametro que nos permitirá definir los parametros específicos para los animales
    public abstract class ParametroAnimal : ParametroSer
    {
        //atributo que nos permitirá definir la velocidad de un animal
        private int velocidad;
        //atributo que nos permitirá definir el hambre de un animal
        private int maxHambre;
        //constructor con todos los atributos
        protected ParametroAnimal(int tiempoReproducion ,String representacion,int velocidad, int hambre) : base(tiempoReproducion, representacion)
        {
            this.velocidad = velocidad;
            this.maxHambre = hambre;
        }
        //getter y setter
        public int getVelocidad() { return this.velocidad; }
        public void setVelocidad(int velocidad) { this.velocidad = velocidad; }
        public int getHambre() { return this.maxHambre; }
        public void setHambre(int hambre) { this.maxHambre = hambre; }
    }
}
