using System;
using System.Windows.Forms;
using CapaNegocio;
using CapaPersistencia;

namespace Inventarios.WinForms
{
    public partial class UIEliminaciónTipoMateriaPrima : Form
    {
        GestorTipoMateriaPrima gestorTipoMateriaPrima;
        public UIEliminaciónTipoMateriaPrima()
        {

            InitializeComponent();
            gestorTipoMateriaPrima = new GestorTipoMateriaPrima();



            dataGridNombresTipoMtaeria.DataSource = gestorTipoMateriaPrima.obtenerTiposMateriaPrima();
            dataGridNombresTipoMtaeria.Columns[2].Visible = false;



        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            textIdTipoMateriaPrima.Text = "";

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



        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            limpiar();

        }

        private void cbxNombreTipoMateriaPrima_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridNombresTipoMtaeria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void seleccionarFilas(object sender, DataGridViewCellEventArgs e)
        {

            textIdTipoMateriaPrima.Text = dataGridNombresTipoMtaeria.Rows[e.RowIndex].Cells[0].Value.ToString();
            textNombreTipoMateria.Text = dataGridNombresTipoMtaeria.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

        private void limpiar()
        {
            textIdTipoMateriaPrima.Text = "";
            textNombreTipoMateria.Text = "";
            gestorTipoMateriaPrima = new GestorTipoMateriaPrima();




            dataGridNombresTipoMtaeria.DataSource = gestorTipoMateriaPrima.obtenerTiposMateriaPrima();



        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            TIPOMATERIAPRIMA tipoMateriaPrima = new TIPOMATERIAPRIMA();
            TIPOMATERIAPRIMA tipo = new TIPOMATERIAPRIMA();

            tipoMateriaPrima.IDTIPOMATERIAPRIMA = Convert.ToInt32(textIdTipoMateriaPrima.Text);

            if (MessageBox.Show("¿Eliminar Tipo Materia Prima?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tipo = gestorTipoMateriaPrima.obtenerTipoMateriaPrima(tipoMateriaPrima);
                gestorTipoMateriaPrima.eliminarTipoMateriaPrima(tipo);

            }

            if ((MessageBox.Show("Eliminación realizada con éxito", "Información", MessageBoxButtons.OK)) == DialogResult.OK)
            {

                limpiar();
            }



        }

        private void textNombreTipoMateria_TextChanged(object sender, EventArgs e)
        {

        }

        private void tlsBarraMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}