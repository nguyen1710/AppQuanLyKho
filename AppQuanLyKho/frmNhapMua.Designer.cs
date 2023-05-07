namespace AppQuanLyKho
{
	partial class frmNhapMua
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapMua));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnAdd = new System.Windows.Forms.ToolStripButton();
			this.btnEdit = new System.Windows.Forms.ToolStripButton();
			this.btnDelete = new System.Windows.Forms.ToolStripButton();
			this.btnExit = new System.Windows.Forms.ToolStripButton();
			this.gridNhap = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dateStart = new System.Windows.Forms.DateTimePicker();
			this.dateEnd = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.btnFind = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.cbbCongty = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cbbDonvi = new System.Windows.Forms.ComboBox();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridNhap)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(35, 35);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnDelete,
            this.btnExit});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1062, 57);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnAdd
			// 
			this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
			this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(39, 54);
			this.btnAdd.Text = "Add";
			this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
			this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(39, 54);
			this.btnEdit.Text = "Edit";
			this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// btnDelete
			// 
			this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
			this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(42, 54);
			this.btnDelete.Text = "Delete";
			this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnExit
			// 
			this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
			this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(39, 54);
			this.btnExit.Text = "Exit";
			this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// gridNhap
			// 
			this.gridNhap.AllowUserToAddRows = false;
			this.gridNhap.AllowUserToDeleteRows = false;
			this.gridNhap.AllowUserToResizeColumns = false;
			this.gridNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridNhap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.gridNhap.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.gridNhap.Location = new System.Drawing.Point(0, 268);
			this.gridNhap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.gridNhap.Name = "gridNhap";
			this.gridNhap.ReadOnly = true;
			this.gridNhap.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.gridNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridNhap.Size = new System.Drawing.Size(1062, 301);
			this.gridNhap.TabIndex = 3;
			this.gridNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridNhap_CellContentClick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 57);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1062, 24);
			this.label1.TabIndex = 4;
			this.label1.Text = "Thông tin";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(152, 97);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 18);
			this.label3.TabIndex = 6;
			this.label3.Text = "Từ ngày";
			// 
			// dateStart
			// 
			this.dateStart.CustomFormat = "yyyy-MM-dd";
			this.dateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateStart.Location = new System.Drawing.Point(284, 98);
			this.dateStart.Name = "dateStart";
			this.dateStart.Size = new System.Drawing.Size(200, 24);
			this.dateStart.TabIndex = 7;
			// 
			// dateEnd
			// 
			this.dateEnd.CustomFormat = "yyyy-MM-dd";
			this.dateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateEnd.Location = new System.Drawing.Point(657, 98);
			this.dateEnd.Name = "dateEnd";
			this.dateEnd.Size = new System.Drawing.Size(200, 24);
			this.dateEnd.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(555, 101);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 18);
			this.label4.TabIndex = 8;
			this.label4.Text = "Đến ngày";
			// 
			// btnFind
			// 
			this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFind.Location = new System.Drawing.Point(493, 229);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(86, 33);
			this.btnFind.TabIndex = 14;
			this.btnFind.Text = "Tìm";
			this.btnFind.UseVisualStyleBackColor = true;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(149, 142);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(129, 18);
			this.label5.TabIndex = 10;
			this.label5.Text = "Công ty/Chi nhánh";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// cbbCongty
			// 
			this.cbbCongty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbCongty.FormattingEnabled = true;
			this.cbbCongty.Location = new System.Drawing.Point(284, 139);
			this.cbbCongty.Name = "cbbCongty";
			this.cbbCongty.Size = new System.Drawing.Size(573, 26);
			this.cbbCongty.TabIndex = 11;
			this.cbbCongty.SelectedIndexChanged += new System.EventHandler(this.cbbCongty_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(149, 190);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 18);
			this.label6.TabIndex = 12;
			this.label6.Text = "Đơn vị";
			// 
			// cbbDonvi
			// 
			this.cbbDonvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbDonvi.FormattingEnabled = true;
			this.cbbDonvi.Location = new System.Drawing.Point(284, 187);
			this.cbbDonvi.Name = "cbbDonvi";
			this.cbbDonvi.Size = new System.Drawing.Size(573, 26);
			this.cbbDonvi.TabIndex = 13;
			// 
			// frmNhapMua
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1062, 570);
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.cbbDonvi);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cbbCongty);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dateEnd);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dateStart);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.gridNhap);
			this.Controls.Add(this.toolStrip1);
			this.Name = "frmNhapMua";
			this.Text = "frmNhapMua";
			this.Load += new System.EventHandler(this.frmNhapMua_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridNhap)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnAdd;
		private System.Windows.Forms.ToolStripButton btnEdit;
		private System.Windows.Forms.ToolStripButton btnDelete;
		private System.Windows.Forms.ToolStripButton btnExit;
		private System.Windows.Forms.DataGridView gridNhap;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dateStart;
		private System.Windows.Forms.DateTimePicker dateEnd;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbbCongty;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbbDonvi;
	}
}