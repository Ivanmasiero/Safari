using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari.services.interfaces
{
    //interfaz que definirá un proveedor de números aleatorios
    public interface IRandomProvider
    {
        int nextRandom(int min, int max);
    }
}
