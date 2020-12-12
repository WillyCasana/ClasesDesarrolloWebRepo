using System;
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


    #region Portada

        public static List<PortadaEnt> PortadaListar()
        {
            List<PortadaEnt> lista = null;

            using (SqlConnection sqlConn = new SqlConnection(cadConexion))
            {
                lista = sqlConn.Query<PortadaEnt>("usp_PortadaListar", commandType: System.Data.CommandType.StoredProcedure).ToList();
            }

            return lista;
        }

        public static PortadaCompraEnt PortadaListarXId(int portId)
        {
            PortadaCompraEnt fila = null;

            // throw new NotImplementedException();
            //using (SqlConnection sqlConn = new SqlConnection(cadConexion))
            // {
            //     fila = sqlConn.Query<PortadaCompraEnt>("usp_PortadaListar")
            // }


            using (SqlConnection sqlConn = new SqlConnection(cadConexion))
            {
                sqlConn.Open();
                SqlCommand cmd = new SqlCommand("usp_PortadaListarXId", sqlConn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@portid", portId);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    fila = new PortadaCompraEnt();
                    fila.PortId = Convert.ToInt32( dr["PortId"]);
                    fila.Descripcion = dr["PortDescripcion"].ToString();
                    fila.PcMoneda = dr["PortMoneda"].ToString();
                    fila.PcPrecio = Convert.ToDecimal( dr["PortPrecio"]);
                }
             }

            return fila;
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
