using System;
using System.Windows.Forms;
using CapaPersistencia;
using CapaNegocio;


namespace Inventarios.WinForms
{
    public partial class UIEliminaciónTipoProductoTerminado : Form
    {
        GestorTipoProductoTerminado gestorTipoProductoTerminado;
        public UIEliminaciónTipoProductoTerminado()
        {
            InitializeComponent();
            gestorTipoProductoTerminado = new GestorTipoProductoTerminado();

            cbxNombreTipoProductoTerminado.ValueMember = "IDTIPOPRODUCTOTERMINADO";
            cbxNombreTipoProductoTerminado.DisplayMember = "NOMREPRODUCTOTERMINADO";
            cbxNombreTipoProductoTerminado.DataSource = gestorTipoProductoTerminado.obtenerTiposProductoTerminado();
            txtIdTipoProductoTerminado.Enabled = false;
            cbxNombreTipoProductoTerminado.DropDownStyle = ComboBoxStyle.DropDownList;
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

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridProductoTerminado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbxNombreTipoProductoTerminado_SelectedIndexChanged(object sender, EventArgs e)
        {
            TIPOPRODUCTOTERMINADO tipo = new TIPOPRODUCTOTERMINADO();
            TIPOPRODUCTOTERMINADO tipo_recuperado = new TIPOPRODUCTOTERMINADO();



            tipo.IDTIPOPRODUCTOTERMINADO = Convert.ToInt32(cbxNombreTipoProductoTerminado.SelectedValue);

            txtIdTipoProductoTerminado.Text = cbxNombreTipoProductoTerminado.SelectedValue.ToString();


            tipo_recuperado = gestorTipoProductoTerminado.ingresoTipoProductoTerminado(tipo);

            txtIdTipoProductoTerminado.Text = Convert.ToString(tipo_recuperado.IDTIPOPRODUCTOTERMINADO);
            try
            {
                dataGridProductoTerminado.DataSource = (gestorTipoProductoTerminado.obtenerListaProductoTerminado(tipo));


                    tipo.IDTIPOPRODUCTOTERMINADO = Convert.ToInt32(txtIdTipoProductoTerminado.Text);
                    dataGridProductoTerminado.DataSource = (gestorTipoProductoTerminado.obtenerListaProductoTerminado(tipo));

                dataGridProductoTerminado.Columns.RemoveAt(2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la aplicación. " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        
        }
        public void limpiar()
        {
            gestorTipoProductoTerminado = new GestorTipoProductoTerminado();


            cbxNombreTipoProductoTerminado.ValueMember = "IDTIPOPRODUCTOTERMINADO";
            cbxNombreTipoProductoTerminado.DisplayMember = "NOMREPRODUCTOTERMINADO";
            cbxNombreTipoProductoTerminado.DataSource = gestorTipoProductoTerminado.obtenerTiposProductoTerminado();
            txtIdTipoProductoTerminado.Text = "";
            txtIdTipoProductoTerminado.Text = "";
            txtIdTipoProductoTerminado.Enabled = false;
            txtIdTipoProductoTerminado.Enabled = false;
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                TIPOPRODUCTOTERMINADO tipoProductoTerminado = new TIPOPRODUCTOTERMINADO();
                if (MessageBox.Show("¿Eliminar Tipo Producto Terminado?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    tipoProductoTerminado.IDTIPOPRODUCTOTERMINADO = Convert.ToInt32(txtIdTipoProductoTerminado.Text);
                    gestorTipoProductoTerminado.EliminarTipoProductoTerminado(tipoProductoTerminado);
                    limpiar();
                    MessageBox.Show("Registro eliminado exitosamente", "Mensaje de Confirmación"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la aplicación. " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}