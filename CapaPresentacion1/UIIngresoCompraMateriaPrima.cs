using System;
using System.Windows.Forms;
using CapaNegocio;
using CapaPersistencia;


namespace Inventarios.WinForms
{
    public partial class UIIngresoCompraMateriaPrima : Form
    {
        
        UIIngresoTipoMateriaPrima frmIngTipoMateriaPrima;

        GestorProveedor gestorProveedor = new GestorProveedor();
        GestorTipoMateriaPrima gestorTipoMateriaPrima = new GestorTipoMateriaPrima();


        public UIIngresoCompraMateriaPrima()
        {
            InitializeComponent();
           
          


            cbxNombreTipoMateriaPrima.ValueMember = "IDTIPOMATERIAPRIMA";
            cbxNombreTipoMateriaPrima.DisplayMember = "NOMBRETIPOMATERIAPRIMA";
            cbxNombreTipoMateriaPrima.DataSource = gestorTipoMateriaPrima.obtenerTiposMateriaPrima();

            textIdProveedor.Text = "";
            textIdTipoMateriaPrima.Text = "";
            textComunidad.Text = "";
            

           
            
            groupBoxValores.Visible = false;
            
                
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            textIdTipoMateriaPrima.Text = "";
            textBox2.Text = "";
            textComunidad.Text = "";
            textIdProveedor.Text = "";
            textBox5.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            
           
            


        }

        private void cbxNombreTipoMateriaPrimaChanged(object sender, EventArgs e)
        {
            PROVEEDOR proveedor = new PROVEEDOR();
            
            textIdTipoMateriaPrima.Text = cbxNombreTipoMateriaPrima.SelectedValue.ToString();
            textIdProveedor.Text = "";
            groupBoxValores.Visible = true;
            cbxProveedor.Enabled = true;
            cbxProveedor.ValueMember = "IDPROVEEDOR";
            cbxProveedor.DisplayMember = "NOMBREPROVEEDOR";
            proveedor.IDTIPOMATERIAPRIMA= Convert.ToInt32(textIdTipoMateriaPrima.Text);
            cbxProveedor.DataSource = gestorProveedor.obtenerProveedoresPorTipoMP(proveedor);

        }

        private void cbxProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            PROVEEDOR proveedor = new PROVEEDOR();
            proveedor.IDPROVEEDOR = Convert.ToInt32(cbxProveedor.SelectedValue);
            proveedor = gestorProveedor.obtenerProveedor(proveedor);
            textIdProveedor.Text = cbxProveedor.SelectedValue.ToString();
            textComunidad.Text = proveedor.COMUNIDAD.ToString();

        }
        
    }
}