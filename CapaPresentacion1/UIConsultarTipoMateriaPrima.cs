using System;
using System.Windows.Forms;
using CapaNegocio;
using CapaPersistencia;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventarios.WinForms
{
    public partial class UIConsultarTipoMateriaPrima : Form
    {
        GestorTipoMateriaPrima gestorTipoMateriaPrima;

        public UIConsultarTipoMateriaPrima()
        {
            InitializeComponent();
            gestorTipoMateriaPrima = new GestorTipoMateriaPrima();
         



        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void rbtCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtCodigo.Enabled = true;
            txtNombre.Enabled = false;
            txtNombre.Text = "";
           


        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtCodigo.Text = "";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            limpiar();
            dataGridTipoMateriaPrima.DataSource = null;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            dataGridTipoMateriaPrima.Visible = true;

            TIPOMATERIAPRIMA tipoMateriaPrima = new TIPOMATERIAPRIMA();
            TIPOPRODUCTOTERMINADO lista = new TIPOPRODUCTOTERMINADO();
            if (txtNombre.Text.Equals("") && (txtCodigo.Enabled = false))
            {
                MessageBox.Show("No se ha escrito el tipo de Producto Terminado a buscar", "Información", MessageBoxButtons.OK);
                limpiar();
            }
            else
            {
                tipoMateriaPrima.NOMBRETIPOMATERIAPRIMA = txtNombre.Text;
                try
                {
                    dataGridTipoMateriaPrima.DataSource = (gestorTipoMateriaPrima.obtenerListaTipoMateriaPrima(tipoMateriaPrima));

                    if (txtCodigo.Text.Equals("") && (txtNombre.Enabled = false))
                    {
                        MessageBox.Show("No se ha escrito el tipo de Producto Terminado a buscar", "Información", MessageBoxButtons.OK);
                        limpiar();
                    }
                    else
                    {

                        tipoMateriaPrima.IDTIPOMATERIAPRIMA = Convert.ToInt32(txtCodigo.Text);
                        dataGridTipoMateriaPrima.DataSource = (gestorTipoMateriaPrima.obtenerListaTipoMateriaPrima(tipoMateriaPrima));
                        dataGridTipoMateriaPrima.Columns.RemoveAt(2);
                    }
                    dataGridTipoMateriaPrima.Columns.RemoveAt(2);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error en la aplicación. " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }



        }

        private void dataGridTipoMateriaPrima_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void UIConsultarTipoMateriaPrima_Load(object sender, EventArgs e)
        {

        }

        private void rbtNombre_CheckedChanged(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtCodigo.Enabled = false;
            txtCodigo.Text = "";


        }

        private void limpiar()
        {
            rbtNombre.Checked = true;
            rbtCodigo.Checked = false;
            txtCodigo.Text = "";
            txtNombre.Text = "";

            rbtCodigo.Enabled = true;
            rbtNombre.Enabled = true;
            txtNombre.Enabled = true;
            txtCodigo.Enabled = false;

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }




    }
}