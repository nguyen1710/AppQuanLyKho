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
using System.Xml.Linq;

namespace AppQuanLyKho
{
	public partial class Products : Form
	{
		
		public Products()
		{
			InitializeComponent();
		}

		private void Products_Load(object sender, EventArgs e)
		{
			LoadData();

		}

		private void LoadData()
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();
			SqlCommand cmd = new SqlCommand("select * from tb_Sanpham", conn);
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

			conn.Close();
		}

		private void gridProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow sp = gridProducts.Rows[e.RowIndex];
			txtMasp.Text =  sp.Cells[0].Value.ToString();
			txtTensp.Text = sp.Cells[1].Value.ToString();
			txtDonvi.Text = sp.Cells[2].Value.ToString();
			txtGia.Text =   sp.Cells[3].Value.ToString();
			txtNhacc.Text = sp.Cells[4].Value.ToString();
			txtXuatxu.Text = sp.Cells[5].Value.ToString();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();
			String sql = "insert into tb_Sanpham VALUES(N'" + txtMasp.Text + "', N'" + txtTensp.Text + "',"+ txtDonvi.Text+"," + txtGia.Text + ",N'" +
				txtNhacc.Text + "',N'" + txtXuatxu.Text+"', '')";
			SqlCommand cmd = new SqlCommand(sql, conn);
			int result = cmd.ExecuteNonQuery();
			if (result > 0)
			{
				MessageBox.Show("Bạn đã thêm một sản phẩm thành công.");
				Products_Load(sender, e);
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
			String sql = "delete from tb_Sanpham where MaSP = '" + txtMasp.Text +"'";
			SqlCommand cmd = new SqlCommand(sql, conn);
			int result = cmd.ExecuteNonQuery();
			if (result > 0)
			{
				MessageBox.Show("Bạn đã xóa một sản phẩm thành công.");
				Products_Load(sender, e);
			}
			else
			{
				MessageBox.Show("Xóa sản phẩm thất bại. Vui lòng thử lại!!!");

			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();
			String sql = "update tb_Sanpham SET masp = N'" + txtMasp.Text + "',tensp =N'" + txtTensp.Text + "',donvitinh=" + txtDonvi.Text + ",dongia=" + txtGia.Text + ",nhacungcap=N'" +
				txtNhacc.Text + "',xuatxu=N'" + txtXuatxu.Text + "' where masp = N'" + txtMasp.Text + "'";
			SqlCommand cmd = new SqlCommand(sql, conn);
			int result = cmd.ExecuteNonQuery();
			if (result > 0)
			{
				MessageBox.Show("Đã cập nhật thành công.");
				Products_Load(sender, e);
			}
			else
			{
				MessageBox.Show("Cập nhật thất bại. Vui lòng thử lại!!!");

			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(Program.strConn);
			conn.Open();
			String sql = "insert into tb_Sanpham VALUES(N'" + txtMasp.Text + "', N'" + txtTensp.Text + "'," + txtDonvi.Text + "," + txtGia.Text + ",N'" +
				txtNhacc.Text + "',N'" + txtXuatxu.Text + "', '')";
			SqlCommand cmd = new SqlCommand(sql, conn);
			int result = cmd.ExecuteNonQuery();
			if (result > 0)
			{
				MessageBox.Show("Bạn đã thêm một sản phẩm thành công.");
				Products_Load(sender, e);
			}
			else
			{
				MessageBox.Show("Bạn đã thêm một sản phẩm thất bại. Vui lòng thử lại!!!");

			}
			
		}
	}
}
