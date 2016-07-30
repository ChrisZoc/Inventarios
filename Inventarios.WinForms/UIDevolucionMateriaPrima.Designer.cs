namespace Inventarios.WinForms
{
    partial class UIDevolucionMateriaPrima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIDevolucionMateriaPrima));
            this.tlsBarraMenu = new System.Windows.Forms.ToolStrip();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tsbConsultarCompraMP = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoMateriaPrima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.tlsBarraMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlsBarraMenu
            // 
            this.tlsBarraMenu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlsBarraMenu.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.tlsBarraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalir,
            this.tsbModificar,
            this.toolStripButton3,
            this.tsbConsultarCompraMP});
            this.tlsBarraMenu.Location = new System.Drawing.Point(0, 0);
            this.tlsBarraMenu.Name = "tlsBarraMenu";
            this.tlsBarraMenu.Size = new System.Drawing.Size(569, 48);
            this.tlsBarraMenu.TabIndex = 29;
            this.tlsBarraMenu.Text = "Menu de articulos";
            // 
            // tsbSalir
            // 
            this.tsbSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbSalir.ForeColor = System.Drawing.Color.DimGray;
            this.tsbSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalir.Image")));
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(72, 45);
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
            this.tsbModificar.Size = new System.Drawing.Size(71, 45);
            this.tsbModificar.Text = "Modificar";
            this.tsbModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbModificar.ToolTipText = "Modifica los datos de un registro";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(68, 45);
            this.toolStripButton3.Text = "Cancelar";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.ToolTipText = "Cancela el registro actual";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // tsbConsultarCompraMP
            // 
            this.tsbConsultarCompraMP.ForeColor = System.Drawing.Color.DimGray;
            this.tsbConsultarCompraMP.Image = ((System.Drawing.Image)(resources.GetObject("tsbConsultarCompraMP.Image")));
            this.tsbConsultarCompraMP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConsultarCompraMP.Name = "tsbConsultarCompraMP";
            this.tsbConsultarCompraMP.Size = new System.Drawing.Size(221, 45);
            this.tsbConsultarCompraMP.Text = "Consultar Compra Materia Prima";
            this.tsbConsultarCompraMP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbConsultarCompraMP.ToolTipText = "Dezpliega la pantalla de busqueda de materia prima";
            this.tsbConsultarCompraMP.Click += new System.EventHandler(this.tsbConsultarCompraMP_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBox12);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(12, 366);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 148);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Campos";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(391, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 21);
            this.comboBox1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Razón";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(189, 84);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(67, 20);
            this.textBox8.TabIndex = 28;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(401, 29);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(275, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Cantidad Perdida (lb)";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(137, 55);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(119, 20);
            this.textBox10.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Id de compra";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(137, 29);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(119, 20);
            this.textBox11.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Fecha de compra";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(38, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Tipo Materia Prima";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(137, 110);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(119, 20);
            this.textBox12.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(38, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Cantidad inicial Materia Prima";
            // 
            // Buscar
            // 
            this.Buscar.Controls.Add(this.dataGridView1);
            this.Buscar.Controls.Add(this.comboBox3);
            this.Buscar.Controls.Add(this.label4);
            this.Buscar.Controls.Add(this.label3);
            this.Buscar.Controls.Add(this.dateTimePicker1);
            this.Buscar.Controls.Add(this.label2);
            this.Buscar.Controls.Add(this.label15);
            this.Buscar.Controls.Add(this.textBox13);
            this.Buscar.Location = new System.Drawing.Point(12, 64);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(542, 296);
            this.Buscar.TabIndex = 32;
            this.Buscar.TabStop = false;
            this.Buscar.Text = "Buscar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.TipoMateriaPrima});
            this.dataGridView1.Location = new System.Drawing.Point(137, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 176);
            this.dataGridView1.TabIndex = 38;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // TipoMateriaPrima
            // 
            this.TipoMateriaPrima.HeaderText = "Tipo Materia Prima";
            this.TipoMateriaPrima.Name = "TipoMateriaPrima";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(102, 67);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(172, 21);
            this.comboBox3.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Fecha de Compra";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(311, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Compras";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(36, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Id Compra";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(102, 29);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(100, 20);
            this.textBox13.TabIndex = 0;
            // 
            // UIDevolucionMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 526);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.tlsBarraMenu);
            this.MinimumSize = new System.Drawing.Size(577, 150);
            this.Name = "UIDevolucionMateriaPrima";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolución Materia Prima";
            this.tlsBarraMenu.ResumeLayout(false);
            this.tlsBarraMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Buscar.ResumeLayout(false);
            this.Buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlsBarraMenu;
        private System.Windows.Forms.ToolStripButton tsbConsultarCompraMP;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox Buscar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoMateriaPrima;
    }
}