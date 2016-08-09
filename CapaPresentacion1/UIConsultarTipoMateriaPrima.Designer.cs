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
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.dataGridTipoMateriaPrima = new System.Windows.Forms.DataGridView();
            this.rbtNombre = new System.Windows.Forms.RadioButton();
            this.rbtCodigo = new System.Windows.Forms.RadioButton();
            this.Buscar = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre = new System.Windows.Forms.MaskedTextBox();
            this.tlsBarraMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTipoMateriaPrima)).BeginInit();
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
            this.btnCancelar});
            this.tlsBarraMenu.Location = new System.Drawing.Point(0, 0);
            this.tlsBarraMenu.Name = "tlsBarraMenu";
            this.tlsBarraMenu.Size = new System.Drawing.Size(768, 48);
            this.tlsBarraMenu.TabIndex = 29;
            this.tlsBarraMenu.Text = "Menu de articulos";
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.CheckOnClick = true;
            this.tsbBuscar.ForeColor = System.Drawing.Color.DimGray;
            this.tsbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscar.Image")));
            this.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(56, 45);
            this.tsbBuscar.Text = "Buscar";
            this.tsbBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbBuscar.ToolTipText = "Busca una compra de materia prima";
            this.tsbBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            // btnCancelar
            // 
            this.btnCancelar.CheckOnClick = true;
            this.btnCancelar.ForeColor = System.Drawing.Color.DimGray;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(68, 45);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.ToolTipText = "Cancela el registro actual";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dataGridTipoMateriaPrima
            // 
            this.dataGridTipoMateriaPrima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTipoMateriaPrima.Location = new System.Drawing.Point(12, 175);
            this.dataGridTipoMateriaPrima.Name = "dataGridTipoMateriaPrima";
            this.dataGridTipoMateriaPrima.ReadOnly = true;
            this.dataGridTipoMateriaPrima.Size = new System.Drawing.Size(741, 118);
            this.dataGridTipoMateriaPrima.TabIndex = 33;
            this.dataGridTipoMateriaPrima.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTipoMateriaPrima_CellContentClick);
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
            this.rbtNombre.CheckedChanged += new System.EventHandler(this.rbtNombre_CheckedChanged);
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
            this.Buscar.Controls.Add(this.txtCodigo);
            this.Buscar.Controls.Add(this.txtNombre);
            this.Buscar.Controls.Add(this.rbtCodigo);
            this.Buscar.Controls.Add(this.rbtNombre);
            this.Buscar.Location = new System.Drawing.Point(12, 64);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(741, 93);
            this.Buscar.TabIndex = 32;
            this.Buscar.TabStop = false;
            this.Buscar.Text = "Buscar";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(128, 55);
            this.txtCodigo.Mask = "99";
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(128, 29);
            this.txtNombre.Mask = "LL?????????????????????????";
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(168, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // UIConsultarTipoMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 322);
            this.Controls.Add(this.dataGridTipoMateriaPrima);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.tlsBarraMenu);
            this.MinimumSize = new System.Drawing.Size(577, 150);
            this.Name = "UIConsultarTipoMateriaPrima";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Tipo Materia Prima";
            this.Load += new System.EventHandler(this.UIConsultarTipoMateriaPrima_Load);
            this.tlsBarraMenu.ResumeLayout(false);
            this.tlsBarraMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTipoMateriaPrima)).EndInit();
            this.Buscar.ResumeLayout(false);
            this.Buscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlsBarraMenu;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.DataGridView dataGridTipoMateriaPrima;
        private System.Windows.Forms.RadioButton rbtNombre;
        private System.Windows.Forms.RadioButton rbtCodigo;
        private System.Windows.Forms.GroupBox Buscar;
        private System.Windows.Forms.MaskedTextBox txtCodigo;
        private System.Windows.Forms.MaskedTextBox txtNombre;
    }
}