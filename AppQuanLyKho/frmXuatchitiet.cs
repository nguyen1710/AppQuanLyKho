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

namespace AppQuanLyKho
{
	public partial class frmXuatchitiet : Form
	{
		public frmXuatchitiet()
		{
			InitializeComponent();
		}

		private void frmXuatchitiet_Load(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();

			string query = "select IDChitiet, IDChungtu, IDSP, soluong, dongia from tb_Chungtuchitiet where IDChungtu = N'" + frmPhieuxuat.SCT + "'";
			string trangthai = "select trangthai from tb_Chungtu where SCT = N'" + frmNhapMua.SCT + "'";
			SqlCommand cmd = new SqlCommand(query, conn);
			SqlCommand cmdtt = new SqlCommand(trangthai, conn);
			cbbTrangthai.Text = (string)cmdtt.ExecuteScalar();
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);

			DataTable dt = new DataTable();
			adapter.Fill(dt);
			if (dt.Rows.Count > 0)
			{
				gridXuatchitiet.DataSource = dt;
			}
			else
			{
				MessageBox.Show("No Data");
			}
			cbbCongTy_Load();
			conn.Close();
		}

		private void cbbCongTy_Load()
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

		private void button1_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();

			string queryMaCT = "select MaCT from tb_Congty where tenCT = N'" + cbbCongty.Text + "'";
			SqlCommand macmd = new SqlCommand(queryMaCT, conn);
			string maCT = (string)macmd.ExecuteScalar();

			String sql = "update tb_Chungtu SET trangthai = N'" + cbbTrangthai.Text + "', MaCT = N'"+ maCT + "' where SCT2 = '" + frmPhieuxuat.SCT + "'";
			SqlCommand cmd = new SqlCommand(sql, conn);
			int result = cmd.ExecuteNonQuery();
			if (result > 0)
			{
				MessageBox.Show("Đã cập nhật thành công.");

				frmPhieuxuat frm = new frmPhieuxuat();
				frm.Show();
				this.Close();

			}
			else
			{
				MessageBox.Show("Cập nhật thất bại. Vui lòng thử lại!!!");

			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			PhieuXuatKho f = new PhieuXuatKho();
			f.Show();
		}

		private void cbbCongty_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
