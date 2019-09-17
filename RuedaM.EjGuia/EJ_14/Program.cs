using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EJ_14";

            int op;
            double solucion=0;

            Console.WriteLine("Calcular area de: \n   1-Cuadrado\n   2-Triangulo\n   3-Circulo ");

            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Write("\nLado del cuadrado: ");
                    solucion=CalculoDeArea.CalcularCuadrado(double.Parse(Console.ReadLine()));
                    
                    break;

                case 2:
                    Console.Write("\nBase del triangulo: ");
                    double b = double.Parse(Console.ReadLine());

                    Console.Write("\nAltura del triangulo: ");
                    double h = double.Parse(Console.ReadLine());

                    solucion = CalculoDeArea.CalcularTriangulo(b, h);
                    break;

                case 3:
                    Console.Write("\nRadio del circulo: ");
                    double c = double.Parse(Console.ReadLine());

                    solucion = CalculoDeArea.CalcularCirculo(c);
                    break;
                default:
                    break;
            }

            Console.Write("\n------> El area es de: {0}",solucion);

            Console.ReadKey();
        }
    }
}
