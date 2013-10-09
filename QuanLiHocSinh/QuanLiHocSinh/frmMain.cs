using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLiHocSinh
{
    public partial class frmMain : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnThemeBlue_Click(object sender, EventArgs e)
        {
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
        }

        private void btnThemeVista_Click(object sender, EventArgs e)
        {
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass;
        }

        private void btnTheme8_Click(object sender, EventArgs e)
        {
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
        }

        private void btnThemeSilver_Click(object sender, EventArgs e)
        {
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Silver;
        }

        private void btnThemeBlack_Click(object sender, EventArgs e)
        {
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Black;
        }

        private void btnTheme7_Click(object sender, EventArgs e)
        {
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
        }
    }
}
