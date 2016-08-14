using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistencia;

namespace CapaNegocio
{
    public class GestorLote
    {
        SIGINEntities entidades { get; set; }

        public GestorLote()
        {

        }

        public LOTE ingresoCompraMateriaPrima(LOTE loteEntrada)
        {
            entidades = new SIGINEntities();
            entidades.LOTEs.AddObject(loteEntrada);

            entidades.SaveChanges();

            return loteEntrada;
        }

        public List<LOTE> obtenerLotes()
        {

            entidades = new SIGINEntities();

            var lstLotes = (from u in entidades.LOTEs select u).ToList();
            return lstLotes;

        }
        public LOTE obtenerLote(LOTE tipoEntrada)
        {

            entidades = new SIGINEntities();

            var L2EQuery = from st in entidades.LOTEs
                           where st.IDLOTE == tipoEntrada.IDLOTE
                           select st;
            var TIPO = L2EQuery.FirstOrDefault<LOTE>();



            Console.Write(TIPO);
            return TIPO;

        }
    }
}