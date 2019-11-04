using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_29.Entidades
{
    public class Equipo
    {
        #region Atributos
        short _cantidadDeJugadores;
        List<Jugador> jugadores;
        string _nombre;
        #endregion

        #region Constructor
        Equipo()
        {
            jugadores = new List<Jugador>();
        }
        public Equipo(short cantidad,string nombre) : this()
        {
            this._cantidadDeJugadores = cantidad;
            this._nombre = nombre;
        }
        #endregion

        #region Operadores
        public static bool operator +(Equipo e, Jugador j)
        {
            if( !(e.jugadores.Contains(j)) && e.jugadores.Count < e._cantidadDeJugadores)
            {
                e.jugadores.Add(j);
                return true;
            }

            return false;
        } 
        #endregion

        public string Mostrar()
        {
            StringBuilder x = new StringBuilder();

            for (int i = 0; i < this.jugadores.Count; i++)
                x.AppendFormat(this.jugadores[i].MostrarDatos());

            return x.ToString();
        }

    }
}
