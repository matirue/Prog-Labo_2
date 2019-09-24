using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase08.Entidades_alumnos_
{
    public class Alumnos
    {
        #region Attributos
        protected string apellido;
        protected ETipoExamen examen;
        protected int legajo;
        protected string nombre;
        #endregion

        #region Propiedades

        public string Apellido { get { return this.apellido; } }
        public ETipoExamen Examen { get { return this.examen; } }
        public int Legajo { get { return this.legajo; } }
        public string Nombre { get { return this.nombre; } }

        #endregion

        #region Metodos

        #region Constructor
        public Alumnos (string nombre,string apellido, int legajo,ETipoExamen examen)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.examen = examen;
        }
        #endregion

        public static string Mostrar (Alumnos a)
        {
            return "\n Alumno: " + a.apellido + ", " + a.nombre + " -- Legajo: " + a.legajo + " -- Exaen: " + a.examen;
        }

        #region Sobrecarga
        public static bool operator ==(Alumnos a, Alumnos b)
        {
            if (!Object.Equals(a, null) && !Object.Equals(a, null))
            {
                if (a.legajo == b.legajo)
                   return true;                
                else
                    return false;                
            }
            else
                return false;
            
        }
        public static bool operator !=(Alumnos a, Alumnos b)
        {
            return !(a == b);            
        }

        #endregion

        #region Ordenadores
        public static int OrdenarPorApelidoAsc(Alumnos a, Alumnos b)
        {
            //return a.apellido.CompareTo(b.apellido);
            return String.Compare(a.apellido, b.apellido); //devuelve un entero positivo si b>a
        }
        public static int OrdenarPorApellidoDesc(Alumnos a, Alumnos b)
        {
            //return b.apellido.CompareTo(a.apellido);
            return -1 * Alumnos.OrdenarPorApelidoAsc(a, b); 
        }
                
        public static int OrdenarPorLegajoAsc(Alumnos a, Alumnos b)
        {
            return String.Compare(a.legajo.ToString(), b.legajo.ToString());
        }
        public static int OrdenarPorLegajoADesc(Alumnos a, Alumnos b)
        {
            return -1 * Alumnos.OrdenarPorLegajoAsc(a, b);
        }
        #endregion

        #endregion
    }
}
