using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_29.Entidades
{
    public class Jugador
    {
        #region Atributo
        int _dni;
        string _nombre;
        int _partidosJuados;
        float _promedioGoles;
        int _totalGoles;

        #endregion

        #region Constructor
        Jugador()
        {
            this._dni = 0;
            this._nombre = " ";
            this._partidosJuados = 0;
            this._promedioGoles = 0;
            this._totalGoles = 0;
        }
        public Jugador(int dni, string nombre):this()
        {
            this._dni = dni;
            this._nombre = nombre;
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni,nombre)
        {
            this._totalGoles = totalGoles;
            this._partidosJuados=totalPartidos;
        }
        #endregion

        #region Prop
        public float GetPromedioGoles
        {
            get
            {
                if (this._partidosJuados > 0)                
                    this._promedioGoles = ((float)this._totalGoles / (float)this._partidosJuados);                
                else
                    this._promedioGoles = 0;

                return this._promedioGoles;
            }
        }
        #endregion

        #region Operadores
        public static bool operator == (Jugador j1, Jugador j2)
        {
            if(!Object.Equals(j1, null) && !Object.Equals(j2, null))
            {
                if (j1._dni == j2._dni)
                    return true;
            }

            return false;
        }
        public static bool operator !=(Jugador j1, Jugador j2) { return !(j1 == j2); }
        #endregion

        #region Metodos
        public string MostrarDatos()
        {
            StringBuilder x = new StringBuilder();
            x.AppendFormat("\n----------------------------------------------------------");
            x.AppendFormat("\nNombre: " + this._nombre);
            x.AppendFormat("\nDNI: " + this._dni);
            x.AppendFormat("\nTotal Goles: " + this._totalGoles);
            x.AppendFormat("\nPartidos Jugados: " + this._partidosJuados);
            x.AppendFormat("\nPromedio Goles: " + this._promedioGoles);
            x.AppendFormat("\n----------------------------------------------------------");

            return x.ToString();
        }
        #endregion
    }
}
