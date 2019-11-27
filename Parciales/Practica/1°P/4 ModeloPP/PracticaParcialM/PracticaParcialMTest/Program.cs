using System;
using PreParcial;

namespace PracticaParcialMTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro perroUno = new Perro("Moro", "Pitbull");
            Perro perroDos = new Perro("Julio", "Cruza", 13, false);
            Perro perroTres = new Perro("Ramón", "Salchicha", 2, true);
            Gato gatoUno = new Gato("José", "Angora");
            Gato gatoDos = new Gato("Hernán", "Cruza");
            Gato gatoTres = new Gato("Fer", "Siamés");
            Grupo grupoUno = new Grupo("Río", EtipoManada.Mixta);
            grupoUno += perroUno;
            grupoUno += perroDos;
            grupoUno += perroUno;
            grupoUno += perroTres;
            grupoUno += gatoUno;
            grupoUno += gatoDos;
            grupoUno += gatoTres;
            Console.WriteLine(grupoUno);
            grupoUno -= perroTres;
            grupoUno -= gatoTres;
            grupoUno -= gatoTres;
            Console.WriteLine(grupoUno);
            if (perroUno.Equals("perroUno"))
                Console.WriteLine("Son la misma mascota");
            else
                Console.WriteLine("No son la misma mascota");
            Console.ReadLine();
        }
    }
}
