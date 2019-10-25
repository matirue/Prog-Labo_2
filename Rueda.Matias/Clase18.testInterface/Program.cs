using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Clase18.EntidadesInterfaces;

namespace Clase18.testInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Aviones

            Avion av1 = new Avion(11111, 1234);
            Avion av2 = new Avion(4444, 2233);
            Privado avP = new Privado(222222, 4567, 10);
            Comercial avC = new Comercial(333333, 4321, 20);
            Console.WriteLine("Aviones:");
            Console.WriteLine("\n+Impuestos nacionales de:");
            Console.WriteLine("  ->Avion: "+ (Gestion.MostrarImpuestoNacional(av1)));
            Console.WriteLine("  ->Avion Privado : " + (Gestion.MostrarImpuestoNacional(avP)));
            Console.WriteLine("  ->Avion Comercial: " + (Gestion.MostrarImpuestoNacional(avC)));
            Console.WriteLine("\n+Impuesto provinciales de:");
            Console.WriteLine("  ->Avion: " + (Gestion.MostrarImpuestoNacional(av2)));
            #endregion

            #region Autos

            Console.WriteLine("\n\nAutos:");
            Deportivo auDep = new Deportivo(123, "asd-123", 111);
            Deportivo auDep2 = new Deportivo(987, "vbn-432", 333);
            Console.WriteLine("\n+Impuestos nacionales de:");
            Console.WriteLine("  ->Auto deportivo : " + (Gestion.MostrarImpuestoNacional(auDep)));
            Console.WriteLine("\n+Impuesto provinciales de:");
            Console.WriteLine("  ->Auto deportivo : " + (Gestion.MostrarImpuestoNacional(auDep2)));
            #endregion

            #region Carreta

            Console.WriteLine("\n\nCarreta:");
            Carreta c1 = new Carreta(999);
            Console.WriteLine("\n+Impuesto provinciales de:");
            Console.WriteLine("  ->Carreta : " + (Gestion.MostrarImpuestoProvincial(c1)));
            #endregion

            Console.ReadKey();
        }
    }
}
