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

namespace _20181122_SP
{
    public partial class FrmPpal : Form
    {
        Queue<Patente> cola;

        List<Thread> hilos;

        public FrmPpal()
        {
            InitializeComponent();

            this.cola = new Queue<Patente>();

            this.hilos = new List<Thread>();
        }

        /// <summary>
        /// En el evento Load del formulario, asociar el evento VistaPatente para los objetos vistaPatente1 y
        /// vistaPatente2 con el manejador.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPpal_Load(object sender, EventArgs e)
        {
            this.vistaPatente1.finExposicion += ProximaPatente;
            this.vistaPatente2.finExposicion += ProximaPatente;
        }

        /// <summary>
        /// En el evento Closing del formulario, asegurarse de que todos los hilos estén terminados. 
        /// Agregar el método FinalizarSimulacion que cumpla esa función.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FinalizarSimulacion(); 
        }

        /// <summary>
        /// Los 3 botones
        /// agregar los datos a la cola de Patentes.
        /// También capturar las excepciones y llamar al método IniciarSimulacion
        /// </summary>
        


        private void btnXml_Click(object sender, EventArgs e)
        {
            try
            {
                List<Patente> lista;
                Xml<List<Patente>> miXml = new Xml<List<Patente>>();
                miXml.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\patentes.xml", out lista);

                this.cola = new Queue<Patente>(lista.AsEnumerable().Reverse());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //inicializar simulacion
            this.IniciarSimulacion();
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            try
            {
                Texto text = new Texto();
                text.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\patentes.txt", out this.cola);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.IniciarSimulacion();
        }

        private void btnSql_Click(object sender, EventArgs e)
        {
            try
            {
                Sql unSql = new Sql();
                unSql.Leer("Patentes", out this.cola);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.IniciarSimulacion();
        }


        /// <summary>
        /// IniciarSimulacion:
        /// a.Finalizará los hilos activos.
        /// b.Llamará al método ProximaPatente para cada uno de los objetos del tipo VistaPatente del
        /// formulario.
        /// </summary>
        private void IniciarSimulacion()
        {
            this.FinalizarSimulacion();
            this.ProximaPatente(this.vistaPatente1);
            this.ProximaPatente(this.vistaPatente2);
        }

        private void FinalizarSimulacion()
        {
            if (this.hilos != null)
            {
                foreach(Thread h in this.hilos)
                {
                    if (h.IsAlive)//is live devulve el estado de ejecucion del hilo
                        h.Abort();//mato el hilo
                }
            }
        }

        //manejador de evento de clase VistaPatente
        private void ProximaPatente(Patentes.VistaPatente vistaPatentes)
        {
            if (this.cola.Count > 0)
            {
                Thread unHilo = new Thread(new ParameterizedThreadStart(vistaPatentes.MostrarPatente));
                unHilo.Start(this.cola.Dequeue());
                this.hilos.Add(unHilo);
            }
        }
    }
}
