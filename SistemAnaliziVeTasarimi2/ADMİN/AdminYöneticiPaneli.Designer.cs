namespace SistemAnaliziVeTasarimi2.ADMİN
{
    partial class AdminYöneticiPaneli
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
            this.btnSekreterKayit = new System.Windows.Forms.Button();
            this.btnDoktorKayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSekreterKayit
            // 
            this.btnSekreterKayit.Location = new System.Drawing.Point(404, 242);
            this.btnSekreterKayit.Name = "btnSekreterKayit";
            this.btnSekreterKayit.Size = new System.Drawing.Size(131, 51);
            this.btnSekreterKayit.TabIndex = 0;
            this.btnSekreterKayit.Text = "Sekreter Kayıt";
            this.btnSekreterKayit.UseVisualStyleBackColor = true;
            this.btnSekreterKayit.Click += new System.EventHandler(this.btnSekreterKayit_Click);
            // 
            // btnDoktorKayit
            // 
            this.btnDoktorKayit.Location = new System.Drawing.Point(150, 242);
            this.btnDoktorKayit.Name = "btnDoktorKayit";
            this.btnDoktorKayit.Size = new System.Drawing.Size(131, 51);
            this.btnDoktorKayit.TabIndex = 1;
            this.btnDoktorKayit.Text = "Doktro Kayıt";
            this.btnDoktorKayit.UseVisualStyleBackColor = true;
            this.btnDoktorKayit.Click += new System.EventHandler(this.btnDoktorKayit_Click);
            // 
            // AdminYöneticiPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDoktorKayit);
            this.Controls.Add(this.btnSekreterKayit);
            this.Name = "AdminYöneticiPaneli";
            this.Text = "AdminYöneticiPaneli";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSekreterKayit;
        private System.Windows.Forms.Button btnDoktorKayit;
    }
}