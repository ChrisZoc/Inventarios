using System;
using System.Windows.Forms;
using CapaNegocio;
using CapaPersistencia;

namespace Inventarios.WinForms
{
    public partial class UIModificacionProveedor : Form
    {
        GestorProveedor gestorProveedor;

        public UIModificacionProveedor()
        {
            InitializeComponent();
            gestorProveedor = new GestorProveedor();

            cbxBuscarComunidad.DataSource = gestorProveedor.cargarComunidades();
            cbxBuscarComunidad.DropDownStyle = ComboBoxStyle.DropDownList;

            cbxBuscarMP.ValueMember = "IDTIPOMATERIAPRIMA";
            cbxBuscarMP.DisplayMember = "NOMBRETIPOMATERIAPRIMA";
            cbxBuscarMP.DataSource = gestorProveedor.obtenerListaTipoMateriaPrima();
            cbxBuscarMP.DropDownStyle = ComboBoxStyle.DropDownList;

            cbxTipoMP.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEstado.DropDownStyle = ComboBoxStyle.DropDownList;

            dgvProveedores.ReadOnly = true;
            dgvProveedores.AutoGenerateColumns = false;
        }

       #region Form Event Handlers
        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            MostrargpbAltaProductos();
        }

        private void tsbBusqueda_Click(object sender, EventArgs e)
        {
            MostrargpbBusquedaProductos();
        }

        private void MostrargpbAltaProductos()
        {
            gpbAlta.Visible = true;
            tsbCancelar.Enabled = true;
        }

        private void MostrargpbBusquedaProductos()
        {
            gpbAlta.Visible = false;

            tsbCancelar.Enabled = false;
        }



        #endregion Form Event Handlers

        private void cbxBuscarComunidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            gestorProveedor = new GestorProveedor();

            cbxBuscarNombre.ValueMember = "IDPROVEEDOR";
            cbxBuscarNombre.DisplayMember = "NOMBREPROVEEDOR";
            cbxBuscarNombre.DataSource = gestorProveedor.cargarNombres(cbxBuscarComunidad.SelectedItem.ToString());
            cbxBuscarNombre.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void tsbBuscarMP_Click(object sender, EventArgs e)
        {
            gestorProveedor = new GestorProveedor();
            TIPOMATERIAPRIMA mp = new TIPOMATERIAPRIMA();
            mp.NOMBRETIPOMATERIAPRIMA = cbxBuscarMP.Text;
            PROVEEDOR buscado = new PROVEEDOR();
            buscado.IDTIPOMATERIAPRIMA = gestorProveedor.obtenerTipoMateriaPrima(mp).IDTIPOMATERIAPRIMA;

            dgvProveedores.DataSource = gestorProveedor.obtenerProveedoresPorTipoMP(buscado);
        }

        private void tsbBuscarNombre_Click(object sender, EventArgs e)
        {
            gestorProveedor = new GestorProveedor();
            PROVEEDOR buscado = new PROVEEDOR();
            buscado.NOMBREPROVEEDOR = cbxBuscarNombre.Text;
            buscado.COMUNIDAD = cbxBuscarComunidad.Text;

            dgvProveedores.DataSource = gestorProveedor.obtenerProveedoresPorNombre(buscado);
        }

        private void dgvProveedores_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            gestorProveedor = new GestorProveedor();

            txtIDProveedor.Text = dgvProveedores.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNombreProveedor.Text = dgvProveedores.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtComunidad.Text = dgvProveedores.Rows[e.RowIndex].Cells[3].Value.ToString();

            cbxTipoMP.ValueMember = "IDTIPOMATERIAPRIMA";
            cbxTipoMP.DisplayMember = "NOMBRETIPOMATERIAPRIMA";
            cbxTipoMP.DataSource = gestorProveedor.obtenerListaTipoMateriaPrima();

            TIPOMATERIAPRIMA mp = new TIPOMATERIAPRIMA();
            mp.IDTIPOMATERIAPRIMA = Convert.ToInt32(dgvProveedores.Rows[e.RowIndex].Cells[1].Value.ToString());
            cbxTipoMP.SelectedIndex = cbxTipoMP.FindStringExact(gestorProveedor.obtenerTipoMateriaPrimaPorID(mp).NOMBRETIPOMATERIAPRIMA);

            cbxEstado.Items.Add("Activo");
            cbxEstado.Items.Add("Inactivo");
            
            var estadoAux = dgvProveedores.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (estadoAux.Equals("True"))
            {
                cbxEstado.SelectedIndex = 0;
            }
            else
            {
                cbxEstado.SelectedIndex = 1;
            }
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            gestorProveedor = new GestorProveedor();

            PROVEEDOR proveedorMod = new PROVEEDOR();
            TIPOMATERIAPRIMA mp = new TIPOMATERIAPRIMA();

            proveedorMod.IDPROVEEDOR = Convert.ToInt32(txtIDProveedor.Text);

            mp.NOMBRETIPOMATERIAPRIMA = cbxTipoMP.Text;
            proveedorMod.IDTIPOMATERIAPRIMA = gestorProveedor.obtenerTipoMateriaPrima(mp).IDTIPOMATERIAPRIMA;

            proveedorMod.NOMBREPROVEEDOR = txtNombreProveedor.Text;
            proveedorMod.COMUNIDAD = txtComunidad.Text;

            if (cbxEstado.Text.Equals("Activo"))
            {
                proveedorMod.ESTADO = true;
            }
            else
            {
                proveedorMod.ESTADO = false;
            }

            if (MessageBox.Show("¿Modificar Proveedor?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gestorProveedor.ActualizarProveedor(proveedorMod);
                limpiar();
                MessageBox.Show("Registro modificado exitosamente", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void limpiar()
        {
            cbxBuscarComunidad.DataSource = gestorProveedor.cargarComunidades();
            cbxBuscarComunidad.DropDownStyle = ComboBoxStyle.DropDownList;

            cbxBuscarMP.ValueMember = "IDTIPOMATERIAPRIMA";
            cbxBuscarMP.DisplayMember = "NOMBRETIPOMATERIAPRIMA";
            cbxBuscarMP.DataSource = gestorProveedor.obtenerListaTipoMateriaPrima();
            cbxBuscarMP.DropDownStyle = ComboBoxStyle.DropDownList;

            dgvProveedores.DataSource = null;

            txtIDProveedor.Text = "";
            txtNombreProveedor.Text = "";
            txtComunidad.Text = "";

            cbxEstado.Items.Clear();
            cbxTipoMP.DataSource = null;
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}