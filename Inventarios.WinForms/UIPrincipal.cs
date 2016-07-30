using System;
using System.Windows.Forms;

namespace Inventarios.WinForms
{
    public partial class UIPrincipal : Form
    {
        UIConsultaProveedor frmConProveedor;
        UIIngresoProveedor frmIngProveedor;
        UIIngresoTipoMateriaPrima frmIngTipoMateriaPrima;
        UIModificaciónTipoMateriaPrima frmModifTipoMateriaPrima;
        UIEliminaciónTipoMateriaPrima frmEliminacionTipoMateriaPrima;
        UIIngresoCompraMateriaPrima frmIngresarCompraMateriaPrima;
        UIModificarCompraMateriaPrima frmModificarCompraMateriaPrima;
        UIEliminacionCompraMateriaPrima frmEliminacionCompraMateriaPrima;
        UIDevolucionMateriaPrima frmModificacionMateriaPrima;
        UILotizacionMateriaPrima frmLotizacionMateriaPrima;
        UIGeneracionReporteParaProductoTerminado frmGeneracionListaProductoTerminado;
        UIIngresoProductoTerminado frmIngresoProductoTerminado;
        UIConsultarProductoTerminado frmConsultarProductoTerminado;
        UIModificaciónProductoTerminado frmModificaciónProductoTerminado;
        UIEliminacionProductoTerminado frmEliminacionProductoTerminado;
        UIModificacionProveedor frmModificacionProveedor;
        UIEliminacionProveedor frmEliminacionProveedor;
        UIConsultarCompraMateriaPrima frmConsultarCompraMateriaPrima;
        UIConsultarTipoMateriaPrima frmConsultarTipoMateriaPrima;
        public UIPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void consultarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmConProveedor == null || frmConProveedor.IsDisposed)
                frmConProveedor = new UIConsultaProveedor();

            frmConProveedor.MdiParent = this;
            frmConProveedor.Show();
            frmConProveedor.BringToFront();
        }

        private void ingresarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmIngProveedor == null || frmIngProveedor.IsDisposed)
                frmIngProveedor = new UIIngresoProveedor();

            frmIngProveedor.MdiParent = this;
            frmIngProveedor.Show();
            frmIngProveedor.BringToFront();
        }

        private void materiaPrimaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (frmModificarCompraMateriaPrima == null || frmModificarCompraMateriaPrima.IsDisposed)
                frmModificarCompraMateriaPrima = new UIModificarCompraMateriaPrima();

            frmModificarCompraMateriaPrima.MdiParent = this;
            frmModificarCompraMateriaPrima.Show();
            frmModificarCompraMateriaPrima.BringToFront();
        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmIngTipoMateriaPrima == null || frmIngTipoMateriaPrima.IsDisposed)
                frmIngTipoMateriaPrima = new UIIngresoTipoMateriaPrima();

            frmIngTipoMateriaPrima.MdiParent = this;
            frmIngTipoMateriaPrima.Show();
            frmIngTipoMateriaPrima.BringToFront();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (frmModifTipoMateriaPrima == null || frmModifTipoMateriaPrima.IsDisposed)
                frmModifTipoMateriaPrima = new UIModificaciónTipoMateriaPrima();

            frmModifTipoMateriaPrima.MdiParent = this;
            frmModifTipoMateriaPrima.Show();
            frmModifTipoMateriaPrima.BringToFront();
        }

        private void eliminarMaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (frmEliminacionTipoMateriaPrima == null || frmEliminacionTipoMateriaPrima.IsDisposed)
                frmEliminacionTipoMateriaPrima = new UIEliminaciónTipoMateriaPrima();

            frmEliminacionTipoMateriaPrima.MdiParent = this;
            frmEliminacionTipoMateriaPrima.Show();
            frmEliminacionTipoMateriaPrima.BringToFront();
        }

        private void ingresarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (frmIngresarCompraMateriaPrima == null || frmIngresarCompraMateriaPrima.IsDisposed)
                frmIngresarCompraMateriaPrima = new UIIngresoCompraMateriaPrima();

            frmIngresarCompraMateriaPrima.MdiParent = this;
            frmIngresarCompraMateriaPrima.Show();
            frmIngresarCompraMateriaPrima.BringToFront();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmEliminacionCompraMateriaPrima == null || frmEliminacionCompraMateriaPrima.IsDisposed)
                frmEliminacionCompraMateriaPrima = new UIEliminacionCompraMateriaPrima();

            frmEliminacionCompraMateriaPrima.MdiParent = this;
            frmEliminacionCompraMateriaPrima.Show();
            frmEliminacionCompraMateriaPrima.BringToFront();
        }

        private void modificarMateriaPrimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                 if (frmModificacionMateriaPrima == null || frmModificacionMateriaPrima.IsDisposed)
                frmModificacionMateriaPrima = new UIDevolucionMateriaPrima();

            frmModificacionMateriaPrima.MdiParent = this;
            frmModificacionMateriaPrima.Show();
            frmModificacionMateriaPrima.BringToFront();
        }

        private void lotizarMateriaPrimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                if (frmLotizacionMateriaPrima == null || frmLotizacionMateriaPrima.IsDisposed)
                frmLotizacionMateriaPrima = new UILotizacionMateriaPrima();

            frmLotizacionMateriaPrima.MdiParent = this;
            frmLotizacionMateriaPrima.Show();
            frmLotizacionMateriaPrima.BringToFront();
        }

        private void generarListaProductoTerminadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmGeneracionListaProductoTerminado == null || frmGeneracionListaProductoTerminado.IsDisposed)
               frmGeneracionListaProductoTerminado = new UIGeneracionReporteParaProductoTerminado();

            frmGeneracionListaProductoTerminado.MdiParent = this;
            frmGeneracionListaProductoTerminado.Show();
            frmGeneracionListaProductoTerminado.BringToFront();
        }

        private void ingresarProductoTerminadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmIngresoProductoTerminado == null || frmIngresoProductoTerminado.IsDisposed)
                    frmIngresoProductoTerminado = new UIIngresoProductoTerminado();

            frmIngresoProductoTerminado.MdiParent = this;
            frmIngresoProductoTerminado.Show();
            frmIngresoProductoTerminado.BringToFront();
        }

        private void consultarProductoTerminadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmConsultarProductoTerminado == null || frmConsultarProductoTerminado.IsDisposed)
                     frmConsultarProductoTerminado = new UIConsultarProductoTerminado();

            frmConsultarProductoTerminado.MdiParent = this;
            frmConsultarProductoTerminado.Show();
            frmConsultarProductoTerminado.BringToFront();
        }

        private void modificarProductoTerminadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if (frmModificaciónProductoTerminado == null || frmModificaciónProductoTerminado.IsDisposed)
                    frmModificaciónProductoTerminado = new UIModificaciónProductoTerminado();

            frmModificaciónProductoTerminado.MdiParent = this;
            frmModificaciónProductoTerminado.Show();
            frmModificaciónProductoTerminado.BringToFront();
        }

        private void eliminacionProductoTerminadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmEliminacionProductoTerminado == null || frmEliminacionProductoTerminado.IsDisposed)
                    frmEliminacionProductoTerminado = new UIEliminacionProductoTerminado();

            frmEliminacionProductoTerminado.MdiParent = this;
            frmEliminacionProductoTerminado.Show();
            frmEliminacionProductoTerminado.BringToFront();
        }

        private void modificarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
                
        if (frmModificacionProveedor == null || frmModificacionProveedor.IsDisposed)
            frmModificacionProveedor = new UIModificacionProveedor();

            frmModificacionProveedor.MdiParent = this;
            frmModificacionProveedor.Show();
            frmModificacionProveedor.BringToFront();
        }

        private void eliminarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
                if (frmEliminacionProveedor == null || frmEliminacionProveedor.IsDisposed)
                    frmEliminacionProveedor = new UIEliminacionProveedor();

            frmEliminacionProveedor.MdiParent = this;
            frmEliminacionProveedor.Show();
            frmEliminacionProveedor.BringToFront();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificacionMateriaPrimaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmConsultarTipoMateriaPrima == null || frmConsultarTipoMateriaPrima.IsDisposed)
                frmConsultarTipoMateriaPrima = new UIConsultarTipoMateriaPrima();

            frmConsultarTipoMateriaPrima.Show();
            frmConsultarTipoMateriaPrima.BringToFront();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmConsultarCompraMateriaPrima == null || frmConsultarCompraMateriaPrima.IsDisposed)
                frmConsultarCompraMateriaPrima = new UIConsultarCompraMateriaPrima();

            frmConsultarCompraMateriaPrima.Show();
            frmConsultarCompraMateriaPrima.BringToFront();
        }
    }
}
