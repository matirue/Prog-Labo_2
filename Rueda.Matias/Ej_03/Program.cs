using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ej_03";

            Console.WriteLine("Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.\n");

            int num;
            int cont = 1;

            Console.Write("Ingrese una cantidad de numeros primos: ");

            num = int.Parse(Console.ReadLine());

            for (int i = 1; cont <= num; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(" --> {0} es primo", i);
                    cont++;
                }
            }
            Console.ReadKey();
        }
    }
}
