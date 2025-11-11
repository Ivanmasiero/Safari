using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari.model.parametro.system
{
    //clase derivada de parametro que nos permitirá definir los parametros específicos para el safari
    public class ParametroSafari : Parametro
    {
        private int cantidadLeon;
        private int cantidadGacela;
        private int cantidadArbusto;
        private int[] tamañoTablero;

        //constructor con todos los atributos
        public ParametroSafari(int cantidadLeon, int cantidadGacela, int cantidadArbusto, int[] tamañoTablero)
        {
            this.cantidadLeon = cantidadLeon;
            this.cantidadGacela = cantidadGacela;
            this.cantidadArbusto = cantidadArbusto;
            this.tamañoTablero = tamañoTablero;
        }
        //setters y getters
        public int getCantidadLeon() { return cantidadLeon; }
        public void setCantidadLeon(int cantidadLeon) { this.cantidadLeon = cantidadLeon; }
        public int getCantidadGacela() { return cantidadGacela; }
        public void setCantidadGacela(int cantidadGacela) { this.cantidadGacela = cantidadGacela; }
        public int getCantidadArbusto() { return cantidadArbusto; }
        public void setCantidadArbusto(int cantidadArbusto) { this.cantidadArbusto = cantidadArbusto; }
        public int[] getTamañoTablero() { return tamañoTablero; }
        public void setTamañoTablero(int[] tamañoTablero) { this.tamañoTablero = tamañoTablero; }

    }
}
