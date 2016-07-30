namespace Inventarios.WinForms
{
    partial class UIConsultaProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIConsultaProveedor));
            this.tlsBarraMenu = new System.Windows.Forms.ToolStrip();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.label6 = new System.Windows.Forms.Label();
            this.lsvProductos = new System.Windows.Forms.ListView();
            this.NomProveedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdProveedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Comunidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpbBusqueda = new System.Windows.Forms.GroupBox();
            this.txtNombreBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tlsBarraMenu.SuspendLayout();
            this.gpbBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlsBarraMenu
            // 
            this.tlsBarraMenu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlsBarraMenu.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.tlsBarraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalir});
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
            this.tsbSalir.ToolTipText = "Cerrar la forma";
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "id Proveedor";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lsvProductos
            // 
            this.lsvProductos.AllowColumnReorder = true;
            this.lsvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NomProveedor,
            this.IdProveedor,
            this.Comunidad,
            this.Tipo,
            this.Estado});
            this.lsvProductos.FullRowSelect = true;
            this.lsvProductos.GridLines = true;
            this.lsvProductos.Location = new System.Drawing.Point(6, 67);
            this.lsvProductos.MultiSelect = false;
            this.lsvProductos.Name = "lsvProductos";
            this.lsvProductos.Size = new System.Drawing.Size(533, 281);
            this.lsvProductos.TabIndex = 15;
            this.lsvProductos.UseCompatibleStateImageBehavior = false;
            this.lsvProductos.View = System.Windows.Forms.View.Details;
            this.lsvProductos.SelectedIndexChanged += new System.EventHandler(this.lsvProductos_SelectedIndexChanged);
            this.lsvProductos.Click += new System.EventHandler(this.lsvProductos_Click);
            // 
            // NomProveedor
            // 
            this.NomProveedor.DisplayIndex = 1;
            this.NomProveedor.Text = "Nombre Proveedor";
            this.NomProveedor.Width = 109;
            // 
            // IdProveedor
            // 
            this.IdProveedor.DisplayIndex = 0;
            this.IdProveedor.Text = "IdProveedor";
            this.IdProveedor.Width = 90;
            // 
            // Comunidad
            // 
            this.Comunidad.Text = "Comunidad";
            this.Comunidad.Width = 81;
            // 
            // Tipo
            // 
            this.Tipo.Text = "Tipo Materia Prima";
            this.Tipo.Width = 119;
            // 
            // gpbBusqueda
            // 
            this.gpbBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbBusqueda.Controls.Add(this.comboBox1);
            this.gpbBusqueda.Controls.Add(this.label1);
            this.gpbBusqueda.Controls.Add(this.label6);
            this.gpbBusqueda.Controls.Add(this.txtNombreBusqueda);
            this.gpbBusqueda.Controls.Add(this.lsvProductos);
            this.gpbBusqueda.Location = new System.Drawing.Point(12, 68);
            this.gpbBusqueda.Name = "gpbBusqueda";
            this.gpbBusqueda.Size = new System.Drawing.Size(545, 348);
            this.gpbBusqueda.TabIndex = 31;
            this.gpbBusqueda.TabStop = false;
            this.gpbBusqueda.Text = "Ver Proveedor";
            this.gpbBusqueda.Visible = false;
            this.gpbBusqueda.Enter += new System.EventHandler(this.gpbBusqueda_Enter);
            // 
            // txtNombreBusqueda
            // 
            this.txtNombreBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreBusqueda.Location = new System.Drawing.Point(374, 22);
            this.txtNombreBusqueda.Name = "txtNombreBusqueda";
            this.txtNombreBusqueda.Size = new System.Drawing.Size(133, 20);
            this.txtNombreBusqueda.TabIndex = 12;
            this.txtNombreBusqueda.TextChanged += new System.EventHandler(this.txtNombreBusqueda_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tipo Materia Prima";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // Estado
            // 
            this.Estado.Text = "Estado";
            this.Estado.Width = 173;
            // 
            // UIConsultaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 424);
            this.Controls.Add(this.tlsBarraMenu);
            this.Controls.Add(this.gpbBusqueda);
            this.MinimumSize = new System.Drawing.Size(577, 458);
            this.Name = "UIConsultaProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Proveedor";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.tlsBarraMenu.ResumeLayout(false);
            this.tlsBarraMenu.PerformLayout();
            this.gpbBusqueda.ResumeLayout(false);
            this.gpbBusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlsBarraMenu;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lsvProductos;
        private System.Windows.Forms.GroupBox gpbBusqueda;
        private System.Windows.Forms.TextBox txtNombreBusqueda;
        private System.Windows.Forms.ColumnHeader IdProveedor;
        private System.Windows.Forms.ColumnHeader NomProveedor;
        private System.Windows.Forms.ColumnHeader Comunidad;
        private System.Windows.Forms.ColumnHeader Tipo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Estado;
    }
}