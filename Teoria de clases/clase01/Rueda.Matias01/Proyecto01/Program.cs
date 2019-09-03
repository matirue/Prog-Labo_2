using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Programa01";

            /*
            System.Console.WriteLine("Hola Mundo. \n");
            //System.Console.ReadKey();
            System.Console.ReadLine();
            */

            /* declarando variable *
            string name;
            Console.WriteLine(" NOMBRE: ");
            name =Console.ReadLine();
            Console.Write("{0}", name);
            */

            /*sin declarar variable*/
            //Console.WriteLine("NOMBRE: ");
            Console.Write("NOMBRE: ");
            Console.WriteLine("\nNombre ingresado: {0} \n", Console.ReadLine());
            Console.WriteLine("Fecha: {0:dd-MM-yyyy}", DateTime.Now);
            Console.ReadKey();
            


        }
    }
}
