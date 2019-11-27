using System;
using System.Text;

namespace ComiqueriaLogic
{
    [Serializable]
    public class Producto
    {
        private int stock;
        private double precio;
        private int codigo;
        private string descripcion;

        /// <summary>
        /// Constructor. Inicializa los atributos del producto. 
        /// </summary>
        /// <param name="codigo">Codigo único (PK) del producto en la base de datos.</param>
        /// <param name="descripcion">Descripción del producto.</param>
        /// <param name="stock">Stock disponible del producto.</param>
        /// <param name="precio">Precio del producto.</param>
        internal Producto(int codigo, string descripcion, int stock, double precio)
        {
            this.codigo = codigo;
            this.Stock = stock;
            this.Precio = precio;
            this.Descripcion = descripcion;
        }

        /// <summary>
        /// Stock del producto. Debe ser mayor a cero. 
        /// </summary>
        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if(value >= 0)
                {
                    this.stock = value;
                }
            }
        } 

        /// <summary>
        /// Precio del producto. Debe ser mayor a 1. 
        /// </summary>
        public double Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                if (value >= 1)
                {
                    this.precio = value;
                }
            }
        }

        /// <summary>
        /// Descripción del producto. 
        /// </summary>
        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
            set
            {
                this.descripcion = value;
            }
        }

        /// <summary>
        /// Código del producto en la base de datos (PK). 
        /// Propiedad de sólo lectura. 
        /// </summary>
        public int Codigo
        {
            get
            {
                return this.codigo;
            }
        }

        /// <summary>
        /// Devuelve un string con los datos de un producto: código, descripción, precio y stock. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("Código: {0}", this.Codigo));
            sb.AppendLine(String.Format("Descripción: {0}", this.Descripcion));
            sb.AppendLine(String.Format("Precio: ${0:0.00}", this.Precio));
            sb.AppendLine(String.Format("Stock: {0} unidades", this.Stock));

            return sb.ToString();
        }
    }
}
