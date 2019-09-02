using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase04.Entidades
{
    public class Cosa
    {
        private int entero;
        private string cadena;
        private DateTime fecha;

        public string Mostrar()
        {
            return $"{this.entero} - {this.cadena} - {this.fecha}\n";
        }

        //sobrecarga de metodos
        public void EstablecerValor(int entero)
        {
            this.entero = entero;
        }
        public void EstablecerValor(string cadena)
        {
            this.cadena = cadena;
        }
        public void EstablecerValor(DateTime fecha)
        {
            this.fecha=fecha;
        }

        //construcor
        public Cosa()
        {
            this.entero = -1;
            this.cadena = "Sin Valor";
            this.fecha = DateTime.Now;
        }
        public Cosa(string cadena):this() // :this() solo para constructores, llama  al constructor anterior
        {                                 // cargando cadena
            this.cadena = cadena;
        }
        //llama al const anterior pasando cadena con this, y cargando fecha
        public Cosa(string cadena, DateTime fecha):this(cadena)
        {
            this.fecha = fecha;
        }
        //lo mismo q antes, this llama cargando cadena y fecha, y el cosntr carga el entero
        public Cosa(string cadena, DateTime fecha, int entero):this(cadena,fecha)
        {
            this.entero = entero;
        }
    }
}
