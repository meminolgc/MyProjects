using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDbFirstProduct
{
	public partial class FrmProduct : Form
	{
		public FrmProduct()
		{
			InitializeComponent();
		}

		DbEFProjectEntities db = new DbEFProjectEntities();

		void ProductList()
		{
			dataGridView1.DataSource = db.TblProduct.ToList();
		}

		private void btnListele_Click(object sender, EventArgs e)
		{
			ProductList();
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			TblProduct tblProduct = new TblProduct();
			tblProduct.ProductPrice = decimal.Parse(txtProductPrice.Text);
			tblProduct.ProductStock = int.Parse(txtProductStock.Text);
			tblProduct.ProductName = txtUrunAd.Text;
			tblProduct.CategoryId = int.Parse(cmbProductCategory.SelectedValue.ToString());
			db.TblProduct.Add(tblProduct);
			db.SaveChanges();
			ProductList();
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			var value = db.TblProduct.Find(int.Parse(txtUrunID.Text));
			db.TblProduct.Remove(value);
			db.SaveChanges();
			ProductList();
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			var value = db.TblProduct.Find(int.Parse(txtUrunID.Text));
			value.ProductPrice = decimal.Parse(txtProductPrice.Text);
			value.ProductStock = int.Parse(txtProductStock.Text);
			value.ProductName = txtUrunAd.Text;
			value.CategoryId = int.Parse(cmbProductCategory.SelectedValue.ToString());
			db.SaveChanges();
			ProductList();
		}

		private void FrmProduct_Load(object sender, EventArgs e)
		{
			var values = db.TblCategory.ToList();
			cmbProductCategory.DisplayMember = "CategoryName";
			cmbProductCategory.ValueMember = "CategoryId";
			cmbProductCategory.DataSource = values;
		}

		private void btnProductListWithCategory_Click(object sender, EventArgs e)
		{
			var values = db.TblProduct
				.Join(db.TblCategory,
				product => product.CategoryId,
				category => category.CategoryId,
				(product, category) => new
				{
					ProductId = product.ProductId,
					ProductName = product.ProductName,
					ProductPrice = product.ProductPrice,
					ProductStock = product.ProductStock,
					CategoryId = category.CategoryId,
					CategoryName = category.CategoryName,
				}).ToList();
			dataGridView1.DataSource = values;


		}

		private void btnAra_Click(object sender, EventArgs e)
		{
			var values = db.TblProduct.Where(x => x.ProductName == txtUrunAd.Text).ToList();
			dataGridView1.DataSource = values;
		}
	}
}
