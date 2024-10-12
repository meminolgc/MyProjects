using JWToken.JWT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JWToken
{
	public partial class FrmEmployee : Form
	{
		public FrmEmployee()
		{
			InitializeComponent();
		}

		public string tokenGet;
		SqlConnection connection = new SqlConnection("Server=EMIN\\SQLEXPRESS; initial catalog=DbJWToken; integrated security=true");

		private void FrmEmployee_Load(object sender, EventArgs e)
		{
			TokenValidator tokenValidator = new TokenValidator();

			richTextBox1.Text = tokenGet;

			var principal = tokenValidator.ValidateJwtToken(tokenGet);

			if (principal != null)
			{
				string username = principal.FindFirst(JwtRegisteredClaimNames.Sub)?.Value;
				MessageBox.Show("Hoşgeldiniz:" + username);

				connection.Open();
				SqlCommand command = new SqlCommand("Select * From TblEmployee", connection);
				SqlDataAdapter adapter = new SqlDataAdapter(command);
				DataTable dataTable = new DataTable();
				adapter.Fill(dataTable);
				dataGridView1.DataSource = dataTable;
				connection.Close();
			}
			else
				MessageBox.Show("Geçersiz token");

	
		}
	}
}
