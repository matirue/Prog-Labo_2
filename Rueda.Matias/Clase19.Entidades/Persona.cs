using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase19.Entidades
{
    public class Persona
    {
        #region Atributos
        public string nombre;
        public string apellido;

        private int _edad;
        private List<String> _apodo;
        #endregion

        #region Construtor
        public Persona(string nombre, string apellido, int edad):this()
        {
            this.nombre = nombre;
            this.apellido = apellido;

            this._edad = edad;

        }
        public Persona()
        {
            this._apodo = new List<string>();
        }//constructor por default para evitar la exception
        #endregion

        //porpiedad de lec y esc necesario si o si para los atributos privas sean cargados
        //no guarda si la prop es solo lec o esc
        public int GetEdad
        {
            get { return this._edad; }
            set { value = this._edad; }
        }

        //con cualquier coleccion alcanza que la prop sea solo lectura
        public List<String>  GetList{ get { return this._apodo; } }

        public override string ToString()
        {
            return "Persona: " + this.apellido + ", " + this.nombre + " ->EDAD:" + this.GetEdad + " // Apodo: " + this.GetList;
        }
    }
}
