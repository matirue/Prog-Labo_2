using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades.SP
{
    
    public class DepositoHeredado : Deposito , ISerializar , IDeserializar
    {
        public Producto[] Productos
        {
            get { return base.productos; }
            set { base.productos = value; }
        }
        public DepositoHeredado()
            : base()
        { }

        public bool Xml(string path)
        {
            bool retorno = false;
            try
            {
                XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8);
                XmlSerializer seri = new XmlSerializer(typeof(DepositoHeredado));
                seri.Serialize(writer, this);
                writer.Close();
                retorno = true;
            }
            catch (XmlException e)
            { }

            return retorno;
        }



        bool IDeserializar.Xml(string path, out DepositoHeredado d)
        {
            bool retorno = false;
            try
            {
                XmlTextReader reader = new XmlTextReader(path);
                XmlSerializer seri = new XmlSerializer(typeof(DepositoHeredado));
                d = (DepositoHeredado)seri.Deserialize(reader);
                reader.Close();
                retorno = true;
            }
            catch (XmlException)
            { d = null; }
            return retorno;      
        }
    }
}
