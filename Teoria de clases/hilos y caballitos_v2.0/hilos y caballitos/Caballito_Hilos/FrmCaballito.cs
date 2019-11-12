using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace Caballito_Hilos
{
    public partial class FrmCaballito : Form
    {
        protected Thread _miHilo;

        public FrmCaballito()
        {
            InitializeComponent();            
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (this._miHilo != null && this._miHilo.IsAlive)
            {
                this._miHilo.Abort();
                this.btnIniciar.Text = "&Iniciar";
            }
            else
            {
                this._miHilo = new Thread(this.AnimarCaballito);
                this._miHilo.Start();
                this.btnIniciar.Text = "&Parar";
            }
        }

        protected virtual void AnimarCaballito()
        {           
            do
            {
                caballito1.MoverCaballito();
                Thread.Sleep(45);

            } while (true);
        }

        private void FrmPrueba_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this._miHilo != null && _miHilo.IsAlive)
                _miHilo.Abort();
        }
    }
}
