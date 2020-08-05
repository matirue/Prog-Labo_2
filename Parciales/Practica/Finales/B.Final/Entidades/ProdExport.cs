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
    [XmlInclude(typeof(ProdVendido))]
    public class ProdExport:ProdImpuesto
    {
        //new ProdExport(pI, "Argentina");
        #region Campos
        public string pais;
        #endregion

        #region Metodos
        public ProdExport() { }
        public ProdExport(ProdImpuesto pi, string pais) 
            : base(pi.nombre,pi.cantidad,pi.impuesto)
        {
            this.pais = pais;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.ToString());
            sb.AppendFormat("\nPais: " + this.pais);
            return sb.ToString();
        }
        #endregion
    }
}
