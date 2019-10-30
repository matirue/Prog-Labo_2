using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Xml.Serialization;
using System.IO;

namespace Clase19.Entidades
{
    [XmlInclude(typeof(Alumno))]
    [XmlInclude(typeof(Empleado))]

    public class Persona:IXML
    {
        #region Atributos
        public string nombre;
        public string apellido;

        private int _edad;
        private List<String> _apodo;
        #endregion

        #region Construtor

        public Persona(string nombre, string apellido, int edad):this()
        {
            this.nombre = nombre;
            this.apellido = apellido;

            this._edad = edad;

        }

        public Persona()//constructor por default para evitar la exception
        {
            this.GetApodos = new List<string>();
            
        }

        #endregion

        #region Propiedad

        //porpiedad de lec y esc necesario si o si para los atributos privas sean cargados
        //no guarda si la prop es solo lec o esc
        public int GetEdad
        {
            get { return this._edad; }
            set { this._edad = value; }
        }

        //con cualquier coleccion alcanza que la prop sea solo lectura
        public List<string>  GetApodos
        {
            get { return this._apodo; }
            set { this._apodo = value; }
        }

        #endregion


        public override string ToString()
        {
            //foreach para los apodos
            StringBuilder apodos = new StringBuilder();
            foreach(string x in this.GetApodos)
            {
                apodos.Append(x);
            }

            
                return "Persona: " + this.apellido + ", " + this.nombre + " ->EDAD:" + this._edad.ToString()
                + " // Apodo: " + apodos.ToString() + " // ";         
        }

        #region Implementacion de IXML
        bool IXML.Guardar(string cad)
        {
            try
            {
                XmlSerializer objXmlSer = new XmlSerializer(typeof(Persona));
                TextWriter tw = new StreamWriter(cad);
                objXmlSer.Serialize(tw, this);

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        bool IXML.Leer(string cad, out object obj)
        {
            try
            {
                XmlSerializer objXmlSer = new XmlSerializer(typeof(Persona));
                TextReader tr = new StreamReader(cad);
                obj = (Persona)objXmlSer.Deserialize(tr);

                return true;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                obj = null;
                return false;
            }
        }
        #endregion
    }
}
