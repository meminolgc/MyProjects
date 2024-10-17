namespace AdonetCustomer
{
	partial class FrmMap
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
			this.btnOpenCityForm = new System.Windows.Forms.Button();
			this.btnOpenCustomerForm = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnOpenCityForm
			// 
			this.btnOpenCityForm.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnOpenCityForm.Location = new System.Drawing.Point(12, 33);
			this.btnOpenCityForm.Name = "btnOpenCityForm";
			this.btnOpenCityForm.Size = new System.Drawing.Size(230, 55);
			this.btnOpenCityForm.TabIndex = 0;
			this.btnOpenCityForm.Text = "Şehir İşlemleri";
			this.btnOpenCityForm.UseVisualStyleBackColor = true;
			this.btnOpenCityForm.Click += new System.EventHandler(this.btnOpenCityForm_Click);
			// 
			// btnOpenCustomerForm
			// 
			this.btnOpenCustomerForm.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnOpenCustomerForm.Location = new System.Drawing.Point(12, 94);
			this.btnOpenCustomerForm.Name = "btnOpenCustomerForm";
			this.btnOpenCustomerForm.Size = new System.Drawing.Size(230, 53);
			this.btnOpenCustomerForm.TabIndex = 1;
			this.btnOpenCustomerForm.Text = "Müşteri İşlemleri";
			this.btnOpenCustomerForm.UseVisualStyleBackColor = true;
			this.btnOpenCustomerForm.Click += new System.EventHandler(this.btnOpenCustomerForm_Click);
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnExit.Location = new System.Drawing.Point(12, 155);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(230, 53);
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "Çıkış Yap";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// FrmMap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(257, 238);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnOpenCustomerForm);
			this.Controls.Add(this.btnOpenCityForm);
			this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FrmMap";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Formlar";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnOpenCityForm;
		private System.Windows.Forms.Button btnOpenCustomerForm;
		private System.Windows.Forms.Button btnExit;
	}
}