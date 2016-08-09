namespace Inventarios.WinForms
{
    partial class UIIngresoTipoMateriaPrima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIIngresoTipoMateriaPrima));
            this.tlsBarraMenu = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbRegresar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.gpbAlta = new System.Windows.Forms.GroupBox();
            this.NombreTipoMateriaPrima = new System.Windows.Forms.MaskedTextBox();
            this.txtIdTipoMateria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.tsbRegresar,
            this.tsbCancelar});
            this.tlsBarraMenu.Location = new System.Drawing.Point(0, 0);
            this.tlsBarraMenu.Name = "tlsBarraMenu";
            this.tlsBarraMenu.Size = new System.Drawing.Size(569, 48);
            this.tlsBarraMenu.TabIndex = 29;
            this.tlsBarraMenu.Text = "Menu de articulos";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.ForeColor = System.Drawing.Color.DimGray;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(52, 45);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbNuevo.ToolTipText = "Crea un nuevo registro";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.CheckOnClick = true;
            this.tsbGuardar.ForeColor = System.Drawing.Color.DimGray;
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(64, 45);
            this.tsbGuardar.Text = "Guardar";
            this.tsbGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbGuardar.ToolTipText = "Guarda los datos de un registro";
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click_1);
            // 
            // tsbRegresar
            // 
            this.tsbRegresar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbRegresar.CheckOnClick = true;
            this.tsbRegresar.ForeColor = System.Drawing.Color.DimGray;
            this.tsbRegresar.Image = ((System.Drawing.Image)(resources.GetObject("tsbRegresar.Image")));
            this.tsbRegresar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRegresar.Name = "tsbRegresar";
            this.tsbRegresar.Size = new System.Drawing.Size(72, 45);
            this.tsbRegresar.Text = "Regresar";
            this.tsbRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbRegresar.ToolTipText = "Cerrar la pantalla actual";
            this.tsbRegresar.Click += new System.EventHandler(this.tsbRegresar_Click);
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
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // gpbAlta
            // 
            this.gpbAlta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbAlta.Controls.Add(this.NombreTipoMateriaPrima);
            this.gpbAlta.Controls.Add(this.txtIdTipoMateria);
            this.gpbAlta.Controls.Add(this.label2);
            this.gpbAlta.Controls.Add(this.label9);
            this.gpbAlta.Location = new System.Drawing.Point(12, 87);
            this.gpbAlta.Name = "gpbAlta";
            this.gpbAlta.Size = new System.Drawing.Size(545, 113);
            this.gpbAlta.TabIndex = 32;
            this.gpbAlta.TabStop = false;
            this.gpbAlta.Text = "Ingreso Tipo Materia Prima";
            this.gpbAlta.Enter += new System.EventHandler(this.gpbAlta_Enter);
            // 
            // NombreTipoMateriaPrima
            // 
            this.NombreTipoMateriaPrima.Location = new System.Drawing.Point(226, 62);
            this.NombreTipoMateriaPrima.Mask = "LL?????????????????????????";
            this.NombreTipoMateriaPrima.Name = "NombreTipoMateriaPrima";
            this.NombreTipoMateriaPrima.Size = new System.Drawing.Size(157, 20);
            this.NombreTipoMateriaPrima.TabIndex = 45;
            // 
            // txtIdTipoMateria
            // 
            this.txtIdTipoMateria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdTipoMateria.Enabled = false;
            this.txtIdTipoMateria.Location = new System.Drawing.Point(226, 32);
            this.txtIdTipoMateria.Name = "txtIdTipoMateria";
            this.txtIdTipoMateria.ReadOnly = true;
            this.txtIdTipoMateria.Size = new System.Drawing.Size(157, 20);
            this.txtIdTipoMateria.TabIndex = 33;
            this.txtIdTipoMateria.TextChanged += new System.EventHandler(this.txtIdTipoMateria_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Id Tipo Materia Prima";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Nombre tipo materia prima";
            // 
            // UIIngresoTipoMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 212);
            this.Controls.Add(this.tlsBarraMenu);
            this.Controls.Add(this.gpbAlta);
            this.MinimumSize = new System.Drawing.Size(577, 150);
            this.Name = "UIIngresoTipoMateriaPrima";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso Tipo Materia Prima";
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
        private System.Windows.Forms.ToolStripButton tsbRegresar;
        private System.Windows.Forms.GroupBox gpbAlta;
        private System.Windows.Forms.TextBox txtIdTipoMateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.MaskedTextBox NombreTipoMateriaPrima;
    }
}