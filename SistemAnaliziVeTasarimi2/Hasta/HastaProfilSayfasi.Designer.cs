namespace SistemAnaliziVeTasarimi2.Hasta
{
    partial class HastaProfilSayfasi
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
            this.btnGERİ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGERİ
            // 
            this.btnGERİ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGERİ.Location = new System.Drawing.Point(1, 0);
            this.btnGERİ.Name = "btnGERİ";
            this.btnGERİ.Size = new System.Drawing.Size(45, 35);
            this.btnGERİ.TabIndex = 3;
            this.btnGERİ.Text = "<";
            this.btnGERİ.UseVisualStyleBackColor = true;
            this.btnGERİ.Click += new System.EventHandler(this.btnGERİ_Click);
            // 
            // HastaProfilSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGERİ);
            this.Name = "HastaProfilSayfasi";
            this.Text = "HastaProfilSayfasi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGERİ;
    }
}