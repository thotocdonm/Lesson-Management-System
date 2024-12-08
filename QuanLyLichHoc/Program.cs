using QuanLyLichHoc.Forms.Login;
using QuanLyLichHoc.Views;
using System;
using System.Windows.Forms;

namespace QuanLyLichHoc
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginForm());

            Application.Run(new LoginForm());

      

        }
    }
}
