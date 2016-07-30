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
            this.tsbBusqueda = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.label6 = new System.Windows.Forms.Label();
            this.lsvProductos = new System.Windows.Forms.ListView();
            this.NombreProveedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpbBusqueda = new System.Windows.Forms.GroupBox();
            this.txtNombreBusqueda = new System.Windows.Forms.TextBox();
            this.IdProveedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dirección = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tlsBarraMenu.SuspendLayout();
            this.gpbBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlsBarraMenu
            // 
            this.tlsBarraMenu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlsBarraMenu.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.tlsBarraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbBusqueda,
            this.tsbSalir});
            this.tlsBarraMenu.Location = new System.Drawing.Point(0, 0);
            this.tlsBarraMenu.Name = "tlsBarraMenu";
            this.tlsBarraMenu.Size = new System.Drawing.Size(569, 48);
            this.tlsBarraMenu.TabIndex = 29;
            this.tlsBarraMenu.Text = "Menu de articulos";
            // 
            // tsbBusqueda
            // 
            this.tsbBusqueda.ForeColor = System.Drawing.Color.DimGray;
            this.tsbBusqueda.Image = ((System.Drawing.Image)(resources.GetObject("tsbBusqueda.Image")));
            this.tsbBusqueda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBusqueda.Name = "tsbBusqueda";
            this.tsbBusqueda.Size = new System.Drawing.Size(56, 45);
            this.tsbBusqueda.Text = "Buscar";
            this.tsbBusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbBusqueda.ToolTipText = "Realiza la busqueda un registro";
            this.tsbBusqueda.Click += new System.EventHandler(this.tsbBusqueda_Click);
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
            this.tsbSalir.ToolTipText = "Cerrar la forma";
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "id Proveedor";
            // 
            // lsvProductos
            // 
            this.lsvProductos.AllowColumnReorder = true;
            this.lsvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdProveedor,
            this.NombreProveedor,
            this.Dirección,
            this.Tipo});
            this.lsvProductos.FullRowSelect = true;
            this.lsvProductos.GridLines = true;
            this.lsvProductos.Location = new System.Drawing.Point(6, 61);
            this.lsvProductos.MultiSelect = false;
            this.lsvProductos.Name = "lsvProductos";
            this.lsvProductos.Size = new System.Drawing.Size(521, 281);
            this.lsvProductos.TabIndex = 15;
            this.lsvProductos.UseCompatibleStateImageBehavior = false;
            this.lsvProductos.View = System.Windows.Forms.View.Details;
            this.lsvProductos.Click += new System.EventHandler(this.lsvProductos_Click);
            // 
            // NombreProveedor
            // 
            this.NombreProveedor.DisplayIndex = 0;
            this.NombreProveedor.Text = "Nombre Proveedor";
            this.NombreProveedor.Width = 115;
            // 
            // gpbBusqueda
            // 
            this.gpbBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbBusqueda.Controls.Add(this.label6);
            this.gpbBusqueda.Controls.Add(this.txtNombreBusqueda);
            this.gpbBusqueda.Controls.Add(this.lsvProductos);
            this.gpbBusqueda.Location = new System.Drawing.Point(12, 68);
            this.gpbBusqueda.Name = "gpbBusqueda";
            this.gpbBusqueda.Size = new System.Drawing.Size(533, 348);
            this.gpbBusqueda.TabIndex = 31;
            this.gpbBusqueda.TabStop = false;
            this.gpbBusqueda.Text = "Ver Proveedor";
            this.gpbBusqueda.Visible = false;
            // 
            // txtNombreBusqueda
            // 
            this.txtNombreBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreBusqueda.Location = new System.Drawing.Point(79, 20);
            this.txtNombreBusqueda.Name = "txtNombreBusqueda";
            this.txtNombreBusqueda.Size = new System.Drawing.Size(257, 20);
            this.txtNombreBusqueda.TabIndex = 12;
            this.txtNombreBusqueda.TextChanged += new System.EventHandler(this.txtNombreBusqueda_TextChanged);
            // 
            // IdProveedor
            // 
            this.IdProveedor.DisplayIndex = 1;
            this.IdProveedor.Text = "Id Proveedor";
            this.IdProveedor.Width = 109;
            // 
            // Dirección
            // 
            this.Dirección.Text = "Dirección";
            // 
            // Tipo
            // 
            this.Tipo.Text = "Tipo";
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
        private System.Windows.Forms.ToolStripButton tsbBusqueda;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lsvProductos;
        private System.Windows.Forms.GroupBox gpbBusqueda;
        private System.Windows.Forms.TextBox txtNombreBusqueda;
        private System.Windows.Forms.ColumnHeader NombreProveedor;
        private System.Windows.Forms.ColumnHeader IdProveedor;
        private System.Windows.Forms.ColumnHeader Dirección;
        private System.Windows.Forms.ColumnHeader Tipo;
    }
}