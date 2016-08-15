using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistencia;

namespace CapaNegocio
{
    public class GestorDevolucionProducto
    {
        SIGINEntities entidades { get; set; }

        public GestorDevolucionProducto()
        {

        }

        public DEVOLUCIONPRODUCTOTERMINADO ingresoDevolucionProductoTerminado(DEVOLUCIONPRODUCTOTERMINADO devolucionEntrada)
        {
            entidades = new SIGINEntities();
            entidades.DEVOLUCIONPRODUCTOTERMINADOes.AddObject(devolucionEntrada);

            entidades.SaveChanges();

            return devolucionEntrada;
        }

        public List<DEVOLUCIONPRODUCTOTERMINADO> obtenerDevoluciones()
        {

            entidades = new SIGINEntities();

            var lstDevoluciones = (from u in entidades.DEVOLUCIONPRODUCTOTERMINADOes select u).ToList();
            return lstDevoluciones;

        }
        public DEVOLUCIONPRODUCTOTERMINADO obtenerDevolucion(DEVOLUCIONPRODUCTOTERMINADO tipoEntrada)
        {

            entidades = new SIGINEntities();

            var L2EQuery = from st in entidades.DEVOLUCIONPRODUCTOTERMINADOes
                           where st.IDPRODUCTOTERMINADO == tipoEntrada.IDPRODUCTOTERMINADO
                           select st;
            var TIPO = L2EQuery.FirstOrDefault<DEVOLUCIONPRODUCTOTERMINADO>();



            Console.Write(TIPO);
            return TIPO;

        }
        public void EliminarDevolucion(DEVOLUCIONPRODUCTOTERMINADO tipoEntrada)
        {
     
            using (var entidades = new SIGINEntities())
            {
                entidades.DEVOLUCIONPRODUCTOTERMINADOes.Attach(tipoEntrada);

                entidades.DeleteObject(tipoEntrada);
                entidades.SaveChanges();
            }

        }
    }
}