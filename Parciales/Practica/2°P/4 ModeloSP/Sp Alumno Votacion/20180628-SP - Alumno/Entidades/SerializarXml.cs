using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Entidades
{
    public class SerializarXml<T> : IArchivos<T>
    {
        public bool Guardar(string rutaArchivo, T objeto)
        {
            XmlTextWriter writer = null;
            XmlSerializer ser = null;
            try
            {
                writer = new XmlTextWriter(rutaArchivo, Encoding.UTF8);
                ser = new XmlSerializer(typeof(T));
                ser.Serialize(writer, objeto);
            }
            catch (Exception e)
            {
                throw new ErrorArchivoException("Error al guardar en XML", e);
            }
            finally
            {
                if(writer != null)
                {
                    writer.Close();
                }
            }
            return true;
        }

        public T Leer(string rutaArchivo)
        {
            T datos;
            XmlSerializer ser = null;
            XmlTextReader reader = null;
            try
            {
                ser = new XmlSerializer(typeof(T));
                reader = new XmlTextReader(rutaArchivo);
                datos = (T)ser.Deserialize(reader);
            }
            catch (Exception e)
            {
                throw new ErrorArchivoException("Error al leer de XML", e);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return datos;
        }
    }
}
