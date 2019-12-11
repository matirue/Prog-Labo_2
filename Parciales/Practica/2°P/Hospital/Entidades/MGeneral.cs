using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class MGeneral : Medico, IMedico
    {
        public override string EstaAtendiendoA
        {
            get
            {
                return base.EstaAtendiendoA;
            }
        }

        public MGeneral(string nombre, string apellido) : base(nombre,apellido)
        {

        }

        protected override void Atender()
        {
            this.numeroAleatorio = new Random();

            Thread.Sleep(numeroAleatorio.Next(1500, 2200));

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
