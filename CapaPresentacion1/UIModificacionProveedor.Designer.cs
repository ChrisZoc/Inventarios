namespace Inventarios.WinForms
{
    partial class UIModificacionProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIModificacionProveedor));
            this.tlsBarraMenu = new System.Windows.Forms.ToolStrip();
            this.tsbBuscarNombre = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscarMP = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbRegresar = new System.Windows.Forms.ToolStripButton();
            this.gpbAlta = new System.Windows.Forms.GroupBox();
            this.txtComunidad = new System.Windows.Forms.MaskedTextBox();
            this.txtNombreProveedor = new System.Windows.Forms.MaskedTextBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.cbxTipoMP = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIDProveedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxBuscarNombre = new System.Windows.Forms.ComboBox();
            this.cbxBuscarComunidad = new System.Windows.Forms.ComboBox();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.ID_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comunidad_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxBuscarMP = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tlsBarraMenu.SuspendLayout();
            this.gpbAlta.SuspendLayout();
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
            this.tsbModificar,
            this.tsbCancelar,
            this.tsbRegresar});
            this.tlsBarraMenu.Location = new System.Drawing.Point(0, 0);
            this.tlsBarraMenu.Name = "tlsBarraMenu";
            this.tlsBarraMenu.Size = new System.Drawing.Size(877, 53);
            this.tlsBarraMenu.TabIndex = 29;
            this.tlsBarraMenu.Text = "Menu de articulos";
            // 
            // tsbBuscarNombre
            // 
            this.tsbBuscarNombre.ForeColor = System.Drawing.Color.DimGray;
            this.tsbBuscarNombre.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscarNombre.Image")));
            this.tsbBuscarNombre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscarNombre.Name = "tsbBuscarNombre";
            this.tsbBuscarNombre.Size = new System.Drawing.Size(179, 50);
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
            this.tsbBuscarMP.Size = new System.Drawing.Size(271, 50);
            this.tsbBuscarMP.Text = "Buscar por Tipo Materia Prima";
            this.tsbBuscarMP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbBuscarMP.Click += new System.EventHandler(this.tsbBuscarMP_Click);
            // 
            // tsbModificar
            // 
            this.tsbModificar.ForeColor = System.Drawing.Color.DimGray;
            this.tsbModificar.Image = ((System.Drawing.Image)(resources.GetObject("tsbModificar.Image")));
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(94, 50);
            this.tsbModificar.Text = "Modificar";
            this.tsbModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbModificar.ToolTipText = "Guarda los datos de un registro";
            this.tsbModificar.Click += new System.EventHandler(this.tsbModificar_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.ForeColor = System.Drawing.Color.DimGray;
            this.tsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.Image")));
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(87, 50);
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
            this.tsbRegresar.Size = new System.Drawing.Size(90, 50);
            this.tsbRegresar.Text = "Regresar";
            this.tsbRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbRegresar.ToolTipText = "Cerrar la forma";
            this.tsbRegresar.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // gpbAlta
            // 
            this.gpbAlta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbAlta.Controls.Add(this.txtComunidad);
            this.gpbAlta.Controls.Add(this.txtNombreProveedor);
            this.gpbAlta.Controls.Add(this.cbxEstado);
            this.gpbAlta.Controls.Add(this.cbxTipoMP);
            this.gpbAlta.Controls.Add(this.label8);
            this.gpbAlta.Controls.Add(this.txtIDProveedor);
            this.gpbAlta.Controls.Add(this.label1);
            this.gpbAlta.Controls.Add(this.label4);
            this.gpbAlta.Controls.Add(this.label3);
            this.gpbAlta.Controls.Add(this.label9);
            this.gpbAlta.Location = new System.Drawing.Point(16, 364);
            this.gpbAlta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbAlta.Name = "gpbAlta";
            this.gpbAlta.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbAlta.Size = new System.Drawing.Size(845, 245);
            this.gpbAlta.TabIndex = 32;
            this.gpbAlta.TabStop = false;
            this.gpbAlta.Text = "Modificar Proveedor";
            // 
            // txtComunidad
            // 
            this.txtComunidad.Location = new System.Drawing.Point(276, 112);
            this.txtComunidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtComunidad.Mask = "LLL???????????????";
            this.txtComunidad.Name = "txtComunidad";
            this.txtComunidad.Size = new System.Drawing.Size(327, 22);
            this.txtComunidad.TabIndex = 60;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(276, 79);
            this.txtNombreProveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreProveedor.Mask = "LLL???????????????";
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(327, 22);
            this.txtNombreProveedor.TabIndex = 59;
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(276, 176);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(327, 24);
            this.cbxEstado.TabIndex = 58;
            // 
            // cbxTipoMP
            // 
            this.cbxTipoMP.FormattingEnabled = true;
            this.cbxTipoMP.Location = new System.Drawing.Point(276, 143);
            this.cbxTipoMP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxTipoMP.Name = "cbxTipoMP";
            this.cbxTipoMP.Size = new System.Drawing.Size(327, 24);
            this.cbxTipoMP.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 180);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 47;
            this.label8.Text = "Estado";
            // 
            // txtIDProveedor
            // 
            this.txtIDProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIDProveedor.Location = new System.Drawing.Point(276, 47);
            this.txtIDProveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDProveedor.Name = "txtIDProveedor";
            this.txtIDProveedor.ReadOnly = true;
            this.txtIDProveedor.Size = new System.Drawing.Size(327, 22);
            this.txtIDProveedor.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "ID Proveedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Tipo Materia Prima";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Comunidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(209, 82);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "Nombre";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefono.Location = new System.Drawing.Point(315, 585);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(327, 22);
            this.txtTelefono.TabIndex = 39;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbxBuscarNombre);
            this.groupBox1.Controls.Add(this.cbxBuscarComunidad);
            this.groupBox1.Controls.Add(this.dgvProveedores);
            this.groupBox1.Controls.Add(this.cbxBuscarMP);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(16, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(845, 267);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // cbxBuscarNombre
            // 
            this.cbxBuscarNombre.FormattingEnabled = true;
            this.cbxBuscarNombre.Location = new System.Drawing.Point(141, 62);
            this.cbxBuscarNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxBuscarNombre.Name = "cbxBuscarNombre";
            this.cbxBuscarNombre.Size = new System.Drawing.Size(196, 24);
            this.cbxBuscarNombre.TabIndex = 57;
            // 
            // cbxBuscarComunidad
            // 
            this.cbxBuscarComunidad.FormattingEnabled = true;
            this.cbxBuscarComunidad.Location = new System.Drawing.Point(141, 27);
            this.cbxBuscarComunidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxBuscarComunidad.Name = "cbxBuscarComunidad";
            this.cbxBuscarComunidad.Size = new System.Drawing.Size(196, 24);
            this.cbxBuscarComunidad.TabIndex = 56;
            this.cbxBuscarComunidad.SelectedIndexChanged += new System.EventHandler(this.cbxBuscarComunidad_SelectedIndexChanged);
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
            this.dgvProveedores.Location = new System.Drawing.Point(36, 107);
            this.dgvProveedores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.Size = new System.Drawing.Size(773, 145);
            this.dgvProveedores.TabIndex = 52;
            this.dgvProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellContentClick);
            this.dgvProveedores.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_RowEnter);
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
            // cbxBuscarMP
            // 
            this.cbxBuscarMP.FormattingEnabled = true;
            this.cbxBuscarMP.Location = new System.Drawing.Point(552, 27);
            this.cbxBuscarMP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxBuscarMP.Name = "cbxBuscarMP";
            this.cbxBuscarMP.Size = new System.Drawing.Size(211, 24);
            this.cbxBuscarMP.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(417, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 17);
            this.label7.TabIndex = 48;
            this.label7.Text = "Tipo Materia Prima";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 47;
            this.label6.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 46;
            this.label5.Text = "Comunidad";
            // 
            // UIModificacionProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 650);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tlsBarraMenu);
            this.Controls.Add(this.gpbAlta);
            this.Controls.Add(this.txtTelefono);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(777, 307);
            this.Name = "UIModificacionProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificación Proveedor";
            this.tlsBarraMenu.ResumeLayout(false);
            this.tlsBarraMenu.PerformLayout();
            this.gpbAlta.ResumeLayout(false);
            this.gpbAlta.PerformLayout();
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
        private System.Windows.Forms.GroupBox gpbAlta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.TextBox txtIDProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxBuscarMP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxTipoMP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxBuscarComunidad;
        private System.Windows.Forms.ComboBox cbxBuscarNombre;
        private System.Windows.Forms.ToolStripButton tsbBuscarNombre;
        private System.Windows.Forms.ToolStripButton tsbBuscarMP;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comunidad_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_Proveedor;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.MaskedTextBox txtComunidad;
        private System.Windows.Forms.MaskedTextBox txtNombreProveedor;
    }
}