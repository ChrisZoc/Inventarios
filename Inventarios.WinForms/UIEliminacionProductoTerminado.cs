using System;
using System.Windows.Forms;
using Inventarios.ApplicationControl.Validation;
using Inventarios.ApplicationServices;
using Inventarios.ApplicationServices.Impl;
using Inventarios.Core;
using Inventarios.WinForms.SingletonModels;

namespace Inventarios.WinForms
{
    public partial class UIEliminacionProductoTerminado : Form
    {
        readonly IProductoService productoService;

        public UIEliminacionProductoTerminado()
        {
            InitializeComponent();
            productoService = new ProductoService(new AlmacenORMDataContext());
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