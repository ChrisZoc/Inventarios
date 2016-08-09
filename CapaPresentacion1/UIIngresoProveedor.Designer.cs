namespace Inventarios.WinForms
{
    partial class UIIngresoProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIIngresoProveedor));
            this.tlsBarraMenu = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbRegresar = new System.Windows.Forms.ToolStripButton();
            this.tsbIngresarTipoMP = new System.Windows.Forms.ToolStripButton();
            this.gpbAlta = new System.Windows.Forms.GroupBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.cbxTipoMP = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIDProveedor = new System.Windows.Forms.MaskedTextBox();
            this.txtNombreProveedor = new System.Windows.Forms.MaskedTextBox();
            this.txtComunidad = new System.Windows.Forms.MaskedTextBox();
            this.tlsBarraMenu.SuspendLayout();
            this.gpbAlta.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlsBarraMenu
            // 
            this.tlsBarraMenu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlsBarraMenu.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.tlsBarraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardar,
            this.tsbCancelar,
            this.tsbRegresar,
            this.tsbIngresarTipoMP});
            this.tlsBarraMenu.Location = new System.Drawing.Point(0, 0);
            this.tlsBarraMenu.Name = "tlsBarraMenu";
            this.tlsBarraMenu.Size = new System.Drawing.Size(571, 48);
            this.tlsBarraMenu.TabIndex = 29;
            this.tlsBarraMenu.Text = "Menu de articulos";
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
            this.tsbIngresarTipoMP.Click += new System.EventHandler(this.tsbIngresarTipoMP_Click);
            // 
            // gpbAlta
            // 
            this.gpbAlta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbAlta.Controls.Add(this.txtComunidad);
            this.gpbAlta.Controls.Add(this.txtNombreProveedor);
            this.gpbAlta.Controls.Add(this.txtIDProveedor);
            this.gpbAlta.Controls.Add(this.cbxEstado);
            this.gpbAlta.Controls.Add(this.cbxTipoMP);
            this.gpbAlta.Controls.Add(this.label2);
            this.gpbAlta.Controls.Add(this.label1);
            this.gpbAlta.Controls.Add(this.label4);
            this.gpbAlta.Controls.Add(this.label3);
            this.gpbAlta.Controls.Add(this.label9);
            this.gpbAlta.Location = new System.Drawing.Point(12, 87);
            this.gpbAlta.Name = "gpbAlta";
            this.gpbAlta.Size = new System.Drawing.Size(547, 185);
            this.gpbAlta.TabIndex = 32;
            this.gpbAlta.TabStop = false;
            this.gpbAlta.Text = "Ingresar Proveedor";
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(152, 113);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(129, 21);
            this.cbxEstado.TabIndex = 48;
            // 
            // cbxTipoMP
            // 
            this.cbxTipoMP.FormattingEnabled = true;
            this.cbxTipoMP.Location = new System.Drawing.Point(152, 139);
            this.cbxTipoMP.Name = "cbxTipoMP";
            this.cbxTipoMP.Size = new System.Drawing.Size(129, 21);
            this.cbxTipoMP.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Tipo Materia Prima";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "ID Proveedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Comunidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(94, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Nombre";
            // 
            // txtIDProveedor
            // 
            this.txtIDProveedor.Enabled = false;
            this.txtIDProveedor.Location = new System.Drawing.Point(152, 35);
            this.txtIDProveedor.Name = "txtIDProveedor";
            this.txtIDProveedor.ReadOnly = true;
            this.txtIDProveedor.Size = new System.Drawing.Size(129, 20);
            this.txtIDProveedor.TabIndex = 49;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(152, 61);
            this.txtNombreProveedor.Mask = "LLL???????????????";
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(129, 20);
            this.txtNombreProveedor.TabIndex = 50;
            // 
            // txtComunidad
            // 
            this.txtComunidad.Location = new System.Drawing.Point(152, 87);
            this.txtComunidad.Mask = "LLL???????????????";
            this.txtComunidad.Name = "txtComunidad";
            this.txtComunidad.Size = new System.Drawing.Size(129, 20);
            this.txtComunidad.TabIndex = 51;
            // 
            // UIIngresoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 295);
            this.Controls.Add(this.tlsBarraMenu);
            this.Controls.Add(this.gpbAlta);
            this.MinimumSize = new System.Drawing.Size(587, 258);
            this.Name = "UIIngresoProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso Proveedor";
            this.tlsBarraMenu.ResumeLayout(false);
            this.tlsBarraMenu.PerformLayout();
            this.gpbAlta.ResumeLayout(false);
            this.gpbAlta.PerformLayout();
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTipoMP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton tsbIngresarTipoMP;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.MaskedTextBox txtComunidad;
        private System.Windows.Forms.MaskedTextBox txtNombreProveedor;
        private System.Windows.Forms.MaskedTextBox txtIDProveedor;
    }
}