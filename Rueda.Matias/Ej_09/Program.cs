using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ej_09";

            Console.WriteLine("Escribir un programa que imprima por pantalla una pirámide como la siguiente: \n*\n***\n*****\n*******\n*********");
            Console.WriteLine("\n---------------------------------------------\n");

            int altura;
            int escalones = 0;

            Console.WriteLine("Ingrese la altura de la piramide: ");
            altura = int.Parse(Console.ReadLine());

            while (altura >= escalones)
            {
                escalones++;

                for (int i = 1; i < escalones; i++)
                    Console.Write("*");

                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
