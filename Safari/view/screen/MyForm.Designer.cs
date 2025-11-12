using System.Drawing;
using System.Windows.Forms;

namespace Safari
{
    partial class MyForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.panelMapa = new System.Windows.Forms.Panel();
            this.panelBotonera = new System.Windows.Forms.TableLayoutPanel();
            this.botonModoLento = new System.Windows.Forms.Button();
            this.botonStop = new System.Windows.Forms.Button();
            this.botonPause = new System.Windows.Forms.Button();
            this.botonPlay = new System.Windows.Forms.Button();
            this.botonNextStep = new System.Windows.Forms.Button();
            this.botonStart = new System.Windows.Forms.Button();
            this.botonParametro = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Panel();
            this.labelTituloSafari = new System.Windows.Forms.Label();
            this.PanelContenedor.SuspendLayout();
            this.panelBotonera.SuspendLayout();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Controls.Add(this.panelMapa);
            this.PanelContenedor.Controls.Add(this.panelBotonera);
            this.PanelContenedor.Controls.Add(this.header);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(0, 0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(2318, 1054);
            this.PanelContenedor.TabIndex = 1;
            this.PanelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelMapa
            // 
            this.panelMapa.BackColor = System.Drawing.Color.ForestGreen;
            this.panelMapa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMapa.Location = new System.Drawing.Point(0, 201);
            this.panelMapa.Name = "panelMapa";
            this.panelMapa.Size = new System.Drawing.Size(2318, 853);
            this.panelMapa.TabIndex = 1;
            this.panelMapa.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMapa_Paint);
            // 
            // panelBotonera
            // 
            this.panelBotonera.BackColor = System.Drawing.Color.LightGray;
            this.panelBotonera.ColumnCount = 7;
            this.panelBotonera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 360F));
            this.panelBotonera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 364F));
            this.panelBotonera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 282F));
            this.panelBotonera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 282F));
            this.panelBotonera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 331F));
            this.panelBotonera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 383F));
            this.panelBotonera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 316F));
            this.panelBotonera.Controls.Add(this.botonModoLento, 6, 0);
            this.panelBotonera.Controls.Add(this.botonStop, 5, 0);
            this.panelBotonera.Controls.Add(this.botonPause, 4, 0);
            this.panelBotonera.Controls.Add(this.botonPlay, 3, 0);
            this.panelBotonera.Controls.Add(this.botonNextStep, 2, 0);
            this.panelBotonera.Controls.Add(this.botonStart, 1, 0);
            this.panelBotonera.Controls.Add(this.botonParametro, 0, 0);
            this.panelBotonera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBotonera.Location = new System.Drawing.Point(0, 100);
            this.panelBotonera.Name = "panelBotonera";
            this.panelBotonera.RowCount = 1;
            this.panelBotonera.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelBotonera.Size = new System.Drawing.Size(2318, 101);
            this.panelBotonera.TabIndex = 0;
            // 
            // botonModoLento
            // 
            this.botonModoLento.Enabled = false;
            this.botonModoLento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.botonModoLento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botonModoLento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonModoLento.Location = new System.Drawing.Point(2005, 3);
            this.botonModoLento.Name = "botonModoLento";
            this.botonModoLento.Padding = new System.Windows.Forms.Padding(5);
            this.botonModoLento.Size = new System.Drawing.Size(310, 95);
            this.botonModoLento.TabIndex = 6;
            this.botonModoLento.Text = "Modo Lento";
            this.botonModoLento.UseVisualStyleBackColor = false;
            this.botonModoLento.Click += new System.EventHandler(this.botonModoLento_Click);
            // 
            // botonStop
            //
            this.botonStop.Enabled = false;
            this.botonStop.BackColor = System.Drawing.Color.Red;
            this.botonStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonStop.Location = new System.Drawing.Point(1622, 3);
            this.botonStop.Name = "botonStop";
            this.botonStop.Padding = new System.Windows.Forms.Padding(5);
            this.botonStop.Size = new System.Drawing.Size(377, 95);
            this.botonStop.TabIndex = 5;
            this.botonStop.Text = "Stop";
            this.botonStop.UseVisualStyleBackColor = false;
            this.botonStop.Click += new System.EventHandler(this.botonStop_Click);
            // 
            // botonPause
            //
            this.botonPause.Enabled = false;
            this.botonPause.BackColor = System.Drawing.Color.Cyan;
            this.botonPause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botonPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPause.Location = new System.Drawing.Point(1291, 3);
            this.botonPause.Name = "botonPause";
            this.botonPause.Padding = new System.Windows.Forms.Padding(5);
            this.botonPause.Size = new System.Drawing.Size(325, 95);
            this.botonPause.TabIndex = 4;
            this.botonPause.Text = "Pause";
            this.botonPause.UseVisualStyleBackColor = false;
            this.botonPause.Click += new System.EventHandler(this.botonPause_Click);
            // 
            // botonPlay
            //
            this.botonPlay.Enabled = false;
            this.botonPlay.BackColor = System.Drawing.Color.Green;
            this.botonPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botonPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPlay.Location = new System.Drawing.Point(1009, 3);
            this.botonPlay.Name = "botonPlay";
            this.botonPlay.Padding = new System.Windows.Forms.Padding(5);
            this.botonPlay.Size = new System.Drawing.Size(276, 95);
            this.botonPlay.TabIndex = 3;
            this.botonPlay.Text = "Play";
            this.botonPlay.UseVisualStyleBackColor = false;
            this.botonPlay.Click += new System.EventHandler(this.botonPlayClick);
            // 
            // botonNextStep
            // 
            this.botonNextStep.AutoSize = true;
            this.botonNextStep.BackColor = System.Drawing.Color.Gold;
            this.botonNextStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botonNextStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonNextStep.Location = new System.Drawing.Point(727, 3);
            this.botonNextStep.Name = "botonNextStep";
            this.botonNextStep.Padding = new System.Windows.Forms.Padding(5);
            this.botonNextStep.Size = new System.Drawing.Size(276, 95);
            this.botonNextStep.TabIndex = 2;
            this.botonNextStep.Text = "Next Step";
            this.botonNextStep.Enabled = false;
            this.botonNextStep.UseVisualStyleBackColor = false;
            this.botonNextStep.Click += new System.EventHandler(this.botonNextStep_Click);
            // 
            // botonStart
            // 
            this.botonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.botonStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonStart.Location = new System.Drawing.Point(363, 3);
            this.botonStart.Name = "botonStart";
            this.botonStart.Padding = new System.Windows.Forms.Padding(5);
            this.botonStart.Size = new System.Drawing.Size(358, 95);
            this.botonStart.TabIndex = 1;
            this.botonStart.Text = "Start";
            this.botonStart.UseVisualStyleBackColor = false;
            this.botonStart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.botonStart_MouseClick);
            // 
            // botonParametro
            // 
            this.botonParametro.AutoSize = true;
            this.botonParametro.BackColor = System.Drawing.Color.Blue;
            this.botonParametro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botonParametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonParametro.Location = new System.Drawing.Point(3, 3);
            this.botonParametro.Name = "botonParametro";
            this.botonParametro.Padding = new System.Windows.Forms.Padding(5);
            this.botonParametro.Size = new System.Drawing.Size(354, 95);
            this.botonParametro.TabIndex = 0;
            this.botonParametro.Text = "Parametros";
            this.botonParametro.UseVisualStyleBackColor = false;
            this.botonParametro.Click += new System.EventHandler(this.botonParametro_Click);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.AliceBlue;
            this.header.Controls.Add(this.labelTituloSafari);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(2318, 100);
            this.header.TabIndex = 0;
            // 
            // labelTituloSafari
            // 
            this.labelTituloSafari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTituloSafari.Location = new System.Drawing.Point(0, 0);
            this.labelTituloSafari.Name = "labelTituloSafari";
            this.labelTituloSafari.Size = new System.Drawing.Size(2318, 100);
            this.labelTituloSafari.TabIndex = 0;
            this.labelTituloSafari.Text = "Safari";
            this.labelTituloSafari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(2318, 1054);
            this.Controls.Add(this.PanelContenedor);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MyForm_Load);
            this.PanelContenedor.ResumeLayout(false);
            this.panelBotonera.ResumeLayout(false);
            this.panelBotonera.PerformLayout();
            this.header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel PanelContenedor;
        private Panel header;
        private Label labelTituloSafari;
        private TableLayoutPanel panelBotonera;
        private Button botonParametro;
        private Button botonModoLento;
        private Button botonStop;
        private Button botonPause;
        private Button botonPlay;
        private Button botonNextStep;
        private Button botonStart;
        private Panel panelMapa;
    }
}
