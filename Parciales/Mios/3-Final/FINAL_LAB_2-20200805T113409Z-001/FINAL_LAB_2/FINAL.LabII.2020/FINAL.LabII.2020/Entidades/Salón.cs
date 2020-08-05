using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    // Generar la clase genérico Salón. Contiene el atributo elementos:List del tipo genérico.
    // (este sólo se podrá inicializar en el constructor por defécto, que además será privado)
    // y el atributo capacidad:int (generar un constructor público que lo reciba como parámetro).

    //Eventos
    //Agregar en la clase Salón que, si se llego al limite de capacidad, se lance un evento SalonLlenoEvent.
    //Esto mostrará un mensaje en el manejador Salon_SalonLlenoEvent (realizarlo según convenciones).
    //Agregar en la clase Salon que, si el idioma no es español, se lance un evento SalonNoEspañolEvent.
    //Esto mostrará un mensaje en el manejador Salon_SalonNoEspañolEvent (realizarlo según convenciones).

    public delegate void SalonLleno (object o, EventArgs e);
    public delegate void NoEspañol (object o, EventArgs e);

    public class Salon<T> where T : Persona
    {
        List<T> elementos;
        int capacidad;

        public event SalonLleno SalonLlenoEvent;
        public event NoEspañol SalonNoEspañolEvent;
        private EventArgs e = new EventArgs();

        Salon() { this.elementos = new List<T>(); }
        public Salon(int capacidad) : this() { this.capacidad = capacidad; }

        // Sobrecarga en el operador +.
        // Al sumar un Salón con un elemento de tipo Persona, se deberá agregar a la lista de elementos
        // SÓLO si el idioma de la persona es Español y aún hay lugar en el salon.
        //Eventos
        //Agregar en la clase Salón que, si se llego al limite de capacidad, se lance un evento SalonLlenoEvent.
        //Esto mostrará un mensaje en el manejador Salon_SalonLlenoEvent (realizarlo según convenciones).
        //Agregar en la clase Salon que, si el idioma no es español, se lance un evento SalonNoEspañolEvent.
        //Esto mostrará un mensaje en el manejador Salon_SalonNoEspañolEvent (realizarlo según convenciones).
        public static Salon<T> operator +(Salon<T> s, T item)
        {
            if (s.elementos.Count < s.capacidad)
            {
                if (item.idioma == EIdioma.Español)
                    s.elementos.Add(item);
                else
                    s.SalonNoEspañolEvent(s, s.e);
            }
            else
                s.SalonLlenoEvent(s, s.e);
            return s;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nCapacidad: " + this.capacidad);
            sb.AppendFormat("\nLista: \n");
            foreach (T aux in this.elementos)
                sb.AppendLine(aux.ToString());

            return sb.ToString();
        }
    }

    
}
