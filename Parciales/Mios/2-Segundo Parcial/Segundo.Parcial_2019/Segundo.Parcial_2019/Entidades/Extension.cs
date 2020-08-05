using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;


namespace Entidades
{
    public static class Extension
    {
        public static bool EliminarFruta(this Cajon<Manzana> c, int id)
        {
            bool retorno = false;
            StringBuilder sb = new StringBuilder();
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);
            SqlCommand commando = new SqlCommand();
            commando.Connection = conexion;
            commando.CommandType = CommandType.Text;
            commando.CommandText = "DELETE FROM sp_lab_II.dbo.frutas WHERE id = " + id.ToString();
            try
            {
                conexion.Open();

                if (commando.ExecuteNonQuery() > 0)
                {
                    retorno = true;
                }
                    
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexion.Close();
            }

            return retorno;
        }
    }
}
