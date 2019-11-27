using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace ComiqueriaLogic.Entidades
{
    public static class ClassSQL
    {
        public delegate void DelegadoBaseDeDatos(AccionesDB acciones);
        public static event DelegadoBaseDeDatos AccesoBaseDeDatos;

        
        #region Campos

        //cadena de instancia sql y base de dato 
        //private String connectionStr = @"Data Source=DESKTOP-3N7LUOO\SQLEXPRESS; "
        //        + "Initial Catalog = Comiqueria; Integrated Security = True";
        //private String connectionStr;
        //private String connectionStr = @"Data Source=.\SQLEXPRESS; "
        //        + "Initial Catalog = Comiqueria; Integrated Security = True";


        //atributo para la conexion con base de datos
         static SqlConnection conexion;
        //atributo para comandos sql
         static SqlCommand comando;
        //atributo de lectura para la tabla de mi bd
         static SqlDataReader lectorBaseDeDatos;
        #endregion

        #region Metodos

        ///// <summary>
        ///// Método para inicializar atributos para trabajar con la base de datos
        ///// </summary>
        //void ConectarBaseDeDatos()
        //{
        //    try
        //    {
        //        //conexion = new SqlConnection(connectionStr); //creo conexion por string
        //        conexion = new SqlConnection(Properties.Settings.Default.Conexion);
        //        //conexion.Open();
        //        comando = new SqlCommand();//creo obj de comandos
        //        comando.Connection = conexion;
        //        //seteo al objeto comando para trabajar con texto
        //        comando.CommandType = System.Data.CommandType.Text;

                
        //    }
        //    catch (InvalidOperationException ex)
        //    {

        //        throw new ComiqueriaException("Error en la onexion a BD!!!", ex);
        //    }
        //}

        /// <summary>
        /// Constructor público que inicializa la conexión a la base de datos
        /// </summary>
        static ClassSQL()
        {
            try
            {
                //conexion = new SqlConnection(connectionStr); //creo conexion por string
                conexion = new SqlConnection(Properties.Settings.Default.Conexion);
                //conexion.Open();
                comando = new SqlCommand();//creo obj de comandos
                
                //seteo al objeto comando para trabajar con texto
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;

            }
            catch (InvalidOperationException ex)
            {

                throw new ComiqueriaException("Error en la onexion a BD!!!", ex);
            }
        }

        #endregion


        /// <summary>
        /// Método para guardar en la base de datos
        /// </summary>
        /// <param name="descripcion"></param>
        /// <param name="stock"></param>
        /// <param name="precio"></param>
        /// <returns></returns>
        public static bool Guardar(string descripcion, int stock, double precio)
        {
            try
            {
                //StringBuilder comandoText = new StringBuilder("INSERT INTO Productos(Descripcion,Precio,Stock)");
                //comando.CommandText = comandoText.AppendFormat("VALUES('{0}',{1},{2})", descripcion, precio, stock).ToString();

                string comandoText = String.Format("INSERT INTO Producto(Descripcion,Precio,Stock) VALUES('{0}',{1},{2})", descripcion, precio, stock);
                comando.CommandText = comandoText;
                conexion.Open();
                comando.ExecuteNonQuery();//ejecuta los comando
                
                return true;
            }
            catch (SqlException ex)
            {
                return false;
                throw new ComiqueriaException("Error al Guardad en la BD!!!", ex);
            }
            finally
            {
                conexion.Close();
            }
            ClassSQL.AccesoBaseDeDatos(AccionesDB.Insert);
        }

        /// <summary>
        /// Método para leer TODOS los datos de una tabla de la base de datos SQL
        /// </summary>
        /// <returns></returns>
        public static List<Producto> Leer()
        {
            Producto producto;
            List<Producto> listado = new List<Producto>();
            

            try
            {
                
                conexion.Open();
                comando.CommandText = "SELECT * FROM Producto";
                lectorBaseDeDatos = comando.ExecuteReader();//seteo para leer

                while (lectorBaseDeDatos.Read())
                {
                    int codigo = int.Parse(lectorBaseDeDatos["Codigo"].ToString());
                    string descripcion = lectorBaseDeDatos["Descripcion"].ToString();
                    double precio = double.Parse(lectorBaseDeDatos["Precio"].ToString());
                    int stock = int.Parse(lectorBaseDeDatos["Stock"].ToString());

                    // Creo un nuevo objetos con los datos leídos de cada columna de la tabla y agrego
                    producto = new Producto(codigo,descripcion,stock,precio);

                    listado.Add(producto);
                }
                
            }
            catch (SqlException ex)
            {

                throw new ComiqueriaException("ERROR al leer la BD", ex);
            }
            finally
            {
                conexion.Close();
            }
            return listado;
        }

        /// <summary>
        /// Método para eliminar un objeto de una tabla de la base de datos SQL
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool Borrar(Producto producto)
        {          

            try
            {
                string comandoText = String.Format("DELETE FROM Producto WHERE Codigo={0}", producto.Codigo);
                comando.CommandText = comandoText;
                conexion.Open();
                comando.ExecuteNonQuery();//ejecuta el comando
                ClassSQL.AccesoBaseDeDatos(AccionesDB.Delete);
                return true;
            }
            catch (SqlException ex)
            {
                return false;
                throw new ComiqueriaException("ERROR al acceder a la BD", ex);
            }
            finally
            {
                conexion.Close();
            }
            
        }

        /// <summary>
        /// Método para actualizar los datos de un objeto de una tabla de la base de datos SQL
        /// </summary>
        /// <param name="descripcion"></param>
        /// <param name="precio"></param>
        /// <returns></returns>
        public static bool Modificar(string descripcion, double precio)
        {
            StringBuilder comandoText = new StringBuilder("UPDATE Poducto SET ");

            comando.CommandText = comandoText.AppendFormat("precio = '{0}', WHERE Descripcion = '{1}'",
                precio, descripcion).ToString();

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();//ejecuta el comando
                ClassSQL.AccesoBaseDeDatos(AccionesDB.Update);
                return true;
            }
            catch (SqlException ex)
            {
                return false;
                throw new ComiqueriaException("ERROR al acceder a la BD", ex);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}