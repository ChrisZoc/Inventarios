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
            this.tsbRegresar = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscarMP = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscarComunidad = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.label6 = new System.Windows.Forms.Label();
            this.gpbBusqueda = new System.Windows.Forms.GroupBox();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.ID_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comunidad_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxBuscarComunidad = new System.Windows.Forms.ComboBox();
            this.cbxBuscarTipoMP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tlsBarraMenu.SuspendLayout();
            this.gpbBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // tlsBarraMenu
            // 
            this.tlsBarraMenu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlsBarraMenu.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.tlsBarraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRegresar,
            this.tsbBuscarMP,
            this.tsbBuscarComunidad,
            this.tsbCancelar});
            this.tlsBarraMenu.Location = new System.Drawing.Point(0, 0);
            this.tlsBarraMenu.Name = "tlsBarraMenu";
            this.tlsBarraMenu.Size = new System.Drawing.Size(638, 48);
            this.tlsBarraMenu.TabIndex = 29;
            this.tlsBarraMenu.Text = "Menu de articulos";
            // 
            // tsbRegresar
            // 
            this.tsbRegresar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbRegresar.ForeColor = System.Drawing.Color.DimGray;
            this.tsbRegresar.Image = ((System.Drawing.Image)(resources.GetObject("tsbRegresar.Image")));
            this.tsbRegresar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRegresar.Name = "tsbRegresar";
            this.tsbRegresar.Size = new System.Drawing.Size(72, 45);
            this.tsbRegresar.Text = "Regresar";
            this.tsbRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbRegresar.ToolTipText = "Cerrar la forma";
            this.tsbRegresar.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // tsbBuscarMP
            // 
            this.tsbBuscarMP.ForeColor = System.Drawing.Color.DimGray;
            this.tsbBuscarMP.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscarMP.Image")));
            this.tsbBuscarMP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscarMP.Name = "tsbBuscarMP";
            this.tsbBuscarMP.Size = new System.Drawing.Size(206, 45);
            this.tsbBuscarMP.Text = "Buscar Por Tipo Materia Prima";
            this.tsbBuscarMP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbBuscarMP.Click += new System.EventHandler(this.tsbBuscarMP_Click);
            // 
            // tsbBuscarComunidad
            // 
            this.tsbBuscarComunidad.ForeColor = System.Drawing.Color.DimGray;
            this.tsbBuscarComunidad.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscarComunidad.Image")));
            this.tsbBuscarComunidad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscarComunidad.Name = "tsbBuscarComunidad";
            this.tsbBuscarComunidad.Size = new System.Drawing.Size(156, 45);
            this.tsbBuscarComunidad.Text = "Buscar Por Comunidad";
            this.tsbBuscarComunidad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbBuscarComunidad.Click += new System.EventHandler(this.tsbBuscarComunidad_Click);
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
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Comunidad";
            // 
            // gpbBusqueda
            // 
            this.gpbBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbBusqueda.Controls.Add(this.dgvProveedores);
            this.gpbBusqueda.Controls.Add(this.cbxBuscarComunidad);
            this.gpbBusqueda.Controls.Add(this.cbxBuscarTipoMP);
            this.gpbBusqueda.Controls.Add(this.label1);
            this.gpbBusqueda.Controls.Add(this.label6);
            this.gpbBusqueda.Location = new System.Drawing.Point(12, 68);
            this.gpbBusqueda.Name = "gpbBusqueda";
            this.gpbBusqueda.Size = new System.Drawing.Size(614, 343);
            this.gpbBusqueda.TabIndex = 31;
            this.gpbBusqueda.TabStop = false;
            this.gpbBusqueda.Text = "Ver Proveedor";
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.AllowUserToDeleteRows = false;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Proveedor,
            this.ID_Tipo,
            this.Nombre_Proveedor,
            this.Comunidad_Proveedor,
            this.Estado_Proveedor});
            this.dgvProveedores.Location = new System.Drawing.Point(16, 60);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.Size = new System.Drawing.Size(580, 259);
            this.dgvProveedores.TabIndex = 53;
            // 
            // ID_Proveedor
            // 
            this.ID_Proveedor.DataPropertyName = "IDPROVEEDOR";
            this.ID_Proveedor.HeaderText = "ID Proveedor";
            this.ID_Proveedor.Name = "ID_Proveedor";
            this.ID_Proveedor.ReadOnly = true;
            // 
            // ID_Tipo
            // 
            this.ID_Tipo.DataPropertyName = "IDTIPOMATERIAPRIMA";
            this.ID_Tipo.HeaderText = "ID Tipo Materia Prima";
            this.ID_Tipo.Name = "ID_Tipo";
            this.ID_Tipo.ReadOnly = true;
            this.ID_Tipo.Width = 135;
            // 
            // Nombre_Proveedor
            // 
            this.Nombre_Proveedor.DataPropertyName = "NOMBREPROVEEDOR";
            this.Nombre_Proveedor.HeaderText = "Nombre";
            this.Nombre_Proveedor.Name = "Nombre_Proveedor";
            this.Nombre_Proveedor.ReadOnly = true;
            // 
            // Comunidad_Proveedor
            // 
            this.Comunidad_Proveedor.DataPropertyName = "COMUNIDAD";
            this.Comunidad_Proveedor.HeaderText = "Comunidad";
            this.Comunidad_Proveedor.Name = "Comunidad_Proveedor";
            this.Comunidad_Proveedor.ReadOnly = true;
            // 
            // Estado_Proveedor
            // 
            this.Estado_Proveedor.DataPropertyName = "ESTADO";
            this.Estado_Proveedor.HeaderText = "Estado";
            this.Estado_Proveedor.Name = "Estado_Proveedor";
            this.Estado_Proveedor.ReadOnly = true;
            // 
            // cbxBuscarComunidad
            // 
            this.cbxBuscarComunidad.FormattingEnabled = true;
            this.cbxBuscarComunidad.Location = new System.Drawing.Point(410, 22);
            this.cbxBuscarComunidad.Name = "cbxBuscarComunidad";
            this.cbxBuscarComunidad.Size = new System.Drawing.Size(169, 21);
            this.cbxBuscarComunidad.TabIndex = 19;
            // 
            // cbxBuscarTipoMP
            // 
            this.cbxBuscarTipoMP.FormattingEnabled = true;
            this.cbxBuscarTipoMP.Location = new System.Drawing.Point(126, 22);
            this.cbxBuscarTipoMP.Name = "cbxBuscarTipoMP";
            this.cbxBuscarTipoMP.Size = new System.Drawing.Size(162, 21);
            this.cbxBuscarTipoMP.TabIndex = 18;
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
            // UIConsultaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 419);
            this.Controls.Add(this.tlsBarraMenu);
            this.Controls.Add(this.gpbBusqueda);
            this.MinimumSize = new System.Drawing.Size(577, 458);
            this.Name = "UIConsultaProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Proveedor";
            this.tlsBarraMenu.ResumeLayout(false);
            this.tlsBarraMenu.PerformLayout();
            this.gpbBusqueda.ResumeLayout(false);
            this.gpbBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlsBarraMenu;
        private System.Windows.Forms.ToolStripButton tsbRegresar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gpbBusqueda;
        private System.Windows.Forms.ComboBox cbxBuscarTipoMP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton tsbBuscarComunidad;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ComboBox cbxBuscarComunidad;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comunidad_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_Proveedor;
        private System.Windows.Forms.ToolStripButton tsbBuscarMP;
    }
}