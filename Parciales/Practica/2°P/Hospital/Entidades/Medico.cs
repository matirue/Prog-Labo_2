using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public delegate void FinAtencionPaciente(Paciente paciente, Medico medico);

    public abstract class Medico : Persona
    {
       
        public event FinAtencionPaciente AtencionFinalizada;

        private Paciente pacienteActual;
        protected static Random tiempoAleatorio;
        protected Thread hilo;
        protected Random numeroAleatorio;

        #region Propiedades

        public Paciente AtenderA
        {
            set
            {
                this.pacienteActual = value;
            }
        }

        public virtual string EstaAtendiendoA
        {
            get
            {
                return this.pacienteActual.ToString();
            }
        }

        #endregion

        #region Método

        protected abstract void Atender();

        protected void FinalizarAtencion()
        {
            this.AtencionFinalizada(this.pacienteActual,this); // Lanzo el evento del paciente actual y la instancia de médico
            this.pacienteActual = null;
            this.hilo.Abort(); // Finalizo el hilo del paciente atendido
        }

        static Medico()
        {
            tiempoAleatorio = new Random();            
        }

        public Medico(string nombre, string apellido) : base(nombre,apellido)
        {

        }

     

        #endregion


    }
}
