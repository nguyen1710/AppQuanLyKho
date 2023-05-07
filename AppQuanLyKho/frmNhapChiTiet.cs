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
	public partial class frmNhapChiTiet : Form
	{
		public frmNhapChiTiet()
		{
			InitializeComponent();
		}

		private void frmNhapChiTiet_Load(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();

			string query = "select * from tb_Chungtuchitiet where IDChungtu = N'" + frmNhapMua.SCT +"'";
			string trangthai = "select trangthai from tb_Chungtu where SCT = N'" + frmNhapMua.SCT + "'";
			SqlCommand cmd = new SqlCommand(query, conn);
			SqlCommand cmdtt = new SqlCommand(trangthai, conn);
			cbbTrangthai.Text = (string)cmdtt.ExecuteScalar();
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);

			DataTable dt = new DataTable();
			adapter.Fill(dt);
			if (dt.Rows.Count > 0)
			{
				gridNhapchitiet.DataSource = dt;
			}
			else
			{
				MessageBox.Show("No Data");
			}

			conn.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();
			String sql = "update tb_Chungtu SET trangthai = N'" + cbbTrangthai.Text + "' where SCT = '" + frmNhapMua.SCT + "'";
			SqlCommand cmd = new SqlCommand(sql, conn);
			int result = cmd.ExecuteNonQuery();
			if (result > 0)
			{
				MessageBox.Show("Đã cập nhật thành công.");
				
				frmNhapMua frm = new frmNhapMua();
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
			PhieuNhapKho frm = new PhieuNhapKho();
			frm.Show();
		}
	}
}
