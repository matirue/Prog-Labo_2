using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        #region Atributos

        private string _apellido;
        private int _legajo;
        private string _nombre;
        private float _nota;

        #endregion

        #region Propiedades

        public string Aperllido
        {
            get { return this._apellido; }
            set { _apellido = value; }
        }
        public int Legajo
        {
            get { return this._legajo; }
            set { _legajo = value; }
        }
        public string Nombre
        {
            get { return this._nombre; }
            set { _nombre = value; }
        }
        public float Nota
        {
            get { return this._nota; }
            set { _nota = value; }
        }

        #endregion

        #region Constructor

        public Alumno(int legajo, string nombre, string apellido)
        {
            this._legajo = legajo;
            this._nombre = nombre;
            this._apellido = apellido;
        }
        public Alumno(string apellido, string nombre, int legajo)
            : this(legajo, nombre, apellido)
        {

        }
        public Alumno(string nombre, int legajo, string apellido)
            : this(legajo, nombre, apellido)
        {

        }
        public Alumno() : this(0, null, null)
        {

        }

        #endregion

        #region Metodos

        //metodo de instancia mostrar
        private string Mostrar()
        {
            return " + " + this.Aperllido + ", " + this.Nombre + " - Legajo: " + this.Legajo +
                      " - Nota: " + this.Nota + "\n";
        }

        //llama al privado
        public static string Mostrar(Alumno a)
        {
            return a.Mostrar();
        }

        #endregion

        #region Operadores

        public static bool operator ==(Alumno a1, Alumno a2)
        {
            bool flag = false;
            if(Object.Equals(a1,null) && Object.Equals(a2, null))
            {
                if (a1._legajo == a2._legajo)
                    flag = true;                
            }
            return flag;            
        }
        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return !(a1 == a2);
        }

        #endregion
        
    }
}
