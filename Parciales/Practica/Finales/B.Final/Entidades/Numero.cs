using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Diseñar la clase Numero que contendrá una propiedad "Cantidad" que sólo permita asignar un valor al atributo 
    //"_cantidad" y un evento EsImpar(diseñarlo para que reciba un Object y un EventArgs, su retorno será void). 
    //a.Si el valor que se intenta asignar es cero, se deberá lanzar una excepción de tipo ArgumentException, 
    //informando de lo acontecido.
    //Si el valor es par(utilizar lo hecho en el punto 1), dejar asignarlo.
    //Si el valor es impar (utilizar lo hecho en el punto 1) disparar el evento EsImpar cuyo manejador tendrá que 
    //escribir en un archivo de texto(log.txt) la fecha(hh:mm:ss y el valor) y dejar asignarlo.
    //b.Hacer un formulario con un cuadro de texto que reciba una cantidad y asignársela al objeto número, hacer 
    //el manejador de eventos en el formulario que capture el evento EsImpar cuyo manejador tendrá que escribir en un 
    //archivo de texto(log.txt) la fecha(hh:mm:ss y el valor) y asignarlo.
    //c.Realizar una estructura try-catch (por fuera de la propiedad) para la escritura de la propiedad del 
    //punto anterior que, al capturar la excepción, muestre el mensaje.
    public class Numero
    {
        #region Campos
        int _cantidad;

        public event EventHandler EsImpar;
        #endregion

        #region Propiedades
        public int Cantidad
        {
            set
            {
                if(value == 0)
                    throw new ArgumentException("El valor que se intenta asignar es 0");
                else if (value.EsPar())
                    this._cantidad = value;
                else if (value.EsImpar())
                {
                    this._cantidad = value;
                    this.EsImpar(this, new EventArgs());
                }
            }
        }
        #endregion

        #region Metodos
        public Numero() { }

        public Numero(int cantidad) { this.Cantidad = cantidad; }
        #endregion
    }
}
