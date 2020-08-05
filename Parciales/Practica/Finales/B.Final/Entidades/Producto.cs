using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    //Sabiendo que estas líneas de código son correctas, que los atributos de las clases son públicos y además que todas 
    //las clases poseen un solo constructor, realice los constructores, de cada una de las clases, sabiendo que 
    //ProdVendido hereda de ProdExport, que ProdExport hereda de ProdImpuesto y que éste último hereda de Producto.
    [Serializable]
    [XmlInclude(typeof(ProdImpuesto))]
    public class Producto
    {
        //Producto("Pala", 22);
        #region Campos
        public string nombre;
        public int cantidad;
        #endregion

        #region Propiedades
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public int Stock
        {
            get { return this.cantidad; }
            set { this.cantidad = value; }
        }
        #endregion

        #region Metodos
        public Producto() { }
        public Producto(string nombre, int cantidad)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
        }

        public override string ToString()
        {
            return String.Format("\nNombre: " + this.nombre +
                                 "\nCantidad: " + this.cantidad);
        }

        public static bool operator ==(Producto p1, Producto p2) { return p1.Nombre == p2.Nombre; }
        public static bool operator !=(Producto p1, Producto p2) { return !(p1 == p2); }
        
        #endregion
    }
}
