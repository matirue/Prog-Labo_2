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
    public class ProdVendido:ProdExport
    {
        //new ProdVendido(pEX, "Cliente Juan");
        #region Campos
        public string cliente;
        #endregion

        #region Metodos
        public ProdVendido() { }
        public ProdVendido(ProdExport pEx, string cliente)
            : base(new ProdImpuesto(pEx.nombre,pEx.cantidad,pEx.impuesto), pEx.pais)
        {
            this.cliente = cliente;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.ToString());
            sb.AppendFormat("\nClente: " + this.cliente);
            return sb.ToString();
        }
        #endregion
    }
}
