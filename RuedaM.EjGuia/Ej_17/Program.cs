using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EJ_17";

            ConsoleColor color = Console.ForegroundColor;//tomo el color actual
            string dibu1;
            string dibu2;
            string dibu3;
            string dibu4;

            Boligrafo a = new Boligrafo(100, ConsoleColor.Blue);//tinta azul y cantidad de 100
            Boligrafo b = new Boligrafo(50, ConsoleColor.Red);//tinta rpja y cantidad de 50
            Boligrafo c = new Boligrafo(50, ConsoleColor.Green);
            Boligrafo d = new Boligrafo(50, ConsoleColor.Magenta);

            Console.WriteLine("\n ---> A obj a con 100 de tinta uso toda la tinta");
            if (a.Pintar(100,out dibu1))
            {
                
                Console.ForegroundColor = a.GetColor;
                Console.WriteLine(dibu1);
                Console.ForegroundColor = color;

            }

            Console.WriteLine("\n ---> A obj b con 50 de tinta uso toda la tinta");
            if (b.Pintar(50, out dibu2))
            {
                
                Console.ForegroundColor = b.GetColor;
                Console.WriteLine(dibu2);
                Console.ForegroundColor = color;
            }

            Console.WriteLine("\n ---> A obj c con 50 de tinta uso 5 la tinta");
            if (c.Pintar(5, out dibu3))
            {
                
                Console.ForegroundColor = c.GetColor;
                Console.WriteLine(dibu3);
                Console.ForegroundColor = color;
            }

            Console.WriteLine("\n ---> A obj d con 50 de tinta uso 0 la tinta");
            if (d.Pintar(0, out dibu4))
            {

                Console.ForegroundColor = d.GetColor;
                Console.WriteLine(dibu4);
                Console.ForegroundColor = color;
            }

            Console.ReadKey();
        }
    }
}
