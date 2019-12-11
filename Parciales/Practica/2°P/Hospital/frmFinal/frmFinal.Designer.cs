namespace frmFinal
{
    partial class frmFinal
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
            this.btnMedicoGral = new System.Windows.Forms.Button();
            this.btnMedicoEsp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMedicoGral
            // 
            this.btnMedicoGral.Location = new System.Drawing.Point(13, 13);
            this.btnMedicoGral.Name = "btnMedicoGral";
            this.btnMedicoGral.Size = new System.Drawing.Size(398, 113);
            this.btnMedicoGral.TabIndex = 0;
            this.btnMedicoGral.Text = "Atender Médico General";
            this.btnMedicoGral.UseVisualStyleBackColor = true;
            this.btnMedicoGral.Click += new System.EventHandler(this.btnMedicoGral_Click);
            // 
            // btnMedicoEsp
            // 
            this.btnMedicoEsp.Location = new System.Drawing.Point(12, 132);
            this.btnMedicoEsp.Name = "btnMedicoEsp";
            this.btnMedicoEsp.Size = new System.Drawing.Size(398, 113);
            this.btnMedicoEsp.TabIndex = 1;
            this.btnMedicoEsp.Text = "Atender Médico Especialista";
            this.btnMedicoEsp.UseVisualStyleBackColor = true;
            this.btnMedicoEsp.Click += new System.EventHandler(this.btnMedicoEsp_Click);
            // 
            // frmFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 262);
            this.Controls.Add(this.btnMedicoEsp);
            this.Controls.Add(this.btnMedicoGral);
            this.Name = "frmFinal";
            this.Text = "Form Final";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFinal_FormClosing);
            this.Load += new System.EventHandler(this.frmFinal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMedicoGral;
        private System.Windows.Forms.Button btnMedicoEsp;
    }
}

