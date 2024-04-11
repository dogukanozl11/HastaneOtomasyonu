namespace SistemAnaliziVeTasarimi2.Hasta
{
    partial class HastaBilgileri
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
            this.CmbDoktorCinsiyet = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxYas = new System.Windows.Forms.MaskedTextBox();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEskiSifre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtİsim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmbDoktorCinsiyet
            // 
            this.CmbDoktorCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbDoktorCinsiyet.FormattingEnabled = true;
            this.CmbDoktorCinsiyet.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.CmbDoktorCinsiyet.Location = new System.Drawing.Point(141, 236);
            this.CmbDoktorCinsiyet.Name = "CmbDoktorCinsiyet";
            this.CmbDoktorCinsiyet.Size = new System.Drawing.Size(222, 28);
            this.CmbDoktorCinsiyet.TabIndex = 45;
            // 
            // maskedTextBoxYas
            // 
            this.maskedTextBoxYas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxYas.Location = new System.Drawing.Point(141, 206);
            this.maskedTextBoxYas.Mask = "00/00/0000";
            this.maskedTextBoxYas.Name = "maskedTextBoxYas";
            this.maskedTextBoxYas.Size = new System.Drawing.Size(222, 26);
            this.maskedTextBoxYas.TabIndex = 44;
            this.maskedTextBoxYas.ValidatingType = typeof(System.DateTime);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.Location = new System.Drawing.Point(173, 443);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(132, 42);
            this.btnGüncelle.TabIndex = 43;
            this.btnGüncelle.Text = "GÜNCELLE";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(120, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 20);
            this.label10.TabIndex = 42;
            this.label10.Text = "Hasta Bilgi Gücelleme";
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniSifre.Location = new System.Drawing.Point(141, 366);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(222, 26);
            this.txtYeniSifre.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(30, 372);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "Yeni Şifre : ";
            // 
            // txtEskiSifre
            // 
            this.txtEskiSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEskiSifre.Location = new System.Drawing.Point(141, 334);
            this.txtEskiSifre.Name = "txtEskiSifre";
            this.txtEskiSifre.Size = new System.Drawing.Size(222, 26);
            this.txtEskiSifre.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(32, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Eski Şifre : ";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.Location = new System.Drawing.Point(141, 302);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(222, 26);
            this.txtEmail.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(55, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "E-Mail : ";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTel.Location = new System.Drawing.Point(141, 270);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(222, 26);
            this.txtTel.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(54, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Tel No : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(44, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Cinsiyet : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Doğum Tarihi : ";
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyisim.Location = new System.Drawing.Point(141, 174);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(222, 26);
            this.txtSoyisim.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(50, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Soyisim : ";
            // 
            // txtTC
            // 
            this.txtTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTC.Location = new System.Drawing.Point(141, 110);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(222, 26);
            this.txtTC.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(16, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "TC Kimlik No : ";
            // 
            // txtİsim
            // 
            this.txtİsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtİsim.Location = new System.Drawing.Point(141, 142);
            this.txtİsim.Name = "txtİsim";
            this.txtİsim.Size = new System.Drawing.Size(222, 26);
            this.txtİsim.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(75, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "İsim : ";
            // 
            // HastaBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 539);
            this.Controls.Add(this.CmbDoktorCinsiyet);
            this.Controls.Add(this.maskedTextBoxYas);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtYeniSifre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEskiSifre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoyisim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtİsim);
            this.Controls.Add(this.label1);
            this.Name = "HastaBilgileri";
            this.Text = "HastaBilgileri";
            this.Load += new System.EventHandler(this.HastaBilgileri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbDoktorCinsiyet;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxYas;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEskiSifre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtİsim;
        private System.Windows.Forms.Label label1;
    }
}