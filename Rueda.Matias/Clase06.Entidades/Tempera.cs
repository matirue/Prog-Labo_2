using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06.Entidades
{
    public class Tempera
    {
        #region Atributos

        private ConsoleColor color;
        private string marca;
        private int cantidad;

        #endregion

        #region Constructor

        public Tempera(ConsoleColor color, string marca, int cantidad)
        {
            this.color = color;
            this.marca = marca;
            this.cantidad = cantidad;
        }

        #endregion

        #region Metodos

        private string Mostrar()
        {
            return "\n Color: " + this.color + " -- Marca: " + this.marca + " -- Cantidad: " + this.cantidad;
        }

        public static implicit operator string (Tempera obj)
        {
            return obj.Mostrar();
        }

        #endregion

        #region Sobrecarga Operadores

        public static bool operator == (Tempera t1, Tempera t2)
        {
            //if ((t1.marca == t2.marca) && (t1.color == t2.color))
            if ((Object.Equals(t1,null) && Object.Equals(t2,null)) && (t1.marca==t2.marca) && (t1.color == t2.color))            
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator != (Tempera t1, Tempera t2)
        {
            return !(t1 == t2);
        }

        public static Tempera operator +(Tempera t, int cantidad)
        {
            t.cantidad += cantidad;
            return t;
            
        }
        public static Tempera operator +(Tempera t1, Tempera t2)
        {
            if (t1.marca==t2.marca && t1.color==t2.color )
            {
                t1 += t2.cantidad;
            }
            return t1;
        }

        #endregion
    }
}
