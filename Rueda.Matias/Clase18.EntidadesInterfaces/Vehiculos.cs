using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase18.EntidadesInterfaces
{
    public abstract class Vehiculos
    {
        #region Atributos
        protected double _precio;
        #endregion

        #region Metodos
        public void MostrarPrecio()
        {
            Console.WriteLine("\n Precio: $" + this._precio);
        }

        public Vehiculos(double precio)
        {
            this._precio = precio;
        }
        #endregion
    }
}
