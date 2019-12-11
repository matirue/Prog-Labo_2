using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Entidades;

namespace FormPrincipal
{
    public partial class formPpal : Form
    {     
        LosHilos hilos;

        public formPpal()
        {
            InitializeComponent();
        }

        public void MostrarMensajeFin(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void formPpal_Load(object sender, EventArgs e)
        {
            this.hilos = new LosHilos();
            this.hilos.AvisoFin += MostrarMensajeFin;
        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            try
            {
                this.hilos += 1;
            }
            catch(CantidadInvalidaException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(this.hilos.Bitacora);
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
