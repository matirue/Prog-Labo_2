using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;
using System.IO;


namespace Entidades
{
    //Crear la clase Deposito que contenga nombre(protected; string) y productos(protected; lista genérica de tipo 
    //Producto), como atributos, y como método Add(agrega un elemento a la lista). 


    [Serializable]
    public class Deposito : IGuardarXML
    {
        #region Campos
        protected string nombre;
        protected List<Producto> productos;
        public int capacidad;
        #endregion

        #region Metodos
        public Deposito() : this("ninguno", 3) { }
        public Deposito(string nombre, int capacidad)
        {
            this.productos = new List<Producto>();
            this.nombre = nombre;
            this.capacidad = capacidad;
        }

        public void Add(Producto p)
        {
            if (this.productos.Count() < this.capacidad)
                this.productos.Add(p);
        }

        //Se debe poder sumar los dos depósitos(con la sobrecarga de un operador en la clase Depósito) retornando
        //una nueva lista con la suma de los Productos, (recordar que, si un producto está en las dos listas, 
        //se debe sumar el stock y no agregar dos veces al mismo producto).
        public static List<Producto> operator +(Deposito d1, Deposito d2)
        {
            Deposito aux = new Deposito("", d1.capacidad + d2.capacidad);
            foreach (Producto p1 in d1.productos)
                aux.Add(new Producto(p1.Nombre, p1.Stock));

            foreach (Producto p2 in d2.productos)
            {
                bool existe = false;
                foreach (Producto aux1 in aux.productos)
                {
                    if (aux1 == p2)
                    {
                        aux1.Stock += p2.Stock;
                        existe = true;
                    }
                }
                if (existe == false)
                    aux.Add(new Producto(p2.Nombre, p2.Stock));
            }

            return aux.productos;
        }


        //Crear la interface IGuardarXML { bool SerializarXML(); }. Implementarla en la clase Deposito.
        //La instancia de tipo Deposito tendrá, al menos, un objeto de tipo Producto, otro de tipo ProdImpuesto, 
        //otro de tipo ProdExport y otro de tipo ProdVendido) y generar una serialización XML del depósito.
        //Modificando lo que crea conveniente para poder serializar todos los atributos de todos los objetos intervinientes, 
        //guardando en el archivo archivo.xml.
        public bool SerializarXML()
        {
            try
            {
                StreamWriter escribir = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\deposito.xml", false);
                XmlSerializer ser;
                ser = new XmlSerializer(typeof(Deposito));
                ser.Serialize(escribir, this);
                escribir.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
    }
}
