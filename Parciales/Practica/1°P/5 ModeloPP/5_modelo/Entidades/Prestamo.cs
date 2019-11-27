using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamosPersonales
{
    abstract public class Prestamo
    {
        #region Atributos
        protected float monto;
        protected DateTime vencimiento;
        #endregion

        #region Propiedades
        public float Monto
        {
            get {
                return this.monto;
            }
        }

        public DateTime Vencimiento
        {
            get {
                return this.vencimiento;
            }
            set {
                if (value > DateTime.Now)
                {
                    this.vencimiento = value;
                }
                else
                {
                    this.vencimiento = DateTime.Now;
                }
            }
        }
        #endregion

        #region Metodos
        #region Constructores
        public Prestamo(float monto, DateTime vencimiento)
        {
            this.monto = monto;
            this.vencimiento = vencimiento;
        }
        #endregion

        public abstract void ExtenderPlazo(DateTime nuevoVencimiento);

        public virtual string Mostrar()
        {
            return ("Monto: " + this.monto + " - Vencimiento: " + this.vencimiento);
        }

        public int OrdenarPorFecha(Prestamo p1, Prestamo p2)
        {
            return DateTime.Compare(p1.Vencimiento, p2.Vencimiento);
        }

        #endregion
    }
}
