using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03
{
    class Persona
    {
        public string nombre;
        public string apellido;
        public int dni;


        public string Mostrar()
        {
            return this.nombre + " " + this.apellido + " " + this.dni + "\n";
        }

        public Persona()
        {

        }

        public Persona (string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

    }
}
