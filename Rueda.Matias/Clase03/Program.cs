using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona miPersona = new Persona(); //primera instancia

            miPersona.nombre = "Matias";
            miPersona.apellido = "Rueda";
            miPersona.dni = 123456789;

            Console.WriteLine(miPersona.Mostrar());

            Persona persona2 = new Persona(); // segunda instancia
            persona2.nombre = "Maria";
            persona2.apellido = "Tupone";
            persona2.dni = 987654321;

            Console.WriteLine(persona2.Mostrar());

            Persona persona3 = new Persona("asd","qwe",35667234);  //pasando datos al const
            Console.WriteLine(persona3.Mostrar());

            Console.ReadKey();
        }
    }
}
