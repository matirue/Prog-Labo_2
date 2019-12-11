using System;
using ComiqueriaLogic.Comun;

namespace ComiqueriaLogic
{
    [Serializable]
    public sealed class Venta
    {
        private static int porcentajeIva;
        private DateTime fecha;
        private Producto producto;
        private double precioFinal;
        private int cantidad;

        /// <summary>
        /// Inicializará el porcentaje de IVA que se aplicará sobre las ventas.
        /// </summary>
        static Venta()
        {
            Venta.porcentajeIva = 21;
        }

        /// <summary>
        /// Constructor de una venta.
        /// </summary>
        /// <param name="producto">Producto vendido.</param>
        /// <param name="cantidad">Cantidad vendida del producto.</param>
        internal Venta(Producto producto, int cantidad)
        {
            this.cantidad = cantidad;
            this.producto = producto;
            this.Vender(cantidad);
        }

        /// <summary>
        /// Porcentaje de IVA aplicado sobre las ventas.
        /// </summary>
        public static int PorcentajeIva
        {
            get
            {
                return Venta.PorcentajeIva;
            }
            set
            {
                Venta.PorcentajeIva = porcentajeIva;
            }
        }

        /// <summary>
        /// Cantidad vendida del producto.
        /// </summary>
        private int Cantidad
        {
            get
            {
                return this.cantidad;
            }
            set
            {
                this.cantidad = value;
            }
        }

        /// <summary>
        /// Producto que fue vendido.
        /// </summary>
        public Producto Producto
        {
            get
            {
                return this.producto;
            }
            set
            {
                this.producto = value;
            }
        }

        /// <summary>
        /// Fecha de la venta. 
        /// </summary>
        internal DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
            set
            {
                this.fecha = value;
            }
        }

        /// <summary>
        /// Precio final de la venta. 
        /// </summary>
        public double PrecioFinal
        {
            get
            {
                return this.precioFinal;
            }
            set
            {
                this.precioFinal = value;
            }
        }

        /// <summary>
        /// Método privado que inicializa y calcula las propiedades de la venta.
        /// </summary>
        /// <param name="cantidad"></param>
        private void Vender(int cantidad)
        {
            producto.Stock -= cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = Venta.CalcularPrecioFinal(producto.Precio, cantidad);        
        }
        
        /// <summary>
        /// Calcula el precio final de la venta aplicando los impuestos.
        /// </summary>
        /// <param name="precioUnidad">Precio unitario del producto vendido.</param>
        /// <param name="cantidad">Cantidad de productos vendidos.</param>
        /// <returns></returns>
        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            double precioSinIva = precioUnidad * cantidad;
            return precioSinIva + precioSinIva * Venta.porcentajeIva / 100;
        }

        /// <summary>
        /// Devuelve un breve texto describiendo los datos más importantes de la venta.
        /// </summary>
        /// <returns></returns>
        public string ObtenerDescripcionBreve()
        {
            return String.Format("{0} - {1} - {2}", this.fecha, this.producto.Descripcion, this.precioFinal.FormatearPrecio());
        }        
    }
}
