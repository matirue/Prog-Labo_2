using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Clase05.Entidades;

namespace Clase05
{
    class Program
    {
        static void Main(string[] args)
        { //hacer todas la combinaciones para mostrar

            Tinta tinta1 = new Tinta();
            string b = (string)tinta1;

            Pluma p = new Pluma();

            b = p;
            p += tinta1;

            Console.WriteLine(p);

            Console.ReadKey();
        }
    }
}
