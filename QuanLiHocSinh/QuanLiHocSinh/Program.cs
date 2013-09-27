using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLiHocSinh
{//minh vãi nhồn
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //dang lien ming ga vl ra
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
