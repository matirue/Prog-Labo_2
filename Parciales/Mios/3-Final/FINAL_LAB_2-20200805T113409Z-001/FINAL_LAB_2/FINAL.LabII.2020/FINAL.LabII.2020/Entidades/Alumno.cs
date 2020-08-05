using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Alumno (legajo: Short; nivel: ENivelDeEstudio) - ToString():string (polimorfismo; reutilizar código)
    //Todos los atributos de las clases son públicos y además:
    //que todas las clases poseen un sólo constructor (sin sobrecargas).
    public class Alumno:Persona
    {
        public short legajo;
        public ENivelDeEstudio nivel;

        //(p, 123, ENivelDeEstudio.Primaria);
        public Alumno():base() { }
        public Alumno(Persona p, short legajo, ENivelDeEstudio nivel)
            :base(p.nombre, p.apellido, p.idioma, p.edad)
        {
            this.legajo = legajo;
            this.nivel = nivel;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.ToString());
            sb.AppendFormat("\nLegajo: " + this.legajo + "\nNivel de Estudio: " + this.nivel.ToString());
            return sb.ToString();
        }
    }
}
