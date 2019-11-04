using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ej_26";

            Random numeroRandom = new Random();

            int[] listaNumeros = new int[20];
            int[] listaPos = new int[20];
            int[] listaNeg = new int[20];
            
            int indice=0;

            Console.WriteLine(". . .Cargando numeros. . .");
            for (int i = 0; i < listaNumeros.Length; i++)
            {
                do
                {
                    listaNumeros[i] = numeroRandom.Next(-100, 100);
                } while (listaNumeros[i] == 0);
            }

            Console.WriteLine("\nNumeros cargados\n Lista de numeros cargados: ");

            foreach(int x in listaNumeros)
            {
                Console.Write(x+" - ");
            }

            Console.WriteLine("\n\n Numeros positivos: ");

            foreach(int x in listaNumeros)
            {
                if (x > 0)
                {
                    listaPos[indice] = x;
                    indice++;
                }
            }

            Comparison<int> compararPos=new Comparison<int>((num1, num2) => num2.CompareTo(num1));
            Array.Sort(listaPos, compararPos);

            foreach(int x in listaPos)
            {
                if (x == 0)
                    continue;
                Console.Write(x + " - ");
            }


            Console.WriteLine("\n\n Numeros negativos: ");

            foreach (int x in listaNumeros)
            {
                if (x < 0)
                {
                    listaNeg[indice] = x;
                    indice++;
                }
            }

            Comparison<int> compararNeg = new Comparison<int>((num1, num2) => num2.CompareTo(num2));
            Array.Sort(listaNeg, compararNeg);

            foreach (int x in listaNeg)
            {
                if (x == 0)
                    continue;
                Console.Write(x + " - ");
            }
            Console.ReadKey();
        }
    } 
}
