using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro_HoPhanMinhTuan
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form frmTuan = new frmTuan();
            frmTuan.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(frmTuan);
        }
    }
}
