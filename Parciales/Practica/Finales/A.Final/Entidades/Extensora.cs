using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Entidades
{

    //Agregar método de extensión (clase Extensora) en Producto: AgregarBD():bool.
    

    //Agregar metodo de extension (clase Extensora) en Producto: MostrarBD():string.
    //MostrarBD retornara una cadena (Nombre y Stock) de todos los registros de la BD.
    //Base de Datos (productosDB) -> Tabla productos (nombre - stock)
    public static class Extensora
    {
        public static string MostrarBD(this Producto obj)
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.CONEXION);
            SqlCommand comando = new SqlCommand();
            Producto auxProdructo;
            try
            {                
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM productosDB";
                SqlDataReader sqlReader = comando.ExecuteReader();
                StringBuilder sb = new StringBuilder();

                while (sqlReader.Read())
                {
                    auxProdructo = new Producto((string)sqlReader[0], (int)sqlReader[1]);
                    sb.AppendLine(auxProdructo.ToString());

                }
                return sb.ToString();                                    

            }
            catch (Exception)
            {                
                return "ERROR";
            }
            finally { conexion.Close(); }
        }
    }
}
