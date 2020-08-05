using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Xml.Serialization;

namespace Entidades
{
    //AlumnoEgresado (promedio: float; promocion: Short) - ToString():string (polimorfismo; reutilizar código) 
    //Todos los atributos de las clases son públicos y además:
    //que todas las clases poseen un sólo constructor (sin sobrecargas).

    //Implementar en AlumnoEgresado: ISerializar(Xml(string):bool) de forma implícita e 
    //IDeserializar(Xml(string, out AlumnoEgresado):bool) de forma explícita
    public class AlumnoEgresado:Alumno, ISerializar,IDeserializar
    {
        public float promedio;
        public short promocion;
        
        public AlumnoEgresado() : base() { }
        public AlumnoEgresado(Alumno a, float promedio, short promocion)
            :base(new Persona(a.nombre, a.apellido, a.idioma, a.edad), a.legajo, a.nivel)
        {
            this.promedio = promedio;
            this.promocion = promocion;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.ToString());
            sb.AppendFormat("\nPromedio: " + this.promedio + "\nPromocion: " + this.promocion+"\n");
            return sb.ToString();
        }

        public bool Xml(string path)
        {
            StreamWriter sw = null;
            XmlSerializer xSer = null;
            bool retorno = false;
            try
            {
                sw = new StreamWriter(path);
                xSer = new XmlSerializer(typeof(AlumnoEgresado));
                xSer.Serialize(sw, this);
            }
            catch (Exception)
            {
                retorno = false;
            }
            finally { sw.Close(); }

            return retorno;
        }

        public bool Xml(string path, out AlumnoEgresado aEg)
        {
            StreamReader sr = null;
            XmlSerializer xSer;
            bool retorno = false;
            try
            {
                sr = new StreamReader(path);
                xSer = new XmlSerializer(typeof(AlumnoEgresado));
                aEg = (AlumnoEgresado)xSer.Deserialize(sr);
                retorno = true;
            }
            catch (Exception)
            {
                aEg = null;
            }
            finally { sr.Close(); }

            return retorno;
        }
    }
}
