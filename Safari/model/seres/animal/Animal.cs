
using Safari.model.seres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari.model
{
    public abstract class Animal : Ser
    {
        //Nos permitira saber cuantos turnos lleva sin comer el animal, empieza en 0 y va aumentando cada turno que pasa sin comer
        private int hambre = 0;
        //Nos permitira saber el maximo de turnos que puede estar sin comer un animal antes de morir
        private int maxHambre;
        //Nos permitira saber la velocidad del animal, los animales con mayor velocidad se moveran antes que los que tengan menos
        private int velocidad;
        //Nos permitirá saber a que otro ser vivo es el que va a comer
        

        protected Animal(int id, int tiempoReproduccion, string representacion, int[] posicion,int maxHambre, int velocidad) 
            : base(id, tiempoReproduccion, representacion, posicion)
        {
            this.maxHambre = maxHambre;
            this.velocidad = velocidad;
            
        }

        //seters y getters
        public int getHambre() { return this.hambre; }
        public void setHambre(int hambre) { this.hambre = hambre; }
        public void setVelocidad(int velocidad) { this.velocidad = velocidad; }
        public int getVelocidad() { return this.velocidad; }
        public int getMaxHambre() { return this.maxHambre; }
        public void setMaxHambre(int maxHambre) { this.maxHambre = maxHambre; }
        public override string ToString()
        {
            return this.getHambre() + "" + this.getRepresentacion() + "" + this.getId();
        }


    }
}
