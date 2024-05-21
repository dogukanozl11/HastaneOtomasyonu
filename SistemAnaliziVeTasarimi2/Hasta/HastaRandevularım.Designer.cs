namespace SistemAnaliziVeTasarimi2.Hasta
{
    partial class HastaRandevularım
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaRandevularım));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Randevularım = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 36);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(795, 219);
            this.dataGridView1.TabIndex = 1;
            // 
            // Randevularım
            // 
            this.Randevularım.AutoSize = true;
            this.Randevularım.Location = new System.Drawing.Point(30, 232);
            this.Randevularım.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Randevularım.Name = "Randevularım";
            this.Randevularım.Size = new System.Drawing.Size(0, 13);
            this.Randevularım.TabIndex = 1;
            this.Randevularım.Visible = false;
            // 
            // HastaRandevularım
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(814, 266);
            this.Controls.Add(this.Randevularım);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HastaRandevularım";
            this.Text = "HastaRandevularım";
            this.Load += new System.EventHandler(this.HastaRandevularım_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Randevularım;
    }
}