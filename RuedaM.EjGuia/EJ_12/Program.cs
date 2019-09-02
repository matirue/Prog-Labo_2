using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EJ_12";

            int numero;
            int suma=0;
            char opcion;
            bool flag;

            Console.WriteLine("SUMADOR");
            Console.Write("Ingrese numero: ");

            flag = int.TryParse(Console.ReadLine(), out numero);
            while (flag == false)
            {
                Console.Write("\nError, numero invalido. Reingrese: ");
                flag = int.TryParse(Console.ReadLine(), out numero);
            }

            suma = suma + numero;

            do {
                Console.Write("\nIngrese otro numero: ");

                flag = int.TryParse(Console.ReadLine(), out numero);
                while (flag == false)
                {
                    Console.Write("\nError, numero invalido. Reingrese: ");
                    flag = int.TryParse(Console.ReadLine(), out numero);
                }

                suma = suma + numero;

                Console.Write("\nContinuar? (s/n): ");
                opcion = Console.ReadKey().KeyChar;
            } while (ValidarRespuesta.ValidaS_N(opcion));

            Console.WriteLine("\n La suma es: {0}", suma);

            Console.ReadKey();
        }
    }
}
