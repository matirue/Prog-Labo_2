using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Autor
    {
        #region Atributos
        /// <summary>
        /// Atributo Apellido.
        /// </summary>
        private string _apellido;

        /// <summary>
        /// Atributo Nombre.
        /// </summary>
        private string _nombre;

        #endregion


        #region Constructores

        /// <summary>
        /// Constructor publico de Autor, que recibe 2 parametros.
        /// </summary>
        /// <param name="nombre"> Parametro nombre </param>
        /// <param name="apellido">Parametro apellido </param>
        public Autor(string nombre, string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }

        #endregion


        #region Metodos

        /// <summary>
        /// Sobrecarga del operador == 
        /// </summary>
        /// <param name="a"> Autor A </param>
        /// <param name="b"> Autor B </param>
        /// <returns></returns>
        public static bool operator == (Autor a, Autor b)
        {
            bool retorno = false;

            if (a._nombre == b._nombre && a._apellido == b._apellido)
            {
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Sobrecarga del operador !=
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator != (Autor a, Autor b)
        {

            return !(a == b);
        }

        /// <summary>
        /// Metodo statico que retorna un string
        /// </summary>
        /// <param name="a"> Autor A</param>
        public static implicit operator string(Autor a)
        {
            return string.Format("{0} - {1}", a._nombre, a._apellido);
        }

        #endregion

    }
}
