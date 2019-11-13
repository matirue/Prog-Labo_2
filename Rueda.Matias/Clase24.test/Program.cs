using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades.Clase24;

namespace Clase24.test
{
    public class Program
    {
        static void Main(string[] args)
        {
            Empleado e1 = new Empleado("Juan", "Perez", 123);
            Empleado e2 = new Empleado("aaaa", "ssss", 321);

            Console.WriteLine(e1.ToString()); 

            e1.limiteSueldo += new LimiteSueldoDelegado(MostarDelegado);
            e1.Sueldo = 28000;
            //MostarDelegado(e1.Sueldo, e1);

           
            e2.limiteSueldoMejor += new LimiteSueldoMejoradoDel(MostrarSegDelegado);
            e2.Sueldo = 50000;




            void MostarDelegado(double sueldo, Empleado emp)
            {
                Console.WriteLine(emp.ToString() + " -> se cargo: $" + sueldo);
            }

            void MostrarSegDelegado(Empleado emp, EmpleadoEventArgs e)
            {
                Console.WriteLine(emp.ToString() + " -> sueldo: $" + e.SueldoAsignado);
            }
            Console.ReadKey();
        }

        
    }
}
