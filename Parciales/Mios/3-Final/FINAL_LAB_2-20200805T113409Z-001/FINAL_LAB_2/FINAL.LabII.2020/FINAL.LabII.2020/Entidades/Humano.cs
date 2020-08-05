using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Humano (nombre:string;  idioma:EIdioma;) - ToString():string
    //Todos los atributos de las clases son públicos y además:
    //que todas las clases poseen un sólo constructor (sin sobrecargas).
    public class Humano
    {
        public string nombre;
        public EIdioma idioma;

        public Humano() { }
        public Humano(string nombre, EIdioma idioma)
        {
            this.nombre = nombre;
            this.idioma = idioma;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nNombre:  " + this.nombre + "\nIdioma: " + this.idioma.ToString());
            return sb.ToString();
        }
    }
}
