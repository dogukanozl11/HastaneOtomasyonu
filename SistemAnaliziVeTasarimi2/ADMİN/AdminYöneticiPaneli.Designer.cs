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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminYöneticiPaneli));
            this.btnSekreterKayit = new System.Windows.Forms.Button();
            this.btnDoktorKayit = new System.Windows.Forms.Button();
            this.btnLabPKayit = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sistemHastanesiDataSet = new SistemAnaliziVeTasarimi2.sistemHastanesiDataSet();
            this.sistemHastanesiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelListesiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelListesiTableAdapter = new SistemAnaliziVeTasarimi2.sistemHastanesiDataSetTableAdapters.PersonelListesiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sistemHastanesiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemHastanesiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelListesiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSekreterKayit
            // 
            this.btnSekreterKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSekreterKayit.Location = new System.Drawing.Point(616, 462);
            this.btnSekreterKayit.Name = "btnSekreterKayit";
            this.btnSekreterKayit.Size = new System.Drawing.Size(179, 87);
            this.btnSekreterKayit.TabIndex = 0;
            this.btnSekreterKayit.Text = "Sekreter Kayıt";
            this.btnSekreterKayit.UseVisualStyleBackColor = true;
            this.btnSekreterKayit.Click += new System.EventHandler(this.btnSekreterKayit_Click);
            // 
            // btnDoktorKayit
            // 
            this.btnDoktorKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktorKayit.Location = new System.Drawing.Point(111, 462);
            this.btnDoktorKayit.Name = "btnDoktorKayit";
            this.btnDoktorKayit.Size = new System.Drawing.Size(179, 87);
            this.btnDoktorKayit.TabIndex = 1;
            this.btnDoktorKayit.Text = "Doktro Kayıt";
            this.btnDoktorKayit.UseVisualStyleBackColor = true;
            this.btnDoktorKayit.Click += new System.EventHandler(this.btnDoktorKayit_Click);
            // 
            // btnLabPKayit
            // 
            this.btnLabPKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLabPKayit.Location = new System.Drawing.Point(360, 462);
            this.btnLabPKayit.Name = "btnLabPKayit";
            this.btnLabPKayit.Size = new System.Drawing.Size(179, 87);
            this.btnLabPKayit.TabIndex = 2;
            this.btnLabPKayit.Text = "Laboratuvar Personel Kayıt";
            this.btnLabPKayit.UseVisualStyleBackColor = true;
            this.btnLabPKayit.Click += new System.EventHandler(this.btnLabPKayit_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.personelListesiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemAnaliziVeTasarimi2.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(982, 456);
            this.reportViewer1.TabIndex = 3;
            // 
            // sistemHastanesiDataSet
            // 
            this.sistemHastanesiDataSet.DataSetName = "sistemHastanesiDataSet";
            this.sistemHastanesiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sistemHastanesiDataSetBindingSource
            // 
            this.sistemHastanesiDataSetBindingSource.DataSource = this.sistemHastanesiDataSet;
            this.sistemHastanesiDataSetBindingSource.Position = 0;
            // 
            // personelListesiBindingSource
            // 
            this.personelListesiBindingSource.DataMember = "PersonelListesi";
            this.personelListesiBindingSource.DataSource = this.sistemHastanesiDataSetBindingSource;
            // 
            // personelListesiTableAdapter
            // 
            this.personelListesiTableAdapter.ClearBeforeFill = true;
            // 
            // AdminYöneticiPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnLabPKayit);
            this.Controls.Add(this.btnDoktorKayit);
            this.Controls.Add(this.btnSekreterKayit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminYöneticiPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminYöneticiPaneli";
            this.Load += new System.EventHandler(this.AdminYöneticiPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemHastanesiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemHastanesiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelListesiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSekreterKayit;
        private System.Windows.Forms.Button btnDoktorKayit;
        private System.Windows.Forms.Button btnLabPKayit;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sistemHastanesiDataSetBindingSource;
        private sistemHastanesiDataSet sistemHastanesiDataSet;
        private System.Windows.Forms.BindingSource personelListesiBindingSource;
        private sistemHastanesiDataSetTableAdapters.PersonelListesiTableAdapter personelListesiTableAdapter;
        //private sistemHastanesiDataSet2TableAdapters.PersonelListesiTableAdapter personelListesiTableAdapter;
    }
}