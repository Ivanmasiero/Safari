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
    public partial class StatsForm : Form
    {
        Controlador controlador;
        public StatsForm(Controlador controlador)
        {
            InitializeComponent();
            this.controlador = controlador;
            this.labelNCantidadSeresComidos.Text = controlador.getSeresMuertos().Count().ToString();
            this.labelNCantidadSeresVivos.Text = controlador.getSeresVivos().Count().ToString();
        }

        private void StatsForm_Load(object sender, EventArgs e)
        {

        }

        private void buttomCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
