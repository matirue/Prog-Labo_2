using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente : Persona
    {
        private int turno;
        private static int ultimoTurnoDado;

        public int Turno
        {
            get
            {
                return this.turno;
            }
        }

        static Paciente()
        {
            ultimoTurnoDado = 0;
        }
        
        public Paciente(string nombre, string apellido) : base(nombre,apellido)
        {
            ultimoTurnoDado++;
            this.turno = ultimoTurnoDado;
        }

        public Paciente(string nombre, string apellido, int turno): base(nombre,apellido)
        {
            ultimoTurnoDado = turno;
            this.turno = ultimoTurnoDado;
        }

        public override string ToString()
        {
            string datos = String.Format("Turno Nº{0}: {2}, {1}",this.turno,this.apellido,this.nombre);

            return datos;
        }
    }
}
