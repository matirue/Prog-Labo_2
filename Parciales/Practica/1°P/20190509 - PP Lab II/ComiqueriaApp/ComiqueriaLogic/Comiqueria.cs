using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ComprobastesLogic;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        //private static Stack<Comprobante> comprobantes;
        private List<Producto> productos;
        private List<Venta> ventas;
        public Producto this[Guid codigo]
        {
            get
            {
                
                foreach (Producto p in this.productos)
                {
                    if (((Guid)p)==codigo)
                    {
                        return p;
                    }
                }
                return null;
            }
        }
        public Comiqueria()
        {
            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();
        }
        public static bool operator ==(Comiqueria comiqueria, Producto producto)
        {
            foreach (Producto p in comiqueria.productos)
            {
                if ((Guid)producto==(Guid)p)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            return !(comiqueria == producto);
        }
        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {
            if (comiqueria!=producto)
            {
                comiqueria.productos.Add(producto);
            }
            return comiqueria;
        }
        public void Vender(Producto producto)
        {
            Vender(producto, 1);
        }   
        public void Vender(Producto producto, int cantidad)
        {
            this.ventas.Add(new Venta(producto, cantidad));
        }
        private int CompararVenta(Venta v1,Venta v2)
        {
            return v1.Fecha.CompareTo(v2.Fecha);
        }
        public string ListarVentas()
        {
            StringBuilder stringBuilder = new StringBuilder();
            this.ventas.Sort(CompararVenta);
            foreach (Venta venta in this.ventas)
            {
                stringBuilder.Append(venta.ObtenerDescripcionBreve());
            }
            return stringBuilder.ToString();
        }
        public Dictionary<Guid, string> ListarProductos()
        {
            Dictionary<Guid, string> nuevoDiccionario = new Dictionary<Guid, string>();
            foreach (Producto producto in this.productos)
            {
                nuevoDiccionario.Add((Guid)producto,producto.Descripcion);
            }
            return nuevoDiccionario;
        }
    }
}
