using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto : Vehiculo
    {
        #region Atributos
        public ETipo tipo;
        #endregion

        #region Constructor
        public Auto(string modelo,float precio, Fabricante fabri, ETipo tipo)
            : base(precio, modelo, fabri)
        {
            this.tipo = tipo;
        }
        #endregion

        #region Metodos

        /// <summary>
        /// retorna true si obj es de auto
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Auto)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return Vehiculo.Mostrar(this) + "\n-TIPO: " + this.tipo + "\n";
            //return Vehiculo.Mostrar(this) + "\n-TIPO: " + this.tipo+"\n";
        }

        #endregion

        #region Operador

        /// <summary>
        /// true si los vehiculos y los tipos son iguales
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(Auto a, Auto b)
        {
            //if (a.tipo == b.tipo)
            //if (a.tipo == b.tipo && Object.Equals(a, b))
            if (a.tipo == b.tipo && (Vehiculo)a==(Vehiculo)b)
                return true;
            
            return false;
        }
        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }

        /// <summary>
        /// retorna el precio del parametro que recibe
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator Single (Auto a)
        {
            return (Single)a.precio;
        }
        #endregion
    }
}
