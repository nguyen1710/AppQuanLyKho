﻿namespace AppQuanLyKho
{
	partial class Login
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
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.btnLogin = new System.Windows.Forms.Button();
			this.Password = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPwd = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbbCongty = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(420, 274);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(158, 13);
			this.linkLabel1.TabIndex = 13;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Do you have Account? Sign in?";
			// 
			// btnLogin
			// 
			this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.Location = new System.Drawing.Point(350, 318);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(90, 42);
			this.btnLogin.TabIndex = 12;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// Password
			// 
			this.Password.AutoSize = true;
			this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Password.Location = new System.Drawing.Point(195, 238);
			this.Password.Name = "Password";
			this.Password.Size = new System.Drawing.Size(117, 22);
			this.Password.TabIndex = 11;
			this.Password.Text = "Mã chi nhánh";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(187, 199);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 22);
			this.label2.TabIndex = 10;
			this.label2.Text = "Tên chi nhánh";
			// 
			// txtPwd
			// 
			this.txtPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPwd.Location = new System.Drawing.Point(321, 235);
			this.txtPwd.Name = "txtPwd";
			this.txtPwd.Size = new System.Drawing.Size(257, 27);
			this.txtPwd.TabIndex = 9;
			this.txtPwd.UseSystemPasswordChar = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(308, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(175, 54);
			this.label1.TabIndex = 7;
			this.label1.Text = "LOGIN";
			// 
			// cbbCongty
			// 
			this.cbbCongty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbCongty.FormattingEnabled = true;
			this.cbbCongty.Location = new System.Drawing.Point(321, 196);
			this.cbbCongty.Name = "cbbCongty";
			this.cbbCongty.Size = new System.Drawing.Size(257, 28);
			this.cbbCongty.TabIndex = 14;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::AppQuanLyKho.Properties.Resources.login1;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cbbCongty);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.Password);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtPwd);
			this.Controls.Add(this.label1);
			this.Name = "Login";
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Login_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Label Password;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPwd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbbCongty;
	}
}