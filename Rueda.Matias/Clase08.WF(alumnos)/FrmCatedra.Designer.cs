namespace Clase08.WF_alumnos_
{
    partial class FrmCatedra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxAlumnos = new System.Windows.Forms.GroupBox();
            this.cmbTipoOrden = new System.Windows.Forms.ComboBox();
            this.listAlumnos = new System.Windows.Forms.ListBox();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonCalificar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.groupBoxAlumnosCalificados = new System.Windows.Forms.GroupBox();
            this.listAlumnosCalificados = new System.Windows.Forms.ListBox();
            this.groupBoxAlumnos.SuspendLayout();
            this.groupBoxAlumnosCalificados.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAlumnos
            // 
            this.groupBoxAlumnos.Controls.Add(this.cmbTipoOrden);
            this.groupBoxAlumnos.Controls.Add(this.listAlumnos);
            this.groupBoxAlumnos.Controls.Add(this.buttonModificar);
            this.groupBoxAlumnos.Controls.Add(this.buttonCalificar);
            this.groupBoxAlumnos.Controls.Add(this.buttonAgregar);
            this.groupBoxAlumnos.Location = new System.Drawing.Point(12, 6);
            this.groupBoxAlumnos.Name = "groupBoxAlumnos";
            this.groupBoxAlumnos.Size = new System.Drawing.Size(434, 217);
            this.groupBoxAlumnos.TabIndex = 0;
            this.groupBoxAlumnos.TabStop = false;
            this.groupBoxAlumnos.Text = "Alumnos";
            // 
            // cmbTipoOrden
            // 
            this.cmbTipoOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoOrden.FormattingEnabled = true;
            this.cmbTipoOrden.Location = new System.Drawing.Point(7, 190);
            this.cmbTipoOrden.Name = "cmbTipoOrden";
            this.cmbTipoOrden.Size = new System.Drawing.Size(421, 21);
            this.cmbTipoOrden.TabIndex = 4;
            this.cmbTipoOrden.SelectedIndexChanged += new System.EventHandler(this.cmbTipoOrden_SelectedIndexChanged);
            // 
            // listAlumnos
            // 
            this.listAlumnos.FormattingEnabled = true;
            this.listAlumnos.Location = new System.Drawing.Point(6, 48);
            this.listAlumnos.Name = "listAlumnos";
            this.listAlumnos.Size = new System.Drawing.Size(422, 134);
            this.listAlumnos.TabIndex = 3;
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(320, 19);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(108, 23);
            this.buttonModificar.TabIndex = 2;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonCalificar
            // 
            this.buttonCalificar.Location = new System.Drawing.Point(165, 19);
            this.buttonCalificar.Name = "buttonCalificar";
            this.buttonCalificar.Size = new System.Drawing.Size(108, 23);
            this.buttonCalificar.TabIndex = 1;
            this.buttonCalificar.Text = "Calificar";
            this.buttonCalificar.UseVisualStyleBackColor = true;
            this.buttonCalificar.Click += new System.EventHandler(this.buttonCalificar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(6, 19);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(108, 23);
            this.buttonAgregar.TabIndex = 0;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // groupBoxAlumnosCalificados
            // 
            this.groupBoxAlumnosCalificados.Controls.Add(this.listAlumnosCalificados);
            this.groupBoxAlumnosCalificados.Location = new System.Drawing.Point(12, 229);
            this.groupBoxAlumnosCalificados.Name = "groupBoxAlumnosCalificados";
            this.groupBoxAlumnosCalificados.Size = new System.Drawing.Size(434, 171);
            this.groupBoxAlumnosCalificados.TabIndex = 1;
            this.groupBoxAlumnosCalificados.TabStop = false;
            this.groupBoxAlumnosCalificados.Text = "Alumnos Calificados";
            // 
            // listAlumnosCalificados
            // 
            this.listAlumnosCalificados.FormattingEnabled = true;
            this.listAlumnosCalificados.Location = new System.Drawing.Point(6, 19);
            this.listAlumnosCalificados.Name = "listAlumnosCalificados";
            this.listAlumnosCalificados.Size = new System.Drawing.Size(422, 134);
            this.listAlumnosCalificados.TabIndex = 4;
            // 
            // FrmCatedra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 412);
            this.Controls.Add(this.groupBoxAlumnosCalificados);
            this.Controls.Add(this.groupBoxAlumnos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCatedra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCatedra";
            this.groupBoxAlumnos.ResumeLayout(false);
            this.groupBoxAlumnosCalificados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAlumnos;
        private System.Windows.Forms.ComboBox cmbTipoOrden;
        private System.Windows.Forms.ListBox listAlumnos;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonCalificar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.GroupBox groupBoxAlumnosCalificados;
        private System.Windows.Forms.ListBox listAlumnosCalificados;
    }
}