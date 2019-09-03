using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_05
{
    class Ej_05
    {
        static void Main(string[] args)
        {
            Console.Title = "Ej_05";
            Console.Write("Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en dos grupos de números, cuyas sumas son iguales. El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8) cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595. Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola.\n\n");

            //int numero;
            double numero, sumaAnterior, sumaPosterior, aumento=1;

            Console.Write("Ingrese numero limite a buscar: ");
            //pido el dato
            numero = double.Parse(Console.ReadLine());

            while (aumento < numero)
            {
                aumento++;
                sumaAnterior = 0;
                sumaPosterior = 0;

                //bucle que suma el bloque anterior a mi numero centro
                for(double i = 1; i < aumento; i++)
                {
                    sumaAnterior = sumaAnterior + i;
                }

                //bucle que suma el bloque posterior a mi numero centro
                for(double j = aumento + 1; j <= sumaAnterior; j++)
                {
                    //si las sumas de cada bloque son iguales o posterior es mayor a anteriror rompro bucle para que 
                    //siga buscando al siguiente numero centro
                    if( (sumaPosterior==sumaAnterior) || (sumaPosterior>sumaAnterior))
                    {
                        break;
                    }

                    sumaPosterior = sumaPosterior + j;
                }

                if (sumaAnterior == sumaPosterior)
                {
                    Console.WriteLine("\nDel numero ingresado {0} - {1} es centro numerico. ",numero,aumento);
                }

            }


            Console.ReadKey();
        }
    }
}
