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
        private clsHOCKY_BUS hocKy_BUS;
        private string tenND;

        public frmBaoCaoMain()
        {
            InitializeComponent();
            namHoc_BUS = new clsNAMHOC_BUS();
            lop_BUS = new clsLOP_BUS();
            hocSinh_BUS = new clsHOCSINH_BUS();
            hanhkiem_BUS = new clsHANHKIEM_BUS();
            hocKy_BUS = new clsHOCKY_BUS();
        }

        public frmBaoCaoMain(string TenND)
        {
            this.tenND = TenND;
            InitializeComponent();
            namHoc_BUS = new clsNAMHOC_BUS();
            lop_BUS = new clsLOP_BUS();
            hocSinh_BUS = new clsHOCSINH_BUS();
            hanhkiem_BUS = new clsHANHKIEM_BUS();
            hocKy_BUS = new clsHOCKY_BUS();
            
        }

        private void frmBaoCaoMain_Load(object sender, EventArgs e)
        {
            namHoc_BUS.hienThiComboBox(cboNamHocDSLop);
            namHoc_BUS.hienThiComboBox(cboNamHocTheHS);
            namHoc_BUS.hienThiComboBox(cboNamHoc);
            namHoc_BUS.hienThiComboBox(cboNamHocHSG);
            hocKy_BUS.hienThiComboBox(cboHocKyHSG);
            btnDshocsinh.Enabled = false;
        }

        private void btnInDSLop_Click(object sender, EventArgs e)
        {
            if (cboNamHocDSLop.SelectedValue!=null)
            {
                frmHiemThiReport hien = new frmHiemThiReport("MANH='" + cboNamHocDSLop.SelectedValue+"'","frmDSLop",tenND);
                hien.Show();
            }
        }

        private void btnInDSGiaoVien_Click(object sender, EventArgs e)
        {
            frmHiemThiReport hien = new frmHiemThiReport("frmDSGiaoVien",tenND);
            hien.Show();
        }

        private void btnInTheHS_Click(object sender, EventArgs e)
        {
            if (treLopTheHS.SelectedNode.Parent == null)
            {
            }
            else
            {
                frmHiemThiReport hien = new frmHiemThiReport(hocSinh_BUS.layMaLop(cboNamHocTheHS, treLopTheHS), "frmTheHocSinh", tenND);
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

        private void treLopTheHS_NodeDoubleClick(object sender, DevComponents.AdvTree.TreeNodeMouseEventArgs e)
        {
            if (treLopTheHS.SelectedNode.Parent == null)
            {
            }
            else
            {
                frmHiemThiReport hien = new frmHiemThiReport(hocSinh_BUS.layMaLop(cboNamHocTheHS, treLopTheHS), "frmTheHocSinh", tenND);
                hien.Show();
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
                        frmHiemThiReport hien = new frmHiemThiReport(cboNamHoc.SelectedValue.ToString(), treLop.SelectedNode.Name.ToString(), "frmDSHocSinh", tenND);
                        hien.Show();
                    }
                    else
                    {
                        MessageBox.Show("Chưa chọn lớp học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Chưa chọn năm học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void treLop_NodeDoubleClick(object sender, DevComponents.AdvTree.TreeNodeMouseEventArgs e)
        {
            if (treLop.SelectedNode.Parent == null)
            {
            }
            else
            {
                frmHiemThiReport hien = new frmHiemThiReport(cboNamHoc.SelectedValue.ToString(), treLop.SelectedNode.Name.ToString(), "frmDSHocSinh");
                hien.Show();
            }
        }

        private void treLop_NodeClick(object sender, DevComponents.AdvTree.TreeNodeMouseEventArgs e)
        {
           btnDshocsinh.Enabled = true;
        }

        private void cboNamHocHSG_SelectedValueChanged(object sender, EventArgs e)
        {
            treHSG.Nodes.Clear();
            if (cboNamHocHSG.SelectedValue != null)
            {
                lop_BUS.hienThiTreeLopTheoNamHoc(cboNamHocHSG.SelectedValue.ToString(), treHSG);
            }
        }

        private void btnInHSG_Click(object sender, EventArgs e)
        {
            if (treHSG.SelectedNode.Parent == null)
            {
            }
            else
            {
                //frmHiemThiReport hien = new frmHiemThiReport(hocSinh_BUS.layMaLop(cboNamHocTheHS, treLopTheHS), "frmTheHocSinh", tenND);
                //hien.Show();
            }
        }
    }
}
