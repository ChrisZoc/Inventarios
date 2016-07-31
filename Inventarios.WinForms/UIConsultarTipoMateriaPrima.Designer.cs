namespace Inventarios.WinForms
{
    partial class UIConsultarTipoMateriaPrima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIConsultarTipoMateriaPrima));
            this.tlsBarraMenu = new System.Windows.Forms.ToolStrip();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.rbtNombre = new System.Windows.Forms.RadioButton();
            this.rbtCodigo = new System.Windows.Forms.RadioButton();
            this.Buscar = new System.Windows.Forms.GroupBox();
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
            this.tsbBuscar,
            this.tsbSalir,
            this.toolStripButton3});
            this.tlsBarraMenu.Location = new System.Drawing.Point(0, 0);
            this.tlsBarraMenu.Name = "tlsBarraMenu";
            this.tlsBarraMenu.Size = new System.Drawing.Size(768, 48);
            this.tlsBarraMenu.TabIndex = 29;
            this.tlsBarraMenu.Text = "Menu de articulos";
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.ForeColor = System.Drawing.Color.DimGray;
            this.tsbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscar.Image")));
            this.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(56, 45);
            this.tsbBuscar.Text = "Buscar";
            this.tsbBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbBuscar.ToolTipText = "Busca una compra de materia prima";
            // 
            // tsbSalir
            // 
            this.tsbSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbSalir.ForeColor = System.Drawing.Color.DimGray;
            this.tsbSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalir.Image")));
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(40, 45);
            this.tsbSalir.Text = "Salir";
            this.tsbSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSalir.ToolTipText = "Cerrar la pantalla actual";
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
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
            // Column6
            // 
            this.Column6.HeaderText = "Lote";
            this.Column6.Name = "Column6";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tipo";
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre Producto Terminado";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(12, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 118);
            this.dataGridView1.TabIndex = 33;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(128, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(140, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(128, 55);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // rbtNombre
            // 
            this.rbtNombre.AutoSize = true;
            this.rbtNombre.Location = new System.Drawing.Point(37, 30);
            this.rbtNombre.Name = "rbtNombre";
            this.rbtNombre.Size = new System.Drawing.Size(81, 17);
            this.rbtNombre.TabIndex = 2;
            this.rbtNombre.TabStop = true;
            this.rbtNombre.Text = "Por Nombre";
            this.rbtNombre.UseVisualStyleBackColor = true;
            this.rbtNombre.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtCodigo
            // 
            this.rbtCodigo.AutoSize = true;
            this.rbtCodigo.Location = new System.Drawing.Point(37, 56);
            this.rbtCodigo.Name = "rbtCodigo";
            this.rbtCodigo.Size = new System.Drawing.Size(77, 17);
            this.rbtCodigo.TabIndex = 3;
            this.rbtCodigo.TabStop = true;
            this.rbtCodigo.Text = "Por Código";
            this.rbtCodigo.UseVisualStyleBackColor = true;
            this.rbtCodigo.CheckedChanged += new System.EventHandler(this.rbtCodigo_CheckedChanged);
            // 
            // Buscar
            // 
            this.Buscar.Controls.Add(this.rbtCodigo);
            this.Buscar.Controls.Add(this.rbtNombre);
            this.Buscar.Controls.Add(this.txtCodigo);
            this.Buscar.Controls.Add(this.txtNombre);
            this.Buscar.Location = new System.Drawing.Point(12, 64);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(741, 93);
            this.Buscar.TabIndex = 32;
            this.Buscar.TabStop = false;
            this.Buscar.Text = "Buscar";
            // 
            // UIConsultarTipoMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 322);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.tlsBarraMenu);
            this.MinimumSize = new System.Drawing.Size(577, 150);
            this.Name = "UIConsultarTipoMateriaPrima";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Tipo Materia Prima";
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
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.RadioButton rbtNombre;
        private System.Windows.Forms.RadioButton rbtCodigo;
        private System.Windows.Forms.GroupBox Buscar;
    }
}