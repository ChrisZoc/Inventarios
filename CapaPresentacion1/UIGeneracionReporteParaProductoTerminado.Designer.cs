namespace Inventarios.WinForms
{
    partial class UIGeneracionReporteParaProductoTerminado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIGeneracionReporteParaProductoTerminado));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtLote = new System.Windows.Forms.RadioButton();
            this.rbtCompra = new System.Windows.Forms.RadioButton();
            this.rbtFecha = new System.Windows.Forms.RadioButton();
            this.rbtSemana = new System.Windows.Forms.RadioButton();
            this.gbxFechas = new System.Windows.Forms.GroupBox();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxSemanas = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tlsBarraMenu = new System.Windows.Forms.ToolStrip();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.gbxFechas.SuspendLayout();
            this.gbxSemanas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tlsBarraMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtLote);
            this.groupBox1.Controls.Add(this.rbtCompra);
            this.groupBox1.Controls.Add(this.rbtFecha);
            this.groupBox1.Controls.Add(this.rbtSemana);
            this.groupBox1.Location = new System.Drawing.Point(39, 129);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(184, 183);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametro";
            // 
            // rbtLote
            // 
            this.rbtLote.AutoSize = true;
            this.rbtLote.Location = new System.Drawing.Point(22, 135);
            this.rbtLote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtLote.Name = "rbtLote";
            this.rbtLote.Size = new System.Drawing.Size(94, 24);
            this.rbtLote.TabIndex = 36;
            this.rbtLote.TabStop = true;
            this.rbtLote.Text = "Por Lote";
            this.rbtLote.UseVisualStyleBackColor = true;
            this.rbtLote.CheckedChanged += new System.EventHandler(this.rbtLote_CheckedChanged);
            // 
            // rbtCompra
            // 
            this.rbtCompra.AutoSize = true;
            this.rbtCompra.Location = new System.Drawing.Point(22, 100);
            this.rbtCompra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtCompra.Name = "rbtCompra";
            this.rbtCompra.Size = new System.Drawing.Size(118, 24);
            this.rbtCompra.TabIndex = 36;
            this.rbtCompra.TabStop = true;
            this.rbtCompra.Text = "Por Compra";
            this.rbtCompra.UseVisualStyleBackColor = true;
            this.rbtCompra.CheckedChanged += new System.EventHandler(this.rbtCompra_CheckedChanged);
            // 
            // rbtFecha
            // 
            this.rbtFecha.AutoSize = true;
            this.rbtFecha.Location = new System.Drawing.Point(22, 29);
            this.rbtFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtFecha.Name = "rbtFecha";
            this.rbtFecha.Size = new System.Drawing.Size(107, 24);
            this.rbtFecha.TabIndex = 34;
            this.rbtFecha.TabStop = true;
            this.rbtFecha.Text = "Por Fecha";
            this.rbtFecha.UseVisualStyleBackColor = true;
            this.rbtFecha.CheckedChanged += new System.EventHandler(this.rbtFecha_CheckedChanged);
            // 
            // rbtSemana
            // 
            this.rbtSemana.AutoSize = true;
            this.rbtSemana.Location = new System.Drawing.Point(22, 65);
            this.rbtSemana.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtSemana.Name = "rbtSemana";
            this.rbtSemana.Size = new System.Drawing.Size(122, 24);
            this.rbtSemana.TabIndex = 35;
            this.rbtSemana.TabStop = true;
            this.rbtSemana.Text = "Por Semana";
            this.rbtSemana.UseVisualStyleBackColor = true;
            this.rbtSemana.CheckedChanged += new System.EventHandler(this.rbtSemana_CheckedChanged);
            // 
            // gbxFechas
            // 
            this.gbxFechas.Controls.Add(this.dtpFechaFin);
            this.gbxFechas.Controls.Add(this.dtpFechaInicio);
            this.gbxFechas.Controls.Add(this.label2);
            this.gbxFechas.Controls.Add(this.label1);
            this.gbxFechas.Location = new System.Drawing.Point(248, 140);
            this.gbxFechas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxFechas.Name = "gbxFechas";
            this.gbxFechas.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxFechas.Size = new System.Drawing.Size(423, 177);
            this.gbxFechas.TabIndex = 32;
            this.gbxFechas.TabStop = false;
            this.gbxFechas.Text = "Fecha";
            this.gbxFechas.Visible = false;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CustomFormat = "31/12/9998";
            this.dtpFechaFin.Location = new System.Drawing.Point(135, 94);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(277, 26);
            this.dtpFechaFin.TabIndex = 3;
            this.dtpFechaFin.Value = new System.DateTime(2016, 7, 19, 0, 46, 47, 0);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(135, 34);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(277, 26);
            this.dtpFechaInicio.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Inicio";
            // 
            // groupBox3
            // 
            this.gbxSemanas.Controls.Add(this.numericUpDown2);
            this.gbxSemanas.Controls.Add(this.numericUpDown1);
            this.gbxSemanas.Controls.Add(this.label4);
            this.gbxSemanas.Controls.Add(this.label3);
            this.gbxSemanas.Location = new System.Drawing.Point(256, 135);
            this.gbxSemanas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxSemanas.Name = "groupBox3";
            this.gbxSemanas.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxSemanas.Size = new System.Drawing.Size(423, 182);
            this.gbxSemanas.TabIndex = 33;
            this.gbxSemanas.TabStop = false;
            this.gbxSemanas.Text = "Semana";
            this.gbxSemanas.Visible = false;
            this.gbxSemanas.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(148, 94);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(180, 26);
            this.numericUpDown2.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(148, 48);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(180, 26);
            this.numericUpDown1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Semana Fin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Semana Inicio";
            // 
            // tlsBarraMenu
            // 
            this.tlsBarraMenu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlsBarraMenu.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.tlsBarraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalir,
            this.tsbModificar,
            this.toolStripButton3});
            this.tlsBarraMenu.Location = new System.Drawing.Point(0, 0);
            this.tlsBarraMenu.Name = "tlsBarraMenu";
            this.tlsBarraMenu.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tlsBarraMenu.Size = new System.Drawing.Size(712, 56);
            this.tlsBarraMenu.TabIndex = 34;
            this.tlsBarraMenu.Text = "Menu de articulos";
            // 
            // tsbSalir
            // 
            this.tsbSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbSalir.ForeColor = System.Drawing.Color.DimGray;
            this.tsbSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalir.Image")));
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(106, 53);
            this.tsbSalir.Text = "Regresar";
            this.tsbSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSalir.ToolTipText = "Cerrar la pantalla actual";
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // tsbModificar
            // 
            this.tsbModificar.ForeColor = System.Drawing.Color.DimGray;
            this.tsbModificar.Image = ((System.Drawing.Image)(resources.GetObject("tsbModificar.Image")));
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(183, 53);
            this.tsbModificar.Text = "Generar Reporte";
            this.tsbModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbModificar.ToolTipText = "Genera un reporte con los datos de un registro";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(102, 53);
            this.toolStripButton3.Text = "Cancelar";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.ToolTipText = "Cancela el registro actual";
            // 
            // UIGeneracionReporteParaProductoTerminado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 335);
            this.Controls.Add(this.tlsBarraMenu);
            this.Controls.Add(this.gbxFechas);
            this.Controls.Add(this.gbxSemanas);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UIGeneracionReporteParaProductoTerminado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generación Lista Producto Terminado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxFechas.ResumeLayout(false);
            this.gbxFechas.PerformLayout();
            this.gbxSemanas.ResumeLayout(false);
            this.gbxSemanas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tlsBarraMenu.ResumeLayout(false);
            this.tlsBarraMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtLote;
        private System.Windows.Forms.RadioButton rbtCompra;
        private System.Windows.Forms.RadioButton rbtFecha;
        private System.Windows.Forms.RadioButton rbtSemana;
        private System.Windows.Forms.GroupBox gbxFechas;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxSemanas;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip tlsBarraMenu;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton tsbSalir;
    }
}