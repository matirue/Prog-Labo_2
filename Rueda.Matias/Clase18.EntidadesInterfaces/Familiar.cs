using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase18.EntidadesInterfaces
{
    public class Familiar:Auto
    {
        #region Atributo
        protected int _cantAsientos;
        #endregion

        #region Metodos
        public Familiar(double precio, string patente, int cantidadAsientos) : base(precio, patente)
        {
            this._cantAsientos = cantidadAsientos;
        }
        #endregion
    }
}
