using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Novela : Libro
    {

        #region Atributos

        public EGenero genero;

        #endregion

        #region Constructores

        public Novela (string titulo, float precio, Autor autor, EGenero genero) : base(titulo, autor, precio)
        {
            this.genero = genero;
        }

        #endregion

        #region Metodos

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine((string)this);
            sb.AppendFormat("Tipo: {0}", this.genero);

            return sb.ToString();
        }


        public static implicit operator double(Novela n)
        {
            return n._precio;
        }



        public static bool operator == (Novela a, Novela b)
        {
            bool retorno = false;

            if ((Libro)a == (Libro)b && a.genero == b.genero)
            {
                retorno = true;
            }

            return retorno;
        }


        public static bool operator != (Novela a, Novela b)
        {
            return !(a == b);
        }


        #endregion
    }
}
