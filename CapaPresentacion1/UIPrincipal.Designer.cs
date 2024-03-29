﻿namespace Inventarios.WinForms
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
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiaPrimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionMateriaPrimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarMaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprarMateriaPrimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarMateriaPrimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lotizarMateriaPrimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarListaProductoTerminadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoTerminadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingrerarTipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoTerminadoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminaciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MnsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnsMenu
            // 
            this.MnsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedorToolStripMenuItem,
            this.materiaPrimaToolStripMenuItem,
            this.procesamientoToolStripMenuItem,
            this.productoTerminadoToolStripMenuItem});
            this.MnsMenu.Location = new System.Drawing.Point(0, 0);
            this.MnsMenu.Name = "MnsMenu";
            this.MnsMenu.Size = new System.Drawing.Size(751, 24);
            this.MnsMenu.TabIndex = 13;
            this.MnsMenu.Text = "menuStrip1";
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarProveedorToolStripMenuItem,
            this.consultarProveedorToolStripMenuItem,
            this.modificarProveedorToolStripMenuItem,
            this.eliminarProveedorToolStripMenuItem});
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.proveedorToolStripMenuItem.Text = "Proveedor";
            this.proveedorToolStripMenuItem.Click += new System.EventHandler(this.proveedorToolStripMenuItem_Click);
            // 
            // ingresarProveedorToolStripMenuItem
            // 
            this.ingresarProveedorToolStripMenuItem.Name = "ingresarProveedorToolStripMenuItem";
            this.ingresarProveedorToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.ingresarProveedorToolStripMenuItem.Text = "Ingreso";
            this.ingresarProveedorToolStripMenuItem.Click += new System.EventHandler(this.ingresarProveedorToolStripMenuItem_Click);
            // 
            // consultarProveedorToolStripMenuItem
            // 
            this.consultarProveedorToolStripMenuItem.Name = "consultarProveedorToolStripMenuItem";
            this.consultarProveedorToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.consultarProveedorToolStripMenuItem.Text = "Consulta";
            this.consultarProveedorToolStripMenuItem.Click += new System.EventHandler(this.consultarProveedorToolStripMenuItem_Click);
            // 
            // modificarProveedorToolStripMenuItem
            // 
            this.modificarProveedorToolStripMenuItem.Name = "modificarProveedorToolStripMenuItem";
            this.modificarProveedorToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.modificarProveedorToolStripMenuItem.Text = "Modificación";
            this.modificarProveedorToolStripMenuItem.Click += new System.EventHandler(this.modificarProveedorToolStripMenuItem_Click);
            // 
            // eliminarProveedorToolStripMenuItem
            // 
            this.eliminarProveedorToolStripMenuItem.Name = "eliminarProveedorToolStripMenuItem";
            this.eliminarProveedorToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.eliminarProveedorToolStripMenuItem.Text = "Eliminación";
            this.eliminarProveedorToolStripMenuItem.Click += new System.EventHandler(this.eliminarProveedorToolStripMenuItem_Click);
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
            this.consultarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarMaToolStripMenuItem});
            this.modificacionMateriaPrimaToolStripMenuItem.Name = "modificacionMateriaPrimaToolStripMenuItem";
            this.modificacionMateriaPrimaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.modificacionMateriaPrimaToolStripMenuItem.Text = "Tipo Materia Prima";
            this.modificacionMateriaPrimaToolStripMenuItem.Click += new System.EventHandler(this.modificacionMateriaPrimaToolStripMenuItem_Click);
            // 
            // ingresarToolStripMenuItem
            // 
            this.ingresarToolStripMenuItem.Name = "ingresarToolStripMenuItem";
            this.ingresarToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.ingresarToolStripMenuItem.Text = "Ingreso";
            this.ingresarToolStripMenuItem.Click += new System.EventHandler(this.ingresarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.consultarToolStripMenuItem.Text = "Consulta";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.modificarToolStripMenuItem.Text = "Modificación";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarMaToolStripMenuItem
            // 
            this.eliminarMaToolStripMenuItem.Name = "eliminarMaToolStripMenuItem";
            this.eliminarMaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.eliminarMaToolStripMenuItem.Text = "Eliminación";
            this.eliminarMaToolStripMenuItem.Click += new System.EventHandler(this.eliminarMaToolStripMenuItem_Click);
            // 
            // comprarMateriaPrimaToolStripMenuItem
            // 
            this.comprarMateriaPrimaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarToolStripMenuItem1,
            this.consultaToolStripMenuItem,
            this.modificarToolStripMenuItem1,
            this.eliminarToolStripMenuItem});
            this.comprarMateriaPrimaToolStripMenuItem.Name = "comprarMateriaPrimaToolStripMenuItem";
            this.comprarMateriaPrimaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.comprarMateriaPrimaToolStripMenuItem.Text = "Compra Materia Prima";
            // 
            // ingresarToolStripMenuItem1
            // 
            this.ingresarToolStripMenuItem1.Name = "ingresarToolStripMenuItem1";
            this.ingresarToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.ingresarToolStripMenuItem1.Text = "Ingreso";
            this.ingresarToolStripMenuItem1.Click += new System.EventHandler(this.ingresarToolStripMenuItem1_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.consultaToolStripMenuItem.Text = "Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem1
            // 
            this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            this.modificarToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.modificarToolStripMenuItem1.Text = "Modificación";
            this.modificarToolStripMenuItem1.Click += new System.EventHandler(this.modificarToolStripMenuItem1_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminación";
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
            this.modificarMateriaPrimaToolStripMenuItem.Size = new System.Drawing.Size(317, 22);
            this.modificarMateriaPrimaToolStripMenuItem.Text = "Devolución Materia Prima";
            this.modificarMateriaPrimaToolStripMenuItem.Click += new System.EventHandler(this.modificarMateriaPrimaToolStripMenuItem_Click);
            // 
            // lotizarMateriaPrimaToolStripMenuItem
            // 
            this.lotizarMateriaPrimaToolStripMenuItem.Name = "lotizarMateriaPrimaToolStripMenuItem";
            this.lotizarMateriaPrimaToolStripMenuItem.Size = new System.Drawing.Size(317, 22);
            this.lotizarMateriaPrimaToolStripMenuItem.Text = "Lotización Materia Prima";
            this.lotizarMateriaPrimaToolStripMenuItem.Click += new System.EventHandler(this.lotizarMateriaPrimaToolStripMenuItem_Click);
            // 
            // generarListaProductoTerminadoToolStripMenuItem
            // 
            this.generarListaProductoTerminadoToolStripMenuItem.Name = "generarListaProductoTerminadoToolStripMenuItem";
            this.generarListaProductoTerminadoToolStripMenuItem.Size = new System.Drawing.Size(317, 22);
            this.generarListaProductoTerminadoToolStripMenuItem.Text = "Generación Reporte Para Producto Terminado";
            this.generarListaProductoTerminadoToolStripMenuItem.Click += new System.EventHandler(this.generarListaProductoTerminadoToolStripMenuItem_Click);
            // 
            // productoTerminadoToolStripMenuItem
            // 
            this.productoTerminadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingrerarTipoToolStripMenuItem,
            this.productoTerminadoToolStripMenuItem1});
            this.productoTerminadoToolStripMenuItem.Name = "productoTerminadoToolStripMenuItem";
            this.productoTerminadoToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.productoTerminadoToolStripMenuItem.Text = "Producto Terminado";
            // 
            // ingrerarTipoToolStripMenuItem
            // 
            this.ingrerarTipoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inToolStripMenuItem,
            this.consultaToolStripMenuItem1,
            this.modificaciónToolStripMenuItem,
            this.eliminaciónToolStripMenuItem});
            this.ingrerarTipoToolStripMenuItem.Name = "ingrerarTipoToolStripMenuItem";
            this.ingrerarTipoToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.ingrerarTipoToolStripMenuItem.Text = "Tipo Producto Terminado ";
            this.ingrerarTipoToolStripMenuItem.Click += new System.EventHandler(this.ingrerarTipoToolStripMenuItem_Click);
            // 
            // inToolStripMenuItem
            // 
            this.inToolStripMenuItem.Name = "inToolStripMenuItem";
            this.inToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.inToolStripMenuItem.Text = "Ingreso";
            this.inToolStripMenuItem.Click += new System.EventHandler(this.inToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem1
            // 
            this.consultaToolStripMenuItem1.Name = "consultaToolStripMenuItem1";
            this.consultaToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.consultaToolStripMenuItem1.Text = "Consulta";
            this.consultaToolStripMenuItem1.Click += new System.EventHandler(this.consultaToolStripMenuItem1_Click);
            // 
            // modificaciónToolStripMenuItem
            // 
            this.modificaciónToolStripMenuItem.Name = "modificaciónToolStripMenuItem";
            this.modificaciónToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modificaciónToolStripMenuItem.Text = "Modificación";
            this.modificaciónToolStripMenuItem.Click += new System.EventHandler(this.modificaciónToolStripMenuItem_Click);
            // 
            // eliminaciónToolStripMenuItem
            // 
            this.eliminaciónToolStripMenuItem.Name = "eliminaciónToolStripMenuItem";
            this.eliminaciónToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eliminaciónToolStripMenuItem.Text = "Eliminación";
            this.eliminaciónToolStripMenuItem.Click += new System.EventHandler(this.eliminaciónToolStripMenuItem_Click);
            // 
            // productoTerminadoToolStripMenuItem1
            // 
            this.productoTerminadoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoToolStripMenuItem,
            this.consultaToolStripMenuItem2,
            this.modificaciónToolStripMenuItem1,
            this.eliminaciónToolStripMenuItem1});
            this.productoTerminadoToolStripMenuItem1.Name = "productoTerminadoToolStripMenuItem1";
            this.productoTerminadoToolStripMenuItem1.Size = new System.Drawing.Size(214, 22);
            this.productoTerminadoToolStripMenuItem1.Text = "Producto Terminado";
            // 
            // ingresoToolStripMenuItem
            // 
            this.ingresoToolStripMenuItem.Name = "ingresoToolStripMenuItem";
            this.ingresoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ingresoToolStripMenuItem.Text = "Ingreso";
            this.ingresoToolStripMenuItem.Click += new System.EventHandler(this.ingresoToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem2
            // 
            this.consultaToolStripMenuItem2.Name = "consultaToolStripMenuItem2";
            this.consultaToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.consultaToolStripMenuItem2.Text = "Consulta";
            this.consultaToolStripMenuItem2.Click += new System.EventHandler(this.consultaToolStripMenuItem2_Click);
            // 
            // modificaciónToolStripMenuItem1
            // 
            this.modificaciónToolStripMenuItem1.Name = "modificaciónToolStripMenuItem1";
            this.modificaciónToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.modificaciónToolStripMenuItem1.Text = "Modificación";
            this.modificaciónToolStripMenuItem1.Click += new System.EventHandler(this.modificaciónToolStripMenuItem1_Click);
            // 
            // eliminaciónToolStripMenuItem1
            // 
            this.eliminaciónToolStripMenuItem1.Name = "eliminaciónToolStripMenuItem1";
            this.eliminaciónToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.eliminaciónToolStripMenuItem1.Text = "Eliminación";
            this.eliminaciónToolStripMenuItem1.Click += new System.EventHandler(this.eliminaciónToolStripMenuItem1_Click);
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
            this.MinimumSize = new System.Drawing.Size(758, 492);
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
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingrerarTipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoTerminadoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ingresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem modificaciónToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminaciónToolStripMenuItem1;
    }
}

