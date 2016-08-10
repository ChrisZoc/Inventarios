using System;
using System.Windows.Forms;
using CapaNegocio;
using CapaPersistencia;
using System.Collections.Generic;

namespace Inventarios.WinForms
{
    public partial class UIDevolucionMateriaPrima : Form
    {
        UIConsultarCompraMateriaPrima frmConsultarCompraMateriaPrima;
        GestorProveedor gestorProveedor;
        GestorCompraMateriaPrima gestorCompraMateriaPrima;


        public UIDevolucionMateriaPrima()
        {
            InitializeComponent();
            gestorProveedor = new GestorProveedor();
            gestorCompraMateriaPrima = new GestorCompraMateriaPrima();

            cmbProveedor.ValueMember = "IDPROVEEDOR";
            cmbProveedor.DisplayMember = "NOMBREPROVEEDOR";
            cmbProveedor.DataSource = gestorProveedor.obtenerProveedores();

            cmbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;


            cmbRazon.Items.Add("Robo");
            cmbRazon.Items.Add("Caída");
            cmbRazon.Items.Add("Pérdida");
            cmbRazon.Items.Add("Daño");

            dgvTablaCompras.Columns[1].Visible = false;

        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            txtIdCompra1.Text = "";
            txtCantidadInicial.Text = "";
            txtIdCompra2.Text = "";
            txtTipoMateriaPrima.Text = "";
            txtCantidad.Text = "";
            txtCantidadInicial.Text = "";


        }

        private void getCurrentCellButton_Click(object sender, System.EventArgs e)
        {
            //txtIdCompra2.Text = dgvTablaCompras.Rows[e.RowIndex].Cells[0].Value.ToString();
            //txtTipoMateriaPrima.Text = dgvTablaCompras.Rows[e.RowIndex].Cells[4].Value.ToString();
            //txtIdCompra.Text = dgvTablaCompras.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tsbConsultarCompraMP_Click(object sender, EventArgs e)
        {
            if (frmConsultarCompraMateriaPrima == null || frmConsultarCompraMateriaPrima.IsDisposed)
                frmConsultarCompraMateriaPrima = new UIConsultarCompraMateriaPrima();

            frmConsultarCompraMateriaPrima.Show();
            frmConsultarCompraMateriaPrima.BringToFront();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void seleccionarFilas(object sender, EventArgs e)
        {

        }

        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<COMPRADEMATERIAPRIMA> comprasMateriaPrima = new List<COMPRADEMATERIAPRIMA>();
            COMPRADEMATERIAPRIMA comprita = new COMPRADEMATERIAPRIMA();

            comprita.IDPROVEEDOR = Convert.ToInt32(cmbProveedor.SelectedValue);

            dgvTablaCompras.DataSource = (gestorCompraMateriaPrima.obtenerComprasMateriaPrimaPorProveedor(comprita));
        }

        private void pckFechaCompra_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvTablaCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedCellCount = dgvTablaCompras.GetCellCount(DataGridViewElementStates.Selected);

            if (selectedCellCount > 0)
            {
                if (dgvTablaCompras.AreAllCellsSelected(true))
                {
                    //MessageBox.Show("Todos los registros han sido seleccionados", "Selected Cells");
                    txtIdCompra1.Text = dgvTablaCompras.SelectedCells[0].ToString();
                }
                else
                {

                    System.Text.StringBuilder sb = new System.Text.StringBuilder();

                    for (int i = 0; i < selectedCellCount; i++)
                    {
                        sb.Append("Row: ");
                        sb.Append(dgvTablaCompras.SelectedCells[i].RowIndex
                            .ToString());
                        sb.Append(", Column: ");

                        sb.Append(dgvTablaCompras.SelectedCells[i].ColumnIndex
                            .ToString());
                        sb.Append("que valores");
                        sb.Append(dgvTablaCompras.SelectedRows);

                        sb.Append(Environment.NewLine);
                    }

                    sb.Append("Total: " + selectedCellCount.ToString());
                    MessageBox.Show(sb.ToString(), "Selected Cells");
                }
            }

        }

        private void txtIdCompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void seleccionarFilas(object sender, DataGridViewCellEventArgs e)
        {
            txtIdCompra1.Text = dgvTablaCompras.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtIdCompra2.Text = dgvTablaCompras.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtIdCompra.Text = dgvTablaCompras.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtCantidadInicial.Text = dgvTablaCompras.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtTipoMateriaPrima.Text = dgvTablaCompras.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void dgvTablaCompras_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}