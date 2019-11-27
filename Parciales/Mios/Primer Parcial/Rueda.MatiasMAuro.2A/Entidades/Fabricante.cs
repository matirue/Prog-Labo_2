using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fabricante
    {
        #region atributos

        private string marca;
        private EPais pais;

        #endregion

        #region Constructor
        public Fabricante(string marca, EPais pais)
        {
            this.marca = marca;
            this.pais = pais;
        }
        #endregion

        #region Operador
        /// <summary>
        /// true si marca y pais son iguales
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(Fabricante a, Fabricante b)
        {
            if(!Object.Equals(a,null) && !Object.Equals(b, null))
            {
                if (a.marca == b.marca && a.pais == b.pais)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Fabricante a, Fabricante b)
        {
            return !(a == b);
        }

         /// <summary>
         /// retorna marca y pais del obj
         /// </summary>
         /// <param name="f"></param>
        public static implicit operator String (Fabricante f)
        {
            //return "+ FABRICANTE: " + f.marca + " - " + f.pais +"\n";
            return f.marca + " - " + f.pais;
        }
        #endregion
    }
}
