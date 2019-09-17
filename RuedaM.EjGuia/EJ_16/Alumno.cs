using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_16
{
    class Alumno
    {
        #region Atributos
        private byte _nota1;
        private byte _nota2;
        private float _notaFinal;

        public string apellido;
        public int legajo;
        public string nombre;
        #endregion

        #region Constructor
        public Alumno (string apellid, string nombre, int legajo)
        {
            this.nombre = apellid;
            this.apellido = nombre;
            this.legajo = legajo;
        }
        #endregion

        #region Metodos
        public void CalcularFinal()
        {
            if(this._nota1 >= 4 && this._nota2 >= 4)
            {
                Random nf = new Random();
                this._notaFinal = nf.Next(4, 10);
                

            }
            else
            {
                this._notaFinal = -1;
            }
        }

        public void  Estudiar(byte notaUno,byte notaDos)
        {
            this._nota1 = notaUno;
            this._nota2 = notaDos;
        } 

        public string Mostrar()
        {
            string retorno= "\n --> Alumno: " + this.apellido + " " + this.nombre + "\n --> Legajo: " + this.legajo + "\n  -> 1°Nota: " + this._nota1 + "\n  -> 2°Nota: "+this._nota2;

            CalcularFinal();

            if (this._notaFinal != -1)
            {
                retorno += "\n  --->Nota Final: " + this._notaFinal;
                
            }
            else
            {
                retorno += "\n  --->  Alumno Desaprobado";
                
            }

            return retorno;
        }
        #endregion
    }
}
