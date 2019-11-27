using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;

        public string Descripcion
        {
            get
            {
                return descripcion;
            }
        }
        public double Precio
        {
            get
            {
                return precio;
            }
            set
            {
                if (value>=1)
                {
                    this.precio = value;
                }
            }
        }
        public int Stock
        {
            set
            {
                if (value>=0)
                {
                    this.stock = value;
                }
            }
            get 
            {
                return this.stock;
            }
        }
        protected Producto(string descripcion, int stock, double precio)
        {
            this.descripcion = descripcion;
            this.precio = precio;
            this.Stock = stock;
            this.codigo = Guid.NewGuid();
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("Descripcion: {0} \nCodigo: {1} \nPrecio: ${2} \nStock: {3}",
                                        this.Descripcion,this.codigo,this.Precio,this.Stock);
            return stringBuilder.ToString();
        }
        public static explicit operator Guid(Producto p)
        {
            return p.codigo;
        }

    }
}
