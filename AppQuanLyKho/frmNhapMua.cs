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
	public partial class frmNhapMua : Form
	{
		public static string SCT, MaDV, MaCT, soluong, dongia = "";
		public frmNhapMua()
		{
			InitializeComponent();
		}

		private void cbbCongty_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void frmNhapMua_Load(object sender, EventArgs e)
		{
			Loaddata();
			cbbCongTy_Load();
			cbbDonvi_Load();
		}

		private void Loaddata()
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();

			string query = "select ID, LoaiCT, SCT, Ngaynhap, MaDV1, MaCT, trangthai, ghichu, soluong,tongtien from tb_Chungtu where LoaiCT = 'NMH'";

			SqlCommand cmd = new SqlCommand(query, conn);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);

			DataTable dt = new DataTable();
			adapter.Fill(dt);
			if (dt.Rows.Count > 0)
			{
				gridNhap.DataSource = dt;
			}
			else
			{
				MessageBox.Show("No Data");
			}

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

		private void cbbDonvi_Load()
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();

			//load combobox congty
			string query = "SELECT TenDV FROM tb_Donvi";
			SqlCommand command = new SqlCommand(query, conn);
			SqlDataReader reader = command.ExecuteReader();
			// Tạo đối tượng ComboBoxItem cho mỗi dòng dữ liệu và thêm vào combobox
			while (reader.Read())
			{
				cbbDonvi.Items.Add(reader[0].ToString());
			}
			conn.Close();
		}
		
		private void btnFind_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();

			string queryMaCT = "select MaCT from tb_Congty where tenCT = N'" + cbbCongty.Text + "'";
			SqlCommand macmd = new SqlCommand(queryMaCT, conn);
			string maCT = (string)macmd.ExecuteScalar();

			string queryMaDV = "select MaDV from tb_DonVi where tenDV = N'" + cbbDonvi.Text + "'";
			SqlCommand madvcmd = new SqlCommand(queryMaDV, conn);
			string maDV = (string)madvcmd.ExecuteScalar();

			string query = "select ID, LoaiCT, SCT, Ngaynhap, MaDV1, MaCT, trangthai, ghichu, soluong,tongtien from tb_Chungtu where MaCT = '" + maCT + "' AND  MaDV1 = '" + maDV + "' AND " +
				"ngaynhap BETWEEN '" + dateStart.Text + "' AND '" + dateEnd.Text + "'";

			SqlCommand cmd = new SqlCommand(query, conn);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);

			DataTable dt = new DataTable();
			adapter.Fill(dt);
			if (dt.Rows.Count > 0)
			{
				gridNhap.DataSource = dt;
			}
			else
			{
				MessageBox.Show("No Data");
			}

			conn.Close();
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void gridNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();

			DataGridViewRow row = gridNhap.Rows[e.RowIndex];
			SCT = row.Cells[2].Value.ToString();
			MaDV = row.Cells[4].Value.ToString();
			MaCT = row.Cells[5].Value.ToString();
			soluong = row.Cells[8].Value.ToString();
			dongia = row.Cells[9].Value.ToString();

			string query = "select * from tb_Chungtuchitiet where IDChungtu = '" + SCT + "'";

			SqlCommand cmd = new SqlCommand(query, conn);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);

			DataTable dt = new DataTable();
			adapter.Fill(dt);
			if (dt.Rows.Count > 0)
			{
				this.Close();
				frmNhapChiTiet frm = new frmNhapChiTiet();
				frm.ShowDialog();
			}
			else
			{
				MessageBox.Show("No Data");
			}
			
		}

		public static string randomNumber()
		{
			Random rand = new Random();
			int randomNumber = rand.Next(1000, 10000); // tạo số ngẫu nhiên trong khoảng từ 1000 đến 9999
			string randomString = randomNumber.ToString(); // chuyển số sang chuỗi
			return randomString;

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			frmThemPhieuNhap frm = new frmThemPhieuNhap();
			frm.ShowDialog();
			this.Close();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			
			
		}
	}
}
