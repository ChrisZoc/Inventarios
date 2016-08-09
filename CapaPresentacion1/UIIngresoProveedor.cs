using System;
using System.Windows.Forms;
using CapaNegocio;
using CapaPersistencia;

namespace Inventarios.WinForms
{
    public partial class UIIngresoProveedor : Form
    {
        UIIngresoTipoMateriaPrima frmIngTipoMateriaPrima;
        GestorProveedor gestorProveedor;

        public UIIngresoProveedor()
        {
            InitializeComponent();
            gestorProveedor = new GestorProveedor();

            cbxTipoMP.ValueMember = "IDTIPOMATERIAPRIMA";
            cbxTipoMP.DisplayMember = "NOMBRETIPOMATERIAPRIMA";
            cbxTipoMP.DataSource = gestorProveedor.obtenerListaTipoMateriaPrima();
            cbxTipoMP.DropDownStyle = ComboBoxStyle.DropDownList;

            cbxEstado.Items.Add("Activo");
            cbxEstado.Items.Add("Inactivo");
            cbxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombreProveedor.Text.Equals(""))
            {
                MessageBox.Show("No se ha escrito el nombre del Proveedor", "Información", MessageBoxButtons.OK);
            }
            else
            {
                if (txtComunidad.Text.Equals(""))
                {
                    MessageBox.Show("No se ha escrito la comunidad del Proveedor", "Información", MessageBoxButtons.OK);
                }
                else
                {
                    if (MessageBox.Show("¿Registrar Proveedor?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        PROVEEDOR proveedor = new PROVEEDOR();
                        TIPOMATERIAPRIMA tipoMP = new TIPOMATERIAPRIMA();
                        gestorProveedor = new GestorProveedor();

                        proveedor.NOMBREPROVEEDOR = txtNombreProveedor.Text;
                        proveedor.COMUNIDAD = txtComunidad.Text;
                        if (cbxEstado.Text.Equals("Activo"))
                        {
                            proveedor.ESTADO = true;
                        }
                        else
                        {
                            proveedor.ESTADO = false;
                        }
                        tipoMP.NOMBRETIPOMATERIAPRIMA = cbxTipoMP.Text;
                        proveedor.IDTIPOMATERIAPRIMA = gestorProveedor.obtenerTipoMateriaPrima(tipoMP).IDTIPOMATERIAPRIMA;
                        proveedor = gestorProveedor.ingresoProveedor(proveedor);
                        txtIDProveedor.Text = proveedor.IDPROVEEDOR.ToString();

                        if ((MessageBox.Show("Registrado con éxito", "Información", MessageBoxButtons.OK)) == DialogResult.OK)
                        {
                            limpiar();
                        }
                    }
                }
            }
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        #region Form Event Handlers
        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void limpiar()
        {
            txtIDProveedor.Text = "";
            txtNombreProveedor.Text = "";
            txtComunidad.Text = "";

            gestorProveedor = new GestorProveedor();

            cbxTipoMP.ValueMember = "IDTIPOMATERIAPRIMA";
            cbxTipoMP.DisplayMember = "NOMBRETIPOMATERIAPRIMA";
            cbxTipoMP.DataSource = gestorProveedor.obtenerListaTipoMateriaPrima();
            cbxTipoMP.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        #endregion Form Event Handlers

        private void tsbIngresarTipoMP_Click(object sender, EventArgs e)
        {
            if (frmIngTipoMateriaPrima == null || frmIngTipoMateriaPrima.IsDisposed)
                frmIngTipoMateriaPrima = new UIIngresoTipoMateriaPrima();

            frmIngTipoMateriaPrima.Show();
            frmIngTipoMateriaPrima.BringToFront();
        }
    }
}