using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrograma02
{
    //acordate de que la clase y programa deben tener el mismo modificador en este caso publico ambos
    public class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "Hola";//le cargo al atributo

            



            //llamo a los metodos primero nombre de clase luego el metodo

            //Sello.ImprimirEnColor();//cambio de color
            Console.WriteLine("Imprimiendo\n");

            

            Sello.color = ConsoleColor.Red;
            Sello.ImprimirEnColor();
            Console.WriteLine(Sello.Imprimir());
            Console.WriteLine("\n\n");
            Sello.color = ConsoleColor.Gray;
            Sello.ImprimirEnColor();
            Console.WriteLine(Sello.Imprimir());
            //Console.WriteLine(Sello.mensaje);//retorna el lçvalor del atributo

            
            

            Console.WriteLine("\nBorrando\n");

            Sello.Borrar();
            Console.WriteLine(Sello.mensaje);

            Console.WriteLine("\n------------Fin-----------\n");

            Console.ReadKey();
        }
    }
}
