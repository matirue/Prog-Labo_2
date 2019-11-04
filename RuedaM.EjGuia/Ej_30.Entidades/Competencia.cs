using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_30.Entidades
{
    public class Competencia
    {
        #region Campos
        short _cantidadCompetidores;
        short _cantidadVueltas;
        List<AutoF1> _competidores;
        #endregion

        #region Metodos

        public string MostrarDatos()
        {
            StringBuilder x = new StringBuilder();
            for (int i = 0; i < this._competidores.Count; i++)
            {
                x.Append(this._competidores[i].MostrarDatos());
            }

            return x.ToString();
        }


        #region Const
        Competencia()
        {
            this._competidores = new List<AutoF1>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
        {
            this._cantidadVueltas = cantidadVueltas;
            this._cantidadCompetidores = cantidadCompetidores;
        }
        #endregion

        #region Ope
        public static bool operator ==(Competencia c, AutoF1 a)
        {
            foreach(AutoF1 x in c._competidores)
            {
                if (x == a)
                {
                    return true;
                    break;
                }
            }
            return false;
        }
        public static bool operator !=(Competencia c, AutoF1 a){ return !(c == a); }

        public static bool operator -(Competencia c, AutoF1 a)
        {

            if (c._competidores.Contains(a))
            {                
                a.EnCompetencia = false;
                a.VueltasRestantes = 0;
                a.CantidadDeCombustible = 0;
                c._competidores.Remove(a);

                return true;
            }

            return false;
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            Random RandomCombustible = new Random();

            if (c._competidores.Count < c._cantidadCompetidores && c != a)
            {
                a.EnCompetencia = true;
                a.VueltasRestantes = c._cantidadVueltas;
                a.CantidadDeCombustible = (short)RandomCombustible.Next(15, 100);
                c._competidores.Add(a);
                return true;
            }

            return false;
        }
        #endregion

        #endregion
    }
}
