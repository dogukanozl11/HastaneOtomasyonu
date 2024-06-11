namespace SistemAnaliziVeTasarimi2.Laboratuvar
{
    partial class LaboratuvarKayıtOlSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaboratuvarKayıtOlSayfasi));
            this.btnLabPKayıtYap = new System.Windows.Forms.Button();
            this.txtLabPYaş = new System.Windows.Forms.MaskedTextBox();
            this.txtLabPTel = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbLabPCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtLabPSifre = new System.Windows.Forms.TextBox();
            this.txtLabPMail = new System.Windows.Forms.TextBox();
            this.txtLabPTC = new System.Windows.Forms.TextBox();
            this.txtLabPSoyisim = new System.Windows.Forms.TextBox();
            this.txtLabPİsim = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLabPKayıtYap
            // 
            this.btnLabPKayıtYap.BackColor = System.Drawing.Color.LawnGreen;
            this.btnLabPKayıtYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLabPKayıtYap.Location = new System.Drawing.Point(511, 302);
            this.btnLabPKayıtYap.Name = "btnLabPKayıtYap";
            this.btnLabPKayıtYap.Size = new System.Drawing.Size(246, 65);
            this.btnLabPKayıtYap.TabIndex = 26;
            this.btnLabPKayıtYap.Text = "Kayıt Yap";
            this.btnLabPKayıtYap.UseVisualStyleBackColor = false;
            this.btnLabPKayıtYap.Click += new System.EventHandler(this.btnLabPKayıtYap_Click);
            // 
            // txtLabPYaş
            // 
            this.txtLabPYaş.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLabPYaş.Location = new System.Drawing.Point(151, 323);
            this.txtLabPYaş.Mask = "00/00/0000";
            this.txtLabPYaş.Name = "txtLabPYaş";
            this.txtLabPYaş.Size = new System.Drawing.Size(246, 27);
            this.txtLabPYaş.TabIndex = 23;
            this.txtLabPYaş.ValidatingType = typeof(System.DateTime);
            // 
            // txtLabPTel
            // 
            this.txtLabPTel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLabPTel.Location = new System.Drawing.Point(511, 104);
            this.txtLabPTel.Mask = "(999) 000-0000";
            this.txtLabPTel.Name = "txtLabPTel";
            this.txtLabPTel.Size = new System.Drawing.Size(246, 27);
            this.txtLabPTel.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(515, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Şifre : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(515, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Telefon No : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(515, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "E-Mail :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(155, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cinsiyet : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(155, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "GG/AA/YYYY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(155, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "T.C Kimlik No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(155, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Soyisim :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(155, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "İsim :";
            // 
            // CmbLabPCinsiyet
            // 
            this.CmbLabPCinsiyet.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbLabPCinsiyet.FormattingEnabled = true;
            this.CmbLabPCinsiyet.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.CmbLabPCinsiyet.Location = new System.Drawing.Point(151, 402);
            this.CmbLabPCinsiyet.Name = "CmbLabPCinsiyet";
            this.CmbLabPCinsiyet.Size = new System.Drawing.Size(246, 27);
            this.CmbLabPCinsiyet.TabIndex = 21;
            // 
            // txtLabPSifre
            // 
            this.txtLabPSifre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabPSifre.Location = new System.Drawing.Point(511, 242);
            this.txtLabPSifre.Name = "txtLabPSifre";
            this.txtLabPSifre.Size = new System.Drawing.Size(246, 27);
            this.txtLabPSifre.TabIndex = 25;
            // 
            // txtLabPMail
            // 
            this.txtLabPMail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabPMail.Location = new System.Drawing.Point(511, 173);
            this.txtLabPMail.Name = "txtLabPMail";
            this.txtLabPMail.Size = new System.Drawing.Size(246, 27);
            this.txtLabPMail.TabIndex = 24;
            // 
            // txtLabPTC
            // 
            this.txtLabPTC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabPTC.Location = new System.Drawing.Point(151, 251);
            this.txtLabPTC.MaxLength = 11;
            this.txtLabPTC.Name = "txtLabPTC";
            this.txtLabPTC.Size = new System.Drawing.Size(246, 27);
            this.txtLabPTC.TabIndex = 20;
            // 
            // txtLabPSoyisim
            // 
            this.txtLabPSoyisim.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabPSoyisim.Location = new System.Drawing.Point(151, 178);
            this.txtLabPSoyisim.Name = "txtLabPSoyisim";
            this.txtLabPSoyisim.Size = new System.Drawing.Size(246, 27);
            this.txtLabPSoyisim.TabIndex = 13;
            // 
            // txtLabPİsim
            // 
            this.txtLabPİsim.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabPİsim.Location = new System.Drawing.Point(151, 94);
            this.txtLabPİsim.Name = "txtLabPİsim";
            this.txtLabPİsim.Size = new System.Drawing.Size(246, 27);
            this.txtLabPİsim.TabIndex = 10;
            // 
            // LaboratuvarKayıtOlSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btnLabPKayıtYap);
            this.Controls.Add(this.txtLabPYaş);
            this.Controls.Add(this.txtLabPTel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbLabPCinsiyet);
            this.Controls.Add(this.txtLabPSifre);
            this.Controls.Add(this.txtLabPMail);
            this.Controls.Add(this.txtLabPTC);
            this.Controls.Add(this.txtLabPSoyisim);
            this.Controls.Add(this.txtLabPİsim);
            this.Name = "LaboratuvarKayıtOlSayfasi";
            this.Text = "LaboratuvarKayıtOlSayfasi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLabPKayıtYap;
        private System.Windows.Forms.MaskedTextBox txtLabPYaş;
        private System.Windows.Forms.MaskedTextBox txtLabPTel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbLabPCinsiyet;
        private System.Windows.Forms.TextBox txtLabPSifre;
        private System.Windows.Forms.TextBox txtLabPMail;
        private System.Windows.Forms.TextBox txtLabPTC;
        private System.Windows.Forms.TextBox txtLabPSoyisim;
        private System.Windows.Forms.TextBox txtLabPİsim;
    }
}