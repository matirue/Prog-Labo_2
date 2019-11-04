using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ej_30.Entidades;

namespace Ej_30.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia c1 = new Competencia(15, 4);
            AutoF1 a1 = new AutoF1(1, "AAA");
            AutoF1 a2 = new AutoF1(2, "SSS");
            AutoF1 a3 = new AutoF1(3, "DDD");
            AutoF1 a4 = new AutoF1(4, "FFF");

            Console.WriteLine("\n Verder que te quiero verde: ");
            if (c1 + a1 && c1 + a2 && c1 + a3 && c1 + a4)
            {
                Console.WriteLine(c1.MostrarDatos());
            }

            Console.ReadKey();

            Console.WriteLine("\n\n\n Mitad de carrera: ");
            if (c1 - a2 )
            {
                Console.WriteLine("-> Abandona SSS ");
                Console.WriteLine(c1.MostrarDatos());
            }

            Console.ReadKey();

            Console.WriteLine("\n\n\n Ultima vuelta: ");
            if (c1 - a1)
            {
                Console.WriteLine("-> Accidentado AAA ");
                Console.WriteLine(c1.MostrarDatos());
            }


            Console.ReadKey();
        }
    }
}
