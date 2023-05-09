namespace AppQuanLyKho
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.label4 = new System.Windows.Forms.Label();
			this.lbNhapMua = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lbDonvi = new System.Windows.Forms.Label();
			this.lbSanpham = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.imageList2 = new System.Windows.Forms.ImageList(this.components);
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.tsbMain = new System.Windows.Forms.ToolStripButton();
			this.tsbReport = new System.Windows.Forms.ToolStripButton();
			this.tsbExit = new System.Windows.Forms.ToolStripButton();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(35, 35);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbMain,
            this.tsbReport,
            this.tsbExit});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1023, 57);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.label4);
			this.splitContainer1.Panel1.Controls.Add(this.pictureBox6);
			this.splitContainer1.Panel1.Controls.Add(this.lbNhapMua);
			this.splitContainer1.Panel1.Controls.Add(this.pictureBox4);
			this.splitContainer1.Panel1.Controls.Add(this.label5);
			this.splitContainer1.Panel1.Controls.Add(this.pictureBox5);
			this.splitContainer1.Panel1.Controls.Add(this.lbDonvi);
			this.splitContainer1.Panel1.Controls.Add(this.pictureBox3);
			this.splitContainer1.Panel1.Controls.Add(this.lbSanpham);
			this.splitContainer1.Panel1.Controls.Add(this.pictureBox2);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
			this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.splitContainer1.Panel2.Controls.Add(this.label3);
			this.splitContainer1.Panel2.Controls.Add(this.label2);
			this.splitContainer1.Size = new System.Drawing.Size(1023, 560);
			this.splitContainer1.SplitterDistance = 256;
			this.splitContainer1.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(75, 239);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(110, 17);
			this.label4.TabIndex = 15;
			this.label4.Text = "Phiếu xuất hàng";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// lbNhapMua
			// 
			this.lbNhapMua.AutoSize = true;
			this.lbNhapMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNhapMua.Location = new System.Drawing.Point(75, 198);
			this.lbNhapMua.Name = "lbNhapMua";
			this.lbNhapMua.Size = new System.Drawing.Size(111, 17);
			this.lbNhapMua.TabIndex = 13;
			this.lbNhapMua.Text = "Phiếu nhập mua";
			this.lbNhapMua.Click += new System.EventHandler(this.lbNhapMua_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(32, 167);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(82, 20);
			this.label5.TabIndex = 11;
			this.label5.Text = "Chứng từ";
			// 
			// lbDonvi
			// 
			this.lbDonvi.AutoSize = true;
			this.lbDonvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDonvi.Location = new System.Drawing.Point(75, 130);
			this.lbDonvi.Name = "lbDonvi";
			this.lbDonvi.Size = new System.Drawing.Size(114, 17);
			this.lbDonvi.TabIndex = 9;
			this.lbDonvi.Text = "Danh mục đơn vị";
			this.lbDonvi.Click += new System.EventHandler(this.lbDonvi_Click);
			// 
			// lbSanpham
			// 
			this.lbSanpham.AutoSize = true;
			this.lbSanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbSanpham.Location = new System.Drawing.Point(75, 104);
			this.lbSanpham.Name = "lbSanpham";
			this.lbSanpham.Size = new System.Drawing.Size(138, 17);
			this.lbSanpham.TabIndex = 7;
			this.lbSanpham.Text = "Danh mục sản phẩm";
			this.lbSanpham.Click += new System.EventHandler(this.lbSanpham_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(32, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "Danh mục";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(243, 130);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(335, 31);
			this.label3.TabIndex = 1;
			this.label3.Text = "XUẤT KHO + NHẬP KHO";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(195, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(450, 31);
			this.label2.TabIndex = 0;
			this.label2.Text = "PHẦN MỀM QUẢN LÝ BÁN HÀNG";
			// 
			// imageList2
			// 
			this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
			this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList2.Images.SetKeyName(0, "delete.png");
			this.imageList2.Images.SetKeyName(1, "plus.png");
			this.imageList2.Images.SetKeyName(2, "tool.png");
			this.imageList2.Images.SetKeyName(3, "minus.png");
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// tsbMain
			// 
			this.tsbMain.Image = ((System.Drawing.Image)(resources.GetObject("tsbMain.Image")));
			this.tsbMain.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbMain.Name = "tsbMain";
			this.tsbMain.Size = new System.Drawing.Size(79, 54);
			this.tsbMain.Text = "Main System";
			this.tsbMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// tsbReport
			// 
			this.tsbReport.Image = ((System.Drawing.Image)(resources.GetObject("tsbReport.Image")));
			this.tsbReport.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbReport.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
			this.tsbReport.Name = "tsbReport";
			this.tsbReport.Size = new System.Drawing.Size(46, 54);
			this.tsbReport.Text = "Report";
			this.tsbReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tsbReport.Click += new System.EventHandler(this.tsbReport_Click);
			// 
			// tsbExit
			// 
			this.tsbExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbExit.Image")));
			this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbExit.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
			this.tsbExit.Name = "tsbExit";
			this.tsbExit.Size = new System.Drawing.Size(39, 54);
			this.tsbExit.Text = "Exit";
			this.tsbExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = global::AppQuanLyKho.Properties.Resources.minus;
			this.pictureBox6.Location = new System.Drawing.Point(36, 234);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(33, 22);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox6.TabIndex = 14;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::AppQuanLyKho.Properties.Resources.minus;
			this.pictureBox4.Location = new System.Drawing.Point(36, 193);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(33, 22);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 12;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = global::AppQuanLyKho.Properties.Resources.plus;
			this.pictureBox5.Location = new System.Drawing.Point(3, 165);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(33, 22);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox5.TabIndex = 10;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::AppQuanLyKho.Properties.Resources.minus;
			this.pictureBox3.Location = new System.Drawing.Point(36, 125);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(33, 22);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 8;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::AppQuanLyKho.Properties.Resources.minus;
			this.pictureBox2.Location = new System.Drawing.Point(36, 99);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(33, 22);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 6;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::AppQuanLyKho.Properties.Resources.plus;
			this.pictureBox1.Location = new System.Drawing.Point(3, 71);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(33, 22);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1023, 560);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.splitContainer1);
			this.Name = "frmMain";
			this.Text = "PHẦN MỀM QUẢN LÝ BÁN HÀNG XUẤT KHO + NHẬP KHO";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsbMain;
		private System.Windows.Forms.ToolStripButton tsbReport;
		private System.Windows.Forms.ToolStripButton tsbExit;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ImageList imageList2;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbSanpham;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbDonvi;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label lbNhapMua;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox6;
	}
}