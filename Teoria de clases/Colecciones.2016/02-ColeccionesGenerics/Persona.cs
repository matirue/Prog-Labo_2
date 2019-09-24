using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Personas
{
    class Persona
    {
        private string _nombre;
        private string _apellido;
        private long _dni;

        public Persona(string nombre, string apellido, long dni)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._dni = dni;
        }

        public void MostrarPersona()
        {
            Console.WriteLine("Nombre: {0}", this._nombre);
            Console.WriteLine("Apellido: {0}", this._apellido);
            Console.WriteLine("Dni: {0}", this._dni);
            Console.WriteLine();
        }
        public void Mostrar()
        {
            Console.WriteLine("Nombre: {0}", this._nombre);
            Console.WriteLine("Apellido: {0}", this._apellido);
            Console.WriteLine("Dni: {0}", this._dni);
            Console.WriteLine();
        }

    }
}
