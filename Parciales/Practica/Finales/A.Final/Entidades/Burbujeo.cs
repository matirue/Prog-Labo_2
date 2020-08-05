using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Entidades
{
    //Realizar el burbujeo de una excepción propia (MiException), comenzando en un método de instancia (de la clase Burbujeo),
    //pasando por un método de estático (de la misma clase) y capturado por última vez en el método que lo inició (manejador _click).
    //En cada paso, agregar en un único archivo de texto (burbujeo.txt)
    //el lugar por donde se paso junto con la hora, minuto y segundo de la accion. 
    //Atrapar la excepción y relanzarla en cada ocasión, al finalizar, leer el archivo y mostrarlo por MessageBox
    public class Burbujeo
    {
        public void MetodoDeInstancia()
        {
            //StreamWriter sw = null;
            //try
            //{
            //    sw = new StreamWriter("burbujeo.txt");
            //    sw.WriteLine("Escrito por el METODO DE INSTANCIA");
            //}
            //catch (Exception ex)
            //{
            //    throw new MiException(ex.Message);
            //}
            //finally { sw.Close(); }
            StreamWriter sw = new StreamWriter((Environment.GetFolderPath(Environment.SpecialFolder.Desktop)) + @"\\burbujeo.txt", false);
            sw.WriteLine("Escrito por el METODO DE INSTANCIA");
            sw.Close();
            throw new MiException("");

        }

        public static void MetodoDeClase()
        {
            try
            {
                new Burbujeo().MetodoDeInstancia();
            }
            catch (MiException ex)
            {
                StreamWriter sw = new StreamWriter((Environment.GetFolderPath(Environment.SpecialFolder.Desktop)) + @"\\burbujeo.txt", true);
                sw.WriteLine("Escrito por el METODO DE CLASE");
                sw.Close();
                throw new MiException(ex.Message);
            }
        }
    }
}
