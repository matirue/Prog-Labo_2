using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ComiqueriaLogic.Comun
{
    public static class Serializador<T> where T : class, new()
    {
        //XML

        public static bool GuardarXML(string rutaArchivo, T objeto)
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
                throw new Exception("Error al guardar en XML", e);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
            return true;
        }

        //Aca estan todas las excepciones pedidas en el parcial
        public static T Leer(string rutaArchivo)
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
            catch (ArgumentException e)
            {
                throw e;
            }
            catch (DirectoryNotFoundException e)
            {
                throw new ComiqueriaException("Error: Directorio no encontrado.", e);
            }
            catch (Exception e)
            {
                throw new Exception("Ocurrió un error, contacte al administrador", e);
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

        //Binario

        public static bool GuardarBinario(string ruta, T datos)
        {
            FileStream fs = null;
            BinaryFormatter ser = null;
            try
            {
                fs = new FileStream(ruta, FileMode.Create);
                ser = new BinaryFormatter();
                ser.Serialize(fs, datos);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
            return true;
        }

        public static T LeerBinario(string ruta)
        {
            T datos;
            FileStream fs = null;
            BinaryFormatter ser = null;
            try
            {
                fs = new FileStream(ruta, FileMode.Open);
                ser = new BinaryFormatter();
                datos = (T)ser.Deserialize(fs);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
            return datos;
        }

    }
}
