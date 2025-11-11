using Safari.model.parametro;
using Safari.model.parametro.system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Safari.services.interfaces
{
    //interfaz que definirá los servicios relacionados con el safari
    internal interface ISafariService
    {

        //Método que iniciará el safari con los parámetros dados, Creará todas las instancias
        void start();
        //Método que avanzará el safari un paso
        void nextStep();
        //Método que pondrá en marcha el safari hasta que se pause, pare o termine
        void play();
        //Método que pausará el safari
        void pause();
        //Método que detendrá el safari
        void stop();
        //metodo que terminara el safari (instancia)
        void end();
        //Método que cambiará los parámetros del safari en ejecución
        void changeParameters(int[] parametrosSafari, int[] parametrosGacela, int[] parametrosLeon, int[] parametrosArbusto);
    }
}
