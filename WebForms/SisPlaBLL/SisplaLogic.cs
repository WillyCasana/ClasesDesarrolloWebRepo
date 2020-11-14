
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

        #region Usuario
        public static List<RolEnt> RolListado()
        {
            return SisPlaDb.RolListado();
        }

            public static List<UsuarioEnt> UsuarioListado()
        {
            return SisPlaDb.UsuarioListado();
        }

            #endregion



            #region Actividad

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

        #endregion

    }
}
