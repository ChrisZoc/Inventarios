using System;
using System.Windows.Forms;

namespace Inventarios.WinForms
{
    public partial class UIEliminacionProductoTerminado : Form
    {
        public UIEliminacionProductoTerminado()
        {
            InitializeComponent();
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

      

    }
}