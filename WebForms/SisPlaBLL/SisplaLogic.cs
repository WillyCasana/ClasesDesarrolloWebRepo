
using SisPla;
using SisPlaDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisPlaBLL
{
    public class SisplaLogic
    {
       #region Portada
        public static List<PortadaEnt> PortadaListar()
        {

            return SisPlaDb.PortadaListar();
        }


       #endregion


       #region Actividad

            public static List<ActividadEnt> ActividadEntListado()
        {
            return SisPlaDb.ActividadEntListado();
        }

        public static PortadaCompraEnt PortadaListarXId(int id)
        {
            return SisPlaDb.PortadaListarXId(id);
        }

        public static void PortadaCompraGrabar(PortadaCompraEnt obj)
        {
             SisPlaDb.PortadaCompraGrabar(obj);
        }

        public static List<CategoriaEnt> CategoriaEntListado()
        {
            return SisPlaDb.CategoriaEntListado();
        }
        public static void ActividadEntRegistrar(ActividadEnt act)
        {
            SisPlaDb.ActividadEntRegistrar(act);
        }

        #endregion 

    }
}
