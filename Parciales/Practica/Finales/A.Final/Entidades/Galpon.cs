using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Generar la clase genérica Galpon. Dicha clase tendrá el atributo _elementos:List del tipo genérico.
    //(este sólo se podrá inicializar en el constructor por defecto, que además será privado)
    //y _capacidad:int (generar un constructor que lo reciba como parámetros).      

    public delegate void DelPares(object o, EventArgs e);

    public class Galpon<T>
    {
        #region Campos
        List<T> _elemntos;
        int _capacidad;

        public event DelPares ElementosPares;
        private EventArgs e = new EventArgs();
        #endregion

        #region Metodos
        Galpon() { this._elemntos = new List<T>(); }
        public Galpon(int cantidad) : this() { this._capacidad = cantidad; }

        //Realizar el método Add, que permite agregar un elemento a la colección. 
        //Cada elemento par agregado en la clase Galpon, disparará un evento (ElementosParesEvent).
        //Asociar el manejador del evento anterior a un método de instancia del formulario. 
        public void Add(T item)
        {
            if (this._elemntos.Count < this._capacidad)
            {
                this._elemntos.Add(item);

                if ((this._elemntos.Count % 2) == 0)
                    ElementosPares(this, this.e);

            }
        }


        //Mostrar en dicho manejador las características por MessageBox.
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nCapacidad: " + this._capacidad);
            sb.AppendFormat("\nLista: \n");
            foreach (T aux in this._elemntos)
                sb.AppendLine(aux.ToString());

            return sb.ToString();
        }
        #endregion
    }
}
