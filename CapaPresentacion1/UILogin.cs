using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventarios.WinForms
{
    public partial class Form1 : Form
    {
        UIPrincipal frmUIPRincipal;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user = "admin";
            String Pass = "admin";
            if (textPass.Text == Pass && textUser.Text == user)
            {
                MessageBox.Show("Accesso Correcto");

                if (frmUIPRincipal == null || frmUIPRincipal.IsDisposed)
                    frmUIPRincipal = new UIPrincipal();

                frmUIPRincipal.Show();
                frmUIPRincipal.BringToFront();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }

        }
    }
}