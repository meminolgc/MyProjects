namespace WeatherApiApp
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
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureWeather = new System.Windows.Forms.PictureBox();
			this.lblCelsius = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lblF = new System.Windows.Forms.Label();
			this.lblWindSpeed = new System.Windows.Forms.Label();
			this.lblHumidity = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureWeather)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(17, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(289, 41);
			this.label1.TabIndex = 0;
			this.label1.Text = "ISTANBUL, TR";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(27, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(200, 31);
			this.label2.TabIndex = 3;
			this.label2.Text = "ISTANBUL, TR";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(32, 139);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 29);
			this.label4.TabIndex = 5;
			this.label4.Text = "Bugün";
			// 
			// pictureWeather
			// 
			this.pictureWeather.BackColor = System.Drawing.Color.Transparent;
			this.pictureWeather.Image = global::WeatherApiApp.Properties.Resources.sun;
			this.pictureWeather.Location = new System.Drawing.Point(24, 170);
			this.pictureWeather.Name = "pictureWeather";
			this.pictureWeather.Size = new System.Drawing.Size(156, 132);
			this.pictureWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureWeather.TabIndex = 2;
			this.pictureWeather.TabStop = false;
			// 
			// lblCelsius
			// 
			this.lblCelsius.AutoSize = true;
			this.lblCelsius.Font = new System.Drawing.Font("Georgia", 68.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblCelsius.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblCelsius.Location = new System.Drawing.Point(226, 170);
			this.lblCelsius.Name = "lblCelsius";
			this.lblCelsius.Size = new System.Drawing.Size(156, 104);
			this.lblCelsius.TabIndex = 11;
			this.lblCelsius.Text = "35";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label7.Location = new System.Drawing.Point(31, 340);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(67, 18);
			this.label7.TabIndex = 14;
			this.label7.Text = "Rüzgar";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label8.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label8.Location = new System.Drawing.Point(31, 369);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(46, 18);
			this.label8.TabIndex = 15;
			this.label8.Text = "Nem";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label9.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label9.Location = new System.Drawing.Point(31, 396);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(101, 18);
			this.label9.TabIndex = 16;
			this.label9.Text = "Fahrenheit";
			// 
			// lblF
			// 
			this.lblF.AutoSize = true;
			this.lblF.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblF.Location = new System.Drawing.Point(150, 396);
			this.lblF.Name = "lblF";
			this.lblF.Size = new System.Drawing.Size(18, 18);
			this.lblF.TabIndex = 17;
			this.lblF.Text = "0";
			// 
			// lblWindSpeed
			// 
			this.lblWindSpeed.AutoSize = true;
			this.lblWindSpeed.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblWindSpeed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblWindSpeed.Location = new System.Drawing.Point(150, 340);
			this.lblWindSpeed.Name = "lblWindSpeed";
			this.lblWindSpeed.Size = new System.Drawing.Size(18, 18);
			this.lblWindSpeed.TabIndex = 18;
			this.lblWindSpeed.Text = "0";
			// 
			// lblHumidity
			// 
			this.lblHumidity.AutoSize = true;
			this.lblHumidity.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblHumidity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblHumidity.Location = new System.Drawing.Point(150, 369);
			this.lblHumidity.Name = "lblHumidity";
			this.lblHumidity.Size = new System.Drawing.Size(18, 18);
			this.lblHumidity.TabIndex = 19;
			this.lblHumidity.Text = "0";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(133)))));
			this.ClientSize = new System.Drawing.Size(488, 485);
			this.Controls.Add(this.lblHumidity);
			this.Controls.Add(this.lblWindSpeed);
			this.Controls.Add(this.lblF);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lblCelsius);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureWeather);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WeatherApp";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureWeather)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureWeather;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblCelsius;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lblF;
		private System.Windows.Forms.Label lblWindSpeed;
		private System.Windows.Forms.Label lblHumidity;
	}
}

