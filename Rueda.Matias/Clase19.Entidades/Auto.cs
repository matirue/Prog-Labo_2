using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase19.Entidades
{
    public class Auto:IXML
    {
        public string marca;
        public double precio;

        public Auto() { }
        public Auto(string marca, double precio)
        {
            this.marca = marca;
            this.precio = precio;
        }

        public bool Guardar(string cad)
        {
            throw new NotImplementedException();
        }

        public bool Leer(string cad, out object obj)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return " Marca: " + this.marca + " -> $" + this.precio;
        }
    }
}
