using JWToken.JWT;
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

namespace JWToken
{
	public partial class FrmLogin : Form
	{
		public FrmLogin()
		{
			InitializeComponent();
		}

		SqlConnection connection = new SqlConnection("Server=EMIN\\SQLEXPRESS; initial catalog=DbJWToken; integrated security=true");
		private void btnGirisYap_Click(object sender, EventArgs e)
		{
			TokenGenerator tokenGenerator = new TokenGenerator();

			connection.Open();
			SqlCommand command = new SqlCommand("Select * From TblUser Where Username=@username and Password=@password", connection);
			command.Parameters.AddWithValue("@username", txtKullaniciAdi.Text);
			command.Parameters.AddWithValue("@password", txtPassword.Text);
			SqlDataReader sqlDataReader = command.ExecuteReader();
			if (sqlDataReader.Read())
			{
				string token = tokenGenerator.GenerateJwtToken2(txtKullaniciAdi.Text);
				MessageBox.Show(token);
				FrmEmployee frm = new FrmEmployee();
				frm.tokenGet = token;
				frm.Show();
			}
			else
			{
				MessageBox.Show("Hatalı kullanıcı adı ya da şifre");
				txtPassword.Clear();
				txtKullaniciAdi.Clear();
				txtKullaniciAdi.Focus();
			}
			connection.Close();
		}
	}
}
