using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comerciante
    {
        #region Atributos
        private string _apellido;
        private string _nombre;
        #endregion

        #region Constructores

        public Comerciante(string nombre, string apellido)
        {
            this._apellido = apellido;
            this._nombre = nombre;
        }

        #endregion

        #region Operadores

        /// <summary>
        /// Retorna true en caso de igualdad en nombres y apellidos entre a y b.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(Comerciante a, Comerciante b)
        {
            if (!Object.Equals(a, null) && !Object.Equals(b, null))
            {
                if (a._nombre == b._nombre && a._apellido == b._apellido)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Comerciante a, Comerciante b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Retorna el comerciante que recibe por parametro
        /// </summary>
        /// <param name="a"></param>
        public static implicit operator string(Comerciante a)
        {
            return " + " + a._apellido + ", " + a._nombre;
        }


        #endregion
    }
}
