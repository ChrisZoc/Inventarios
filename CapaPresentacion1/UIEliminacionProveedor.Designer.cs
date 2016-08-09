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
            this.tsbBuscarNombre = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscarMP = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbRegresar = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.ID_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comunidad_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxBuscarNombre = new System.Windows.Forms.ComboBox();
            this.cbxBuscarTipoMP = new System.Windows.Forms.ComboBox();
            this.cbxBuscarComunidad = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tlsBarraMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // tlsBarraMenu
            // 
            this.tlsBarraMenu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlsBarraMenu.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.tlsBarraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbBuscarNombre,
            this.tsbBuscarMP,
            this.tsbEliminar,
            this.tsbCancelar,
            this.tsbRegresar});
            this.tlsBarraMenu.Location = new System.Drawing.Point(0, 0);
            this.tlsBarraMenu.Name = "tlsBarraMenu";
            this.tlsBarraMenu.Size = new System.Drawing.Size(646, 48);
            this.tlsBarraMenu.TabIndex = 29;
            this.tlsBarraMenu.Text = "Menu de articulos";
            // 
            // tsbBuscarNombre
            // 
            this.tsbBuscarNombre.ForeColor = System.Drawing.Color.DimGray;
            this.tsbBuscarNombre.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscarNombre.Image")));
            this.tsbBuscarNombre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscarNombre.Name = "tsbBuscarNombre";
            this.tsbBuscarNombre.Size = new System.Drawing.Size(135, 45);
            this.tsbBuscarNombre.Text = "Buscar Por Nombre";
            this.tsbBuscarNombre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbBuscarNombre.Click += new System.EventHandler(this.tsbBuscarNombre_Click);
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
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
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
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvProveedores);
            this.groupBox1.Controls.Add(this.cbxBuscarNombre);
            this.groupBox1.Controls.Add(this.cbxBuscarTipoMP);
            this.groupBox1.Controls.Add(this.cbxBuscarComunidad);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 223);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Proveedor,
            this.ID_Tipo,
            this.Nombre_Proveedor,
            this.Comunidad_Proveedor,
            this.Estado_Proveedor});
            this.dgvProveedores.Location = new System.Drawing.Point(20, 87);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.Size = new System.Drawing.Size(579, 118);
            this.dgvProveedores.TabIndex = 52;
            this.dgvProveedores.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_RowEnter);
            // 
            // ID_Proveedor
            // 
            this.ID_Proveedor.DataPropertyName = "IDPROVEEDOR";
            this.ID_Proveedor.HeaderText = "ID Proveedor";
            this.ID_Proveedor.Name = "ID_Proveedor";
            // 
            // ID_Tipo
            // 
            this.ID_Tipo.DataPropertyName = "IDTIPOMATERIAPRIMA";
            this.ID_Tipo.HeaderText = "ID Tipo Materia Prima";
            this.ID_Tipo.Name = "ID_Tipo";
            this.ID_Tipo.Width = 135;
            // 
            // Nombre_Proveedor
            // 
            this.Nombre_Proveedor.DataPropertyName = "NOMBREPROVEEDOR";
            this.Nombre_Proveedor.HeaderText = "Nombre";
            this.Nombre_Proveedor.Name = "Nombre_Proveedor";
            // 
            // Comunidad_Proveedor
            // 
            this.Comunidad_Proveedor.DataPropertyName = "COMUNIDAD";
            this.Comunidad_Proveedor.HeaderText = "Comunidad";
            this.Comunidad_Proveedor.Name = "Comunidad_Proveedor";
            // 
            // Estado_Proveedor
            // 
            this.Estado_Proveedor.DataPropertyName = "ESTADO";
            this.Estado_Proveedor.HeaderText = "Estado";
            this.Estado_Proveedor.Name = "Estado_Proveedor";
            // 
            // cbxBuscarNombre
            // 
            this.cbxBuscarNombre.FormattingEnabled = true;
            this.cbxBuscarNombre.Location = new System.Drawing.Point(106, 50);
            this.cbxBuscarNombre.Name = "cbxBuscarNombre";
            this.cbxBuscarNombre.Size = new System.Drawing.Size(148, 21);
            this.cbxBuscarNombre.TabIndex = 51;
            // 
            // cbxBuscarTipoMP
            // 
            this.cbxBuscarTipoMP.FormattingEnabled = true;
            this.cbxBuscarTipoMP.Location = new System.Drawing.Point(407, 22);
            this.cbxBuscarTipoMP.Name = "cbxBuscarTipoMP";
            this.cbxBuscarTipoMP.Size = new System.Drawing.Size(159, 21);
            this.cbxBuscarTipoMP.TabIndex = 50;
            // 
            // cbxBuscarComunidad
            // 
            this.cbxBuscarComunidad.FormattingEnabled = true;
            this.cbxBuscarComunidad.Location = new System.Drawing.Point(106, 22);
            this.cbxBuscarComunidad.Name = "cbxBuscarComunidad";
            this.cbxBuscarComunidad.Size = new System.Drawing.Size(148, 21);
            this.cbxBuscarComunidad.TabIndex = 49;
            this.cbxBuscarComunidad.SelectedIndexChanged += new System.EventHandler(this.cbxBuscarComunidad_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 25);
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
            // UIEliminacionProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 299);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tlsBarraMenu);
            this.MinimumSize = new System.Drawing.Size(587, 258);
            this.Name = "UIEliminacionProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminación Proveedor";
            this.tlsBarraMenu.ResumeLayout(false);
            this.tlsBarraMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlsBarraMenu;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton tsbRegresar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.ComboBox cbxBuscarNombre;
        private System.Windows.Forms.ComboBox cbxBuscarTipoMP;
        private System.Windows.Forms.ComboBox cbxBuscarComunidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripButton tsbBuscarNombre;
        private System.Windows.Forms.ToolStripButton tsbBuscarMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comunidad_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_Proveedor;
    }
}