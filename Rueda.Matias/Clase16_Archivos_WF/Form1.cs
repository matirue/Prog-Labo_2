using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.IO;

namespace Clase16_Archivos_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //cargo el combobox
            foreach(Environment.SpecialFolder x in Environment.SpecialFolder.GetValues(typeof(Environment.SpecialFolder)))
            {
                this.cmbRuta.Items.Add(x);
            }
            //lo instancio
            this.cmbRuta.SelectedItem = Environment.SpecialFolder.Desktop;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(Environment.GetFolderPath((Environment.SpecialFolder)this.cmbRuta.SelectedItem) + "\\" + this.txtNombreDelArchivo.Text))
                {
                    sw.WriteLine(this.richTexto.Text);
                    MessageBox.Show(String.Format("->Se guardo correctamente el archivo {0} ", this.txtNombreDelArchivo.Text));
                }
            }
            //un catch por cada posible exception
            catch (ArgumentOutOfRangeException a)
            {
                MessageBox.Show(a.Message);
            }
            catch(ArgumentException a)
            {
                MessageBox.Show(a.Message);
            }
            catch (DirectoryNotFoundException a)
            {
                MessageBox.Show(a.Message);
            }
            catch (PathTooLongException a)
            {
                MessageBox.Show(a.Message);
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            string leido = "";
            try
            {
                using (StreamReader sw = new StreamReader(Environment.GetFolderPath((Environment.SpecialFolder)this.cmbRuta.SelectedItem) + "\\" + this.txtNombreDelArchivo.Text))
                {
                    leido = sw.ReadToEnd();
                }
                MessageBox.Show(leido);
                this.txtNombreDelArchivo.Text = "";
                this.richTexto.Text = "";
            }
            //un catch por cada posible exception
            catch (ArgumentOutOfRangeException a)
            {
                MessageBox.Show(a.Message);
            }
            catch (ArgumentException a)
            {
                MessageBox.Show(a.Message);
            }
            catch (DirectoryNotFoundException a)
            {
                MessageBox.Show(a.Message);
            }
            catch (PathTooLongException a)
            {
                MessageBox.Show(a.Message);
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
    }
}
