namespace Inventarios.WinForms
{
    partial class UIIngresoCompraMateriaPrima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIIngresoCompraMateriaPrima));
            this.tlsBarraMenu = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbIngresarTipoMP = new System.Windows.Forms.ToolStripButton();
            this.groupBoxValores = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.textComunidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxProveedor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textIdProveedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxNombreTipoMateriaPrima = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textIdTipoMateriaPrima = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.MaskedTextBox();
            this.textBox7 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.tlsBarraMenu.SuspendLayout();
            this.groupBoxValores.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlsBarraMenu
            // 
            this.tlsBarraMenu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlsBarraMenu.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.tlsBarraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbSalir,
            this.tsbGuardar,
            this.tsbIngresarTipoMP});
            this.tlsBarraMenu.Location = new System.Drawing.Point(0, 0);
            this.tlsBarraMenu.Name = "tlsBarraMenu";
            this.tlsBarraMenu.Size = new System.Drawing.Size(668, 48);
            this.tlsBarraMenu.TabIndex = 29;
            this.tlsBarraMenu.Text = "Menu de articulos";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.ForeColor = System.Drawing.Color.DimGray;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(52, 45);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbNuevo.ToolTipText = "Crea un nuevo registro";
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
            // tsbGuardar
            // 
            this.tsbGuardar.ForeColor = System.Drawing.Color.DimGray;
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(64, 45);
            this.tsbGuardar.Text = "Guardar";
            this.tsbGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbGuardar.ToolTipText = "Guarda los datos de un registro";
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // tsbIngresarTipoMP
            // 
            this.tsbIngresarTipoMP.ForeColor = System.Drawing.Color.DimGray;
            this.tsbIngresarTipoMP.Image = ((System.Drawing.Image)(resources.GetObject("tsbIngresarTipoMP.Image")));
            this.tsbIngresarTipoMP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbIngresarTipoMP.Name = "tsbIngresarTipoMP";
            this.tsbIngresarTipoMP.Size = new System.Drawing.Size(192, 45);
            this.tsbIngresarTipoMP.Text = "Ingresar Tipo Materia Prima";
            this.tsbIngresarTipoMP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbIngresarTipoMP.ToolTipText = "Abre una ventana de ingreso tipo materia prima ";
            this.tsbIngresarTipoMP.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // groupBoxValores
            // 
            this.groupBoxValores.Controls.Add(this.maskedTextBox2);
            this.groupBoxValores.Controls.Add(this.textBox7);
            this.groupBoxValores.Controls.Add(this.textBox5);
            this.groupBoxValores.Controls.Add(this.textBox1);
            this.groupBoxValores.Controls.Add(this.label11);
            this.groupBoxValores.Controls.Add(this.label10);
            this.groupBoxValores.Controls.Add(this.dateTimePicker1);
            this.groupBoxValores.Controls.Add(this.label9);
            this.groupBoxValores.Controls.Add(this.textComunidad);
            this.groupBoxValores.Controls.Add(this.label8);
            this.groupBoxValores.Controls.Add(this.cbxProveedor);
            this.groupBoxValores.Controls.Add(this.label7);
            this.groupBoxValores.Controls.Add(this.label6);
            this.groupBoxValores.Controls.Add(this.textBox2);
            this.groupBoxValores.Controls.Add(this.label5);
            this.groupBoxValores.Controls.Add(this.label4);
            this.groupBoxValores.Controls.Add(this.textIdProveedor);
            this.groupBoxValores.Controls.Add(this.label3);
            this.groupBoxValores.Location = new System.Drawing.Point(33, 169);
            this.groupBoxValores.Name = "groupBoxValores";
            this.groupBoxValores.Size = new System.Drawing.Size(599, 175);
            this.groupBoxValores.TabIndex = 31;
            this.groupBoxValores.TabStop = false;
            this.groupBoxValores.Text = "Valores";
            this.groupBoxValores.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(485, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 20);
            this.textBox1.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(436, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Estado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(230, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Precio";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(283, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(122, 20);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(436, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Semana";
            // 
            // textComunidad
            // 
            this.textComunidad.Location = new System.Drawing.Point(485, 63);
            this.textComunidad.Name = "textComunidad";
            this.textComunidad.Size = new System.Drawing.Size(94, 20);
            this.textComunidad.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(422, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Comunidad";
            // 
            // cbxProveedor
            // 
            this.cbxProveedor.FormattingEnabled = true;
            this.cbxProveedor.Location = new System.Drawing.Point(283, 59);
            this.cbxProveedor.Name = "cbxProveedor";
            this.cbxProveedor.Size = new System.Drawing.Size(121, 21);
            this.cbxProveedor.TabIndex = 26;
            this.cbxProveedor.SelectedIndexChanged += new System.EventHandler(this.cbxProveedor_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Peso (lb)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Id de compra";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(103, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(48, 20);
            this.textBox2.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Fecha de compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "IdProveedor";
            // 
            // textIdProveedor
            // 
            this.textIdProveedor.Enabled = false;
            this.textIdProveedor.Location = new System.Drawing.Point(102, 60);
            this.textIdProveedor.Name = "textIdProveedor";
            this.textIdProveedor.ReadOnly = true;
            this.textIdProveedor.Size = new System.Drawing.Size(49, 20);
            this.textIdProveedor.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Proveedor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxNombreTipoMateriaPrima);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textIdTipoMateriaPrima);
            this.groupBox1.Location = new System.Drawing.Point(33, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 78);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbxNombreTipoMateriaPrima
            // 
            this.cbxNombreTipoMateriaPrima.FormattingEnabled = true;
            this.cbxNombreTipoMateriaPrima.Items.AddRange(new object[] {
            "Guayusa",
            "Canela",
            "Hierba buena",
            "Hierba Luisa",
            "Flor de Jamaica",
            "Naranja"});
            this.cbxNombreTipoMateriaPrima.Location = new System.Drawing.Point(146, 31);
            this.cbxNombreTipoMateriaPrima.Name = "cbxNombreTipoMateriaPrima";
            this.cbxNombreTipoMateriaPrima.Size = new System.Drawing.Size(121, 21);
            this.cbxNombreTipoMateriaPrima.TabIndex = 20;
            this.cbxNombreTipoMateriaPrima.SelectedIndexChanged += new System.EventHandler(this.cbxNombreTipoMateriaPrimaChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre tipo materia prima";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "idTipoMateriaPrima";
            // 
            // textIdTipoMateriaPrima
            // 
            this.textIdTipoMateriaPrima.Location = new System.Drawing.Point(487, 31);
            this.textIdTipoMateriaPrima.Name = "textIdTipoMateriaPrima";
            this.textIdTipoMateriaPrima.ReadOnly = true;
            this.textIdTipoMateriaPrima.Size = new System.Drawing.Size(46, 20);
            this.textIdTipoMateriaPrima.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(102, 93);
            this.textBox5.Mask = "999";
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(49, 20);
            this.textBox5.TabIndex = 36;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(283, 93);
            this.textBox7.Mask = "9999$";
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 37;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(487, 31);
            this.maskedTextBox2.Mask = "9,L";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(92, 20);
            this.maskedTextBox2.TabIndex = 38;
            // 
            // UIIngresoCompraMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 371);
            this.Controls.Add(this.groupBoxValores);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tlsBarraMenu);
            this.MinimumSize = new System.Drawing.Size(577, 150);
            this.Name = "UIIngresoCompraMateriaPrima";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso Compra Materia Prima";
            this.tlsBarraMenu.ResumeLayout(false);
            this.tlsBarraMenu.PerformLayout();
            this.groupBoxValores.ResumeLayout(false);
            this.groupBoxValores.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlsBarraMenu;
        private System.Windows.Forms.ToolStripButton tsbIngresarTipoMP;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.GroupBox groupBoxValores;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textComunidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxProveedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textIdProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxNombreTipoMateriaPrima;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textIdTipoMateriaPrima;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox textBox7;
        private System.Windows.Forms.MaskedTextBox textBox5;
    }
}