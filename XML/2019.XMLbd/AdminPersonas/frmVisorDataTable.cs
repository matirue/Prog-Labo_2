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
    public partial class frmVisorDataTable : frmVisorPersona
    {
        private DataTable dataTable;
        
        public frmVisorDataTable(DataTable dt):base()
        {
            this.dataTable = dt;
            this.ActualizarLista();
        }
        public DataTable DataTable
        {
            get { return this.dataTable; }
        }
        protected override void btnAgregar_Click(object sender, EventArgs e)
        {          

            frmPersona frm = new frmPersona();
            frm.ShowDialog();
            if(frm.DialogResult == DialogResult.OK)
            {
                DataColumnCollection columas = dataTable.Columns;
                DataRow fila = dataTable.NewRow();
                //fila[columas[0]] = frm.Persona.;
                fila[columas[1]] = frm.Persona.nombre;
                fila[columas[2]] = frm.Persona.apellido;
                fila[columas[3]] = frm.Persona.edad;
                dataTable.Rows.Add(fila);
                this.ActualizarLista();
            }
        }
        protected override void ActualizarLista()
        {
            this.lstVisor.Items.Clear();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if(dataTable.Rows[i].RowState != DataRowState.Deleted)
                this.lstVisor.Items.Add(String.Format("{0} - {1} - {2} - {3} ", dataTable.Rows[i][dataTable.Columns[0]], dataTable.Rows[i][dataTable.Columns[1]], dataTable.Rows[i][dataTable.Columns[2]], dataTable.Rows[i][dataTable.Columns[3]]));
            }
        }
        protected override void btnModificar_Click(object sender, EventArgs e)
        {
            DataRow datoFila = this.dataTable.Rows[this.lstVisor.SelectedIndex];
            if(datoFila.RowState != DataRowState.Deleted)
            {
                frmPersona frm = new frmPersona(new Entidades.Persona(datoFila["nombre"].ToString(), datoFila["apellido"].ToString(), int.Parse(datoFila["edad"].ToString())));
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    datoFila["nombre"] = frm.Persona.nombre;
                    datoFila["apellido"] = frm.Persona.apellido;
                    datoFila["edad"] = frm.Persona.edad;
                }
            }
            
            this.ActualizarLista();
        }
        protected override void btnEliminar_Click(object sender, EventArgs e)
        {
            this.dataTable.Rows[this.lstVisor.SelectedIndex].Delete();
            this.ActualizarLista();
        }
    }
}
