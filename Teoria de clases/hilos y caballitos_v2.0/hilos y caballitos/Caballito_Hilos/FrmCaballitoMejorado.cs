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
    public partial class FrmCaballitoMejorado : FrmCaballito
    {
        private int _velocidad;

        public FrmCaballitoMejorado()
        {
            InitializeComponent();

            this._velocidad = this.trackBar1.Maximum;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this._velocidad = this.trackBar1.Value;
            this._velocidad = this.trackBar1.Maximum - this.trackBar1.Value;
        }


        protected override void AnimarCaballito()
        {
            //base.AnimarCaballito();
            do
            {
                caballito1.MoverCaballito();
                Thread.Sleep(this._velocidad);

            } while (true);
        }
    }
}
