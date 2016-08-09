using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistencia;

namespace CapaNegocio
{
    public class GestorTipoMateriaPrima
    {
        SIGINEntities entidades { get; set; }

        public GestorTipoMateriaPrima()
        {

        }

        public TIPOMATERIAPRIMA ingresoTipoMateriaPrima(TIPOMATERIAPRIMA tipoMateriaPrima)
        {
            entidades = new SIGINEntities();
            entidades.TIPOMATERIAPRIMAs.AddObject(tipoMateriaPrima);

            entidades.SaveChanges();

            return tipoMateriaPrima;

        }

        public List<TIPOMATERIAPRIMA> obtenerTiposMateriaPrima()
        {

            entidades = new SIGINEntities();

            var lstTipoMateriaPrima = (from u in entidades.TIPOMATERIAPRIMAs select u).ToList();
            return lstTipoMateriaPrima;





        }

        public TIPOMATERIAPRIMA obtenerTipoMateriaPrima(TIPOMATERIAPRIMA tipoEntrada)
        {
            entidades = new SIGINEntities();

            var L2EQuery = from st in entidades.TIPOMATERIAPRIMAs
                           where st.IDTIPOMATERIAPRIMA == tipoEntrada.IDTIPOMATERIAPRIMA
                           select st;
            var TIPO = L2EQuery.FirstOrDefault<TIPOMATERIAPRIMA>();



            Console.Write(TIPO);
            return TIPO;

        }

        public void ActualizarNombreTipoMateria(int idTipoMateria, string nombre)
        {
            var TipoMateriaPrima = new TIPOMATERIAPRIMA { IDTIPOMATERIAPRIMA = idTipoMateria };
            using (var entidades = new SIGINEntities())
            {
                entidades.TIPOMATERIAPRIMAs.Attach(TipoMateriaPrima);
                TipoMateriaPrima.NOMBRETIPOMATERIAPRIMA = nombre;
                entidades.SaveChanges();
            }
        }

        public void eliminarTipoMateriaPrima(TIPOMATERIAPRIMA tipoEntrada)
        {

            using (var entidades = new SIGINEntities())
            {
                entidades.TIPOMATERIAPRIMAs.Attach(tipoEntrada);
                entidades.DeleteObject(tipoEntrada);
                entidades.SaveChanges();


            }






        }


        public List<TIPOMATERIAPRIMA> obtenerListaTipoMateriaPrima(TIPOMATERIAPRIMA tipoEntrada)
        {

            entidades = new SIGINEntities();
            if (!tipoEntrada.NOMBRETIPOMATERIAPRIMA.Equals(""))
            {
                var lstTipoMateriaPrima = (from st in entidades.TIPOMATERIAPRIMAs
                                           where st.NOMBRETIPOMATERIAPRIMA == tipoEntrada.NOMBRETIPOMATERIAPRIMA
                                           select st).ToList();
                return lstTipoMateriaPrima;
            }
            else
            {
                var lstTipoMateriaPrima = (from st in entidades.TIPOMATERIAPRIMAs
                                           where st.IDTIPOMATERIAPRIMA == tipoEntrada.IDTIPOMATERIAPRIMA
                                           select st).ToList();
                return lstTipoMateriaPrima;
            }




        }

    }
}