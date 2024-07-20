using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlshopthoitrangtreem
{
    static class Program
    {
        public static frmMain mainForm = null;
        public static frmDangNhap loginForm = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            loginForm = new frmDangNhap();
            /*Application.Run(new frmMain());*/
            Application.Run(loginForm);
        }
    }
}
