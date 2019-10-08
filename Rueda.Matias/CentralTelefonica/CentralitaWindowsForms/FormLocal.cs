using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CentralitaHerencia;

namespace CentralitaWindowsForms
{
    public partial class FormLocal : FormLlamada
    {
        private Local nuevaLlamadaLocal;

        public Local GetLocal { get { return this.nuevaLlamadaLocal; } }

        public FormLocal()
        {
            InitializeComponent();
        }

        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            nuevaLlamadaLocal = new Local(this.txtNOrigen.Text, float.Parse(this.txtDuracion.Text), this.txtNDestino.Text, float.Parse(this.txtCosto.Text));
            DialogResult = DialogResult.OK;
        }
    }
}
