using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class MEspecialista : Medico, IMedico
    {
        public enum Especialidad
        {
            Traumatologo,
            Odontologo
        };

        private Especialidad especialidad;

        public override string EstaAtendiendoA
        {
            get
            {
                return base.EstaAtendiendoA;
            }
        }

        public MEspecialista(string nombre, string apellido, Especialidad especialidad) : base(nombre,apellido)
        {
            this.especialidad = especialidad;
        }

        protected override void Atender()
        {
            this.numeroAleatorio = new Random();

            Thread.Sleep(numeroAleatorio.Next(5000, 10000));

            this.FinalizarAtencion();
        }


        public void IniciarAtencion(Paciente paciente)
        {
            this.hilo = new Thread(Atender);
            base.AtenderA = paciente;
            hilo.Start();
        }
    }
}
