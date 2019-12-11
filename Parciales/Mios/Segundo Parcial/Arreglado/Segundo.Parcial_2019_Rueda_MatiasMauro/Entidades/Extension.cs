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

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;

            comando.CommandText = "DELETE FROM sp_lab_II.dbo.frutas WHERE id = " + id.ToString();

            try
            {
                //SqlCommand comando = new SqlCommand();
                //comando.Connection = conexion;
                //comando.CommandType = CommandType.Text;
                
                //comando.CommandText = "DELETE FROM sp_lab_II.dbo.frutas WHERE id = " + id.ToString();
                //comando.CommandText = "DELETE FROM sp_lab_II.dbo.frutas WHERE id = " + id;
                //comando.Parameters.AddWithValue("@id", id);
                //comando.CommandText = "DELETE FROM frutas WHERE [id] = @id";


                conexion.Open();

                if (comando.ExecuteNonQuery()!=0)
                {
                    retorno = true;
                    conexion.Close();
                }
                    
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //finally
            //{
            //    if (conexion.State == ConnectionState.Open)
            //    {
            //        conexion.Close();
            //        //retorno = true;
            //    }
            //}

            return retorno;
        }
    }
}
