using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace RPP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Emisor> emisores = new List<Emisor>();
            Emisor emisorEmail = new EmisorDeEmails("Licencia por caducar", EProducto.AppHosting, "pepito@pepe.pepe"); 
            emisores.Add(emisorEmail);
        
            emisores.Add(new EmisorDeEmails("3 meses gratis de servicio de monitoreo.", EProducto.MonitoringApp, "pepito@pepe.pepe"));

            EmisorDeWhatsapp emisorWhatsapp = new EmisorDeWhatsapp("Usted ha adquirido servicio de Azure SQL Base de Datos", EProducto.SQLDatabase);
            emisores.Add(emisorWhatsapp);

            Console.ForegroundColor = ConsoleColor.Yellow; ManejadorDeEmisores manejador = new ManejadorDeEmisores("West Us");

            foreach (Emisor emisor in emisores) { if (manejador + emisor) Console.WriteLine("Emisor agregado.");
            else Console.WriteLine("No se pudo agregar emisor."); }

            Console.ForegroundColor = ConsoleColor.Red; if (manejador + emisorEmail) Console.WriteLine("Se agregó el emisor."); else Console.WriteLine("No se agregó al emisor.");

            if (manejador - emisorEmail) Console.WriteLine("Se eliminó emisor."); else Console.WriteLine("No se eliminó emisor.");

            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine(manejador.EnviarMensajes()); emisorWhatsapp.NumeroTelefono = 1514134118;

            Console.ForegroundColor = ConsoleColor.DarkGreen; Console.WriteLine(manejador.EnviarMensajes()); Console.ReadKey();


        }
    }
}
