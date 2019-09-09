using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06.Entidades
{
    public class Paleta
    {

        #region Atributos

        private Tempera[] _colores;
        private int _cantidadMaximaColores;

        #endregion

        #region Constructores

        //construtores
        //public Paleta():this(5)
        //{
        //    //this.colores = new Tempera[5];
        //    //this.cantidadMaximaColores = 5;
        //}
        //public Paleta(int cantidad)
        //{
        //    this.colores = new Tempera[cantidad];  
        //    this.cantidadMaximaColores = cantidad;
        //}

        //estos const los invoco desde el implicit, no voy a poder hacer mas el new paleta
        private Paleta() : this(5)
        {

        }
        private Paleta(int cantidad)
        {
            this._cantidadMaximaColores = cantidad;
            this._colores = new Tempera[this._cantidadMaximaColores];
        }

        #endregion

        #region Sobrecarga Operadores


        //aca hago el llamado de los const
        public static implicit operator Paleta(int cantidad)
        {
            Paleta pal = new Paleta(cantidad);
            return pal;
        }

        public static explicit operator string(Paleta p)
        {
            return p.Mostrar();
        }

        public static bool operator ==(Paleta p, Tempera t)
        {
            //for(int i = 0; i < p.cantidadMaximaColores; i++)
            //{
            //    if (p.colores.GetValue(i) != null && p.colores[i]==t)
            //    {
            //        return true;
            //    }
            //}
            //return false;

            foreach (Tempera obj in p._colores)
            {
                if (!(Object.Equals(obj, null)) && t == obj)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Paleta p, Tempera t)
        {
            return !(p == t);
        }

        //si temp no esta en paleta se agrega al primer lugar libre
        //si temp esta en paleta se acumula
        public static Paleta operator +(Paleta p, Tempera t)
        {//primero busco si esta la temera. despues uso obvtenelugarlibre cuando sea necesario
            int indice = -1;

            if (p == t)
            {
                indice = p.ObtenerLugarLibre(t);
                if (indice != -1)
                {
                    p._colores[indice] += t;
                }
            }            
            else
            {
                indice = p.ObtenerLugarLibre();
                if (indice != -1)
                {
                    p._colores[indice] = t;
                }
            }
            return p;
        }

        //si la tempera  esa en paleta tengo q restar la cantidades
        //si la resta da cero o menos ese indice queda en null
        //sin no existe no hago nada
        public static Paleta operator -(Paleta p, Tempera t)
        {
            int i;

            for (i = 0; i < p._cantidadMaximaColores; i++)
            {
                if (p._colores[i] == t)
                {
                    p._cantidadMaximaColores -= 1;
                    if (p._cantidadMaximaColores <= 0)
                    {
                        p._colores[i] = null;
                    }
                }
            }
            return p;
            

        }

        //me devuelve el indice de la tempera o -1 si no esta
        public static Paleta operator |(Paleta p, Tempera t)
        {
            int indice=-1;
            if(p == t)
            {
                for (int i= 0; i < p._colores.Length; i++)
                {
                    if (p._colores[i] == t)
                    {
                        indice = i;
                        break;
                    }
                }
            }
            return indice;
        }

        
        #endregion

        #region Metodos

        private string Mostrar()
        {
            string retorna = "\n Cantidad Max: " + this._cantidadMaximaColores + " Tempera: ";
            string agregar = "";
            foreach (Tempera temp in this._colores)
            {
                agregar += temp;
            }
            retorna += agregar;
            return retorna;
        }

        //busca un valor libre y lo retorna
        //retorna -1 en caso contrario
        private int ObtenerLugarLibre()
        {
            int indice = -1;
            for (int i = 0; i < this._cantidadMaximaColores; i++)
            {
                if (this._colores[i] == null)
                {
                    indice = i;
                    break;
                }
            }
            return indice;
        }

        //sobrecargo el metodo ObtenerLugarLibre
        private int ObtenerLugarLibre(Tempera t)
        {
            int indice = -1;
            for(int i = 0; i < this._cantidadMaximaColores; i++)
            {
                if(this._colores.GetValue(i) != null && this._colores[i] == t)
                {
                    indice = i;
                    break;
                }
            }
            return indice;
        }
       
        #endregion
    
    }   

}

    

   

        

