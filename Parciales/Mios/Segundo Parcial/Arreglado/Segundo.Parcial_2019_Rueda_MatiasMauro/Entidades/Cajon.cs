using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Xml;
using System.Xml.Serialization;
using System.IO;

//Crear la clase Cajon<T>

//atributos: _capacidad:int, _elementos:List<T> y _precioUnitario:double (todos protegidos)        

//Propiedades
//Elementos:(sólo lectura) expone al atributo de tipo List<T>.
//PrecioTotal:(sólo lectura) retorna el precio total del cajón (precio * cantidad de elementos).

//Constructor
//Cajon(), Cajon(int), Cajon(double, int); 
//El por default: es el único que se encargará de inicializar la lista.

//Métodos
//ToString: Mostrará en formato de tipo string, la capacidad, la cantidad total de elementos,
//el precio total y el listado de todos los elementos contenidos en el cajón. Reutilizar código.

//Sobrecarga de operador
//(+) Será el encargado de agregar elementos al cajón, siempre y cuando no supere la capacidad del mismo.

//Implementar (implicitamente) ISerializar en Cajon y manzana

namespace Entidades
{
    public delegate void PrecioExcedido(double precioTotal);

    public class Cajon<T>:ISerializar
    {
        protected int _capacidad;
        protected List<T> _elementos;
        protected double _precioUnitario;

        public event PrecioExcedido eventoPrecio;

        public List<T> Elementos { get { return this._elementos; } }

        public double PrecioTotal { get { return (this._precioUnitario * this._elementos.Count); } }

        public Cajon()
        {
            this._elementos = new List<T>();
        }

        public Cajon(int capacidad) : this()
        {
            this._capacidad = capacidad;
        }

        public Cajon(double precioUnitario, int capacidad) : this(capacidad)
        {
            this._precioUnitario = precioUnitario;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Capacidad: {0}\n", this._capacidad);
            sb.AppendFormat("Cantidad total de elementos: {0}\n", this._elementos.Count);
            sb.AppendFormat("Precio Total: ${0}\n", this.PrecioTotal);

            foreach (T item in this._elementos)
            {
                if (item != null)
                {
                    sb.AppendLine(item.ToString());
                }
            }
            return sb.ToString();
        }

        public static Cajon<T> operator +(Cajon<T> cajon, T item)
        {
            if (cajon._elementos.Count + 1 <= cajon._capacidad)
            {
                if (cajon.PrecioTotal <= 55)
                {
                    cajon._elementos.Add(item);
                }
                else
                {
                    cajon.eventoPrecio.Invoke(cajon.PrecioTotal);
                }
            }

            else
            {
                throw new CajonLlenoException("El cajon esta lleno");

            }
            return cajon;
        }

        public bool Xml(string path)
        {
            string path2 = @"\" + path;
            bool retorno = false;
            //XmlTextWriter xw = null;
            StreamWriter sw = null;

            try
            {
                XmlSerializer sr = new XmlSerializer(typeof(Cajon<T>));
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
                //if (xw != null)
                //    xw.Close();
                if (sw != null)
                {
                    //retorno = true;
                    sw.Close();
                }
                    
            }


            return retorno;
        }


        //Manejador
        //public void manejadorTexto(object sender)
        //{
        //    try
        //    {
        //        using (StreamWriter sm = new StreamWriter("manejadorTexo.txt", false))
        //        {
        //            sm.WriteLine(sender.ToString());
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //}

        //Agregar un método de extensión a la clase Cajon que:
        //Reciba como parámetro un entero (será usado como valor del campo ID)
        //Elimine de la base de datos la fruta cuyo ID coincida con el parámetro recibido
        //Retorne un booleano que indique: 
        //TRUE, si se ha eliminado la fruta. 
        //FALSE, si no se elimino.
        //Excepción, si se probocó algún error en la base de datos


    }
}
