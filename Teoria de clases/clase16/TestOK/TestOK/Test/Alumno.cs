using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad
{
    public class Alumno
    {
        private string _nombreCompleto;
        private string _legajo;

        public Alumno(string nombre, string legajo)
        {
            this._nombreCompleto = nombre;
            this._legajo = legajo;
        }

        public string NombreCompleto
        {
            get
            {
                return this._nombreCompleto;
            }
        }
        public string Legajo
        {
            get
            {
                return this._legajo;
            }
        }
    }
}
