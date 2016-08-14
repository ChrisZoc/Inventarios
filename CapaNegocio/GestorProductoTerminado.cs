using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistencia;

namespace CapaNegocio
{
    public class GestorProductoTerminado
    {
        SIGINEntities entidades { get; set; }

        public GestorProductoTerminado()
        {

        }

        public PRODUCTOTERMINADO ingresoProductoTerminado(PRODUCTOTERMINADO productoTerminado)
        {
            entidades = new SIGINEntities();
            entidades.PRODUCTOTERMINADOes.AddObject(productoTerminado);

            entidades.SaveChanges();

            return productoTerminado;

        }

        public List<PRODUCTOTERMINADO> obtenerProductoTerminado()
        {

            entidades = new SIGINEntities();

            var lstProductoTerminado = (from u in entidades.PRODUCTOTERMINADOes select u).ToList();
            return lstProductoTerminado;


        }

        public List<resultadoProductoTerminado> obtenerListaProductoTerminadoPorNombre(TIPOPRODUCTOTERMINADO tipoEntrada)
        {

            entidades = new SIGINEntities();
            if (!tipoEntrada.NOMREPRODUCTOTERMINADO.Equals(""))
            {
                /*var lstTipoProductoTerminado = (from st in entidades.PRODUCTOTERMINADOes
                                                where st.NOMREPRODUCTOTERMINADO == tipoEntrada.NOMREPRODUCTOTERMINADO
                                                select st).ToList();*/

                var lstTipoProductoTerminado = (from st in entidades.PRODUCTOTERMINADOes
                                                join prod in entidades.TIPOPRODUCTOTERMINADOes
                                                    on st.IDTIPOPRODUCTOTERMINADO equals prod.IDTIPOPRODUCTOTERMINADO
                                                join lote in entidades.LOTEs
                                                    on st.IDLOTE equals lote.IDLOTE
                                                    where prod.NOMREPRODUCTOTERMINADO == tipoEntrada.NOMREPRODUCTOTERMINADO
                                                select new resultadoProductoTerminado
                                                {
                                                    idProducto = st.IDPRODUCTOTERMINADO,
                                                    Nombre = prod.NOMREPRODUCTOTERMINADO,
                                                    idDevolución = st.IDDEVOLUCIONPROD,
                                                    Lote = lote.NOMBRE,
                                                    Precio = st.PRECIOTERMINADO
                                                }).ToList();


                return lstTipoProductoTerminado;
            }
            else {
                return null;

            }

        }

        public List<resultadoProductoTerminado> obtenerListaProductoTerminadoPorID(PRODUCTOTERMINADO tipoEntrada)
        {

            entidades = new SIGINEntities();
            
                /*var lstTipoProductoTerminado = (from st in entidades.PRODUCTOTERMINADOes
                                                where st.NOMREPRODUCTOTERMINADO == tipoEntrada.NOMREPRODUCTOTERMINADO
                                                select st).ToList();*/

                var lstTipoProductoTerminado = (from st in entidades.PRODUCTOTERMINADOes
                                                join prod in entidades.TIPOPRODUCTOTERMINADOes
                                                    on st.IDTIPOPRODUCTOTERMINADO equals prod.IDTIPOPRODUCTOTERMINADO
                                                join lote in entidades.LOTEs
                                                    on st.IDLOTE equals lote.IDLOTE
                                                where st.IDPRODUCTOTERMINADO==tipoEntrada.IDPRODUCTOTERMINADO
                                                select new resultadoProductoTerminado
                                                {
                                                    idProducto = st.IDPRODUCTOTERMINADO,
                                                    Nombre = prod.NOMREPRODUCTOTERMINADO,
                                                    idDevolución=st.IDDEVOLUCIONPROD,
                                                    Lote = lote.NOMBRE,
                                                    Precio = st.PRECIOTERMINADO
                                                }).ToList();


                return lstTipoProductoTerminado;
            

        }

        public PRODUCTOTERMINADO obtenerProductoTerminado(PRODUCTOTERMINADO tipoEntrada)
        {
            entidades = new SIGINEntities();

            var L2EQuery = from st in entidades.PRODUCTOTERMINADOes
                           where st.IDPRODUCTOTERMINADO == tipoEntrada.IDPRODUCTOTERMINADO
                           select st;
            var TIPO = L2EQuery.FirstOrDefault<PRODUCTOTERMINADO>();



            Console.Write(TIPO);
            return TIPO;

        }

        public void ActualizarNombreProductoTerminado(PRODUCTOTERMINADO tipoEntrada)
        {
            
            using (var entidades = new SIGINEntities())
            {
                entidades.PRODUCTOTERMINADOes.Attach(tipoEntrada);
                entidades.SaveChanges();
            }
        }

        public void EliminarProductoTerminado(PRODUCTOTERMINADO tipoEntrada)
        {
            using (var entidades = new SIGINEntities())
            {
                entidades.PRODUCTOTERMINADOes.Attach(tipoEntrada);
                entidades.DeleteObject(tipoEntrada);
                entidades.SaveChanges();
            }

        }





    }

    public class resultadoProductoTerminado
    {

        public int idProducto { get; set; }
        public string Nombre{ get; set; }
        public string Lote { get; set; }
        public int? idDevolución { get; set; }
        public double? Precio { get; set; }

    }
}
