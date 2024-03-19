namespace SistemAnaliziVeTasarimi2
{
    partial class Anasayfa
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
            this.BtnHastaGiris = new System.Windows.Forms.Button();
            this.BtnDoktorGiris = new System.Windows.Forms.Button();
            this.BtnSekreterGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnHastaGiris
            // 
            this.BtnHastaGiris.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnHastaGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHastaGiris.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnHastaGiris.Location = new System.Drawing.Point(78, 248);
            this.BtnHastaGiris.Name = "BtnHastaGiris";
            this.BtnHastaGiris.Size = new System.Drawing.Size(125, 50);
            this.BtnHastaGiris.TabIndex = 0;
            this.BtnHastaGiris.Text = "Hasta Girişi";
            this.BtnHastaGiris.UseVisualStyleBackColor = false;
            this.BtnHastaGiris.Click += new System.EventHandler(this.BtnHastaGiris_Click);
            // 
            // BtnDoktorGiris
            // 
            this.BtnDoktorGiris.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnDoktorGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDoktorGiris.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnDoktorGiris.Location = new System.Drawing.Point(228, 248);
            this.BtnDoktorGiris.Name = "BtnDoktorGiris";
            this.BtnDoktorGiris.Size = new System.Drawing.Size(125, 50);
            this.BtnDoktorGiris.TabIndex = 0;
            this.BtnDoktorGiris.Text = "Doktor Girişi";
            this.BtnDoktorGiris.UseVisualStyleBackColor = false;
            this.BtnDoktorGiris.Click += new System.EventHandler(this.BtnDoktorGiris_Click);
            // 
            // BtnSekreterGiris
            // 
            this.BtnSekreterGiris.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnSekreterGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSekreterGiris.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnSekreterGiris.Location = new System.Drawing.Point(378, 248);
            this.BtnSekreterGiris.Name = "BtnSekreterGiris";
            this.BtnSekreterGiris.Size = new System.Drawing.Size(125, 50);
            this.BtnSekreterGiris.TabIndex = 0;
            this.BtnSekreterGiris.Text = "Sekreter Girişi";
            this.BtnSekreterGiris.UseVisualStyleBackColor = false;
            this.BtnSekreterGiris.Click += new System.EventHandler(this.BtnSekreterGiris_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.BtnSekreterGiris);
            this.Controls.Add(this.BtnDoktorGiris);
            this.Controls.Add(this.BtnHastaGiris);
            this.Name = "Anasayfa";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnHastaGiris;
        private System.Windows.Forms.Button BtnDoktorGiris;
        private System.Windows.Forms.Button BtnSekreterGiris;
    }
}

