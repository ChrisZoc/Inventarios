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
    public partial class UIEliminacionProductoTerminado : Form
    {
        GestorProductoTerminado gestorProductoTerminado;
        PRODUCTOTERMINADO proAux;
        public UIEliminacionProductoTerminado()
        {
            InitializeComponent();
            proAux = new PRODUCTOTERMINADO();
            gestorProductoTerminado = new GestorProductoTerminado();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbtNombre_CheckedChanged(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtCodigo.Enabled = false;
        }

        private void rbtCodigo_CheckedChanged(object sender, EventArgs e)
        {

            txtNombre.Enabled = false;
            txtCodigo.Enabled = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
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

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            gestorProductoTerminado = new GestorProductoTerminado();
            PRODUCTOTERMINADO productoTerminado = new PRODUCTOTERMINADO();
            GestorDevolucionProducto gestorDevolucionPoducto = new GestorDevolucionProducto();
            DEVOLUCIONPRODUCTOTERMINADO devolucionProducto = new DEVOLUCIONPRODUCTOTERMINADO();

            if (MessageBox.Show("¿Eliminar Producto Terminado?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                productoTerminado = gestorProductoTerminado.obtenerProductoTerminado(proAux);
                devolucionProducto.IDPRODUCTOTERMINADO = proAux.IDPRODUCTOTERMINADO;
                devolucionProducto = gestorDevolucionPoducto.obtenerDevolucion(devolucionProducto);
                MessageBox.Show(proAux.IDPRODUCTOTERMINADO.ToString(), "Zoc Vale arta", MessageBoxButtons.YesNo);
                gestorDevolucionPoducto.EliminarDevolucion(devolucionProducto);
                gestorProductoTerminado.EliminarProductoTerminado(productoTerminado);

                if ((MessageBox.Show("Eliminación realizada con éxito", "Información", MessageBoxButtons.OK)) == DialogResult.OK)
                {
                    limpiar();
                }
            }
        }

        private void dataGridProductoTerminado_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            proAux.IDPRODUCTOTERMINADO = Convert.ToInt32(dataGridProductoTerminado.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtNombre.Text = proAux.IDPRODUCTOTERMINADO.ToString();
           
        }

        private void tlsBarraMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridProductoTerminado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        
    }
}