using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AppQuanLyKho
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}
		private void Login_Load(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();

			//load combobox congty
			string query = "SELECT TenCT FROM tb_Congty";
			SqlCommand command = new SqlCommand(query, conn);
			SqlDataReader reader = command.ExecuteReader();
			// Tạo đối tượng ComboBoxItem cho mỗi dòng dữ liệu và thêm vào combobox
			while (reader.Read())
			{
				cbbCongty.Items.Add(reader[0].ToString());
			}

			conn.Close();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();
			String sSQL = "SELECT TenCT, MaCT FROM tb_Congty WHERE " +
			"TenCT=N'" + cbbCongty.Text + "' and MaCT='" +
			txtPwd.Text + "'";
			SqlCommand cmd = new SqlCommand(sSQL, conn);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			if (dt.Rows.Count > 0)
			{
				MessageBox.Show("Login Successful!");
				this.Close();
			}
			else
			{
				MessageBox.Show("Invalid Login. Please check userID or Password!");
			}
		}
	}
}
