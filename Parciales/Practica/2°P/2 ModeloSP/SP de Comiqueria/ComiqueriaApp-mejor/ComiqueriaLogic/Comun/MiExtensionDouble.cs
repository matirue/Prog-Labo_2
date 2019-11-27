using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic.Comun
{
    public static class MiExtensionDouble
    {
        public static string FormatearPrecio(this Double numero)
        {
            string aux = String.Format("{0:0.00}", numero);
            return String.Format("${0}", aux);
        }
    }
}
