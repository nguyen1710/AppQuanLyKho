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
	public partial class PhieuNhapKho : Form
	{
		public PhieuNhapKho()
		{
			InitializeComponent();
		}

		private void PhieuNhapKho_Load(object sender, EventArgs e)
		{
			lbSL.Text = frmNhapMua.soluong;
			lbTT.Text = frmNhapMua.dongia;
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();

			string query = "select IDChitiet, IDChungtu, IDSP, soluong, dongia from tb_Chungtuchitiet where IDChungtu = N'" + frmNhapMua.SCT + "'";
			string queryNCC = "select nhacungcap from tb_Chungtuchitiet where IDChungtu = N'" + frmNhapMua.SCT + "'";

			string queryMaCT = "select TenCT from tb_Congty where MaCT = N'" + frmNhapMua.MaCT + "'";
			SqlCommand macmd = new SqlCommand(queryMaCT, conn);
			lbCT.Text = (string)macmd.ExecuteScalar();

			string queryMaDV = "select TenDV from tb_DonVi where MaDV = N'" + frmNhapMua.MaDV + "'";
			SqlCommand madvcmd = new SqlCommand(queryMaDV, conn);
			lbDV.Text = (string)madvcmd.ExecuteScalar();

			SqlCommand cmd = new SqlCommand(query, conn);
			SqlCommand cmdNCC = new SqlCommand(queryNCC, conn);

			lbNCC.Text = (string)cmdNCC.ExecuteScalar();
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);

			DataTable dt = new DataTable();
			adapter.Fill(dt);
			if (dt.Rows.Count > 0)
			{
				gridPhieu.DataSource = dt;
			}
			else
			{
				MessageBox.Show("No Data");
			}

			conn.Close();
		}
			
	}
}
