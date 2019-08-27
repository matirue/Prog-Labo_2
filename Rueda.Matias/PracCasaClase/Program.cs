using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracCasaClase
{//acordate de q la clase y programa el mismo modificador, en este caso public ambos
    public class Program
    {
        static void Main(string[] args)
        {
            //Cargo elatibuto con hola
            MiClass.mensaje = "HOLA";

            //llamo a los metodos, primero nombre de clase luego el metodo

            Console.WriteLine("Imprimiendo:\n");

            MiClass.color = ConsoleColor.Red;
            MiClass.ImprimirEnColor();
            Console.WriteLine(MiClass.Imprimir());

            Console.WriteLine("\n\nImprimiendo en otro color:\n");
            MiClass.color = ConsoleColor.Green;
            MiClass.ImprimirEnColor();
            Console.WriteLine(MiClass.Imprimir());

            Console.WriteLine("\nBorrando:\n");
            MiClass.Borrar();
            Console.WriteLine(MiClass.mensaje);

            Console.WriteLine("\n\n---------FIN----------\n");

            Console.ReadKey();

        }
    }
}
