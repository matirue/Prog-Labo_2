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
using System.Xml;
using System.Xml.Serialization;
using System.Data.SqlClient;

namespace AdminPersonas
{
    public partial class FrmPrincipal : Form
    {
        private List<Persona> lista;

        public FrmPrincipal()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;

            this.lista = new List<Persona>();
        }

        private void cargarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //implementar...

            //la ruta para guardar el archivo usar el: openFileDialog.ShowDialog q permite abrir una ventana de dialogo
            //donde me permite aclarar nombre y lugar donde guardar. Usar el openFileDialog.FileLine
            //public static bool Serializar(IXML x)

            //tanto como el open como el save abren la misma ventana cada uno con unas difecencioa
            //initialdirectory establesco el directorio donde gardarlo
            //con Filename el nombre del archivo
            //una vez guardado el archivo, al volver visualizarlo debo levanta el archivo actualizado

            //    return x.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            //        + @"\Carpeta de prueba\Clase19\3archivo3.xml");
            //}

            try
            {   
                //ventana para que el ususario indique de donde cargar
                OpenFileDialog opFiDi = new OpenFileDialog();
                opFiDi.ShowDialog();

                XmlSerializer xmlSer = new XmlSerializer(typeof(List<Persona>));
                TextReader tr = new StreamReader(opFiDi.FileName); //carga segun la ruta indicada
                this.lista = (List<Persona>)xmlSer.Deserialize(tr);
                tr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void guardarEnArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //implementar... aca aplico la serializacion
            //aca uso el saveFielDialog
            try
            {
                //ventana para que el ususario indique donde guardar
                SaveFileDialog savFiDi = new SaveFileDialog();
                savFiDi.FileName = "listaPersonasDelWF.xml";
                savFiDi.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                savFiDi.ShowDialog();

                XmlSerializer xmlSer = new XmlSerializer(typeof(List<Persona>));
                TextWriter tw = new StreamWriter(savFiDi.FileName); //carga segun la ruta indicada
                xmlSer.Serialize(tw, this.lista);
                tw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisorPersona frm = new frmVisorPersona(this.lista);

            frm.StartPosition = FormStartPosition.CenterScreen;

            //implementar
            //abre el archivo guardado
            frm.Show();

            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //implementar
            this.Close();
        }
    }
}
