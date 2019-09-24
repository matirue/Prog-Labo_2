using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_19
{
    class Sumador
    {
        #region Atributos
        private int _cantidadSuma;
        #endregion

        #region Metodos

        #region Constructor
        public Sumador():this(0) //inicializo en cero
        {

        }
        public Sumador(int cantidadSumas)
        {
            this._cantidadSuma = cantidadSumas;
        }
        #endregion

        #region Operadores
        public static long operator +(Sumador s1, Sumador s2)
        {
            return (long)s1._cantidadSuma + (long)s2._cantidadSuma;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            if (s1._cantidadSuma == s2._cantidadSuma)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion 

        public long Sumar (long a, long b)
        {
            this._cantidadSuma += 1;
            return a + b;
        }

        public string Sumar (string a, string b)
        {
            this._cantidadSuma += 1;
            return a + b +"\n";
        }

        public static explicit operator int (Sumador s)
        {
            return s._cantidadSuma;
        }
        #endregion
    }
}
