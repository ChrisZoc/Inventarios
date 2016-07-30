namespace Inventarios.WinForms
{
    partial class UIEliminaciónTipoMateriaPrima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIEliminaciónTipoMateriaPrima));
            this.tlsBarraMenu = new System.Windows.Forms.ToolStrip();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombretipomateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buscar = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tlsBarraMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Buscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlsBarraMenu
            // 
            this.tlsBarraMenu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlsBarraMenu.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.tlsBarraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEliminar,
            this.tsbSalir,
            this.tsbCancelar});
            this.tlsBarraMenu.Location = new System.Drawing.Point(0, 0);
            this.tlsBarraMenu.Name = "tlsBarraMenu";
            this.tlsBarraMenu.Size = new System.Drawing.Size(561, 48);
            this.tlsBarraMenu.TabIndex = 29;
            this.tlsBarraMenu.Text = "Menu de articulos";
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.ForeColor = System.Drawing.Color.DimGray;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(61, 45);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbEliminar.ToolTipText = "Guarda los datos de un registro";
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
            // tsbCancelar
            // 
            this.tsbCancelar.ForeColor = System.Drawing.Color.DimGray;
            this.tsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.Image")));
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(68, 45);
            this.tsbCancelar.Text = "Cancelar";
            this.tsbCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCancelar.ToolTipText = "Cancela el registro actual";
            this.tsbCancelar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombretipomateria});
            this.dataGridView1.Location = new System.Drawing.Point(49, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 114);
            this.dataGridView1.TabIndex = 31;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            // 
            // Nombretipomateria
            // 
            this.Nombretipomateria.HeaderText = "Nombre tipo materia prima";
            this.Nombretipomateria.Name = "Nombretipomateria";
            // 
            // Buscar
            // 
            this.Buscar.Controls.Add(this.comboBox1);
            this.Buscar.Controls.Add(this.label2);
            this.Buscar.Controls.Add(this.label1);
            this.Buscar.Controls.Add(this.textBox1);
            this.Buscar.Location = new System.Drawing.Point(49, 78);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(441, 72);
            this.Buscar.TabIndex = 30;
            this.Buscar.TabStop = false;
            this.Buscar.Text = "Buscar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IdTipoMateriaPrima";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(315, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(66, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // UIEliminaciónTipoMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 316);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.tlsBarraMenu);
            this.MinimumSize = new System.Drawing.Size(577, 150);
            this.Name = "UIEliminaciónTipoMateriaPrima";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminación Tipo Materia Prima";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.tlsBarraMenu.ResumeLayout(false);
            this.tlsBarraMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Buscar.ResumeLayout(false);
            this.Buscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlsBarraMenu;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombretipomateria;
        private System.Windows.Forms.GroupBox Buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}