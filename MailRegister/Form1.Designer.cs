﻿namespace MailRegister
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.btnRegister = new System.Windows.Forms.Button();
			this.txtSurname = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtConfirmPassword = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(59, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Adınız: ";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(135, 34);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(248, 26);
			this.txtName.TabIndex = 1;
			// 
			// btnRegister
			// 
			this.btnRegister.BackColor = System.Drawing.Color.White;
			this.btnRegister.Location = new System.Drawing.Point(271, 194);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(112, 30);
			this.btnRegister.TabIndex = 2;
			this.btnRegister.Text = "Kayıt Ol";
			this.btnRegister.UseVisualStyleBackColor = false;
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
			// 
			// txtSurname
			// 
			this.txtSurname.Location = new System.Drawing.Point(135, 66);
			this.txtSurname.Name = "txtSurname";
			this.txtSurname.Size = new System.Drawing.Size(248, 26);
			this.txtSurname.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(36, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 18);
			this.label2.TabIndex = 3;
			this.label2.Text = "Soyadınız:";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(135, 98);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(248, 26);
			this.txtEmail.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(69, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 18);
			this.label3.TabIndex = 5;
			this.label3.Text = "Email:";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(135, 130);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(248, 26);
			this.txtPassword.TabIndex = 8;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(53, 135);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(79, 18);
			this.label4.TabIndex = 7;
			this.label4.Text = "Şifreniz:";
			// 
			// txtConfirmPassword
			// 
			this.txtConfirmPassword.Location = new System.Drawing.Point(135, 162);
			this.txtConfirmPassword.Name = "txtConfirmPassword";
			this.txtConfirmPassword.Size = new System.Drawing.Size(248, 26);
			this.txtConfirmPassword.TabIndex = 10;
			this.txtConfirmPassword.UseSystemPasswordChar = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(18, 167);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(114, 18);
			this.label5.TabIndex = 9;
			this.label5.Text = "Şifre Tekrar:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(443, 320);
			this.Controls.Add(this.txtConfirmPassword);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtSurname);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnRegister);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "Kayıt Formu";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Button btnRegister;
		private System.Windows.Forms.TextBox txtSurname;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtConfirmPassword;
		private System.Windows.Forms.Label label5;
	}
}

