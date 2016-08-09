using System;
using System.Windows.Forms;
using CapaNegocio;
using CapaPersistencia;

namespace Inventarios.WinForms
{
    public partial class UIConsultaProveedor : Form
    {
        GestorProveedor gestorProveedor;

        public UIConsultaProveedor()
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

        #endregion Form Event Handlers

        private void tsbBuscarMP_Click(object sender, EventArgs e)
        {
            gestorProveedor = new GestorProveedor();
            TIPOMATERIAPRIMA mp = new TIPOMATERIAPRIMA();
            mp.NOMBRETIPOMATERIAPRIMA = cbxBuscarTipoMP.Text;
            PROVEEDOR buscado = new PROVEEDOR();
            buscado.IDTIPOMATERIAPRIMA = gestorProveedor.obtenerTipoMateriaPrima(mp).IDTIPOMATERIAPRIMA;

            dgvProveedores.DataSource = gestorProveedor.obtenerProveedoresPorTipoMP(buscado);
        }

        private void tsbBuscarComunidad_Click(object sender, EventArgs e)
        {
            gestorProveedor = new GestorProveedor();
            PROVEEDOR p = new PROVEEDOR();
            p.COMUNIDAD = cbxBuscarComunidad.Text;

            dgvProveedores.DataSource = gestorProveedor.obtenerProveedoresPorComunidad(p);
        }

        public void limpiar()
        {
            gestorProveedor = new GestorProveedor();

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
    }
}