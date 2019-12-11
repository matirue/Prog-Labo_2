using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Parcial
{
    public partial class frmRSP : Form
    {
        List<Persona> _corredores;
        List<Thread> _corredoresActivos;
        bool _hayGanador;

        public frmRSP()
        {
            InitializeComponent();
            this._corredores = new List<Persona>();
            this._corredoresActivos = new List<Thread>();
            this._corredores.Add(new Persona("Fernando", 9, Corredor.Carril.Carril_1));
            this._corredores.Add(new Persona("Fernando", 9, Corredor.Carril.Carril_2));
            this._hayGanador = false;
        }

        public delegate void CorrenCallback(int avance, Corredor corredor);
        void PersonaCorriendo(int avance, Corredor corredor)
        {
            if (pgbCarril1.InvokeRequired || pgbCarril2.InvokeRequired)
            {
                CorrenCallback d = new CorrenCallback(PersonaCorriendo);
                this.Invoke(d, new object[] { avance, corredor });
            }
            else
            {
                if (corredor.CarrilElegido == Corredor.Carril.Carril_1)
                {
                    AnalizarCarrera(pgbCarril1, avance, corredor);
                }
                else if (corredor.CarrilElegido == Corredor.Carril.Carril_2)
                {
                    AnalizarCarrera(pgbCarril2, avance, corredor);
                }
            }
        }

        private void btnCorrer_Click(object sender, EventArgs e)
        {
            foreach (Persona corredor in this._corredores)
            {
                corredor.Corriendo += PersonaCorriendo;
                Thread hilo = new Thread(corredor.Correr);
                hilo.Start();
            }
        }

        void AnalizarCarrera(ProgressBar carril, int avance, Corredor corredor)
        {
            if (corredor.CarrilElegido == Corredor.Carril.Carril_1)
            {
                if ((pgbCarril1.Value + avance) < 100)
                {
                    pgbCarril1.Value += avance;
                }
                else
                {
                    pgbCarril1.Value = 100;
                    this._hayGanador = true;
                    HayGanador(corredor);
                }
            }
            else if (corredor.CarrilElegido == Corredor.Carril.Carril_2)
            {
                if ((pgbCarril2.Value + avance) < 100)
                {
                    pgbCarril2.Value += avance;
                }
                else
                {
                    pgbCarril2.Value = 100;
                    this._hayGanador = true;
                    HayGanador(corredor);
                }
            }
        }

        void HayGanador(Corredor corredor)
        {
            foreach (Thread hilo in this._corredoresActivos)
            {
                hilo.Abort();
            }
            MessageBox.Show("Ha ganado el corredor del carril " + corredor.CarrilElegido + "!");
            LimpiarCarriles();
        }

        void LimpiarCarriles()
        {
            pgbCarril1.Value = 0;
            pgbCarril2.Value = 0;
        }
    }
}
