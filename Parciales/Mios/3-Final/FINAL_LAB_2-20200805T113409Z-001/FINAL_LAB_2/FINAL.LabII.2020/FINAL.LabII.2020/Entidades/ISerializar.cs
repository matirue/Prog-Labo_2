using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //ISerializar(Xml(string):bool) de forma implícita
    public interface ISerializar
    {
        bool Xml(string path);
    }
}
