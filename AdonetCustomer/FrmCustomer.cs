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

namespace AdonetCustomer
{
	public partial class FrmCustomer : Form
	{
		public FrmCustomer()
		{
			InitializeComponent();
		}

		SqlConnection sqlConnection = new SqlConnection("Server=EMIN\\SQLEXPRESS; initial catalog=DbCustomer; integrated security=true");

		private void btnList_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("Select CustomerId, CustomerName, CustomerSurname,CustomerBalance,CustomerStatus,CityName From TblCustomer Inner Join TblCity On TblCity.CityId=TblCustomer.CustomerCity", sqlConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
			sqlConnection.Close();
		}

		private void btnProcedure_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("Execute CustomerListWithCity", sqlConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
			sqlConnection.Close();
		}

		private void FrmCustomer_Load(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("Select * From TblCity", sqlConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			cmbCity.ValueMember = "CityId";
			cmbCity.DisplayMember = "CityName";
			cmbCity.DataSource = dataTable;
			sqlConnection.Close();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("insert into TblCustomer (CustomerName, CustomerSurname, CustomerCity, CustomerBalance, CustomerStatus) values (@customerName, @customerSurname, @customerCity, @customerBalance, @customerStatus)", sqlConnection);
			command.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
			command.Parameters.AddWithValue("@customerSurname", txtCustomerSurname.Text);
			command.Parameters.AddWithValue("@customerCity", cmbCity.SelectedValue);
			command.Parameters.AddWithValue("@customerBalance", txtBalance.Text);
			if (rdbActive.Checked)
			{
				command.Parameters.AddWithValue("@customerStatus", true);
			}
			if (rdbPassive.Checked)
			{
				command.Parameters.AddWithValue("@customerStatus", false);
			}
			command.ExecuteNonQuery();
			sqlConnection.Close();
			MessageBox.Show("Müşteri başarılı bir şekilde eklendi", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("Delete from TblCustomer Where CustomerId=@customerId", sqlConnection);
			command.Parameters.AddWithValue("@customerId", txtCustomerId.Text);
			command.ExecuteNonQuery();
			sqlConnection.Close();
			MessageBox.Show("Müşteri başarılı bir şekilde silindi", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("Update TblCustomer Set CustomerName=@customerName, CustomerSurname=@customerSurname, CustomerCity=@customerCity, CustomerBalance=@customerBalance, CustomerStatus=@customerStatus where CustomerId=@customerId", sqlConnection);
			command.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
			command.Parameters.AddWithValue("@customerSurname", txtCustomerSurname.Text);
			command.Parameters.AddWithValue("@customerCity", cmbCity.SelectedValue);
			command.Parameters.AddWithValue("@customerBalance", txtBalance.Text);
			command.Parameters.AddWithValue("@customerId", txtCustomerId.Text);
			if (rdbActive.Checked)
			{
				command.Parameters.AddWithValue("@customerStatus", true);
			}
			if (rdbPassive.Checked)
			{
				command.Parameters.AddWithValue("@customerStatus", false);
			}
			command.ExecuteNonQuery();
			sqlConnection.Close();
			MessageBox.Show("Müşteri başarılı bir şekilde güncellendi", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("Select CustomerId, CustomerName, CustomerSurname,CustomerBalance,CustomerStatus,CityName From TblCustomer Inner Join TblCity On TblCity.CityId=TblCustomer.CustomerCity where CustomerName=@customerName", sqlConnection);
			command.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
			sqlConnection.Close();
		}
	}
}
