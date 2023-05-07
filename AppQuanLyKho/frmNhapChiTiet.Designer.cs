namespace AppQuanLyKho
{
	partial class frmNhapChiTiet
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.gridNhapchitiet = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.cbbTrangthai = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gridNhapchitiet)).BeginInit();
			this.SuspendLayout();
			// 
			// gridNhapchitiet
			// 
			this.gridNhapchitiet.AllowUserToAddRows = false;
			this.gridNhapchitiet.AllowUserToDeleteRows = false;
			this.gridNhapchitiet.AllowUserToResizeColumns = false;
			this.gridNhapchitiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridNhapchitiet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.gridNhapchitiet.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InfoText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridNhapchitiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.gridNhapchitiet.Location = new System.Drawing.Point(0, 54);
			this.gridNhapchitiet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.gridNhapchitiet.Name = "gridNhapchitiet";
			this.gridNhapchitiet.ReadOnly = true;
			this.gridNhapchitiet.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.gridNhapchitiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridNhapchitiet.Size = new System.Drawing.Size(663, 515);
			this.gridNhapchitiet.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(26, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 18);
			this.label2.TabIndex = 41;
			this.label2.Text = "Trạng thái";
			// 
			// cbbTrangthai
			// 
			this.cbbTrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbTrangthai.FormattingEnabled = true;
			this.cbbTrangthai.Items.AddRange(new object[] {
            "Đang vận chuyển",
            "Đã đến"});
			this.cbbTrangthai.Location = new System.Drawing.Point(126, 17);
			this.cbbTrangthai.Name = "cbbTrangthai";
			this.cbbTrangthai.Size = new System.Drawing.Size(166, 26);
			this.cbbTrangthai.TabIndex = 40;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(320, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 31);
			this.button1.TabIndex = 42;
			this.button1.Text = "Cập nhật";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(442, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(88, 31);
			this.button2.TabIndex = 43;
			this.button2.Text = "In phiếu";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// frmNhapChiTiet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(663, 569);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbbTrangthai);
			this.Controls.Add(this.gridNhapchitiet);
			this.Name = "frmNhapChiTiet";
			this.Text = "frmNhapChiTiet";
			this.Load += new System.EventHandler(this.frmNhapChiTiet_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridNhapchitiet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView gridNhapchitiet;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbbTrangthai;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}