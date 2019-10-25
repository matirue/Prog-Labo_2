using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase18.EntidadesInterfaces
{
    public class Deportivo : Auto, IAFIP, IARBA
    {
        #region Atributo
        protected int _caballoFuerza;
        #endregion

        #region Metodos
        public Deportivo(double precio,string patente,int hp) : base(precio, patente)
        {
            this._caballoFuerza = hp;
        }


        #region Implementacion de IAFIP
        double IAFIP.CalcularImpuesto()
        {
            double precio=0;
            if (this._precio > 0)
            {
                precio = this._precio * .28F;
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
                precio = this._precio * .23F;
            }
            return precio;
        }
        #endregion

        #endregion
    }
}
