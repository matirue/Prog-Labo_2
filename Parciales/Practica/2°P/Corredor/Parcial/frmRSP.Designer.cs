namespace Parcial
{
    partial class frmRSP
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
            this.pgbCarril1 = new System.Windows.Forms.ProgressBar();
            this.lblCarril1 = new System.Windows.Forms.Label();
            this.btnCorrer = new System.Windows.Forms.Button();
            this.lblCarril2 = new System.Windows.Forms.Label();
            this.pgbCarril2 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // pgbCarril1
            // 
            this.pgbCarril1.Location = new System.Drawing.Point(147, 25);
            this.pgbCarril1.Name = "pgbCarril1";
            this.pgbCarril1.Size = new System.Drawing.Size(507, 38);
            this.pgbCarril1.TabIndex = 0;
            // 
            // lblCarril1
            // 
            this.lblCarril1.AutoSize = true;
            this.lblCarril1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarril1.Location = new System.Drawing.Point(36, 34);
            this.lblCarril1.Name = "lblCarril1";
            this.lblCarril1.Size = new System.Drawing.Size(84, 29);
            this.lblCarril1.TabIndex = 1;
            this.lblCarril1.Text = "Carril1";
            // 
            // btnCorrer
            // 
            this.btnCorrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrer.Location = new System.Drawing.Point(491, 148);
            this.btnCorrer.Name = "btnCorrer";
            this.btnCorrer.Size = new System.Drawing.Size(163, 71);
            this.btnCorrer.TabIndex = 2;
            this.btnCorrer.Text = "Correr";
            this.btnCorrer.UseVisualStyleBackColor = true;
            this.btnCorrer.Click += new System.EventHandler(this.btnCorrer_Click);
            // 
            // lblCarril2
            // 
            this.lblCarril2.AutoSize = true;
            this.lblCarril2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarril2.Location = new System.Drawing.Point(36, 92);
            this.lblCarril2.Name = "lblCarril2";
            this.lblCarril2.Size = new System.Drawing.Size(84, 29);
            this.lblCarril2.TabIndex = 4;
            this.lblCarril2.Text = "Carril2";
            // 
            // pgbCarril2
            // 
            this.pgbCarril2.Location = new System.Drawing.Point(147, 83);
            this.pgbCarril2.Name = "pgbCarril2";
            this.pgbCarril2.Size = new System.Drawing.Size(507, 38);
            this.pgbCarril2.TabIndex = 3;
            // 
            // frmRSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 231);
            this.Controls.Add(this.lblCarril2);
            this.Controls.Add(this.pgbCarril2);
            this.Controls.Add(this.btnCorrer);
            this.Controls.Add(this.lblCarril1);
            this.Controls.Add(this.pgbCarril1);
            this.Name = "frmRSP";
            this.Text = "RSP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbCarril1;
        private System.Windows.Forms.Label lblCarril1;
        private System.Windows.Forms.Button btnCorrer;
        private System.Windows.Forms.Label lblCarril2;
        private System.Windows.Forms.ProgressBar pgbCarril2;
    }
}

