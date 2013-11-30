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
        private clsHANHKIEM_BUS hanhkiem_BUS;
        public frmBaoCaoMain()
        {
            InitializeComponent();
            namHoc_BUS = new clsNAMHOC_BUS();
            lop_BUS = new clsLOP_BUS();
            hocSinh_BUS = new clsHOCSINH_BUS();
            hanhkiem_BUS = new clsHANHKIEM_BUS();
        }

        private void frmBaoCaoMain_Load(object sender, EventArgs e)
        {
            namHoc_BUS.hienThiComboBox(cboNamHocDSLop);
            namHoc_BUS.hienThiComboBox(cboNamHocTheHS);
            namHoc_BUS.hienThiComboBox(cboNamHoc);
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

        private void cboNamHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            treLop.Nodes.Clear();
            hanhkiem_BUS.hienThiLopHoc(treLop, cboNamHoc);
        }

        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDshocsinh_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.SelectedValue != null)
            {
                if (treLop.SelectedNode.Name.ToString().Substring(0, 1).ToString() == "L")
                {
                    frmHiemThiReport hien = new frmHiemThiReport(cboNamHoc.SelectedValue.ToString(), treLop.SelectedNode.Name.ToString(), "frmDSHocSinh");
                    hien.Show();
                }
            }
        }
    }
}
