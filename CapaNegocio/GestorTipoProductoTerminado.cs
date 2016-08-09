using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistencia;

namespace CapaNegocio
{
    public class GestorTipoProductoTerminado
    {
        SIGINEntities entidades { get; set; }

        public GestorTipoProductoTerminado()
        {

        }

        public TIPOPRODUCTOTERMINADO ingresoTipoProductoTerminado(TIPOPRODUCTOTERMINADO tipoProductoTerminado)
        {
            entidades = new SIGINEntities();
            entidades.TIPOPRODUCTOTERMINADOes.AddObject(tipoProductoTerminado);

            entidades.SaveChanges();

            return tipoProductoTerminado;

        }

        public List<TIPOPRODUCTOTERMINADO> obtenerTiposProductoTerminado()
        {

            entidades = new SIGINEntities();

            var lstTipoProductoTerminado = (from u in entidades.TIPOPRODUCTOTERMINADOes select u).ToList();
            return lstTipoProductoTerminado;


        }

        public List<TIPOPRODUCTOTERMINADO> obtenerListaProductoTerminado(TIPOPRODUCTOTERMINADO tipoEntrada)
        {

            entidades = new SIGINEntities();
            if (!tipoEntrada.NOMREPRODUCTOTERMINADO.Equals(""))
            {
                var lstTipoProductoTerminado = (from st in entidades.TIPOPRODUCTOTERMINADOes
                                                where st.NOMREPRODUCTOTERMINADO == tipoEntrada.NOMREPRODUCTOTERMINADO
                                                select st).ToList();
                return lstTipoProductoTerminado;
            }
            else
            {
                var lstTipoProductoTerminado = (from st in entidades.TIPOPRODUCTOTERMINADOes
                                                where st.IDTIPOPRODUCTOTERMINADO == tipoEntrada.IDTIPOPRODUCTOTERMINADO
                                                select st).ToList();
                return lstTipoProductoTerminado;
            }




        }

        public TIPOPRODUCTOTERMINADO obtenerTipoProductoTerminado(TIPOPRODUCTOTERMINADO tipoEntrada)
        {
            entidades = new SIGINEntities();

            var L2EQuery = from st in entidades.TIPOPRODUCTOTERMINADOes
                           where st.IDTIPOPRODUCTOTERMINADO == tipoEntrada.IDTIPOPRODUCTOTERMINADO
                           select st;
            var TIPO = L2EQuery.FirstOrDefault<TIPOPRODUCTOTERMINADO>();



            Console.Write(TIPO);
            return TIPO;

        }

        public void ActualizarNombreTipoProductoTerminado(int idTipoProductoTerminado, string nombre)
        {
            var TipoProductoTerminado = new TIPOPRODUCTOTERMINADO { IDTIPOPRODUCTOTERMINADO = idTipoProductoTerminado };
            using (var entidades = new SIGINEntities())
            {
                entidades.TIPOPRODUCTOTERMINADOes.Attach(TipoProductoTerminado);
                TipoProductoTerminado.NOMREPRODUCTOTERMINADO = nombre;
                entidades.SaveChanges();
            }
        }

        public void EliminarTipoProductoTerminado(TIPOPRODUCTOTERMINADO tipoEntrada)
        {
            using (var entidades = new SIGINEntities())
            {
                entidades.TIPOPRODUCTOTERMINADOes.Attach(tipoEntrada);
                entidades.DeleteObject(tipoEntrada);
                entidades.SaveChanges();
            }

        }





    }
}
