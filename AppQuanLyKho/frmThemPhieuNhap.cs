using System;
using System.Collections;
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
	public partial class frmThemPhieuNhap : Form
	{

		private static string randomNumber = frmNhapMua.randomNumber();
		private static string SCT, IDChungtu;

		public frmThemPhieuNhap()
		{
			InitializeComponent();
			
		}
		

		private void frmThemPhieuNhap_Load(object sender, EventArgs e)
		{
			LoadSanPham();
			cbbCongTy_Load();
			cbbDonvi_Load();
			cbbNcc_Load();
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
				//cbbCongty.Items.Add(reader[1].ToString());


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

		private void cbbNcc_Load()
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();

			//load combobox congty
			string query = "SELECT TENNCC FROM tb_Nhacungcap";
			SqlCommand command = new SqlCommand(query, conn);
			SqlDataReader reader = command.ExecuteReader();
			// Tạo đối tượng ComboBoxItem cho mỗi dòng dữ liệu và thêm vào combobox
			while (reader.Read())
			{
				cbbNcc.Items.Add(reader[0].ToString());
			}

			conn.Close();
		}

		private void LoadSanPham()
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();
			SqlCommand cmd = new SqlCommand("select * from tb_Sanpham", conn);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);

			DataTable dt = new DataTable();
			adapter.Fill(dt);
			if (dt.Rows.Count > 0)
			{
				gridSanpham.DataSource = dt;
			}
			else
			{
				MessageBox.Show("No Data");
			}

			conn.Close();
		}


		private void gridSanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow sp = gridSanpham.Rows[e.RowIndex];
			txtMasp.Text = sp.Cells[0].Value.ToString();
			txtTensp.Text = sp.Cells[1].Value.ToString();
			txtGia.Text = sp.Cells[3].Value.ToString();
			txtXuatxu.Text = sp.Cells[5].Value.ToString();
		}

		private void LoadGridChiTiet(string ID)
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();
			string query = "select * from tb_Chungtuchitiet where IDChitiet = N'" + ID + "'";
			SqlCommand cmd = new SqlCommand(query, conn);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);

			DataTable dt = new DataTable();
			adapter.Fill(dt);
			if (dt.Rows.Count > 0)
			{
				gridSpchitiet.DataSource = dt;
			}
			else
			{
				MessageBox.Show("No Data");
			}

			conn.Close();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			string stringdate = dateNhap.Text.Replace("-", "");
			SCT = "NM" + stringdate + randomNumber;
			IDChungtu = "CT" + stringdate + randomNumber;
			string IDCTChitiet = stringdate + "/NM/" + randomNumber;
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();

			string query = "insert into tb_Chungtuchitiet VALUES(N'" + IDCTChitiet + "', N'" + SCT + "', N'" + txtMasp.Text +
				"', " + int.Parse(txtSoluong.Text) + ", " + int.Parse(txtGia.Text) * int.Parse(txtSoluong.Text) + ", N'" + cbbNcc.Text + "')";
			SqlCommand cmd = new SqlCommand(query, conn);
			int result = cmd.ExecuteNonQuery();
			if (result > 0)
			{
				LoadGridChiTiet(IDCTChitiet);
			}
			else
			{
				MessageBox.Show("No Data");
			}

			conn.Close();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();


			string queryMaCT = "select MaCT from tb_Congty where tenCT = N'" + cbbCongty.Text + "'";
			SqlCommand macmd = new SqlCommand(queryMaCT, conn);
			string maCT = (string)macmd.ExecuteScalar();

			string queryMaDV = "select MaDV from tb_DonVi where tenDV = N'" + cbbDonvi.Text + "'";
			SqlCommand madvcmd = new SqlCommand(queryMaDV, conn);
			string maDV = (string)madvcmd.ExecuteScalar();

			string querySoluong = "select sum(soluong) from tb_Chungtuchitiet where IDChungtu = '"+ SCT +"'";
			SqlCommand cmdSoluong = new SqlCommand(querySoluong, conn);
			string queryDongia = "select sum(dongia) from tb_Chungtuchitiet where IDChungtu = '" + SCT + "'";
			SqlCommand cmdDongia = new SqlCommand(queryDongia, conn);

			int soluong = Convert.ToInt32(cmdSoluong.ExecuteScalar());
			int dongia = Convert.ToInt32(cmdDongia.ExecuteScalar());

			string queryAddNhapMua = "insert into tb_Chungtu VALUES(N'" + IDChungtu+ "', N'NMH', N'" + SCT +"', '" + dateNhap.Text +
				"', '', '', N'" + maDV + "','', N'" + maCT + "', N'" + cbbTrangthai.Text + "', N'" + txtGhichu.Text + "', " + soluong + ", " + dongia +")";
			SqlCommand cmd = new SqlCommand(queryAddNhapMua, conn);

			int result = cmd.ExecuteNonQuery();
			if (result > 0)
			{
				MessageBox.Show("Thêm Thành công");
				frmNhapMua frm = new frmNhapMua();
				frm.Show();
				this.Close();
			}
			else
			{
				MessageBox.Show("No Data");
			}

			conn.Close();
		}
	}
}
