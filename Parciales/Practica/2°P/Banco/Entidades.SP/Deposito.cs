using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades.SP
{
    [XmlInclude(typeof(DepositoHeredado))]
    public class Deposito
    {
        public Producto[] productos;

        public Deposito() : this(3)
        { }

        public Deposito(int cantidad)
        { productos = new Producto[cantidad]; }

        public static Producto[] operator +(Deposito a, Deposito b)
        {
            Producto[] c = new Producto[1];
            int cont = 0;
            int indice = 0;
            foreach (Producto i in a.productos)
            {
                if (c.Length <= cont)
                    Array.Resize(ref c, cont + 1);

                if (ObtenerIndice(c, i) != -1)
                {
                    c[ObtenerIndice(c, i)].stock += i.stock;
                    cont--;
                }
                else
                { 
                    c[cont] = i;                    
                }
                if (indice == a.productos.Length - 2)
                    cont--;
                cont++;
                indice++;
            }
            indice = 0;            
            foreach (Producto i in b.productos)
            {
                if (c.Length <= cont)
                    Array.Resize(ref c, cont + 1);

                if (ObtenerIndice(c, i) != -1)
                {
                    c[ObtenerIndice(c, i)].stock += i.stock;
                    cont--;
                    
                }
                else {
                    c[cont] = i;                    
                }
                if (indice == b.productos.Length - 2)
                    cont--;
                cont++;
                indice++;
            }            

            return c;
        }

        public static int ObtenerIndice(Producto[] array, Producto item)
        {
            int indice = -1;
            int i = 0;
            
            foreach (Producto prod in array)
            {
                if (prod != null)
                {
                    if (prod.nombre == item.nombre)
                    {
                        indice = i;
                        break;
                    }
                    i++; 
                }
                
            }
            return indice;
        }
    }
}
