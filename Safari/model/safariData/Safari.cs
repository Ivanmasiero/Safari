using Safari.model.parametro.system;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari.model.safariData
{
    //Clase de datos del safari, tendra la lista de seres vivos que habitan en el safari y los que estan muertos. Ademas tendrá un tablero que representara el safari
    public class Safari
    {
        List<Ser> seresVivos;
        List<Ser> seresMuertos;
        Object[,] tablero;
        ParametroSafari parametroSafari;
        int cantidadLeon;
        int cantidadGacela;
        int cantidadArbusto;

        //constructor vacio
        public Safari() 
        {
            this.seresVivos = new List<Ser>();
            this.seresMuertos = new List<Ser>();
            this.tablero = new object[0,0];
            this.cantidadLeon = 0;
            this.cantidadGacela = 0;
            this.cantidadArbusto = 0;
        }

        //constructor con atributos
        public Safari(int cantidadLeon, int cantidadGacela, int cantidadArbusto, Object[,] tablero) 
        {
            this.seresVivos = new List<Ser>();
            this.seresMuertos = new List<Ser>();
            this.cantidadLeon = cantidadLeon;
            this.cantidadGacela = cantidadGacela;
            this.cantidadArbusto = cantidadArbusto;
            this.tablero = tablero;
        }
        //constructor inializando con parametro
        public Safari(ParametroSafari parametroSafari)
        {
            this.parametroSafari = parametroSafari;
            this.seresVivos = new List<Ser>();
            this.seresMuertos = new List<Ser>();
            this.cantidadLeon = parametroSafari.getCantidadLeon();
            this.cantidadGacela = parametroSafari.getCantidadGacela();
            this.cantidadArbusto = parametroSafari.getCantidadArbusto();
            this.tablero = new object[parametroSafari.getTamañoTablero()[0], parametroSafari.getTamañoTablero()[1]];
        }

        //setters y getters
            
        public List<Ser> getSeresVivos() { return this.seresVivos; }
        public void setSeresVivos(List<Ser> seresVivos) { this.seresVivos = seresVivos; }
        public List<Ser> getSeresMuertos() { return this.seresMuertos; }
        public void setSeresMuertos(List<Ser> seresMuertos) { this.seresMuertos = seresMuertos; }
        public Object[,] getTablero() { return this.tablero; }
        public void setTablero(Object[,] tablero) { this.tablero = tablero; }
        public int cantidadLeones() { return this.cantidadLeon; }
        public void setCantidadLeones(int cantidadLeon) { this.cantidadLeon = cantidadLeon; }
        public int cantidadArbustos() { return this.cantidadArbusto; }
        public void setCantidadArbustos(int cantidadArbusto) { this.cantidadArbusto = cantidadArbusto; }
        public int cantidadGacelas() { return this.cantidadGacela; }
        public void setCantidadGacelas(int cantidadGacela) { this.cantidadGacela = cantidadGacela; }
    }
}
