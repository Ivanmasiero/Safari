using Safari.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari.services.interfaces
{
    //interfaz que definirá los servicios relacionados con los animales
    internal interface IAnimalService : ISerVivoService
    {
        /*
         * Método que moverá al animal a la siguiente posición, ira hacia la comida y si esta a su alcance la comerá.
         * Necesita el tablero para saber donde está la comida y una acción para eliminar la comida de la lista de 
         * seres vivos en caso de que el animal a moverse tenga que comer
         */
        void moverse(Object[,] tablero, Ser ser, Action<Ser> matarComida);
    }
}
