using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EJ_16";

            Alumno a1 = new Alumno("tttt","bbb",123);
            Alumno a2 = new Alumno("sss","ddd",456);
            Alumno a3 = new Alumno("fff","ggg",789);

            a1.Estudiar(5, 7);
            a2.Estudiar(2, 9);
            a3.Estudiar(4, 4);

            Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(a1.Mostrar());
            Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(a2.Mostrar());
            Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(a3.Mostrar());

            Console.WriteLine("\n\n---->FIN");
            Console.ReadKey();

        }
    }
}
