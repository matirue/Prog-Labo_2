using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Eventos.WindowsForm.Manejadores2
{
    public partial class frmManejadores : Form
    {
        public frmManejadores()
        {
            InitializeComponent();

            //ASIGNO 'DINAMICAMENTE' EL MANEJADOR AL EVENTO LOAD
            this.Load += new EventHandler(MiManejadorDeEventoLoad);
        }

        private void MiManejadorDeEventoLoad(object sender, EventArgs e)
        { 
            this.lblNombre.Click += new EventHandler(ControlPulsado);
            this.txtNombre.Click += new EventHandler(ControlPulsado);
            this.btnPulsar.Click += new EventHandler(ControlPulsado);
        }

        //EN ESTE MANEJADOR DE EVENTOS ASIGNAMOS EL EVENTO 'CLICK'
        //DE DISTINTOS TIPOS DE CONTROLES DEL FORMULARIO
        private void ControlPulsado(object sender, EventArgs e)
        {
            //COMPRUEBO SOBRE QUE CONTROL SE HIZO CLICK

            //SI ES LABEL... CAMBIO EL ESTILO AL BORDE
            if(sender is Label)
            {
                ((Label)sender).BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }

            //SI ES BUTTON... CIERRO EL FORMULARIO
            if(sender is Button)
            {
                MessageBox.Show("Cierro el Formulario!!!");
                this.Close();
            }

            //SI ES TEXTBOX... CAMBIO EL COLOR DE FONDO
            if(sender is TextBox)
            {
                ((TextBox)sender).BackColor = Color.Navy;
            }
        }
    }
}
