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

        Paleta miPaleta=5;

        #region Cotructor

        

        #endregion

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

            this.temperaToolStripMenuItem.Enabled = true;
            

            //creo paleta con 5 pinturas
            //this.miPaleta = 5;
            //al hacer click en crear paleta se hace visible 
            this.groupBoxPaleta.Visible = true;

            //despues de clickear lo bloqueo
            this.crearPaletaToolStripMenuItem.Enabled = false;
            //this.crearPaletaToolStripMenuItem.Enabled = true;
        }

        private void temperaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //creo el formulario donde voy a cargar la paleta        
            FrmTemperas frm = new FrmTemperas();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                this.ltsPaleta.Items.Clear();
                this.miPaleta += frm.MiTempera;
                for (int i = 0; i < 5; i++)
                {
                    this.ltsPaleta.Items.Add((string)this.miPaleta[i]);
                }
            }
            //formulario padre
            //Tempera.MdiParent = this;

            //muestro el formulario
            //showdialog no sirve para mdiparent
           

            //this.groupBoxPaleta.Visible = true;

            
        }

        private void groupBoxPaleta_Enter(object sender, EventArgs e)
        {
            
        }

        //como el menu paleta esta bloqueado, el + vuelve a llamaar a tempera permitiendo agregar otra tempera
        private void buttonMas_Click(object sender, EventArgs e)
        {
            temperaToolStripMenuItem_Click(sender, e);
            //FrmTemperas tempFrm = new FrmTemperas();
            //tempFrm.ShowDialog();
            //if (tempFrm.DialogResult == DialogResult.OK)//lo muestro cuando doy aceptar
            //{
                
            //    this.miPaleta += tempFrm.MiTempera;//llamo por propiedad al objeto creado en el formtempera
                
            //    ltsPaleta.Items.Add((string)tempFrm.MiTempera);//lo muestro
            //}
        }

        //el menos lo quita
        private void buttonMenos_Click(object sender, EventArgs e)
        {
            //FrmTemperas tempFrm = new FrmTemperas();
            int indice;
            FrmTemperas tempFrm = new FrmTemperas();
            //tomo el indice del ultimo elemento de la lista
            
            tempFrm.ShowDialog();
            //if (tempFrm.DialogResult == DialogResult.OK)
            if (buttonMenos.DialogResult == DialogResult.OK)
            {
                this.miPaleta -= tempFrm.MiTempera;
                ltsPaleta.Items.Clear();
                ltsPaleta.Items.Add((string)tempFrm.MiTempera);
            }
      
            
            //ltsPaleta.Items.Remove(indice);
            //tempFrm.ShowDialog();

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {//actualizar o refrescar listados
            
            int indice = this.ltsPaleta.SelectedIndex;
            if (indice!=-1 && this.miPaleta[indice] != null)
            {
                FrmTemperas temp = new FrmTemperas(this.miPaleta[indice]);
                temp.StartPosition = FormStartPosition.CenterScreen;
                temp.ShowDialog();

                if (temp.DialogResult == DialogResult.OK)
                {
                    this.ltsPaleta.Items.Clear();
                    this.miPaleta[indice] = temp.MiTempera;
                    for(int i = 0; i < 5; i++)
                    {
                        this.ltsPaleta.Items.Add((string)this.miPaleta[i]);
                    }
                }

            }

        }
    }
}
