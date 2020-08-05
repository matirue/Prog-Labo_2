using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    //ProdVendido hereda de ProdExport, que ProdExport hereda de ProdImpuesto y que éste último hereda de Producto.
    [Serializable]
    [XmlInclude(typeof(ProdExport))]
    public class ProdImpuesto:Producto
    {//new ProdImpuesto(pro.Nombre, pro.Stock, 600.33);
        #region Campos
        public double impuesto;
        #endregion

        #region Metodos
        public ProdImpuesto() { }
        public ProdImpuesto(string nombre, int cantidad, double impuesto) : base(nombre, cantidad)
        {
            this.impuesto = impuesto;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.ToString());
            sb.AppendFormat("\nImpuesto: " + this.impuesto);
            return sb.ToString();
        }
        #endregion
    }
}
