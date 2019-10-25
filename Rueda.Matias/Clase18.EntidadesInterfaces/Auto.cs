using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase18.EntidadesInterfaces
{
    public abstract class Auto:Vehiculos
    {
        #region Atributos
        protected string _patente;
        #endregion

        #region Metodos
        public Auto(double precio, string patente) : base(precio)
        {
            this._patente = patente;
        }

        public void MostrarPatente()
        {
            Console.WriteLine("\n Patente: " + this._patente);
        }
        #endregion
    }
}
