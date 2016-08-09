using System;
using System.Windows.Forms;
using CapaPersistencia;
using CapaNegocio;

namespace Inventarios.WinForms
{
    public partial class UIIngresoTipoProductoTerminado: Form
    {
        GestorTipoProductoTerminado gestorTipoProductoTerminado;

        public UIIngresoTipoProductoTerminado()
        {
            InitializeComponent();
            gestorTipoProductoTerminado = new GestorTipoProductoTerminado();
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            limpiar(); 
            
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

        private void gpbAlta_Enter(object sender, EventArgs e)
        {

        }

        private void tsbGuardar_Click_1(object sender, EventArgs e)
        {
            if (NombreTipoProductoTerminado.Text.Trim().Equals(""))
            {
                MessageBox.Show("No se ha escrito el tipo de Producto Terminado", "Información", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("¿Registrar Tipo Producto Terminado?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {


                    TIPOPRODUCTOTERMINADO tipoProductoTerminado = new TIPOPRODUCTOTERMINADO();

                    tipoProductoTerminado.NOMREPRODUCTOTERMINADO = NombreTipoProductoTerminado.Text.Trim();
                    tipoProductoTerminado = gestorTipoProductoTerminado.ingresoTipoProductoTerminado(tipoProductoTerminado);
                    txtIdTipoProductoTerminado.Text = tipoProductoTerminado.IDTIPOPRODUCTOTERMINADO.ToString();
                    if ((MessageBox.Show("Registrado con éxito", "Información", MessageBoxButtons.OK)) == DialogResult.OK)
                    {
                        limpiar();
                    }
                }
            }

        }

        private void limpiar()
        {
            NombreTipoProductoTerminado.Text = "";
            txtIdTipoProductoTerminado.Text = "";
        }
    }
}


