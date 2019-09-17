using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06.Entidades.V1
{
    public class Tempera
    {
        #region ATRIBUTOS

        private ConsoleColor _color;
        private string _marca;
        private int _cantidad;

        #endregion

        #region Propiedades
        //para retornar atributos y lo puedo tomar por el form uso prop
        //public Tempera miTempera
        //{
        //    get
        //    {
        //        return this._color;
        //    }
        //    //set;
        //}
        public ConsoleColor GetColor {
            get
            {
                return this._color;
            }
        }

        public string GetMarca
        {
            get
            {
                return this._marca;
            }

        }

        public int GetCantidad
        {
            get
            {
                return this._cantidad;
            }
        }
#endregion


        #region CONSTRUCTOR

        public Tempera(ConsoleColor color, string marca, int cantidad)
        {
            this._color = color;
            this._marca = marca;
            this._cantidad = cantidad;
        }

        #endregion

        #region METODOS

        //muestro las temperas
        private string Mostrar()
        {
            return " - Marca: " + this._marca + "\n - Color: " + this._color + "\n - Cantidad: " + this._cantidad + "\n\n   --------------------   \n\n";
        }

        public static implicit operator string (Tempera temp)
        {
            if (!Object.Equals(temp, null))
            {
                return temp.Mostrar();
            }
            else
            {
                return "\n*******No hay tempera*******\n";
            }
        }

        #endregion

        #region SOBRECARGAS

        public static bool operator == (Tempera temp1, Tempera temp2)
        {
            if( !Object.Equals(temp1,null) && !Object.Equals(temp2,null))
            {
                if(temp1._color==temp2._color && temp1._marca == temp2._marca)
                {
                    return true;
                }
                return false;
            }
            else
            {
                return Object.Equals(temp1, temp2);//compara si son iguales
            }
            
        }
        public static bool operator !=(Tempera temp1, Tempera temp2)
        {
            return !(temp1 == temp2);

        }

        public static Tempera operator +(Tempera temp, int cantidad)
        {
            if (!Object.Equals(temp, null))
            {
                if (temp._cantidad <= 0)
                {
                    return null;
                }
                else
                {
                    temp._cantidad += cantidad;
                    return temp;
                }
            }
            return temp;
        }
        public static Tempera operator +(Tempera temp1, Tempera temp2)
        {
            if (temp1 == temp2)
            {
                return (temp1 += temp2._cantidad);
            }
            else
            {
                return temp1;
            }
        }

        public static Tempera operator -(Tempera temp1, Tempera temp2)
        {
            if (temp1 == temp2)
            {
                
                temp1._cantidad -= temp2._cantidad;
                if (temp1._cantidad <= 0)
                {
                    temp1 = null;
                    return temp1;
                }
                return temp1;

            }
            else
            {
                return temp1;
            }

        }

        #endregion
    }
}
