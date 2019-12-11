using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.SP
{
    public class Producto
    {
        public string nombre;
        public int stock;

        public Producto() 
        {
            this.nombre = "";
            this.stock = 0;
        }
        public Producto(string nombre, int stock)
        {
            this.nombre = nombre;
            this.stock = stock;
        }
    }
}
