using System;
using System.Collections.Generic;
using System.Text;

namespace PreParcial
{
    public class Gato : Mascota
    {
        #region Metodos
        public override bool Equals(object obj)
        {
            if (obj is Gato)
            {
                if ((Gato)obj == this)
                {
                    return true;
                }
            }
            return false;
        }

        protected override string Ficha()
        {
            return base.DatosCompletos();
        }

        #region Constructores
        public Gato(string nombre, string raza) : base(nombre, raza)
        {
        }
        #endregion

        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1==g2);
        }

        public static bool operator ==(Gato g1, Gato g2)
        {
            if (g1.Nombre == g2.Nombre && g1.Raza == g2.Raza)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return this.Ficha();
        }
    }
        #endregion
}
