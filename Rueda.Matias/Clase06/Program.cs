using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Clase06.Entidades.V1;

namespace Clase06
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Tempera t = new Tempera(ConsoleColor.Black, "aaaa", 11);
            //Tempera t2 = new Tempera(ConsoleColor.Red, "ssss", int.MaxValue);
            //Console.WriteLine(t == t2); 
            //Console.WriteLine((string)t); 


            //Paleta a = new Paleta(11);
            Paleta a = 3;
            Tempera c= new Tempera(ConsoleColor.Red, "aaaa", 4);
            Tempera d = new Tempera(ConsoleColor.Green, "bbbb", 3);

            //a = 3;
            a = a + c;
            a += d;
            Console.WriteLine((string)a);
            Console.ReadKey();


        }
    }
}
