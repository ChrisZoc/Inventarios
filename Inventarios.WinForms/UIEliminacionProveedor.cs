using System;
using System.Windows.Forms;
using Inventarios.ApplicationControl.Validation;
using Inventarios.ApplicationServices;
using Inventarios.ApplicationServices.Impl;
using Inventarios.Core;
using Inventarios.WinForms.SingletonModels;

namespace Inventarios.WinForms
{
    public partial class UIEliminacionProveedor : Form
    {
        readonly IProductoService productoService;

        public UIEliminacionProveedor()
        {
            InitializeComponent();
            productoService = new ProductoService(new AlmacenORMDataContext());
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
        }

        private void lsvProductos_Click(object sender, EventArgs e)
        {
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
          
            tsbCancelar.Enabled = true;
        }

        private void MostrargpbBusquedaProductos()
        {            
            tsbCancelar.Enabled = false;
        }

     

        #endregion Form Event Handlers

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}