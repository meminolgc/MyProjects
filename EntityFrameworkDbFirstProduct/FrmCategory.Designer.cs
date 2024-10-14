namespace EntityFrameworkDbFirstProduct
{
	partial class FrmCategory
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
			this.btnEkle = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtKategoriAd = new System.Windows.Forms.TextBox();
			this.btnSil = new System.Windows.Forms.Button();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.btnAra = new System.Windows.Forms.Button();
			this.btnListele = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnEkle
			// 
			this.btnEkle.Location = new System.Drawing.Point(121, 120);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(127, 28);
			this.btnEkle.TabIndex = 0;
			this.btnEkle.Text = "Ekle";
			this.btnEkle.UseVisualStyleBackColor = true;
			this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "Kategori ID:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(305, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(498, 241);
			this.dataGridView1.TabIndex = 2;
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(117, 12);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(182, 26);
			this.txtID.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 18);
			this.label2.TabIndex = 4;
			this.label2.Text = "Kategori Adı:";
			// 
			// txtKategoriAd
			// 
			this.txtKategoriAd.Location = new System.Drawing.Point(117, 44);
			this.txtKategoriAd.Name = "txtKategoriAd";
			this.txtKategoriAd.Size = new System.Drawing.Size(182, 26);
			this.txtKategoriAd.TabIndex = 5;
			// 
			// btnSil
			// 
			this.btnSil.Location = new System.Drawing.Point(121, 154);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(127, 28);
			this.btnSil.TabIndex = 6;
			this.btnSil.Text = "Sil";
			this.btnSil.UseVisualStyleBackColor = true;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Location = new System.Drawing.Point(121, 191);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(127, 28);
			this.btnGuncelle.TabIndex = 7;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = true;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// btnAra
			// 
			this.btnAra.Location = new System.Drawing.Point(121, 225);
			this.btnAra.Name = "btnAra";
			this.btnAra.Size = new System.Drawing.Size(127, 28);
			this.btnAra.TabIndex = 8;
			this.btnAra.Text = "Ara";
			this.btnAra.UseVisualStyleBackColor = true;
			// 
			// btnListele
			// 
			this.btnListele.Location = new System.Drawing.Point(121, 86);
			this.btnListele.Name = "btnListele";
			this.btnListele.Size = new System.Drawing.Size(127, 28);
			this.btnListele.TabIndex = 9;
			this.btnListele.Text = "Listele";
			this.btnListele.UseVisualStyleBackColor = true;
			this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
			// 
			// FrmCategory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(815, 274);
			this.Controls.Add(this.btnListele);
			this.Controls.Add(this.btnAra);
			this.Controls.Add(this.btnGuncelle);
			this.Controls.Add(this.btnSil);
			this.Controls.Add(this.txtKategoriAd);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnEkle);
			this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FrmCategory";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kategori İşlemleri";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnEkle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtKategoriAd;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.Button btnAra;
		private System.Windows.Forms.Button btnListele;
	}
}

