using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ej_04";
            Console.Write("Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo) que son divisores del número. El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6. Escribir una aplicación que encuentre los 4 primeros números perfectos.\n\n");

            int numero;
            int solA;
            int solB;

            Console.WriteLine("\n\n-------------------------------------------------------\nLos 4 primeros numeros perfectos son: ");

            for (int i = 1; i < 10000; i++)
            {
                numero = 0;

                solA = i / 2;

                for (int j = 1; j <= solA; j++)
                {
                    solB = i % j;
                    if (solB == 0)
                        numero = numero + j;
                }

                if (numero == i)
                    Console.Write("\n {0} es numero perfecto.", i);
            }
            Console.ReadKey();
        }
    }
}
