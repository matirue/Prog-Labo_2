using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Extencion
    {
        public static string InformarNovedad(this CartucheraLlenaException e) { return e.Message; }
    }
}
