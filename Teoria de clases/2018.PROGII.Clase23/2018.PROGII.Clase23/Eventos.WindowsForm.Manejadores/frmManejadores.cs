using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Eventos.WindowsForm.Manejadores
{
    public partial class frmManejadores : Form
    {
        public frmManejadores()
        {
            InitializeComponent();
        }

        #region Manejadores Dinámicos
        /// <summary>
        /// METODO CON TAREA COMUN
        /// A TODOS LOS CONTROLES
        /// </summary>
        /// <param name="sender">EMISOR DEL EVENTO</param>
        /// <param name="e">EVENTOS RELACIONADOS CON EL OBJETO</param>
        private void CambiarLetrasMayusculas(object sender, EventArgs e)
        {
            //ANTES DE CAMBIAR A MAYUSCULAS LAS LETRAS
            //DEBO CASTEAR EL 'SENDER' A 'BUTTON'
            ((Button)sender).Text = ((Button)sender).Text.ToUpper();
        }
        /// <summary>
        /// METODO CON TAREA PARTICULAR
        /// PARA CADA CONTROL
        /// </summary>
        /// <param name="sender">EMISOR DEL EVENTO</param>
        /// <param name="e">EVENTOS RELACIONADOS CON EL OBJETO</param>
        private void CambiarColorFondo(object sender, EventArgs e)
        {
            Button cual = (Button)sender;
            //IDENTIFICO QUE BOTON FUE PULSADO
            if (cual == this.btnBotonUno)
            {
                this.btnBotonUno.BackColor = Color.BurlyWood;
            }
            if (cual == this.btnBotonDos)
            {
                this.btnBotonDos.BackColor = Color.Cornsilk;
            }
            if (cual == this.btnBotonTres)
            {
                this.btnBotonTres.BackColor = Color.HotPink;
            }
        }
        #endregion

        #region Manejadores Estáticos
        private void TareaEnComunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AGREGO EL MANEJADOR DE TAREAS COMUNES
            this.btnBotonUno.Click += new EventHandler(CambiarLetrasMayusculas);
            this.btnBotonDos.Click += new EventHandler(CambiarLetrasMayusculas);
            this.btnBotonTres.Click += new EventHandler(CambiarLetrasMayusculas);
        }

        private void TareaParticularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AGREGO EL MANEJADOR DE TAREAS PARTICULARES
            this.btnBotonUno.Click += new EventHandler(CambiarColorFondo);
            this.btnBotonDos.Click += new EventHandler(CambiarColorFondo);
            this.btnBotonTres.Click += new EventHandler(CambiarColorFondo);
        }

        private void BtnUnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //REMUEVO EL MANEJADOR AL EVENTO 'CLICK' DE 'BTNBOTONUNO'
            this.btnBotonUno.Click -= new EventHandler(CambiarLetrasMayusculas);
            this.btnBotonUno.Click -= new EventHandler(CambiarColorFondo);
        }

        private void BtnDosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //REMUEVO EL MANEJADOR AL EVENTO 'CLICK' DE 'BTNBOTONDOS'
            this.btnBotonDos.Click -= new EventHandler(CambiarLetrasMayusculas);
            this.btnBotonDos.Click -= new EventHandler(CambiarColorFondo);
        }

        private void BtnTresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //REMUEVO EL MANEJADOR AL EVENTO 'CLICK' DE 'BTNBOTONTRES'
            this.btnBotonTres.Click -= new EventHandler(CambiarLetrasMayusculas);
            this.btnBotonTres.Click -= new EventHandler(CambiarColorFondo);
        }

        private void TodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //REMUEVO EL MANEJADOR AL EVENTO 'CLICK' DE 'BTNBOTONUNO'
            this.btnBotonUno.Click -= new EventHandler(CambiarLetrasMayusculas);
            this.btnBotonUno.Click -= new EventHandler(CambiarColorFondo);

            //REMUEVO EL MANEJADOR AL EVENTO 'CLICK' DE 'BTNBOTONDOS'
            this.btnBotonDos.Click -= new EventHandler(CambiarLetrasMayusculas);
            this.btnBotonDos.Click -= new EventHandler(CambiarColorFondo);

            //REMUEVO EL MANEJADOR AL EVENTO 'CLICK' DE 'BTNBOTONTRES'
            this.btnBotonTres.Click -= new EventHandler(CambiarLetrasMayusculas);
            this.btnBotonTres.Click -= new EventHandler(CambiarColorFondo);
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            // RECORRO LOS CONTROLES Y COLOCO EL VALOR INICIAL
            foreach (Control queControl in this.Controls)
            {
                if (queControl is Button)
                {
                    ((Button)queControl).Text = ((Button)queControl).Text.ToLower();
                    ((Button)queControl).BackColor = Button.DefaultBackColor;
                }

            }
        }
        #endregion
    }
}
