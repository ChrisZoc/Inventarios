using System;
using System.Windows.Forms;
using CapaNegocio;
using CapaPersistencia;

namespace Inventarios.WinForms
{
    public partial class UILotizacionMateriaPrima : Form
    {
        UIIngresoCompraMateriaPrima frmIngresoCompraMateriaPrima;
        GestorCompraMateriaPrima gestorCompraMateriaPrima;
        GestorLote gestorLote;
        public UILotizacionMateriaPrima()
        {
            InitializeComponent();

            gestorCompraMateriaPrima = new GestorCompraMateriaPrima();
            gestorLote = new GestorLote();

            dataGridView1.DataSource = gestorLote.obtenerLotes();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void UILotizacionMateriaPrima_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            txtIdCompra.Text = "";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            if (frmIngresoCompraMateriaPrima == null || frmIngresoCompraMateriaPrima.IsDisposed)
                frmIngresoCompraMateriaPrima = new UIIngresoCompraMateriaPrima();

            frmIngresoCompraMateriaPrima.Show();
            frmIngresoCompraMateriaPrima.BringToFront();
        }

        private void Buscar_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            COMPRADEMATERIAPRIMA compraMateriaPrima = new COMPRADEMATERIAPRIMA();
            COMPRADEMATERIAPRIMA compraRecuperada = new COMPRADEMATERIAPRIMA();

            compraMateriaPrima.ID = Convert.ToInt32(txtIdCompra.Text);
            compraRecuperada = gestorCompraMateriaPrima.obtenerCompraMateriaPrima(compraMateriaPrima);

            txtIdCompra2.Text = compraRecuperada.ID.ToString();
            txtFechaCompra.Text = compraRecuperada.FECHACOMPRA.ToString();
            txtCantidadInicial.Text = compraRecuperada.PESOCOMPRA.ToString();
            txtTipoMateria.Text = compraRecuperada.IDTIPOMATERIAPRIMA.ToString();//MODIFICAR!!!!!!!!!!!!!!!
        }

        private void button1_Click(object sender, EventArgs e)
        {
            COMPRADEMATERIAPRIMA compraAInsertar = new COMPRADEMATERIAPRIMA();

            compraAInsertar.ID = Convert.ToInt32(txtIdCompra2);
            compraAInsertar.FECHACOMPRA = Convert.ToDateTime(txtFechaCompra);
            compraAInsertar.PESOCOMPRA = Convert.ToDecimal(txtCantidadInicial);
            compraAInsertar.IDTIPOMATERIAPRIMA = Convert.ToInt32(txtTipoMateria);
        }

        private void seleccionarFilas(object sender, DataGridViewCellEventArgs e)
        {
            txtIdLote.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNombreLote.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}