using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.IO;

namespace Entidades
{
    //Realizar el burbujeo de una excepción propia (MiException), comenzando en un método de instancia
    //(de la clase Burbujeo), pasando por un método de estático (de la misma clase *) y capturado 
    //por última vez en el método que lo inicio (manejador btnPunto4_Click). 
    //En cada paso, agregar en un único archivo de texto (burbujeo.log), en la carpeta 
    //'Mis documentos' del cliente, el lugar por donde se pasó junto con la hora, minuto y segundo de la acción. 
    //Atrapar la excepción y relanzarla en cada ocación.
    public class Burbujeo
    {

        public void MetodoInstancia()
        {            
            StreamWriter sw = new StreamWriter((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)) + @"\\burbujeo.log", false);
            sw.WriteLine("Escrito por el METODO DE INSTANCIA");
            sw.Close();
            throw new MiException("");

        }

        public static void MetodoClase()
        {
            try
            {
                new Burbujeo().MetodoInstancia();
            }
            catch (MiException ex)
            {
                StreamWriter sw = new StreamWriter((Environment.GetFolderPath(Environment.SpecialFolder.Desktop)) + @"\\burbujeo.log", true);
                sw.WriteLine("Escrito por el METODO DE CLASE");
                sw.Close();
                throw new MiException(ex.Message);
            }
        }
    }
}
