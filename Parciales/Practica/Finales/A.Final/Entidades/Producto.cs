using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    
    //La clase Producto tiene dos atributos: nombre y stock y un único constructor
    public class Producto
    {
        #region Campos
        string nombre;
        int stock;
        #endregion

        #region Propiedades
        public string  Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public int Stock
        {
            get { return this.stock; }
            set { this.stock = value; }
        }
        #endregion

        #region Metodos
        public Producto() { }
        public Producto(string nombre, int stock) : this()
        {
            this.nombre = nombre;
            this.stock = stock;
        }

        public override string ToString()
        {
            return String.Format("\nNombre: " + this.Nombre + "\nStock: " + this.Stock);
        }

        public static bool operator ==(Producto a, Producto b)
        {
            if(!Object.Equals(a,null) && !Object.Equals(b, null))
            {
                if (a.Nombre == b.Nombre)
                    return true;
            }
            
            return false;
        }
        public static bool operator !=(Producto a, Producto b) { return !(a == b); }

        public static int operator ==(Producto[] a, Producto b)
        {
            int retorno = -1;

            for(int i = 0; i < a.Length ; i++)
            {
                if (a[i] == b)
                {
                    retorno = i;
                    break;
                }                    
            }
            return retorno;
        }
        public static int operator !=(Producto[] a, Producto b) { return -1; }

        //AgregarBD insertará sobre la Base de Datos la instancia que lo invoque (Nombre y Stock)
        //Base de Datos (productosDB) -> Tabla productos (nombre - stock)
        public bool AgregarBD()
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.CONEXION);
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO productosBD (nombre,stock) VALUES ('" + this.Nombre.ToString() +
                                                                                     "'," + this.Stock.ToString() + ")";
                conexion.Open();
                comando.ExecuteNonQuery();                
                return true;

            }
            catch (Exception)
            {                
                return false;
            }
            finally { conexion.Close(); }

        }


        #endregion


    }
}
