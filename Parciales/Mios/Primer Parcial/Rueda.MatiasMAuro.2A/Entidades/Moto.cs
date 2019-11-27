using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        #region Atributo

        public ECilindrada cilindrada;

        #endregion

        #region Constructor
        public Moto (string marca, EPais pais, string modelo, float precio, ECilindrada cilindrada)
            : base(marca, pais, modelo, precio)
        {
            this.cilindrada = cilindrada;
        }
        #endregion

        #region Metodos

        /// <summary>
        /// retorna true si obj es de Moto
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Moto)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return Vehiculo.Mostrar(this) + "\n-CILINDRADA: " + this.cilindrada+"\n";
        }

        #endregion

        #region Operador

        /// <summary>
        /// True si vheiculo y cilindadra son iguales
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(Moto a, Moto b)
        {

            //if (a.cilindrada == b.cilindrada)
            //if (a.cilindrada == b.cilindrada && Object.Equals(a,b))
            if (a.cilindrada == b.cilindrada && (Vehiculo)a == (Vehiculo)b)
                return true;
            
            return false;
        }
        public static bool operator !=(Moto a, Moto b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Retorna el precio de la moto parametro
        /// </summary>
        /// <param name="m"></param>
        public static implicit operator Single(Moto m)
        {
            return (Single)m.precio;
        }
        #endregion
    }
}
