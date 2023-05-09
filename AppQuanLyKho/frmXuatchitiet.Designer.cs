namespace AppQuanLyKho
{
	partial class frmXuatchitiet
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
			this.gridXuatchitiet = new System.Windows.Forms.DataGridView();
			this.cbbCongty = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.cbbTrangthai = new System.Windows.Forms.ComboBox();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gridXuatchitiet)).BeginInit();
			this.SuspendLayout();
			// 
			// gridXuatchitiet
			// 
			this.gridXuatchitiet.AllowUserToAddRows = false;
			this.gridXuatchitiet.AllowUserToDeleteRows = false;
			this.gridXuatchitiet.AllowUserToResizeColumns = false;
			this.gridXuatchitiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridXuatchitiet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.gridXuatchitiet.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InfoText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridXuatchitiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.gridXuatchitiet.Location = new System.Drawing.Point(1, 187);
			this.gridXuatchitiet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.gridXuatchitiet.Name = "gridXuatchitiet";
			this.gridXuatchitiet.ReadOnly = true;
			this.gridXuatchitiet.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.gridXuatchitiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridXuatchitiet.Size = new System.Drawing.Size(854, 470);
			this.gridXuatchitiet.TabIndex = 4;
			// 
			// cbbCongty
			// 
			this.cbbCongty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbCongty.FormattingEnabled = true;
			this.cbbCongty.Location = new System.Drawing.Point(231, 26);
			this.cbbCongty.Name = "cbbCongty";
			this.cbbCongty.Size = new System.Drawing.Size(573, 26);
			this.cbbCongty.TabIndex = 13;
			this.cbbCongty.SelectedIndexChanged += new System.EventHandler(this.cbbCongty_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(29, 29);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(196, 18);
			this.label5.TabIndex = 12;
			this.label5.Text = "Công ty/Chi nhánh xuất hàng";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(326, 122);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 31);
			this.button1.TabIndex = 45;
			this.button1.Text = "Cập nhật";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(152, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 18);
			this.label2.TabIndex = 44;
			this.label2.Text = "Trạng thái";
			// 
			// cbbTrangthai
			// 
			this.cbbTrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbTrangthai.FormattingEnabled = true;
			this.cbbTrangthai.Items.AddRange(new object[] {
            "Đang vận chuyển",
            "Đã đến"});
			this.cbbTrangthai.Location = new System.Drawing.Point(231, 58);
			this.cbbTrangthai.Name = "cbbTrangthai";
			this.cbbTrangthai.Size = new System.Drawing.Size(166, 26);
			this.cbbTrangthai.TabIndex = 43;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(434, 122);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(88, 31);
			this.button2.TabIndex = 46;
			this.button2.Text = "In phiếu";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// frmXuatchitiet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(855, 656);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbbTrangthai);
			this.Controls.Add(this.cbbCongty);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.gridXuatchitiet);
			this.Name = "frmXuatchitiet";
			this.Text = "CHI TIẾT PHIẾU XUẤT";
			this.Load += new System.EventHandler(this.frmXuatchitiet_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridXuatchitiet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView gridXuatchitiet;
		private System.Windows.Forms.ComboBox cbbCongty;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbbTrangthai;
		private System.Windows.Forms.Button button2;
	}
}