using Safari.controller;
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
        private bool construido;
        private Controlador controlador;
        public ParametroForm(int[] parametrosSafari, int[] parametrosLeon, int[] parametrosGacela, int[] parametrosArbusto, bool construido, Controlador controlador)
        {
            InitializeComponent();
            // Cargar los parámetros en los controles correspondientes
            nCantidadLeones.Value = parametrosSafari[0];
            nCantidadGacela.Value = parametrosSafari[1];
            nCantidadArbustos.Value = parametrosSafari[2];
            nTamaño.Value = parametrosSafari[3];
            nTrLeon.Value = parametrosLeon[0];
            nHmLeon.Value = parametrosLeon[1];
            nVLeon.Value = parametrosLeon[2];
            nTrGacela.Value = parametrosGacela[0];
            nHmGacela.Value = parametrosGacela[1];
            nVGacela.Value = parametrosGacela[2];
            nTrArbusto.Value = parametrosArbusto[0];
            this.construido = construido;
            this.controlador = controlador;
            if (construido)
            {
                // Deshabilitar los controles relacionados con el tamaño del safari
                nTamaño.Enabled = false;
                nCantidadLeones.Enabled = false;
                nCantidadGacela.Enabled = false;
                nCantidadArbustos.Enabled = false;
            }
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

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            //control de excepcion
            if (!cantidadValida())
            {
                return; // Salir si la cantidad no es válida
            }
            //Parametros del safari
            controlador.setCantidadArbustos((int)nCantidadArbustos.Value);
            controlador.setCantidadGacelas((int)nCantidadGacela.Value);
            controlador.setCantidadLeones((int)nCantidadLeones.Value);
            controlador.setTablero(new object[(int)nTamaño.Value, (int)nTamaño.Value]);

            //Parametros seres vivos
            controlador.setParametroGacela(new int[] { (int)nTrGacela.Value, (int)nHmGacela.Value, (int)nVGacela.Value });
            controlador.setParametroLeon(new int[] { (int)nTrLeon.Value, (int)nHmLeon.Value, (int)nVLeon.Value });
            controlador.setParametroArbusto(new int[] { (int)nTrArbusto.Value });

            
            
            //Cerramos la ventana
            this.Close();
        }
        private bool cantidadValida()
        {
            int totalCeldas = (int)(nTamaño.Value * nTamaño.Value);
            int sumaActual = (int)(nCantidadLeones.Value + nCantidadGacela.Value + nCantidadArbustos.Value);

            if (sumaActual > totalCeldas)
            {
               

                // Ajustamos el valor que acaba de provocar el exceso
                int exceso = sumaActual - totalCeldas;
                
                MessageBox.Show(
                    $"La suma total de seres no puede superar el número de celdas ({totalCeldas}).",
                    "Límite excedido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return false;
            }
            return true;
        }
    }
}
