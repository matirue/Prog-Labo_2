using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase08.Entidades_alumnos_
{
    public class AlumnoCalificado:Alumnos
    {
        #region Atributos
        protected double nota;
        #endregion

        #region Propiedades
        public double Nota { get { return this.nota; } }

        #endregion

        #region Metodos

        #region Constructor
        //public AlumnoCalificado(string nombre, string apellido, int legajo, ETipoExamen examen, double nota) : base(nombre, apellido, legajo, examen)
        //{
        //    this.nota = nota;
        //}
        //public AlumnoCalificado(Alumnos a, double nota):this(a.Nombre,a.Apellido,a.Legajo,a.Examen,nota)
        //{
        //}
        public AlumnoCalificado(string nombre, string apellido, int legajo, ETipoExamen examen, double nota) 
            : this(new Alumnos(nombre, apellido, legajo, examen),nota)
        {
            
        }
        public AlumnoCalificado(Alumnos a, double nota) : base(a.Nombre, a.Apellido, a.Legajo, a.Examen)
        {
            this.nota = nota;
        }
        #endregion

        public string Mostrar()
        {
            return Alumnos.Mostrar(this) + " -- Nota: " + this.nota;
            //return " -- Nota: " + this.nota;
        }
        public override string Tostring()
        {
            return base.ToString() + this.Mostrar();
        }



        #endregion
    }
}
