using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic.Comun
{
    public interface IArchivoTexto
    {
        string Ruta { get; }
        string Texto { get; }
    }
}
