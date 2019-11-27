using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComiqueriaLogic;

namespace ComprobastesLogic
{
    class Factura : Comprobante
    {
        private DateTime fechaDeVencimiento;
        private TipoFactura tipoFactura;

        public enum TipoFactura
        {
            A,
            B,
            C,
            D
        }
        public override bool Equals(object obj)
        {
            if ((obj is Factura) && base.Equals(obj) && this.tipoFactura==((Factura)obj).tipoFactura)
            {
                return true;
            }
            return false;
        }
        public Factura(Venta venta, int diasParaVencimiento, TipoFactura tipoFactura):base (venta)
        {
            this.fechaEmision = venta.Fecha;
            this.fechaDeVencimiento = venta.Fecha.AddDays(diasParaVencimiento);
            this.tipoFactura = tipoFactura;
        }
        public Factura(Venta venta, TipoFactura tipoFactura):this (venta,15,tipoFactura)
        {

        }

        public override string GenerarComprobante()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"FACTURA {this.tipoFactura}");
            sb.AppendLine("");
            sb.AppendLine($"Fecha Emision {this.fechaEmision}");
            sb.AppendLine($"Fecha de Vencimiento {this.fechaDeVencimiento}");
            sb.AppendLine("");
            sb.AppendLine($"Descripcion {((Producto)this.Venta).Descripcion}");
            sb.AppendLine($"Cantidad {this.Venta.Cantidad}");
            sb.AppendLine($"Precio unitario: ${((Producto)this.Venta).Precio:00}");
            sb.AppendLine("");
            sb.AppendLine($"Subtotal: ${((Producto)this.Venta).Precio * this.Venta.Cantidad}");
            sb.AppendLine($"Importe IVA: ${((((Producto)this.Venta).Precio * this.Venta.Cantidad) * Venta.PorcentajeIva) / 100}");
            sb.AppendLine($"Precio Final: tu vieja");

            return sb.ToString();
        }
    }
}
