﻿namespace SistemAnaliziVeTasarimi2
{
    partial class Admin
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.btnAdminGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSekreterKayitGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtid.Location = new System.Drawing.Point(98, 93);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(182, 27);
            this.txtid.TabIndex = 0;
            // 
            // txtsifre
            // 
            this.txtsifre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifre.Location = new System.Drawing.Point(98, 173);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(182, 27);
            this.txtsifre.TabIndex = 0;
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.Location = new System.Drawing.Point(98, 206);
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(182, 47);
            this.btnAdminGiris.TabIndex = 1;
            this.btnAdminGiris.Text = "Giriş Yap";
            this.btnAdminGiris.UseVisualStyleBackColor = true;
            this.btnAdminGiris.Click += new System.EventHandler(this.btnAdminGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(102, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(102, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre  :";
            // 
            // btnSekreterKayitGeri
            // 
            this.btnSekreterKayitGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSekreterKayitGeri.Location = new System.Drawing.Point(2, 3);
            this.btnSekreterKayitGeri.Name = "btnSekreterKayitGeri";
            this.btnSekreterKayitGeri.Size = new System.Drawing.Size(45, 35);
            this.btnSekreterKayitGeri.TabIndex = 5;
            this.btnSekreterKayitGeri.Text = "<";
            this.btnSekreterKayitGeri.UseVisualStyleBackColor = true;
            this.btnSekreterKayitGeri.Click += new System.EventHandler(this.btnSekreterKayitGeri_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 308);
            this.Controls.Add(this.btnSekreterKayitGeri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdminGiris);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtid);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Button btnAdminGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSekreterKayitGeri;
    }
}