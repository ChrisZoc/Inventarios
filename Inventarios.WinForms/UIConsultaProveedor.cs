using System;
using System.Windows.Forms;
using Inventarios.ApplicationControl.Validation;
using Inventarios.ApplicationServices;
using Inventarios.ApplicationServices.Impl;
using Inventarios.Core;
using Inventarios.WinForms.SingletonModels;

namespace Inventarios.WinForms
{
    public partial class UIConsultaProveedor : Form
    {
        readonly IProductoService productoService;

        public UIConsultaProveedor()
        {
            InitializeComponent();
            productoService = new ProductoService(new AlmacenORMDataContext());
            MostrargpbBusquedaProductos();

        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            
        }

        private void lsvProductos_Click(object sender, EventArgs e)
        {
           
            gpbBusqueda.Visible = true;
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
           
        }

        private void tsbBusqueda_Click(object sender, EventArgs e)
        {
            MostrargpbBusquedaProductos();
        }

        private void MostrargpbBusquedaProductos()
        {
            gpbBusqueda.Visible = true;
            txtNombreBusqueda.Focus();
        }

       
       
        #endregion Form Event Handlers

        private void gpbBusqueda_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lsvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}