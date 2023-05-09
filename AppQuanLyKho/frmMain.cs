using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyKho
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void lbSanpham_Click(object sender, EventArgs e)
		{
			Products products= new Products();
			products.ShowDialog();
		}

		private void tsbExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void lbDonvi_Click(object sender, EventArgs e)
		{
			frmDonvi fr = new frmDonvi();
			fr.ShowDialog();
		}

		private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void lbNhapMua_Click(object sender, EventArgs e)
		{
			frmNhapMua fr= new frmNhapMua();	
			fr.ShowDialog();
		}

		private void label4_Click(object sender, EventArgs e)
		{
			frmPhieuxuat fr = new frmPhieuxuat();
			fr.ShowDialog();
		}

		private void tsbReport_Click(object sender, EventArgs e)
		{

		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			Login f = new Login();
			f.ShowDialog();
		}
	}
}
