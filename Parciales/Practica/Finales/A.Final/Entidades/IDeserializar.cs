using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //IDeserializar(Xml(string, out Deposito):bool) de forma explícita
    public interface IDeserializar
    {
        //bool Xml(string path, out Deposito d);
        bool Xml(string path, out DepositoHeredado d);
    }
}
