namespace Inventarios.WinForms
{
    partial class UIEliminaciónTipoProductoTerminado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIEliminaciónTipoProductoTerminado));
            this.tlsBarraMenu = new System.Windows.Forms.ToolStrip();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.dataGridProductoTerminado = new System.Windows.Forms.DataGridView();
            this.Buscar = new System.Windows.Forms.GroupBox();
            this.cbxNombreTipoProductoTerminado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdTipoProductoTerminado = new System.Windows.Forms.TextBox();
            this.tlsBarraMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductoTerminado)).BeginInit();
            this.Buscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlsBarraMenu
            // 
            this.tlsBarraMenu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlsBarraMenu.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.tlsBarraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEliminar,
            this.tsbSalir,
            this.tsbCancelar});
            this.tlsBarraMenu.Location = new System.Drawing.Point(0, 0);
            this.tlsBarraMenu.Name = "tlsBarraMenu";
            this.tlsBarraMenu.Size = new System.Drawing.Size(748, 53);
            this.tlsBarraMenu.TabIndex = 29;
            this.tlsBarraMenu.Text = "Menu de articulos";
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.ForeColor = System.Drawing.Color.DimGray;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(83, 50);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbEliminar.ToolTipText = "Guarda los datos de un registro";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
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
            // dataGridProductoTerminado
            // 
            this.dataGridProductoTerminado.AllowUserToDeleteRows = false;
            this.dataGridProductoTerminado.AllowUserToOrderColumns = true;
            this.dataGridProductoTerminado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridProductoTerminado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductoTerminado.Location = new System.Drawing.Point(65, 212);
            this.dataGridProductoTerminado.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridProductoTerminado.Name = "dataGridProductoTerminado";
            this.dataGridProductoTerminado.Size = new System.Drawing.Size(588, 140);
            this.dataGridProductoTerminado.TabIndex = 31;
            this.dataGridProductoTerminado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProductoTerminado_CellContentClick);
            // 
            // Buscar
            // 
            this.Buscar.Controls.Add(this.cbxNombreTipoProductoTerminado);
            this.Buscar.Controls.Add(this.label2);
            this.Buscar.Controls.Add(this.label1);
            this.Buscar.Controls.Add(this.txtIdTipoProductoTerminado);
            this.Buscar.Location = new System.Drawing.Point(65, 96);
            this.Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Buscar.Name = "Buscar";
            this.Buscar.Padding = new System.Windows.Forms.Padding(4);
            this.Buscar.Size = new System.Drawing.Size(615, 89);
            this.Buscar.TabIndex = 30;
            this.Buscar.TabStop = false;
            this.Buscar.Text = "Buscar";
            // 
            // cbxNombreTipoProductoTerminado
            // 
            this.cbxNombreTipoProductoTerminado.FormattingEnabled = true;
            this.cbxNombreTipoProductoTerminado.Location = new System.Drawing.Point(88, 32);
            this.cbxNombreTipoProductoTerminado.Margin = new System.Windows.Forms.Padding(4);
            this.cbxNombreTipoProductoTerminado.Name = "cbxNombreTipoProductoTerminado";
            this.cbxNombreTipoProductoTerminado.Size = new System.Drawing.Size(160, 24);
            this.cbxNombreTipoProductoTerminado.TabIndex = 3;
            this.cbxNombreTipoProductoTerminado.SelectedIndexChanged += new System.EventHandler(this.cbxNombreTipoProductoTerminado_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "IdTipoProductoTerminado";
            // 
            // txtIdTipoProductoTerminado
            // 
            this.txtIdTipoProductoTerminado.Location = new System.Drawing.Point(461, 32);
            this.txtIdTipoProductoTerminado.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdTipoProductoTerminado.Name = "txtIdTipoProductoTerminado";
            this.txtIdTipoProductoTerminado.Size = new System.Drawing.Size(132, 22);
            this.txtIdTipoProductoTerminado.TabIndex = 0;
            // 
            // UIEliminaciónTipoProductoTerminado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 389);
            this.Controls.Add(this.dataGridProductoTerminado);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.tlsBarraMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(763, 174);
            this.Name = "UIEliminaciónTipoProductoTerminado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminación Tipo Producto Terminado";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.tlsBarraMenu.ResumeLayout(false);
            this.tlsBarraMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductoTerminado)).EndInit();
            this.Buscar.ResumeLayout(false);
            this.Buscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlsBarraMenu;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridView dataGridProductoTerminado;
        private System.Windows.Forms.GroupBox Buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdTipoProductoTerminado;
        private System.Windows.Forms.ComboBox cbxNombreTipoProductoTerminado;
        private System.Windows.Forms.Label label2;
    }
}