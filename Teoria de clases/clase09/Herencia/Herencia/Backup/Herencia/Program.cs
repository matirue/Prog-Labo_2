using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseDerivada clase = new ClaseDerivada(1);

            clase.nombre = "Juan";
            Console.WriteLine(clase.Id);

            ClaseError error = new ClaseError();

            error.Compila();
            error.Falla(new ClaseBase(1));

            Console.ReadLine();

        }
    }
}
