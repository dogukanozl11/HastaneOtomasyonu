namespace SistemAnaliziVeTasarimi2.Doktor
{
    partial class DoktorKayıtOlSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorKayıtOlSayfasi));
            this.btnDoktorKayıtYap = new System.Windows.Forms.Button();
            this.txtDoktorTel = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbDoktorCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtDoktorSifre = new System.Windows.Forms.TextBox();
            this.txtDoktorMail = new System.Windows.Forms.TextBox();
            this.txtDoktorTC = new System.Windows.Forms.TextBox();
            this.txtDoktorİsim = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbDoktorBrans = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxYas = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDoktorKayıtYap
            // 
            this.btnDoktorKayıtYap.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnDoktorKayıtYap.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDoktorKayıtYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoktorKayıtYap.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktorKayıtYap.Location = new System.Drawing.Point(637, 398);
            this.btnDoktorKayıtYap.Name = "btnDoktorKayıtYap";
            this.btnDoktorKayıtYap.Size = new System.Drawing.Size(246, 65);
            this.btnDoktorKayıtYap.TabIndex = 22;
            this.btnDoktorKayıtYap.Text = "Kayıt Yap";
            this.btnDoktorKayıtYap.UseVisualStyleBackColor = false;
            this.btnDoktorKayıtYap.Click += new System.EventHandler(this.btnDoktorKayıtYap_Click);
            // 
            // txtDoktorTel
            // 
            this.txtDoktorTel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDoktorTel.Location = new System.Drawing.Point(661, 170);
            this.txtDoktorTel.Mask = "(999) 000-0000";
            this.txtDoktorTel.Name = "txtDoktorTel";
            this.txtDoktorTel.Size = new System.Drawing.Size(222, 27);
            this.txtDoktorTel.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(501, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Şifre : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(501, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tel No : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(501, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "E-Mail :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(71, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Cinsiyet : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(71, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Gün/Ay/Yıl : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(71, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "T.C Kimlik No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(71, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "İsim - Soyisim : ";
            // 
            // CmbDoktorCinsiyet
            // 
            this.CmbDoktorCinsiyet.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbDoktorCinsiyet.FormattingEnabled = true;
            this.CmbDoktorCinsiyet.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.CmbDoktorCinsiyet.Location = new System.Drawing.Point(251, 290);
            this.CmbDoktorCinsiyet.Name = "CmbDoktorCinsiyet";
            this.CmbDoktorCinsiyet.Size = new System.Drawing.Size(222, 27);
            this.CmbDoktorCinsiyet.TabIndex = 12;
            // 
            // txtDoktorSifre
            // 
            this.txtDoktorSifre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoktorSifre.Location = new System.Drawing.Point(661, 290);
            this.txtDoktorSifre.Name = "txtDoktorSifre";
            this.txtDoktorSifre.Size = new System.Drawing.Size(222, 27);
            this.txtDoktorSifre.TabIndex = 10;
            // 
            // txtDoktorMail
            // 
            this.txtDoktorMail.BackColor = System.Drawing.SystemColors.Window;
            this.txtDoktorMail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoktorMail.Location = new System.Drawing.Point(661, 210);
            this.txtDoktorMail.Name = "txtDoktorMail";
            this.txtDoktorMail.Size = new System.Drawing.Size(222, 27);
            this.txtDoktorMail.TabIndex = 9;
            // 
            // txtDoktorTC
            // 
            this.txtDoktorTC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoktorTC.Location = new System.Drawing.Point(251, 210);
            this.txtDoktorTC.MaxLength = 11;
            this.txtDoktorTC.Name = "txtDoktorTC";
            this.txtDoktorTC.Size = new System.Drawing.Size(222, 27);
            this.txtDoktorTC.TabIndex = 8;
            // 
            // txtDoktorİsim
            // 
            this.txtDoktorİsim.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDoktorİsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDoktorİsim.Location = new System.Drawing.Point(251, 170);
            this.txtDoktorİsim.Name = "txtDoktorİsim";
            this.txtDoktorİsim.Size = new System.Drawing.Size(222, 26);
            this.txtDoktorİsim.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(501, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Branş :";
            // 
            // CmbDoktorBrans
            // 
            this.CmbDoktorBrans.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbDoktorBrans.FormattingEnabled = true;
            this.CmbDoktorBrans.Items.AddRange(new object[] {
            "",
            "Çocuk Sağlığı Ve Hastalıkları",
            "Deri Ve Zührevi Hastalıkları (Cildiye)",
            "Enfeksiyon Hastalıkları",
            "Fizik Tedavi Ve Rehabilitasyon",
            "Genel Cerrahi",
            "Göğüs Cerrahisi",
            "İç Hastalıkları (Dahiliye)",
            "Kadın Hastalıkları ve Doğum",
            "Kalp ve Damar Cerrahisi",
            "Kardiyoloji",
            "Kulak Burun Boğaz Hastalıkları",
            "Ortopedi Ve Travmatoloji",
            "Ruh Sağlığı Ve Hastalıkları (Psikiyatri)",
            "Nöroloji",
            "Üroloji",
            "Acil1",
            "Acil2",
            "Acil3"});
            this.CmbDoktorBrans.Location = new System.Drawing.Point(661, 250);
            this.CmbDoktorBrans.Name = "CmbDoktorBrans";
            this.CmbDoktorBrans.Size = new System.Drawing.Size(222, 27);
            this.CmbDoktorBrans.TabIndex = 12;
            // 
            // maskedTextBoxYas
            // 
            this.maskedTextBoxYas.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxYas.Location = new System.Drawing.Point(251, 250);
            this.maskedTextBoxYas.Mask = "00/00/0000";
            this.maskedTextBoxYas.Name = "maskedTextBoxYas";
            this.maskedTextBoxYas.Size = new System.Drawing.Size(222, 27);
            this.maskedTextBoxYas.TabIndex = 21;
            this.maskedTextBoxYas.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(314, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(414, 39);
            this.label10.TabIndex = 23;
            this.label10.Text = "DOKTOR KAYIT SAYFASI";
            // 
            // DoktorKayıtOlSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnDoktorKayıtYap);
            this.Controls.Add(this.maskedTextBoxYas);
            this.Controls.Add(this.txtDoktorTel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbDoktorBrans);
            this.Controls.Add(this.CmbDoktorCinsiyet);
            this.Controls.Add(this.txtDoktorSifre);
            this.Controls.Add(this.txtDoktorMail);
            this.Controls.Add(this.txtDoktorTC);
            this.Controls.Add(this.txtDoktorİsim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DoktorKayıtOlSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoktorKayıtOlSayfasi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoktorKayıtYap;
        private System.Windows.Forms.MaskedTextBox txtDoktorTel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbDoktorCinsiyet;
        private System.Windows.Forms.TextBox txtDoktorSifre;
        private System.Windows.Forms.TextBox txtDoktorMail;
        private System.Windows.Forms.TextBox txtDoktorTC;
        private System.Windows.Forms.TextBox txtDoktorİsim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbDoktorBrans;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxYas;
        private System.Windows.Forms.Label label10;
    }
}