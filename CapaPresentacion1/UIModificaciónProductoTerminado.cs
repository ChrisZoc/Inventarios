using System;
using System.Windows.Forms;
using CapaPersistencia;
using CapaNegocio;

namespace Inventarios.WinForms
{
    public partial class UIModificaciónProductoTerminado : Form
    {
        
        GestorProductoTerminado gestorProductoTerminado = new GestorProductoTerminado();

        public UIModificaciónProductoTerminado()
        {
            InitializeComponent();
            GestorTipoProductoTerminado gestorTipoProductoTerminado = new GestorTipoProductoTerminado();
            

        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            
            txtCodigo.Text = "";
            txtCantidadPerdida.Text = "";
            txtIdProducto.Text = "";
            txtPrecio.Text = "";
            txtCantidadActual.Text = "";
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
        }

        private void lsvProductos_Click(object sender, EventArgs e)
        {
                     
        }

        private void txtNombreBusqueda_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            PRODUCTOTERMINADO productoTerminado= new PRODUCTOTERMINADO();
            PRODUCTOTERMINADO productoTerminadoNuevo = new PRODUCTOTERMINADO();
            resultadoProductoTerminado lista = new resultadoProductoTerminado();
            if (txtCodigo.Text.Equals(""))
            {
                MessageBox.Show("No se ha escrito el código de Producto Terminado a buscar", "Información", MessageBoxButtons.OK);
            }
            else
            {
                
                productoTerminado.IDPRODUCTOTERMINADO = Convert.ToInt32(txtCodigo.Text);
                productoTerminadoNuevo = gestorProductoTerminado.obtenerProductoTerminado(productoTerminado);
                txtIdProducto.Text = productoTerminadoNuevo.IDPRODUCTOTERMINADO.ToString();
                txtPrecio.Text = productoTerminadoNuevo.PRECIOTERMINADO.ToString();
                txtCantidadActual.Text = productoTerminadoNuevo.CANTIDADPRODUCTOTERMINADO.ToString(); 
                GestorTipoProductoTerminado gestorTipoProductoTerminado = new GestorTipoProductoTerminado();
                cboxTipo.ValueMember = "IDTIPOPRODUCTOTERMINADO";
                cboxTipo.DisplayMember = "NOMREPRODUCTOTERMINADO";
                cboxTipo.DataSource = gestorTipoProductoTerminado.obtenerTiposProductoTerminado();
                cboxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
                GestorLote gestorLote = new GestorLote();
                cboxLote.ValueMember = "IDLOTE";
                cboxLote.DisplayMember = "NOMBRE";
                cboxLote.DataSource = gestorLote.obtenerLotes();
                cboxLote.DropDownStyle = ComboBoxStyle.DropDownList;
                TIPOPRODUCTOTERMINADO pt = new TIPOPRODUCTOTERMINADO();
                pt.IDTIPOPRODUCTOTERMINADO= Convert.ToInt32(productoTerminadoNuevo.IDTIPOPRODUCTOTERMINADO);
                LOTE lt = new LOTE();
                lt.IDLOTE = Convert.ToInt32(productoTerminadoNuevo.IDLOTE);
                DEVOLUCIONPRODUCTOTERMINADO dp = new DEVOLUCIONPRODUCTOTERMINADO();
                dp.IDDEVOLUCIONPROD= Convert.ToInt32(productoTerminadoNuevo.IDDEVOLUCIONPROD);
                cboxTipo.SelectedIndex = cboxTipo.FindStringExact(gestorTipoProductoTerminado.obtenerTipoProductoTerminado(pt).NOMREPRODUCTOTERMINADO);
                cboxLote.SelectedIndex = cboxLote.FindStringExact(gestorLote.obtenerLote(lt).NOMBRE);
                GestorDevolucionProducto gestorDevolucion=new GestorDevolucionProducto();
                
               
            }  
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            if (txtPrecio.Text.Trim().Equals(""))
            {
                MessageBox.Show("No se ha escrito el precio del Producto Terminado", "Información", MessageBoxButtons.OK);
            }
            else if (txtCantidadActual.Text.Trim().Equals(""))
            {
                MessageBox.Show("No se ha escrito la cantidad actual de Producto Terminado", "Información", MessageBoxButtons.OK);
            }
            else if (txtCantidadPerdida.Text.Trim().Equals(""))
            {
                MessageBox.Show("No se ha escrito la cantidad perdida de Producto Terminado", "Información", MessageBoxButtons.OK);
            }
            else if (cboxLote.Text.Trim().Equals(""))
            {
                MessageBox.Show("No se ha escogido el lote del Producto Terminado", "Información", MessageBoxButtons.OK);
            }
            else if (cboxTipo.Text.Trim().Equals(""))
            {
                MessageBox.Show("No se ha escogido el tipo de Producto Terminado", "Información", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("¿Registrar Tipo Producto Terminado?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {


                    PRODUCTOTERMINADO productoTerminado = new PRODUCTOTERMINADO();
                    GestorDevolucionProducto gestorDevolucionProducto = new GestorDevolucionProducto();
                    productoTerminado.IDPRODUCTOTERMINADO = Convert.ToInt32(txtCodigo.Text);
                    productoTerminado.IDTIPOPRODUCTOTERMINADO = Convert.ToInt32(cboxTipo.SelectedValue.ToString());
                    productoTerminado.IDLOTE = Convert.ToInt32(cboxLote.SelectedValue.ToString());
                    productoTerminado.PRECIOTERMINADO = Convert.ToDouble(txtPrecio.Text);
                    

                    if ((!cboxRazon.Text.Trim().Equals("")) && txtCantidadPerdida.Equals(""))
                    {
                        MessageBox.Show("No se ha escogido la cantidad perdida de Producto Terminado", "Información", MessageBoxButtons.OK);
                    }
                    else if((!cboxRazon.Text.Trim().Equals("")) && (!txtCantidadPerdida.Equals("")))
                    {
                        DEVOLUCIONPRODUCTOTERMINADO devolucionProductoTerminado = new DEVOLUCIONPRODUCTOTERMINADO();
                        devolucionProductoTerminado.RAZONDEVOLUCIONPRODUCTO = cboxRazon.Text;
                        devolucionProductoTerminado.CANTIDADDEVOLUCIONPRODUCTO = Convert.ToDouble(txtCantidadPerdida.Text);
                        devolucionProductoTerminado.IDPRODUCTOTERMINADO = Convert.ToInt32(txtIdProducto.Text);
                        devolucionProductoTerminado = gestorDevolucionProducto.ingresoDevolucionProductoTerminado(devolucionProductoTerminado);
                        
                            productoTerminado.CANTIDADPRODUCTOTERMINADO = Convert.ToInt32(txtCantidadActual.Text) - Convert.ToInt32(txtCantidadPerdida.Text);
                            productoTerminado.IDDEVOLUCIONPROD = devolucionProductoTerminado.IDDEVOLUCIONPROD;
                        
                        
                    }
                    if (Convert.ToInt32(txtCantidadPerdida.Text) > 0)
                    {
                        if (productoTerminado.CANTIDADPRODUCTOTERMINADO > 0)
                        {
                            gestorProductoTerminado.ActualizarNombreProductoTerminado(productoTerminado);
                            txtPrecio.Text = productoTerminado.PRECIOTERMINADO.ToString();
                            txtCantidadActual.Text = productoTerminado.CANTIDADPRODUCTOTERMINADO.ToString();
                            if ((MessageBox.Show("Registrado con éxito", "Información", MessageBoxButtons.OK)) == DialogResult.OK)
                            {
                                // limpiar();
                            }
                        }
                        else
                        {
                            MessageBox.Show("La cantidad perdida de Producto Terminado es mayor a la cantidad Actual", "Error", MessageBoxButtons.OK);
                        }
                    }
                    else {
                        MessageBox.Show("La cantidad perdida de Producto Terminado no puede ser un valor negativo", "Error", MessageBoxButtons.OK);
                    }
                   

                    
                }
            }
        }

    }
}