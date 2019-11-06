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
using System.Data.SqlClient;

namespace AdminPersonas
{
    public partial class frmVisorPersona : Form
    {
        List<Persona> listaPersona;
        
        /***************************************************************/
        public void ActualizarMiLista()
        {
            this.lstVisor.Items.Clear();

            foreach (Persona p in this.listaPersona)
                this.lstVisor.Items.Add(p);
        }

        /***************************************************************/
        public frmVisorPersona()
        {
            InitializeComponent();

            /***************************************************************/
            this.listaPersona = new List<Persona>();
        }
        public frmVisorPersona(List<Persona> lstPer) : this()
        {
            this.listaPersona = lstPer;
            this.ActualizarMiLista();
        }
        /***************************************************************/

        public List<Persona> ListaDePersonas
        {
            get { return this.listaPersona; }
            set { this.listaPersona = value; }
        }

        /***************************************************************/




        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //frmPersona frm = new frmPersona();
            //frm.StartPosition = FormStartPosition.CenterScreen;
            //frm.ShowDialog();
            ////implementar

            //if (frm.DialogResult == DialogResult.OK)
            //{
            //    this.listaPersona.Add(frm.Persona);
            //    this.lstVisor.Items.Add(frm.Persona);
            //}

            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            //implementar

            if (frm.DialogResult == DialogResult.OK)
            {
                StringBuilder str = new StringBuilder();

                SqlCommand sqlCmd = new SqlCommand();

                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion);

                conexion.Open();

                this.listaPersona.Add(frm.Persona);
                this.lstVisor.Items.Add(frm.Persona);

                try
                {
                    str.AppendFormat("insert into Personas(nombre,apellido,edad) values ('{0}','{1}','{2}')", frm.Persona.nombre, frm.Persona.apellido, frm.Persona.edad);
                    sqlCmd.Connection = conexion;

                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = str.ToString();
                    sqlCmd.ExecuteNonQuery();//transcribe a la bd
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    conexion.Close();
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //frmPersona frm = new frmPersona(/*params*/);
            //frm.StartPosition = FormStartPosition.CenterScreen;

            ////implementar
            //frm.ShowDialog();
            //if (frm.DialogResult == DialogResult.OK)
            //    this.lstVisor.SelectedItem = frm.Persona;

            //this.ActualizarMiLista();

            if (!Object.Equals(this.lstVisor.SelectedItem, null))
            {
                ////mustro con los datos seleccionado
                //frmPersona frm = new frmPersona((Persona)this.lstVisor.SelectedItem);
                //frm.StartPosition = FormStartPosition.CenterScreen;

                ////implementar
                //frm.ShowDialog();
                //if (frm.DialogResult == DialogResult.OK)
                //    this.lstVisor.SelectedItem = frm.Persona;                                   

                //this.ActualizarMiLista();

                StringBuilder str = new StringBuilder();
                SqlCommand sqlCmd = new SqlCommand();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion);

                conexion.Open();

                frmPersona frm = new frmPersona((Persona)this.lstVisor.SelectedItem);
                frm.StartPosition = FormStartPosition.CenterScreen;

                //implementar
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    this.lstVisor.SelectedItem = frm.Persona;

                    try
                    {
                        str.AppendFormat("update Personas set nombre='{0}',apellido='{1}',edad={2} where id={3}", frm.Persona.nombre, frm.Persona.apellido, frm.Persona.edad, this.lstVisor.SelectedIndex + 1);

                        sqlCmd.Connection = conexion;

                        sqlCmd.CommandType = CommandType.Text;
                        sqlCmd.CommandText = str.ToString();
                        sqlCmd.ExecuteNonQuery(); //transcribe a la bd

                        conexion.Close();
                    }
                    catch (Exception ex)
                    {
                        conexion.Close();
                        MessageBox.Show(ex.Message);
                        throw;
                    }

                    
                }
                this.ActualizarMiLista();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //frmPersona frm = new frmPersona();
            //frm.StartPosition = FormStartPosition.CenterScreen;

            ////implementar

            //this.listaPersona.Remove((Persona)this.lstVisor.SelectedItem);
            //this.ActualizarMiLista();

            if (!Object.Equals(this.lstVisor.SelectedItem, null))
            {
                StringBuilder str = new StringBuilder();
                SqlCommand sqlCmd = new SqlCommand();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion);

                conexion.Open();

                frmPersona frm = new frmPersona((Persona)this.lstVisor.SelectedItem);
                frm.StartPosition = FormStartPosition.CenterScreen;

                //implementar

                this.listaPersona.Remove((Persona)this.lstVisor.SelectedItem);

                    try
                    {
                        str.AppendFormat("delete from Personas where id={0}", this.lstVisor.SelectedIndex + 1);

                        sqlCmd.Connection = conexion;

                        sqlCmd.CommandType = CommandType.Text;
                        sqlCmd.CommandText = str.ToString();
                        sqlCmd.ExecuteNonQuery(); //transcribe a la bd

                        conexion.Close();
                    }
                    catch (Exception ex)
                    {
                        conexion.Close();
                        MessageBox.Show(ex.Message);
                        throw;
                    }
                this.ActualizarMiLista();
            }

        }
    }
}
