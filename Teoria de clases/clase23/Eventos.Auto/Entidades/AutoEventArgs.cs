using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutoEventArgs : EventArgs
    {
        private double _restoCombustible;

        public double CombustibleEnElTanque          
        {
            get
            {
                return this._restoCombustible;
            }
            set
            {
                this._restoCombustible = value;
            }

        }
    }
}
