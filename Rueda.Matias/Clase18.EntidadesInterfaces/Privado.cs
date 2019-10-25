using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase18.EntidadesInterfaces
{
    public class Privado:Avion
    {
        #region Atributo
        protected int _valoracionServicioDeAbordo;
        #endregion

        #region Metodos
        public Privado(double precio, double velocidad, int valoracion) : base(precio, velocidad)
        {
            this._valoracionServicioDeAbordo = valoracion;
        }
        #endregion
    }
}
