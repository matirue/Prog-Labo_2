using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Entidades
{
    public class Manejador<T>
    {
        public void manejadorTexto(double p)
        {
            StreamWriter sw = null;
            try
            {

                sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//ArchivoEvento.txt");
                sw.WriteLine(DateTime.Now.ToString());
                sw.WriteLine("PRECIO TOTAL: " + p.ToString());
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sw != null)
                    sw.Close();
            }
        }
    }
}
