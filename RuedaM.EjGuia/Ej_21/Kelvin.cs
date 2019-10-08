using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_21
{
    class Kelvin
    {
        private double _cantidad;

        public Kelvin(double cantidad)
        {
            this._cantidad = cantidad;

        }
        public Kelvin() : this(273)
        {

        }

        public double GetCantidad { get { return this._cantidad; } }

        //conversor
        public static explicit operator Celsius(Kelvin k)
        {
            Celsius c = new Celsius(((k.GetCantidad - 273.15)));
            return c;
        }
        public static explicit operator Farenheit(Kelvin k)
        {
            Farenheit f = new Farenheit((k.GetCantidad * 1.8) - 459.67);    
            return f;
        }
        public static explicit operator Kelvin(double cantidad)
        {
            Kelvin k = new Kelvin(cantidad);
            return k;
        }

        //operadores
        public static bool operator ==(Kelvin k, Kelvin b)
        {
            if (k.GetCantidad == b.GetCantidad)
                return true;
            else
                return false;
        }
        public static bool operator !=(Kelvin k, Kelvin b)
        {
            return !(k == b);
        }

        public static bool operator ==(Kelvin k, Celsius c)
        {
            Kelvin algo = new Kelvin();
            algo = (Kelvin)c;

            if (k.GetCantidad == algo.GetCantidad)
                return true;
            else
                return false;
        }
        public static bool operator !=(Kelvin k, Celsius c)
        {
            return !(c == k);
        }

        public static bool operator ==(Kelvin k, Farenheit f)
        {
            Kelvin algo = new Kelvin();
            algo = (Kelvin)f;

            if (k.GetCantidad == algo.GetCantidad)
                return true;
            else
                return false;
        }
        public static bool operator !=(Kelvin k, Farenheit f)
        {
            return !(f == k);
        }

        public static Kelvin operator +(Kelvin x, Kelvin y)
        {
            return (Kelvin)x._cantidad + (Kelvin)y._cantidad;
        }
        public static Kelvin operator -(Kelvin x, Kelvin y)
        {
            return (Kelvin)x._cantidad - (Kelvin)y._cantidad;
        }

        public static Kelvin operator +(Kelvin x, Celsius y)
        {
            Kelvin algo = new Kelvin();
            algo = (Kelvin)y;

            return (Kelvin)x._cantidad + (Kelvin)algo._cantidad;
        }
        public static Kelvin operator -(Kelvin x, Celsius y)
        {
            Kelvin algo = new Kelvin();
            algo = (Kelvin)y;

            return (Kelvin)x._cantidad - (Kelvin)algo._cantidad;
        }

        public static Kelvin operator +(Kelvin x, Farenheit y)
        {
            Kelvin algo = new Kelvin();
            algo = (Kelvin)y;

            return (Kelvin)x._cantidad + (Kelvin)algo._cantidad;
        }
        public static Kelvin operator -(Kelvin x, Farenheit y)
        {
            Kelvin algo = new Kelvin();
            algo = (Kelvin)y;

            return (Kelvin)x._cantidad - (Kelvin)algo._cantidad;
        }
    }
}
