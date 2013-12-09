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
    public partial class frmBaoCaoHocTap : DevComponents.DotNetBar.Office2007Form
    {
        private clsNAMHOC_BUS namHoc_BUS;
        private clsLOP_BUS lop_BUS;
        private clsHOCSINH_BUS hocSinh_BUS;
        private clsHANHKIEM_BUS hanhkiem_BUS;
        private clsHOCKY_BUS hocKy_BUS;
        private string tenND;

        public frmBaoCaoHocTap()
        {
           InitializeComponent();
            namHoc_BUS = new clsNAMHOC_BUS();
            lop_BUS = new clsLOP_BUS();
            hocSinh_BUS = new clsHOCSINH_BUS();
            hanhkiem_BUS = new clsHANHKIEM_BUS();
            hocKy_BUS = new clsHOCKY_BUS();
        }

        public frmBaoCaoHocTap(string TenND)
        {
            this.tenND = TenND;
            InitializeComponent();
            namHoc_BUS = new clsNAMHOC_BUS();
            lop_BUS = new clsLOP_BUS();
            hocSinh_BUS = new clsHOCSINH_BUS();
            hanhkiem_BUS = new clsHANHKIEM_BUS();
            hocKy_BUS = new clsHOCKY_BUS();

        }

        private void frmBaoCaoHocTap_Load(object sender, EventArgs e)
        {
            namHoc_BUS.hienThiComboBox(cboNamHocHSG);
            hocKy_BUS.hienThiComboBox(cboHocKyHSG);
        }
    }
}
