using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic.Comun
{
    public static class ArchivoTexto
    {
        public static void Escribir(IArchivoTexto objeto, bool append)
        {
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(objeto.Ruta, append);
                writer.Write(objeto.Texto);
                writer.WriteLine("------------------------------------");
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }

        public static string Leer(string ruta)
        {
            StreamReader reader = null;
            string texto;
            try
            {
                reader = new StreamReader(ruta);
                texto = reader.ReadToEnd();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return texto;
        }
    }
}
