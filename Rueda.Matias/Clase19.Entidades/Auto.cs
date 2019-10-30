using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Xml.Serialization;
using System.IO;

namespace Clase19.Entidades
{
    public class Auto:IXML
    {
        #region Atributos
        public string marca;
        public double precio;
        #endregion

        #region Constructores
        public Auto() { }
        public Auto(string marca, double precio):this()
        {
            this.marca = marca;
            this.precio = precio;
        }
        #endregion

        public override string ToString()
        {
            return " Marca: " + this.marca + " -> $" + this.precio;
        }


        #region Implementacion de IXML
        public bool Guardar(string cad)
        {
            try
            {
                XmlSerializer objXmlSer = new XmlSerializer(typeof(Auto));
                TextWriter tw = new StreamWriter(cad);
                objXmlSer.Serialize(tw, this);
                tw.Close();
                return true;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool Leer(string cad, out object obj)
        {
            try
            {
                XmlSerializer objXmlSer = new XmlSerializer(typeof(Auto));
                TextReader tr = new StringReader(cad);
                obj=(Auto)objXmlSer.Deserialize(tr);
                tr.Close();
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
