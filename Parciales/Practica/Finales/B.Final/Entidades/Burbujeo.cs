using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Entidades
{
    public class Burbujeo
    {
        public static void MetodoClase()
        {
            GuardarArchivo("Pasa por metodo de clase estatico");

            try
            {
                Burbujeo burb = new Burbujeo();
                burb.MetodoInstancia();
            }
            catch (MiException e)
            {
                throw e;
            }
        }

        public void MetodoInstancia()
        {
            GuardarArchivo("Pasa por metodo de instancia");
            throw new MiException("Metodo de instancia");
        }

        public static void GuardarArchivo(string msg)
        {
            //using (TextWriter tw = new StreamWriter("burbujeo.txt", true))
            using (TextWriter tw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\burbujeo.txt", true))
            {
                tw.WriteLine(msg + "   " + DateTime.Now);
            }
        }
    }
}
