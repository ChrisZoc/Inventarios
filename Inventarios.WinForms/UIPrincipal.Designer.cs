namespace Inventarios.WinForms
{
    partial class UIPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIPrincipal));
            this.MnsMenu = new System.Windows.Forms.MenuStrip();
            this.materiaPrimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionMateriaPrimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarMaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprarMateriaPrimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarMateriaPrimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lotizarMateriaPrimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarListaProductoTerminadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoTerminadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarProductoTerminadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProductoTerminadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProductoTerminadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminacionProductoTerminadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnsMenu
            // 
            this.MnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materiaPrimaToolStripMenuItem,
            this.procesamientoToolStripMenuItem,
            this.productoTerminadoToolStripMenuItem,
            this.proveedorToolStripMenuItem});
            this.MnsMenu.Location = new System.Drawing.Point(0, 0);
            this.MnsMenu.Name = "MnsMenu";
            this.MnsMenu.Size = new System.Drawing.Size(751, 24);
            this.MnsMenu.TabIndex = 13;
            this.MnsMenu.Text = "menuStrip1";
            // 
            // materiaPrimaToolStripMenuItem
            // 
            this.materiaPrimaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificacionMateriaPrimaToolStripMenuItem,
            this.comprarMateriaPrimaToolStripMenuItem});
            this.materiaPrimaToolStripMenuItem.Name = "materiaPrimaToolStripMenuItem";
            this.materiaPrimaToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.materiaPrimaToolStripMenuItem.Text = "Materia Prima";
            this.materiaPrimaToolStripMenuItem.Click += new System.EventHandler(this.materiaPrimaToolStripMenuItem_Click);
            // 
            // modificacionMateriaPrimaToolStripMenuItem
            // 
            this.modificacionMateriaPrimaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarMaToolStripMenuItem});
            this.modificacionMateriaPrimaToolStripMenuItem.Name = "modificacionMateriaPrimaToolStripMenuItem";
            this.modificacionMateriaPrimaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.modificacionMateriaPrimaToolStripMenuItem.Text = "Tipo Materia Prima";
            // 
            // ingresarToolStripMenuItem
            // 
            this.ingresarToolStripMenuItem.Name = "ingresarToolStripMenuItem";
            this.ingresarToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.ingresarToolStripMenuItem.Text = "Ingreso Tipo Materia Prima";
            this.ingresarToolStripMenuItem.Click += new System.EventHandler(this.ingresarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.modificarToolStripMenuItem.Text = "Modificación Tipo Materia Prima";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarMaToolStripMenuItem
            // 
            this.eliminarMaToolStripMenuItem.Name = "eliminarMaToolStripMenuItem";
            this.eliminarMaToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.eliminarMaToolStripMenuItem.Text = "Eliminación Tipo Materia Prima";
            this.eliminarMaToolStripMenuItem.Click += new System.EventHandler(this.eliminarMaToolStripMenuItem_Click);
            // 
            // comprarMateriaPrimaToolStripMenuItem
            // 
            this.comprarMateriaPrimaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarToolStripMenuItem1,
            this.modificarToolStripMenuItem1,
            this.eliminarToolStripMenuItem});
            this.comprarMateriaPrimaToolStripMenuItem.Name = "comprarMateriaPrimaToolStripMenuItem";
            this.comprarMateriaPrimaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.comprarMateriaPrimaToolStripMenuItem.Text = "Compra Materia Prima";
            // 
            // ingresarToolStripMenuItem1
            // 
            this.ingresarToolStripMenuItem1.Name = "ingresarToolStripMenuItem1";
            this.ingresarToolStripMenuItem1.Size = new System.Drawing.Size(267, 22);
            this.ingresarToolStripMenuItem1.Text = "Ingreso Compra Materia Prima";
            this.ingresarToolStripMenuItem1.Click += new System.EventHandler(this.ingresarToolStripMenuItem1_Click);
            // 
            // modificarToolStripMenuItem1
            // 
            this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            this.modificarToolStripMenuItem1.Size = new System.Drawing.Size(267, 22);
            this.modificarToolStripMenuItem1.Text = "Modificación Compra Materia Prima";
            this.modificarToolStripMenuItem1.Click += new System.EventHandler(this.modificarToolStripMenuItem1_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminación Compra Materia Prima";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // procesamientoToolStripMenuItem
            // 
            this.procesamientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarMateriaPrimaToolStripMenuItem,
            this.lotizarMateriaPrimaToolStripMenuItem,
            this.generarListaProductoTerminadoToolStripMenuItem});
            this.procesamientoToolStripMenuItem.Name = "procesamientoToolStripMenuItem";
            this.procesamientoToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.procesamientoToolStripMenuItem.Text = "Procesamiento";
            // 
            // modificarMateriaPrimaToolStripMenuItem
            // 
            this.modificarMateriaPrimaToolStripMenuItem.Name = "modificarMateriaPrimaToolStripMenuItem";
            this.modificarMateriaPrimaToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.modificarMateriaPrimaToolStripMenuItem.Text = "Modificación Materia Prima";
            this.modificarMateriaPrimaToolStripMenuItem.Click += new System.EventHandler(this.modificarMateriaPrimaToolStripMenuItem_Click);
            // 
            // lotizarMateriaPrimaToolStripMenuItem
            // 
            this.lotizarMateriaPrimaToolStripMenuItem.Name = "lotizarMateriaPrimaToolStripMenuItem";
            this.lotizarMateriaPrimaToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.lotizarMateriaPrimaToolStripMenuItem.Text = "Lotización Materia Prima";
            this.lotizarMateriaPrimaToolStripMenuItem.Click += new System.EventHandler(this.lotizarMateriaPrimaToolStripMenuItem_Click);
            // 
            // generarListaProductoTerminadoToolStripMenuItem
            // 
            this.generarListaProductoTerminadoToolStripMenuItem.Name = "generarListaProductoTerminadoToolStripMenuItem";
            this.generarListaProductoTerminadoToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.generarListaProductoTerminadoToolStripMenuItem.Text = "Generación Lista Producto Terminado";
            this.generarListaProductoTerminadoToolStripMenuItem.Click += new System.EventHandler(this.generarListaProductoTerminadoToolStripMenuItem_Click);
            // 
            // productoTerminadoToolStripMenuItem
            // 
            this.productoTerminadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarProductoTerminadoToolStripMenuItem,
            this.consultarProductoTerminadoToolStripMenuItem,
            this.modificarProductoTerminadoToolStripMenuItem,
            this.eliminacionProductoTerminadoToolStripMenuItem});
            this.productoTerminadoToolStripMenuItem.Name = "productoTerminadoToolStripMenuItem";
            this.productoTerminadoToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.productoTerminadoToolStripMenuItem.Text = "Producto Terminado";
            // 
            // ingresarProductoTerminadoToolStripMenuItem
            // 
            this.ingresarProductoTerminadoToolStripMenuItem.Name = "ingresarProductoTerminadoToolStripMenuItem";
            this.ingresarProductoTerminadoToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.ingresarProductoTerminadoToolStripMenuItem.Text = "Ingreso Producto Terminado";
            this.ingresarProductoTerminadoToolStripMenuItem.Click += new System.EventHandler(this.ingresarProductoTerminadoToolStripMenuItem_Click);
            // 
            // consultarProductoTerminadoToolStripMenuItem
            // 
            this.consultarProductoTerminadoToolStripMenuItem.Name = "consultarProductoTerminadoToolStripMenuItem";
            this.consultarProductoTerminadoToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.consultarProductoTerminadoToolStripMenuItem.Text = "Consulta Producto Terminado";
            this.consultarProductoTerminadoToolStripMenuItem.Click += new System.EventHandler(this.consultarProductoTerminadoToolStripMenuItem_Click);
            // 
            // modificarProductoTerminadoToolStripMenuItem
            // 
            this.modificarProductoTerminadoToolStripMenuItem.Name = "modificarProductoTerminadoToolStripMenuItem";
            this.modificarProductoTerminadoToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.modificarProductoTerminadoToolStripMenuItem.Text = "Modificación Producto Terminado";
            this.modificarProductoTerminadoToolStripMenuItem.Click += new System.EventHandler(this.modificarProductoTerminadoToolStripMenuItem_Click);
            // 
            // eliminacionProductoTerminadoToolStripMenuItem
            // 
            this.eliminacionProductoTerminadoToolStripMenuItem.Name = "eliminacionProductoTerminadoToolStripMenuItem";
            this.eliminacionProductoTerminadoToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.eliminacionProductoTerminadoToolStripMenuItem.Text = "Eliminacion Producto Terminado";
            this.eliminacionProductoTerminadoToolStripMenuItem.Click += new System.EventHandler(this.eliminacionProductoTerminadoToolStripMenuItem_Click);
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarProveedorToolStripMenuItem,
            this.eliminarProveedorToolStripMenuItem,
            this.modificarProveedorToolStripMenuItem,
            this.consultarProveedorToolStripMenuItem});
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.proveedorToolStripMenuItem.Text = "Proveedor";
            // 
            // ingresarProveedorToolStripMenuItem
            // 
            this.ingresarProveedorToolStripMenuItem.Name = "ingresarProveedorToolStripMenuItem";
            this.ingresarProveedorToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.ingresarProveedorToolStripMenuItem.Text = "Ingreso Proveedor";
            this.ingresarProveedorToolStripMenuItem.Click += new System.EventHandler(this.ingresarProveedorToolStripMenuItem_Click);
            // 
            // eliminarProveedorToolStripMenuItem
            // 
            this.eliminarProveedorToolStripMenuItem.Name = "eliminarProveedorToolStripMenuItem";
            this.eliminarProveedorToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.eliminarProveedorToolStripMenuItem.Text = "Eliminación Proveedor";
            this.eliminarProveedorToolStripMenuItem.Click += new System.EventHandler(this.eliminarProveedorToolStripMenuItem_Click);
            // 
            // modificarProveedorToolStripMenuItem
            // 
            this.modificarProveedorToolStripMenuItem.Name = "modificarProveedorToolStripMenuItem";
            this.modificarProveedorToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.modificarProveedorToolStripMenuItem.Text = "Modificación Proveedor";
            this.modificarProveedorToolStripMenuItem.Click += new System.EventHandler(this.modificarProveedorToolStripMenuItem_Click);
            // 
            // consultarProveedorToolStripMenuItem
            // 
            this.consultarProveedorToolStripMenuItem.Name = "consultarProveedorToolStripMenuItem";
            this.consultarProveedorToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.consultarProveedorToolStripMenuItem.Text = "Consulta Proveedor";
            this.consultarProveedorToolStripMenuItem.Click += new System.EventHandler(this.consultarProveedorToolStripMenuItem_Click);
            // 
            // UIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(751, 459);
            this.Controls.Add(this.MnsMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MnsMenu;
            this.MinimumSize = new System.Drawing.Size(759, 493);
            this.Name = "UIPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MnsMenu.ResumeLayout(false);
            this.MnsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnsMenu;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiaPrimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoTerminadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesamientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarMateriaPrimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lotizarMateriaPrimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarListaProductoTerminadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificacionMateriaPrimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprarMateriaPrimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarMaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarProductoTerminadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarProductoTerminadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarProductoTerminadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminacionProductoTerminadoToolStripMenuItem;
    }
}

