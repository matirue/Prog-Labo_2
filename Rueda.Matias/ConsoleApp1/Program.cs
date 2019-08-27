using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ej_02";
            Console.WriteLine("Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: ERROR. ¡Reingresar número!.\n\n");

            int num;

            Console.Write("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());


            while (num <= 0)
            {
                Console.Clear();

                Console.WriteLine("\n\n ERROR. ¡Reingresar número!");
                Console.Write("\nIngrese un numero: ");
                num = int.Parse(Console.ReadLine());
            }

            Console.Clear();

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Ingreso: {0}", num);
            Console.WriteLine("El cuadrado: {0}", Math.Pow(num, 2));
            Console.WriteLine("El cubo: {0}", Math.Pow(num, 3));
            Console.WriteLine("-------------------------------------------");

            Console.ReadKey();
        }
    }
}
