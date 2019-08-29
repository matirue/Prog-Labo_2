using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EJ_16";

            Alumno a1 = new Alumno("Matias", "Rueda", 100);
            a1.Estudiar(6, 6);
            a1.CalcularFinal();

            Alumno a2 = new Alumno("aaa", "bbb", 101);
            a2.Estudiar(2, 3);
            a2.CalcularFinal();

            Alumno a3 = new Alumno("ddd", "eeee", 102);
            a3.Estudiar(4, 10);
            a3.CalcularFinal();

            Alumno a4 = new Alumno("fff", "kkkk", 103);
            a4.Estudiar(9, 2);
            a4.CalcularFinal();

            //Console.WriteLine("Legajo    Apellido   Nombre   Nota 1 - Nota 2 - Nota Final");
            Console.Write(a1.Mostrar());
            Console.Write(a2.Mostrar());
            Console.Write(a3.Mostrar());
            Console.Write(a4.Mostrar());


            Console.ReadKey();
        }
    }
}
