using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Partiendo de la base del ejercicio anterior, se pide realizar un programa que imprima 
//por pantalla una pirámide como la siguiente:
//                *
//               **
//              **** 
//             ***** 
//            ****** 
//           *******
//Nota: Utilizar estructuras repetitivas y selectivas.

namespace Ej_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ej_10";

            int altura;

            Console.Write("Ingrese la altura de la piramide: ");
            altura = int.Parse(Console.ReadLine());

            for(int i = 1; i <= altura; i++)
            {
                for(int j = 0; j < (altura - i); j++)
                {
                    Console.Write(" ");
                }
                for(int k = 0; k < (i * 2) - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
