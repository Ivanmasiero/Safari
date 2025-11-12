using Safari.model;
using Safari.model.parametro;
using Safari.model.seres;
using Safari.services.interfaces;
using Safari.services.tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari.services.seresServices.AnimalesServices
{
    //clase que implementa la funcionalidad específica de los leones
    public class LeonService : IAnimalService
    {
        private int id;
        private string repre;
        private IRandomProvider randomProvider;
        //constructor con el proveedor de numeros aleatorios
        public LeonService(IRandomProvider randomProvider)
        {
            this.randomProvider = randomProvider;
        }
        public Ser morir(Ser ser)
        {
            ser.setEstado("Muerto");
            return ser;

        }
        public void moverse(Object[,] tablero, Ser ser, Action<Ser> matarComida)
        {
            //buscamos la posicion de la comida mas cercana
            int[] posComida = ToolsAnimales.buscarComida(typeof(Herviboro), ser, tablero);
            //si hay comida en el tablero
            if (posComida != null)
            {
                //bucamos la siguiente casilla en direccion a la comida
                int[] siguienteCasilla = ToolsAnimales.siguienteCasilla(tablero, ser, posComida);
                //si la siguiente casilla es comida, comemos, si no nos movemos a esa posicion, en caso de que la casilla este ocupada movemos aleatoriamente

                //verificamos si la siguiente casilla no es nulo (hay algo)
                if (tablero[siguienteCasilla[0], siguienteCasilla[1]] != null)
                {
                    //verificamos si es un herbivoro para poder comer
                    if (typeof(Herviboro).IsAssignableFrom(tablero[siguienteCasilla[0], siguienteCasilla[1]].GetType())) //me da null pointer exception
                    {
                        //comemos
                        ToolsAnimales.Comer(tablero, ser, siguienteCasilla, matarComida);
                    }
                    //si no es herbivoro movemos aleatoriamente
                    else
                    {
                        //avanzamos aleatoriamente
                        ToolsAnimales.moverAnimalAleatorio(tablero, ser, randomProvider);
                    }
                }
                //si la casilla esta vacia avanzamos hacia ella
                else
                {
                    //avanzamos hacia la comida
                    ToolsAnimales.moverAnimalAPosicion(tablero, ser, siguienteCasilla);
                }

            }
            //si no hay comida nos movemos aleatoriamente
            else
            {
                ToolsAnimales.moverAnimalAleatorio(tablero, ser, randomProvider);
            }
        }
        public Ser nacer(object[,] tablero,String repre, int[] parametros)
        {
            int tiempoReproduccion = parametros[0];
            int hambre = parametros[1];
            int velocidad = parametros[2];
            this.id++;
            this.repre = repre;
            int[] posicionNacimiento = Tools.buscarSitioVacioAleatorio(randomProvider, tablero);
            return new Leon(id, tiempoReproduccion, repre, posicionNacimiento, hambre, velocidad);
        }

        public Ser reproducirse(Ser ser, int[] parametro, object[,] tablero)
        {
            //guardamos la posicion del padre
            int posFila = ser.getPosicion()[0];
            int posColumna = ser.getPosicion()[1];
            //buscamos una posicion vacia alrededor del padre
            int[] posNacimiento = Tools.buscarSitioVacioPosicion(posFila, posColumna, tablero);
            //si hay posicion vacia devolvemos el nuevo leon
            if (posNacimiento != null)
            {
                this.id++;
                return new Leon(id, parametro[0], repre, posNacimiento, parametro[1], parametro[2]);
            }
            //si no hay posicion vacia devolvemos null
            else
            {
                return null;
            }

        }
        public void resetId()
        {
            this.id = 0;
        }
    }
}
