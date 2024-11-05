namespace GasPriceSimulation_
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtGasAmount = new System.Windows.Forms.TextBox();
			this.txtTotalPrice = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.btnStart = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtDieselPrice = new System.Windows.Forms.TextBox();
			this.txtGasolinePrice = new System.Windows.Forms.TextBox();
			this.txtLpgPrice = new System.Windows.Forms.TextBox();
			this.rdbGasoline = new System.Windows.Forms.RadioButton();
			this.rdbDiesel = new System.Windows.Forms.RadioButton();
			this.rdbLpg = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MV Boli", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(198, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(553, 70);
			this.label1.TabIndex = 0;
			this.label1.Text = "Gas Price Simulation";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Cursor = System.Windows.Forms.Cursors.Default;
			this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(26, 101);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Yakıt Miktarı:";
			// 
			// txtGasAmount
			// 
			this.txtGasAmount.Location = new System.Drawing.Point(154, 96);
			this.txtGasAmount.Name = "txtGasAmount";
			this.txtGasAmount.Size = new System.Drawing.Size(154, 26);
			this.txtGasAmount.TabIndex = 2;
			// 
			// txtTotalPrice
			// 
			this.txtTotalPrice.Location = new System.Drawing.Point(154, 128);
			this.txtTotalPrice.Name = "txtTotalPrice";
			this.txtTotalPrice.Size = new System.Drawing.Size(154, 26);
			this.txtTotalPrice.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Cursor = System.Windows.Forms.Cursors.Default;
			this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.ForeColor = System.Drawing.SystemColors.Control;
			this.label3.Location = new System.Drawing.Point(20, 133);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(131, 18);
			this.label3.TabIndex = 3;
			this.label3.Text = "Toplam Tutar:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Cursor = System.Windows.Forms.Cursors.Default;
			this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.ForeColor = System.Drawing.SystemColors.Control;
			this.label4.Location = new System.Drawing.Point(10, 168);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(142, 18);
			this.label4.TabIndex = 5;
			this.label4.Text = "Dolum Durumu:";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(155, 161);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(268, 28);
			this.progressBar1.TabIndex = 6;
			// 
			// btnStart
			// 
			this.btnStart.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnStart.Location = new System.Drawing.Point(17, 280);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(135, 32);
			this.btnStart.TabIndex = 7;
			this.btnStart.Text = "Dolum Yap";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtLpgPrice);
			this.groupBox1.Controls.Add(this.txtDieselPrice);
			this.groupBox1.Controls.Add(this.txtGasolinePrice);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Location = new System.Drawing.Point(441, 95);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(335, 179);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Fiyatlar";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Cursor = System.Windows.Forms.Cursors.Default;
			this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.ForeColor = System.Drawing.SystemColors.Control;
			this.label5.Location = new System.Drawing.Point(48, 109);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 18);
			this.label5.TabIndex = 8;
			this.label5.Text = "LPG:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Cursor = System.Windows.Forms.Cursors.Default;
			this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.ForeColor = System.Drawing.SystemColors.Control;
			this.label6.Location = new System.Drawing.Point(16, 72);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(81, 18);
			this.label6.TabIndex = 7;
			this.label6.Text = "Motorin:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Cursor = System.Windows.Forms.Cursors.Default;
			this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.ForeColor = System.Drawing.SystemColors.Control;
			this.label7.Location = new System.Drawing.Point(26, 34);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(71, 18);
			this.label7.TabIndex = 6;
			this.label7.Text = "Benzin:";
			// 
			// txtDieselPrice
			// 
			this.txtDieselPrice.Location = new System.Drawing.Point(100, 67);
			this.txtDieselPrice.Name = "txtDieselPrice";
			this.txtDieselPrice.ReadOnly = true;
			this.txtDieselPrice.Size = new System.Drawing.Size(171, 26);
			this.txtDieselPrice.TabIndex = 10;
			// 
			// txtGasolinePrice
			// 
			this.txtGasolinePrice.Location = new System.Drawing.Point(100, 30);
			this.txtGasolinePrice.Name = "txtGasolinePrice";
			this.txtGasolinePrice.ReadOnly = true;
			this.txtGasolinePrice.Size = new System.Drawing.Size(171, 26);
			this.txtGasolinePrice.TabIndex = 9;
			// 
			// txtLpgPrice
			// 
			this.txtLpgPrice.Location = new System.Drawing.Point(100, 104);
			this.txtLpgPrice.Name = "txtLpgPrice";
			this.txtLpgPrice.ReadOnly = true;
			this.txtLpgPrice.Size = new System.Drawing.Size(171, 26);
			this.txtLpgPrice.TabIndex = 11;
			// 
			// rdbGasoline
			// 
			this.rdbGasoline.AutoSize = true;
			this.rdbGasoline.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
			this.rdbGasoline.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.rdbGasoline.Location = new System.Drawing.Point(55, 34);
			this.rdbGasoline.Name = "rdbGasoline";
			this.rdbGasoline.Size = new System.Drawing.Size(83, 22);
			this.rdbGasoline.TabIndex = 9;
			this.rdbGasoline.TabStop = true;
			this.rdbGasoline.Text = "Benzin";
			this.rdbGasoline.UseVisualStyleBackColor = true;
			// 
			// rdbDiesel
			// 
			this.rdbDiesel.AutoSize = true;
			this.rdbDiesel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
			this.rdbDiesel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.rdbDiesel.Location = new System.Drawing.Point(169, 34);
			this.rdbDiesel.Name = "rdbDiesel";
			this.rdbDiesel.Size = new System.Drawing.Size(93, 22);
			this.rdbDiesel.TabIndex = 10;
			this.rdbDiesel.TabStop = true;
			this.rdbDiesel.Text = "Motorin";
			this.rdbDiesel.UseVisualStyleBackColor = true;
			// 
			// rdbLpg
			// 
			this.rdbLpg.AutoSize = true;
			this.rdbLpg.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
			this.rdbLpg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.rdbLpg.Location = new System.Drawing.Point(293, 34);
			this.rdbLpg.Name = "rdbLpg";
			this.rdbLpg.Size = new System.Drawing.Size(58, 22);
			this.rdbLpg.TabIndex = 11;
			this.rdbLpg.TabStop = true;
			this.rdbLpg.Text = "Gaz";
			this.rdbLpg.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rdbGasoline);
			this.groupBox2.Controls.Add(this.rdbLpg);
			this.groupBox2.Controls.Add(this.rdbDiesel);
			this.groupBox2.Location = new System.Drawing.Point(14, 195);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(409, 79);
			this.groupBox2.TabIndex = 12;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Yakıt Türü";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Firebrick;
			this.ClientSize = new System.Drawing.Size(915, 332);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtTotalPrice);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtGasAmount);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtGasAmount;
		private System.Windows.Forms.TextBox txtTotalPrice;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtLpgPrice;
		private System.Windows.Forms.TextBox txtDieselPrice;
		private System.Windows.Forms.TextBox txtGasolinePrice;
		private System.Windows.Forms.RadioButton rdbGasoline;
		private System.Windows.Forms.RadioButton rdbDiesel;
		private System.Windows.Forms.RadioButton rdbLpg;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}

