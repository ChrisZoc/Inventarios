using System;
using System.Windows.Forms;
using Inventarios.ApplicationControl.Validation;
using Inventarios.ApplicationServices;
using Inventarios.ApplicationServices.Impl;
using Inventarios.Core;
using Inventarios.WinForms.SingletonModels;

namespace Inventarios.WinForms
{
    public partial class UIIngresoProveedor : Form
    {
        readonly IProductoService productoService;
        UIIngresoTipoMateriaPrima frmIngTipoMateriaPrima;


        public UIIngresoProveedor()
        {
            InitializeComponent();
            productoService = new ProductoService(new AlmacenORMDataContext());
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            

        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
        }

        private void lsvProductos_Click(object sender, EventArgs e)
        {
            gpbAlta.Visible = true;
            tsbCancelar.Enabled = true;
            ProductoForm.IsUpdate = true;

          
        }

        private void txtNombreBusqueda_TextChanged(object sender, EventArgs e)
        {
            
        }

        #region Form Event Handlers
        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            MostrargpbAltaProductos();
        }

        private void tsbBusqueda_Click(object sender, EventArgs e)
        {
            MostrargpbBusquedaProductos();
        }

        private void MostrargpbAltaProductos()
        {
            ProductoForm.IsUpdate = false;
            gpbAlta.Visible = true;
            tsbCancelar.Enabled = true;
        }

        private void MostrargpbBusquedaProductos()
        {
            gpbAlta.Visible = false;
            
            tsbCancelar.Enabled = false;
        }

     

        #endregion Form Event Handlers

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tsbIngresarTipoMP_Click(object sender, EventArgs e)
        {
            if (frmIngTipoMateriaPrima == null || frmIngTipoMateriaPrima.IsDisposed)
                frmIngTipoMateriaPrima = new UIIngresoTipoMateriaPrima();

            frmIngTipoMateriaPrima.Show();
            frmIngTipoMateriaPrima.BringToFront();
        }
    }
}