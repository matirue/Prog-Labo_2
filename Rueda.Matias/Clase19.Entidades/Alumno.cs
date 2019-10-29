using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase19.Entidades
{
    public class Alumno:Persona
    {
        public double nota;

        public Alumno() { }
        public Alumno(string nombre, string apellido, int edad, double nota) : base(nombre, apellido, edad)
        {
            this.nota = nota;
        }
    }
}
