using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02
{

    //importante q sea public
    public class Miclase
    {
        public static int edad;
        public static string nombre;
         
        public static void MostrarEdad()
        {
            Console.WriteLine(Miclase.edad);
            Console.ReadKey();
        }
        
        public static string MostrarNombre()
        {
            nombre = "MATIAS";

            return Miclase.nombre;
        }

        public static bool CompararNombres(string nombre)
        {
            if (nombre == Miclase.nombre)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
