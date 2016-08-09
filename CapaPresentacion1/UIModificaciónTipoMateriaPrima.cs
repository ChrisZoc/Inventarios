using System;
using System.Windows.Forms;
using CapaPersistencia;
using CapaNegocio;


namespace Inventarios.WinForms
{

    public partial class UIModificaciónTipoMateriaPrima : Form
    {
        GestorTipoMateriaPrima gestorTipoMateriaPrima;

        public UIModificaciónTipoMateriaPrima()
        {
            InitializeComponent();

            gestorTipoMateriaPrima = new GestorTipoMateriaPrima();


            cboxNomTipoMateriaPrima.ValueMember = "IDTIPOMATERIAPRIMA";
            cboxNomTipoMateriaPrima.DisplayMember = "NOMBRETIPOMATERIAPRIMA";
            cboxNomTipoMateriaPrima.DataSource = gestorTipoMateriaPrima.obtenerTiposMateriaPrima();
            idTipoMateriaPrima.Enabled = false;
            textBNomTipoMatPrima.Enabled = false;
            cboxNomTipoMateriaPrima.DropDownStyle = ComboBoxStyle.DropDownList;

       
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            idTipoMateriaPrima.Text = "";
            textBNomTipoMatPrima.Text = "";
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

                TIPOMATERIAPRIMA tipoMateriaPrima = new TIPOMATERIAPRIMA();
                if (MessageBox.Show("¿Modificar Tipo Materia Prima?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    tipoMateriaPrima.NOMBRETIPOMATERIAPRIMA = textBNomTipoMatPrima.Text.ToString();
                    gestorTipoMateriaPrima.ActualizarNombreTipoMateria(Convert.ToInt32(idTipoMateriaPrima.Text), tipoMateriaPrima.NOMBRETIPOMATERIAPRIMA);
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
       
        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        public void limpiar()
        {
           


            gestorTipoMateriaPrima = new GestorTipoMateriaPrima();


            cboxNomTipoMateriaPrima.ValueMember = "IDTIPOMATERIAPRIMA";
            cboxNomTipoMateriaPrima.DisplayMember = "NOMBRETIPOMATERIAPRIMA";
            cboxNomTipoMateriaPrima.DataSource = gestorTipoMateriaPrima.obtenerTiposMateriaPrima();
            textBNomTipoMatPrima.Text = "";
            idTipoMateriaPrima.Text = "";
            idTipoMateriaPrima.Enabled = false;
            textBNomTipoMatPrima.Enabled = false;
        }


        private void cboxNomTipoMateriaPrima_SelectedIndexChanged(object sender, EventArgs e)
        {

          TIPOMATERIAPRIMA tipo = new TIPOMATERIAPRIMA();
          TIPOMATERIAPRIMA tipo_recuperado = new TIPOMATERIAPRIMA();


          
          tipo.IDTIPOMATERIAPRIMA = Convert.ToInt32(cboxNomTipoMateriaPrima.SelectedValue);

         idTipoMateriaPrima.Text=cboxNomTipoMateriaPrima.SelectedValue.ToString();


         tipo_recuperado=gestorTipoMateriaPrima.obtenerTipoMateriaPrima(tipo);

         textBNomTipoMatPrima.Text = tipo_recuperado.NOMBRETIPOMATERIAPRIMA;

         textBNomTipoMatPrima.Enabled = true;
        }

    }
}