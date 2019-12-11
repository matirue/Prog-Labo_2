using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using ComiqueriaLogic.Comun;

namespace ComiqueriaLogic.Entidades
{
    public static class ArchivoTexto
    {
        static StreamWriter tw;
        static StreamReader tr;


        /// <summary>
        /// Método para guardar los datos de un objeto del tipo de interfaz IArchivoTexto
        /// </summary>
        /// <param name="objeto"></param>
        /// <param name="append"></param>
        /// <returns></returns>
        public static bool Escribir(IArchivoTexto objeto, bool append)
        {
            try
            {
                //Creo variable para escribir en un archivo
                tw = new StreamWriter(objeto.Ruta, append, Encoding.UTF8);
                // Escribo cada dato en una linea diferente
                tw.WriteLine(objeto.Texto);
                return true;
            }
            catch (NotSupportedException exception)
            {
                return false;
                throw new ComiqueriaException("Error al guardar.", exception);
            }
            catch (IOException exception)
            {
                return false;
                throw new ComiqueriaException("Error al guardar", exception);
            }
            finally
            {
                tw.Close(); // Cierro el archivo
            }
        }

        /// <summary>
        /// Implementación de método para leer de un archivo de texto
        /// </summary>
        /// <param name="objeto"></param>
        /// <param name="append"></param>
        /// <returns></returns>
        public static string Leer(string archivo)
        {
            try
            {
                // Creo variable para leer archivo
                tr = new StreamReader(archivo, Encoding.UTF8);
                // Leo hasta el final del archivo y guardo la información en un string
                return tr.ReadToEnd();
            }
            catch (OutOfMemoryException exception)
            {
                throw new ComiqueriaException("Error al leer.", exception);
            }
            catch (IOException exception)
            {
                throw new ComiqueriaException("Error al leer.", exception);
            }
            finally
            {
                tr.Close(); // Cierro el archivo
            }
        }


    }
}
