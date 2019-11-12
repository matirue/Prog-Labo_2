using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Eventos.WindowsForm.Manejadores3
{
    public partial class frmPasarManejador : Form
    {
        public frmPasarManejador()
        {
            InitializeComponent();

            //ASIGNO 'DINAMICAMENTE' EL MANEJADOR AL EVENTO LOAD
            this.Load += new EventHandler(Inicializar);
        }

        private void Inicializar(object sender, EventArgs e)
        {
            this.Button1.Click += new EventHandler(Mostrar);

            this.lblMensaje.Text = "Manejador en el Button1";
        }

        private void Mostrar(object sender, EventArgs e)
        {
            Button unBoton = (Button)sender;

            MessageBox.Show("Soy " + unBoton.Name, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.PasarManejador(unBoton, e);
        }

        private void PasarManejador(Object boton, EventArgs evento)
        {
            Button unBoton = (Button)boton;
            
            //AGREGO EL MANEJADOR AL SIGUIENTE BOTON
            //Y REMUEVO EL MANEJADOR AL BOTON ACTUAL

            if (unBoton == this.Button1)
            {
                this.Button2.Click += new EventHandler(Mostrar);
                this.Button1.Click -= new EventHandler(Mostrar);
                this.lblMensaje.Text = "Manejador en el Button2";
                this.Button2.Focus();
            }
            if (unBoton == this.Button2)
            {
                this.Button3.Click += new EventHandler(Mostrar);
                this.Button2.Click -= new EventHandler(Mostrar);
                this.lblMensaje.Text = "Manejador en el Button3";
                this.Button3.Focus();
            }
            if (unBoton == this.Button3)
            {
                this.Button4.Click += new EventHandler(Mostrar);
                this.Button3.Click -= new EventHandler(Mostrar);
                this.lblMensaje.Text = "Manejador en el Button4";
                this.Button4.Focus();
            }
            if (unBoton == this.Button4)
            {
                this.Button1.Click += new EventHandler(Mostrar);
                this.Button4.Click -= new EventHandler(Mostrar);
                this.lblMensaje.Text = "Manejador en el Button1";
                this.Button1.Focus();
            }
        }

        //MANEJADOR AGREGADO 'ESTATICAMENTE'
        private void frmPasarManejador_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Esta seguro de salir?", "Terminar la aplicación",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
