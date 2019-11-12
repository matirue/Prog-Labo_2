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
    public partial class Form2 : Form
    {
        private Thread _hilo;

        public Form2()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.btnCrearPelotita.Click += new System.EventHandler(this.btnCrearPelotita_Click);

        }

        private void btnCrearPelotita_Click(object sender, EventArgs e)
        {
            this.btnCrearPelotita.Click -= new System.EventHandler(this.btnCrearPelotita_Click);
            this.btnPausarPelotita.Click += new System.EventHandler(this.btnPausarPelotita_Click);
            this.btnMatarPelotita.Click += new System.EventHandler(this.btnMatarPelotita_Click);

            //***************************************************************************************//
            Pelotita p = new Pelotita(this.pictureBox1);

            this._hilo = new Thread(p.DoWork);

            this._hilo.Start();
            //**************************************************************************************//

        }
        private void btnPausarPelotita_Click(object sender, EventArgs e)
        {
            this.btnPausarPelotita.Click -= new System.EventHandler(this.btnPausarPelotita_Click);
            this.btnReanudarPelotita.Click += new System.EventHandler(this.btnReanudarPelotita_Click);

            this._hilo.Suspend();   
        }

        private void btnReanudarPelotita_Click(object sender, EventArgs e)
        {
            this.btnReanudarPelotita.Click -= new System.EventHandler(this.btnReanudarPelotita_Click);
            this.btnPausarPelotita.Click += new System.EventHandler(this.btnPausarPelotita_Click);

            this._hilo.Resume();
        }

        private void btnMatarPelotita_Click(object sender, EventArgs e)
        {
            this.btnReanudarPelotita.Click -= new System.EventHandler(this.btnReanudarPelotita_Click);
            this.btnPausarPelotita.Click -= new System.EventHandler(this.btnPausarPelotita_Click);
            this.btnMatarPelotita.Click -= new System.EventHandler(this.btnMatarPelotita_Click);
            this.btnCrearPelotita.Click += new System.EventHandler(this.btnCrearPelotita_Click);

            try
            {
                this._hilo.Abort();
            }
            catch (Exception) { }
            finally 
            {
                MessageBox.Show("Pelotita is Dead!!!");

                Graphics g = this.pictureBox1.CreateGraphics();
                g.Clear(this.pictureBox1.BackColor);
            }
        }
    }
}
