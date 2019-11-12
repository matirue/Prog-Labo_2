namespace Eventos.WindowsForm.Manejadores
{
    partial class frmManejadores
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.btnBotonTres = new System.Windows.Forms.Button();
            this.btnBotonDos = new System.Windows.Forms.Button();
            this.btnBotonUno = new System.Windows.Forms.Button();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.AgregarManejadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TareaEnComunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TareaParticularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoverManejadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnUnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnDosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnTresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.Location = new System.Drawing.Point(70, 217);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(210, 23);
            this.btnRestablecer.TabIndex = 19;
            this.btnRestablecer.Text = "Restablecer valores iniciales";
            this.btnRestablecer.UseVisualStyleBackColor = true;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // btnBotonTres
            // 
            this.btnBotonTres.Location = new System.Drawing.Point(70, 151);
            this.btnBotonTres.Name = "btnBotonTres";
            this.btnBotonTres.Size = new System.Drawing.Size(210, 23);
            this.btnBotonTres.TabIndex = 17;
            this.btnBotonTres.Text = "con un manejador de evento";
            this.btnBotonTres.UseVisualStyleBackColor = true;
            // 
            // btnBotonDos
            // 
            this.btnBotonDos.Location = new System.Drawing.Point(70, 102);
            this.btnBotonDos.Name = "btnBotonDos";
            this.btnBotonDos.Size = new System.Drawing.Size(210, 23);
            this.btnBotonDos.TabIndex = 16;
            this.btnBotonDos.Text = "para compartir código";
            this.btnBotonDos.UseVisualStyleBackColor = true;
            // 
            // btnBotonUno
            // 
            this.btnBotonUno.Location = new System.Drawing.Point(70, 57);
            this.btnBotonUno.Name = "btnBotonUno";
            this.btnBotonUno.Size = new System.Drawing.Size(210, 23);
            this.btnBotonUno.TabIndex = 15;
            this.btnBotonUno.Text = "Esto es una pequeña prueba";
            this.btnBotonUno.UseVisualStyleBackColor = true;
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AgregarManejadoresToolStripMenuItem,
            this.RemoverManejadoresToolStripMenuItem});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(350, 24);
            this.mnuMenu.TabIndex = 18;
            this.mnuMenu.Text = "MenuStrip1";
            // 
            // AgregarManejadoresToolStripMenuItem
            // 
            this.AgregarManejadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TareaEnComunToolStripMenuItem,
            this.TareaParticularToolStripMenuItem});
            this.AgregarManejadoresToolStripMenuItem.Name = "AgregarManejadoresToolStripMenuItem";
            this.AgregarManejadoresToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.AgregarManejadoresToolStripMenuItem.Text = "Agregar Manejadores";
            // 
            // TareaEnComunToolStripMenuItem
            // 
            this.TareaEnComunToolStripMenuItem.Name = "TareaEnComunToolStripMenuItem";
            this.TareaEnComunToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.TareaEnComunToolStripMenuItem.Text = "Tarea Común";
            this.TareaEnComunToolStripMenuItem.Click += new System.EventHandler(this.TareaEnComunToolStripMenuItem_Click);
            // 
            // TareaParticularToolStripMenuItem
            // 
            this.TareaParticularToolStripMenuItem.Name = "TareaParticularToolStripMenuItem";
            this.TareaParticularToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.TareaParticularToolStripMenuItem.Text = "Tarea Particular";
            this.TareaParticularToolStripMenuItem.Click += new System.EventHandler(this.TareaParticularToolStripMenuItem_Click);
            // 
            // RemoverManejadoresToolStripMenuItem
            // 
            this.RemoverManejadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnUnoToolStripMenuItem,
            this.BtnDosToolStripMenuItem,
            this.BtnTresToolStripMenuItem,
            this.TodosToolStripMenuItem});
            this.RemoverManejadoresToolStripMenuItem.Name = "RemoverManejadoresToolStripMenuItem";
            this.RemoverManejadoresToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.RemoverManejadoresToolStripMenuItem.Text = "Remover Manejadores";
            // 
            // BtnUnoToolStripMenuItem
            // 
            this.BtnUnoToolStripMenuItem.Name = "BtnUnoToolStripMenuItem";
            this.BtnUnoToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.BtnUnoToolStripMenuItem.Text = "btnUno";
            this.BtnUnoToolStripMenuItem.Click += new System.EventHandler(this.BtnUnoToolStripMenuItem_Click);
            // 
            // BtnDosToolStripMenuItem
            // 
            this.BtnDosToolStripMenuItem.Name = "BtnDosToolStripMenuItem";
            this.BtnDosToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.BtnDosToolStripMenuItem.Text = "btnDos";
            this.BtnDosToolStripMenuItem.Click += new System.EventHandler(this.BtnDosToolStripMenuItem_Click);
            // 
            // BtnTresToolStripMenuItem
            // 
            this.BtnTresToolStripMenuItem.Name = "BtnTresToolStripMenuItem";
            this.BtnTresToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.BtnTresToolStripMenuItem.Text = "btnTres";
            this.BtnTresToolStripMenuItem.Click += new System.EventHandler(this.BtnTresToolStripMenuItem_Click);
            // 
            // TodosToolStripMenuItem
            // 
            this.TodosToolStripMenuItem.Name = "TodosToolStripMenuItem";
            this.TodosToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.TodosToolStripMenuItem.Text = "Todos";
            this.TodosToolStripMenuItem.Click += new System.EventHandler(this.TodosToolStripMenuItem_Click);
            // 
            // frmManejadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 296);
            this.Controls.Add(this.btnRestablecer);
            this.Controls.Add(this.btnBotonTres);
            this.Controls.Add(this.btnBotonDos);
            this.Controls.Add(this.btnBotonUno);
            this.Controls.Add(this.mnuMenu);
            this.Name = "frmManejadores";
            this.Text = "Manejadores a  Controles de igual tipo";
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnRestablecer;
        internal System.Windows.Forms.Button btnBotonTres;
        internal System.Windows.Forms.Button btnBotonDos;
        internal System.Windows.Forms.Button btnBotonUno;
        internal System.Windows.Forms.MenuStrip mnuMenu;
        internal System.Windows.Forms.ToolStripMenuItem AgregarManejadoresToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem TareaEnComunToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem TareaParticularToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RemoverManejadoresToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem BtnUnoToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem BtnDosToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem BtnTresToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem TodosToolStripMenuItem;
    }
}

