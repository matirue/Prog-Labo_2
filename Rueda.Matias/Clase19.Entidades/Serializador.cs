using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase19.Entidades
{
    public static class Serializador
    {
        public static bool Serializar (IXML x)
        {
            //return x.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\XMLarchivo.xml");
            //return x.Guardar(@"C:\Users\Matias\Desktop\Carpeta de prueba\Clase19\XMLarchivo4.xml");
            return x.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Carpeta de prueba\\Clase19\\archivoFinal.xml");
        }

        public static bool Deserializar(IXML x, out object obj)
        {
            //return x.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\XMLarchivo4.xml", out obj);
            //return x.Leer(@"C:\Users\Matias\Desktop\Carpeta de prueba\Clase19\XMLarchivo4.xml", out obj);
            return x.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Carpeta de prueba\\Clase19\\archivoFinal.xml", out obj);
        }
    }
}
