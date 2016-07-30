using System;
using System.Windows.Forms;
using Inventarios.ApplicationControl.Validation;
using Inventarios.ApplicationServices;
using Inventarios.ApplicationServices.Impl;
using Inventarios.Core;
using Inventarios.WinForms.SingletonModels;

namespace Inventarios.WinForms
{
    public partial class UILotizacionMateriaPrima : Form
    {
        readonly IProductoService productoService;
        UIIngresoCompraMateriaPrima frmIngresoCompraMateriaPrima;
        public UILotizacionMateriaPrima()
        {
            InitializeComponent();
            productoService = new ProductoService(new AlmacenORMDataContext());
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void UILotizacionMateriaPrima_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            textBox13.Text = "";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            if (frmIngresoCompraMateriaPrima == null || frmIngresoCompraMateriaPrima.IsDisposed)
                frmIngresoCompraMateriaPrima = new UIIngresoCompraMateriaPrima();

            frmIngresoCompraMateriaPrima.Show();
            frmIngresoCompraMateriaPrima.BringToFront();
        }

      

    }
}