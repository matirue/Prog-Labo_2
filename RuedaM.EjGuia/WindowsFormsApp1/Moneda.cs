using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Moneda
    {
        public class Dolar
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
            public Dolar(double cantidad) : this(cantidad, 1)
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
                if (d._cantidad * Peso.GetCotizacin() == (float)p.GetCantidad())
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

        public class Euro
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
                Dolar obj = new Dolar(p._cantidad * Euro.GetCotizacin());
                return obj;
            }

            public static explicit operator Peso(Euro c)
            {
                Dolar dolar = new Dolar(0);
                dolar = (Dolar)c;
                Peso obj = new Peso(Dolar.GetCotizacion() * Peso.GetCotizacin());
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

        public class Peso
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
            public Peso(double cantidad) : this(cantidad, 38.33F)
            {
            }
            private Peso() : this(0, 38.33F)
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

            public static bool operator ==(Peso p, Dolar d)
            {
                Peso x = new Peso();
                x = (Peso)d;

                if (x.GetCantidad() == (float)p.GetCantidad())
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

            public static Peso operator +(Peso p, Dolar d)
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
}
