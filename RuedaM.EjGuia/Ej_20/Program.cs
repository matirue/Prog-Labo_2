using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EJ_20";

            Dolar d1 = new Dolar(1);
            Peso p1 = new Peso(17.55);
            Euro e1 = new Euro(20);

            Console.WriteLine(d1 == p1);
            Console.WriteLine(d1 == e1);
            Console.WriteLine(e1 == p1);

            //Console.WriteLine(d1 + p1);

            Console.ReadKey();
        }
    }
}
