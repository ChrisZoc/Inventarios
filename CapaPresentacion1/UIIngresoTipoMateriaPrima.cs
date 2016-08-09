using System;
using System.Windows.Forms;
using CapaPersistencia;
using CapaNegocio;
namespace Inventarios.WinForms
{
    public partial class UIIngresoTipoMateriaPrima : Form

    {
        GestorTipoMateriaPrima gestorTipoMateriaPrima;
        
        public UIIngresoTipoMateriaPrima()
        {
            InitializeComponent();

            gestorTipoMateriaPrima = new GestorTipoMateriaPrima();
            
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {

       

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

        #region Form Event Handlers
        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            txtIdTipoMateria.Text = "";
            NombreTipoMateriaPrima.Text = "";
        }

        private void tsbBusqueda_Click(object sender, EventArgs e)
        {
            MostrargpbBusquedaProductos();
        }

        private void MostrargpbAltaProductos()
        {
           
            gpbAlta.Visible = true;
            tsbCancelar.Enabled = true;
        }

        private void MostrargpbBusquedaProductos()
        {
            gpbAlta.Visible = false;
            
            tsbCancelar.Enabled = false;
        }

     

        #endregion Form Event Handlers

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void gpbAlta_Enter(object sender, EventArgs e)
        {

        }

        private void tsbGuardar_Click_1(object sender, EventArgs e)
        {
            if (NombreTipoMateriaPrima.Text.Equals(""))
            {
                MessageBox.Show("No se ha escrito el tipo de Materia Prima", "Información", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("¿Registrar Tipo Materia Prima?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {


                    TIPOMATERIAPRIMA tipoMateriaPrima = new TIPOMATERIAPRIMA();

                    tipoMateriaPrima.NOMBRETIPOMATERIAPRIMA = NombreTipoMateriaPrima.Text;
                    tipoMateriaPrima = gestorTipoMateriaPrima.ingresoTipoMateriaPrima(tipoMateriaPrima);
                    txtIdTipoMateria.Text = tipoMateriaPrima.IDTIPOMATERIAPRIMA.ToString();
                   if(( MessageBox.Show("Registrado con éxito", "Información", MessageBoxButtons.OK)) == DialogResult.OK)
                   {
                   
                    limpiar();
                   }
                }
            }
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            limpiar();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtIdTipoMateria_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tsbRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void limpiar()
        {
            NombreTipoMateriaPrima.Text = "";
            txtIdTipoMateria.Text = "";
        }
    }
}