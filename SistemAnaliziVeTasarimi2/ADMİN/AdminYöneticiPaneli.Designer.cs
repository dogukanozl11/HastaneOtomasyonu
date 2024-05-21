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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminYöneticiPaneli));
            this.btnSekreterKayit = new System.Windows.Forms.Button();
            this.btnDoktorKayit = new System.Windows.Forms.Button();
            this.btnLabPKayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSekreterKayit
            // 
            this.btnSekreterKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSekreterKayit.Location = new System.Drawing.Point(527, 158);
            this.btnSekreterKayit.Name = "btnSekreterKayit";
            this.btnSekreterKayit.Size = new System.Drawing.Size(204, 113);
            this.btnSekreterKayit.TabIndex = 0;
            this.btnSekreterKayit.Text = "Sekreter Kayıt";
            this.btnSekreterKayit.UseVisualStyleBackColor = true;
            this.btnSekreterKayit.Click += new System.EventHandler(this.btnSekreterKayit_Click);
            // 
            // btnDoktorKayit
            // 
            this.btnDoktorKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktorKayit.Location = new System.Drawing.Point(22, 158);
            this.btnDoktorKayit.Name = "btnDoktorKayit";
            this.btnDoktorKayit.Size = new System.Drawing.Size(204, 113);
            this.btnDoktorKayit.TabIndex = 1;
            this.btnDoktorKayit.Text = "Doktro Kayıt";
            this.btnDoktorKayit.UseVisualStyleBackColor = true;
            this.btnDoktorKayit.Click += new System.EventHandler(this.btnDoktorKayit_Click);
            // 
            // btnLabPKayit
            // 
            this.btnLabPKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLabPKayit.Location = new System.Drawing.Point(271, 158);
            this.btnLabPKayit.Name = "btnLabPKayit";
            this.btnLabPKayit.Size = new System.Drawing.Size(204, 113);
            this.btnLabPKayit.TabIndex = 2;
            this.btnLabPKayit.Text = "Laboratuvar Personel Kayıt";
            this.btnLabPKayit.UseVisualStyleBackColor = true;
            this.btnLabPKayit.Click += new System.EventHandler(this.btnLabPKayit_Click);
            // 
            // AdminYöneticiPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 305);
            this.Controls.Add(this.btnLabPKayit);
            this.Controls.Add(this.btnDoktorKayit);
            this.Controls.Add(this.btnSekreterKayit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminYöneticiPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminYöneticiPaneli";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSekreterKayit;
        private System.Windows.Forms.Button btnDoktorKayit;
        private System.Windows.Forms.Button btnLabPKayit;
    }
}