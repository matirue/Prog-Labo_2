using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//IDeserializar -> Xml(string, out Fruta):bool

namespace Entidades
{
    public interface IDeserializar
    {
        bool Xml(string path, out Fruta f);
    }
}
