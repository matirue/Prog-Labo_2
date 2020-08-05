using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Xml.Serialization;

namespace Entidades
{
    //Crear la clase DepositoHeredado, que derive de Desposito y que implemente: 
    //ISerializar(Xml(string):bool) de forma implicita y
    //IDeserializar(Xml(string, out Deposito):bool) de forma explícita
    public class DepositoHeredado : Deposito, ISerializar, IDeserializar
    {
        public DepositoHeredado() : base() { }

        #region Interface
        public bool Xml(string path)
        {
            StreamWriter sw = null;
            XmlSerializer xSer = null;
            bool retorno = false;
            try
            {
                sw = new StreamWriter(path);
                xSer = new XmlSerializer(typeof(DepositoHeredado));
                xSer.Serialize(sw, this);
            }
            catch (Exception)
            {
                retorno = false;
            }
            finally { sw.Close(); }

            return retorno;
        }


        bool IDeserializar.Xml(string path, out DepositoHeredado d)
        {
            StreamReader sr = null;
            XmlSerializer xSer;
            bool retorno = false;
            try
            {
                sr = new StreamReader(path);
                xSer = new XmlSerializer(typeof(DepositoHeredado));
                d = (DepositoHeredado)xSer.Deserialize(sr);
                retorno = true;
            }
            catch (Exception)
            {
                d = null;
            }
            finally { sr.Close(); }

            return retorno;
        }
        #endregion
    }
}
