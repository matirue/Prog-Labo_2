using System;
using System.Collections.Generic;
using System.Text;

namespace PreParcial
{
    public class Perro : Mascota
    {
        #region Atributos
        private int edad;
        private bool esAlfa;
        #endregion

        #region Metodos
        public override bool Equals(object obj)
        {
            if (obj is Perro)
            {
                if ((Perro)obj == this)
                {
                    return true;
                }
            }
            return false;
        }

        public static explicit operator int(Perro p)
        {
            return p.edad;
        } 

        protected override string Ficha()
        {
            string retorno = "";
            if (esAlfa == true)
            {
                retorno = base.DatosCompletos() + ", alfa de la manada, edad " + this.edad;
            }
            else
            {
                retorno = base.DatosCompletos() + ", edad " + this.edad;
            }
            return retorno;
        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Perro p1, Perro p2)
        {
            if (p1.Nombre == p2.Nombre && p1.Raza == p2.Raza && p1.edad == p2.edad)
            {
                return true;
            }
            return false;
        }

        #region Constructores
        public Perro (string nombre, string raza) : this(nombre, raza, 0, false)
        {
        }

        public Perro(string nombre, string raza, int edad, bool esAlfa) : base(nombre, raza)
        { 
        }
        #endregion

         public override string ToString()
        {
            return this.Ficha();
        }

        #endregion
    }
}
