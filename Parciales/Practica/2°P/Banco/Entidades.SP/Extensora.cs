using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Entidades.SP
{
    public static class Extensora
    {
        public static string MostrarBD(this Producto a)
        {
            StringBuilder sb = new StringBuilder();
            SqlConnection connect = new SqlConnection(Properties.Settings.Default.Conexion);
            string comando = "select * from productos";
            SqlCommand cm = new SqlCommand(comando, connect);
            connect.Open();
            var reader = cm.ExecuteReader();
            while (reader.Read())
            {                
                sb.AppendFormat("{0}-{1}\n",reader["nombre"].ToString(),reader["stock"].ToString());
            }
            connect.Close();
            reader.Close();
            return sb.ToString();
        }
    }
}
