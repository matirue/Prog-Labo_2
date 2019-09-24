using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ej_19";

            Sumador s1 = new Sumador();
            Sumador s2 = new Sumador(3);
            Console.WriteLine("S1 iniciado en 0:");
            Console.WriteLine("Uso sumar que recibe long:");
            Console.WriteLine(s1.Sumar(3, 3));
            Console.WriteLine("\n\nUso sumar que recibe strin:");
            Console.WriteLine(s1.Sumar("4", "4"));

            Console.WriteLine("\n\n\nS2 iniciado en 3:");
            Console.WriteLine("Uso sumar que recibe long:");
            Console.WriteLine(s1.Sumar(5, 5));
            Console.WriteLine("\n\nUso sumar que recibe strin:");
            Console.WriteLine(s1.Sumar("6", "6"));

            Console.ReadKey();
        }
    }
}
