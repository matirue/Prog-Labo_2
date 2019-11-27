using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Archivos
{
    public class Xml<T>: IArchivo<T>
    {
        public void Guardar(string archivo, T datos)
        {
            XmlTextWriter tw = null;
            XmlSerializer serialisable = null;
            try
            {
                tw = new XmlTextWriter(archivo, Encoding.UTF8);
                serialisable = new XmlSerializer(typeof(T));

                serialisable.Serialize(tw, datos);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                tw.Close();
            }
        }

        public void Leer(string archivo, out T datos)
        {
            XmlTextReader tr = null;
            XmlSerializer serialisable = null;
            try
            {
                tr = new XmlTextReader(archivo);
                serialisable = new XmlSerializer(typeof(T));

                datos=(T)serialisable.Deserialize(tr);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                tr.Close();
            }
        }
    }
}
