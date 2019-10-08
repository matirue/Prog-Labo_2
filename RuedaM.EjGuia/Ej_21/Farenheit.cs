using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_21
{
    class Farenheit
    {
        private double _cantidad;

        public Farenheit (double cantidad)
        {
            this._cantidad = cantidad;

        }
        public Farenheit() : this(32)
        {

        }

        public double GetCantidad { get { return this._cantidad; } }

        //conversor
        public static explicit operator Celsius(Farenheit f)
        {
            Celsius c = new Celsius(((f.GetCantidad - 32) / 1.8));
            return c;
        }
        public static explicit operator Kelvin(Farenheit f)
        {
            Kelvin k = new Kelvin((f.GetCantidad + 459.67)/1.8);
            return k;
        }
        public static explicit operator Farenheit (double cantidad)
        {
            Farenheit c = new Farenheit(cantidad);
            return c;
        }

        //operadores
        public static bool operator ==(Farenheit f, Farenheit b)
        {
            if (f.GetCantidad == b.GetCantidad)
                return true;
            else
                return false;
        }
        public static bool operator !=(Farenheit f, Farenheit b)
        {
            return !(f == b);
        }

        public static bool operator ==(Farenheit f, Celsius c)
        {
            Farenheit algo = new Farenheit();
            algo = (Farenheit)c;

            if (f.GetCantidad == algo.GetCantidad)
                return true;
            else
                return false;
        }
        public static bool operator !=(Farenheit f, Celsius c)
        {
            return !(c == f);
        }

        public static bool operator ==(Farenheit f, Kelvin k)
        {
            Farenheit algo = new Farenheit();
            algo = (Farenheit)k;

            if (f.GetCantidad == algo.GetCantidad)
                return true;
            else
                return false;
        }
        public static bool operator !=(Farenheit f, Kelvin k)
        {
            return !(f == k);
        }

        public static Celsius operator +(Farenheit x, Farenheit y)
        {
            return (Farenheit)x._cantidad + (Farenheit)y._cantidad;
        }
        public static Celsius operator -(Farenheit x, Farenheit y)
        {
            return (Farenheit)x._cantidad - (Farenheit)y._cantidad;
        }

        public static Celsius operator +(Farenheit x, Celsius y)
        {
            Farenheit algo = new Farenheit();
            algo = (Farenheit)y;

            return (Farenheit)x._cantidad + (Farenheit)algo._cantidad;
        }
        public static Celsius operator -(Farenheit x, Celsius y)
        {
            Farenheit algo = new Farenheit();
            algo = (Farenheit)y;

            return (Farenheit)x._cantidad - (Farenheit)algo._cantidad;
        }

        public static Celsius operator +(Farenheit x, Kelvin y)
        {
            Farenheit algo = new Farenheit();
            algo = (Farenheit)y;

            return (Farenheit)x._cantidad + (Farenheit)algo._cantidad;
        }
        public static Celsius operator -(Farenheit x, Kelvin y)
        {
            Farenheit algo = new Farenheit();
            algo = (Farenheit)y;

            return (Farenheit)x._cantidad - (Farenheit)algo._cantidad;
        }
    }
}
