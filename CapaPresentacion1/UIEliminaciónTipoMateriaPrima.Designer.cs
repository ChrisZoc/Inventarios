namespace Inventarios.WinForms
{
    partial class UIEliminaciónTipoMateriaPrima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIEliminaciónTipoMateriaPrima));
            this.tlsBarraMenu = new System.Windows.Forms.ToolStrip();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbRegresar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.dataGridNombresTipoMtaeria = new System.Windows.Forms.DataGridView();
            this.Buscar = new System.Windows.Forms.GroupBox();
            this.textNombreTipoMateria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textIdTipoMateriaPrima = new System.Windows.Forms.TextBox();
            this.tlsBarraMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNombresTipoMtaeria)).BeginInit();
            this.Buscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlsBarraMenu
            // 
            this.tlsBarraMenu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlsBarraMenu.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.tlsBarraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEliminar,
            this.tsbRegresar,
            this.tsbCancelar});
            this.tlsBarraMenu.Location = new System.Drawing.Point(0, 0);
            this.tlsBarraMenu.Name = "tlsBarraMenu";
            this.tlsBarraMenu.Size = new System.Drawing.Size(561, 48);
            this.tlsBarraMenu.TabIndex = 29;
            this.tlsBarraMenu.Text = "Menu de articulos";
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.CheckOnClick = true;
            this.tsbEliminar.ForeColor = System.Drawing.Color.DimGray;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(61, 45);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbEliminar.ToolTipText = "Elimina los datos de un registro";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
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
            this.tsbRegresar.ToolTipText = "Cerrar la pantalla actual";
            this.tsbRegresar.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.CheckOnClick = true;
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
            // dataGridNombresTipoMtaeria
            // 
            this.dataGridNombresTipoMtaeria.AllowUserToDeleteRows = false;
            this.dataGridNombresTipoMtaeria.AllowUserToOrderColumns = true;
            this.dataGridNombresTipoMtaeria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNombresTipoMtaeria.Location = new System.Drawing.Point(49, 172);
            this.dataGridNombresTipoMtaeria.Name = "dataGridNombresTipoMtaeria";
            this.dataGridNombresTipoMtaeria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridNombresTipoMtaeria.Size = new System.Drawing.Size(441, 114);
            this.dataGridNombresTipoMtaeria.TabIndex = 31;
            this.dataGridNombresTipoMtaeria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridNombresTipoMtaeria_CellContentClick);
            this.dataGridNombresTipoMtaeria.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.seleccionarFilas);
            // 
            // Buscar
            // 
            this.Buscar.Controls.Add(this.textNombreTipoMateria);
            this.Buscar.Controls.Add(this.label2);
            this.Buscar.Controls.Add(this.label1);
            this.Buscar.Controls.Add(this.textIdTipoMateriaPrima);
            this.Buscar.Location = new System.Drawing.Point(49, 78);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(441, 72);
            this.Buscar.TabIndex = 30;
            this.Buscar.TabStop = false;
            this.Buscar.Text = "Buscar";
            // 
            // textNombreTipoMateria
            // 
            this.textNombreTipoMateria.Location = new System.Drawing.Point(66, 26);
            this.textNombreTipoMateria.Name = "textNombreTipoMateria";
            this.textNombreTipoMateria.Size = new System.Drawing.Size(100, 20);
            this.textNombreTipoMateria.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IdTipoMateriaPrima";
            // 
            // textIdTipoMateriaPrima
            // 
            this.textIdTipoMateriaPrima.Location = new System.Drawing.Point(315, 26);
            this.textIdTipoMateriaPrima.Name = "textIdTipoMateriaPrima";
            this.textIdTipoMateriaPrima.Size = new System.Drawing.Size(100, 20);
            this.textIdTipoMateriaPrima.TabIndex = 0;
            // 
            // UIEliminaciónTipoMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 316);
            this.Controls.Add(this.dataGridNombresTipoMtaeria);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.tlsBarraMenu);
            this.MinimumSize = new System.Drawing.Size(577, 150);
            this.Name = "UIEliminaciónTipoMateriaPrima";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminación Tipo Materia Prima";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.tlsBarraMenu.ResumeLayout(false);
            this.tlsBarraMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNombresTipoMtaeria)).EndInit();
            this.Buscar.ResumeLayout(false);
            this.Buscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlsBarraMenu;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton tsbRegresar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridView dataGridNombresTipoMtaeria;
        private System.Windows.Forms.GroupBox Buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textIdTipoMateriaPrima;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNombreTipoMateria;
    }
}