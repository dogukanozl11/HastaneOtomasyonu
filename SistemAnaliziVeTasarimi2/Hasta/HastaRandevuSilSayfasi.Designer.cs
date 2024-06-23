namespace SistemAnaliziVeTasarimi2.Hasta
{
    partial class HastaRandevuSilSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaRandevuSilSayfasi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRandevuiptal = new System.Windows.Forms.Button();
            this.randevularım = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(81, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(765, 277);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnRandevuiptal
            // 
            this.btnRandevuiptal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevuiptal.Location = new System.Drawing.Point(369, 421);
            this.btnRandevuiptal.Name = "btnRandevuiptal";
            this.btnRandevuiptal.Size = new System.Drawing.Size(200, 50);
            this.btnRandevuiptal.TabIndex = 1;
            this.btnRandevuiptal.Text = "Randevu İptal Et";
            this.btnRandevuiptal.UseVisualStyleBackColor = true;
            this.btnRandevuiptal.Click += new System.EventHandler(this.btnRandevuiptal_Click);
            // 
            // randevularım
            // 
            this.randevularım.AutoSize = true;
            this.randevularım.BackColor = System.Drawing.Color.Transparent;
            this.randevularım.Font = new System.Drawing.Font("Bookman Old Style", 24F);
            this.randevularım.Location = new System.Drawing.Point(362, 66);
            this.randevularım.Name = "randevularım";
            this.randevularım.Size = new System.Drawing.Size(245, 39);
            this.randevularım.TabIndex = 2;
            this.randevularım.Text = "RANDEVULAR";
            // 
            // HastaRandevuSilSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.randevularım);
            this.Controls.Add(this.btnRandevuiptal);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HastaRandevuSilSayfasi";
            this.Text = "HastaRandevuSilSayfasi";
            this.Load += new System.EventHandler(this.HastaRandevuSilSayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRandevuiptal;
        private System.Windows.Forms.Label randevularım;
    }
}