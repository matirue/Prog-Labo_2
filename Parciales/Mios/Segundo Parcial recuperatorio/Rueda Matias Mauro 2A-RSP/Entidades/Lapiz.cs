using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;


namespace Entidades
{
    //Lapiz-> color:ConsoleColor(publico); trazo:ETipoTrazo(enum {Fino, Grueso, Medio}; publico); PreciosCuidados->true; 
    //Reutilizar UtilesToString en ToString() (mostrar todos los valores).



    public class Lapiz:Utiles,ISerializa,IDeserializa
    {
        #region Enumerado
        public enum ETipoTrazo { Fino,Grueso,Medio}
        #endregion

        #region Campos
        public ConsoleColor color;
        public ETipoTrazo trazo;
        #endregion

        #region Propiedad
        public override bool PreciosCuidados { get { return true; } }
        #endregion

        #region Constructores
        public Lapiz(ConsoleColor color, ETipoTrazo trazo,string marca, double precio) 
            : base(marca, precio)
        {
            this.color = color;
            this.trazo = trazo;
        }

        public Lapiz() : base() { }
        #endregion

        #region Metodos
        public override string UtilesToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("\n+Lapiz: \nColor: " +this.color.ToString());
            sb.Append(" - Trazo: " + this.trazo.ToString());
            sb.AppendLine(" - Precio cuidado: " + this.PreciosCuidados);

            return sb.ToString();
        }

        public override string ToString()
        {
            return base.UtilesToString()+this.UtilesToString();

        }
        #endregion

        //Implementar (implícitamente) ISerializa lápiz
        //Implementar (explícitamente) IDeserializa en lápiz
        //El archivo .xml guardarlo en el escritorio del cliente con el nombre formado con su apellido.nombre.lapiz.xml
        //Ejemplo: Alumno Juan Pérez -> perez.juan.lapiz.xml,
        #region Implementacion de las interfases
        //public string Path => throw new NotImplementedException();                          
        public string Path => Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RUEDA.MATIAS.lapiz.xml";

        public bool Xml()
        {
            bool retorno = false;

            
            XmlTextWriter xw = null;
            XmlSerializer ser = null;

            try
            {
                xw = new XmlTextWriter(this.Path, Encoding.UTF8);
                ser = new XmlSerializer(typeof(Lapiz));
                ser.Serialize(xw, this);
                retorno = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (xw != null)
                {
                    xw.Close();
                }
            }

            return retorno;
            
        }

        bool IDeserializa.Xml(out Lapiz unLapiz)
        {
            bool retorno = false;
            unLapiz = null;
            
            XmlTextReader xr = null;
            XmlSerializer ser = null;

            try
            {
                xr = new XmlTextReader(this.Path);
                ser = new XmlSerializer(typeof(Lapiz));
                unLapiz = (Lapiz)ser.Deserialize(xr);
                retorno = true;
            }
            catch (Exception ex)
            {

                throw ex;
                
            }
            finally
            {
                if (xr != null)
                {
                    xr.Close();
                }
            }


            return retorno;
        }
        #endregion
    }
}
