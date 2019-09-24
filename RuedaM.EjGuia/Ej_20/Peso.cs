using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_20
{
    class Peso
    {
        #region atributos
        private double _cantidad;
        private static float _cotizRespectoDolar;
        #endregion

        #region metodos

        #region constructor
        public Peso(double cantidad, float cotizacion)
        {
            this._cantidad = cantidad;
            Peso._cotizRespectoDolar = cotizacion;
        }
        public Peso(double cantidad):this(cantidad,38.33F)
        {
        }
        private Peso():this(0,38.33F)
        {
        }
        #endregion


        /// <summary>
        /// Retorna _cotizRespectoDolas
        /// </summary>
        /// <returns></returns>
        public static float GetCotizacin()
        {
            return Peso._cotizRespectoDolar;
        }

        /// <summary>
        /// Retorna _cantidad
        /// </summary>
        /// <returns></returns>
        public double GetCantidad()
        {
            return this._cantidad;
        }

        #region Conversores de monedas
        public static explicit operator Dolar(Peso p)
        {
            Dolar x = new Dolar(p._cantidad / Peso.GetCotizacin());
            return x;
        }

        public static explicit operator Euro(Peso p)
        {
            Dolar x = new Dolar(0);
            x = (Dolar)p;
            Euro e = new Euro(x.GetCantidad() * Euro.GetCotizacin());
            return e;
        }

        public static implicit operator Peso(double d)
        {
            Peso x = new Peso(d);
            return x;
        }
        #endregion

        #region Sorecarga de operadores

        public static bool operator ==(Peso p,Dolar d)
        {
            Peso x = new Peso();
            x = (Peso)d;

            if(x.GetCantidad() == (float)p.GetCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator ==(Peso p, Euro e)
        {
            Peso x = new Peso();
            x = (Peso)e;

            if (x.GetCantidad() == (float)p.GetCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }

        public static bool operator ==(Peso p1, Peso p2)
        {
            if (p1.GetCantidad() == p2.GetCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }

        public static Peso operator +(Peso p,Dolar d)
        {
            Peso x = new Peso();
            x = (Peso)d;

            p._cantidad += x.GetCantidad();
            return p;
        }
        public static Peso operator -(Peso p, Dolar d)
        {
            Peso x = new Peso();
            x = (Peso)d;

            p._cantidad -= x.GetCantidad();
            return p;
        }

        public static Peso operator +(Peso p, Euro e)
        {
            Peso x = new Peso();
            x = (Peso)e;

            p._cantidad += x.GetCantidad();
            return p;
        }
        public static Peso operator -(Peso p, Euro e)
        {
            Peso x = new Peso();
            x = (Peso)e;

            p._cantidad -= x.GetCantidad();
            return p;
        }
        #endregion



        #endregion
    }
}
