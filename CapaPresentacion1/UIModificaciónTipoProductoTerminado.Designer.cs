namespace Inventarios.WinForms
{
    partial class UIModificaciónTipoProductoTerminado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIModificaciónTipoProductoTerminado));
            this.tlsBarraMenu = new System.Windows.Forms.ToolStrip();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBNomTipoProductoTerminado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.GroupBox();
            this.cboxNomTipoProductoTerminado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idTipoProductoTerminado = new System.Windows.Forms.TextBox();
            this.tlsBarraMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Buscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlsBarraMenu
            // 
            this.tlsBarraMenu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlsBarraMenu.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.tlsBarraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbModificar,
            this.tsbSalir,
            this.tsbCancelar});
            this.tlsBarraMenu.Location = new System.Drawing.Point(0, 0);
            this.tlsBarraMenu.Name = "tlsBarraMenu";
            this.tlsBarraMenu.Size = new System.Drawing.Size(759, 53);
            this.tlsBarraMenu.TabIndex = 29;
            this.tlsBarraMenu.Text = "Menu de articulos";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBNomTipoProductoTerminado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(60, 188);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(637, 78);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Campos";
            // 
            // textBNomTipoProductoTerminado
            // 
            this.textBNomTipoProductoTerminado.Location = new System.Drawing.Point(273, 30);
            this.textBNomTipoProductoTerminado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBNomTipoProductoTerminado.Name = "textBNomTipoProductoTerminado";
            this.textBNomTipoProductoTerminado.Size = new System.Drawing.Size(132, 22);
            this.textBNomTipoProductoTerminado.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre tipo producto terminado";
            // 
            // Buscar
            // 
            this.Buscar.Controls.Add(this.cboxNomTipoProductoTerminado);
            this.Buscar.Controls.Add(this.label3);
            this.Buscar.Controls.Add(this.label1);
            this.Buscar.Controls.Add(this.idTipoProductoTerminado);
            this.Buscar.Location = new System.Drawing.Point(60, 78);
            this.Buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Buscar.Name = "Buscar";
            this.Buscar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Buscar.Size = new System.Drawing.Size(637, 81);
            this.Buscar.TabIndex = 34;
            this.Buscar.TabStop = false;
            this.Buscar.Text = "Buscar";
            // 
            // cboxNomTipoProductoTerminado
            // 
            this.cboxNomTipoProductoTerminado.FormattingEnabled = true;
            this.cboxNomTipoProductoTerminado.Location = new System.Drawing.Point(87, 34);
            this.cboxNomTipoProductoTerminado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxNomTipoProductoTerminado.Name = "cboxNomTipoProductoTerminado";
            this.cboxNomTipoProductoTerminado.Size = new System.Drawing.Size(184, 24);
            this.cboxNomTipoProductoTerminado.TabIndex = 32;
            this.cboxNomTipoProductoTerminado.SelectedIndexChanged += new System.EventHandler(this.cboxNomTipoProductoTerminado_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "IdTipoProductoTerminado";
            // 
            // idTipoProductoTerminado
            // 
            this.idTipoProductoTerminado.Location = new System.Drawing.Point(468, 36);
            this.idTipoProductoTerminado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idTipoProductoTerminado.Name = "idTipoProductoTerminado";
            this.idTipoProductoTerminado.Size = new System.Drawing.Size(132, 22);
            this.idTipoProductoTerminado.TabIndex = 0;
            // 
            // UIModificaciónTipoProductoTerminado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 342);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.tlsBarraMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(763, 174);
            this.Name = "UIModificaciónTipoProductoTerminado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificación Tipo Producto Terminado";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.tlsBarraMenu.ResumeLayout(false);
            this.tlsBarraMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Buscar.ResumeLayout(false);
            this.Buscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlsBarraMenu;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBNomTipoProductoTerminado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Buscar;
        private System.Windows.Forms.ComboBox cboxNomTipoProductoTerminado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTipoProductoTerminado;
    }
}