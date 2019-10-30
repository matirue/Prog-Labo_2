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
            #region En clase
            /***
             
            //---------------------------------------------------------------------
            Persona per = new Persona("asd", "QWE", 10);
            Console.WriteLine(per + "\n");

            Persona per1 = new Persona("rty", "ZXC", 20);
            Persona per2 = new Persona("uio", "BNM", 30);
            Persona per3 = new Persona("ujn", "PLK", 40);

            //List<Persona> ltsPersona = new List<Persona>();
            //per1.GetApodos.Add("ap1");
            //ltsPersona.Add(per1);
            //per2.GetApodos.Add("ap2");
            //ltsPersona.Add(per2);
            //per3.GetApodos.Add("ap3");
            //ltsPersona.Add(per3);

            Console.WriteLine("\n Autos: ");
            Auto a1 = new Auto("auto_A", 123456);
            Auto a2 = new Auto("auto_B", 654321);

            Console.WriteLine(a1.ToString() + "\n");


            Object a3 = new Auto();
            //---------------------------------------------------------------------//
            //para serializar

            try
            {

                //el type es la clase del obj q va a señalizar, lo tiene q conocer de antemano
                //la clase debe ser publica
                XmlSerializer objXmlSer = new XmlSerializer(typeof(Persona));

                //necesita un constructor por default xq sino tira una excepcion
                //TextWriter tw = new StreamWriter(@"C:\Users\Matias\Desktop\Carpeta de prueba\Clase19\archPersona.xml");
                TextWriter tw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+ @"\\Carpeta de prueba\Clase19\archPersona.xml");

                objXmlSer.Serialize(tw, per);

                tw.Close();
                
            }
            catch (Exception e)
            {
                
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\n------------------------------------------------------------------------\n\n");
            //para deserealizar
            try
            {
                XmlSerializer objXmlSer = new XmlSerializer(typeof(Persona));

                //TextReader tr = new StreamReader(@"C:\Users\Matias\Desktop\Carpeta de prueba\Clase19\archPersona.xml");
                TextReader tr = new StringReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\\Carpeta de prueba\Clase19\\archPersona.xml");

                Object objPer = (Persona)objXmlSer.Deserialize(tr);//me devuelve un object con el objeto de tipo persona encapsulado
                Console.WriteLine(objPer.ToString());
                tr.Close();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\n------------------------------------------------------------------------\n\n");

            try
            {

                List<Persona> ltsPersona = new List<Persona>();
                per1.GetApodos.Add("ap1");
                ltsPersona.Add(per1);
                per2.GetApodos.Add("ap2");
                ltsPersona.Add(per2);
                per3.GetApodos.Add("ap3");
                ltsPersona.Add(per3);

                XmlSerializer objXmlSer = new XmlSerializer(typeof(List<Persona>));                

                //TextWriter tw = new StreamWriter(@"C:\Users\Matias\Desktop\Carpeta de prueba\Clase19\archPersona.xml");
                TextWriter tw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+ @"\\Carpeta de prueba\Clase19\archPersona.xml");

                objXmlSer.Serialize(tw, ltsPersona);

                tw.Close();

                //TextReader tr = new StringReader(@"C:\Users\Matias\Desktop\Carpeta de prueba\Clase19\archPersona.xml");
                TextReader tr = new StringReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\\Carpeta de prueba\Clase19\\archPersona.xml");

                foreach (Persona p in (List<Persona>)objXmlSer.Deserialize(tr))
                {
                    Console.WriteLine(p.ToString());
                }
                tr.Close();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\n------------------------------------------------------------------------\n\n");

            //Serializacion 

            Serializador.Serializar(a1);

            Serializador.Deserializar(a1, out a3);
            //Console.WriteLine(" Deserializado -> " + a3.ToString());

            ***/

            #endregion

            #region Mejorado

            Persona p1 = new Persona("asd", "QWE", 10);
            Persona p2 = new Persona("rty", "ZXC", 20);
            Persona p3 = new Persona("uio", "BNM", 30);

            Alumno al1 = new Alumno("aaa", "QQQ", 21, 7);
            Alumno al2 = new Alumno("sss", "WWW", 22, 8);
            Alumno al3 = new Alumno("ddd", "EEE", 23, 9);

            Empleado e1 = new Empleado("zzz", "XXX", 24, 100, 11111);
            Empleado e2 = new Empleado("ccc", "VVV", 25, 101, 22222);
            Empleado e3 = new Empleado("bbb", "NNN", 26, 102, 33333);

            List<Persona> ltsPersona = new List<Persona>();
            p1.GetApodos.Add("1apodo1");
            p2.GetApodos.Add("2apodo2");
            p3.GetApodos.Add("3apodo3");

            ltsPersona.Add(p1);
            ltsPersona.Add(p2);
            ltsPersona.Add(p3);

            ltsPersona.Add(al1);
            ltsPersona.Add(al2);
            ltsPersona.Add(al3);

            ltsPersona.Add(e1);
            ltsPersona.Add(e2);
            ltsPersona.Add(e3);

            try
            {
                

                XmlSerializer objXmlSer = new XmlSerializer(typeof(List<Persona>));

                TextWriter tw = new StreamWriter(@"C:\Users\Matias\Desktop\Carpeta de prueba\Clase19\3archivo3.xml");
                //TextWriter tw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\Carpeta de prueba\\Clase19\\2archivo2.xml");
                //TextWriter tw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\1archivo1.xml");

                objXmlSer.Serialize(tw, ltsPersona);
                tw.Close();

                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }

            try
            {
                List<Persona> ltsAux = new List<Persona>();
                XmlSerializer objXmlSer = new XmlSerializer(typeof(List<Persona>));

                TextReader tr = new StreamReader(@"C:\Users\Matias\Desktop\Carpeta de prueba\Clase19\3archivo3.xml");
                //TextReader tr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\Carpeta de prueba\\Clase19\\2archivo2.xml");
                //TextReader tr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\1archivo1.xml");
                ltsAux = (List<Persona>)objXmlSer.Deserialize(tr);

                Console.WriteLine("\n-----------------------------------------------------------------------");

                foreach (Persona p in ltsAux)
                {
                    Console.WriteLine(p.ToString());
                }
                tr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            #endregion
            Console.ReadKey();
        }
    }
}
