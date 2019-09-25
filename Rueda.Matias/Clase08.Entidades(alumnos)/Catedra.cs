using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase08.Entidades_alumnos_
{
    public class Catedra
    {
        #region Atributo
        //private List<Alumnos> alumnos;
        List<Alumnos> alumnos = new List<Alumnos>();
        #endregion

        #region Propiedad
        public List<Alumnos> Alumnos { get { return this.alumnos; } }
        #endregion

        #region Metodos

        #region Constructor

        public Catedra()
        {
           // this.alumnos = new List<Alumnos>();
        }

        #endregion

        #region Sobrecargas
        public static bool operator ==(Catedra c, Alumnos a)
        {
            if(!Object.Equals(c,null) && !Object.Equals(a, null))
            {
                //for(int i = 0; i < c.alumnos.Count; i++)
                //{
                //    if (c.alumnos[i] == a)
                //    {
                //        return true;
                //    }
                //}
                foreach (Alumnos alum in c.alumnos)
                {
                    if (alum == a)
                    {
                        return true;                        
                    }
                }
            }            
            return false;
        }
        public static bool operator !=(Catedra c, Alumnos a)
        {
            return !(c == a);
        }

        public static bool operator +(Catedra c, Alumnos a)
        {
            if (c != a)
            {
                c.alumnos.Add(a);
                return true;
            }
            return false;
        }
        public static bool operator -(Catedra c, Alumnos a)
        {
            if (c == a)
            {
                c.alumnos.Remove(a);
                return true;
            }
            return false;
        }

        public static int operator |(Alumnos a, Catedra c)
        {
            for(int i = 0; i < c.alumnos.Count; i++)
            {
                if (c.alumnos[i] == a)
                {
                    return i;
                    break;
                }
            }
            return -1;
        }
        #endregion

        public override string ToString()
        {
            string cad = " ";
            for(int i = 0; i < this.alumnos.Count; i++)
            {
                cad += this.alumnos[i].Tostring();
            }
            return cad;
        }

        #endregion
    }
}
