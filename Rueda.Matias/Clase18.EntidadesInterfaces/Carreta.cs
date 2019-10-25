using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase18.EntidadesInterfaces
{
    public class Carreta:Vehiculos,IARBA
    {
        #region Metodo
        public Carreta(double precio) : base(precio)
        {
        }

        #region Implementacion de IARBA
        double IARBA.CalcularImpuesto()
        {
            double precio = 0;
            if (this._precio > 0)
            {
                precio = this._precio * .18F;
            }
            return precio;
        }
        #endregion
        #endregion
    }
}
