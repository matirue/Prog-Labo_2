using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a1 = new Alumno(123, "Juan", "Perez");
            Alumno a2 = new Alumno(456, "Alberto", "Samid");
            Alumno a3 = new Alumno(789, "Patricia", "Bulrricho");
            Alumno a4 = a1;
            Alumno a5 = new Alumno(951, "María", "Gonzalez");

            Materia m1 = EMateria.Programacion_I;
            Materia m2 = EMateria.Laboratorio_II;
            m1 += a1;
            m1 += a2;
            m1 += a3;
            m1 += a4;
            m2 += a2;
            m2 += a3;
            m2 += a5;
            Console.WriteLine();
            m1 -= a3;
            m2 -= a4;
            m1.CalificarAlumnos();
            m2.CalificarAlumnos();
            Console.WriteLine((string)m1);
            Console.WriteLine("Promedio gral. : {0:#,###.00}", (float)m1);
            Console.WriteLine((string)m2);
            Console.WriteLine("Promedio gral. : {0:#,###.00}", (float)m2);

            Console.ReadLine();
        }
    }
}
