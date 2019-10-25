using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase18.EntidadesInterfaces
{
    public class Avion : Vehiculos, IAFIP, IARBA
    {
        #region Atributos
        protected double _velocidadMaxima;
        #endregion

        #region Metodo

        public Avion(double precio, double velocidadMaxima) : base(precio)
        {
            this._velocidadMaxima = velocidadMaxima;
        }
        

        #region Implementacion de IAFIP
        double IAFIP.CalcularImpuesto()
        {
            double precio = 0;
            if (this._precio > 0)
            {
                precio = this._precio * .33F;
            }
            return precio;
        }
        #endregion

        #region Implementacion de IARBA
        double IARBA.CalcularImpuesto()
        {
            double precio = 0;
            if (this._precio > 0)
            {
                precio = this._precio * .27F;
            }
            return precio;            
        }
        #endregion

        #endregion

    }
}
