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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace AppQuanLyKho
{
	public partial class frmDonvi : Form
	{
		public frmDonvi()
		{
			InitializeComponent();
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}


		private void frmDonvi_Load(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();

			//load datagrid
			SqlCommand cmd = new SqlCommand("select * from tb_Donvi", conn);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);

			DataTable dt = new DataTable();
			adapter.Fill(dt);
			if (dt.Rows.Count > 0)
			{
				gridProducts.DataSource = dt;
			}
			else
			{
				MessageBox.Show("No Data");
			}

			//load combobox
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

		private void btnEdit_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();
			int check = 0;
			if (ckbKho.Checked)
			{
				check = 1;
			}
			string queryMaCT = "select MaCT from tb_Congty where tenCT = '" + cbbCongty.Text + "'";
			SqlCommand macmd = new SqlCommand(queryMaCT, conn);
			string maCT = (string)macmd.ExecuteScalar();
			String sql = "update tb_Donvi SET maDV =N'" + txtMa.Text + "', tenDV = N'" + txtTen.Text + "',diachi = N'" + txtDiachi.Text + "',dienthoai = N'" + txtSdt.Text + "',email = N'" +
				txtEmail.Text + "', maCT = N'" + maCT + "',kho = " + check + ",kyhieu = N'" + txtKihieu.Text + "' where maDV = N'" + txtMa.Text + "'";
			SqlCommand cmd = new SqlCommand(sql, conn);
			int result = cmd.ExecuteNonQuery();
			if (result > 0)
			{
				MessageBox.Show("Đã cập nhật thành công.");
				frmDonvi_Load(sender, e);
			}
			else
			{
				MessageBox.Show("Cập nhật thất bại. Vui lòng thử lại!!!");

			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{

			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();
			int check = 0;
			if(ckbKho.Checked)
			{
				check = 1;
			}
			string queryMaCT = "select MaCT from tb_Congty where MaCT = '" + cbbCongty.Text + "'";
			SqlCommand macmd = new SqlCommand(queryMaCT, conn);
			string maCT = (string)macmd.ExecuteScalar();
			String sql = "insert into tb_Donvi VALUES(N'" + txtMa.Text + "', N'" + txtTen.Text + "',N'" + txtDiachi.Text + "',N'" + txtSdt.Text + "',N'" +
				txtEmail.Text + "',N'" + maCT + "'," +check+",N'" + txtKihieu.Text+"')";
			SqlCommand cmd = new SqlCommand(sql, conn);
			int result = cmd.ExecuteNonQuery();
			if (result > 0)
			{
				MessageBox.Show("Bạn đã thêm một sản phẩm thành công.");
				frmDonvi_Load(sender, e);
			}
			else
			{
				MessageBox.Show("Bạn đã thêm một sản phẩm thất bại. Vui lòng thử lại!!!");

			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();
			String sql = "delete from tb_Donvi where MaDV = '" + txtMa.Text + "'";
			SqlCommand cmd = new SqlCommand(sql, conn);
			int result = cmd.ExecuteNonQuery();
			if (result > 0)
			{
				MessageBox.Show("Bạn đã xóa một đơn vị thành công.");
				frmDonvi_Load(sender, e);
			}
			else
			{
				MessageBox.Show("Xóa đơn vị thất bại. Vui lòng thử lại!!!");

			}
		}

		private void gridProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow sp = gridProducts.Rows[e.RowIndex];
			txtMa.Text = sp.Cells[0].Value.ToString();
			txtTen.Text = sp.Cells[1].Value.ToString();
			txtDiachi.Text = sp.Cells[2].Value.ToString();
			txtSdt.Text = sp.Cells[3].Value.ToString();
			txtEmail.Text = sp.Cells[4].Value.ToString();

			//ckbKho = sp.Cells[6].ToString();
			if (sp.Cells[6].Value.ToString() == "1") 
			{
				ckbKho.Checked = true;
			}
			txtKihieu.Text = sp.Cells[7].Value.ToString();
		}
	}
}
