using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_30.Entidades
{
    public class AutoF1
    {
        #region Campos
        short _cantidadCombustible;
        bool _enCompetencia;
        string _escuderia;
        short _numero;
        short _vueltasRestantes;
        #endregion

        #region  Metodos

        #region Prop
        public short CantidadDeCombustible
        {
            get { return this._cantidadCombustible; }
            set { this._cantidadCombustible = value; }
        }

        public bool EnCompetencia
        {
            get { return this._enCompetencia; }
            set { this._enCompetencia = value; }
        }

        public short VueltasRestantes
        {
            get { return this._vueltasRestantes; }
            set { this._vueltasRestantes = value; }
        }
        #endregion

        public string MostrarDatos()
        {
            StringBuilder x = new StringBuilder();
            x.AppendFormat("\n----------------------------------------");
            x.AppendFormat("\n->Numero: " + this._numero);
            x.AppendFormat("\n->Escuderia: " + this._escuderia);

            x.AppendFormat("\n->¿En competencia: ");
            if (this._enCompetencia == true)
                x.Append(" SI ");
            else
                x.Append(" NO ");

            x.AppendFormat("\n->Combustible: " + this._cantidadCombustible);
            x.AppendFormat("\n->Vueltas: " + this._vueltasRestantes);
            x.AppendFormat("\n----------------------------------------\n");

            return x.ToString();

        }

        #region Constructor
        AutoF1()
        {
            this._enCompetencia = false;
            this._cantidadCombustible = 0;
            this._vueltasRestantes = 0;
        }
        public AutoF1(short numero, string escuderia):this()
        {
            this._numero = numero;
            this._escuderia = escuderia;
        }
        #endregion

        #region Op

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            if(!Object.Equals(a1,null) && !Object.Equals(a2, null))
            {
                if (a1._numero == a2._numero && a1._escuderia == a2._escuderia)
                    return true;
            }

            return false;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2) { return !(a1 == a2); }

        #endregion

        #endregion
    }
}
