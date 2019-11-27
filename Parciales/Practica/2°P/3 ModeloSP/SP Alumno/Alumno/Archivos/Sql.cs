using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Archivos
{
    public class Sql : IArchivo<Queue<Patente>>
    {
        #region Campos
        static SqlCommand comando;
        static SqlConnection conexion;
        #endregion

        #region Metodos

        static Sql()
        {
            //string connectionStr = @"Data Source=.\SQLEXPRESS; Initial Catalog=patentes-sp-2018; Integrated Security = True";
            try
            {
                conexion = new SqlConnection(Properties.Settings.Default.Conexion);
                comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
        #region Implementacion de IArchivo       


        public void Guardar(string tabla, Queue<Patente> datos)
        {
            foreach(Patente patente  in datos)
            {
                try
                {
                    string consulta = String.Format("INSERT INTO {0} (patente, tipo) VALUES ('{1}','{2}')",
                        tabla, patente.CodigoPatente, patente.TipoCodigo.ToString());

                    comando.CommandText = consulta;
                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        public void Leer(string tabla, out Queue<Patente> datos)
        {
            datos = new Queue<Patente>();
            Patente patente;

            try
            {
                string consulta = String.Format("SELECT * FROM {0}", tabla);
                comando.CommandText = consulta;
                conexion.Open();

                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    string codigoPatente = lector["patente"].ToString();
                    Enum.TryParse(lector["tipo"].ToString(), out Patente.Tipo tipoPatente);
                    patente = new Patente(codigoPatente, tipoPatente);
                    datos.Enqueue(patente);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
        #endregion
       
        
        #endregion


    }
}
