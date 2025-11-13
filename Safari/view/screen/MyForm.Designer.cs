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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyForm));
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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStart = new System.Windows.Forms.ToolStripButton();
            this.toolPlay = new System.Windows.Forms.ToolStripButton();
            this.toolPause = new System.Windows.Forms.ToolStripButton();
            this.toolStop = new System.Windows.Forms.ToolStripButton();
            this.toolSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStats = new System.Windows.Forms.ToolStripButton();
            this.toolExit = new System.Windows.Forms.ToolStripButton();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoSafariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.párametrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarStats = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeSafariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlesManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelContenedor.SuspendLayout();
            this.panelBotonera.SuspendLayout();
            this.header.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Controls.Add(this.panelMapa);
            this.PanelContenedor.Controls.Add(this.panelBotonera);
            this.PanelContenedor.Controls.Add(this.header);
            this.PanelContenedor.Controls.Add(this.toolStrip);
            this.PanelContenedor.Controls.Add(this.menu);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(0, 0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(2318, 1054);
            this.PanelContenedor.TabIndex = 1;
            // 
            // panelMapa
            // 
            this.panelMapa.BackColor = System.Drawing.Color.Goldenrod;
            this.panelMapa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMapa.Location = new System.Drawing.Point(0, 283);
            this.panelMapa.Name = "panelMapa";
            this.panelMapa.Size = new System.Drawing.Size(2318, 771);
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
            this.panelBotonera.Location = new System.Drawing.Point(0, 182);
            this.panelBotonera.Margin = new System.Windows.Forms.Padding(0);
            this.panelBotonera.Name = "panelBotonera";
            this.panelBotonera.RowCount = 1;
            this.panelBotonera.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelBotonera.Size = new System.Drawing.Size(2318, 101);
            this.panelBotonera.TabIndex = 0;
            // 
            // botonModoLento
            // 
            this.botonModoLento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.botonModoLento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botonModoLento.Enabled = false;
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
            this.botonStop.BackColor = System.Drawing.Color.Red;
            this.botonStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botonStop.Enabled = false;
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
            this.botonPause.BackColor = System.Drawing.Color.Cyan;
            this.botonPause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botonPause.Enabled = false;
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
            this.botonPlay.BackColor = System.Drawing.Color.Green;
            this.botonPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botonPlay.Enabled = false;
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
            this.botonNextStep.Enabled = false;
            this.botonNextStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonNextStep.Location = new System.Drawing.Point(727, 3);
            this.botonNextStep.Name = "botonNextStep";
            this.botonNextStep.Padding = new System.Windows.Forms.Padding(5);
            this.botonNextStep.Size = new System.Drawing.Size(276, 95);
            this.botonNextStep.TabIndex = 2;
            this.botonNextStep.Text = "Next Step";
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
            this.header.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.header.Controls.Add(this.labelTituloSafari);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 82);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(2318, 100);
            this.header.TabIndex = 0;
            // 
            // labelTituloSafari
            // 
            this.labelTituloSafari.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelTituloSafari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTituloSafari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloSafari.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTituloSafari.Location = new System.Drawing.Point(0, 0);
            this.labelTituloSafari.Margin = new System.Windows.Forms.Padding(0);
            this.labelTituloSafari.Name = "labelTituloSafari";
            this.labelTituloSafari.Size = new System.Drawing.Size(2318, 100);
            this.labelTituloSafari.TabIndex = 0;
            this.labelTituloSafari.Text = "Safari";
            this.labelTituloSafari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStart,
            this.toolPlay,
            this.toolPause,
            this.toolStop,
            this.toolSettings,
            this.toolStats,
            this.toolExit});
            this.toolStrip.Location = new System.Drawing.Point(0, 40);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(2318, 42);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStart
            // 
            this.toolStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStart.Image = ((System.Drawing.Image)(resources.GetObject("toolStart.Image")));
            this.toolStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStart.Name = "toolStart";
            this.toolStart.Size = new System.Drawing.Size(46, 36);
            this.toolStart.Text = "Start";
            this.toolStart.Click += new System.EventHandler(this.toolStart_Click);
            // 
            // toolPlay
            // 
            this.toolPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPlay.Enabled = false;
            this.toolPlay.Image = global::Safari.Properties.Resources.play;
            this.toolPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPlay.Margin = new System.Windows.Forms.Padding(10, 2, 10, 4);
            this.toolPlay.Name = "toolPlay";
            this.toolPlay.Size = new System.Drawing.Size(46, 36);
            this.toolPlay.Text = "Play";
            this.toolPlay.Click += new System.EventHandler(this.toolPlay_Click);
            // 
            // toolPause
            // 
            this.toolPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPause.Enabled = false;
            this.toolPause.Image = global::Safari.Properties.Resources.pause;
            this.toolPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPause.Margin = new System.Windows.Forms.Padding(10, 2, 10, 4);
            this.toolPause.Name = "toolPause";
            this.toolPause.Size = new System.Drawing.Size(46, 36);
            this.toolPause.Text = "Pause";
            this.toolPause.Click += new System.EventHandler(this.toolPause_Click);
            // 
            // toolStop
            // 
            this.toolStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStop.Enabled = false;
            this.toolStop.Image = global::Safari.Properties.Resources.stop;
            this.toolStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStop.Margin = new System.Windows.Forms.Padding(10, 2, 10, 4);
            this.toolStop.Name = "toolStop";
            this.toolStop.Size = new System.Drawing.Size(46, 36);
            this.toolStop.Text = "Stop";
            this.toolStop.Click += new System.EventHandler(this.toolStop_Click);
            // 
            // toolSettings
            // 
            this.toolSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSettings.Image = global::Safari.Properties.Resources.setting;
            this.toolSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSettings.Margin = new System.Windows.Forms.Padding(10, 2, 10, 4);
            this.toolSettings.Name = "toolSettings";
            this.toolSettings.Size = new System.Drawing.Size(46, 36);
            this.toolSettings.Text = "Settings";
            this.toolSettings.Click += new System.EventHandler(this.toolSettings_Click);
            // 
            // toolStats
            // 
            this.toolStats.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStats.Enabled = false;
            this.toolStats.Image = global::Safari.Properties.Resources.stats;
            this.toolStats.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStats.Margin = new System.Windows.Forms.Padding(10, 2, 10, 4);
            this.toolStats.Name = "toolStats";
            this.toolStats.Size = new System.Drawing.Size(46, 36);
            this.toolStats.Text = "Stats";
            this.toolStats.Click += new System.EventHandler(this.toolStats_Click);
            // 
            // toolExit
            // 
            this.toolExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolExit.Image = global::Safari.Properties.Resources.end;
            this.toolExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolExit.Margin = new System.Windows.Forms.Padding(10, 2, 10, 4);
            this.toolExit.Name = "toolExit";
            this.toolExit.Size = new System.Drawing.Size(46, 36);
            this.toolExit.Text = "Exit";
            this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.simulacionToolStripMenuItem,
            this.verToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(2318, 40);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoSafariToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(114, 36);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoSafariToolStripMenuItem
            // 
            this.nuevoSafariToolStripMenuItem.Name = "nuevoSafariToolStripMenuItem";
            this.nuevoSafariToolStripMenuItem.Size = new System.Drawing.Size(281, 44);
            this.nuevoSafariToolStripMenuItem.Text = "Nuevo safari";
            this.nuevoSafariToolStripMenuItem.Click += new System.EventHandler(this.nuevoSafariToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(281, 44);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // simulacionToolStripMenuItem
            // 
            this.simulacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarToolStripMenuItem,
            this.pausarToolStripMenuItem,
            this.reiniciarToolStripMenuItem,
            this.párametrosToolStripMenuItem});
            this.simulacionToolStripMenuItem.Name = "simulacionToolStripMenuItem";
            this.simulacionToolStripMenuItem.Size = new System.Drawing.Size(151, 36);
            this.simulacionToolStripMenuItem.Text = "Simulación";
            // 
            // iniciarToolStripMenuItem
            // 
            this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(265, 44);
            this.iniciarToolStripMenuItem.Text = "Iniciar";
            this.iniciarToolStripMenuItem.Click += new System.EventHandler(this.iniciarToolStripMenuItem_Click);
            // 
            // pausarToolStripMenuItem
            // 
            this.pausarToolStripMenuItem.Name = "pausarToolStripMenuItem";
            this.pausarToolStripMenuItem.Size = new System.Drawing.Size(265, 44);
            this.pausarToolStripMenuItem.Text = "Pausar";
            this.pausarToolStripMenuItem.Click += new System.EventHandler(this.pausarToolStripMenuItem_Click);
            // 
            // reiniciarToolStripMenuItem
            // 
            this.reiniciarToolStripMenuItem.Name = "reiniciarToolStripMenuItem";
            this.reiniciarToolStripMenuItem.Size = new System.Drawing.Size(265, 44);
            this.reiniciarToolStripMenuItem.Text = "Reiniciar";
            this.reiniciarToolStripMenuItem.Click += new System.EventHandler(this.reiniciarToolStripMenuItem_Click);
            // 
            // párametrosToolStripMenuItem
            // 
            this.párametrosToolStripMenuItem.Name = "párametrosToolStripMenuItem";
            this.párametrosToolStripMenuItem.Size = new System.Drawing.Size(265, 44);
            this.párametrosToolStripMenuItem.Text = "Párametros";
            this.párametrosToolStripMenuItem.Click += new System.EventHandler(this.párametrosToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarStats});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(68, 36);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // mostrarStats
            // 
            this.mostrarStats.Name = "mostrarStats";
            this.mostrarStats.Size = new System.Drawing.Size(355, 44);
            this.mostrarStats.Text = "Mostrar Estádisticas";
            this.mostrarStats.Click += new System.EventHandler(this.mostrarStats_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeSafariToolStripMenuItem,
            this.controlesManualToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(101, 36);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeSafariToolStripMenuItem
            // 
            this.acercaDeSafariToolStripMenuItem.Name = "acercaDeSafariToolStripMenuItem";
            this.acercaDeSafariToolStripMenuItem.Size = new System.Drawing.Size(338, 44);
            this.acercaDeSafariToolStripMenuItem.Text = "Acerca de Safari";
            this.acercaDeSafariToolStripMenuItem.Click += new System.EventHandler(this.acercaDeSafariToolStripMenuItem_Click);
            // 
            // controlesManualToolStripMenuItem
            // 
            this.controlesManualToolStripMenuItem.Name = "controlesManualToolStripMenuItem";
            this.controlesManualToolStripMenuItem.Size = new System.Drawing.Size(338, 44);
            this.controlesManualToolStripMenuItem.Text = "Controles/Manual";
            this.controlesManualToolStripMenuItem.Click += new System.EventHandler(this.controlesManualToolStripMenuItem_Click);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(2318, 1054);
            this.Controls.Add(this.PanelContenedor);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MyForm_Load);
            this.PanelContenedor.ResumeLayout(false);
            this.PanelContenedor.PerformLayout();
            this.panelBotonera.ResumeLayout(false);
            this.panelBotonera.PerformLayout();
            this.header.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
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
        private MenuStrip menu;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem nuevoSafariToolStripMenuItem;
        private ToolStripMenuItem simulacionToolStripMenuItem;
        private ToolStripMenuItem iniciarToolStripMenuItem;
        private ToolStripMenuItem pausarToolStripMenuItem;
        private ToolStripMenuItem reiniciarToolStripMenuItem;
        private ToolStripMenuItem párametrosToolStripMenuItem;
        private ToolStripMenuItem verToolStripMenuItem;
        private ToolStripMenuItem mostrarStats;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem acercaDeSafariToolStripMenuItem;
        private ToolStripMenuItem controlesManualToolStripMenuItem;
        private ToolStrip toolStrip;
        private ToolStripButton toolPlay;
        private ToolStripButton toolPause;
        private ToolStripButton toolStop;
        private ToolStripButton toolSettings;
        private ToolStripButton toolStats;
        private ToolStripButton toolExit;
        private ToolStripButton toolStart;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}
