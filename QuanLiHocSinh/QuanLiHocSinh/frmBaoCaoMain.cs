using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLHS.BUS;

namespace QuanLiHocSinh
{
    public partial class frmBaoCaoMain : DevComponents.DotNetBar.Office2007Form
    {
        private clsNAMHOC_BUS namHoc_BUS;
 
        public frmBaoCaoMain()
        {
            InitializeComponent();
            namHoc_BUS = new clsNAMHOC_BUS();
        }

        private void frmBaoCaoMain_Load(object sender, EventArgs e)
        {
            namHoc_BUS.hienThiComboBox(cboNamHocDSLop);   
        }

        private void btnInDSLop_Click(object sender, EventArgs e)
        {
            if (cboNamHocDSLop.SelectedValue!=null)
            {
                frmHiemThiReport hien = new frmHiemThiReport("MANH='" + cboNamHocDSLop.SelectedValue+"'","frmDSLop");
                hien.Show();
            }
        }
    }
}
