using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    //Agregar método de extensión (clase Extensora) en Persona MostrarBD():string.
    //MostrarBD retornará una cadena (Apellido, Nombre y Edad) de todos los registros de la BD.
    //Tabla - personas { id(autoincremental - numérico) - apellido(cadena) - edad(numérico) - nombre(cadena) }.
    public static class Extensora
    {
        public static string MostrarBD(this Persona obj)
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.CONEXION);
            SqlCommand comando = new SqlCommand();
            Persona auxProdructo;
            try
            {
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM final_lab_II";
                SqlDataReader sqlReader = comando.ExecuteReader();
                StringBuilder sb = new StringBuilder();

                while (sqlReader.Read())
                {
                    auxProdructo = new Persona((string)sqlReader[3], (string)sqlReader[1], obj.idioma ,(sbyte)sqlReader[2]);
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
