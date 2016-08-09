using System;
using System.Windows.Forms;
using CapaPersistencia;
using CapaNegocio;

namespace Inventarios.WinForms
{
    public partial class UIModificaciónTipoProductoTerminado : Form
    {
        GestorTipoProductoTerminado gestorTipoProductoTerminado;
        public UIModificaciónTipoProductoTerminado()
        {
            InitializeComponent();
            gestorTipoProductoTerminado = new GestorTipoProductoTerminado();

            cboxNomTipoProductoTerminado.ValueMember = "IDTIPOPRODUCTOTERMINADO";
            cboxNomTipoProductoTerminado.DisplayMember = "NOMREPRODUCTOTERMINADO";
            cboxNomTipoProductoTerminado.DataSource = gestorTipoProductoTerminado.obtenerTiposProductoTerminado();
            idTipoProductoTerminado.Enabled = false;
            textBNomTipoProductoTerminado.Enabled = false;
            cboxNomTipoProductoTerminado.DropDownStyle = ComboBoxStyle.DropDownList;
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

        private void Buscar_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            try
            {

                TIPOPRODUCTOTERMINADO tipoProductoTerminado = new TIPOPRODUCTOTERMINADO();
                if (MessageBox.Show("¿Modificar Tipo Producto Terminado?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    tipoProductoTerminado.NOMREPRODUCTOTERMINADO = textBNomTipoProductoTerminado.Text.ToString();
                    gestorTipoProductoTerminado.ActualizarNombreTipoProductoTerminado(Convert.ToInt32(idTipoProductoTerminado.Text), tipoProductoTerminado.NOMREPRODUCTOTERMINADO);
                    limpiar();
                    MessageBox.Show("Registro ingresado exitosamente", "Mensaje de Confirmación"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la aplicación. " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void limpiar()
        {



            gestorTipoProductoTerminado = new GestorTipoProductoTerminado();


            cboxNomTipoProductoTerminado.ValueMember = "IDTIPOPRODUCTOTERMINADO";
            cboxNomTipoProductoTerminado.DisplayMember = "NOMREPRODUCTOTERMINADO";
            cboxNomTipoProductoTerminado.DataSource = gestorTipoProductoTerminado.obtenerTiposProductoTerminado();
            textBNomTipoProductoTerminado.Text = "";
            idTipoProductoTerminado.Text = "";
            idTipoProductoTerminado.Enabled = false;
            textBNomTipoProductoTerminado.Enabled = false;
        }

        private void cboxNomTipoProductoTerminado_SelectedIndexChanged(object sender, EventArgs e)
        {
            TIPOPRODUCTOTERMINADO tipo = new TIPOPRODUCTOTERMINADO();
          TIPOPRODUCTOTERMINADO tipo_recuperado = new TIPOPRODUCTOTERMINADO();


          
          tipo.IDTIPOPRODUCTOTERMINADO = Convert.ToInt32(cboxNomTipoProductoTerminado.SelectedValue);

         idTipoProductoTerminado.Text=cboxNomTipoProductoTerminado.SelectedValue.ToString();


         tipo_recuperado=gestorTipoProductoTerminado.obtenerTipoProductoTerminado(tipo);

         textBNomTipoProductoTerminado.Text = tipo_recuperado.NOMREPRODUCTOTERMINADO;

         textBNomTipoProductoTerminado.Enabled = true;
        
        }

    }
}