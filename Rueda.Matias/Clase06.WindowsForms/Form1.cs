using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Clase06.Entidades.V1;

namespace Clase06.WindowsForms
{
    public partial class Form1 : Form
    {

        Paleta miPaleta;

        public Form1()
        {
            InitializeComponent();

            //ventana inicia maximizada
            //this.WindowState = FormWindowState.Maximized;

            
            //con esto hago que el form principal o padrea que va a contener otro formularios
            this.IsMdiContainer = true;
            //al arranque no es visible el groupBoxPaleta
            this.groupBoxPaleta.Visible = false;
            //this.crearPaletaToolStripMenuItem.Visible = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void crearPaletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //limpio ltsbox
            this.ltsPaleta.Items.Clear();

            //creo paleta con 5 pinturas
            this.miPaleta = 5;
            //al hacer click en crear paleta se hace visible 
            this.groupBoxPaleta.Visible = true;

            //despues de clickear lo bloqueo
            this.crearPaletaToolStripMenuItem.Enabled = false;
            //this.crearPaletaToolStripMenuItem.Enabled = true;
        }

        private void temperaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //creo el formulario donde voy a cargar la paleta
            FrmTemperas tempFrm = new FrmTemperas();

            //formulario padre
            //Tempera.MdiParent = this;

            //muestro el formulario
            //showdialog no sirve para mdiparent
            tempFrm.ShowDialog();

            //this.groupBoxPaleta.Visible = true;

            if (tempFrm.DialogResult == DialogResult.OK)//lo muestro cuando doy aceptar
            {
                this.miPaleta += tempFrm.MiTempera;//llamo por propiedad al objeto creado en el formtempera
                ltsPaleta.Items.Add((string)tempFrm.MiTempera);//lo muestro
            }
        }

        private void groupBoxPaleta_Enter(object sender, EventArgs e)
        {

        }
    }
}
