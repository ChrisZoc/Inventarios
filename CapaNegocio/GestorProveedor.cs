using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistencia;


namespace CapaNegocio
{
    public class GestorProveedor
    {
        SIGINEntities Entidades { get; set; }
        public GestorProveedor()
        {

        }
        public List<PROVEEDOR> obtenerProveedores()
        {
            Entidades = new SIGINEntities();
            var lstProveedores = (from u in Entidades.PROVEEDORs select u).ToList();
            return lstProveedores;
        }
        public PROVEEDOR obtenerProveedor(PROVEEDOR p)
        {
            Entidades = new SIGINEntities();
            var lstProveedores = from u in Entidades.PROVEEDORs
                                 where u.IDPROVEEDOR == p.IDPROVEEDOR
                                 select u;
            var proveedor = lstProveedores.FirstOrDefault<PROVEEDOR>();
            return proveedor;
        }
        public List<PROVEEDOR> obtenerProveedoresPorNombre(PROVEEDOR p)
        {
            Entidades = new SIGINEntities();
            var lstNombres = (from u in Entidades.PROVEEDORs
                              where u.NOMBREPROVEEDOR == p.NOMBREPROVEEDOR && u.COMUNIDAD == p.COMUNIDAD
                              select u).ToList();
            return lstNombres;
        }
        public List<PROVEEDOR> obtenerProveedoresPorTipoMP(PROVEEDOR p)
        {
            Entidades = new SIGINEntities();
            var lstNombres = (from u in Entidades.PROVEEDORs
                              where u.IDTIPOMATERIAPRIMA == p.IDTIPOMATERIAPRIMA
                              select u).ToList();
            return lstNombres;
        }
        public List<PROVEEDOR> obtenerProveedoresPorComunidad(PROVEEDOR p)
        {
            Entidades = new SIGINEntities();
            var lstNombres = (from u in Entidades.PROVEEDORs
                              where u.COMUNIDAD == p.COMUNIDAD
                              select u).ToList();
            return lstNombres;
        }
        public List<TIPOMATERIAPRIMA> obtenerListaTipoMateriaPrima()
        {
            Entidades = new SIGINEntities();
            var lstTipoMP = (from u in Entidades.TIPOMATERIAPRIMAs select u).ToList();
            return lstTipoMP;
        }
        public TIPOMATERIAPRIMA obtenerTipoMateriaPrima(TIPOMATERIAPRIMA tipoEntrada)
        {
            Entidades = new SIGINEntities();

            var tipoMP = from st in Entidades.TIPOMATERIAPRIMAs
                         where st.NOMBRETIPOMATERIAPRIMA == tipoEntrada.NOMBRETIPOMATERIAPRIMA
                         select st;
            var materiaPrima = tipoMP.FirstOrDefault<TIPOMATERIAPRIMA>();

            return materiaPrima;
        }
        public TIPOMATERIAPRIMA obtenerTipoMateriaPrimaPorID(TIPOMATERIAPRIMA tipoEntrada) 
        {
            Entidades = new SIGINEntities();

            var tipoMP = from st in Entidades.TIPOMATERIAPRIMAs
                         where st.IDTIPOMATERIAPRIMA == tipoEntrada.IDTIPOMATERIAPRIMA
                         select st;
            var materiaPrima = tipoMP.FirstOrDefault<TIPOMATERIAPRIMA>();

            return materiaPrima;
        }
        public PROVEEDOR ingresoProveedor(PROVEEDOR proveedor)
        {
            Entidades = new SIGINEntities();
            Entidades.PROVEEDORs.AddObject(proveedor);

            Entidades.SaveChanges();

            return proveedor;
        }
        public List<String> cargarComunidades()
        {
            Entidades = new SIGINEntities();
            var comunidad = from st in Entidades.PROVEEDORs
                            group st by st.COMUNIDAD into u
                            select u;
            var listaCom = new List<String>();
            foreach (var com in comunidad)
            {
                listaCom.Add(com.Key);
            }
            return listaCom;
        }
        public List<PROVEEDOR> cargarNombres(String comunidad)
        {
            Entidades = new SIGINEntities();
            var nombres = (from st in Entidades.PROVEEDORs
                           where st.COMUNIDAD == comunidad
                           select st).ToList();
            return nombres;
        }
        public void ActualizarProveedor(PROVEEDOR proveedorEntrada)
        {
            var proveedor = new PROVEEDOR { IDPROVEEDOR = proveedorEntrada.IDPROVEEDOR };
            using (Entidades = new SIGINEntities())
            {
                Entidades.PROVEEDORs.Attach(proveedor);
                proveedor.IDTIPOMATERIAPRIMA = proveedorEntrada.IDTIPOMATERIAPRIMA;
                proveedor.NOMBREPROVEEDOR = proveedorEntrada.NOMBREPROVEEDOR;
                proveedor.COMUNIDAD = proveedorEntrada.COMUNIDAD;
                proveedor.ESTADO = proveedorEntrada.ESTADO;
                Entidades.SaveChanges();
            }
        }
        public void eliminarProveedor(PROVEEDOR proveedorEntrada)
        {
            using (Entidades = new SIGINEntities())
            {
                Entidades.PROVEEDORs.Attach(proveedorEntrada);
                Entidades.DeleteObject(proveedorEntrada);
                Entidades.SaveChanges();
            }
        }
    }
}
