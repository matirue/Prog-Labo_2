using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-----------XML--------------------
using System.Xml.Serialization;
using System.Xml;
using System.IO;
//----------------------------------

using Clase19.Entidades;

namespace Clase19.test
{
    public class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------------------------------------------
            Persona per = new Persona("asd", "QWE", 10);
            Persona per1 = new Persona("rty", "ZXC", 20);
            Persona per2 = new Persona("uio", "BNM", 30);
            Persona per3 = new Persona("ujn", "PLK", 40);
            Console.WriteLine(per+"\n");
            //---------------------------------------------------------------------//
            //para serializar
            
            try
            {

                //el type es la clase del obj q va a señalizar, lo tiene q conocer de antemano
                //la clase debe ser publica
                XmlSerializer objXml = new XmlSerializer(typeof(Persona));
                //necesita un constructor por default xq sino tira una excepcion

                StreamWriter objStreamWriter = new StreamWriter(@"C:\Pruebas\archivo2.xml");

                objXml.Serialize(objStreamWriter, per);

                objStreamWriter.Close();
                
            }
            catch (Exception e)
            {
                
                Console.WriteLine(e.Message);
            }
            

            //para deserealizar
            try
            {
                XmlSerializer objXml = new XmlSerializer(typeof(Persona));

                StreamReader lectura = new StreamReader(@"C:\Pruebas\archivo2.xml");
                Persona p2=(Persona)objXml.Deserialize(lectura);//me devuelve un object con el objeto de tipo persona encapsulado
                Console.WriteLine("----------------------\n\n"+p2.ToString());
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            try
            {

                List<Persona> ltsPersona = new List<Persona>();


                ltsPersona.Add(per1);
                ltsPersona.Add(per2);
                ltsPersona.Add(per3);

                XmlSerializer objXml = new XmlSerializer(typeof(Persona));                

                StreamWriter objStreamWriter = new StreamWriter(@"C:\Pruebas\archivo2.xml");

                objXml.Serialize(objStreamWriter, ltsPersona);

                objStreamWriter.Close();


            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
