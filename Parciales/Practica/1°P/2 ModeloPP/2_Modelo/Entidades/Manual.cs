using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Manual : Libro
    {

        #region Atributos
        public ETipo tipo;

        #endregion;


        #region Constructores

        public Manual(string titulo, float precio, string nombre, string apellido, ETipo tipo) : base(precio, titulo, nombre, apellido)
        {
            this.tipo = tipo;
        }

        #endregion


        #region Metodos


        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(((string)this)); // REUTILIZO.

            sb.AppendFormat("TIPO: {0}", this.tipo);
            return sb.ToString();
        }


        public static implicit operator double (Manual m)
        {
            return m._precio;
        }


        public static bool operator == (Manual a, Manual b)
        {
            bool retorno = false;

            if (a.tipo == b.tipo)
            {
                retorno = true;
            }

            return retorno;
        }


        public static bool operator !=(Manual a, Manual b)
        {
            return !(a == b);
        }
        #endregion
    }
}
