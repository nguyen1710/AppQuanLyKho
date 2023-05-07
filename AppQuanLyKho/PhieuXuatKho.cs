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
	public partial class PhieuXuatKho : Form
	{
		public PhieuXuatKho()
		{
			InitializeComponent();
		}

		private void PhieuXuatKho_Load(object sender, EventArgs e)
		{
			lbSL.Text = frmPhieuxuat.soluong;
			lbTT.Text = frmPhieuxuat.dongia;
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();

			string query = "select IDChitiet, IDChungtu, IDSP, soluong, dongia from tb_Chungtuchitiet where IDChungtu = N'" + frmPhieuxuat.SCT + "'";

			string queryMaCT = "select TenCT from tb_Congty where MaCT = N'" + frmPhieuxuat.MaCT + "'";
			SqlCommand macmd = new SqlCommand(queryMaCT, conn);
			lbCT.Text = (string)macmd.ExecuteScalar();

			string queryMaDV = "select TenDV from tb_DonVi where MaDV = N'" + frmPhieuxuat.MaDV + "'";
			SqlCommand madvcmd = new SqlCommand(queryMaDV, conn);
			lbDV.Text = (string)madvcmd.ExecuteScalar();

			SqlCommand cmd = new SqlCommand(query, conn);

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
