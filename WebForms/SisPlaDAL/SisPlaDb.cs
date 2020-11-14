﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using SisPla;

namespace SisPlaDAL
{

    public static class SisPlaDb
    {
        static string cadConexion = @"Server=DESKTOP-4KPFF10\SVR2016 ; Database=SisPlaAct;User Id=sa;Password=sa";
        //static string cadConexion = "Server=DESKTOP-4KPFF10\SVR2016 ; Database=SisPlaAct;Integrated Security=true";

        #region Usuario


        public static List<RolEnt> RolListado()
        {
            List<RolEnt> listado = null;
            using(SqlConnection connObj = new SqlConnection(cadConexion))
            {
                listado = connObj.Query<RolEnt>("usp_RolListar", commandType: System.Data.CommandType.StoredProcedure).ToList();
            }

            return listado;
        }

        public static List<UsuarioEnt> UsuarioListado()
        {
            List<UsuarioEnt> listado=null;

            using (SqlConnection connObj = new SqlConnection(cadConexion))
            {
                listado = connObj.Query<UsuarioEnt>("usp_UsuarioListar", commandType: System.Data.CommandType.StoredProcedure).ToList();
            }

            return listado;
        }

        #endregion

        #region Actividad
        public static List<ActividadEnt> ActividadEntListado()
        {
            List<ActividadEnt> ActividadEntObj = null;

            using (SqlConnection conn = new SqlConnection(cadConexion))
            {
                ActividadEntObj = conn.Query<ActividadEnt>("USP_ActividadListar", commandType: System.Data.CommandType.StoredProcedure).ToList();
            }

            return ActividadEntObj;

        }

        public static List<CategoriaEnt> CategoriaEntListado()
        {
            List<CategoriaEnt> CategoriaEntObj = null;

            using (SqlConnection conn = new SqlConnection(cadConexion))
            {
                CategoriaEntObj = conn.Query<CategoriaEnt>("usp_CategoriaListar", commandType: System.Data.CommandType.StoredProcedure).ToList();
            }

            return CategoriaEntObj;

        }

        public static void ActividadEntRegistrar(ActividadEnt act)
        {
            using (SqlConnection conn = new SqlConnection(cadConexion))
            {
                conn.Execute("usp_ActividadInsertar"
                    , new
                    {
                        act.ActComentario,
                        act.ActTiempo,
                        act.CatId,
                        act.ActFecha
                    ,
                        act.UsuId
                    }, commandType: System.Data.CommandType.StoredProcedure);
            }
        }
        #endregion





    }
}
