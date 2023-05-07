using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyKho
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		public static string strConn = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=FINALPROJECTSE;Persist Security Info=True;User ID=sa;Password=sql2017";
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frmMain());
		}
	}
}
