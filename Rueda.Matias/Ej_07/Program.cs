using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ej_07";

            //variables de tipo tiempo

            DateTime fNacimiento;
            DateTime fHoy;
            TimeSpan diasvividos;

            Console.WriteLine("Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) y calcule el número de días vividos por esa persona hasta la fecha actual (tomar la fecha del sistema con DateTime.Now).\n\n");

            Console.WriteLine("\n---------------------------------------------\n");

            Console.WriteLine("Fecha de nacimiento (DD/MM/AAAA): ");

            fNacimiento = DateTime.Parse(Console.ReadLine());

            //valido que no ingrese fecha mayor a la actual
            while (fNacimiento > DateTime.Now)
            {
                Console.WriteLine(" ERROR... Reingrese dato: ");
                fNacimiento = DateTime.Parse(Console.ReadLine());
            }

            fHoy = DateTime.Now;

            diasvividos = fHoy - fNacimiento;

            Console.WriteLine("\n---------------------------------------------\n");
            Console.WriteLine("Fecha de nacimiento: {0:dd/MM/yyyy} \nFecha actual: {1:dd/MM/yyyy} \nDias vividos: {2} \n ", fNacimiento, fHoy, diasvividos.Days);
            Console.WriteLine("---------------------------------------------\n");
            Console.ReadKey();
        }
    }
}
