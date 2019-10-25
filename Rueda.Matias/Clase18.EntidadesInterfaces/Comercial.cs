using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase18.EntidadesInterfaces
{
    public class Comercial:Avion, IARBA
    {
        #region Atributo
        protected int _cantidadPasajeros;
        #endregion

        #region Metodos
        public Comercial(double precio, double velocidad, int pasajeros) : base(precio, velocidad)
        {
            this._cantidadPasajeros = pasajeros;
        }

        #region Implementacion de IARBA
        double IARBA.CalcularImpuesto()
        {
            double precio = 0;
            if (this._precio > 0)
            {
                precio = this._precio * .25F;
            }
            return precio;
        }
        #endregion

        #endregion
    }
}
