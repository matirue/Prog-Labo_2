using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_21
{
    class Celsius
    {
        private double _cantidad;

        public Celsius(double cantidad)
        {
            this._cantidad = cantidad;

        }
        public Celsius() : this(0)
        {

        }

        public double GetCantidad { get { return this._cantidad; } }

        //conversor
        public static explicit operator Farenheit(Celsius c)
        {
            Farenheit f = new Farenheit(((c.GetCantidad * 1.8) + 32));
            return f;
        }
        public static explicit operator Kelvin(Celsius c)
        {
            Kelvin k = new Kelvin((c.GetCantidad + 273.15));
            return k;
        }
        public static explicit operator Celsius(double cantidad)
        {
            Celsius c = new Celsius(cantidad);
            return c;
        }

        //operadores
        public static bool operator ==(Celsius c, Celsius b)
        {
            if (c.GetCantidad == b.GetCantidad)
                return true;
            else
                return false;
        }
        public static bool operator !=(Celsius c, Celsius b)
        {
            return !(c == b);
        }

        public static bool operator ==(Celsius c, Farenheit f)
        {
            Celsius algo = new Celsius();
            algo = (Celsius)f;

            if (c.GetCantidad == algo.GetCantidad)
                return true;
            else
                return false;
        }
        public static bool operator !=(Celsius c, Farenheit f)
        {
            return !(c == f);
        }

        public static bool operator ==(Celsius c, Kelvin k)
        {
            Celsius algo = new Celsius();
            algo = (Celsius)k;

            if (c.GetCantidad == algo.GetCantidad)
                return true;
            else
                return false;
        }
        public static bool operator !=(Celsius c, Kelvin k)
        {
            return !(c == k);
        }

        public static Celsius operator +(Celsius x, Celsius y)
        {
            return (Celsius)x._cantidad + (Celsius)y._cantidad;
        }
        public static Celsius operator -(Celsius x, Celsius y)
        {
            return (Celsius)x._cantidad - (Celsius)y._cantidad;
        }

        public static Celsius operator +(Celsius x, Farenheit y)
        {
            Celsius algo = new Celsius();
            algo = (Celsius)y;

            return (Celsius)x._cantidad + (Celsius)algo._cantidad;
        }
        public static Celsius operator -(Celsius x, Farenheit y)
        {
            Celsius algo = new Celsius();
            algo = (Celsius)y;

            return (Celsius)x._cantidad - (Celsius)algo._cantidad;
        }

        public static Celsius operator +(Celsius x, Kelvin y)
        {
            Celsius algo = new Celsius();
            algo = (Celsius)y;

            return (Celsius)x._cantidad + (Celsius)algo._cantidad;
        }
        public static Celsius operator -(Celsius x, Kelvin y)
        {
            Celsius algo = new Celsius();
            algo = (Celsius)y;

            return (Celsius)x._cantidad + (Celsius)algo._cantidad;
        }
    }
}
