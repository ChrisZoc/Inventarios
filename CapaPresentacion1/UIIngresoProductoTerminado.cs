using System;
using System.Windows.Forms;
using CapaPersistencia;
using CapaNegocio;

namespace Inventarios.WinForms
{
    public partial class UIIngresoProductoTerminado : Form
    {
        UIIngresoTipoMateriaPrima frmIngTipoMateriaPrima;
        GestorProductoTerminado gestorProductoTerminado = new GestorProductoTerminado();
        public UIIngresoProductoTerminado()
        {
            InitializeComponent();
            GestorTipoProductoTerminado gestorTipoProductoTerminado = new GestorTipoProductoTerminado();
            cboxTipo.ValueMember = "IDTIPOPRODUCTOTERMINADO";
            cboxTipo.DisplayMember = "NOMREPRODUCTOTERMINADO";
            cboxTipo.DataSource = gestorTipoProductoTerminado.obtenerTiposProductoTerminado();
            cboxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            GestorLote gestorLote = new GestorLote();
            cboxLote.ValueMember = "IDLOTE";
            cboxLote.DisplayMember = "NOMBRE";
            cboxLote.DataSource = gestorLote.obtenerLotes();
            cboxLote.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            if (frmIngTipoMateriaPrima == null || frmIngTipoMateriaPrima.IsDisposed)
                frmIngTipoMateriaPrima = new UIIngresoTipoMateriaPrima();

            frmIngTipoMateriaPrima.Show();
            frmIngTipoMateriaPrima.BringToFront();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void UIIngresoProductoTerminado_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            txtPrecio.Text = "";
            txtCantidad.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {

        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (txtPrecio.Text.Trim().Equals(""))
            {
                MessageBox.Show("No se ha escrito el precio del Producto Terminado", "Información", MessageBoxButtons.OK);
            }
            else if (txtCantidad.Text.Trim().Equals(""))
            {
                MessageBox.Show("No se ha escrito la cantidad de Producto Terminado", "Información", MessageBoxButtons.OK);
            }
            else if (cboxLote.Text.Trim().Equals(""))
            {
                MessageBox.Show("No se ha escogido el lote del Producto Terminado", "Información", MessageBoxButtons.OK);
            }
            else if (cboxTipo.Text.Trim().Equals(""))
            {
                MessageBox.Show("No se ha escogido el tipo de Producto Terminado", "Información", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("¿Registrar Tipo Producto Terminado?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {


                    PRODUCTOTERMINADO productoTerminado = new PRODUCTOTERMINADO();

                    productoTerminado.IDTIPOPRODUCTOTERMINADO = Convert.ToInt32(cboxTipo.SelectedValue.ToString());
                    productoTerminado.IDLOTE = Convert.ToInt32(cboxLote.SelectedValue.ToString());
                    productoTerminado.PRECIOTERMINADO=Convert.ToDouble(txtPrecio.Text);
                    productoTerminado.CANTIDADPRODUCTOTERMINADO = Convert.ToInt32(txtCantidad.Text);
                    productoTerminado = gestorProductoTerminado.ingresoProductoTerminado(productoTerminado);
                    txtPrecio.Text = productoTerminado.PRECIOTERMINADO.ToString();
                    txtCantidad.Text = productoTerminado.CANTIDADPRODUCTOTERMINADO.ToString();

                    if ((MessageBox.Show("Registrado con éxito", "Información", MessageBoxButtons.OK)) == DialogResult.OK)
                    {
                       // limpiar();
                    }
                }
            }
        }

    }
}