using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05.Entidades
{
    public class Pluma
    {
        private string _marca;
        private Tinta _tinta;
        private int _cantidad;


        //constructor
        public Pluma()
        {
            this._marca = "Sin Marca";
            this._tinta = null;
            this._cantidad = 0;
        }

        public Pluma(string marca) : this()
        {
            this._marca = marca;
        }

        public Pluma(string marca, Tinta tinta) : this(marca)
        {
            this._tinta = tinta;
        }

        public Pluma(string marca,  Tinta tinta, int cantidad) : this(marca,tinta)
        {
            this._cantidad = cantidad;
        }

        //metodos
        private string Mostrar()
        {
            return "Marca: " + this._marca + "\n" + Tinta.Mostrar(this._tinta) + "\nCantidad: " + this._cantidad;
        }
        public static implicit operator string (Pluma pluma)
        {
            return pluma.Mostrar();
        }

        public static bool operator == (Pluma p, Tinta t)
        {
            return (p._tinta == t);
        }

        public static bool operator !=(Pluma p, Tinta t)
        {
            return !(p == t); // noo hace falta aclarar el atributo de pluma 
        }

        public static Pluma operator +(Pluma p, Tinta t)
        {
            if (p._tinta == t && p._cantidad<100)
            {
                p._cantidad++;
                return p;
            }

            return p;
        }

    }
}
