namespace Inventarios.WinForms
{
    partial class UIEliminacionProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIEliminacionProveedor));
            this.tlsBarraMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comunidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoMateriaPrima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tlsBarraMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlsBarraMenu
            // 
            this.tlsBarraMenu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlsBarraMenu.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.tlsBarraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.tsbCancelar,
            this.tsbSalir});
            this.tlsBarraMenu.Location = new System.Drawing.Point(0, 0);
            this.tlsBarraMenu.Name = "tlsBarraMenu";
            this.tlsBarraMenu.Size = new System.Drawing.Size(571, 48);
            this.tlsBarraMenu.TabIndex = 29;
            this.tlsBarraMenu.Text = "Menu de articulos";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(61, 45);
            this.toolStripButton1.Text = "Eliminar";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.ToolTipText = "Guarda los datos de un registro";
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.ForeColor = System.Drawing.Color.DimGray;
            this.tsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.Image")));
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(68, 45);
            this.tsbCancelar.Text = "Cancelar";
            this.tsbCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCancelar.ToolTipText = "cancela el ingreso actual";
            this.tsbCancelar.Click += new System.EventHandler(this.tsbGuardar_Click);
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
            this.tsbSalir.ToolTipText = "Cerrar la forma";
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 223);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProveedor,
            this.Nombre,
            this.Comunidad,
            this.TipoMateriaPrima,
            this.Estado});
            this.dataGridView1.Location = new System.Drawing.Point(27, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(493, 118);
            this.dataGridView1.TabIndex = 52;
            // 
            // IdProveedor
            // 
            this.IdProveedor.HeaderText = "IdProveedor";
            this.IdProveedor.Name = "IdProveedor";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 200;
            // 
            // Comunidad
            // 
            this.Comunidad.HeaderText = "Comunidad";
            this.Comunidad.Name = "Comunidad";
            // 
            // TipoMateriaPrima
            // 
            this.TipoMateriaPrima.HeaderText = "Tipo Materia Prima";
            this.TipoMateriaPrima.Name = "TipoMateriaPrima";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // comboBox3
            // 
            this.comboBox3.Enabled = false;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(106, 50);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(148, 21);
            this.comboBox3.TabIndex = 51;
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(361, 24);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(159, 21);
            this.comboBox2.TabIndex = 50;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 21);
            this.comboBox1.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Tipo Materia Prima";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Comunidad";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(361, 51);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(159, 20);
            this.textBox3.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "id Proveedor";
            // 
            // UIEliminacionProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 299);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tlsBarraMenu);
            this.MinimumSize = new System.Drawing.Size(587, 258);
            this.Name = "UIEliminacionProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminación Proveedor";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.tlsBarraMenu.ResumeLayout(false);
            this.tlsBarraMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlsBarraMenu;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comunidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoMateriaPrima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
    }
}