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
            this.txtHastaYaş = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxKanGrup = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHastaKayıtYap
            // 
            this.btnHastaKayıtYap.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnHastaKayıtYap.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.btnHastaKayıtYap.Location = new System.Drawing.Point(660, 330);
            this.btnHastaKayıtYap.Name = "btnHastaKayıtYap";
            this.btnHastaKayıtYap.Size = new System.Drawing.Size(222, 50);
            this.btnHastaKayıtYap.TabIndex = 22;
            this.btnHastaKayıtYap.Text = "Kayıt Yap";
            this.btnHastaKayıtYap.UseVisualStyleBackColor = false;
            this.btnHastaKayıtYap.Click += new System.EventHandler(this.btnHastaKayıtYap_Click);
            // 
            // txtHastaTel
            // 
            this.txtHastaTel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHastaTel.Location = new System.Drawing.Point(660, 210);
            this.txtHastaTel.Mask = "(999) 000-0000";
            this.txtHastaTel.Name = "txtHastaTel";
            this.txtHastaTel.Size = new System.Drawing.Size(222, 27);
            this.txtHastaTel.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label7.Location = new System.Drawing.Point(500, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Şifre : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label8.Location = new System.Drawing.Point(500, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Telefon No : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label6.Location = new System.Drawing.Point(500, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "E-Mail :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label5.Location = new System.Drawing.Point(70, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Cinsiyet : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label4.Location = new System.Drawing.Point(70, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Doğum Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label3.Location = new System.Drawing.Point(70, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "T.C Kimlik No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label2.Location = new System.Drawing.Point(70, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Soyisim :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.Location = new System.Drawing.Point(70, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
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
            this.CmbHastaCinsiyet.Location = new System.Drawing.Point(250, 330);
            this.CmbHastaCinsiyet.Name = "CmbHastaCinsiyet";
            this.CmbHastaCinsiyet.Size = new System.Drawing.Size(222, 27);
            this.CmbHastaCinsiyet.TabIndex = 12;
            // 
            // txtHastaSifre
            // 
            this.txtHastaSifre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHastaSifre.Location = new System.Drawing.Point(660, 290);
            this.txtHastaSifre.Name = "txtHastaSifre";
            this.txtHastaSifre.Size = new System.Drawing.Size(222, 27);
            this.txtHastaSifre.TabIndex = 10;
            // 
            // txtHastaMail
            // 
            this.txtHastaMail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHastaMail.Location = new System.Drawing.Point(660, 250);
            this.txtHastaMail.Name = "txtHastaMail";
            this.txtHastaMail.Size = new System.Drawing.Size(222, 27);
            this.txtHastaMail.TabIndex = 9;
            // 
            // txtHastaTC
            // 
            this.txtHastaTC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHastaTC.Location = new System.Drawing.Point(250, 250);
            this.txtHastaTC.MaxLength = 11;
            this.txtHastaTC.Name = "txtHastaTC";
            this.txtHastaTC.Size = new System.Drawing.Size(222, 27);
            this.txtHastaTC.TabIndex = 8;
            // 
            // txtHastaSoyisim
            // 
            this.txtHastaSoyisim.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHastaSoyisim.Location = new System.Drawing.Point(250, 210);
            this.txtHastaSoyisim.Name = "txtHastaSoyisim";
            this.txtHastaSoyisim.Size = new System.Drawing.Size(222, 27);
            this.txtHastaSoyisim.TabIndex = 11;
            // 
            // txtHastaİsim
            // 
            this.txtHastaİsim.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHastaİsim.Location = new System.Drawing.Point(250, 170);
            this.txtHastaİsim.Name = "txtHastaİsim";
            this.txtHastaİsim.Size = new System.Drawing.Size(222, 27);
            this.txtHastaİsim.TabIndex = 6;
            // 
            // txtHastaYaş
            // 
            this.txtHastaYaş.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHastaYaş.Location = new System.Drawing.Point(250, 290);
            this.txtHastaYaş.Mask = "00/00/0000";
            this.txtHastaYaş.Name = "txtHastaYaş";
            this.txtHastaYaş.Size = new System.Drawing.Size(222, 27);
            this.txtHastaYaş.TabIndex = 21;
            this.txtHastaYaş.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label9.Location = new System.Drawing.Point(500, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "Kan Grubu :";
            // 
            // comboBoxKanGrup
            // 
            this.comboBoxKanGrup.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxKanGrup.FormattingEnabled = true;
            this.comboBoxKanGrup.Items.AddRange(new object[] {
            "A   R+",
            "A   R-",
            "B   R+",
            "B   R-",
            "AB R+",
            "AB R-",
            "0    R+",
            "0    R-"});
            this.comboBoxKanGrup.Location = new System.Drawing.Point(660, 170);
            this.comboBoxKanGrup.Name = "comboBoxKanGrup";
            this.comboBoxKanGrup.Size = new System.Drawing.Size(222, 27);
            this.comboBoxKanGrup.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Bookman Old Style", 24F);
            this.label10.Location = new System.Drawing.Point(372, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(289, 39);
            this.label10.TabIndex = 43;
            this.label10.Text = "HASTA KAYIT OL";
            // 
            // HastaKayıtOlSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxKanGrup);
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
        private System.Windows.Forms.MaskedTextBox txtHastaYaş;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxKanGrup;
        private System.Windows.Forms.Label label10;
    }
}