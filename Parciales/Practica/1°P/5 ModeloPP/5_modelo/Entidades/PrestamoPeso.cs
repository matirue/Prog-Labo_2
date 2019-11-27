using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamosPersonales
{
    public class PrestamoPeso : Prestamo
    {

        #region Atributos
        private float porcentajeInteres;
        #endregion

        #region Propiedades
        public float Interes
        {
            get {
                return this.CalcularInteres();
            }
        }
        #endregion

        #region Metodos
        private float CalcularInteres()
        {
            return ((this.Monto * this.porcentajeInteres) / 100);
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            float dias = (float)(this.Vencimiento - nuevoVencimiento).TotalDays;
            this.porcentajeInteres += (int)0.25 * dias;
            this.Vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {
            return (base.Mostrar() + " - %Interes : " + this.porcentajeInteres);
        }

        #region Constructores
        public PrestamoPeso(float monto, DateTime vencimiento, float porcentajeInteres) : base(monto, vencimiento)
        {
            this.porcentajeInteres = porcentajeInteres;
        }

        public PrestamoPeso(Prestamo prestamo, float porcentajeInteres) : this(prestamo.Monto, prestamo.Vencimiento, porcentajeInteres)
        {
        }
        #endregion

        #endregion
    }
}
