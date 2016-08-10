namespace Inventarios.WinForms
{
    partial class UIDevolucionMateriaPrima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIDevolucionMateriaPrima));
            this.tlsBarraMenu = new System.Windows.Forms.ToolStrip();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tsbConsultarCompraMP = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCantidadInicial = new System.Windows.Forms.MaskedTextBox();
            this.txtIdDevolucion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbRazon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdCompra = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIdCompra2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTipoMateriaPrima = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.GroupBox();
            this.dgvTablaCompras = new System.Windows.Forms.DataGridView();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pckFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtIdCompra1 = new System.Windows.Forms.TextBox();
            this.tlsBarraMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // tlsBarraMenu
            // 
            this.tlsBarraMenu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlsBarraMenu.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.tlsBarraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalir,
            this.tsbModificar,
            this.toolStripButton3,
            this.tsbConsultarCompraMP});
            this.tlsBarraMenu.Location = new System.Drawing.Point(0, 0);
            this.tlsBarraMenu.Name = "tlsBarraMenu";
            this.tlsBarraMenu.Size = new System.Drawing.Size(759, 53);
            this.tlsBarraMenu.TabIndex = 29;
            this.tlsBarraMenu.Text = "Menu de articulos";
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
            // tsbModificar
            // 
            this.tsbModificar.ForeColor = System.Drawing.Color.DimGray;
            this.tsbModificar.Image = ((System.Drawing.Image)(resources.GetObject("tsbModificar.Image")));
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(94, 50);
            this.tsbModificar.Text = "Modificar";
            this.tsbModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbModificar.ToolTipText = "Modifica los datos de un registro";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(87, 50);
            this.toolStripButton3.Text = "Cancelar";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.ToolTipText = "Cancela el registro actual";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // tsbConsultarCompraMP
            // 
            this.tsbConsultarCompraMP.ForeColor = System.Drawing.Color.DimGray;
            this.tsbConsultarCompraMP.Image = ((System.Drawing.Image)(resources.GetObject("tsbConsultarCompraMP.Image")));
            this.tsbConsultarCompraMP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConsultarCompraMP.Name = "tsbConsultarCompraMP";
            this.tsbConsultarCompraMP.Size = new System.Drawing.Size(290, 50);
            this.tsbConsultarCompraMP.Text = "Consultar Compra Materia Prima";
            this.tsbConsultarCompraMP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbConsultarCompraMP.ToolTipText = "Dezpliega la pantalla de busqueda de materia prima";
            this.tsbConsultarCompraMP.Click += new System.EventHandler(this.tsbConsultarCompraMP_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCantidadInicial);
            this.groupBox1.Controls.Add(this.txtIdDevolucion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbRazon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtIdCompra);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtIdCompra2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtTipoMateriaPrima);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(16, 450);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(723, 182);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Devolución";
            this.groupBox1.Enter += new System.EventHandler(this.seleccionarFilas);
            // 
            // txtCantidadInicial
            // 
            this.txtCantidadInicial.Location = new System.Drawing.Point(521, 36);
            this.txtCantidadInicial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidadInicial.Mask = "0000";
            this.txtCantidadInicial.Name = "txtCantidadInicial";
            this.txtCantidadInicial.Size = new System.Drawing.Size(157, 22);
            this.txtCantidadInicial.TabIndex = 33;
            // 
            // txtIdDevolucion
            // 
            this.txtIdDevolucion.Enabled = false;
            this.txtIdDevolucion.Location = new System.Drawing.Point(521, 98);
            this.txtIdDevolucion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdDevolucion.Name = "txtIdDevolucion";
            this.txtIdDevolucion.ReadOnly = true;
            this.txtIdDevolucion.Size = new System.Drawing.Size(157, 22);
            this.txtIdDevolucion.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Id devolución";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cmbRazon
            // 
            this.cmbRazon.FormattingEnabled = true;
            this.cmbRazon.Location = new System.Drawing.Point(521, 68);
            this.cmbRazon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbRazon.Name = "cmbRazon";
            this.cmbRazon.Size = new System.Drawing.Size(157, 24);
            this.cmbRazon.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Razón";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Location = new System.Drawing.Point(252, 98);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(88, 22);
            this.txtCantidad.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(367, 39);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Cantidad Perdida (lb)";
            // 
            // txtIdCompra
            // 
            this.txtIdCompra.Enabled = false;
            this.txtIdCompra.Location = new System.Drawing.Point(183, 68);
            this.txtIdCompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdCompra.Name = "txtIdCompra";
            this.txtIdCompra.ReadOnly = true;
            this.txtIdCompra.Size = new System.Drawing.Size(157, 22);
            this.txtIdCompra.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 39);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Id de compra";
            // 
            // txtIdCompra2
            // 
            this.txtIdCompra2.Enabled = false;
            this.txtIdCompra2.Location = new System.Drawing.Point(183, 36);
            this.txtIdCompra2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdCompra2.Name = "txtIdCompra2";
            this.txtIdCompra2.ReadOnly = true;
            this.txtIdCompra2.Size = new System.Drawing.Size(157, 22);
            this.txtIdCompra2.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(51, 71);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "Fecha de compra";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(51, 139);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 17);
            this.label13.TabIndex = 18;
            this.label13.Text = "Tipo Materia Prima";
            // 
            // txtTipoMateriaPrima
            // 
            this.txtTipoMateriaPrima.Enabled = false;
            this.txtTipoMateriaPrima.Location = new System.Drawing.Point(183, 135);
            this.txtTipoMateriaPrima.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTipoMateriaPrima.Name = "txtTipoMateriaPrima";
            this.txtTipoMateriaPrima.ReadOnly = true;
            this.txtTipoMateriaPrima.Size = new System.Drawing.Size(157, 22);
            this.txtTipoMateriaPrima.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(48, 102);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(194, 17);
            this.label14.TabIndex = 15;
            this.label14.Text = "Cantidad inicial Materia Prima";
            // 
            // Buscar
            // 
            this.Buscar.Controls.Add(this.dgvTablaCompras);
            this.Buscar.Controls.Add(this.cmbProveedor);
            this.Buscar.Controls.Add(this.label4);
            this.Buscar.Controls.Add(this.label3);
            this.Buscar.Controls.Add(this.pckFechaCompra);
            this.Buscar.Controls.Add(this.label2);
            this.Buscar.Controls.Add(this.label15);
            this.Buscar.Controls.Add(this.txtIdCompra1);
            this.Buscar.Location = new System.Drawing.Point(16, 79);
            this.Buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Buscar.Name = "Buscar";
            this.Buscar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Buscar.Size = new System.Drawing.Size(723, 364);
            this.Buscar.TabIndex = 32;
            this.Buscar.TabStop = false;
            this.Buscar.Text = "Buscar";
            this.Buscar.Enter += new System.EventHandler(this.seleccionarFilas);
            // 
            // dgvTablaCompras
            // 
            this.dgvTablaCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaCompras.Location = new System.Drawing.Point(183, 140);
            this.dgvTablaCompras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTablaCompras.Name = "dgvTablaCompras";
            this.dgvTablaCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTablaCompras.Size = new System.Drawing.Size(324, 217);
            this.dgvTablaCompras.TabIndex = 38;
            this.dgvTablaCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTablaCompras_CellContentClick_1);
            this.dgvTablaCompras.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.seleccionarFilas);
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(136, 82);
            this.cmbProveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(228, 24);
            this.cmbProveedor.TabIndex = 37;
            this.cmbProveedor.SelectedIndexChanged += new System.EventHandler(this.cmbProveedor_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Fecha de Compra";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pckFechaCompra
            // 
            this.pckFechaCompra.Location = new System.Drawing.Point(415, 36);
            this.pckFechaCompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pckFechaCompra.Name = "pckFechaCompra";
            this.pckFechaCompra.Size = new System.Drawing.Size(265, 22);
            this.pckFechaCompra.TabIndex = 34;
            this.pckFechaCompra.ValueChanged += new System.EventHandler(this.pckFechaCompra_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Compras";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(48, 36);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 17);
            this.label15.TabIndex = 1;
            this.label15.Text = "Id Compra";
            // 
            // txtIdCompra1
            // 
            this.txtIdCompra1.Enabled = false;
            this.txtIdCompra1.Location = new System.Drawing.Point(136, 36);
            this.txtIdCompra1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdCompra1.Name = "txtIdCompra1";
            this.txtIdCompra1.ReadOnly = true;
            this.txtIdCompra1.Size = new System.Drawing.Size(132, 22);
            this.txtIdCompra1.TabIndex = 0;
            // 
            // UIDevolucionMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 647);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.tlsBarraMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(761, 166);
            this.Name = "UIDevolucionMateriaPrima";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolución Materia Prima";
            this.tlsBarraMenu.ResumeLayout(false);
            this.tlsBarraMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Buscar.ResumeLayout(false);
            this.Buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlsBarraMenu;
        private System.Windows.Forms.ToolStripButton tsbConsultarCompraMP;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIdCompra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIdCompra2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTipoMateriaPrima;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox Buscar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtIdCompra1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ComboBox cmbRazon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker pckFechaCompra;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvTablaCompras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdDevolucion;
        private System.Windows.Forms.MaskedTextBox txtCantidadInicial;
    }
}