using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="EJ_15";

            double n1;
            double n2;
            double solucion = 0;
            int op;
            char seguir=' ';
            bool flag=false;

            


            do
            {
                Console.Clear();

                Console.Write("Primer numero: ");
                while (!(double.TryParse(Console.ReadLine(), out n1)))
                {
                    Console.Write("\n Dato invalido. Reingrese: ");
                }

                Console.Write("\n\nSegundo numero: ");
                while (!(double.TryParse(Console.ReadLine(), out n2)))
                {
                    Console.Write("\n Dato invalido. Reingrese: ");
                }

                Console.Write("\n\n Operacion:\n  1-Sumar\n  2-Restar\n  3-Multiplicar\n  4-Dividir\nEsperando: ");


                do
                {
                    flag = int.TryParse(Console.ReadLine(), out op);
                    while (flag == false)
                    {
                        Console.Write("\n Dato invalido. Reingrese: ");
                        flag = int.TryParse(Console.ReadLine(), out op);
                    }
                    if (flag == true)
                    {
                        if (op != 1 && op != 2 && op != 3 && op != 4)
                        {
                            flag = false;
                            Console.Write("\n Dato invalido. Reingrese: ");
                            flag = int.TryParse(Console.ReadLine(), out op);
                        }
                    }

                } while (flag == false);


                solucion = Calculadora.Calcular(n1, n2, op);
                Console.Write("\n---->Solucion: {0}", solucion);

                Console.Write("\n\n Continuar? (s/n): ");
                seguir = Console.ReadKey().KeyChar;

            } while (seguir == 's' || seguir == 'S');

            Console.Write("\n\n   OK.. ");

            Console.ReadKey();
        }
    }
}
