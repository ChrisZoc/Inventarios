using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inventarios.WinForms
{
    public partial class UIGeneracionReporteParaProductoTerminado : Form
    {
        public UIGeneracionReporteParaProductoTerminado()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void rbtFecha_CheckedChanged(object sender, EventArgs e)
        {
            gbxSemanas.Visible = false;
            gbxFechas.Visible = true;
        }

        private void rbtSemana_CheckedChanged(object sender, EventArgs e)
        {
            gbxFechas.Visible = false;
            gbxSemanas.Visible = true;
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbtCompra_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtLote_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
