namespace AppQuanLyKho
{
	partial class frmThemPhieuNhap
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.gridSanpham = new System.Windows.Forms.DataGridView();
			this.txtSoluong = new System.Windows.Forms.TextBox();
			this.btnThem = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.gridSpchitiet = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtXuatxu = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtGia = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtTensp = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtMasp = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.cbbNcc = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtGhichu = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbbTrangthai = new System.Windows.Forms.ComboBox();
			this.cbbDonvi = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cbbCongty = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dateNhap = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gridSanpham)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridSpchitiet)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gridSanpham
			// 
			this.gridSanpham.AllowUserToAddRows = false;
			this.gridSanpham.AllowUserToDeleteRows = false;
			this.gridSanpham.AllowUserToResizeColumns = false;
			this.gridSanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridSanpham.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.gridSanpham.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridSanpham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.gridSanpham.Location = new System.Drawing.Point(13, 306);
			this.gridSanpham.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.gridSanpham.Name = "gridSanpham";
			this.gridSanpham.ReadOnly = true;
			this.gridSanpham.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.gridSanpham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridSanpham.Size = new System.Drawing.Size(396, 329);
			this.gridSanpham.TabIndex = 4;
			this.gridSanpham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSanpham_CellContentClick);
			// 
			// txtSoluong
			// 
			this.txtSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSoluong.Location = new System.Drawing.Point(440, 379);
			this.txtSoluong.Name = "txtSoluong";
			this.txtSoluong.Size = new System.Drawing.Size(65, 24);
			this.txtSoluong.TabIndex = 22;
			// 
			// btnThem
			// 
			this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.Location = new System.Drawing.Point(431, 409);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(83, 32);
			this.btnThem.TabIndex = 23;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(437, 363);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 13);
			this.label1.TabIndex = 24;
			this.label1.Text = "Nhập số lượng:";
			// 
			// gridSpchitiet
			// 
			this.gridSpchitiet.AllowUserToAddRows = false;
			this.gridSpchitiet.AllowUserToDeleteRows = false;
			this.gridSpchitiet.AllowUserToResizeColumns = false;
			this.gridSpchitiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridSpchitiet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.gridSpchitiet.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridSpchitiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.gridSpchitiet.Location = new System.Drawing.Point(539, 306);
			this.gridSpchitiet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.gridSpchitiet.Name = "gridSpchitiet";
			this.gridSpchitiet.ReadOnly = true;
			this.gridSpchitiet.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.gridSpchitiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridSpchitiet.Size = new System.Drawing.Size(692, 329);
			this.gridSpchitiet.TabIndex = 25;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtXuatxu);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.txtGia);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.txtTensp);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.txtMasp);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.cbbNcc);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtGhichu);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.cbbTrangthai);
			this.groupBox1.Controls.Add(this.cbbDonvi);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.cbbCongty);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.dateNhap);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(13, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1218, 288);
			this.groupBox1.TabIndex = 32;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin nhập";
			// 
			// txtXuatxu
			// 
			this.txtXuatxu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtXuatxu.Location = new System.Drawing.Point(915, 231);
			this.txtXuatxu.Name = "txtXuatxu";
			this.txtXuatxu.Size = new System.Drawing.Size(159, 24);
			this.txtXuatxu.TabIndex = 53;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(843, 234);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(57, 18);
			this.label9.TabIndex = 52;
			this.label9.Text = "Xuất xứ";
			// 
			// txtGia
			// 
			this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGia.Location = new System.Drawing.Point(915, 179);
			this.txtGia.Name = "txtGia";
			this.txtGia.Size = new System.Drawing.Size(119, 24);
			this.txtGia.TabIndex = 51;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(843, 185);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(31, 18);
			this.label10.TabIndex = 50;
			this.label10.Text = "Giá";
			// 
			// txtTensp
			// 
			this.txtTensp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTensp.Location = new System.Drawing.Point(915, 133);
			this.txtTensp.Name = "txtTensp";
			this.txtTensp.Size = new System.Drawing.Size(159, 24);
			this.txtTensp.TabIndex = 47;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(840, 133);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(57, 18);
			this.label12.TabIndex = 46;
			this.label12.Text = "Tên SP";
			// 
			// txtMasp
			// 
			this.txtMasp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMasp.Location = new System.Drawing.Point(915, 81);
			this.txtMasp.Name = "txtMasp";
			this.txtMasp.Size = new System.Drawing.Size(119, 24);
			this.txtMasp.TabIndex = 45;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(843, 84);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(53, 18);
			this.label13.TabIndex = 44;
			this.label13.Text = "Mã SP";
			// 
			// cbbNcc
			// 
			this.cbbNcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbNcc.FormattingEnabled = true;
			this.cbbNcc.Location = new System.Drawing.Point(257, 227);
			this.cbbNcc.Name = "cbbNcc";
			this.cbbNcc.Size = new System.Drawing.Size(440, 26);
			this.cbbNcc.TabIndex = 43;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(122, 230);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(99, 18);
			this.label7.TabIndex = 42;
			this.label7.Text = "Nhà cung cấp";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(435, 179);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 18);
			this.label4.TabIndex = 41;
			this.label4.Text = "Ghi chú";
			// 
			// txtGhichu
			// 
			this.txtGhichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGhichu.Location = new System.Drawing.Point(518, 178);
			this.txtGhichu.Name = "txtGhichu";
			this.txtGhichu.Size = new System.Drawing.Size(179, 24);
			this.txtGhichu.TabIndex = 40;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(122, 181);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 18);
			this.label2.TabIndex = 39;
			this.label2.Text = "Trạng thái";
			// 
			// cbbTrangthai
			// 
			this.cbbTrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbTrangthai.FormattingEnabled = true;
			this.cbbTrangthai.Items.AddRange(new object[] {
            "Đang vận chuyển",
            "Đã đến"});
			this.cbbTrangthai.Location = new System.Drawing.Point(257, 173);
			this.cbbTrangthai.Name = "cbbTrangthai";
			this.cbbTrangthai.Size = new System.Drawing.Size(130, 26);
			this.cbbTrangthai.TabIndex = 38;
			// 
			// cbbDonvi
			// 
			this.cbbDonvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbDonvi.FormattingEnabled = true;
			this.cbbDonvi.Location = new System.Drawing.Point(257, 130);
			this.cbbDonvi.Name = "cbbDonvi";
			this.cbbDonvi.Size = new System.Drawing.Size(440, 26);
			this.cbbDonvi.TabIndex = 37;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(122, 133);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 18);
			this.label6.TabIndex = 36;
			this.label6.Text = "Đơn vị";
			// 
			// cbbCongty
			// 
			this.cbbCongty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbCongty.FormattingEnabled = true;
			this.cbbCongty.Location = new System.Drawing.Point(257, 82);
			this.cbbCongty.Name = "cbbCongty";
			this.cbbCongty.Size = new System.Drawing.Size(440, 26);
			this.cbbCongty.TabIndex = 35;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(122, 85);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(129, 18);
			this.label5.TabIndex = 34;
			this.label5.Text = "Công ty/Chi nhánh";
			// 
			// dateNhap
			// 
			this.dateNhap.CustomFormat = "yyyy-MM-dd";
			this.dateNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateNhap.Location = new System.Drawing.Point(257, 41);
			this.dateNhap.Name = "dateNhap";
			this.dateNhap.Size = new System.Drawing.Size(172, 24);
			this.dateNhap.TabIndex = 33;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(125, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 18);
			this.label3.TabIndex = 32;
			this.label3.Text = "Ngày nhập";
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(1129, 652);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(102, 32);
			this.btnSave.TabIndex = 33;
			this.btnSave.Text = "Hoàn thành";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// frmThemPhieuNhap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1244, 696);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.gridSpchitiet);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.txtSoluong);
			this.Controls.Add(this.gridSanpham);
			this.Name = "frmThemPhieuNhap";
			this.Text = "THÊM PHIẾU NHẬP KHO";
			this.Load += new System.EventHandler(this.frmThemPhieuNhap_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridSanpham)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridSpchitiet)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView gridSanpham;
		private System.Windows.Forms.TextBox txtSoluong;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView gridSpchitiet;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cbbNcc;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtGhichu;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbbTrangthai;
		private System.Windows.Forms.ComboBox cbbDonvi;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbbCongty;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dateNhap;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtXuatxu;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtGia;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtTensp;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtMasp;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button btnSave;
	}
}