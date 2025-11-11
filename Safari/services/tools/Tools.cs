using Safari.services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari.services.tools
{
    //clase de utilidades varias para el proyecto Safari
    internal class Tools
    {

        //Metodo que nos permitirá buscar una posición aleatoria libre en el tablero
        public static int[] buscarSitioVacioAleatorio (IRandomProvider randomProvider, Object[,] tablero)
        {
           bool vacio = false;
            while (!vacio)
            {
                int fila = randomProvider.nextRandom(0, tablero.GetLength(0));
                int columna = randomProvider.nextRandom(0, tablero.GetLength(1));
                if (tablero[fila, columna] == null)
                {
                    return new int[] { fila, columna };
                }
            }
            return null;
        }

        /*
         * Nos permitirá verificar que alrededor de una posicion dada hay un espacion vacio, devolveremos un array la  posFila y posColumna
         * del sitio vacio en caso de que haya y en caso de que no devolveremos null;
         */
        internal static int[] buscarSitioVacioPosicion(int posFila, int posColumna, Object[,] tablero)
        {
            /*
             * La logica será intentar acceder a las posiciones alrededor de la posicion dada, si no se puede acceder por IndexOutOfRangeException
             * continuaremos con la siguiente posicion, si se puede acceder comprobaremos si es null, en caso afirmativo devolveremos la posicion
             * El metodo irá izquierda, arriba, derecha, abajo. Se podrá añadir diagonales en un futuro poniendo mas comprobaciones
             */

            //Izquierda
            try
            {
                if (tablero[posFila, posColumna - 1] == null) return new int[] { posFila, posColumna - 1 };
            }
            catch (IndexOutOfRangeException e)
            { }
            //Arriba
            try
            {
                if (tablero[posFila - 1, posColumna] == null) return new int[] { posFila - 1, posColumna };
            }
            catch (IndexOutOfRangeException e)
            { }

            //Derecha
            try
            {
                if (tablero[posFila, posColumna + 1] == null) return new int[] { posFila, posColumna + 1 };
            }
            catch (IndexOutOfRangeException e)
            { }

            //Abajo
            try
            {
                if (tablero[posFila + 1, posColumna] == null) return new int[] { posFila + 1, posColumna };
            }
            catch (IndexOutOfRangeException e)
            { }
            return null;
        }
    }
}
