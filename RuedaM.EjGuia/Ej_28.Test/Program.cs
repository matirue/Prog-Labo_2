using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ej_29.Entidades;

namespace Ej_29.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo e1 = new Equipo(2, "equipo");
            Jugador j1 = new Jugador(1111, "aaa", 5, 2);
            Jugador j2 = new Jugador(2222, "sss", 7, 16);
            Jugador j3 = new Jugador(1111, "ccc", 0, 3);

            if (e1 + j1 && e1 + j2)
            {
                Console.WriteLine(e1.Mostrar());
            }
            else
            {
                Console.WriteLine("No se pudo cargar.");
            }



            Console.ReadKey();
        }
    }
}
