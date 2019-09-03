using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EJ_13";

            string dato;
            double numero;
            int opc;

            do
            {
                Console.Write(" 1- Convertir decimal a binario.\n 2- Convertir binario a decimal.\n 3- Salir\n Operacion: ");
                //opc = int.Parse(Console.ReadLine());
                while (!(int.TryParse(Console.ReadLine(), out opc)))
                {
                    Console.WriteLine("\n ERROR. La opcion debe ser numerica");
                    Console.Write("Reingrese: ");
                }

                switch (opc)
                {
                    case 1:
                        Console.Write("Ingrese valor decimal: ");
                        dato = Console.ReadLine();

                        while (!double.TryParse(dato, out numero))
                        {
                            Console.WriteLine("ERROR. El vallor debe ser numerico.");
                            Console.Write("Reingrese: ");
                            dato = Console.ReadLine();
                        }

                        Console.WriteLine("\n--> Ingreso: " + numero + "\n--> Su binario: " + Conversor.DecimalBinario(numero) + "\n\n");
                        break;

                    case 2:
                        Console.Write("Ingrese valor binario: ");
                        dato = Console.ReadLine();

                        Console.WriteLine("\n--> Ingreso: " + dato + "\n--> Su decimal: " + Conversor.BinarioDecimal(dato) + "\n\n");
                        break;
                    case 3:
                        break;
                }
            } while (opc != 3);


            Console.ReadKey();
        }
    }
}
