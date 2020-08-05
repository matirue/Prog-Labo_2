using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    //Persona (apellido:string; edad:Sbyte) - ToString():string (polimorfismo; reutilizar código) 
    //Todos los atributos de las clases son públicos y además:
    //que todas las clases poseen un sólo constructor (sin sobrecargas).
    public class Persona:Humano
    {
        public string apellido;
        public sbyte edad;
    
        public Persona() :base() { }
        public Persona(string nombre, string apellido, EIdioma idioma, sbyte edad) : base(nombre, idioma)
        {
            this.apellido = apellido;
            this.edad = edad;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.ToString());
            sb.AppendFormat("\n Apellido: " + this.apellido + "\nEdad: " + this.edad);
            return sb.ToString();
        }

        //Agregar método de extensión (clase Extensora) en Persona AgregarBD():bool.
        //AgregarBD retornará un booleano indicando si se pudo agregar o no a la base de datos.
        public bool AgregarBD()
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.CONEXION);
            SqlCommand comando = new SqlCommand();
            try
            {
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO final_lab_II (apellido,nombre,edad) VALUES ('" + this.apellido.ToString() + 
                                                                                        "'," + this.nombre.ToString() +
                                                                                     "'," + this.edad.ToString() + ")";
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
    }
}
