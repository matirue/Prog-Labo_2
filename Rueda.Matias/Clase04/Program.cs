using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//clase pasada como referencia
using Clase04.Entidades;

namespace Clase04
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa cosa1 = new Cosa();

            cosa1.EstablecerValor("HOLA...");
            cosa1.EstablecerValor(DateTime.Now);
            cosa1.EstablecerValor(1234);

            Console.WriteLine("Usando Sobrecarga de metodos:\n\n" + cosa1.Mostrar());

            Console.WriteLine("--------------------------------------------------------------------\n");

            Cosa cosa2= new Cosa();
            Cosa cosa3 = new Cosa("aaaaa");
            Cosa cosa4 = new Cosa("sssss",DateTime.Now);
            Cosa cosa5 = new Cosa("ddddd",new DateTime(1993,4,12),9999);

            Console.WriteLine("Usando Constructores:\n\n" + cosa2.Mostrar() + "\n" + cosa3.Mostrar() + "\n" + cosa4.Mostrar() + "\n" + cosa5.Mostrar() + "\n"); ;

            Console.ReadKey();
        }
    }
}
