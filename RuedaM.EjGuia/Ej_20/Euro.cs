using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_20
{
    class Euro
    {
        #region atributos
        private double _cantidad;
        private static float _cotizRespectoDolar;
        #endregion

        #region Metodos

        #region constructo
        public Euro(double cantida, float cotizacion)
        {
            this._cantidad = cantida;
            Euro._cotizRespectoDolar = cotizacion;
        }
        public Euro(double cantidad) : this(cantidad, 1.16F)
        {
        }
        private Euro() : this(0, 1.16F)
        {
        }
        #endregion

        /// <summary>
        /// Retorna _cotizRespectoDolas
        /// </summary>
        /// <returns></returns>
        public static float GetCotizacin()
        {
            return Euro._cotizRespectoDolar;
        }

        /// <summary>
        /// Retorna _cantidad
        /// </summary>
        /// <returns></returns>
        public double GetCantidad()
        {
            return this._cantidad;
        }

        #region conversores de monedas
        public static explicit operator Dolar(Euro p)
        {
            Dolar obj = new Dolar( p._cantidad * Euro.GetCotizacin() );
            return obj;
        }

        public static explicit operator Peso(Euro c)
        {
            Dolar dolar = new Dolar(0);
            dolar = (Dolar)c;
            Peso obj = new Peso( Dolar.GetCotizacion() * Peso.GetCotizacin() );
            return obj;
        }

        public static implicit operator Euro(double d)
        {
            Euro obj = new Euro(d);
            return obj;
        }
        #endregion

        #region Sorecarga de operadores

        public static bool operator ==(Euro e, Dolar d)
        {
            Euro x = new Euro(e.GetCantidad());
            x = (Euro)d;

            if (x.GetCantidad() == (float)e.GetCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator ==(Euro e, Peso p)
        {
            Euro x = new Euro();
            x = (Euro)p;
            if (x.GetCantidad() == (float)e.GetCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            if (e1.GetCantidad() == e2.GetCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static Euro operator +(Euro e, Peso p)
        {
            Euro x = new Euro();
            x = (Euro)p;

            e._cantidad += x.GetCantidad();
            return e;
        }
        public static Euro operator -(Euro e, Peso p)
        {
            Euro x = new Euro();
            x = (Euro)p;

            e._cantidad -= x.GetCantidad();
            return e;
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            Euro x = new Euro();
            x = (Euro)d;

            e._cantidad += x.GetCantidad();
            return e;
        }
        public static Euro operator -(Euro e, Dolar d)
        {
            Euro x = new Euro();
            x = (Euro)d;

            e._cantidad -= x.GetCantidad();
            return e;
        }
        #endregion

        #endregion

    }
}
