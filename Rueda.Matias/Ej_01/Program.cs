using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ej 01";

            //string nombre = "Matias";
            //string apellido = "Rueda";
            //int edad = 26;
            //string dato;

            //Console.ForegroundColor = ConsoleColor.Red;
            ////Console.BackgroundColor = ConsoleColor.Red;

            //Console.WriteLine("Hola mundo C# \n");

            //Console.WriteLine("{0} {1} - {2}\n",nombre, apellido, edad);

            //Console.Write("\nIngrese algo: ");
            //dato = Console.ReadLine();
            //Console.WriteLine("\n\nIngreso: {0}\n", dato);

            int numero;

            int max=0;
            int min=0;
            int acumulador=0;
            float promedio;
            int i;
            for ( i = 0; i < 5; i++)
            // for (int i = 0; i < 5; i++)
            {
                Console.Write("\nIngrese un numero: ");
                numero = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    max = numero;
                    min = numero;
                }
                
                if (numero < min)
                {
                    min = numero;
                }

                if (numero > max)
                {
                    max = numero;
                }

                acumulador = acumulador + numero;

            }

            //promedio = acumulador / 5;
            promedio = (Single) acumulador / i;

            Console.WriteLine("\n\n\n Maxmo: {0} \n Minimo: {1} \n Promedio: {2}", max, min, promedio);

 
            Console.ReadLine();           
        }
    }
}
