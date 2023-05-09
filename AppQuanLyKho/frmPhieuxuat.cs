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
	public partial class frmPhieuxuat : Form
	{
		public static string SCT, MaDV, MaCT, soluong, dongia = "";

		private void btnFind_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();

			string query = "select ID, LoaiCT, SCT2, Ngayxuat, MaDV2, MaCT, trangthai,soluong,tongtien from tb_Chungtu where LoaiCT = 'XMH' AND Ngayxuat BETWEEN '" + dateStart.Text + "' AND '" + dateEnd.Text + "'";

			SqlCommand cmd = new SqlCommand(query, conn);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);

			DataTable dt = new DataTable();
			adapter.Fill(dt);
			if (dt.Rows.Count > 0)
			{
				gridXuat.DataSource = dt;
			}
			else
			{
				MessageBox.Show("No Data");
			}

			conn.Close();
			
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();	
		}

		public frmPhieuxuat()
		{
			InitializeComponent();
		}

		private void frmPhieuxuat_Load(object sender, EventArgs e)
		{
			LoadData();
		}
		private void LoadData()
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();

			string query = "select ID, LoaiCT, SCT2, Ngayxuat, MaDV2, MaCT, trangthai,soluong,tongtien from tb_Chungtu where LoaiCT = 'XMH'";

			SqlCommand cmd = new SqlCommand(query, conn);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);

			DataTable dt = new DataTable();
			adapter.Fill(dt);
			if (dt.Rows.Count > 0)
			{
				gridXuat.DataSource = dt;
			}
			else
			{
				MessageBox.Show("No Data");
			}

			conn.Close();
		}

		private void gridXuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();

			DataGridViewRow row = gridXuat.Rows[e.RowIndex];
			SCT = row.Cells[2].Value.ToString();
			MaDV = row.Cells[4].Value.ToString();
			MaCT = row.Cells[5].Value.ToString();
			soluong = row.Cells[7].Value.ToString();
			dongia = row.Cells[8].Value.ToString();

			string query = "select IDChitiet, IDChungtu, IDSP, soluong, dongia from tb_Chungtuchitiet where IDChungtu = '" + SCT + "'";

			SqlCommand cmd = new SqlCommand(query, conn);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);

			DataTable dt = new DataTable();
			adapter.Fill(dt);
			if (dt.Rows.Count > 0)
			{
				this.Close();
				frmXuatchitiet frm = new frmXuatchitiet();
				frm.ShowDialog();
			}
			else
			{
				MessageBox.Show("No Data");
			}
		}
	}
}
