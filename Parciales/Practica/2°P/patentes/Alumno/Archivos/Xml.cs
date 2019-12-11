using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T> : IArchivo<T> where T:new()
    {
        public void Guardar(string archivo, T datos)
        {
            XmlSerializer serializador = new XmlSerializer(typeof(T));
            StreamWriter sw = new StreamWriter(archivo);
            serializador.Serialize(sw, datos);
            sw.Close();
        }

        public void Leer(string archivo, out T datos)
        {
            XmlSerializer serializador = new XmlSerializer(typeof(T));
            StreamReader sr = new StreamReader(archivo);
            datos = (T)serializador.Deserialize(sr);
            sr.Close();
        }
    }
}
