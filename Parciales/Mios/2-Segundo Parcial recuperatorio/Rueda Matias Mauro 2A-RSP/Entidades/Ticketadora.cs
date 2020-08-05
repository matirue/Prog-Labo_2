using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    //Crear el manejador necesario para que, una vez capturado el evento, se imprima en un archivo de texto: 
    //la fecha (con hora, minutos y segundos) y el total de la cartuchera (en un nuevo renglón). 
    //Se deben acumular los mensajes. El archivo se guardará con el nombre tickets.log en la carpeta 'Mis documentos' del cliente.
    //El manejador de eventos (c_gomas_EventoPrecio) invocará al método (de clase) 
    //ImprimirTicket (se alojará en la clase Ticketeadora), que retorna un booleano indicando si se pudo escribir o no
    public class Ticketadora
    {
        public static bool ImprimirTicket(double precioTotal)
        {
            bool retorno = false;

            try
            {
                StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\tickets.log", true);
                sw.WriteLine(DateTime.Now);
                sw.WriteLine("Precio Total :$" + precioTotal);

                sw.Close();
                retorno = true;
            }
            catch (Exception)
            {

            }


            return retorno;
        }
        
        




    }
}
