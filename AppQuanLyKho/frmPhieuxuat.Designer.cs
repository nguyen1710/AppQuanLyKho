namespace AppQuanLyKho
{
	partial class frmPhieuxuat
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuxuat));
			this.btnFind = new System.Windows.Forms.Button();
			this.dateEnd = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.dateStart = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.gridXuat = new System.Windows.Forms.DataGridView();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnAdd = new System.Windows.Forms.ToolStripButton();
			this.btnEdit = new System.Windows.Forms.ToolStripButton();
			this.btnDelete = new System.Windows.Forms.ToolStripButton();
			this.btnExit = new System.Windows.Forms.ToolStripButton();
			this.ID = new System.Windows.Forms.Label();
			this.IDChungtu = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.gridXuat)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnFind
			// 
			this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFind.Location = new System.Drawing.Point(491, 198);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(86, 33);
			this.btnFind.TabIndex = 26;
			this.btnFind.Text = "Tìm";
			this.btnFind.UseVisualStyleBackColor = true;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// dateEnd
			// 
			this.dateEnd.CustomFormat = "yyyy-MM-dd";
			this.dateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateEnd.Location = new System.Drawing.Point(464, 148);
			this.dateEnd.Name = "dateEnd";
			this.dateEnd.Size = new System.Drawing.Size(200, 24);
			this.dateEnd.TabIndex = 21;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(362, 151);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 18);
			this.label4.TabIndex = 20;
			this.label4.Text = "Đến ngày";
			// 
			// dateStart
			// 
			this.dateStart.CustomFormat = "yyyy-MM-dd";
			this.dateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateStart.Location = new System.Drawing.Point(464, 106);
			this.dateStart.Name = "dateStart";
			this.dateStart.Size = new System.Drawing.Size(200, 24);
			this.dateStart.TabIndex = 19;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(362, 106);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 18);
			this.label3.TabIndex = 18;
			this.label3.Text = "Từ ngày";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(2, 64);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1062, 24);
			this.label1.TabIndex = 17;
			this.label1.Text = "Thông tin";
			// 
			// gridXuat
			// 
			this.gridXuat.AllowUserToAddRows = false;
			this.gridXuat.AllowUserToDeleteRows = false;
			this.gridXuat.AllowUserToResizeColumns = false;
			this.gridXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridXuat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.gridXuat.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridXuat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.gridXuat.Location = new System.Drawing.Point(0, 253);
			this.gridXuat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.gridXuat.Name = "gridXuat";
			this.gridXuat.ReadOnly = true;
			this.gridXuat.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.gridXuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridXuat.Size = new System.Drawing.Size(1062, 355);
			this.gridXuat.TabIndex = 16;
			this.gridXuat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridXuat_CellContentClick);
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
			this.toolStrip1.Size = new System.Drawing.Size(1067, 57);
			this.toolStrip1.TabIndex = 15;
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
			// ID
			// 
			this.ID.AutoSize = true;
			this.ID.Location = new System.Drawing.Point(1029, 9);
			this.ID.Name = "ID";
			this.ID.Size = new System.Drawing.Size(0, 13);
			this.ID.TabIndex = 27;
			// 
			// IDChungtu
			// 
			this.IDChungtu.AutoSize = true;
			this.IDChungtu.Location = new System.Drawing.Point(1020, 234);
			this.IDChungtu.Name = "IDChungtu";
			this.IDChungtu.Size = new System.Drawing.Size(0, 13);
			this.IDChungtu.TabIndex = 28;
			this.IDChungtu.Visible = false;
			// 
			// frmPhieuxuat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 641);
			this.Controls.Add(this.IDChungtu);
			this.Controls.Add(this.ID);
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.dateEnd);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dateStart);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.gridXuat);
			this.Controls.Add(this.toolStrip1);
			this.Name = "frmPhieuxuat";
			this.Text = "frmPhieuxuat";
			this.Load += new System.EventHandler(this.frmPhieuxuat_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridXuat)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.DateTimePicker dateEnd;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dateStart;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView gridXuat;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnAdd;
		private System.Windows.Forms.ToolStripButton btnEdit;
		private System.Windows.Forms.ToolStripButton btnDelete;
		private System.Windows.Forms.ToolStripButton btnExit;
		private System.Windows.Forms.Label ID;
		private System.Windows.Forms.Label IDChungtu;
	}
}