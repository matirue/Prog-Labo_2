using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Clase06.Entidades;

namespace Clase06
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Tempera obj = new Tempera(ConsoleColor.Black, "marca", 12);
            //Tempera obj2 = new Tempera(ConsoleColor.Black, "marca", int.MaxValue);
            //Console.WriteLine(obj == obj2); // true
            //Console.WriteLine((string)obj); // black -- marca -- 12


            //Paleta a = new Paleta(55);
            Paleta a = 3;
            Tempera c= new Tempera(ConsoleColor.Red, "aaaa", 2);
            Tempera d = new Tempera(ConsoleColor.Green, "bbbb", 1);

            //a = 3;
            a = a + c;
            a += d;
            Console.WriteLine(a);
            Console.ReadKey();


        }
    }
}
