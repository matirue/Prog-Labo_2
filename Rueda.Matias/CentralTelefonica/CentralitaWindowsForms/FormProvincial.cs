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
    public partial class FormProvincial : FormLlamada
    {
        private Provincial nuevaLlamadaProvincia;

        public Provincial GetProvincial { get { return this.nuevaLlamadaProvincia; } }

        public FormProvincial()
        {
            InitializeComponent();

            foreach(EFranja x in Enum.GetValues(typeof(EFranja)))
            {
                cmbFanja.Items.Add(x);
            }

            this.cmbFanja.SelectedItem = EFranja.Franja_1;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            nuevaLlamadaProvincia = new Provincial(this.txtNOrigen.Text, (EFranja)this.cmbFanja.SelectedIndex, float.Parse(this.txtDuracion.Text), this.txtDuracion.Text);
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
