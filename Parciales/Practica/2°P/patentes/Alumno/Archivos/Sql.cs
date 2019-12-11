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
        SqlConnection conexion;
        SqlCommand comando;

        public Sql()
        {
            this.conexion = new SqlConnection(Properties.Settings.Default.Conexion);
            this.comando = new SqlCommand();
            this.comando.CommandType = CommandType.Text;
            this.comando.Connection = conexion;
        }

        #region Implementacion de IArchivo
        public void Guardar(string archivo, Queue<Patente> datos)
        {
            //try
            //{
            //    string path = "INSERT INTO " + archivo + "(patente, tipo)";
            //    foreach (Patente p in datos)
            //    {
            //        path += "SELECT '" + p.CodigoPatente.ToString() + "','" + p.TipoCodigo.ToString() + "' UNION ALL";
            //    }

            //    path = path.Substring(0, path.Length - 11);
            //    this.comando.CommandText = path;//le paso las instrucciones 
            //    this.conexion.Open();//inicio concexion
            //    this.comando.ExecuteNonQuery();//ejecuto comando
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            //finally
            //{
            //    if (this.conexion.State == ConnectionState.Open)
            //    {
            //        this.conexion.Close();
            //    }
            //}

            foreach (Patente patente in datos)
            {
                try
                {
                    //string consulta = String.Format("INSERT INTO {0} (patente, tipo) VALUES ('{1}','{2}')",
                    //    archivo, patente.CodigoPatente, patente.TipoCodigo.ToString());

                    string consulta = String.Format("INSERT INTO " + archivo + " (patente, tipo) VALUES ('{1}','{2}')",
                        patente.CodigoPatente, patente.TipoCodigo.ToString());

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

        public void Leer(string archivo, out Queue<Patente> datos)
        {
            datos = new Queue<Patente>();
            Patente patente;

            try
            {
                string consulta = String.Format("SELECT * FROM {0}", archivo);
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


    }
}
