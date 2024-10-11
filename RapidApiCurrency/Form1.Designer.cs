namespace RapidApiCurrency
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
			this.lblDolar = new System.Windows.Forms.Label();
			this.lblEuro = new System.Windows.Forms.Label();
			this.txtUnitPrice = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.rdbDollar = new System.Windows.Forms.RadioButton();
			this.rdbEuro = new System.Windows.Forms.RadioButton();
			this.rdbPound = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTotalPrice = new System.Windows.Forms.TextBox();
			this.lblPound = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblDolar
			// 
			this.lblDolar.AutoSize = true;
			this.lblDolar.Location = new System.Drawing.Point(25, 28);
			this.lblDolar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDolar.Name = "lblDolar";
			this.lblDolar.Size = new System.Drawing.Size(55, 18);
			this.lblDolar.TabIndex = 0;
			this.lblDolar.Text = "Dolar: ";
			// 
			// lblEuro
			// 
			this.lblEuro.AutoSize = true;
			this.lblEuro.Location = new System.Drawing.Point(196, 28);
			this.lblEuro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblEuro.Name = "lblEuro";
			this.lblEuro.Size = new System.Drawing.Size(51, 18);
			this.lblEuro.TabIndex = 2;
			this.lblEuro.Text = "Euro: ";
			// 
			// txtUnitPrice
			// 
			this.txtUnitPrice.Location = new System.Drawing.Point(149, 131);
			this.txtUnitPrice.Name = "txtUnitPrice";
			this.txtUnitPrice.Size = new System.Drawing.Size(199, 26);
			this.txtUnitPrice.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(48, 137);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 18);
			this.label1.TabIndex = 5;
			this.label1.Text = "Birim Tutar: ";
			// 
			// rdbDollar
			// 
			this.rdbDollar.AutoSize = true;
			this.rdbDollar.Location = new System.Drawing.Point(54, 85);
			this.rdbDollar.Name = "rdbDollar";
			this.rdbDollar.Size = new System.Drawing.Size(64, 22);
			this.rdbDollar.TabIndex = 6;
			this.rdbDollar.TabStop = true;
			this.rdbDollar.Text = "Dolar";
			this.rdbDollar.UseVisualStyleBackColor = true;
			// 
			// rdbEuro
			// 
			this.rdbEuro.AutoSize = true;
			this.rdbEuro.Location = new System.Drawing.Point(156, 85);
			this.rdbEuro.Name = "rdbEuro";
			this.rdbEuro.Size = new System.Drawing.Size(60, 22);
			this.rdbEuro.TabIndex = 7;
			this.rdbEuro.TabStop = true;
			this.rdbEuro.Text = "Euro";
			this.rdbEuro.UseVisualStyleBackColor = true;
			// 
			// rdbPound
			// 
			this.rdbPound.AutoSize = true;
			this.rdbPound.Location = new System.Drawing.Point(244, 85);
			this.rdbPound.Name = "rdbPound";
			this.rdbPound.Size = new System.Drawing.Size(71, 22);
			this.rdbPound.TabIndex = 8;
			this.rdbPound.TabStop = true;
			this.rdbPound.Text = "Pound";
			this.rdbPound.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(198, 210);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(150, 32);
			this.button1.TabIndex = 9;
			this.button1.Text = "İşlemi Yap";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 170);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 18);
			this.label2.TabIndex = 11;
			this.label2.Text = "Ödenecek Tutar: ";
			// 
			// txtTotalPrice
			// 
			this.txtTotalPrice.Enabled = false;
			this.txtTotalPrice.Location = new System.Drawing.Point(151, 164);
			this.txtTotalPrice.Name = "txtTotalPrice";
			this.txtTotalPrice.Size = new System.Drawing.Size(197, 26);
			this.txtTotalPrice.TabIndex = 10;
			// 
			// lblPound
			// 
			this.lblPound.AutoSize = true;
			this.lblPound.Location = new System.Drawing.Point(350, 29);
			this.lblPound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPound.Name = "lblPound";
			this.lblPound.Size = new System.Drawing.Size(58, 18);
			this.lblPound.TabIndex = 12;
			this.lblPound.Text = "Pound:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(526, 276);
			this.Controls.Add(this.lblPound);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtTotalPrice);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.rdbPound);
			this.Controls.Add(this.rdbEuro);
			this.Controls.Add(this.rdbDollar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtUnitPrice);
			this.Controls.Add(this.lblEuro);
			this.Controls.Add(this.lblDolar);
			this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "Currency ";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblDolar;
		private System.Windows.Forms.Label lblEuro;
		private System.Windows.Forms.TextBox txtUnitPrice;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rdbDollar;
		private System.Windows.Forms.RadioButton rdbEuro;
		private System.Windows.Forms.RadioButton rdbPound;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTotalPrice;
		private System.Windows.Forms.Label lblPound;
	}
}

