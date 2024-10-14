namespace EntityFrameworkDbFirstProduct
{
	partial class FrmProduct
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
			this.btnListele = new System.Windows.Forms.Button();
			this.btnAra = new System.Windows.Forms.Button();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.btnSil = new System.Windows.Forms.Button();
			this.txtUrunAd = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUrunID = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.btnEkle = new System.Windows.Forms.Button();
			this.txtProductStock = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtProductPrice = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cmbProductCategory = new System.Windows.Forms.ComboBox();
			this.btnProductListWithCategory = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnListele
			// 
			this.btnListele.Location = new System.Drawing.Point(123, 177);
			this.btnListele.Name = "btnListele";
			this.btnListele.Size = new System.Drawing.Size(79, 28);
			this.btnListele.TabIndex = 19;
			this.btnListele.Text = "Listele";
			this.btnListele.UseVisualStyleBackColor = true;
			this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
			// 
			// btnAra
			// 
			this.btnAra.Location = new System.Drawing.Point(123, 316);
			this.btnAra.Name = "btnAra";
			this.btnAra.Size = new System.Drawing.Size(182, 28);
			this.btnAra.TabIndex = 18;
			this.btnAra.Text = "Ara";
			this.btnAra.UseVisualStyleBackColor = true;
			this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Location = new System.Drawing.Point(123, 282);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(182, 28);
			this.btnGuncelle.TabIndex = 17;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = true;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// btnSil
			// 
			this.btnSil.Location = new System.Drawing.Point(123, 245);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(182, 28);
			this.btnSil.TabIndex = 16;
			this.btnSil.Text = "Sil";
			this.btnSil.UseVisualStyleBackColor = true;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// txtUrunAd
			// 
			this.txtUrunAd.Location = new System.Drawing.Point(123, 46);
			this.txtUrunAd.Name = "txtUrunAd";
			this.txtUrunAd.Size = new System.Drawing.Size(182, 26);
			this.txtUrunAd.TabIndex = 15;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(42, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 18);
			this.label2.TabIndex = 14;
			this.label2.Text = "Ürün Adı:";
			// 
			// txtUrunID
			// 
			this.txtUrunID.Location = new System.Drawing.Point(123, 14);
			this.txtUrunID.Name = "txtUrunID";
			this.txtUrunID.Size = new System.Drawing.Size(182, 26);
			this.txtUrunID.TabIndex = 13;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(313, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(790, 332);
			this.dataGridView1.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(47, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 18);
			this.label1.TabIndex = 11;
			this.label1.Text = "Ürün ID:";
			// 
			// btnEkle
			// 
			this.btnEkle.Location = new System.Drawing.Point(123, 211);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(182, 28);
			this.btnEkle.TabIndex = 10;
			this.btnEkle.Text = "Ekle";
			this.btnEkle.UseVisualStyleBackColor = true;
			this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
			// 
			// txtProductStock
			// 
			this.txtProductStock.Location = new System.Drawing.Point(123, 110);
			this.txtProductStock.Name = "txtProductStock";
			this.txtProductStock.Size = new System.Drawing.Size(182, 26);
			this.txtProductStock.TabIndex = 23;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(35, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 18);
			this.label3.TabIndex = 22;
			this.label3.Text = "Ürün Stok:";
			// 
			// txtProductPrice
			// 
			this.txtProductPrice.Location = new System.Drawing.Point(123, 78);
			this.txtProductPrice.Name = "txtProductPrice";
			this.txtProductPrice.Size = new System.Drawing.Size(182, 26);
			this.txtProductPrice.TabIndex = 21;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(30, 83);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(91, 18);
			this.label4.TabIndex = 20;
			this.label4.Text = "Ürün Fiyat:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(7, 150);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(114, 18);
			this.label6.TabIndex = 24;
			this.label6.Text = "Ürün Kategori:";
			// 
			// cmbProductCategory
			// 
			this.cmbProductCategory.FormattingEnabled = true;
			this.cmbProductCategory.Location = new System.Drawing.Point(123, 145);
			this.cmbProductCategory.Name = "cmbProductCategory";
			this.cmbProductCategory.Size = new System.Drawing.Size(182, 26);
			this.cmbProductCategory.TabIndex = 25;
			// 
			// btnProductListWithCategory
			// 
			this.btnProductListWithCategory.Location = new System.Drawing.Point(219, 177);
			this.btnProductListWithCategory.Name = "btnProductListWithCategory";
			this.btnProductListWithCategory.Size = new System.Drawing.Size(86, 28);
			this.btnProductListWithCategory.TabIndex = 26;
			this.btnProductListWithCategory.Text = "Listele";
			this.btnProductListWithCategory.UseVisualStyleBackColor = true;
			this.btnProductListWithCategory.Click += new System.EventHandler(this.btnProductListWithCategory_Click);
			// 
			// FrmProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1115, 366);
			this.Controls.Add(this.btnProductListWithCategory);
			this.Controls.Add(this.cmbProductCategory);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtProductStock);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtProductPrice);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnListele);
			this.Controls.Add(this.btnAra);
			this.Controls.Add(this.btnGuncelle);
			this.Controls.Add(this.btnSil);
			this.Controls.Add(this.txtUrunAd);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtUrunID);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnEkle);
			this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FrmProduct";
			this.Text = "FrmProduct";
			this.Load += new System.EventHandler(this.FrmProduct_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnListele;
		private System.Windows.Forms.Button btnAra;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.TextBox txtUrunAd;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUrunID;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnEkle;
		private System.Windows.Forms.TextBox txtProductStock;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtProductPrice;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbProductCategory;
		private System.Windows.Forms.Button btnProductListWithCategory;
	}
}