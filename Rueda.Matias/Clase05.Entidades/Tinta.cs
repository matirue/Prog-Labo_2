using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05.Entidades
{
    /// <summary>
    /// clase de paractica
    /// </summary>
    public class Tinta
    {
        private ConsoleColor _color;
        private ETipoTinta _tipo;

        //constructor
        /// <summary>
        /// color->blue
        /// tipo->comun
        /// </summary>
        public Tinta()
        {
            this._color = ConsoleColor.Blue;
            this._tipo = ETipoTinta.comun;
        }

        /// <summary>
        /// tipo->comun
        /// </summary>
        /// <param name="color">valor usuario</param>
        public Tinta(ConsoleColor color):this()
        {
            this._color = color;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="color">valor usuario</param>
        /// <param name="tipo">valor usuario</param>
        public Tinta(ConsoleColor color, ETipoTinta tipo):this(color)
        {
            this._tipo = tipo;
        }

        //metodos
        private string Mostrar()
        {
            return "Color: " + this._color + "\nTipo de tinta: " + this._tipo;
        }

        /// <summary>
        /// Mostrara informacion segun el objeto que le paso
        /// </summary>
        /// <param name="tipo">Objeto</param>
        /// <returns></returns>
        public static string Mostrar(Tinta tipo)
        {
            return tipo.Mostrar();
        }


        //sobrecarga

        public static bool operator == (Tinta a,Tinta b)
        {
            bool retorno = false;
            if (!Object.Equals(a,null) && !Object.Equals(b, null))
            {
                if (a._color == b._color && a._tipo == b._tipo)
                {
                    retorno = true;
                }
                else
                {
                    retorno = false;
                }
            }
            
            return retorno;
        }

        public static bool operator !=(Tinta a, Tinta b)
        {
            return !(a == b);  //reutilizo codigo evitando errores
        }


        public static bool operator == (Tinta tinta, ConsoleColor color)
        {
            bool retorno = false;

            if (tinta._color == color)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator != (Tinta tinta, ConsoleColor color)
        {
            return !(tinta._color == color);
        }

        public  static explicit operator string (Tinta tipo)
        {
            return tipo.Mostrar();
        }
    }
}
