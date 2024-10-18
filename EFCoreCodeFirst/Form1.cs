﻿using EFCoreCodeFirst.DAL.Context;
using EFCoreCodeFirst.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFCoreCodeFirst
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		MovieContext context = new MovieContext();
		private void btnList_Click(object sender, EventArgs e)
		{
			var values = context.Categories.ToList();
			dataGridView1.DataSource = values;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Category category = new Category();
			category.CategoryName = txtCategoryName.Text;
			context.Categories.Add(category);
			context.SaveChanges();
			MessageBox.Show("İşlem başarılı");
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtCategoryId.Text);
			var value = context.Categories.Find(id);
			value.CategoryName = txtCategoryName.Text;
			context.SaveChanges();
			MessageBox.Show("İşlem Başarılı");
		}

		private void bbtnDelete_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtCategoryId.Text);
			var value = context.Categories.Find(id);
			context.Categories.Remove(value);
			context.SaveChanges();
			MessageBox.Show("İşlem Başarılı");

		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			var values = context.Categories.Where(x => x.CategoryName == txtCategoryName.Text).ToList();
			dataGridView1.DataSource= values;
		}
	}
}
