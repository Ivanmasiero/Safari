using Safari.services.interfaces;
using System.Windows.Forms;

namespace Safari.view.ventanasModales
{
    partial class ParametroForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.contenedor = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelBoton = new System.Windows.Forms.Panel();
            this.tablaBoton = new System.Windows.Forms.TableLayoutPanel();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.panelParametos = new System.Windows.Forms.Panel();
            this.tablaArbusto = new System.Windows.Forms.TableLayoutPanel();
            this.nTamaño = new System.Windows.Forms.NumericUpDown();
            this.lTamaño = new System.Windows.Forms.Label();
            this.tablaTrArbusto = new System.Windows.Forms.TableLayoutPanel();
            this.nTrArbusto = new System.Windows.Forms.NumericUpDown();
            this.lTrArbusto = new System.Windows.Forms.Label();
            this.lArbusto = new System.Windows.Forms.Label();
            this.tablaParametroLeon = new System.Windows.Forms.TableLayoutPanel();
            this.tablaVLeon = new System.Windows.Forms.TableLayoutPanel();
            this.nVLeon = new System.Windows.Forms.NumericUpDown();
            this.lVLeon = new System.Windows.Forms.Label();
            this.tablaHmLeon = new System.Windows.Forms.TableLayoutPanel();
            this.nHmLeon = new System.Windows.Forms.NumericUpDown();
            this.lHmLeon = new System.Windows.Forms.Label();
            this.tablaTrLeon = new System.Windows.Forms.TableLayoutPanel();
            this.nTrLeon = new System.Windows.Forms.NumericUpDown();
            this.lTrLeon = new System.Windows.Forms.Label();
            this.lLeones = new System.Windows.Forms.Label();
            this.tablaParametroGacela = new System.Windows.Forms.TableLayoutPanel();
            this.tablaVGacela = new System.Windows.Forms.TableLayoutPanel();
            this.nVGacela = new System.Windows.Forms.NumericUpDown();
            this.lVGacela = new System.Windows.Forms.Label();
            this.tablaHmGacela = new System.Windows.Forms.TableLayoutPanel();
            this.nMhGacela = new System.Windows.Forms.NumericUpDown();
            this.lMhGacela = new System.Windows.Forms.Label();
            this.tablaTrGacela = new System.Windows.Forms.TableLayoutPanel();
            this.nTrGacela = new System.Windows.Forms.NumericUpDown();
            this.lTrGacela = new System.Windows.Forms.Label();
            this.lGacelas = new System.Windows.Forms.Label();
            this.panelCantidades = new System.Windows.Forms.Panel();
            this.tablaCantidades = new System.Windows.Forms.TableLayoutPanel();
            this.tableCantidadArbustos = new System.Windows.Forms.TableLayoutPanel();
            this.nCantidadArbustos = new System.Windows.Forms.NumericUpDown();
            this.lCantidadArbustos = new System.Windows.Forms.Label();
            this.tablaCantidadLeones = new System.Windows.Forms.TableLayoutPanel();
            this.nCantidadLeones = new System.Windows.Forms.NumericUpDown();
            this.lCantidadLeones = new System.Windows.Forms.Label();
            this.tablaCantidadGacela = new System.Windows.Forms.TableLayoutPanel();
            this.nCantidadGacela = new System.Windows.Forms.NumericUpDown();
            this.lCantidadGacela = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelParametro = new System.Windows.Forms.Label();
            this.contenedor.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelBoton.SuspendLayout();
            this.tablaBoton.SuspendLayout();
            this.panelParametos.SuspendLayout();
            this.tablaArbusto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nTamaño)).BeginInit();
            this.tablaTrArbusto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nTrArbusto)).BeginInit();
            this.tablaParametroLeon.SuspendLayout();
            this.tablaVLeon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nVLeon)).BeginInit();
            this.tablaHmLeon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHmLeon)).BeginInit();
            this.tablaTrLeon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nTrLeon)).BeginInit();
            this.tablaParametroGacela.SuspendLayout();
            this.tablaVGacela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nVGacela)).BeginInit();
            this.tablaHmGacela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMhGacela)).BeginInit();
            this.tablaTrGacela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nTrGacela)).BeginInit();
            this.panelCantidades.SuspendLayout();
            this.tablaCantidades.SuspendLayout();
            this.tableCantidadArbustos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCantidadArbustos)).BeginInit();
            this.tablaCantidadLeones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCantidadLeones)).BeginInit();
            this.tablaCantidadGacela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCantidadGacela)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.contenedor.Controls.Add(this.panelMain);
            this.contenedor.Controls.Add(this.panelHeader);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 0);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1602, 847);
            this.contenedor.TabIndex = 0;
            this.contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.contenedor_Paint);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelBoton);
            this.panelMain.Controls.Add(this.panelParametos);
            this.panelMain.Controls.Add(this.panelCantidades);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 100);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1602, 747);
            this.panelMain.TabIndex = 1;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // panelBoton
            // 
            this.panelBoton.Controls.Add(this.tablaBoton);
            this.panelBoton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBoton.Location = new System.Drawing.Point(0, 647);
            this.panelBoton.Name = "panelBoton";
            this.panelBoton.Size = new System.Drawing.Size(1602, 100);
            this.panelBoton.TabIndex = 2;
            // 
            // tablaBoton
            // 
            this.tablaBoton.ColumnCount = 1;
            this.tablaBoton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablaBoton.Controls.Add(this.botonGuardar, 0, 0);
            this.tablaBoton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaBoton.Location = new System.Drawing.Point(0, 0);
            this.tablaBoton.Name = "tablaBoton";
            this.tablaBoton.RowCount = 1;
            this.tablaBoton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablaBoton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tablaBoton.Size = new System.Drawing.Size(1602, 100);
            this.tablaBoton.TabIndex = 0;
            // 
            // botonGuardar
            // 
            this.botonGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonGuardar.AutoSize = true;
            this.botonGuardar.Location = new System.Drawing.Point(587, 15);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(428, 70);
            this.botonGuardar.TabIndex = 1;
            this.botonGuardar.Text = "Guardar parametros";
            this.botonGuardar.UseVisualStyleBackColor = true;
            // 
            // panelParametos
            // 
            this.panelParametos.Controls.Add(this.tablaArbusto);
            this.panelParametos.Controls.Add(this.tablaParametroLeon);
            this.panelParametos.Controls.Add(this.tablaParametroGacela);
            this.panelParametos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelParametos.Location = new System.Drawing.Point(0, 100);
            this.panelParametos.Name = "panelParametos";
            this.panelParametos.Size = new System.Drawing.Size(1602, 647);
            this.panelParametos.TabIndex = 1;
            // 
            // tablaArbusto
            // 
            this.tablaArbusto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tablaArbusto.ColumnCount = 4;
            this.tablaArbusto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablaArbusto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablaArbusto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablaArbusto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablaArbusto.Controls.Add(this.nTamaño, 3, 0);
            this.tablaArbusto.Controls.Add(this.lTamaño, 2, 0);
            this.tablaArbusto.Controls.Add(this.tablaTrArbusto, 1, 0);
            this.tablaArbusto.Controls.Add(this.lArbusto, 0, 0);
            this.tablaArbusto.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablaArbusto.Location = new System.Drawing.Point(0, 367);
            this.tablaArbusto.Name = "tablaArbusto";
            this.tablaArbusto.RowCount = 1;
            this.tablaArbusto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablaArbusto.Size = new System.Drawing.Size(1602, 183);
            this.tablaArbusto.TabIndex = 2;
            // 
            // nTamaño
            // 
            this.nTamaño.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nTamaño.Location = new System.Drawing.Point(1341, 76);
            this.nTamaño.Name = "nTamaño";
            this.nTamaño.Size = new System.Drawing.Size(120, 31);
            this.nTamaño.TabIndex = 3;
            // 
            // lTamaño
            // 
            this.lTamaño.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lTamaño.AutoSize = true;
            this.lTamaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTamaño.Location = new System.Drawing.Point(929, 73);
            this.lTamaño.Name = "lTamaño";
            this.lTamaño.Size = new System.Drawing.Size(142, 37);
            this.lTamaño.TabIndex = 2;
            this.lTamaño.Text = "Tamaño";
            // 
            // tablaTrArbusto
            // 
            this.tablaTrArbusto.ColumnCount = 2;
            this.tablaTrArbusto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaTrArbusto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaTrArbusto.Controls.Add(this.nTrArbusto, 1, 0);
            this.tablaTrArbusto.Controls.Add(this.lTrArbusto, 0, 0);
            this.tablaTrArbusto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaTrArbusto.Location = new System.Drawing.Point(403, 3);
            this.tablaTrArbusto.Name = "tablaTrArbusto";
            this.tablaTrArbusto.RowCount = 1;
            this.tablaTrArbusto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaTrArbusto.Size = new System.Drawing.Size(394, 177);
            this.tablaTrArbusto.TabIndex = 1;
            // 
            // nTrArbusto
            // 
            this.nTrArbusto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nTrArbusto.Location = new System.Drawing.Point(235, 73);
            this.nTrArbusto.Name = "nTrArbusto";
            this.nTrArbusto.Size = new System.Drawing.Size(120, 31);
            this.nTrArbusto.TabIndex = 0;
            // 
            // lTrArbusto
            // 
            this.lTrArbusto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lTrArbusto.AutoSize = true;
            this.lTrArbusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTrArbusto.Location = new System.Drawing.Point(19, 62);
            this.lTrArbusto.Name = "lTrArbusto";
            this.lTrArbusto.Size = new System.Drawing.Size(158, 52);
            this.lTrArbusto.TabIndex = 1;
            this.lTrArbusto.Text = "Tiempo de Reproducción";
            // 
            // lArbusto
            // 
            this.lArbusto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lArbusto.AutoSize = true;
            this.lArbusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lArbusto.Location = new System.Drawing.Point(123, 73);
            this.lArbusto.Name = "lArbusto";
            this.lArbusto.Size = new System.Drawing.Size(153, 37);
            this.lArbusto.TabIndex = 0;
            this.lArbusto.Text = "Arbustos";
            // 
            // tablaParametroLeon
            // 
            this.tablaParametroLeon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tablaParametroLeon.ColumnCount = 4;
            this.tablaParametroLeon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablaParametroLeon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablaParametroLeon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablaParametroLeon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablaParametroLeon.Controls.Add(this.tablaVLeon, 3, 0);
            this.tablaParametroLeon.Controls.Add(this.tablaHmLeon, 2, 0);
            this.tablaParametroLeon.Controls.Add(this.tablaTrLeon, 1, 0);
            this.tablaParametroLeon.Controls.Add(this.lLeones, 0, 0);
            this.tablaParametroLeon.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablaParametroLeon.Location = new System.Drawing.Point(0, 184);
            this.tablaParametroLeon.Name = "tablaParametroLeon";
            this.tablaParametroLeon.RowCount = 1;
            this.tablaParametroLeon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablaParametroLeon.Size = new System.Drawing.Size(1602, 183);
            this.tablaParametroLeon.TabIndex = 1;
            // 
            // tablaVLeon
            // 
            this.tablaVLeon.ColumnCount = 2;
            this.tablaVLeon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaVLeon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaVLeon.Controls.Add(this.nVLeon, 1, 0);
            this.tablaVLeon.Controls.Add(this.lVLeon, 0, 0);
            this.tablaVLeon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaVLeon.Location = new System.Drawing.Point(1203, 3);
            this.tablaVLeon.Name = "tablaVLeon";
            this.tablaVLeon.RowCount = 1;
            this.tablaVLeon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaVLeon.Size = new System.Drawing.Size(396, 177);
            this.tablaVLeon.TabIndex = 3;
            // 
            // nVLeon
            // 
            this.nVLeon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nVLeon.Location = new System.Drawing.Point(237, 73);
            this.nVLeon.Name = "nVLeon";
            this.nVLeon.Size = new System.Drawing.Size(120, 31);
            this.nVLeon.TabIndex = 0;
            // 
            // lVLeon
            // 
            this.lVLeon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lVLeon.AutoSize = true;
            this.lVLeon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVLeon.Location = new System.Drawing.Point(40, 75);
            this.lVLeon.Name = "lVLeon";
            this.lVLeon.Size = new System.Drawing.Size(117, 26);
            this.lVLeon.TabIndex = 1;
            this.lVLeon.Text = "Velocidad";
            // 
            // tablaHmLeon
            // 
            this.tablaHmLeon.ColumnCount = 2;
            this.tablaHmLeon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaHmLeon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaHmLeon.Controls.Add(this.nHmLeon, 1, 0);
            this.tablaHmLeon.Controls.Add(this.lHmLeon, 0, 0);
            this.tablaHmLeon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaHmLeon.Location = new System.Drawing.Point(803, 3);
            this.tablaHmLeon.Name = "tablaHmLeon";
            this.tablaHmLeon.RowCount = 1;
            this.tablaHmLeon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaHmLeon.Size = new System.Drawing.Size(394, 177);
            this.tablaHmLeon.TabIndex = 2;
            // 
            // nHmLeon
            // 
            this.nHmLeon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nHmLeon.Location = new System.Drawing.Point(235, 73);
            this.nHmLeon.Name = "nHmLeon";
            this.nHmLeon.Size = new System.Drawing.Size(120, 31);
            this.nHmLeon.TabIndex = 0;
            // 
            // lHmLeon
            // 
            this.lHmLeon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lHmLeon.AutoSize = true;
            this.lHmLeon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHmLeon.Location = new System.Drawing.Point(5, 75);
            this.lHmLeon.Name = "lHmLeon";
            this.lHmLeon.Size = new System.Drawing.Size(186, 26);
            this.lHmLeon.TabIndex = 1;
            this.lHmLeon.Text = "Hambre Máxima";
            // 
            // tablaTrLeon
            // 
            this.tablaTrLeon.ColumnCount = 2;
            this.tablaTrLeon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaTrLeon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaTrLeon.Controls.Add(this.nTrLeon, 1, 0);
            this.tablaTrLeon.Controls.Add(this.lTrLeon, 0, 0);
            this.tablaTrLeon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaTrLeon.Location = new System.Drawing.Point(403, 3);
            this.tablaTrLeon.Name = "tablaTrLeon";
            this.tablaTrLeon.RowCount = 1;
            this.tablaTrLeon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaTrLeon.Size = new System.Drawing.Size(394, 177);
            this.tablaTrLeon.TabIndex = 1;
            // 
            // nTrLeon
            // 
            this.nTrLeon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nTrLeon.Location = new System.Drawing.Point(235, 73);
            this.nTrLeon.Name = "nTrLeon";
            this.nTrLeon.Size = new System.Drawing.Size(120, 31);
            this.nTrLeon.TabIndex = 0;
            // 
            // lTrLeon
            // 
            this.lTrLeon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lTrLeon.AutoSize = true;
            this.lTrLeon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTrLeon.Location = new System.Drawing.Point(19, 62);
            this.lTrLeon.Name = "lTrLeon";
            this.lTrLeon.Size = new System.Drawing.Size(158, 52);
            this.lTrLeon.TabIndex = 1;
            this.lTrLeon.Text = "Tiempo de Reproducción";
            // 
            // lLeones
            // 
            this.lLeones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lLeones.AutoSize = true;
            this.lLeones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLeones.Location = new System.Drawing.Point(136, 73);
            this.lLeones.Name = "lLeones";
            this.lLeones.Size = new System.Drawing.Size(127, 37);
            this.lLeones.TabIndex = 0;
            this.lLeones.Text = "Leones";
            // 
            // tablaParametroGacela
            // 
            this.tablaParametroGacela.ColumnCount = 4;
            this.tablaParametroGacela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablaParametroGacela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablaParametroGacela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablaParametroGacela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablaParametroGacela.Controls.Add(this.tablaVGacela, 3, 0);
            this.tablaParametroGacela.Controls.Add(this.tablaHmGacela, 2, 0);
            this.tablaParametroGacela.Controls.Add(this.tablaTrGacela, 1, 0);
            this.tablaParametroGacela.Controls.Add(this.lGacelas, 0, 0);
            this.tablaParametroGacela.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablaParametroGacela.Location = new System.Drawing.Point(0, 0);
            this.tablaParametroGacela.Name = "tablaParametroGacela";
            this.tablaParametroGacela.RowCount = 1;
            this.tablaParametroGacela.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablaParametroGacela.Size = new System.Drawing.Size(1602, 184);
            this.tablaParametroGacela.TabIndex = 0;
            this.tablaParametroGacela.Paint += new System.Windows.Forms.PaintEventHandler(this.tablaParametroGacela_Paint);
            // 
            // tablaVGacela
            // 
            this.tablaVGacela.ColumnCount = 2;
            this.tablaVGacela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaVGacela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaVGacela.Controls.Add(this.nVGacela, 1, 0);
            this.tablaVGacela.Controls.Add(this.lVGacela, 0, 0);
            this.tablaVGacela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaVGacela.Location = new System.Drawing.Point(1203, 3);
            this.tablaVGacela.Name = "tablaVGacela";
            this.tablaVGacela.RowCount = 1;
            this.tablaVGacela.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaVGacela.Size = new System.Drawing.Size(396, 178);
            this.tablaVGacela.TabIndex = 3;
            // 
            // nVGacela
            // 
            this.nVGacela.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nVGacela.Location = new System.Drawing.Point(237, 73);
            this.nVGacela.Name = "nVGacela";
            this.nVGacela.Size = new System.Drawing.Size(120, 31);
            this.nVGacela.TabIndex = 0;
            // 
            // lVGacela
            // 
            this.lVGacela.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lVGacela.AutoSize = true;
            this.lVGacela.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVGacela.Location = new System.Drawing.Point(40, 76);
            this.lVGacela.Name = "lVGacela";
            this.lVGacela.Size = new System.Drawing.Size(117, 26);
            this.lVGacela.TabIndex = 1;
            this.lVGacela.Text = "Velocidad";
            // 
            // tablaHmGacela
            // 
            this.tablaHmGacela.ColumnCount = 2;
            this.tablaHmGacela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaHmGacela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaHmGacela.Controls.Add(this.nMhGacela, 1, 0);
            this.tablaHmGacela.Controls.Add(this.lMhGacela, 0, 0);
            this.tablaHmGacela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaHmGacela.Location = new System.Drawing.Point(803, 3);
            this.tablaHmGacela.Name = "tablaHmGacela";
            this.tablaHmGacela.RowCount = 1;
            this.tablaHmGacela.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaHmGacela.Size = new System.Drawing.Size(394, 178);
            this.tablaHmGacela.TabIndex = 2;
            // 
            // nMhGacela
            // 
            this.nMhGacela.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nMhGacela.Location = new System.Drawing.Point(235, 73);
            this.nMhGacela.Name = "nMhGacela";
            this.nMhGacela.Size = new System.Drawing.Size(120, 31);
            this.nMhGacela.TabIndex = 0;
            // 
            // lMhGacela
            // 
            this.lMhGacela.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lMhGacela.AutoSize = true;
            this.lMhGacela.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMhGacela.Location = new System.Drawing.Point(5, 76);
            this.lMhGacela.Name = "lMhGacela";
            this.lMhGacela.Size = new System.Drawing.Size(186, 26);
            this.lMhGacela.TabIndex = 1;
            this.lMhGacela.Text = "Hambre Máxima";
            // 
            // tablaTrGacela
            // 
            this.tablaTrGacela.ColumnCount = 2;
            this.tablaTrGacela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaTrGacela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaTrGacela.Controls.Add(this.nTrGacela, 1, 0);
            this.tablaTrGacela.Controls.Add(this.lTrGacela, 0, 0);
            this.tablaTrGacela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaTrGacela.Location = new System.Drawing.Point(403, 3);
            this.tablaTrGacela.Name = "tablaTrGacela";
            this.tablaTrGacela.RowCount = 1;
            this.tablaTrGacela.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaTrGacela.Size = new System.Drawing.Size(394, 178);
            this.tablaTrGacela.TabIndex = 1;
            // 
            // nTrGacela
            // 
            this.nTrGacela.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nTrGacela.Location = new System.Drawing.Point(235, 73);
            this.nTrGacela.Name = "nTrGacela";
            this.nTrGacela.Size = new System.Drawing.Size(120, 31);
            this.nTrGacela.TabIndex = 0;
            // 
            // lTrGacela
            // 
            this.lTrGacela.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lTrGacela.AutoSize = true;
            this.lTrGacela.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTrGacela.Location = new System.Drawing.Point(19, 63);
            this.lTrGacela.Name = "lTrGacela";
            this.lTrGacela.Size = new System.Drawing.Size(158, 52);
            this.lTrGacela.TabIndex = 1;
            this.lTrGacela.Text = "Tiempo de Reproducción";
            // 
            // lGacelas
            // 
            this.lGacelas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lGacelas.AutoSize = true;
            this.lGacelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGacelas.Location = new System.Drawing.Point(129, 73);
            this.lGacelas.Name = "lGacelas";
            this.lGacelas.Size = new System.Drawing.Size(141, 37);
            this.lGacelas.TabIndex = 0;
            this.lGacelas.Text = "Gacelas";
            // 
            // panelCantidades
            // 
            this.panelCantidades.Controls.Add(this.tablaCantidades);
            this.panelCantidades.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCantidades.Location = new System.Drawing.Point(0, 0);
            this.panelCantidades.Name = "panelCantidades";
            this.panelCantidades.Size = new System.Drawing.Size(1602, 100);
            this.panelCantidades.TabIndex = 0;
            // 
            // tablaCantidades
            // 
            this.tablaCantidades.ColumnCount = 3;
            this.tablaCantidades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tablaCantidades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tablaCantidades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tablaCantidades.Controls.Add(this.tableCantidadArbustos, 2, 0);
            this.tablaCantidades.Controls.Add(this.tablaCantidadLeones, 1, 0);
            this.tablaCantidades.Controls.Add(this.tablaCantidadGacela, 0, 0);
            this.tablaCantidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaCantidades.Location = new System.Drawing.Point(0, 0);
            this.tablaCantidades.Name = "tablaCantidades";
            this.tablaCantidades.RowCount = 1;
            this.tablaCantidades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaCantidades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaCantidades.Size = new System.Drawing.Size(1602, 100);
            this.tablaCantidades.TabIndex = 0;
            // 
            // tableCantidadArbustos
            // 
            this.tableCantidadArbustos.ColumnCount = 2;
            this.tableCantidadArbustos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableCantidadArbustos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableCantidadArbustos.Controls.Add(this.nCantidadArbustos, 1, 0);
            this.tableCantidadArbustos.Controls.Add(this.lCantidadArbustos, 0, 0);
            this.tableCantidadArbustos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableCantidadArbustos.Location = new System.Drawing.Point(1071, 3);
            this.tableCantidadArbustos.Name = "tableCantidadArbustos";
            this.tableCantidadArbustos.RowCount = 1;
            this.tableCantidadArbustos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableCantidadArbustos.Size = new System.Drawing.Size(528, 94);
            this.tableCantidadArbustos.TabIndex = 2;
            // 
            // nCantidadArbustos
            // 
            this.nCantidadArbustos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nCantidadArbustos.Location = new System.Drawing.Point(336, 31);
            this.nCantidadArbustos.Name = "nCantidadArbustos";
            this.nCantidadArbustos.Size = new System.Drawing.Size(120, 31);
            this.nCantidadArbustos.TabIndex = 0;
            // 
            // lCantidadArbustos
            // 
            this.lCantidadArbustos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lCantidadArbustos.AutoSize = true;
            this.lCantidadArbustos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCantidadArbustos.Location = new System.Drawing.Point(11, 34);
            this.lCantidadArbustos.Name = "lCantidadArbustos";
            this.lCantidadArbustos.Size = new System.Drawing.Size(241, 26);
            this.lCantidadArbustos.TabIndex = 1;
            this.lCantidadArbustos.Text = "Cantidad de Arbustos";
            // 
            // tablaCantidadLeones
            // 
            this.tablaCantidadLeones.ColumnCount = 2;
            this.tablaCantidadLeones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaCantidadLeones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaCantidadLeones.Controls.Add(this.nCantidadLeones, 1, 0);
            this.tablaCantidadLeones.Controls.Add(this.lCantidadLeones, 0, 0);
            this.tablaCantidadLeones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaCantidadLeones.Location = new System.Drawing.Point(537, 3);
            this.tablaCantidadLeones.Name = "tablaCantidadLeones";
            this.tablaCantidadLeones.RowCount = 1;
            this.tablaCantidadLeones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaCantidadLeones.Size = new System.Drawing.Size(528, 94);
            this.tablaCantidadLeones.TabIndex = 1;
            // 
            // nCantidadLeones
            // 
            this.nCantidadLeones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nCantidadLeones.Location = new System.Drawing.Point(336, 31);
            this.nCantidadLeones.Name = "nCantidadLeones";
            this.nCantidadLeones.Size = new System.Drawing.Size(120, 31);
            this.nCantidadLeones.TabIndex = 0;
            // 
            // lCantidadLeones
            // 
            this.lCantidadLeones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lCantidadLeones.AutoSize = true;
            this.lCantidadLeones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCantidadLeones.Location = new System.Drawing.Point(23, 34);
            this.lCantidadLeones.Name = "lCantidadLeones";
            this.lCantidadLeones.Size = new System.Drawing.Size(217, 26);
            this.lCantidadLeones.TabIndex = 1;
            this.lCantidadLeones.Text = "Cantidad de leones";
            // 
            // tablaCantidadGacela
            // 
            this.tablaCantidadGacela.ColumnCount = 2;
            this.tablaCantidadGacela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaCantidadGacela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaCantidadGacela.Controls.Add(this.nCantidadGacela, 1, 0);
            this.tablaCantidadGacela.Controls.Add(this.lCantidadGacela, 0, 0);
            this.tablaCantidadGacela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaCantidadGacela.Location = new System.Drawing.Point(3, 3);
            this.tablaCantidadGacela.Name = "tablaCantidadGacela";
            this.tablaCantidadGacela.RowCount = 1;
            this.tablaCantidadGacela.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaCantidadGacela.Size = new System.Drawing.Size(528, 94);
            this.tablaCantidadGacela.TabIndex = 0;
            // 
            // nCantidadGacela
            // 
            this.nCantidadGacela.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nCantidadGacela.Location = new System.Drawing.Point(336, 31);
            this.nCantidadGacela.Name = "nCantidadGacela";
            this.nCantidadGacela.Size = new System.Drawing.Size(120, 31);
            this.nCantidadGacela.TabIndex = 0;
            this.nCantidadGacela.ValueChanged += new System.EventHandler(this.nCantidadGacela_ValueChanged);
            // 
            // lCantidadGacela
            // 
            this.lCantidadGacela.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lCantidadGacela.AutoSize = true;
            this.lCantidadGacela.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCantidadGacela.Location = new System.Drawing.Point(17, 34);
            this.lCantidadGacela.Name = "lCantidadGacela";
            this.lCantidadGacela.Size = new System.Drawing.Size(229, 26);
            this.lCantidadGacela.TabIndex = 1;
            this.lCantidadGacela.Text = "Cantidad de gacelas";
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.labelParametro);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1602, 100);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelParametro
            // 
            this.labelParametro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelParametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParametro.Location = new System.Drawing.Point(0, 0);
            this.labelParametro.Name = "labelParametro";
            this.labelParametro.Size = new System.Drawing.Size(1602, 100);
            this.labelParametro.TabIndex = 0;
            this.labelParametro.Text = "Parametros";
            this.labelParametro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ParametroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1602, 847);
            this.Controls.Add(this.contenedor);
            this.Name = "ParametroForm";
            this.Text = "ParametroForm";
            this.contenedor.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelBoton.ResumeLayout(false);
            this.tablaBoton.ResumeLayout(false);
            this.tablaBoton.PerformLayout();
            this.panelParametos.ResumeLayout(false);
            this.tablaArbusto.ResumeLayout(false);
            this.tablaArbusto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nTamaño)).EndInit();
            this.tablaTrArbusto.ResumeLayout(false);
            this.tablaTrArbusto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nTrArbusto)).EndInit();
            this.tablaParametroLeon.ResumeLayout(false);
            this.tablaParametroLeon.PerformLayout();
            this.tablaVLeon.ResumeLayout(false);
            this.tablaVLeon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nVLeon)).EndInit();
            this.tablaHmLeon.ResumeLayout(false);
            this.tablaHmLeon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHmLeon)).EndInit();
            this.tablaTrLeon.ResumeLayout(false);
            this.tablaTrLeon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nTrLeon)).EndInit();
            this.tablaParametroGacela.ResumeLayout(false);
            this.tablaParametroGacela.PerformLayout();
            this.tablaVGacela.ResumeLayout(false);
            this.tablaVGacela.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nVGacela)).EndInit();
            this.tablaHmGacela.ResumeLayout(false);
            this.tablaHmGacela.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMhGacela)).EndInit();
            this.tablaTrGacela.ResumeLayout(false);
            this.tablaTrGacela.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nTrGacela)).EndInit();
            this.panelCantidades.ResumeLayout(false);
            this.tablaCantidades.ResumeLayout(false);
            this.tableCantidadArbustos.ResumeLayout(false);
            this.tableCantidadArbustos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCantidadArbustos)).EndInit();
            this.tablaCantidadLeones.ResumeLayout(false);
            this.tablaCantidadLeones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCantidadLeones)).EndInit();
            this.tablaCantidadGacela.ResumeLayout(false);
            this.tablaCantidadGacela.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCantidadGacela)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contenedor;
        private Panel panelHeader;
        private Label labelParametro;
        private Panel panelMain;
        private Panel panelBoton;
        private Panel panelParametos;
        private Panel panelCantidades;
        private TableLayoutPanel tablaCantidades;
        private TableLayoutPanel tablaCantidadGacela;
        private NumericUpDown nCantidadGacela;
        private TableLayoutPanel tablaCantidadLeones;
        private NumericUpDown nCantidadLeones;
        private Label lCantidadLeones;
        private Label lCantidadGacela;
        private TableLayoutPanel tableCantidadArbustos;
        private NumericUpDown nCantidadArbustos;
        private Label lCantidadArbustos;
        private TableLayoutPanel tablaParametroGacela;
        private TableLayoutPanel tablaTrGacela;
        private NumericUpDown nTrGacela;
        private Label lTrGacela;
        private Label lGacelas;
        private TableLayoutPanel tablaParametroLeon;
        private TableLayoutPanel tablaVLeon;
        private NumericUpDown nVLeon;
        private Label lVLeon;
        private TableLayoutPanel tablaHmLeon;
        private NumericUpDown nHmLeon;
        private Label lHmLeon;
        private TableLayoutPanel tablaTrLeon;
        private NumericUpDown nTrLeon;
        private Label lTrLeon;
        private Label lLeones;
        private TableLayoutPanel tablaVGacela;
        private NumericUpDown nVGacela;
        private Label lVGacela;
        private TableLayoutPanel tablaHmGacela;
        private NumericUpDown nMhGacela;
        private Label lMhGacela;
        private TableLayoutPanel tablaArbusto;
        private TableLayoutPanel tablaTrArbusto;
        private NumericUpDown nTrArbusto;
        private Label lTrArbusto;
        private Label lArbusto;
        private TableLayoutPanel tablaBoton;
        private Button botonGuardar;
        private NumericUpDown nTamaño;
        private Label lTamaño;
    }
}