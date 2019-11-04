using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ej_27";

            Random numeroRandom = new Random();

            #region List<>
            Console.WriteLine("\nLista de tipo List<>: ");
            List<int> miLista = new List<int>();

            for(int i = 0; i < 20; i++)
            {
                miLista.Add(numeroRandom.Next(-100, 100));
            }

            Console.WriteLine("\n->Lista de numeros cargados: ");
            foreach (int x in miLista)
            {
                Console.Write(" {0} //", x);
            }
            Console.WriteLine("\n\n ->Numeros positivos: ");
            for(int i = 0; i < 20; i++)
            {
                if (miLista[i] > 0)
                    Console.Write(" {0} //", miLista[i]);
            }
            Console.WriteLine("\n\n ->Numeros negativos: ");
            for (int i = 0; i < 20; i++)
            {
                if (miLista[i] < 0)
                    Console.Write(" {0} //", miLista[i]);
            }

            #endregion

            Console.ReadKey();
            Console.WriteLine("\n\n---------------------------------------------------------");
            #region Pila
            Console.WriteLine("\n\nLista de tipo Stack: ");
            Stack<int> miPila = new Stack<int>();

            for(int i = 0; i < 20; i++)
            {
                miPila.Push(numeroRandom.Next(-100, 100));
            }
            
            Console.WriteLine("\n Lista de numeros cargados: ");
            foreach(int x in miPila)
            {
                Console.Write(" {0} //", x);
            }
            Console.WriteLine("\n\n Numeros positivos: ");
            foreach(int x in miPila)
            {
                if (x > 0)
                    Console.Write(" {0} //", x);
            }
            Console.WriteLine("\n\n Numeros negativos: ");
            foreach (int x in miPila)
            {
                if (x < 0)
                    Console.Write(" {0} //", x);
            }
            #endregion

            Console.ReadKey();
            Console.WriteLine("\n\n---------------------------------------------------------");
            #region Cola
            Console.WriteLine("\n\nLista de tipo Cola: ");
            Queue<int> cola = new Queue<int>();
            for(int i = 0; i < 20; i++)
            {
                cola.Enqueue(numeroRandom.Next(-100, 100));
            }
            Console.WriteLine("\n\n Lista de numeros cargados: ");
            foreach(int x in cola)
            {
                Console.Write(" {0} //", x);
            }
            Console.WriteLine("\n\n Numeros positivos: ");
            foreach (int x in cola)
            {
                if (x > 0)
                    Console.Write(" {0} //", x);
            }
            Console.WriteLine("\n\n Numeros negativos: ");
            foreach (int x in cola)
            {
                if (x < 0)
                    Console.Write(" {0} //", x);
            }
            #endregion
            Console.ReadKey();
        }
    }
}
