using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase24
{
    public class Empleado
    {
        #region Campos
        string nombre;
        string apelido;
        int legajo;
        double sueldo;

        //instancia del evento que usa al delegado
        public event LimiteSueldoDelegado limiteSueldo;

        public event LimiteSueldoMejoradoDel limiteSueldoMejor;



        #endregion


        public Empleado(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apelido = apellido;
            this.legajo = legajo;
        }

        #region Prop
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string Apellido
        {
            get { return this.apelido; }
            set { this.apelido = value; }
        }
        public int  Legajo
        {
            get { return this.legajo; }
            set { this.legajo = value; }
        }

        public double Sueldo
        {
            get { return this.sueldo; }
            set
            {//aplicacion el evento

                //this.sueldo = value;
                if (value >= 18000 && value <30000)
                    this.limiteSueldo(value, this);//disparo el evento
                else if (value >= 30000)
                {
                    EmpleadoEventArgs e = new EmpleadoEventArgs(); //genero el valor
                    e.SueldoAsignado = value;//le asigno el valor
                    this.limiteSueldoMejor(this, e);//disparo el evento
                }
                else
                    this.sueldo = value;
            }
        }
        
        
        #endregion

        #region Metodos
        public override string ToString()
        {
            return "Legajos: " + this.Legajo + " - Empleado: " + this.Apellido + ", " + this.Nombre;
        }


        #endregion
    }
}
