using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Serialization;
using System.IO;

//Manzana-> _provinciaOrigen:string (protegido); Nombre:string (prop. s/l, retornará 'Manzana'); 
//Reutilizar FrutaToString en ToString() (mostrar todos los valores). TieneCarozo->true

//Implementar (implicitamente) ISerializar en Cajon y manzana
//Implementar (explicitamente) IDeserializar en manzana
namespace Entidades
{
    public class Manzana : Fruta, ISerializar, IDeserializar
    {
        protected string _provinciaOrigen;

        public string Nombre { get { return "Manzana"; } }
        
        public string ProvinciaOrigen
        {
            get { return this._provinciaOrigen; }
            set { this._provinciaOrigen = value; }            
        }

        public override bool TieneCarozo{ get { return true; } }

        public Manzana() : base(null, 0) { }

        public Manzana(string color, double peso, string provinciaOrigen) 
            : base(color, peso)
        {
            this._provinciaOrigen = provinciaOrigen;
        }


        protected override string FrutaToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.FrutaToString());
            sb.AppendFormat("Provincia Origen: {0}", this.ProvinciaOrigen);

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.FrutaToString();
        }



        public bool Xml(string path)
        {
            string path2 = @"\" + path;

            bool retorno = false;

            //XmlTextWriter xw = null;
            StreamWriter sw = null;
            try
            {
                XmlSerializer sr = new XmlSerializer(typeof(Manzana));
                //xw = new XmlTextWriter((Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + path2), Encoding.UTF8);
                //sr.Serialize(xw, this);

                sw = new StreamWriter((Environment.GetFolderPath(Environment.SpecialFolder.Desktop)) + path2);
                sr.Serialize(sw, this);

                retorno = true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                //if(xw!=null)
                //xw.Close();

                if (sw != null)
                {
                    //retorno = true;
                    sw.Close();
                }

            }


            return retorno;
        }


        bool IDeserializar.Xml(string path, out Fruta f)
        {
            bool retono = false;
            string path2 = @"\" + path;
            f = null;
            try
            {
                XmlSerializer sr = new XmlSerializer(typeof(Manzana));
                XmlTextReader xr = new XmlTextReader(((Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + path2)));
                f = (Manzana)sr.Deserialize(xr);
                xr.Close();
                retono = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return retono;
        }
    }
}
