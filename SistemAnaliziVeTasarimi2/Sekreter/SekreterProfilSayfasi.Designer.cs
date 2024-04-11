namespace SistemAnaliziVeTasarimi2.Sekreter
{
    partial class SekreterProfilSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SekreterProfilSayfasi));
            this.btnGERİ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGERİ
            // 
            this.btnGERİ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGERİ.Location = new System.Drawing.Point(3, 3);
            this.btnGERİ.Name = "btnGERİ";
            this.btnGERİ.Size = new System.Drawing.Size(45, 35);
            this.btnGERİ.TabIndex = 2;
            this.btnGERİ.Text = "<";
            this.btnGERİ.UseVisualStyleBackColor = true;
            this.btnGERİ.Click += new System.EventHandler(this.btnGERİ_Click);
            // 
            // SekreterProfilSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGERİ);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SekreterProfilSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SekreterProfilSayfasi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGERİ;
    }
}