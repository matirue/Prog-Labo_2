using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personas;

namespace _02_ColeccionesGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.MostrarColeccionesGenerics();
        }

        #region Colecciones Generics

        private static void MostrarColeccionesGenerics()
        {
            Console.Clear();
            Console.WriteLine("******************************");
            Console.WriteLine("**********Generis*************");
            Console.WriteLine("******************************");
            Console.ReadLine();


            Console.WriteLine("******************************");
            Console.WriteLine("*********Dictionary***********");
            Console.WriteLine("******************************");
            Console.ReadLine();

            //DECLARO UNA COLECCION GENERICA DE TIPO CLAVE-VALOR
            Dictionary<int, Persona> diccionario = new Dictionary<int, Persona>();

            Console.WriteLine("Creo mi diccionario con los tipos...");
            Console.WriteLine("Dictionary<int, Persona> diccionario");

            Console.ReadLine();
            Console.Clear();

            //DECLARO E INSTANCIO UNA PERSONA
            Persona personita = new Persona("Roberto", "Sanchez", 22777666);

            diccionario.Add(1, new Persona("Juan", "Perez", 20999888));
            diccionario.Add(2, personita);
            diccionario.Add(3, new Persona("Rosa", "Gutierrez", 20555444));
            diccionario.Add(4, new Persona("Elvira", "Torres", 22333222));

            Console.WriteLine("Agrego con diccionario.Add()");
            Console.WriteLine("Recorro la colección con un for.");
            Console.ReadLine();

            Console.WriteLine("Cantidad de elementos en la colección {0}.",
                                diccionario.Count);

            Console.ReadLine();

            for (int i = 1; i <= diccionario.Count; i++)
            {
                diccionario[i].MostrarPersona();
            }


            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("******************************");
            Console.WriteLine("******Listas Genéricas********");
            Console.WriteLine("******************************");
            Console.ReadLine();

            //DECLARO E INSTANCIO UNA LISTA GENERICA DE PERSONA
            List<Persona> lista = new List<Persona>();

            Console.WriteLine("Creo mi lista de tipo...");
            Console.WriteLine("List<Persona> lista ");

            Console.ReadLine();
            Console.Clear();

            lista.Add(new Persona("Juan", "Perez", 20999888));
            lista.Add(personita);
            lista.Add(new Persona("Rosa", "Gutierrez", 20555444));

            Console.WriteLine("Agrego con lista.Add()");
            Console.WriteLine("Recorro la colección con un for each.");
            Console.ReadLine();

            Console.WriteLine("Cantidad de elementos en la colección {0}.",
                                lista.Count);

            Console.ReadLine();

            foreach (Persona elemento in lista)
            {
                elemento.MostrarPersona();
            }


            Console.ReadLine();

        }
        #endregion

    }
}
