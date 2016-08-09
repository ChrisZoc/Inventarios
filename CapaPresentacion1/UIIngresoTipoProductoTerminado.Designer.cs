namespace Inventarios.WinForms
{
    partial class UIIngresoTipoProductoTerminado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIIngresoTipoProductoTerminado));
            this.tlsBarraMenu = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.gpbAlta = new System.Windows.Forms.GroupBox();
            this.txtIdTipoProductoTerminado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreTipoProductoTerminado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tlsBarraMenu.SuspendLayout();
            this.gpbAlta.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlsBarraMenu
            // 
            this.tlsBarraMenu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlsBarraMenu.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.tlsBarraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbGuardar,
            this.tsbSalir,
            this.tsbCancelar});
            this.tlsBarraMenu.Location = new System.Drawing.Point(0, 0);
            this.tlsBarraMenu.Name = "tlsBarraMenu";
            this.tlsBarraMenu.Size = new System.Drawing.Size(759, 53);
            this.tlsBarraMenu.TabIndex = 29;
            this.tlsBarraMenu.Text = "Menu de articulos";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.ForeColor = System.Drawing.Color.DimGray;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(69, 50);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbNuevo.ToolTipText = "Crea un nuevo registro";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.ForeColor = System.Drawing.Color.DimGray;
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(83, 50);
            this.tsbGuardar.Text = "Guardar";
            this.tsbGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbGuardar.ToolTipText = "Guarda los datos de un registro";
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click_1);
            // 
            // tsbSalir
            // 
            this.tsbSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbSalir.ForeColor = System.Drawing.Color.DimGray;
            this.tsbSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalir.Image")));
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(90, 50);
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
            this.tsbCancelar.Size = new System.Drawing.Size(87, 50);
            this.tsbCancelar.Text = "Cancelar";
            this.tsbCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCancelar.ToolTipText = "Cancela el registro actual";
            this.tsbCancelar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // gpbAlta
            // 
            this.gpbAlta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbAlta.Controls.Add(this.txtIdTipoProductoTerminado);
            this.gpbAlta.Controls.Add(this.label2);
            this.gpbAlta.Controls.Add(this.NombreTipoProductoTerminado);
            this.gpbAlta.Controls.Add(this.label9);
            this.gpbAlta.Location = new System.Drawing.Point(16, 107);
            this.gpbAlta.Margin = new System.Windows.Forms.Padding(4);
            this.gpbAlta.Name = "gpbAlta";
            this.gpbAlta.Padding = new System.Windows.Forms.Padding(4);
            this.gpbAlta.Size = new System.Drawing.Size(727, 139);
            this.gpbAlta.TabIndex = 32;
            this.gpbAlta.TabStop = false;
            this.gpbAlta.Text = "Ingreso Tipo Producto Terminado";
            this.gpbAlta.Enter += new System.EventHandler(this.gpbAlta_Enter);
            // 
            // txtIdTipoProductoTerminado
            // 
            this.txtIdTipoProductoTerminado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdTipoProductoTerminado.Location = new System.Drawing.Point(301, 39);
            this.txtIdTipoProductoTerminado.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdTipoProductoTerminado.Name = "txtIdTipoProductoTerminado";
            this.txtIdTipoProductoTerminado.ReadOnly = true;
            this.txtIdTipoProductoTerminado.Size = new System.Drawing.Size(208, 22);
            this.txtIdTipoProductoTerminado.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "IdTipoProductoTerminado";
            // 
            // NombreTipoProductoTerminado
            // 
            this.NombreTipoProductoTerminado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NombreTipoProductoTerminado.Location = new System.Drawing.Point(301, 71);
            this.NombreTipoProductoTerminado.Margin = new System.Windows.Forms.Padding(4);
            this.NombreTipoProductoTerminado.Name = "NombreTipoProductoTerminado";
            this.NombreTipoProductoTerminado.Size = new System.Drawing.Size(208, 22);
            this.NombreTipoProductoTerminado.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 80);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "Nombre tipo producto terminado";
            // 
            // UIIngresoTipoProductoTerminado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 261);
            this.Controls.Add(this.tlsBarraMenu);
            this.Controls.Add(this.gpbAlta);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(763, 174);
            this.Name = "UIIngresoTipoProductoTerminado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso Tipo Producto Terminado";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.tlsBarraMenu.ResumeLayout(false);
            this.tlsBarraMenu.PerformLayout();
            this.gpbAlta.ResumeLayout(false);
            this.gpbAlta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlsBarraMenu;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.GroupBox gpbAlta;
        private System.Windows.Forms.TextBox txtIdTipoProductoTerminado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreTipoProductoTerminado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
    }
}