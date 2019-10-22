using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase17.DepositosAutos
{
    public class Auto
    {
        #region Atributos
        private string _color;
        private string _marca;
        #endregion

        #region Propiedades
        public string Color { get { return this._color; } }
        public string Marca { get { return this._marca; } }
        #endregion

        #region Constructor
        public Auto(string color, string marca)
        {
            this._color = color;
            this._marca = marca;
        }
        #endregion

        #region Operador

        /// <summary>
        /// true en caso de igualdad en color y marca 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(Auto a, Auto b)
        {
            if(!Object.Equals(a, null) && !Object.Equals(b, null) )
            {
                //if (a._color == b._color && a._marca == b._marca)
                if (String.Compare(a.Color,b.Color)==0 && String.Compare(a.Marca, b.Marca)==0)
                    return true;
            }

            return false;
        }
        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }

        #endregion

        #region Metodos

        /// <summary>
        /// true si obj es de tipo auto y su marca y color son iguales
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if ( (obj is Auto) && ((Auto)obj == this) )
                return true;
            else
                return false;
        }

        /// <summary>
        /// retorna un string con marca y color
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "  ->Marca: " + this._marca + " - Color: " + this._color + "\n";
        }

        #endregion
    }
}
