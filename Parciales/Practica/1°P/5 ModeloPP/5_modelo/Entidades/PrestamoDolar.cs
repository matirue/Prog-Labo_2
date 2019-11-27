using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamosPersonales
{
    public class PrestamoDolar : Prestamo
    {
        #region Atributos
        private PeriocidadDePagos periocidad;
        #endregion

        #region Propiedades
        public float Interes
        {
            get {
                return this.CalcularInteres();
            }
        }

        public PeriocidadDePagos Periocidad
        {
            get {
                return this.periocidad;
            }
        }
        #endregion

        #region Metodos
        private float CalcularInteres()
        {
            float retorno = -1;
            if (this.periocidad == PeriocidadDePagos.Mensual)
            {
                retorno = 25;
            }else if (this.periocidad == PeriocidadDePagos.Bimestral)
            {
                retorno = 35;
            }
            else if (this.periocidad == PeriocidadDePagos.Trimestral)
            {
                retorno = 40;
            }
            return retorno;
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            double dias = (nuevoVencimiento - (this.Vencimiento)).TotalDays;
            this.monto += (float)(dias * 2.5);
            this.Vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {
            return (base.Mostrar()  + " - Periocidad: " + this.periocidad);
        }

        #region Constructores
        public PrestamoDolar(float monto, DateTime vencimiento, PeriocidadDePagos periocidad) : base(monto, vencimiento)
        {
            this.periocidad = periocidad;
        }

        public PrestamoDolar(Prestamo prestamo, PeriocidadDePagos periocidad) : this (prestamo.Monto, prestamo.Vencimiento, periocidad)
        {
        }
        #endregion

        #endregion
    }
}
