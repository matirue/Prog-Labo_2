using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        public string nombre;
        public string apellido;
        public int edad;

        public Persona() { }

        public Persona(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public override string ToString()
        {
            return this.nombre  + " - " +  this.apellido + " - " + this.edad;
        }
    }
}
