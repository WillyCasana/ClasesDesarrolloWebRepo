
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

        public static void ActividadEntEliminar(int id)
        {
            SisPlaDb.ActividadEntEliminar(id);
        }


        public static void ActividadEntActualizar(ActividadEnt act)
        {
            SisPlaDb.ActividadEntActualizar(act);

        }
            public static ActividadEnt ActividadEntListadoXId(int id)
        {

            return SisPlaDb.ActividadEntListadoXId(id);
        }


            public static List<ActividadEnt> ActividadEntListado()
        {
            

            return SisPlaDb.ActividadEntListado();
        }

        public static List<CategoriaEnt> CategoriaEntListado()
        {
            return SisPlaDb.CategoriaEntListado();
        }

        public static void ActividadEntRegistrar(ActividadEnt act)
        {

            SisPlaDb.ActividadEntRegistrar(act);
        }

     }
}
