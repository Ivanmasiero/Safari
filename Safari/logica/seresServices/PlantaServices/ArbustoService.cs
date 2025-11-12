using Safari.model;
using Safari.model.parametro;
using Safari.services.interfaces;
using Safari.services.tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari.services.seresServices.PlantaServices
{
    public class ArbustoService : ISerVivoService

    {
        //Nos va ayudar a asignar un id unico a cada arbusto
        private int id;
        private string repre;

        //Necesitamos el proveedor de numeros aleatorios
        IRandomProvider randomProvider;
        //Constructor con el proveedor de numeros aleatorios
        public ArbustoService(IRandomProvider randomProvider)
        {
            this.randomProvider = randomProvider;
        }
        public Ser morir(Ser ser)
        {
            ser.setEstado("Muerto");
            return ser;
        }

        public Ser nacer(Object[,] tablero, String repre, int[] parametros)
        {
            this.id++;
            this.repre = repre; 
            int[] posicionNacimiento = Tools.buscarSitioVacioAleatorio(randomProvider, tablero);
            return new Arbusto(id, parametros[0], repre, posicionNacimiento);
        }


        //En caso de que no haya sitio alrededor del padre devolveremos null
        public Ser reproducirse(Ser ser, int[] parametro,Object[,] tablero)
        {
            int posFila = ser.getPosicion()[0];
            int posColumna = ser.getPosicion()[1];
            int [] posNacimiento = Tools.buscarSitioVacioPosicion(posFila, posColumna,tablero);
            if (posNacimiento!= null)
            {
                this.id++;
                return new Arbusto(id, parametro[0],repre, posNacimiento);
            }

            return null;    
        }
        public void resetId()
        {
            this.id = 0;
        }

        //¡¡¡¡¡¡METODOS PRIVADOS!!!!!!

    }
}
