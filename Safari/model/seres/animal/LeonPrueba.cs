using Safari.model.parametro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari.model.seres
{
    public class LeonPrueba

    {
        ParametroLeon parametro;
        int velocidad => parametro.getVelocidad();

        public LeonPrueba(ParametroLeon parametro)
        {
            this.parametro = parametro;
        }
    }
}
