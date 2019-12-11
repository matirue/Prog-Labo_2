using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PatenteInvalidaException : Exception
    {
        public PatenteInvalidaException(string mensaje) : base(mensaje) { }

        public PatenteInvalidaException(string mensaje, Exception innerException) 
                              : base(mensaje,innerException) { }
    }
}
