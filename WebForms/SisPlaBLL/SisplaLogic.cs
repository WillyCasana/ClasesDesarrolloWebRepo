﻿
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
