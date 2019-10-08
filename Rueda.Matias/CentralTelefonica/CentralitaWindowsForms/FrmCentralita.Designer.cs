namespace CentralitaWindowsForms
{
    partial class FrmCentralita
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLocal = new System.Windows.Forms.Button();
            this.btnProvincia = new System.Windows.Forms.Button();
            this.cboOrdenamiento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstVisor = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnLocal
            // 
            this.btnLocal.Location = new System.Drawing.Point(12, 182);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(135, 23);
            this.btnLocal.TabIndex = 0;
            this.btnLocal.Text = "Llamda Local";
            this.btnLocal.UseVisualStyleBackColor = true;
            this.btnLocal.Click += new System.EventHandler(this.btnLocal_Click);
            // 
            // btnProvincia
            // 
            this.btnProvincia.Location = new System.Drawing.Point(153, 182);
            this.btnProvincia.Name = "btnProvincia";
            this.btnProvincia.Size = new System.Drawing.Size(135, 23);
            this.btnProvincia.TabIndex = 1;
            this.btnProvincia.Text = "Llamada Provincial";
            this.btnProvincia.UseVisualStyleBackColor = true;
            this.btnProvincia.Click += new System.EventHandler(this.btnProvincia_Click);
            // 
            // cboOrdenamiento
            // 
            this.cboOrdenamiento.FormattingEnabled = true;
            this.cboOrdenamiento.Location = new System.Drawing.Point(438, 184);
            this.cboOrdenamiento.Name = "cboOrdenamiento";
            this.cboOrdenamiento.Size = new System.Drawing.Size(190, 21);
            this.cboOrdenamiento.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ordenar por:";
            // 
            // lstVisor
            // 
            this.lstVisor.FormattingEnabled = true;
            this.lstVisor.Location = new System.Drawing.Point(12, 12);
            this.lstVisor.Name = "lstVisor";
            this.lstVisor.Size = new System.Drawing.Size(616, 160);
            this.lstVisor.TabIndex = 4;
            // 
            // FrmCentralita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 217);
            this.Controls.Add(this.lstVisor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboOrdenamiento);
            this.Controls.Add(this.btnProvincia);
            this.Controls.Add(this.btnLocal);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmCentralita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centralita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.Button btnProvincia;
        private System.Windows.Forms.ComboBox cboOrdenamiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstVisor;
    }
}

