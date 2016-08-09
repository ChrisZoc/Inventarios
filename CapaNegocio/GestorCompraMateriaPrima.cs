using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistencia;

namespace CapaNegocio
{

    public class GestorCompraMateriaPrima
    {
        SIGINEntities entidades { get; set; }

        public GestorCompraMateriaPrima()
        {

        }

        public COMPRADEMATERIAPRIMA ingresoCompraMateriaPrima(COMPRADEMATERIAPRIMA compraMateriaPrima)
        {
            entidades = new SIGINEntities();
            entidades.COMPRADEMATERIAPRIMAs.AddObject(compraMateriaPrima);

            entidades.SaveChanges();

            return compraMateriaPrima;

        }

        public COMPRADEMATERIAPRIMA obtenerCompraMateriaPrima(COMPRADEMATERIAPRIMA tipoEntrada)
        {
            entidades = new SIGINEntities();

            var L2EQuery = from st in entidades.COMPRADEMATERIAPRIMAs
                           where st.ID == tipoEntrada.ID
                           select st;
            var TIPO = L2EQuery.FirstOrDefault<COMPRADEMATERIAPRIMA>();

            Console.Write(TIPO);
            return TIPO;

        }



        public List<COMPRADEMATERIAPRIMA> obtenerComprasMateriaPrima()
        {

            entidades = new SIGINEntities();

            var lstComprasMateriaPrima = (from u in entidades.COMPRADEMATERIAPRIMAs select u).ToList();
            return lstComprasMateriaPrima;

        }

        public List<COMPRADEMATERIAPRIMA> obtenerComprasMateriaPrimaPorProveedor(COMPRADEMATERIAPRIMA tipoEntrada)
        {

            entidades = new SIGINEntities();

            var lstComprasMateriaPrimaPorProveedor = (from u in entidades.COMPRADEMATERIAPRIMAs
                                                      where u.IDPROVEEDOR == tipoEntrada.IDPROVEEDOR
                                                      select u).ToList();
            return lstComprasMateriaPrimaPorProveedor;

        }

    }
}