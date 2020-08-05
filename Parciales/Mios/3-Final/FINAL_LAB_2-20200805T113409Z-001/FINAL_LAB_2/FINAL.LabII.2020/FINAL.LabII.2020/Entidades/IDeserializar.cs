using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //IDeserializar(Xml(string, out AlumnoEgresado):bool)
    public interface IDeserializar
    {
        bool Xml(string path, out AlumnoEgresado aEg);
    }
}
