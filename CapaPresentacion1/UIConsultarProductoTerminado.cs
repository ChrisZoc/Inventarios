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
    public partial class UIConsultarProductoTerminado : Form
    {
        GestorProductoTerminado gestorProductoTerminado;
        public UIConsultarProductoTerminado()
        {
            InitializeComponent();
            gestorProductoTerminado = new GestorProductoTerminado();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtCodigo.Enabled = false;
            txtNombre.Enabled = true;

        }

        private void rbtCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtNombre.Enabled = false;
            txtCodigo.Enabled = true;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtCodigo.Text = "";

        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            TIPOPRODUCTOTERMINADO tipoProductoTerminado = new TIPOPRODUCTOTERMINADO();
            PRODUCTOTERMINADO productoTerminado = new PRODUCTOTERMINADO();
            resultadoProductoTerminado lista = new resultadoProductoTerminado();
            if (txtNombre.Text.Equals("") && (txtCodigo.Enabled = false))
            {
                MessageBox.Show("No se ha escrito el tipo de Producto Terminado a buscar", "Información", MessageBoxButtons.OK);
            }
            else
            {
                tipoProductoTerminado.NOMREPRODUCTOTERMINADO = txtNombre.Text;

                try
                {
                    dataGridProductoTerminado.DataSource = (gestorProductoTerminado.obtenerListaProductoTerminadoPorNombre(tipoProductoTerminado));
                    //dataGridProductoTerminado.Columns.RemoveAt(8);
                    if (txtCodigo.Text.Equals("") && (txtNombre.Enabled = false))
                    {
                        MessageBox.Show("No se ha escrito el tipo de Producto Terminado a buscar", "Información", MessageBoxButtons.OK);
                    }
                    else
                    {

                        productoTerminado.IDPRODUCTOTERMINADO = Convert.ToInt32(txtCodigo.Text);
                        dataGridProductoTerminado.DataSource = (gestorProductoTerminado.obtenerListaProductoTerminadoPorID(productoTerminado));

                    }

                    //dataGridProductoTerminado.Columns.RemoveAt(2);

                }
                catch (Exception ex)
                {
                }
                limpiar();
            }  
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

      

    }
}