using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Eventos
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto miAuto = new Auto("Renault");

            miAuto.ReservaCombustible += ManejadorReserva;
            miAuto.SinCombustible += ManejadorEmpty;

            Console.Write(miAuto.ToString());

            Console.WriteLine("Viaje 1: 230 Km");

            miAuto.ConducirMejorado(230);

            Console.Write(miAuto.ToString());

            Console.WriteLine("Viaje 2 300 Km");

            miAuto.ConducirMejorado(300);

            Console.Write(miAuto.ToString());

            Console.WriteLine("Viaje 3 100 Km");

            miAuto.ConducirMejorado(100);

            Console.Write(miAuto.ToString());

            Console.WriteLine("Presione <enter> para cerrar.");
            Console.ReadKey();
        }

        static void ManejadorReserva(object sender, AutoEventArgs e)
        {
            String llenar;

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Soy el " + ((Auto)sender).Marca + " y estoy con la reserva, solo quedan {0} litros de combustible.", e.CombustibleEnElTanque);

            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Desea Llenar el tanque? S/N: ");

            Console.ForegroundColor = ConsoleColor.Gray;
            llenar = Console.ReadLine();
            Console.WriteLine();

            if (String.Compare(llenar, "s") == 0)
            {
                ((Auto)sender).LlenarTanque();

            }

        }

        static void ManejadorEmpty(object sender, AutoEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Soy el " + ((Auto)sender).Marca + " y me quede sin combustible.");

            Console.ForegroundColor = ConsoleColor.Gray;
        }


    }

    
}
