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

    }
}