using Safari.model;
using Safari.model.parametro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Safari.services.interfaces
{
    //interfaz que definirá los servicios relacionados con los seres vivos
    public interface ISerVivoService
    {
        //Cambiaremos el estado del ser vivo a muerto y devolveremos el ser, que ahora esta muerto para añadirlo a la lista de seres muertos
        Ser morir(Ser ser);
        //Generaremos un nuevo ser vivo en una posicion aleatoria, para ello necesitaré el tablero del safari para tener en cuenta las posiciones ocupadas
        // y los parametros para determinar con que atributos debe nacer el ser
        Ser nacer(Object[,] tablero, String repre, int[] parametros);

        //Generaremos un nuevo ser vivo a partir de otro, le pasamos un parametro para que sepa las estadisticas con las que deba nacer el hijo y el tablero
        //como contexto para buscar una posicion libre alrededor del padre
        Ser reproducirse(Ser ser, int[]parametro , Object[,] tablero);
        void resetId();
    }
}