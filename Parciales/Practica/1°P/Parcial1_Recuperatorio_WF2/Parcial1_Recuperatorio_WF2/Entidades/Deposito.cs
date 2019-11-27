using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Deposito
  {

        #region Atributos
        public List<Producto> productos;
        #endregion


        #region Constructores
        /// <summary>
        /// Constructor por defecto que inicializara la cantidad de productos con 3
        /// </summary>
        public Deposito() : this(3)
        {

        }

        /// <summary>
        /// Constructor que inicializara con los parametros pasados
        /// </summary>
        /// <param name="cantidadProductos">Cantidad de productos a inicializar</param>
        public Deposito(int cantidadProductos)
        {
          productos = new List<Producto>(cantidadProductos);
        }
        #endregion


        #region Sobrecargas

        //Se debe poder sumar las listas de los dos depósitos (con la sobrecarga de un operador en la clase Deposito) 
        //y guardar el valor que retorna en una lista de Productos, recordar que si un producto está en las dos listas, 
        //se debe sumar el stock y no agregar dos veces al mismo producto.
        public static List<Producto> operator +(Deposito a, Deposito b)
        {
          //Creamos nueva lista
          List<Producto> nuevaLista = new List<Producto>();

          foreach(Producto p1 in a.productos)
          {
            foreach(Producto p2 in b.productos)
            {
              if(p1.nombre == p2.nombre)
              {
                p1.stock += p2.stock;
              }
              else
              {
                nuevaLista.Add(p2);
              }
            }

            nuevaLista.Add(p1);
          }

          return nuevaLista;
        }
            #endregion


        #region Metodos

        /// <summary>
        /// Metodo para ordenar en orden alfabetico.
        /// </summary>
        /// <param name="d1"></param>
        public static void OrdenarAlfabetico(Deposito d1)
        {
            d1.productos.Sort((p, q) => string.Compare(p.nombre, q.nombre));
        }

        /// <summary>
        /// Metodo para ordenar de forma ascendente.
        /// </summary>
        /// <param name="d1"></param>
        public static void OrdenarAscendente(Deposito d1)
        {
            d1.productos.Sort((p, q) => p.stock.CompareTo(q.stock));
        }

        #endregion

    }
}
