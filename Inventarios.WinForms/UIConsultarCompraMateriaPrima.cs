using System;
using System.Windows.Forms;
using Inventarios.ApplicationControl.Validation;
using Inventarios.ApplicationServices;
using Inventarios.ApplicationServices.Impl;
using Inventarios.Core;
using Inventarios.WinForms.SingletonModels;

namespace Inventarios.WinForms
{
    public partial class UIConsultarCompraMateriaPrima : Form
    {
        readonly IProductoService productoService;

        public UIConsultarCompraMateriaPrima()
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
            

        }

        private void rbtCodigo_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
           

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

      

    }
}