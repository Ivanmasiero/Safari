using Safari.controller;
using Safari.model;
using Safari.model.safariData;
using Safari.services.interfaces;
using Safari.view.ventanasModales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Safari
{
    public partial class MyForm : Form
    {
        private TestSafariService safari;
       
        public MyForm()
        {
            
            InitializeComponent();
            safari = new TestSafariService();
            safari.OnTableroUpdated += () => panelMapa.Invalidate(); // Suscribirse al evento
            //Maximizamos la ventana al iniciar
            this.WindowState = FormWindowState.Maximized;
            //Creamos las columnas de la botonera
            this.panelBotonera.ColumnStyles.Clear();
            for (int i = 0; i < 7; i++)
            {
                this.panelBotonera.ColumnStyles.Add(
                    new ColumnStyle(SizeType.Percent, 100F / 7F));
            }

            // Los botones deben ocupar toda su celda
            foreach (Control c in panelBotonera.Controls)
                c.Dock = DockStyle.Fill;
            // Manejar el evento Resize del panelMapa
            panelMapa.Resize += (s, e) =>
            {
                panelMapa.Invalidate(); // fuerza repintado cuando cambie tamaño
            };
            //suscribimos los botones a los eventos
            safari.cambiarEstadoBotones += ()=>
                {
                    botonStart.Enabled = safari.getIsStopped();
                    botonNextStep.Enabled = safari.getIsPaused();
                    botonPlay.Enabled = safari.getIsPaused();
                    botonPause.Enabled = safari.getIsPlaying();
                    botonStop.Enabled = safari.getIsPlaying();
                    botonModoLento.Enabled = safari.getIsPaused();
                    botonParametro.Enabled = safari.getIsStopped();
                };

        }



        private void MyForm_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        

        private void panelMapa_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int rows = safari.getTablero().GetLength(0);
            int cols = safari.getTablero().GetLength(1);
            int cellWidth = panelMapa.Width / cols;
            int cellHeight = panelMapa.Height / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Ser ser = safari.getTablero()[i, j] as Ser;
                    Rectangle cellRect = new Rectangle(j * cellWidth, i * cellHeight, cellWidth, cellHeight);

                    // dibujar el contorno de la celda
                    g.DrawRectangle(Pens.Black, cellRect);

                    // dibujar la letra del ser vivo
                    if (ser != null)
                    {
                        string letra = ser.ToString(); // o un método que devuelva “L” para León, “G” para Gacela
                        StringFormat sf = new StringFormat
                        {
                            Alignment = StringAlignment.Center,
                            LineAlignment = StringAlignment.Center
                        };
                        g.DrawString(letra, this.Font, Brushes.White, cellRect, sf);
                    }
                }
            }

        }

        private void botonStart_MouseClick(object sender, MouseEventArgs e)
        {
            safari.start();
            
        }

        private void botonNextStep_Click(object sender, EventArgs e)
        {
            safari.nextStep();
        }

        private void botonPlayClick(object sender, EventArgs e)
        {
            safari.play();
        }

        private void botonPause_Click(object sender, EventArgs e)
        {
            safari.pause();
        }

        private void botonStop_Click(object sender, EventArgs e)
        {
            safari.stop();
        }

        private async void botonModoLento_Click(object sender, EventArgs e)
        {
            await safari.nextStepAsync();
        }

        private void botonParametro_Click(object sender, EventArgs e)
        {
            ParametroForm parametroForm = new ParametroForm();
            parametroForm.ShowDialog();
        }
    }
}
