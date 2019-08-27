using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracCasaClase
{//acordate de q la clase y programa el mismo modificador, en este caso public ambos
    public class MiClass
    {
        //atributos
        //si no es public y static no aparece cuando haga el llamando en main
        public static string mensaje;
        public static ConsoleColor color;

        //metodos
        public static string Imprimir()
        {
            return MiClass.ArmarFormatoMensaje();
        }

        public static void Borrar()
        {
            MiClass.mensaje = "";
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = MiClass.color;
        }

        private static string ArmarFormatoMensaje()
        {
            int cantidad;
            string mensajeNuevo = "";

            cantidad = MiClass.mensaje.Length + 2;

            for(int i = 0; i < cantidad; i++)
            {
                mensajeNuevo += "*";
            }

            mensajeNuevo += "\n*" + MiClass.mensaje + "*\n" + mensajeNuevo;

            return mensajeNuevo;
        }
    }
}
