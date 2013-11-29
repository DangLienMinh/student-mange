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
        private clsLOP_BUS lop_BUS;
        private clsHOCSINH_BUS hocSinh_BUS;
 
        public frmBaoCaoMain()
        {
            InitializeComponent();
            namHoc_BUS = new clsNAMHOC_BUS();
            lop_BUS = new clsLOP_BUS();
            hocSinh_BUS = new clsHOCSINH_BUS();
        }

        private void frmBaoCaoMain_Load(object sender, EventArgs e)
        {
            namHoc_BUS.hienThiComboBox(cboNamHocDSLop);
            namHoc_BUS.hienThiComboBox(cboNamHocTheHS); 
        }

        private void btnInDSLop_Click(object sender, EventArgs e)
        {
            if (cboNamHocDSLop.SelectedValue!=null)
            {
                frmHiemThiReport hien = new frmHiemThiReport("MANH='" + cboNamHocDSLop.SelectedValue+"'","frmDSLop");
                hien.Show();
            }
        }

        private void btnInDSGiaoVien_Click(object sender, EventArgs e)
        {
            frmHiemThiReport hien = new frmHiemThiReport("frmDSGiaoVien");
            hien.Show();
        }

        private void btnInTheHS_Click(object sender, EventArgs e)
        {
            if (treLopTheHS.SelectedNode == null || treLopTheHS.SelectedNode.Parent == null)
            {
                MessageBox.Show("Bạn phải chon một lớp");
            }
            else
            {
                frmHiemThiReport hien = new frmHiemThiReport(hocSinh_BUS.layMaLop(cboNamHocTheHS,treLopTheHS), "frmTheHocSinh");
                hien.Show();
            }
        }

        private void cboNamHocTheHS_SelectedValueChanged(object sender, EventArgs e)
        {
            treLopTheHS.Nodes.Clear();
            if (cboNamHocTheHS.SelectedValue!=null)
            {
                lop_BUS.hienThiTreeLopTheoNamHoc(cboNamHocTheHS.SelectedValue.ToString(), treLopTheHS);
            }
        }
    }
}
