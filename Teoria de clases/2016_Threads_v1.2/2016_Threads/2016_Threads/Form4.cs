using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading.Tasks;
using System.Threading;

namespace Pelotita_Con_Threads
{
    public partial class Form4 : Form
    {
        private List<Thread> _hilos;
        private int _cantPausa;

        public Form4()
        {
            InitializeComponent();

            this._hilos = new List<Thread>();
            this._cantPausa = 0;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.btnCrearPelotita.Click += new System.EventHandler(this.btnCrearPelotita_Click);
            this.btnPausarPelotita.Click += new System.EventHandler(this.btnPausarPelotita_Click);
            this.btnReanudarPelotita.Click += new System.EventHandler(this.btnReanudarPelotita_Click);
            this.btnMatarPelotita.Click += new System.EventHandler(this.btnMatarPelotita_Click);

        }

        private void btnCrearPelotita_Click(object sender, EventArgs e)
        {
            //***************************************************************************************//
            Pelotita p = new Pelotita(this.pictureBox1);
            Thread hilo = new Thread(p.DoWork);

            this._hilos.Add(hilo);

            hilo.Start();

            this.lblCantidad.Text = "Cantidad de Pelotitas = " + this._hilos.Count;
            //************************************************************************************************************************//

        }

        private void btnPausarPelotita_Click(object sender, EventArgs e)
        {
            try
            {
                this._hilos[this._cantPausa].Suspend();
                this._cantPausa++;
            }
            catch (Exception){ }

        }

        private void btnReanudarPelotita_Click(object sender, EventArgs e)
        {
            try
            {                
                this._hilos[this._cantPausa - 1].Resume();
                this._cantPausa--;
                
            }
            catch (Exception) { }
            
        }

        private void btnMatarPelotita_Click(object sender, EventArgs e)
        {
            try
            {
                this._hilos[this._hilos.Count-1].Abort();
                this._hilos.RemoveAt(this._hilos.Count - 1);

                this.lblCantidad.Text = "Cantidad de Pelotitas = " + this._hilos.Count;

                Graphics g = this.pictureBox1.CreateGraphics();
                g.Clear(this.pictureBox1.BackColor);
            }
            catch (Exception) { }
        }
    }
}
