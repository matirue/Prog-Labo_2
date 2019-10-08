using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CentralitaHerencia;

namespace CentralitaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita central = new Centralita("Telecom");

            Local l1 = new Local("Lomas de Zamora", 30.3F, "Turdera", 5.25F);
            Provincial p1 = new Provincial("BsAs", (EFranja)0, 15.2F, "Cordoba");

            Local l2 = new Local("Llavallol", 12.3F, "Temperley", 2.75F);
            Provincial p2 = new Provincial("Mendoza", (EFranja)1, 7.2F, "Tucuman");

            Provincial p3 = new Provincial((EFranja)2, l2);

            //agrego de a uno
            central += l1;
            Console.WriteLine(" \n Llamada agregada: "+central.ToString());
            Console.ReadKey();
            central += l2;
            Console.WriteLine(" \n Segunda llamada agregada: "+central.ToString());
            Console.ReadKey();
            central += p1;
            Console.WriteLine(" \n Sumando una provincial: "+central.ToString());
            Console.ReadKey();

            Console.WriteLine(" \n Inteto agregra de nuevo la l1 " );
            central += l1;
            Console.ReadKey();

            Console.WriteLine(" \n\n Lista: "+central.ToString());
            Console.ReadKey();

            Console.WriteLine(" \n\n Ordenando ");
            Console.ReadKey();
            central.OrdenarLLamadas();
            Console.WriteLine(" \n\n Lista ordenada: " + central.ToString());
            Console.ReadKey();

            Console.WriteLine(" \n\n Ganancias: ");
            Console.WriteLine(" Local: " + central.CalcularGanancia((ETipoLlamada)0));
            Console.WriteLine(" Provincial: " + central.CalcularGanancia((ETipoLlamada)1));
            Console.WriteLine(" Total: " + central.CalcularGanancia((ETipoLlamada)2));

            Console.WriteLine("\n\n\n +++++ FIN +++++++");
            Console.ReadKey();
        }
    }
}
