using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad
{
    public class AulaLlenaException : Exception
    {
        public AulaLlenaException(string mensaje)
            : base(mensaje)
        {
        }
    }
}
