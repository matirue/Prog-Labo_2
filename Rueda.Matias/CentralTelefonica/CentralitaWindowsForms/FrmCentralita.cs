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
    public partial class FrmCentralita : Form
    {
        Centralita miCentral = new Centralita("Telecom");

        public FrmCentralita()
        {
            InitializeComponent();

            this.cboOrdenamiento.Text = "OrdenarPorDuracion";
            this.cboOrdenamiento.Enabled = false;
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            FormLocal frmLocal = new FormLocal();
            frmLocal.ShowDialog();
            
            if (frmLocal.DialogResult == DialogResult.OK)
            {
                miCentral += frmLocal.GetLocal;
            }

            ActualizarLista();

        }

        private void btnProvincia_Click(object sender, EventArgs e)
        {
            FormProvincial frmProv = new FormProvincial();
            frmProv.ShowDialog();

            if (frmProv.DialogResult == DialogResult.OK)
            {
                miCentral += frmProv.GetProvincial;
            }

            ActualizarLista();
        }

        private void ActualizarLista()
        {
            this.lstVisor.Items.Clear();
            miCentral.OrdenarLLamadas();

            for(int i = 0; i < miCentral.Llamadas.Count(); i++)
            {
                lstVisor.Items.Add(miCentral.Llamadas[i]);
            }
        }
    }
}
