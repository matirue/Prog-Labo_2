using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Dao : IArchivos<Votacion>
    {
        static SqlCommand comando;
        static SqlConnection conexion;

        static Dao()
        {
            //string connectionStr = @"Data Source=.\SQLEXPRESS; Initial Catalog=votacion-sp-2018; Integrated Security = True";
            string connectionStr = @"Data Source=DESKTOP-3N7LUOO; Initial Catalog=votacion-sp-2018; Integrated Security = True";
            try
            {
                conexion = new SqlConnection(connectionStr);
                comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool Guardar(string tabla, Votacion votacion)
        {
            try
            {
                string consulta = String.Format("INSERT INTO {0} (nombreLey, afirmativos, negativos, abstenciones, nombreAlumno) VALUES ('{1}', {2}, {3}, {4}, '{5}')", 
                    tabla, votacion.ContadorAfirmativo, votacion.ContadorAfirmativo, votacion.ContadorNegativo, votacion.ContadorAbstencion, "Leandro Egea");
                comando.CommandText = consulta;
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return true;
        }

        public Votacion Leer(string tabla)
        {
            throw new NotImplementedException();
        }
    }
}
