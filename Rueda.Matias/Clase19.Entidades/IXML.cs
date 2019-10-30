using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clase19.Entidades
{
    public interface IXML
    {
        bool Guardar(string cad);
        bool Leer(string cad, out object obj);
    }
}
