using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrograma02
{//acordate de que la clase y programa deben tener el mismo modificador en este caso publico ambos
    public class Sello
    {
        //atributo
        //si no es public y static no aparece cuando haga el llamado en main
        public static string mensaje;
        public static ConsoleColor color; //consolecolor es un enumerado de los colores que puede aplicar en la caomputadora

        


        //metodos
        public static string Imprimir()
        {
            return Sello.ArmarFormatoMensaje();
        }
        public static void Borrar()
        {
            Sello.mensaje = "";
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
                
        }

        private static string ArmarFormatoMensaje()
        {
            int cantidad;
            string mensajeNuevo="";
            
            cantidad=Sello.mensaje.Length+2;

            for(int i = 0; i < cantidad; i++)
            {
                mensajeNuevo+="*";
            }
            mensajeNuevo += "\n*"+ Sello.mensaje + "*\n" + mensajeNuevo;

            return mensajeNuevo  ;
        }
    }
}
