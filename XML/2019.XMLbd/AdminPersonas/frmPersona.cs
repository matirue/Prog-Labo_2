using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace AdminPersonas
{
    public partial class frmPersona : Form
    {
        private Persona miPersona;

        public Persona Persona
        {
            get { return this.miPersona; }
            
        }

        public frmPersona()
        {
            InitializeComponent();
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            //implementar

            try
            {
                XmlSerializer xmlSer = new XmlSerializer(typeof(List<Persona>));
                using (TextWriter tw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\2019.XMLbd\Arc de Pruebas\persona.xml"))
                {

                    Persona p = new Persona(this.txtNombre.Text, this.txtApellido.Text, int.Parse(this.txtEdad.Text));
                    xmlSer.Serialize(tw, p);
                    this.DialogResult = DialogResult.OK;
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
