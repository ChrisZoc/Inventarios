using System;
using System.Windows.Forms;
using CapaNegocio;
using CapaPersistencia;

namespace Inventarios.WinForms
{
    public partial class UIEliminacionProveedor : Form
    {
        GestorProveedor gestorProveedor;
        PROVEEDOR proAux = new PROVEEDOR();

        public UIEliminacionProveedor()
        {
            InitializeComponent();
            gestorProveedor = new GestorProveedor();

            cbxBuscarComunidad.DataSource = gestorProveedor.cargarComunidades();
            cbxBuscarComunidad.DropDownStyle = ComboBoxStyle.DropDownList;

            cbxBuscarTipoMP.ValueMember = "IDTIPOMATERIAPRIMA";
            cbxBuscarTipoMP.DisplayMember = "NOMBRETIPOMATERIAPRIMA";
            cbxBuscarTipoMP.DataSource = gestorProveedor.obtenerListaTipoMateriaPrima();
            cbxBuscarTipoMP.DropDownStyle = ComboBoxStyle.DropDownList;

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
          
            tsbCancelar.Enabled = true;
        }

        private void MostrargpbBusquedaProductos()
        {            
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

        private void tsbBuscarNombre_Click(object sender, EventArgs e)
        {
            gestorProveedor = new GestorProveedor();
            PROVEEDOR buscado = new PROVEEDOR();
            buscado.NOMBREPROVEEDOR = cbxBuscarNombre.Text;
            buscado.COMUNIDAD = cbxBuscarComunidad.Text;

            dgvProveedores.DataSource = gestorProveedor.obtenerProveedoresPorNombre(buscado);
        }

        private void tsbBuscarMP_Click(object sender, EventArgs e)
        {
            gestorProveedor = new GestorProveedor();
            TIPOMATERIAPRIMA mp = new TIPOMATERIAPRIMA();
            mp.NOMBRETIPOMATERIAPRIMA = cbxBuscarTipoMP.Text;
            PROVEEDOR buscado = new PROVEEDOR();
            buscado.IDTIPOMATERIAPRIMA = gestorProveedor.obtenerTipoMateriaPrima(mp).IDTIPOMATERIAPRIMA;

            dgvProveedores.DataSource = gestorProveedor.obtenerProveedoresPorTipoMP(buscado);
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            gestorProveedor = new GestorProveedor();
            PROVEEDOR proveedor = new PROVEEDOR();

            if (MessageBox.Show("¿Eliminar Proveedor?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                proveedor = gestorProveedor.obtenerProveedor(proAux);
                gestorProveedor.eliminarProveedor(proveedor);

                if ((MessageBox.Show("Eliminación realizada con éxito", "Información", MessageBoxButtons.OK)) == DialogResult.OK)
                {
                    limpiar();
                }
            }
        }

        public void limpiar()
        {
            cbxBuscarComunidad.DataSource = gestorProveedor.cargarComunidades();
            cbxBuscarComunidad.DropDownStyle = ComboBoxStyle.DropDownList;

            cbxBuscarTipoMP.ValueMember = "IDTIPOMATERIAPRIMA";
            cbxBuscarTipoMP.DisplayMember = "NOMBRETIPOMATERIAPRIMA";
            cbxBuscarTipoMP.DataSource = gestorProveedor.obtenerListaTipoMateriaPrima();
            cbxBuscarTipoMP.DropDownStyle = ComboBoxStyle.DropDownList;

            dgvProveedores.DataSource = null;
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dgvProveedores_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            proAux.IDPROVEEDOR = Convert.ToInt32(dgvProveedores.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
    }
}