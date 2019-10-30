using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase19.Entidades
{
    public class Alumno:Persona
    {
        #region Atributo
        public double nota;
        #endregion

        #region Constructor
        public Alumno():base()
        {
        }
        public Alumno(string nombre, string apellido, int edad, double nota) 
            : base(nombre, apellido, edad)
        {
            this.nota = nota;
        }
        #endregion 

        public override string ToString()
        {
            return base.ToString() + " Nota: " + this.nota;
        }
    }
}
