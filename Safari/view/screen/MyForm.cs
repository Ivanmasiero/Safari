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
using Safari.view.ventanasAyuda;
using System.Windows.Forms;

namespace Safari
{
    public partial class MyForm : Form
    {
        //controlador para comunicar la vista con el modelo de datos y la lógica
        private Controlador controlador;
        //variable que nos dira si estamos en modo play o no
        bool isPlaying = false;
        //variable que nos dira si el safari ha sido construido o no
        bool construido = false;
        //creamos un cache para las imágenes
        private Dictionary<string, Image> cacheImagenes;

        public MyForm()
        {
            
            InitializeComponent();
            controlador = new Controlador();

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
            //inicializamos el cache de imágenes
            cacheImagenes = new Dictionary<string, Image>();
            
                
            


        }

        private void MyForm_Load(object sender, EventArgs e)
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

                    // dibujar al ser si existe
                    if (ser != null)
                    {
                        string ruta = ser.getRepresentacion();

                        Image img;

                        // si la imagen ya está cargada, usarla
                        if (!cacheImagenes.TryGetValue(ruta, out img))
                        {
                            if (File.Exists(ruta))
                            {
                                img = Image.FromFile(ruta);
                                cacheImagenes[ruta] = img; // guardar en memoria
                            }
                            else
                            {
                                img = null;
                            }
                        }

                        if (img != null)
                        {
                            g.DrawImage(img, cellRect);
                        }
                    }
                }

            }
        }

        private void botonStart_MouseClick(object sender, MouseEventArgs e)
        {
            construido = true;
            botonStart.Enabled = false;
            toolStart.Enabled = false;
            botonNextStep.Enabled = true;
            botonPlay.Enabled = true;
            toolPlay.Enabled = true;
            botonParametro.Enabled = true;
            toolStats.Enabled = true;
            botonModoLento.Enabled = true;
            botonPause.Enabled = false;
            toolPause.Enabled = true;
            botonStop.Enabled = true;
            toolStop.Enabled = true;
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
            toolStart.Enabled = false;
            botonNextStep.Enabled = false;
            botonPlay.Enabled = false;
            toolPlay.Enabled = false;
            botonParametro.Enabled = false;
            toolStats.Enabled = false;
            botonModoLento.Enabled = false;
            botonPause.Enabled = true;
            toolPause.Enabled = true;
            botonStop.Enabled = true;
            toolStop.Enabled = true;


            //hasta que no se pare no se detendrá
            if (isPlaying)
            {
                //ejecutamos el play en un hilo aparte para no bloquear la interfaz
                Task.Run(async () =>
                {
                    while (isPlaying)
                    {
                        controlador.nextStep();
                        await Task.Delay(1000); //esperamos 500 milisegundos entre cada paso
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
            toolStart.Enabled = false;
            botonNextStep.Enabled = true;
            botonPlay.Enabled = true;
            toolPlay.Enabled = true;
            botonParametro.Enabled = true;
            botonModoLento.Enabled = true;
            botonPause.Enabled = false;
            toolPause.Enabled = false;
            botonStop.Enabled = true;
            toolStop.Enabled = true;
            toolStats.Enabled = true;
        }

        private void botonStop_Click(object sender, EventArgs e)
        {
            botonStart.Enabled = true;
            toolStart.Enabled = true;
            botonNextStep.Enabled = false;
            botonPlay.Enabled = false;
            toolPlay.Enabled = false;
            botonParametro.Enabled = true;
            toolStats.Enabled = false;
            botonModoLento.Enabled = false;
            botonPause.Enabled = false;
            toolPause.Enabled = false;
            botonStop.Enabled = false;
            toolStop.Enabled = false;
            construido = false;
            isPlaying = false;
            controlador.reset();
        }

        private async void botonModoLento_Click(object sender, EventArgs e)
        {
            isPlaying = true;
            botonStart.Enabled = false;
            toolStart.Enabled = false;
            botonNextStep.Enabled = false;
            botonPlay.Enabled = false;
            toolPlay.Enabled = false;
            botonParametro.Enabled = false;
            toolStats.Enabled = false;
            botonModoLento.Enabled = false;
            botonPause.Enabled = true;
            toolPause.Enabled = true;
            botonStop.Enabled = true;
            toolStop.Enabled = true;

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
            ParametroForm parametroForm = new ParametroForm(controlador.getParametroSafari(), controlador.getParametroLeon(), controlador.getParametroGacela(), controlador.getParametroArbusto(), construido, controlador);
            parametroForm.ShowDialog();
        }

       

        private void toolPlay_Click(object sender, EventArgs e)
        {
            isPlaying = true;
            botonStart.Enabled = false;     
            botonNextStep.Enabled = false;
            botonPlay.Enabled = false;
            toolPlay.Enabled = false;
            botonParametro.Enabled = false;
            toolStats.Enabled = false;
            botonModoLento.Enabled = false;
            botonPause.Enabled = true;
            toolPause.Enabled = true;
            botonStop.Enabled = true;
            toolStop.Enabled = true;


            //hasta que no se pare no se detendrá
            if (isPlaying)
            {
                //ejecutamos el play en un hilo aparte para no bloquear la interfaz
                Task.Run(async () =>
                {
                    while (isPlaying)
                    {
                        controlador.nextStep();
                        await Task.Delay(1000); //esperamos 500 milisegundos entre cada paso
                        panelMapa.Invalidate();
                    }
                }
                );
            }

        }

        private void toolPause_Click(object sender, EventArgs e)
        {
            isPlaying = false;
            botonStart.Enabled = false;
            botonNextStep.Enabled = true;
            botonPlay.Enabled = true;
            toolPlay.Enabled = true;
            botonParametro.Enabled = true;
            toolStats.Enabled = true;
            botonModoLento.Enabled = true;
            botonPause.Enabled = false;
            toolPause.Enabled = false;
            botonStop.Enabled = true;
            toolStop.Enabled = true;

        }

        private void toolStop_Click(object sender, EventArgs e)
        {
            botonStart.Enabled = true;
            botonNextStep.Enabled = false;
            botonPlay.Enabled = false;
            toolPlay.Enabled = false;
            botonParametro.Enabled = true;
            toolStats.Enabled = false;
            botonModoLento.Enabled = false;
            botonPause.Enabled = false;
            toolPause.Enabled = false;
            botonStop.Enabled = false;
            toolStop.Enabled = false;
            construido = false;
            isPlaying = false;
            controlador.reset();

        }

        private void toolSettings_Click(object sender, EventArgs e)
        {
            //abro la ventana de parámetros
            ParametroForm parametroForm = new ParametroForm(controlador.getParametroSafari(), controlador.getParametroLeon(), controlador.getParametroGacela(), controlador.getParametroArbusto(), construido, controlador);
            parametroForm.ShowDialog();

        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            //preguntamos si quiere salir
            var result = MessageBox.Show("¿Estás seguro de que quieres salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void toolStats_Click(object sender, EventArgs e)
        {
            //abro la ventana de estadísticas
            StatsForm statsForm = new StatsForm(controlador);
            statsForm.ShowDialog();
        }

        private void toolStart_Click(object sender, EventArgs e)
        {
            construido = true;
            botonStart.Enabled = false;
            toolStart.Enabled = false;
            botonNextStep.Enabled = true;
            botonPlay.Enabled = true;
            toolPlay.Enabled = true;
            botonParametro.Enabled = true;
            toolStats.Enabled = true;
            botonModoLento.Enabled = true;
            botonPause.Enabled = false;
            toolPause.Enabled = true;
            botonStop.Enabled = true;
            toolStop.Enabled = true;
            controlador.start();
            panelMapa.Invalidate();
        }

        private void nuevoSafariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (construido)
            {
                var result = MessageBox.Show("¿Estás seguro de que quieres iniciar un nuevo safari? Se perderán los datos actuales.", "Nuevo Safari", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    botonStop_Click(sender, e);
                    toolStart_Click(sender, e);
                }
            }else
            {
                    toolStart_Click(sender, e);
            }
            
               
        }

        private void iniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (construido)
            {
                var result = MessageBox.Show("¿Estás seguro de que quieres iniciar la simulación?", "Iniciar Simulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    toolPlay_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Primero debes iniciar un nuevo safari.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pausarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (construido)
            {
                if (isPlaying)
                {
                    toolPause_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("La simulación ya está pausada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Primero debes iniciar un nuevo safari.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (construido)
            {
                var result = MessageBox.Show("¿Estás seguro de que quieres reiniciar el safari? Se perderán los datos actuales.", "Reiniciar Safari", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    botonStop_Click(sender, e);
                    toolStart_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Primero debes iniciar un nuevo safari.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void párametrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (construido)
            {
                if (isPlaying)
                {
                    MessageBox.Show("Debes pausar la simulación antes de cambiar los parámetros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    toolSettings_Click(sender, e);
                }
            }
            else
            {
                toolSettings_Click(sender, e);
            }
        }

        private void mostrarStats_Click(object sender, EventArgs e)
        {
            if (construido)
            {
                if (isPlaying)
                {
                    MessageBox.Show("Debes pausar la simulación antes de ver las estadísticas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    toolStats_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Primero debes iniciar un nuevo safari.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void acercaDeSafariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe acercaDe = new AcercaDe();
            acercaDe.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolExit_Click(sender, e);
        }

        private void controlesManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AyudaForm ayudaForm = new AyudaForm();
            ayudaForm.Show();
        }
    }
}
