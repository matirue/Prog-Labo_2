using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic.Entidades
{
    public static class ProductoDAO
    {
        public delegate void DelegadoDB(AccionesDB accion);
        public static event DelegadoDB EventoDB;

        private static SqlConnection conexion;
        private static SqlCommand comando;

        static ProductoDAO()
        {
            string connectionStr = @"Data Source=DESKTOP-3N7LUOO; Initial Catalog=Comiqueria; Integrated Security = True";

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

        public static bool Guardar(string descripcion, double precio, int stock)
        {
            bool respuesta = false;

            try
            {
                //string consulta = String.Format("INSERT INTO Productos (descripcion, precio, stock) VALUES ('{0}', {1}, {2})", descripcion, precio, stock);
                string consulta = String.Format("INSERT INTO Producto (Descripcion, Precio, Stock) VALUES ('{0}', {1}, {2})", descripcion, precio, stock);
                comando.CommandText = consulta;
                conexion.Open();
                comando.ExecuteNonQuery();
                respuesta = true;
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            ProductoDAO.EventoDB(AccionesDB.Insert);
            return respuesta;
        }

        public static List<Producto> Leer()
        {
            List<Producto> productos = new List<Producto>();
            Producto producto;

            string consulta = String.Format("Select * from Producto");
            try
            {
                comando.CommandText = consulta;
                conexion.Open();
                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    //int codigo = int.Parse(oDr["codigo"].ToString());
                    //string descripcion = oDr["descripcion"].ToString();
                    //double precio = double.Parse(oDr["precio"].ToString());
                    //int stock = int.Parse(oDr["stock"].ToString());
                    int codigo = int.Parse(oDr["Codigo"].ToString());
                    string descripcion = oDr["Descripcion"].ToString();
                    double precio = double.Parse(oDr["Precio"].ToString());
                    int stock = int.Parse(oDr["Stock"].ToString());
                    producto = new Producto(codigo, descripcion, stock, precio);
                    productos.Add(producto);
                }
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

            return productos;
        }

        public static bool Borrar(int codigo)
        {
            bool respuesta = false;

            try
            {
                //string consulta = String.Format("DELETE FROM Productos WHERE codigo={0}", codigo);
                string consulta = String.Format("DELETE FROM Producto WHERE Codigo={0}", codigo);
                comando.CommandText = consulta;
                conexion.Open();
                comando.ExecuteNonQuery();
                respuesta = true;
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
            ProductoDAO.EventoDB(AccionesDB.Delete);
            return respuesta;
        }
    }
}
