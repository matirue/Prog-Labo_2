using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace ComiqueriaLogic.Entidades
{
    public static class Serializador<T> where T : new()
    {         
        static Serializador() { }


        /// <summary>
        /// Metodo que guarda un archivo binario Xml
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public static bool GuardarXmlBinario(string archivo, T datos)
        {
            FileStream lector=null;
            BinaryFormatter serializador=null;
            try
            {
                // Creo objeto para escribir el archivo
                lector = new FileStream(archivo, FileMode.Create);
                // Creo objeto para serializar el objeto para escribir
                serializador = new BinaryFormatter();
                // Serializo el objeto para escribir en el archivo
                serializador.Serialize(lector, datos);
                return true;
            }
            catch (NullReferenceException ex)
            {
                return false;
                throw new ComiqueriaException("ERROR!!! excepction de referencia", ex);
            }
            catch (ArgumentException ex)
            {
                return false;
                throw new ComiqueriaException("ERROR!!! excepction de argumento", ex);
            }
            catch (DirectoryNotFoundException ex)
            {
                return false;
                throw new ComiqueriaException("Error: Directorio no encontrado.", ex);
            }
            finally
            {
                lector.Close();
            }
        }

        /// <summary>
        /// Implementación del método para leer de un archivo XML
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public static bool LeerXmlBinario(string archivo, out T datos)
        {
            // Creo objeto para leer el archivo
            FileStream lector = null;
            BinaryFormatter serializador = null;
            
            try
            {
                lector = new FileStream(archivo, FileMode.Open);
                serializador = new BinaryFormatter();

                datos = (T)serializador.Deserialize(lector);
                return true;
            }
            catch (ArgumentException ex)
            {
                //return false;
                throw new ComiqueriaException("ERROR!!! excepction de argumento", ex);
            }
            catch (DirectoryNotFoundException ex)
            {
                //return false;
                throw new ComiqueriaException("Error: Directorio no encontrado.", ex);
            }
            finally
            {
                lector.Close();
            }
        }

        /// <summary>
        /// Implementación de método para guardar en un archivo XML
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public static bool GuardarXml(string archivo, T datos)
        {
            XmlTextWriter tw=null;
            XmlSerializer serializador;
            try
            {
                // Creo objeto para escribir el archivo
                tw = new XmlTextWriter(archivo, Encoding.UTF8);
                // Creo objeto para serializar el objeto para escribir
                serializador = new XmlSerializer(typeof(T));
                //serializo el objeto para escribir en el archivo
                serializador.Serialize(tw, datos);
                return true;
            }
            catch (ArgumentException ex)
            {
                return false;
                throw new ComiqueriaException("ERROR!!! excepction de argumento", ex);
            }
            catch (DirectoryNotFoundException ex)
            {
                return false;
                throw new ComiqueriaException("Error: Directorio no encontrado.", ex);
            }
            finally
            {
                tw.Close();
            }
        }

        /// <summary>
        /// Implementación del método para leer de un archivo XML
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public static bool LeerXml(string archivo, out T datos)
        {
            // Creo objeto para Leer el archivo
            XmlTextReader tr = null;
            // Creo objeto para serializar el objeto para escribir
            XmlSerializer serializador;

            try
            {
                tr = new XmlTextReader(archivo);
                serializador = new XmlSerializer(typeof(T));

                datos = (T)serializador.Deserialize(tr);
                return true;
            }
            catch (ArgumentException ex)
            {

                throw new ComiqueriaException("ERROR!!! excepction de argumento", ex);
            }
            catch (DirectoryNotFoundException ex)
            {

                throw new ComiqueriaException("Error: Directorio no encontrado.", ex);
            }
            finally
            {
                tr.Close();
            }
        }

    }
}
