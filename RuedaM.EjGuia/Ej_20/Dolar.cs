using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_20
{
    class Dolar
    {
        #region atributos
        private double _cantidad;
        private static float _cotizRespectoDolar;
        #endregion
        
        #region metodos

        #region constructo
        public Dolar(double cantida, float cotizacion)
        {
            this._cantidad = cantida;
            Dolar._cotizRespectoDolar = cotizacion;
        }
        public Dolar(double cantidad):this(cantidad,1)
        {
        }
        private Dolar() : this(0, 1)
        {
        }
        #endregion        

        /// <summary>
        /// Retorna _cotizRespectoDolar
        /// </summary>
        /// <returns></returns>
        public static float GetCotizacion()
        {
            return Dolar._cotizRespectoDolar;
        }

        /// <summary>
        /// Retorna cantidad
        /// </summary>
        /// <returns></returns>
        public double GetCantidad()
        {
            return this._cantidad;
        }


        #region conversores de monedad
        public static explicit operator Euro(Dolar d)
        {
            Euro x = new Euro(d._cantidad / Euro.GetCotizacin());
            return x;
        }

        public static explicit operator Peso(Dolar d)
        {
            Peso x = new Peso(d._cantidad * Peso.GetCotizacin());
            return x;
        }

        public static implicit operator Dolar(double d)
        {
            Dolar x = new Dolar(d);
            return x;
        }
        /////////////////////////////////////////////////////////
        #endregion

        #region Sorecarga de operadores

        public static bool operator ==(Dolar p, Euro d)
        {
            Dolar x = new Dolar(p.GetCantidad());
            x = (Dolar)d;

            if (x.GetCantidad() == (float)p.GetCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Dolar p, Euro d)
        {
            return !(p == d);
        }

        public static bool operator ==(Dolar d, Peso p)
        {
            if (d._cantidad*Peso.GetCotizacin() == (float)p.GetCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            if (d1.GetCantidad() == d2.GetCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        public static Dolar operator +(Dolar d, Peso p)
        {
            Dolar x = new Dolar();
            x = (Dolar)d;

            d._cantidad += x.GetCantidad();
            return d;
        }
        public static Dolar operator -(Dolar d, Peso p)
        {
            Dolar x = new Dolar();
            x = (Dolar)d;

            d._cantidad -= x.GetCantidad();
            return d;
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar x = new Dolar();
            x = (Dolar)e;

            d._cantidad += x.GetCantidad();
            return d;
        }
        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar x = new Dolar();
            x = (Dolar)e;

            d._cantidad -= x.GetCantidad();
            return d;
        }
        #endregion

        #endregion

    }
}
