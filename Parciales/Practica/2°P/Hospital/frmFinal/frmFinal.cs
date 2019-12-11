using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Threading;

namespace frmFinal
{
    public partial class frmFinal : Form
    {
        private delegate void AtencionPaciente(object sender, EventArgs e);

        private MEspecialista medicoEspecialista;
        private MGeneral medicoGeneral;
        private Thread mocker;
        private Queue<Paciente> pacienteEnEspera;
        private Paciente paciente;

        public frmFinal()
        {
            InitializeComponent();
            this.medicoGeneral = new MGeneral("Luis", "Salinas");
            this.medicoEspecialista = new MEspecialista("Jorge", "Iglesias", MEspecialista.Especialidad.Traumatologo);
            this.pacienteEnEspera = new Queue<Paciente>();
        }

        private void frmFinal_Load(object sender, EventArgs e)
        {
            this.mocker = new Thread(this.MockPacientes);
            this.mocker.Start();
            this.medicoGeneral.AtencionFinalizada += this.FinAtencion;
            this.medicoEspecialista.AtencionFinalizada += this.FinAtencion;
        }

        private void frmFinal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.mocker.IsAlive)
            {
                this.mocker.Abort();
            }
        }

        private void MockPacientes()
        {
            this.pacienteEnEspera.Enqueue(new Paciente("Pepito", "Gonzalez", 1));
            Thread.Sleep(5000);
            this.pacienteEnEspera.Enqueue(new Paciente("Juan Carlos", "Pérez", 2));
            Thread.Sleep(5000);
            this.pacienteEnEspera.Enqueue(new Paciente("Manuelita", "Pepas",4));
            Thread.Sleep(5000);
            this.pacienteEnEspera.Enqueue(new Paciente("Juancito", "Lopez", 3));
            Thread.Sleep(5000);
        }

        private void AtenderPacientes(IMedico iMedico)
        {
            paciente = this.pacienteEnEspera.Dequeue();

            iMedico.IniciarAtencion(paciente);
            MessageBox.Show(String.Format("Está atendiendo a {0}", ((Medico)iMedico).EstaAtendiendoA));
        }

        private void FinAtencion(Paciente paciente, Medico medico)
        {
            string mensaje = String.Format("Finalizó la atención de {0} por {1}!", paciente.ToString(), medico.ToString());

            if (this.InvokeRequired)
            {
                FinAtencionPaciente delegado = new FinAtencionPaciente(this.FinAtencion);
                object[] parametros = new object[] { paciente, medico };

                this.BeginInvoke(delegado, parametros);
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }

        private void btnMedicoGral_Click(object sender, EventArgs e)
        {
            if (this.pacienteEnEspera.Count > 0)
            {
                this.AtenderPacientes(this.medicoGeneral);
            }
        }

        private void btnMedicoEsp_Click(object sender, EventArgs e)
        {
            

            if (this.pacienteEnEspera.Count > 0)
            {
                this.AtenderPacientes(this.medicoEspecialista);
            }
        }
    }
}
