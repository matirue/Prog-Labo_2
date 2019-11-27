using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Materia
    {
        #region Atributo

        private List<Alumno> _alumnos;
        private EMateria _nombre;
        private static Random _notaParaUnAlumno;

        #endregion

        #region Propiedades

        public List<Alumno> Alumnos
        {
            get { return this._alumnos; }
            set { _alumnos = value; }
        }
        public EMateria Nombre
        {
            get { return this._nombre; }
            set { _nombre = value; }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// encargado de, utilizando el atributo de tipo Random, colocar una nota aleatoria a cada alumno de la materia.
        /// </summary>
        public void CalificarAlumnos()
        {            
            for(int i = 0; i < this.Alumnos.Count; i++)
            {
                this.Alumnos[i].Nota = Materia._notaParaUnAlumno.Next(1, 10);
            }
        }

        /// <summary>
        /// retornará en un string el contenido de sus atributos
        /// </summary>
        /// <returns></returns>
        private string Mostrar()
        {
            StringBuilder x = new StringBuilder();
            x.AppendLine("Materia: " + this._nombre.ToString());
            x.AppendLine("************************************");
            x.AppendLine("**************ALUMNOS***************");

            foreach (Alumno a in this.Alumnos)
            {
                x.AppendLine(Alumno.Mostrar(a));
            }

            x.AppendLine(" ");

            return x.ToString();
        }

        #endregion        

        #region Constructores

        //const de clase
        static Materia()
        {
            Materia._notaParaUnAlumno = new Random();
        }

        //constructor por defecto privado y de instancia
        private  Materia()
        {
            this._alumnos = new List<Alumno>();
        }        

        private Materia(EMateria nombre):this()
        {
            this._nombre = nombre;
        }

        #endregion

        #region Operadores

        /// <summary>
        /// retornará una materia cuyo nombre sea el recibido por parámetro.
        /// </summary>
        /// <param name="nombre"></param>
        public static implicit operator Materia(EMateria nombre)
        {
            return new Materia(nombre);
        }

        /// <summary>
        /// retornará el promedio de todas las notas de sus alumnos.
        /// </summary>
        /// <param name="m"></param>
        public static implicit operator float(Materia m)
        {
            float notas = 0;
            int cantidadAlumnos = 0;

            foreach (Alumno a in m.Alumnos)
            {
                notas += a.Nota;
                cantidadAlumnos++;
            }

            return (notas / cantidadAlumnos);
        }

        /// <summary>
        /// retornará un string con el contenido completo de la materia.
        /// </summary>
        /// <param name="materia"></param>
        public static explicit operator string(Materia materia)
        {
            return "\n" + materia.Mostrar();
        }

        /// <summary>
        /// retornará true, si es que el alumno se encuentra en la lista de alumnos, false, caso contrario.
        /// </summary>
        /// <param name="m"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Materia m,Alumno a)
        {
            if(!Object.Equals(m,null) && !Object.Equals(a, null))
            {
                foreach(Alumno x in m.Alumnos)
                {
                    if (x == a)
                        return true;
                }
            }
            return false;
        }
        public static bool operator !=(Materia m, Alumno a)
        {
            return !(m == a);

        }

        /// <summary>
        /// retornará una materia con el agregado de un alumno, siempre y cuando dicho alumno no se encuentre en el listado.
        /// </summary>
        /// <param name="m"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Materia operator +(Materia m, Alumno a)
        {
            if (m != a)
            {
                Console.WriteLine(" Se agregó un alumno a la materia " + m.Nombre.ToString() + "!!!");
                m.Alumnos.Add(a);
            }
            else
            {
                Console.WriteLine(" El alumno ya esta en la materia " + m.Nombre.ToString() + "!!!");
            }

            return m;
        }
        /// <summary>
        /// retornará una materia sin el alumno, siempre y cuando el alumno se encuentre en el listado.
        /// </summary>
        /// <param name="m"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Materia operator -(Materia m, Alumno a)
        {
            if (m == a)
            {
                Console.WriteLine(" Se quitó un alumno a la materia " + m.Nombre.ToString() + "!!!");
                m.Alumnos.Remove(a);
            }
            else
            {
                Console.WriteLine(" El alumno no está en la materia " + m.Nombre.ToString() + "!!!");
            }

            return m;
        }

        #endregion
    }
}
