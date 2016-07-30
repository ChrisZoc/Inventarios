using System;
using System.Windows.Forms;
using Inventarios.ApplicationControl.Validation;
using Inventarios.ApplicationServices;
using Inventarios.ApplicationServices.Impl;
using Inventarios.Core;
using Inventarios.WinForms.SingletonModels;

namespace Inventarios.WinForms
{
    public partial class UIIngresoProductoTerminado : Form
    {
        readonly IProductoService productoService;
        UIIngresoTipoMateriaPrima frmIngTipoMateriaPrima;

        public UIIngresoProductoTerminado()
        {
            InitializeComponent();
            productoService = new ProductoService(new AlmacenORMDataContext());
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
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

    }
}