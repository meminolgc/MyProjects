﻿namespace JWToken
{
	partial class FrmLogin
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
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnGirisYap = new System.Windows.Forms.Button();
			this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(140, 75);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(194, 26);
			this.txtPassword.TabIndex = 11;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(91, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 18);
			this.label2.TabIndex = 10;
			this.label2.Text = "Şifre:";
			// 
			// btnGirisYap
			// 
			this.btnGirisYap.Location = new System.Drawing.Point(170, 112);
			this.btnGirisYap.Name = "btnGirisYap";
			this.btnGirisYap.Size = new System.Drawing.Size(126, 31);
			this.btnGirisYap.TabIndex = 8;
			this.btnGirisYap.Text = "Giriş Yap";
			this.btnGirisYap.UseVisualStyleBackColor = true;
			this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
			// 
			// txtKullaniciAdi
			// 
			this.txtKullaniciAdi.Location = new System.Drawing.Point(140, 38);
			this.txtKullaniciAdi.Name = "txtKullaniciAdi";
			this.txtKullaniciAdi.Size = new System.Drawing.Size(194, 26);
			this.txtKullaniciAdi.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 18);
			this.label1.TabIndex = 6;
			this.label1.Text = "Kullanıcı Adı:";
			// 
			// FrmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(387, 189);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnGirisYap);
			this.Controls.Add(this.txtKullaniciAdi);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FrmLogin";
			this.Text = "Giriş Formu";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnGirisYap;
		private System.Windows.Forms.TextBox txtKullaniciAdi;
		private System.Windows.Forms.Label label1;
	}
}

