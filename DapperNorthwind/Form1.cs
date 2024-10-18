using Dapper;
using DapperNorthwind.Dtos.CategoryDtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperNorthwind
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		SqlConnection connection = new SqlConnection("Server=EMIN\\SQLEXPRESS; initial catalog=DapperDb; integrated security=true");

		private async void btnCategoryList_Click(object sender, EventArgs e)
		{
			string query = "Select * From Categories";
			var values = await connection.QueryAsync<ResultCategoryDto>(query);
			dataGridView1.DataSource = values;

		}

		private async void btnCreateCategory_Click(object sender, EventArgs e)
		{
			string query = "insert into Categories (CategoryName,Description) Values (@p1,@p2)";
			var parameters = new DynamicParameters();
			parameters.Add("@p1",txtCategoryId.Text);
			parameters.Add("@p2",txtCategoryName.Text);
			await connection.ExecuteAsync(query, parameters);
		}

		private async void button1_Click(object sender, EventArgs e)
		{
			string query = "Delete From Categories Where CategoryId=@categoryId";
			var parameters = new DynamicParameters();
			parameters.Add("@categoryId", txtCategoryId.Text);
			await connection.ExecuteAsync(query, parameters);
		}

		private async void button2_Click(object sender, EventArgs e)
		{
			string query = "Update Categories Set CategoryName=@categoryName,Description=@description Where CategoryId=@categoryId";
			var parameters = new DynamicParameters();
			parameters.Add("@categoryName", txtCategoryName.Text);
			parameters.Add("@description", txtCategoryDescription.Text);
			parameters.Add("@categoryId", txtCategoryId.Text);
			await connection.ExecuteAsync(query, parameters);
		}
	}
}
