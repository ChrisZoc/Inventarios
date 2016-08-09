using System;
using System.Windows.Forms;

namespace Inventarios.WinForms
{
    public partial class UIConsultarProductoTerminado : Form
    {

        public UIConsultarProductoTerminado()
        {
            InitializeComponent();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtCodigo.Enabled = false;
            txtNombre.Enabled = true;

        }

        private void rbtCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtNombre.Enabled = false;
            txtCodigo.Enabled = true;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtCodigo.Text = "";

        }

      

    }
}