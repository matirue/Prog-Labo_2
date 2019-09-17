using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06.Entidades.V1
{
    public class Paleta
    {
        #region ATRIBUTOS

        private Tempera[] _colores;
        private int _cantidadMaximaColores;

        #endregion

        #region INDEXEADOR
        //indexeador
        public Tempera this[int index]
        {
            get
            {//LECTURA
                return this._colores[index];
            }
            set
            {//ESCRITURA
                this._colores[index] = value;
            }
        }
        //propiedad
        //public Tempera[] MiTempera
        //{
        //    get { return _colores; }
        //    set { _colores = value; }
        //}
        #endregion

        #region CONSTRUCTOR

        private Paleta() : this(5)
        {

        }
        private Paleta(int cantidad)
        {
            this._cantidadMaximaColores = cantidad;
            this._colores = new Tempera[cantidad];
        }

        #endregion
        
        #region METODOS

        public static implicit operator Paleta (int cantidad)
        {
            if (cantidad > 0)
            {
                Paleta pal = new Paleta(cantidad);
                return pal;
            }
            else
            {
                return null;
            }
        }

        private string Mostrar()
        {
            string cad = string.Format(" Cantidad de colores: " + this._cantidadMaximaColores + " ");

            for (int i = 0; i < this._cantidadMaximaColores; i++)
            {
                cad += (string)this._colores[i];
            }
            //foreach(Tempera temp in this._colores)
            //{
            //    cad += temp;
            //}
            return cad;
        }

        public static explicit operator string (Paleta pal)
        {
            return pal.Mostrar();
        }

        private int ObtenerLugarLibre()
        {
            int indice=-1;
            for(int i = 0; i < this._colores.Length; i++)
            {
                if (Object.Equals(this._colores[i], null))
                {  //retorno el indice y salgo
                    indice = i;
                    break;
                }
            }
            return indice;
        }

        #endregion

        #region SOBRECARGA

        public static bool operator == (Paleta pal, Tempera temp)
        {
            if(!Object.Equals(pal,null) && !Object.Equals(temp, null))
            {
                foreach(Tempera t in pal._colores)
                {
                    if (t == temp)
                    {
                        return true;
                    }
                }
            }
            else
            {
                return Object.Equals(pal, temp);
            }
            return false;
        }
        public static bool operator !=(Paleta pal, Tempera temp)
        {
            return !(pal == temp);
        }

        public static Paleta operator +(Paleta pal, Tempera temp)
        {
            if (pal != temp)
            {
                if (pal.ObtenerLugarLibre() != 1)
                {
                    pal._colores[pal.ObtenerLugarLibre()] = temp;
                }
                return pal;
            }
            else
            {
                for(int i = 0; i < pal._colores.Length; i++)
                {
                    if (pal._colores[i] == temp)
                    {
                        pal._colores[i] += pal._colores[i];
                        return pal;
                    }
                }
                return pal;
            }
        }
        public static Paleta operator -(Paleta pal, Tempera temp)
        {
            if (pal == temp)
            {
                if(temp==pal._colores[pal | temp])
                {
                    if( (pal._colores[pal | temp]+ -1)==null)
                    {
                        return pal;
                    }
                }
            }
            return pal;
        }
        public static int operator | (Paleta pal, Tempera temp)
        {
            int indice = -1;

            if (pal == temp)
            {
                for(int i = 0; i < pal._colores.Length; i++)
                {
                    if (pal._colores[i] == temp)
                    {
                        indice = i;
                        break;
                    }
                }
            }
            return indice;
        }


        #endregion
    }
}
