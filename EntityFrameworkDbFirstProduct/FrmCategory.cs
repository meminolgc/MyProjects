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
	public partial class FrmCategory : Form
	{
		public FrmCategory()
		{
			InitializeComponent();
		}

		DbEFProjectEntities db = new DbEFProjectEntities();

		void CategoryList()
		{
			dataGridView1.DataSource = db.TblCategory.ToList();
		}


		private void btnListele_Click(object sender, EventArgs e)
		{
			CategoryList();
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			TblCategory tblCategory = new TblCategory();
			tblCategory.CategoryName = txtKategoriAd.Text;
			db.TblCategory.Add(tblCategory);
			db.SaveChanges();	
			CategoryList();
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(txtID.Text);
			var value = db.TblCategory.Find(id);
			db.TblCategory.Remove(value);
			db.SaveChanges();
			CategoryList();
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(txtID.Text);
			var value = db.TblCategory.Find(id);
			value.CategoryName = txtKategoriAd.Text;
			db.SaveChanges();
			CategoryList();

		}
	}
}
