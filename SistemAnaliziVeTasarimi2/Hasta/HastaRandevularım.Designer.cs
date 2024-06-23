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
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(76, 163);
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Bookman Old Style", 24F);
            this.label10.Location = new System.Drawing.Point(353, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(245, 39);
            this.label10.TabIndex = 44;
            this.label10.Text = "RANDEVULAR";
            // 
            // HastaRandevularım
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.label10);
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
        private System.Windows.Forms.Label label10;
    }
}