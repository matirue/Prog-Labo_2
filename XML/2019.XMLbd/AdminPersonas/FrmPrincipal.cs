using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Data.SqlClient;
using Entidades;

namespace AdminPersonas
{
    public partial class FrmPrincipal : Form
    {
        private List<Persona> lista;
        private DataTable tablaPersonas;
        private SqlDataAdapter dataAdapter;
        public FrmPrincipal()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.lista = new List<Persona>();
            this.tablaPersonas = new DataTable("Personas");

            SqlConnection sqlConexion;
            sqlConexion = new SqlConnection(Properties.Settings.Default.Conexion);
            this.dataAdapter = new SqlDataAdapter("SELECT * FROM Personas", sqlConexion);
            dataAdapter.Fill(tablaPersonas);
            dataAdapter.InsertCommand = new SqlCommand("insert into Personas(nombre,apellido,edad) values (@p1,@p2,@p3)", sqlConexion);
            dataAdapter.UpdateCommand = new SqlCommand("update Personas set nombre=@p1,apellido=@p2,edad=@p3 where id=@p4", sqlConexion);
            dataAdapter.DeleteCommand = new SqlCommand("delete from Personas where id=@p4",sqlConexion);

            dataAdapter.InsertCommand.Parameters.Add("@p1", SqlDbType.VarChar, 50,"nombre");
            dataAdapter.InsertCommand.Parameters.Add("@p2", SqlDbType.VarChar, 50, "apellido");
            dataAdapter.InsertCommand.Parameters.Add("@p3", SqlDbType.Int,2,"edad");
            dataAdapter.InsertCommand.Parameters.Add("@p4", SqlDbType.Int,2, "id");

            dataAdapter.UpdateCommand.Parameters.Add("@p1", SqlDbType.VarChar, 50, "nombre");
            dataAdapter.UpdateCommand.Parameters.Add("@p2", SqlDbType.VarChar, 50, "apellido");
            dataAdapter.UpdateCommand.Parameters.Add("@p3", SqlDbType.Int, 2, "edad");
            dataAdapter.UpdateCommand.Parameters.Add("@p4", SqlDbType.Int, 2, "id");

            dataAdapter.DeleteCommand.Parameters.Add("@p1", SqlDbType.VarChar, 50, "nombre");
            dataAdapter.DeleteCommand.Parameters.Add("@p2", SqlDbType.VarChar, 50, "apellido");
            dataAdapter.DeleteCommand.Parameters.Add("@p3", SqlDbType.Int, 2, "edad");
            dataAdapter.DeleteCommand.Parameters.Add("@p4", SqlDbType.Int, 2, "id");



            //this.CargarDataTable();
        }

        private void cargarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //implementar...
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                XmlSerializer xmlSer = new XmlSerializer(typeof(List<Persona>));
                TextReader tr = new StreamReader(ofd.FileName);
                this.lista = (List<Persona>)xmlSer.Deserialize(tr);
                tr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void guardarEnArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //implementar...
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = "listaDePersonasWinForm.xml";
                sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                sfd.ShowDialog();
                XmlSerializer xmlSer = new XmlSerializer(typeof(List<Persona>));
                TextWriter tw = new StreamWriter(sfd.FileName);
                xmlSer.Serialize(tw, this.lista);
                tw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmVisorPersona frm = new frmVisorPersona(this.lista);
            frmVisorDataTable frm = new frmVisorDataTable(tablaPersonas);
            frm.StartPosition = FormStartPosition.CenterScreen;

            //implementar
            frm.Show();
            //this.tablaPersonas = frm.DataTable;
            //this.lista = frm.ListaDePersonas;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //implementar
            this.Close();
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)//IPIMENTACION DE SQL !!!!!!!!!!!!!!!!!!!
        {
            try
            {
                SqlConnection sqlConexion;
                sqlConexion = new SqlConnection(Properties.Settings.Default.Conexion);
                sqlConexion.Open();
                MessageBox.Show("Se pudo establecer conexion con el sql");
                sqlConexion.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void traerTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConexion = new SqlConnection(Properties.Settings.Default.Conexion);
            sqlConexion.Open();
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.Connection = sqlConexion;
            sqlCom.CommandType = CommandType.Text;
            //sqlCom.CommandText = "SELECT TOP 1000 [id],[nombre],[apellido],[edad]FROM[personas_bd].[dbo].[personas]";
            sqlCom.CommandText = "SELECT * FROM Personas";
            SqlDataReader sqlDataReader = sqlCom.ExecuteReader();
            while (sqlDataReader.Read() != false)
            {
                this.lista.Add(new Persona((string)sqlDataReader["nombre"].ToString(),sqlDataReader["apellido"].ToString(),int.Parse(sqlDataReader["edad"].ToString())));
            }
            sqlDataReader.Close();
            sqlConexion.Close();
        }
        private void CargarDataTable()
        {
            try
            {
                SqlConnection sqlConexion = new SqlConnection(Properties.Settings.Default.Conexion);
                sqlConexion.Open();
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.Connection = sqlConexion;
                sqlCom.CommandType = CommandType.Text;
                //sqlCom.CommandText = "SELECT TOP 1000 [id],[nombre],[apellido],[edad]FROM[personas_bd].[dbo].[personas]";
                sqlCom.CommandText = "SELECT * FROM Personas";
                SqlDataReader sqlDataReader = sqlCom.ExecuteReader();
                this.tablaPersonas.Load(sqlDataReader);
                sqlDataReader.Close();
                sqlConexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void sincronizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //aca recorro el dataTable y agrega las filas marcadas como adder, elimina las que macan como deleted y modifica
            //las que estan marcadas como modificadas
            dataAdapter.Update(tablaPersonas);
        }
    }
}
