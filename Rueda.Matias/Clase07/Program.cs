using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Clase07.Entidades_coleccion;

namespace Clase07
{
    class Program
    {
        static void Main(string[] args)
        {
            Capitulo c1 = "primer capitulo";
            Capitulo c2 = "segundo capitulo";
            Capitulo c3 = "tercero capitulo";
            Console.Write(" NUMERO - TITULO - PAGINAS - OBJETO");
            Console.Write("\n {0} - {1} - {2} - C1", c1.Numero, c1.Titulo, c1.Paginas);
            Console.Write("\n {0} - {1} - {2} - C2", c2.Numero, c2.Titulo, c2.Paginas);
            Console.Write("\n {0} - {1} - {2} - C3", c3.Numero, c3.Titulo, c3.Paginas);

            Console.WriteLine("\n\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n\n");

            Libro miLibro = new Libro("C# al descubierto", "Joe Mayo");

            miLibro[0] = "Fundamentos Básicos de C#";
            miLibro[1] = "Cómo comenzar con C#";
            miLibro[2] = "Cómo escribir expresiones con C#";

            miLibro[-1] = "Genero un índice erroneo";

            miLibro[5] = "Genero otro índice erroneo";





            Console.WriteLine("\n Libro:");

            Console.WriteLine("\n Titulo: {0}", miLibro.Titulo);

            Console.WriteLine("\n Autor: {0}", miLibro.Autor);

            Console.WriteLine("\n Cantidad de páginas: {0}", miLibro.CantidadPaginas);



            for (int i = 0; i < miLibro.CantidadCapitulos; i++)

            {

                Console.WriteLine("\n\n--> Capitulo {0}: {1} {2}", miLibro[i].Numero, miLibro[i].Titulo, miLibro[i].Paginas);

            }
                                  

            Console.ReadKey();
        }
    }
}
