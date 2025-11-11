using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Safari.view.ventanasModales
{
    public partial class ParametroForm : Form
    {
        public ParametroForm()
        {
            InitializeComponent();
            
        }

        private void dgwParametros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void nCantidadGacela_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tablaParametroGacela_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

     

        private void botonGuardar_Click_1(object sender, EventArgs e)
        {
            //Parametros del safari
            int CantidadGacelas = (int)nCantidadGacela.Value;
            int CantidadLeones = (int)nCantidadLeones.Value;
            int CantidadArbustos = (int)nCantidadArbustos.Value;
            int tamaño = (int)nTamaño.Value;
            //Parametros de las gacelas
            int trGacela = (int)nTrGacela.Value;
            int hmGacela = (int)nMhGacela.Value;
            int vGacela = (int)nVGacela.Value;
            //Parametros de los leones
            int trLeon = (int)nTrLeon.Value;
            int hmLeon = (int)nHmLeon.Value;
            int vLeon = (int)nVLeon.Value;
            //Parametros de los arbustos
            int trArbusto = (int)nTrArbusto.Value;
            //guardamos los parametros en arrays
            int[] parametrosSafari = { CantidadLeones, CantidadGacelas, CantidadArbustos, tamaño };
            int[] parametrosGacela = { trGacela, vGacela, hmGacela };
            int[] parametrosLeon = { trLeon, vLeon, hmLeon };
            int[] parametrosArbusto = { trArbusto };
        }
    }
}
