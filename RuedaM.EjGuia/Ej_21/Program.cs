using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EJ_21";

            Celsius a = new Celsius();
            Kelvin b = new Kelvin();
            Farenheit c = new Farenheit();

            Celsius d = new Celsius(10);
            Kelvin e = new Kelvin(20);
            Farenheit f = new Farenheit(100);

            Console.WriteLine(a.GetCantidad+" "+b.GetCantidad + " " + c.GetCantidad + " " + d.GetCantidad + " " + e.GetCantidad + " " + f.GetCantidad);

            a = d + e;

            Console.WriteLine("\n " + a.GetCantidad);
       
            Console.ReadKey();
        }
    }
}
