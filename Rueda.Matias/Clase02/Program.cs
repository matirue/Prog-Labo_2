using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MiLibreria;
using Clase02.Entidades;

namespace Clase02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 02";
            Console.WriteLine("EDAD SIN CARGAR:");
            Miclase.MostrarEdad();
            Console.WriteLine("\nEDAD CARGADA");
            Miclase.edad = 26;
            Miclase.MostrarEdad();

            Console.WriteLine("\n--------------------------------");

            Console.WriteLine("\nNombre cargado en Miclase:");
            Miclase.MostrarNombre();

            Console.WriteLine("\n--------------------------------");

            Console.WriteLine("\nNombre cargado en miClase:");
            Console.WriteLine(Miclase.nombre);
            Console.WriteLine("\nCambiando nombre:");
            Miclase.nombre = "Mauro";
            Console.WriteLine(Miclase.nombre);

            Console.WriteLine("\n--------------------------------");

            Console.WriteLine("\nCargando en MiLibreria:");
            MiLibreria.MiClase.nombre = "MATIAS";
            Console.WriteLine(MiLibreria.MiClase.Mostrarombre());

            Console.WriteLine("\n--------------------------------");

            Sello.mensaje = "HOLAAAAAAAAAAAA";
            Sello.Imprimir();
            Sello.Borrar();

            Sello.mensaje = "AHORA SOY ROJO";
            Sello.color = ConsoleColor.Red;
            Sello.ImprimirEnColor();

            Sello.mensaje = "HOLA2";
            Sello.Imprimir();

            Console.ReadKey();

        }
    }
}
