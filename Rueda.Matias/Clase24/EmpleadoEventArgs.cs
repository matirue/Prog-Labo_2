using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase24
{
    public class EmpleadoEventArgs : EventArgs
    {
        
        //prop autocontenida
        public double SueldoAsignado
        {
            get;
            set;
        }

    }
}
