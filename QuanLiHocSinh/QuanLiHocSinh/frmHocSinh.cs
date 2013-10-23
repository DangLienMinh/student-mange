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
    public partial class frmHocSinh : DevComponents.DotNetBar.Office2007Form
    {
        public clsHOCSINH_BUS hocsinh=new clsHOCSINH_BUS();
        public frmHocSinh()
        {
            InitializeComponent();
            
        }

        private void btnItemTim_Click(object sender, EventArgs e)
        {

        }

        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            hocsinh.cboGioitinh(cbGioiTinh);
            hocsinh.cboNamhoc(cbNamHoc);
        }
    }
}
