namespace Safari.view.ventanasModales
{
    partial class StatsForm
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
            this.tableStats = new System.Windows.Forms.TableLayoutPanel();
            this.labelCantidadSeresVivos = new System.Windows.Forms.Label();
            this.labelCantidadSeresComidos = new System.Windows.Forms.Label();
            this.labelNCantidadSeresVivos = new System.Windows.Forms.Label();
            this.labelNCantidadSeresComidos = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.tableBottom = new System.Windows.Forms.TableLayoutPanel();
            this.buttomCerrar = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.tableTitulo = new System.Windows.Forms.TableLayoutPanel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.contenedor.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.tableStats.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.tableBottom.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.tableTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.contenedor.Controls.Add(this.panelMain);
            this.contenedor.Controls.Add(this.panelBottom);
            this.contenedor.Controls.Add(this.panelHeader);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 0);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1029, 604);
            this.contenedor.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tableStats);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 100);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1029, 404);
            this.panelMain.TabIndex = 2;
            // 
            // tableStats
            // 
            this.tableStats.ColumnCount = 3;
            this.tableStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.60532F));
            this.tableStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.39468F));
            this.tableStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 539F));
            this.tableStats.Controls.Add(this.labelCantidadSeresVivos, 1, 0);
            this.tableStats.Controls.Add(this.labelCantidadSeresComidos, 1, 1);
            this.tableStats.Controls.Add(this.labelNCantidadSeresVivos, 2, 0);
            this.tableStats.Controls.Add(this.labelNCantidadSeresComidos, 2, 1);
            this.tableStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableStats.Location = new System.Drawing.Point(0, 0);
            this.tableStats.Name = "tableStats";
            this.tableStats.RowCount = 2;
            this.tableStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.45544F));
            this.tableStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.54456F));
            this.tableStats.Size = new System.Drawing.Size(1029, 303);
            this.tableStats.TabIndex = 0;
            // 
            // labelCantidadSeresVivos
            // 
            this.labelCantidadSeresVivos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCantidadSeresVivos.AutoSize = true;
            this.labelCantidadSeresVivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidadSeresVivos.Location = new System.Drawing.Point(201, 69);
            this.labelCantidadSeresVivos.Name = "labelCantidadSeresVivos";
            this.labelCantidadSeresVivos.Size = new System.Drawing.Size(266, 25);
            this.labelCantidadSeresVivos.TabIndex = 0;
            this.labelCantidadSeresVivos.Text = "Cantidad de seres vivos";
            // 
            // labelCantidadSeresComidos
            // 
            this.labelCantidadSeresComidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCantidadSeresComidos.AutoSize = true;
            this.labelCantidadSeresComidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidadSeresComidos.Location = new System.Drawing.Point(185, 221);
            this.labelCantidadSeresComidos.Name = "labelCantidadSeresComidos";
            this.labelCantidadSeresComidos.Size = new System.Drawing.Size(298, 25);
            this.labelCantidadSeresComidos.TabIndex = 1;
            this.labelCantidadSeresComidos.Text = "Cantidad de seres comidos";
            // 
            // labelNCantidadSeresVivos
            // 
            this.labelNCantidadSeresVivos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNCantidadSeresVivos.AutoSize = true;
            this.labelNCantidadSeresVivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNCantidadSeresVivos.Location = new System.Drawing.Point(746, 69);
            this.labelNCantidadSeresVivos.Name = "labelNCantidadSeresVivos";
            this.labelNCantidadSeresVivos.Size = new System.Drawing.Size(25, 25);
            this.labelNCantidadSeresVivos.TabIndex = 2;
            this.labelNCantidadSeresVivos.Text = "0";
            this.labelNCantidadSeresVivos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelNCantidadSeresComidos
            // 
            this.labelNCantidadSeresComidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNCantidadSeresComidos.AutoSize = true;
            this.labelNCantidadSeresComidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNCantidadSeresComidos.Location = new System.Drawing.Point(746, 221);
            this.labelNCantidadSeresComidos.Name = "labelNCantidadSeresComidos";
            this.labelNCantidadSeresComidos.Size = new System.Drawing.Size(25, 25);
            this.labelNCantidadSeresComidos.TabIndex = 3;
            this.labelNCantidadSeresComidos.Text = "0";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.tableBottom);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 504);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1029, 100);
            this.panelBottom.TabIndex = 1;
            // 
            // tableBottom
            // 
            this.tableBottom.ColumnCount = 1;
            this.tableBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableBottom.Controls.Add(this.buttomCerrar, 0, 0);
            this.tableBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableBottom.Location = new System.Drawing.Point(0, 0);
            this.tableBottom.Name = "tableBottom";
            this.tableBottom.RowCount = 1;
            this.tableBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableBottom.Size = new System.Drawing.Size(1029, 100);
            this.tableBottom.TabIndex = 0;
            // 
            // buttomCerrar
            // 
            this.buttomCerrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttomCerrar.AutoSize = true;
            this.buttomCerrar.BackColor = System.Drawing.Color.Maroon;
            this.buttomCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttomCerrar.Location = new System.Drawing.Point(444, 20);
            this.buttomCerrar.Name = "buttomCerrar";
            this.buttomCerrar.Size = new System.Drawing.Size(140, 60);
            this.buttomCerrar.TabIndex = 0;
            this.buttomCerrar.Text = "Cerrar";
            this.buttomCerrar.UseVisualStyleBackColor = false;
            this.buttomCerrar.Click += new System.EventHandler(this.buttomCerrar_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.tableTitulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1029, 100);
            this.panelHeader.TabIndex = 0;
            // 
            // tableTitulo
            // 
            this.tableTitulo.ColumnCount = 1;
            this.tableTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableTitulo.Controls.Add(this.labelTitulo, 0, 0);
            this.tableTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableTitulo.Location = new System.Drawing.Point(0, 0);
            this.tableTitulo.Name = "tableTitulo";
            this.tableTitulo.RowCount = 1;
            this.tableTitulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableTitulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableTitulo.Size = new System.Drawing.Size(1029, 100);
            this.tableTitulo.TabIndex = 0;
            // 
            // labelTitulo
            // 
            this.labelTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(391, 27);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(246, 46);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Estádisticas";
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 604);
            this.Controls.Add(this.contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "StatsForm";
            this.Text = "StatsForm";
            this.Load += new System.EventHandler(this.StatsForm_Load);
            this.contenedor.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.tableStats.ResumeLayout(false);
            this.tableStats.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.tableBottom.ResumeLayout(false);
            this.tableBottom.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.tableTitulo.ResumeLayout(false);
            this.tableTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.TableLayoutPanel tableBottom;
        private System.Windows.Forms.Button buttomCerrar;
        private System.Windows.Forms.TableLayoutPanel tableTitulo;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TableLayoutPanel tableStats;
        private System.Windows.Forms.Label labelCantidadSeresVivos;
        private System.Windows.Forms.Label labelCantidadSeresComidos;
        private System.Windows.Forms.Label labelNCantidadSeresVivos;
        private System.Windows.Forms.Label labelNCantidadSeresComidos;
    }
}