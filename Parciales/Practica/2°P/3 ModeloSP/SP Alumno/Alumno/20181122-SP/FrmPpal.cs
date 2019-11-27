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
using Archivos;
using System.Threading;
using Patentes;

namespace _20181122_SP
{
    public partial class FrmPpal : Form
    {
        Queue<Patente> cola;
        List<Thread> hilos;

        public FrmPpal()
        {
            InitializeComponent();
            hilos = new List<Thread>();
            this.cola = new Queue<Patente>();
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {
            vistaPatente1.finExposicion += ProximaPatente;
            vistaPatente2.finExposicion += ProximaPatente;
        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            FinalizarSimulacion();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            try
            {
                List<Patente> lista;
                new Xml<List<Patente>>().Leer(@"C:\zzz\patentes.xml", out lista);
                cola = new Queue<Patente>(lista.AsEnumerable().Reverse());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            IniciarSimulacion();
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            try
            {
                new Texto().Leer(@"C:\zzz\patentes.txt", out cola);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            IniciarSimulacion();
        }

        private void btnSql_Click(object sender, EventArgs e)
        {
            try
            {
                Sql sql = new Sql();
                sql.Leer("Patentes", out cola);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            IniciarSimulacion();
        }

        private void IniciarSimulacion()
        {
            FinalizarSimulacion();
            ProximaPatente(vistaPatente1);
            ProximaPatente(vistaPatente2);
        }

        private void FinalizarSimulacion()
        {
            foreach (Thread hilo in hilos)
            {
                if (hilo.IsAlive)
                    hilo.Abort();
            }
        }

        public void ProximaPatente(VistaPatente vp)
        {
            if (cola.Count > 0)
            {
                Thread t = new Thread(new ParameterizedThreadStart(vp.MostrarPatente));
                t.Start(cola.Dequeue());
                hilos.Add(t);
            }
        }
    }
}
