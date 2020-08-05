using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    //Implementar (implícitamente) ISerializa lápiz
    //Implementar (explícitamente) IDeserializa en lápiz
    //El archivo .xml guardarlo en el escritorio del cliente con el nombre formado con su apellido.nombre.lapiz.xml
    //Ejemplo: Alumno Juan Pérez -> perez.juan.lapiz.xml
    public interface IDeserializa
    {
        bool Xml(out Lapiz unLapiz);
    }
}
