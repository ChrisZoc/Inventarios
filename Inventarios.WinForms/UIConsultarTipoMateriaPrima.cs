using System;
using System.Windows.Forms;
using Inventarios.ApplicationControl.Validation;
using Inventarios.ApplicationServices;
using Inventarios.ApplicationServices.Impl;
using Inventarios.Core;
using Inventarios.WinForms.SingletonModels;

namespace Inventarios.WinForms
{
    public partial class UIConsultarTipoMateriaPrima : Form
    {
        readonly IProductoService productoService;

        public UIConsultarTipoMateriaPrima()
        {
            InitializeComponent();
            productoService = new ProductoService(new AlmacenORMDataContext());
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