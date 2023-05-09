namespace AppQuanLyKho
{
	partial class frmDonvi
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonvi));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.gridProducts = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbbCongty = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMa = new System.Windows.Forms.TextBox();
			this.txtTen = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSdt = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtKihieu = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtDiachi = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.ckbKho = new System.Windows.Forms.CheckBox();
			this.btnAdd = new System.Windows.Forms.ToolStripButton();
			this.btnEdit = new System.Windows.Forms.ToolStripButton();
			this.btnDelete = new System.Windows.Forms.ToolStripButton();
			this.btnExit = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
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
			this.toolStrip1.Size = new System.Drawing.Size(791, 57);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// gridProducts
			// 
			this.gridProducts.AllowUserToAddRows = false;
			this.gridProducts.AllowUserToDeleteRows = false;
			this.gridProducts.AllowUserToResizeColumns = false;
			this.gridProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.gridProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.gridProducts.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.gridProducts.Location = new System.Drawing.Point(0, 60);
			this.gridProducts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.gridProducts.Name = "gridProducts";
			this.gridProducts.ReadOnly = true;
			this.gridProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.gridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridProducts.Size = new System.Drawing.Size(791, 316);
			this.gridProducts.TabIndex = 2;
			this.gridProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProducts_CellContentClick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 377);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1050, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "Thông tin";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 413);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(124, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "Công ty/Chi nhánh";
			// 
			// cbbCongty
			// 
			this.cbbCongty.FormattingEnabled = true;
			this.cbbCongty.Location = new System.Drawing.Point(142, 412);
			this.cbbCongty.Name = "cbbCongty";
			this.cbbCongty.Size = new System.Drawing.Size(433, 21);
			this.cbbCongty.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(15, 462);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(27, 17);
			this.label3.TabIndex = 7;
			this.label3.Text = "Mã";
			// 
			// txtMa
			// 
			this.txtMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMa.Location = new System.Drawing.Point(67, 460);
			this.txtMa.Name = "txtMa";
			this.txtMa.Size = new System.Drawing.Size(100, 23);
			this.txtMa.TabIndex = 8;
			// 
			// txtTen
			// 
			this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTen.Location = new System.Drawing.Point(238, 459);
			this.txtTen.Name = "txtTen";
			this.txtTen.Size = new System.Drawing.Size(337, 23);
			this.txtTen.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(197, 462);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 17);
			this.label4.TabIndex = 9;
			this.label4.Text = "Tên";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// txtSdt
			// 
			this.txtSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSdt.Location = new System.Drawing.Point(102, 508);
			this.txtSdt.Name = "txtSdt";
			this.txtSdt.Size = new System.Drawing.Size(276, 23);
			this.txtSdt.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(15, 511);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 17);
			this.label5.TabIndex = 11;
			this.label5.Text = "Điện thoại";
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(482, 508);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(277, 23);
			this.txtEmail.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(420, 511);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(42, 17);
			this.label6.TabIndex = 13;
			this.label6.Text = "Email";
			// 
			// txtKihieu
			// 
			this.txtKihieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtKihieu.Location = new System.Drawing.Point(659, 460);
			this.txtKihieu.Name = "txtKihieu";
			this.txtKihieu.Size = new System.Drawing.Size(100, 23);
			this.txtKihieu.TabIndex = 16;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(607, 462);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(51, 17);
			this.label7.TabIndex = 15;
			this.label7.Text = "Kí hiệu";
			// 
			// txtDiachi
			// 
			this.txtDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDiachi.Location = new System.Drawing.Point(84, 554);
			this.txtDiachi.Name = "txtDiachi";
			this.txtDiachi.Size = new System.Drawing.Size(675, 23);
			this.txtDiachi.TabIndex = 18;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(15, 557);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(51, 17);
			this.label8.TabIndex = 17;
			this.label8.Text = "Địa chỉ";
			// 
			// ckbKho
			// 
			this.ckbKho.AutoSize = true;
			this.ckbKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ckbKho.Location = new System.Drawing.Point(610, 413);
			this.ckbKho.Name = "ckbKho";
			this.ckbKho.Size = new System.Drawing.Size(52, 21);
			this.ckbKho.TabIndex = 19;
			this.ckbKho.Text = "Kho";
			this.ckbKho.UseVisualStyleBackColor = true;
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
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
			// frmDonvi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(791, 605);
			this.Controls.Add(this.ckbKho);
			this.Controls.Add(this.txtDiachi);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtKihieu);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtSdt);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtTen);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtMa);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cbbCongty);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.gridProducts);
			this.Controls.Add(this.toolStrip1);
			this.Name = "frmDonvi";
			this.Text = "QUẢN LÝ ĐƠN VỊ";
			this.Load += new System.EventHandler(this.frmDonvi_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnAdd;
		private System.Windows.Forms.ToolStripButton btnEdit;
		private System.Windows.Forms.ToolStripButton btnDelete;
		private System.Windows.Forms.ToolStripButton btnExit;
		private System.Windows.Forms.DataGridView gridProducts;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbbCongty;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMa;
		private System.Windows.Forms.TextBox txtTen;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtSdt;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtKihieu;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtDiachi;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.CheckBox ckbKho;
	}
}