using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_01
{
    class Ej_01
    {
        static void Main(string[] args)
        {
            Console.Title = "Ej_01";
            Console.WriteLine("Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.\n\n");

            int num, max=0, min=0, acumulador=0;

            float promedio=0;

            Console.Write("Ingrese 5 numeros: ");

            for (int i=0; i < 5; i++)
            {
                num=int.Parse( Console.ReadLine() );

                if (i == 0)
                {
                    max = num;
                    min = num;
                }

                acumulador += num;

                if (num > max)
                {
                    max = num;
                }
                else if(num<min)
                {
                    min = num;
                }

                
            }

            promedio = (float)(acumulador / 5.0);

            
            Console.WriteLine("\nMaximo: {0}", max);
            Console.WriteLine("\nMinimo: {0}", min);
            Console.WriteLine("\nPromedio: {0:#,###.00}", promedio);
            

            Console.ReadKey();
        }
    }
}
