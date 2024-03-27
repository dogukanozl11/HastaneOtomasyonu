namespace SistemAnaliziVeTasarimi2.Hasta
{
    partial class HastaKayıtOlSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaKayıtOlSayfasi));
            this.btnHastaKayıtYap = new System.Windows.Forms.Button();
            this.txtHastaTel = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbHastaCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtHastaSifre = new System.Windows.Forms.TextBox();
            this.txtHastaMail = new System.Windows.Forms.TextBox();
            this.txtHastaTC = new System.Windows.Forms.TextBox();
            this.txtHastaSoyisim = new System.Windows.Forms.TextBox();
            this.txtHastaİsim = new System.Windows.Forms.TextBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.txtHastaYaş = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnHastaKayıtYap
            // 
            this.btnHastaKayıtYap.BackColor = System.Drawing.Color.LawnGreen;
            this.btnHastaKayıtYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastaKayıtYap.Location = new System.Drawing.Point(161, 668);
            this.btnHastaKayıtYap.Name = "btnHastaKayıtYap";
            this.btnHastaKayıtYap.Size = new System.Drawing.Size(246, 65);
            this.btnHastaKayıtYap.TabIndex = 22;
            this.btnHastaKayıtYap.Text = "Kayıt Yap";
            this.btnHastaKayıtYap.UseVisualStyleBackColor = false;
            this.btnHastaKayıtYap.Click += new System.EventHandler(this.btnHastaKayıtYap_Click);
            // 
            // txtHastaTel
            // 
            this.txtHastaTel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHastaTel.Location = new System.Drawing.Point(161, 470);
            this.txtHastaTel.Mask = "(999) 000-0000";
            this.txtHastaTel.Name = "txtHastaTel";
            this.txtHastaTel.Size = new System.Drawing.Size(246, 27);
            this.txtHastaTel.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(165, 580);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Şifre : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(165, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Telefon No : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(165, 511);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "E-Mail :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(165, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Cinsiyet : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(165, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "GG/AA/YYYY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(165, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "T.C Kimlik No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(165, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Soyisim :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(165, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "İsim :";
            // 
            // CmbHastaCinsiyet
            // 
            this.CmbHastaCinsiyet.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbHastaCinsiyet.FormattingEnabled = true;
            this.CmbHastaCinsiyet.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.CmbHastaCinsiyet.Location = new System.Drawing.Point(161, 403);
            this.CmbHastaCinsiyet.Name = "CmbHastaCinsiyet";
            this.CmbHastaCinsiyet.Size = new System.Drawing.Size(246, 27);
            this.CmbHastaCinsiyet.TabIndex = 12;
            // 
            // txtHastaSifre
            // 
            this.txtHastaSifre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHastaSifre.Location = new System.Drawing.Point(161, 608);
            this.txtHastaSifre.Name = "txtHastaSifre";
            this.txtHastaSifre.Size = new System.Drawing.Size(246, 27);
            this.txtHastaSifre.TabIndex = 10;
            // 
            // txtHastaMail
            // 
            this.txtHastaMail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHastaMail.Location = new System.Drawing.Point(161, 539);
            this.txtHastaMail.Name = "txtHastaMail";
            this.txtHastaMail.Size = new System.Drawing.Size(246, 27);
            this.txtHastaMail.TabIndex = 9;
            // 
            // txtHastaTC
            // 
            this.txtHastaTC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHastaTC.Location = new System.Drawing.Point(161, 252);
            this.txtHastaTC.Name = "txtHastaTC";
            this.txtHastaTC.Size = new System.Drawing.Size(246, 27);
            this.txtHastaTC.TabIndex = 8;
            // 
            // txtHastaSoyisim
            // 
            this.txtHastaSoyisim.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHastaSoyisim.Location = new System.Drawing.Point(161, 179);
            this.txtHastaSoyisim.Name = "txtHastaSoyisim";
            this.txtHastaSoyisim.Size = new System.Drawing.Size(246, 27);
            this.txtHastaSoyisim.TabIndex = 11;
            // 
            // txtHastaİsim
            // 
            this.txtHastaİsim.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHastaİsim.Location = new System.Drawing.Point(161, 95);
            this.txtHastaİsim.Name = "txtHastaİsim";
            this.txtHastaİsim.Size = new System.Drawing.Size(246, 27);
            this.txtHastaİsim.TabIndex = 6;
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Red;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(1, 1);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(45, 35);
            this.btnGeri.TabIndex = 23;
            this.btnGeri.Text = "<";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // txtHastaYaş
            // 
            this.txtHastaYaş.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHastaYaş.Location = new System.Drawing.Point(161, 324);
            this.txtHastaYaş.Mask = "00/00/0000";
            this.txtHastaYaş.Name = "txtHastaYaş";
            this.txtHastaYaş.Size = new System.Drawing.Size(246, 27);
            this.txtHastaYaş.TabIndex = 21;
            this.txtHastaYaş.ValidatingType = typeof(System.DateTime);
            // 
            // HastaKayıtOlSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnHastaKayıtYap);
            this.Controls.Add(this.txtHastaYaş);
            this.Controls.Add(this.txtHastaTel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbHastaCinsiyet);
            this.Controls.Add(this.txtHastaSifre);
            this.Controls.Add(this.txtHastaMail);
            this.Controls.Add(this.txtHastaTC);
            this.Controls.Add(this.txtHastaSoyisim);
            this.Controls.Add(this.txtHastaİsim);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HastaKayıtOlSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HastaKayıtOlSayfasi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHastaKayıtYap;
        private System.Windows.Forms.MaskedTextBox txtHastaTel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbHastaCinsiyet;
        private System.Windows.Forms.TextBox txtHastaSifre;
        private System.Windows.Forms.TextBox txtHastaMail;
        private System.Windows.Forms.TextBox txtHastaTC;
        private System.Windows.Forms.TextBox txtHastaSoyisim;
        private System.Windows.Forms.TextBox txtHastaİsim;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.MaskedTextBox txtHastaYaş;
    }
}