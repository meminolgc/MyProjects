namespace MailRegister
{
	partial class FrmMailConfirm
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
			this.txtEmailAdress = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtConfirmCode = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnConfirm = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtEmailAdress
			// 
			this.txtEmailAdress.Location = new System.Drawing.Point(179, 59);
			this.txtEmailAdress.Name = "txtEmailAdress";
			this.txtEmailAdress.Size = new System.Drawing.Size(248, 26);
			this.txtEmailAdress.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(55, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(121, 18);
			this.label1.TabIndex = 2;
			this.label1.Text = "Email Adresi:";
			// 
			// txtConfirmCode
			// 
			this.txtConfirmCode.Location = new System.Drawing.Point(179, 91);
			this.txtConfirmCode.Name = "txtConfirmCode";
			this.txtConfirmCode.Size = new System.Drawing.Size(248, 26);
			this.txtConfirmCode.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(13, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(163, 18);
			this.label2.TabIndex = 4;
			this.label2.Text = "6 Haneli Kodunuz:";
			// 
			// btnConfirm
			// 
			this.btnConfirm.BackColor = System.Drawing.Color.White;
			this.btnConfirm.Location = new System.Drawing.Point(250, 123);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new System.Drawing.Size(177, 37);
			this.btnConfirm.TabIndex = 6;
			this.btnConfirm.Text = "Aktivasyonu Tamamla";
			this.btnConfirm.UseVisualStyleBackColor = false;
			this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
			// 
			// FrmMailConfirm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.ClientSize = new System.Drawing.Size(458, 221);
			this.Controls.Add(this.btnConfirm);
			this.Controls.Add(this.txtConfirmCode);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtEmailAdress);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmMailConfirm";
			this.Text = "Mail Aktivasyon Formu";
			this.Load += new System.EventHandler(this.FrmMailConfirm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtEmailAdress;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtConfirmCode;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnConfirm;
	}
}