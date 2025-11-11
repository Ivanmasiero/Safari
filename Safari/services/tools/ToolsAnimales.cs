using Safari.model;
using Safari.services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari.services.tools
{
    //clase con metodos utiles para los animales
    internal class ToolsAnimales
    {
        //metodo para buscar comida en el tablero de forma recursiva. Ira buscando cada vez mas lejos hasta que encuentre,
        //en caso de que no aviste comida retorna null
        public static int[] buscarComida(Type tipoComida, Ser ser, Object[,] tablero, int distancia = 1)
        {
            //forma de salir de la recursividad
            if (distancia > tablero.GetLength(0)) return null;
            int posFila = ser.getPosicion()[0];
            int posColumna = ser.getPosicion()[1];
            int[] posPosibleComida;
            //Izquierda
            try
            {
                posPosibleComida = new int[] { posFila, posColumna - distancia };
                //guardamos el tipo de objeto que hay en esa posicion
                Type tipoCelda = tablero[posPosibleComida[0], posPosibleComida[1]]?.GetType();
                //si el tipo de objeto de la celda es asignable al tipo de comida que buscamos devolvemos la posicion
                if (tipoComida.IsAssignableFrom(tipoCelda)) return posPosibleComida;
            }
            catch (IndexOutOfRangeException e)
            { }
            //Arriba
            try
            {
                posPosibleComida = new int[] { posFila - distancia, posColumna };
                //guardamos el tipo de objeto que hay en esa posicion
                Type tipoCelda = tablero[posPosibleComida[0], posPosibleComida[1]]?.GetType();
                //si el tipo de objeto de la celda es asignable al tipo de comida que buscamos devolvemos la posicion
                if (tipoComida.IsAssignableFrom(tipoCelda)) return posPosibleComida;
            }
            catch (IndexOutOfRangeException e)
            { }

            //Derecha
            try
            {
                posPosibleComida = new int[] { posFila, posColumna + distancia };
                //guardamos el tipo de objeto que hay en esa posicion
                Type tipoCelda = tablero[posPosibleComida[0], posPosibleComida[1]]?.GetType();
                //si el tipo de objeto de la celda es asignable al tipo de comida que buscamos devolvemos la posicion
                if (tipoComida.IsAssignableFrom(tipoCelda)) return posPosibleComida;
            }
            catch (IndexOutOfRangeException e)
            { }

            //Abajo
            try
            {
                posPosibleComida = new int[] { posFila + distancia, posColumna };
                //guardamos el tipo de objeto que hay en esa posicion
                Type tipoCelda = tablero[posPosibleComida[0], posPosibleComida[1]]?.GetType();
                //si el tipo de objeto de la celda es asignable al tipo de comida que buscamos devolvemos la posicion
                if (tipoComida.IsAssignableFrom(tipoCelda)) return posPosibleComida;
            }
            catch (IndexOutOfRangeException e)
            { }
            return buscarComida(tipoComida, ser, tablero, ++distancia);
            


        }
        //metodo que hará que el ser coma en la posicion siguienteCasilla, pediremos por parametro una accion que saque de la lista de los vivos la comida
        internal static void Comer(object[,] tablero, Ser ser, int[] siguienteCasilla, Action<Ser> matarComida)
        {
            //guardamos las posiciones
            int[] posActual = new int[] { ser.getPosicion()[0], ser.getPosicion()[1] };
            int[] posComida = new int[] { siguienteCasilla[0], siguienteCasilla[1] };
            //sacamos la comida de la lista de vivos (lo hara el safari Service)
            matarComida((Ser)tablero[posComida[0], posComida[1]]); // hay que matar la comioda<<<<<<<<<<<<<<<<<<<<<<
            // hay que quitar el ser que come de su antigua posicion
            tablero[posActual[0], posActual[1]] = null;
            //movemos al ser que come a la posicion de la comida , la comida desaparece del tablero
            tablero[siguienteCasilla[0], siguienteCasilla[1]] = ser;
            //actualizamos el atributo posicion del ser
            actualizarPosicionSerAtributo(ser, siguienteCasilla);
            //actualizamos el hambre del ser que come
            ((Animal)ser).setHambre(0);

        }
        //metodo que moverá al animal a una posicion aleatoria libre <<<<<<<<<<<<<<<<<<<<< en realidad no es aleatoria >>>>>>>>>>>>
        internal static void moverAnimalAleatorio(object[,] tablero, Ser ser, IRandomProvider randomProvider)
        {
            //guardamos la posicion actual
            int[] posActual = new int[] { ser.getPosicion()[0], ser.getPosicion()[1] };
            //sacamos una nueva posicion
            int[] nuevaPos=Tools.buscarSitioVacioPosicion(ser.getPosicion()[0], ser.getPosicion()[1], tablero); //<<<<<<<<<<< por este metodo>>>>>>>>>
            //movemos al ser a la nueva posicion si hay espacio
            if (nuevaPos!= null)
            {
                //dejar libre la posicion actual
                tablero[ser.getPosicion()[0], ser.getPosicion()[1]] = null;
                //movemos al ser a la nueva posicion en el tablero
                tablero[nuevaPos[0], nuevaPos[1]] = ser;
                //actualizamos el atributo posicion del ser
                ToolsAnimales.actualizarPosicionSerAtributo(ser, nuevaPos);
            }
            
        }
        //metodo que moverá al animal a la posicion siguienteCasilla
        internal static void moverAnimalAPosicion(object[,] tablero, Ser ser, int[] siguienteCasilla)
        {
            //liberamos la posicion actual
            tablero[ser.getPosicion()[0], ser.getPosicion()[1]] = null;
            //movemos al ser a la siguiente posicion
            tablero[siguienteCasilla[0], siguienteCasilla[1]] = ser;
            //actualizamos el atributo posicion del ser
            actualizarPosicionSerAtributo(ser, siguienteCasilla);
        }

        //metodo que devolverá la posicion donde este la comida o hacia donde este. Revisará izquierda, arriba, derecha, abajo
        internal static int [] siguienteCasilla(object[,] tablero, Ser ser, int[] posComida)
        {
            int serFila = ser.getPosicion()[0];
            int serColumna = ser.getPosicion()[1];
            int comidaFila = posComida[0];
            int comidaColumna = posComida[1];

            //Mover a la izquierda
            if (comidaColumna < serColumna)
            {
                return new int[] { serFila, serColumna - 1 };
            }
            //Mover hacia arriba
            else if (comidaFila < serFila)
            {
                return new int[] { serFila - 1, serColumna };
            }
            //Mover a la derecha
            else if (comidaColumna > serColumna)
            {
                return new int[] { serFila, serColumna + 1 };
            }
            //Mover hacia abajo
            else if (comidaFila > serFila)
            {
                return new int[] { serFila + 1, serColumna };
            }
            return null;

            /*
            //Mover en el eje X
            if (comidaColumna < serColumna)
            {
                //Mover a la izquierda
                for (int i = serColumna; i > comidaColumna; i--)
                {
                    tablero[serFila, i] = null;
                    tablero[serFila, i - 1] = ser;
                }
            }
            else if (comidaColumna > serColumna)
            {
                //Mover a la derecha
                for (int i = serColumna; i < comidaColumna; i++)
                {
                    tablero[serFila, i] = null;
                    tablero[serFila, i + 1] = ser;
                }
            }
            //Mover en el eje Y
            if (comidaFila < serFila)
            {
                //Mover hacia arriba
                for (int i = serFila; i > comidaFila; i--)
                {
                    tablero[i, serColumna] = null;
                    tablero[i - 1, serColumna] = ser;
                }
            }
            else if (comidaFila > serFila)
            {
                //Mover hacia abajo
                for (int i = serFila; i < comidaFila; i++)
                {
                    tablero[i, serColumna] = null;
                    tablero[i + 1, serColumna] = ser;
                }
            
            */
        }
        //metodo que servira para cambiar el atributo de posicion del ser despues de moverse
        internal static void actualizarPosicionSerAtributo(Ser ser, int[] nuevaPosicion)
        {
            ser.setPosicion(new int[] { nuevaPosicion[0], nuevaPosicion[1] });
        }
    }
}
