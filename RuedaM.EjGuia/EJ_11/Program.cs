using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EJ_11";

            int numero;
            int max = 0;
            int min = 0;
            float promedio;
            int acumulado=0;

            bool flag = false;

            for(int i = 0; i < 10; i++)
            {
                Console.Write("\n{0}-Ingrese numero: ", i+1);

                //numero = int.Parse(Console.ReadLine());
                flag = int.TryParse(Console.ReadLine(), out numero);

                //while (Validacion.Validar(numero, -100, 100) == false)
                //{
                //    Console.Write("\nError, numero invalido. Reingrese: ");
                //    numero = int.Parse(Console.ReadLine());
                //}
                while (flag == false || Validacion.Validar(numero, -100, 100) == false)
                {
                    Console.Write("\nError, numero invalido. Reingrese: ");
                    flag = int.TryParse(Console.ReadLine(), out numero);
                }

                if (i == 0)
                {
                    max = numero;
                    min = numero;
                }

                if (numero > max)
                {
                    max = numero;
                }
                else if (numero < min)
                {
                    min = numero;
                }

                acumulado = acumulado + numero;
            }

            promedio = (Single)acumulado / 10;

            Console.WriteLine("\n\n MAXIMO: {0} \n MINIMO: {1} \n PROMEDIO: {2}", max, min, promedio);

            Console.ReadKey();
        }
    }
}
