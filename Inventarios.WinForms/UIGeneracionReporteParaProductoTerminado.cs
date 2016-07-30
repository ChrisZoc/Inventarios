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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox2.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = true;
        }
    }
}
