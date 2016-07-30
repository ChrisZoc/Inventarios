using System;
using System.Windows.Forms;
using Inventarios.ApplicationControl.Validation;
using Inventarios.ApplicationServices;
using Inventarios.ApplicationServices.Impl;
using Inventarios.Core;
using Inventarios.WinForms.SingletonModels;

namespace Inventarios.WinForms
{
    
    public partial class UIDevolucionMateriaPrima : Form
    {
        readonly IProductoService productoService;
        UIConsultarCompraMateriaPrima frmConsultarCompraMateriaPrima;

        public UIDevolucionMateriaPrima()
        {
            InitializeComponent();
            productoService = new ProductoService(new AlmacenORMDataContext());
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            textBox13.Text = "";
            textBox9.Text = "";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tsbConsultarCompraMP_Click(object sender, EventArgs e)
        {
            if (frmConsultarCompraMateriaPrima == null || frmConsultarCompraMateriaPrima.IsDisposed)
                frmConsultarCompraMateriaPrima = new UIConsultarCompraMateriaPrima();

            frmConsultarCompraMateriaPrima.Show();
            frmConsultarCompraMateriaPrima.BringToFront();
        }

      

    }
}