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
    public partial class UIConsultarTipoProductoTerminado : Form
    {
        GestorTipoProductoTerminado gestorTipoProductoTerminado;
        public UIConsultarTipoProductoTerminado()
        {
            InitializeComponent();
            gestorTipoProductoTerminado=new GestorTipoProductoTerminado();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtCodigo.Enabled = false;
            txtCodigo.Text = "";
           

        }

        private void rbtCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtCodigo.Enabled = true;
            txtNombre.Enabled = false;
            txtNombre.Text = "";

         
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            limpiar();
            dataGridTipoProductoTerminado.DataSource = null;

        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            TIPOPRODUCTOTERMINADO tipoProductoTerminado = new TIPOPRODUCTOTERMINADO();
            TIPOPRODUCTOTERMINADO lista = new TIPOPRODUCTOTERMINADO();
            if (txtNombre.Text.Equals("") && (txtCodigo.Enabled = false))
            {
                MessageBox.Show("No se ha escrito el tipo de Producto Terminado a buscar", "Información", MessageBoxButtons.OK);
            }
            else
            {
                tipoProductoTerminado.NOMREPRODUCTOTERMINADO = txtNombre.Text;
                
                try
                {
                    dataGridTipoProductoTerminado.DataSource = (gestorTipoProductoTerminado.obtenerListaProductoTerminado(tipoProductoTerminado));
                    dataGridTipoProductoTerminado.Columns.RemoveAt(2);
                    if (txtCodigo.Text.Equals("") && (txtNombre.Enabled = false))
                    {
                        MessageBox.Show("No se ha escrito el tipo de Producto Terminado a buscar", "Información", MessageBoxButtons.OK);
                    }
                    else
                    {

                        tipoProductoTerminado.IDTIPOPRODUCTOTERMINADO = Convert.ToInt32(txtCodigo.Text);
                        dataGridTipoProductoTerminado.DataSource = (gestorTipoProductoTerminado.obtenerListaProductoTerminado(tipoProductoTerminado));
                        
                    }
                    
                    dataGridTipoProductoTerminado.Columns.RemoveAt(2);
                    
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