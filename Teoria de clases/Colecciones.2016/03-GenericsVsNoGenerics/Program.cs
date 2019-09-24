using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personas;

namespace _03_GenericsVsNoGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************");
            Console.WriteLine("**Generics vs. No Generics****");
            Console.WriteLine("******************************");
            Console.ReadLine();

            Console.WriteLine("Creo una Pila no genérica.");
            Console.WriteLine("System.Collections.Stack pilaNoGenerica = new System.Collections.Stack();");

            Console.ReadLine();
            Console.Clear();

            //DECLARO E INSTANCIO UNA PILA NO GENERICA
            System.Collections.Stack pilaNoGenerica = new System.Collections.Stack();

            Console.WriteLine("Agrego valores a la pila de distintos tipos.");

            Console.ReadLine();

            pilaNoGenerica.Push(3);
            pilaNoGenerica.Push("Valor de tipo String");
            pilaNoGenerica.Push(new Personas.Persona("Alfredo", "Lopez", 22555999));

            Console.WriteLine("Desapilo con el método Pop().");
            Console.ReadLine();

            int cant = pilaNoGenerica.Count;

            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine("Elementos en la pila no genérica {0}",
                                    pilaNoGenerica.Pop());
            }

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Agrego valores a la pila de tipo 'Persona'.");
            Console.WriteLine("Pero me equivoco e ingreso un elemento de otro tipo...");

            Console.ReadLine();

            pilaNoGenerica.Push(new Personas.Persona("Brian", "Jimenez", 23000666));
            pilaNoGenerica.Push("Valor de tipo String");
            pilaNoGenerica.Push(new Personas.Persona("Alfredo", "Lopez", 22555999));

            Console.WriteLine("Recorro con un for each y utilizo el método MostrarPersonas().");
            Console.ReadLine();

            foreach (Personas.Persona item in pilaNoGenerica)
            {
                item.MostrarPersona();
            }

            Console.WriteLine("Se produce un error en tiempo de ejecución.");

            Console.ReadLine();
            Console.Clear();



            Console.WriteLine("Creo una Pila genérica.");
            Console.WriteLine("System.Collections.Generic.Stack<Personas.Persona> pilaGenerica");

            Console.ReadLine();
            //DECLARO UN PILA GENERICA DE TIPO PERSONA
            System.Collections.Generic.Stack<Personas.Persona> pilaGenerica;

            //INSTANCIO LA PILA GENERICA DE TIPO PERSONA
            pilaGenerica = new System.Collections.Generic.Stack<Personas.Persona>();


            Console.WriteLine("Agrego valores a la pila de tipo 'Persona'.");
            Console.WriteLine("Pero me equivoco e ingreso un elemento de otro tipo...");

            Console.ReadLine();


            pilaGenerica.Push(new Personas.Persona("Adrian", "Gonzalez", 32885410));

            //pilaGenerica.Push("Adrian Gonzalez");

            pilaGenerica.Push(new Personas.Persona("Marta", "Lopez", 18542330));

            Console.WriteLine("Se produce un error en tiempo de compilación.");

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Recorro con un for each y utilizo el método MostrarPersonas().");
            Console.ReadLine();

            foreach (Personas.Persona item in pilaGenerica)
            {
                item.MostrarPersona();
            }

            Console.ReadLine();

        }
    }
}
