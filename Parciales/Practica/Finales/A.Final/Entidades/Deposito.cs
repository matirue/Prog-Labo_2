using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Crear dos objetos de tipo Deposito, cada uno de estos objetos contiene un Array de la clase Producto.
    //Un constructor por default (inicializa en 3 productos) y una sobrecarga que reciba la cantidad de productos 
    //del depósito (REUTILIZAR CODIGO).     
    
    
    public class Deposito
    {
        #region Campos
        Producto[] productos;
        #endregion

        #region Propiedades
        public Producto[] Productos
        {
            get { return this.productos; }
            set { this.productos = value; }
        }
        #endregion

        #region Metodos
        public Deposito() : this(3) { }
        public Deposito(int cantidad) { this.productos = new Producto[cantidad]; }

        //Se debe poder sumar los Array de los dos depósitos (con la sobrecarga de un operador en la clase Deposito) y guardar 
        //el valor que retorna en un Array de Productos, recordar que si un producto está en los dos Arrays, 
        //se debe sumar el stock y no agregar dos veces al mismo producto.
        public static Producto[] operator +(Deposito d1, Deposito d2)
        {
            Producto[] auxProducto1 = new Producto[3];
            Producto auxProducto2;

            int indice1 = 0;
            int indice2 = 0;

            foreach (Producto i in d1.productos)
            {
                if ((auxProducto1 == i) == -1)
                {
                    auxProducto1[indice1] = i;
                    indice1++;
                }
                else
                {
                    indice2 = (auxProducto1 == i);
                    auxProducto2 = new Producto(i.Nombre, auxProducto1[indice2].Stock + i.Stock);
                    auxProducto1[indice2] = auxProducto2;
                }
            }
            foreach (Producto i in d2.productos)
            {
                if ((auxProducto1 == i) == -1)
                {
                    auxProducto1[indice1] = i;
                    indice1++;
                }
                else
                {
                    indice2 = (auxProducto1 == i);
                    auxProducto2 = new Producto(i.Nombre, auxProducto1[indice2].Stock + i.Stock);
                    auxProducto1[indice2] = auxProducto2;
                }

            }
            return auxProducto1;
        }

        //Mostrar el contenido del array resultante (nombre y stock)
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Producto aux in this.productos)
                sb.AppendLine(aux.ToString());
            return sb.ToString();
        }

        #endregion
    }
}
