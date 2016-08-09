using System;
using System.Windows.Forms;

namespace Inventarios.WinForms
{
    public partial class UIModificacionMateria : Form
    {

        public UIModificacionMateria()
        {
            InitializeComponent();
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
           
            gpbAlta.Visible = true;
            tsbGuardar.Enabled = true;
        }

        private void MostrargpbBusquedaProductos()
        {
            gpbAlta.Visible = false;
            
            tsbGuardar.Enabled = false;
        }

     

        #endregion Form Event Handlers

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}