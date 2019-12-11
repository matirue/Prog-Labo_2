using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using ComiqueriaLogic.Comun;
using ComiqueriaLogic.Entidades;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        private List<Producto> productos;
        private List<Venta> ventas;
        public event Action productosListChanged;

        //ClassSQL miSql;

        /// <summary>
        /// Constructor, instancia los campos de tipo lista. 
        /// Asocia el evento de cambios en la tabla de productos para actualizar la lista.
        /// </summary>
        public Comiqueria()
        {
            /* PUNTO 4D: 
             * Cree también un método que retorne la lista de productos (List<Producto>) almacenada en la tabla de productos. 
             * Utilice este método para cargar la lista de productos en la clase Comiqueria cuando se instancie una nueva comiquería.  
             */

            this.ventas = new List<Venta>();
            /**************************/
            //this.miSql = new ClassSQL();
            //this.productos = this.miSql.Leer();
            this.productos = ClassSQL.Leer();
            ClassSQL.AccesoBaseDeDatos += LeerBaseDeDatos;

            /**************************/


        }

        /// <summary>
        /// Devuelve o carga la lista de productos.
        /// </summary>
        public List<Producto> Productos
        {
            get
            {
                return this.productos;
            }
            set
            {
                this.productos = value;
                this.productosListChanged();
            }
        }

        public List<Venta> Ventas
        {
            get
            {
                return this.ventas;
            }
            set
            {
                this.ventas = value;
            }
        }

        /// <summary>
        /// Verifica si un producto se encuentra en la lista de productos.
        /// </summary>
        /// <param name="comiqueria"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool operator ==(Comiqueria comiqueria, Producto producto)
        {
            foreach (Producto prod in comiqueria.productos)
            {
                if (prod.Codigo == producto.Codigo)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Verifica si un producto NO se encuentra en la lista de productos. 
        /// </summary>
        /// <param name="comiqueria"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            return !(comiqueria == producto);
        }

        /// <summary>
        /// Genera una nueva venta.
        /// </summary>
        /// <param name="producto">Producto a Vender.</param>
        /// <param name="cantidad">Cantidad solicitada del producto.</param>
        public void Vender(Producto producto, int cantidad)
        {
            Venta nuevaVenta = new Venta(producto, cantidad);
            this.ventas.Add(nuevaVenta);

            string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), String.Format(@"Venta_{0}.bin", nuevaVenta.Fecha.ToString("ddMMyyyy_HHmmss")));

            // Punto 6G - Serializar a binario la nueva venta.
            //Serializador<Venta>.GuardarXmlBinario(ruta, nuevaVenta);

            ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), String.Format(@"Venta_{0}.xml", nuevaVenta.Fecha.ToString("ddMMyyyy_HHmmss")));
            // Punto 6G - Serializar a xml la nueva venta.
            //Serializador<Venta>.GuardarXml(ruta, nuevaVenta);
        }

        /// <summary>
        /// Devuelve un string conteniendo la descripción breve de cada venta en la lista de ventas. 
        /// </summary>
        /// <returns></returns>
        public string ListarVentas()
        {
            List<Venta> ventasOrdenadas = this.ventas.OrderByDescending(x => x.Fecha).ToList();

            StringBuilder sb = new StringBuilder();
            foreach (Venta venta in ventasOrdenadas)
            {
                sb.AppendLine(venta.ObtenerDescripcionBreve());
            }

            return sb.ToString();
        }


        /*******************************************************/
        //manejador
        public void LeerBaseDeDatos(AccionesDB accion)
        {
            this.Productos = ClassSQL.Leer();
        }
    }
}
