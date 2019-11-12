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
    public partial class Form3 : Form
    {
        private int _cantidad;

        public Form3()
        {
            InitializeComponent();

            this._cantidad = 0;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.btnCrearPelotita.Click += new System.EventHandler(this.btnCrearPelotita_Click);

        }

        private void btnCrearPelotita_Click(object sender, EventArgs e)
        {
            //***************************************************************************************//
            Pelotita p = new Pelotita(this.pictureBox1);

            Thread hilo = new Thread(p.DoWork);

            hilo.Start();

            this._cantidad++;

            this.lblCantidad.Text = "Cantidad de Pelotitas = " + this._cantidad;
            //***************************************************************************************//

        }
    }
}
