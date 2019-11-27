using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComiqueriaLogic;
namespace ComprobastesLogic
{
    public abstract class Comprobante
    {
        protected DateTime fechaEmision;
        private Venta venta;

        internal Venta Venta
        {
            get { return venta; }
        }

        public Comprobante(Venta venta)
        {
            this.fechaEmision = venta.Fecha;
            this.venta = venta;
        }

        public override bool Equals(Object obj)
        {
            if ((obj is Comprobante) && this.fechaEmision==((Comprobante)obj).fechaEmision)
            {
                return true;
            }
            return false;
        }
        public abstract string GenerarComprobante();



    }
}
