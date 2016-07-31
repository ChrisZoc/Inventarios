using System;
using System.Windows.Forms;
using Inventarios.ApplicationControl.Validation;
using Inventarios.ApplicationServices;
using Inventarios.ApplicationServices.Impl;
using Inventarios.Core;
using Inventarios.WinForms.SingletonModels;

namespace Inventarios.WinForms
{
    public partial class UIModificarCompraMateriaPrima : Form
    {
        readonly IProductoService productoService;

        public UIModificarCompraMateriaPrima()
        {
            InitializeComponent();
            productoService = new ProductoService(new AlmacenORMDataContext());
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

      

    }
}