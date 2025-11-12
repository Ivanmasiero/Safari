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
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Safari
{
    public partial class MyForm : Form
    {
        private Controlador controlador;
        //variable que nos dira si estamos en modo play o no
        bool isPlaying = false;
        //variable que nos dira si el safari ha sido construido o no
        bool construido = false;

        public MyForm()
        {
            
            InitializeComponent();
            controlador = new Controlador();
            /*service.OnTableroUpdated += () => panelMapa.Invalidate(); // Suscribirse al evento*/
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
            /*safari.cambiarEstadoBotones += ()=>
                {
                    botonStart.Enabled = safari.getIsStopped();
                    botonNextStep.Enabled = safari.getIsPaused();
                    botonPlay.Enabled = safari.getIsPaused();
                    botonPause.Enabled = safari.getIsPlaying();
                    botonStop.Enabled = safari.getIsPlaying();
                    botonModoLento.Enabled = safari.getIsPaused();
                    botonParametro.Enabled = safari.getIsStopped();
                };
            */

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
            int rows = controlador.getTablero().GetLength(0);
            int cols = controlador.getTablero().GetLength(1);
            int cellWidth = panelMapa.Width / cols;
            int cellHeight = panelMapa.Height / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Ser ser = controlador.getTablero()[i, j] as Ser;
                    Rectangle cellRect = new Rectangle(j * cellWidth, i * cellHeight, cellWidth, cellHeight);

                    // dibujar el contorno de la celda
                    g.DrawRectangle(Pens.Black, cellRect);

                    // dibujar la letra del ser vivo
                    if (ser != null)
                    {
                        string ruta = ser.getRepresentacion(); // mala forma de hacerlo, pero por ahora vale

                        if (File.Exists(ruta))
                        {
                            using (Image img = Image.FromFile(ruta))
                            {
                                g.DrawImage(img, cellRect);
                            }
                        }

                    
                        
                    }
                }
            }

        }

        private void botonStart_MouseClick(object sender, MouseEventArgs e)
        {
            construido = true;
            botonStart.Enabled = false;
            botonNextStep.Enabled = true;
            botonPlay.Enabled = true;
            botonParametro.Enabled = true;
            botonModoLento.Enabled = true;
            botonPause.Enabled = false;
            botonStop.Enabled = true;
            controlador.start();
            panelMapa.Invalidate();


        }

        private void botonNextStep_Click(object sender, EventArgs e)
        {
          
            controlador.nextStep();
            panelMapa.Invalidate();
        }

        private void botonPlayClick(object sender, EventArgs e)
        {
            isPlaying = true;
            botonStart.Enabled = false;
            botonNextStep.Enabled = false;
            botonPlay.Enabled = false;
            botonParametro.Enabled = false;
            botonModoLento.Enabled = false;
            botonPause.Enabled = true;
            botonStop.Enabled = true;


            //hasta que no se pare no se detendrá
            if (isPlaying)
            {
                //ejecutamos el play en un hilo aparte para no bloquear la interfaz
                Task.Run(async () =>
                {
                    while (isPlaying)
                    {
                        controlador.nextStep();
                        await Task.Delay(500); //esperamos 500 milisegundos entre cada paso
                        panelMapa.Invalidate();
                    }

                }
                );
            }
        }

        private void botonPause_Click(object sender, EventArgs e)
        {
            isPlaying = false;
            botonStart.Enabled = false;
            botonNextStep.Enabled = true;
            botonPlay.Enabled = true;
            botonParametro.Enabled = true;
            botonModoLento.Enabled = true;
            botonPause.Enabled = false;
            botonStop.Enabled = true;
        }

        private void botonStop_Click(object sender, EventArgs e)
        {
            botonStart.Enabled = true;
            botonNextStep.Enabled = false;
            botonPlay.Enabled = false;
            botonParametro.Enabled = true;
            botonModoLento.Enabled = false;
            botonPause.Enabled = false;
            botonStop.Enabled = false;
            construido = false;
            isPlaying = false;
            controlador.reset();
        }

        private async void botonModoLento_Click(object sender, EventArgs e)
        {
            isPlaying = true;
            botonStart.Enabled = false;
            botonNextStep.Enabled = false;
            botonPlay.Enabled = false;
            botonParametro.Enabled = false;
            botonModoLento.Enabled = false;
            botonPause.Enabled = true;
            botonStop.Enabled = true;

            //hasta que no se pare no se detendrá
            if (isPlaying)
            {
                //ejecutamos el play en un hilo aparte para no bloquear la interfaz
                Task.Run(async () =>
                {
                    while (isPlaying)
                    {
                        controlador.nextStep();
                        await Task.Delay(2000); //esperamos 2 segundos entre cada paso
                        panelMapa.Invalidate();
                    }
                });
            }
        }

        private void botonParametro_Click(object sender, EventArgs e)
        {
            ParametroForm parametroForm = new ParametroForm(controlador.getParametroSafari(), controlador.getParametroLeon(), controlador.getParametroGacela(), controlador.getParametroArbusto(),construido, controlador);
            parametroForm.ShowDialog();
        }

        

        
    }
}
