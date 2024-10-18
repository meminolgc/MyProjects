namespace DapperNorthwind
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
			this.btnCategoryList = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtCategoryId = new System.Windows.Forms.TextBox();
			this.txtCategoryName = new System.Windows.Forms.TextBox();
			this.btnCreateCategory = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCategoryDescription = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCategoryList
			// 
			this.btnCategoryList.Location = new System.Drawing.Point(483, 289);
			this.btnCategoryList.Name = "btnCategoryList";
			this.btnCategoryList.Size = new System.Drawing.Size(146, 33);
			this.btnCategoryList.TabIndex = 0;
			this.btnCategoryList.Text = "Kategori Listesi";
			this.btnCategoryList.UseVisualStyleBackColor = true;
			this.btnCategoryList.Click += new System.EventHandler(this.btnCategoryList_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(7, 5);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(622, 278);
			this.dataGridView1.TabIndex = 1;
			// 
			// txtCategoryId
			// 
			this.txtCategoryId.Location = new System.Drawing.Point(191, 289);
			this.txtCategoryId.Name = "txtCategoryId";
			this.txtCategoryId.Size = new System.Drawing.Size(275, 26);
			this.txtCategoryId.TabIndex = 2;
			// 
			// txtCategoryName
			// 
			this.txtCategoryName.Location = new System.Drawing.Point(191, 321);
			this.txtCategoryName.Name = "txtCategoryName";
			this.txtCategoryName.Size = new System.Drawing.Size(275, 26);
			this.txtCategoryName.TabIndex = 3;
			// 
			// btnCreateCategory
			// 
			this.btnCreateCategory.Location = new System.Drawing.Point(483, 328);
			this.btnCreateCategory.Name = "btnCreateCategory";
			this.btnCreateCategory.Size = new System.Drawing.Size(146, 33);
			this.btnCreateCategory.TabIndex = 4;
			this.btnCreateCategory.Text = "Kategori Ekle";
			this.btnCreateCategory.UseVisualStyleBackColor = true;
			this.btnCreateCategory.Click += new System.EventHandler(this.btnCreateCategory_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(79, 294);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 18);
			this.label1.TabIndex = 5;
			this.label1.Text = "Kategori ID:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(70, 326);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(118, 18);
			this.label2.TabIndex = 6;
			this.label2.Text = "Kategori Adı:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(6, 358);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(182, 18);
			this.label3.TabIndex = 7;
			this.label3.Text = "Kategori Açıklaması:";
			// 
			// txtCategoryDescription
			// 
			this.txtCategoryDescription.Location = new System.Drawing.Point(191, 353);
			this.txtCategoryDescription.Multiline = true;
			this.txtCategoryDescription.Name = "txtCategoryDescription";
			this.txtCategoryDescription.Size = new System.Drawing.Size(275, 86);
			this.txtCategoryDescription.TabIndex = 8;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(483, 367);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(146, 33);
			this.button1.TabIndex = 9;
			this.button1.Text = "Kategori Sil";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(483, 406);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(146, 33);
			this.button2.TabIndex = 10;
			this.button2.Text = "Kategori Güncelle";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(643, 452);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtCategoryDescription);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCreateCategory);
			this.Controls.Add(this.txtCategoryName);
			this.Controls.Add(this.txtCategoryId);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnCategoryList);
			this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCategoryList;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtCategoryId;
		private System.Windows.Forms.TextBox txtCategoryName;
		private System.Windows.Forms.Button btnCreateCategory;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCategoryDescription;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}

