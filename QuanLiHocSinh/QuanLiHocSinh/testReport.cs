using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLHS.BUS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.IO;

namespace QuanLiHocSinh
{
    public partial class testReport : DevComponents.DotNetBar.Office2007Form
    {
        private clsNAMHOC_BUS namHoc_BUS;
        private clsLOP_BUS lop_BUS;
        private clsHOCSINH_BUS hocSinh_BUS;
        private clsHANHKIEM_BUS hanhkiem_BUS;
        private clsBAOCAO_BUS baoCao_BUS;
        private clsHOCKY_BUS hocKy_BUS;
        private clsKHOI_BUS khoi_BUS;
        private clsMONHOC_BUS monHoc_BUS;
        private string tenND;

        public testReport()
        {
           InitializeComponent();
            namHoc_BUS = new clsNAMHOC_BUS();
            lop_BUS = new clsLOP_BUS();
            hocSinh_BUS = new clsHOCSINH_BUS();
            hanhkiem_BUS = new clsHANHKIEM_BUS();
            hocKy_BUS = new clsHOCKY_BUS();
            baoCao_BUS = new clsBAOCAO_BUS();
            khoi_BUS = new clsKHOI_BUS();
            monHoc_BUS = new clsMONHOC_BUS();
        }

        public testReport(string TenND)
        {
            this.tenND = TenND;
            InitializeComponent();
            namHoc_BUS = new clsNAMHOC_BUS();
            lop_BUS = new clsLOP_BUS();
            hocSinh_BUS = new clsHOCSINH_BUS();
            hanhkiem_BUS = new clsHANHKIEM_BUS();
            hocKy_BUS = new clsHOCKY_BUS();
            baoCao_BUS = new clsBAOCAO_BUS();
            khoi_BUS = new clsKHOI_BUS();
            monHoc_BUS = new clsMONHOC_BUS();
        }

        private void frmBaoCaoHocTap_Load(object sender, EventArgs e)
        {
            namHoc_BUS.hienThiComboBox(cboNamHocHSG);
            namHoc_BUS.hienThiComboBox(cboNamhocBangDiem);
            hocKy_BUS.hienThiComboBox(cboHocKyHSG);
            namHoc_BUS.hienThiComboBox(cboNamHocLuuBan);
            khoi_BUS.hienThiComboBox(cboKhoiLuuBan);

            monHoc_BUS.hienThiComboBox(cboMonHocMH);
            namHoc_BUS.hienThiComboBox(cboNamHocMH);
            hocKy_BUS.hienThiComboBox(cboHocKyMH);
            hocKy_BUS.hienThiComboBox(cboHKTongKetHK);
            namHoc_BUS.hienThiComboBox(cboNHTongKetHK);

            namHoc_BUS.hienThiComboBox(cboNamHocHocBa);
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
            if (treHSG.SelectedNode == null || treHSG.SelectedNode.Parent == null)
            {
                MessageBox.Show("Phải chọn một lớp");
            }
            else
            {
                DataSet ds = baoCao_BUS.HSGTheoHocKy(cboNamHocHSG, cboHocKyHSG, lop_BUS.layMaLopTrenTree(cboNamHocHSG, treHSG));
                frmHiemThiReport show = new frmHiemThiReport("HSG", ds, tenND);
                show.Show();
            }
        }

        private void btnInLuuBan_Click(object sender, EventArgs e)
        {
            if (cboNamHocLuuBan.SelectedValue!=null&&cboKhoiLuuBan.SelectedValue!=null)
            {
                DataSet ds = baoCao_BUS.layThongTinLuuBanTheoNamHoc(cboNamHocHSG,cboKhoiLuuBan);
                frmHiemThiReport show = new frmHiemThiReport("LuuBan", ds, tenND);
                show.Show();
            }
        }

        private void btnInMH_Click(object sender, EventArgs e)
        {
            if (treLopMH.SelectedNode == null || treLopMH.SelectedNode.Parent == null)
            {
                MessageBox.Show("Phải chọn một lớp");
            }
            else
            {
                DataSet ds = baoCao_BUS.baoCaoDiemTheoMonHoc(cboNamHocMH, cboHocKyMH,cboMonHocMH, lop_BUS.layMaLopTrenTree(cboNamHocMH, treLopMH));
                frmHiemThiReport show = new frmHiemThiReport("DiemTheoMonHoc", ds, tenND);
                show.Show();
            }
        }

        private void cboNamHocMH_SelectedValueChanged(object sender, EventArgs e)
        {
            treLopMH.Nodes.Clear();
            if (cboNamHocMH.SelectedValue != null)
            {
                lop_BUS.hienThiTreeLopTheoNamHoc(cboNamHocMH.SelectedValue.ToString(), treLopMH);
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            DataSet ds = baoCao_BUS.hocBaTheoNamHoc(cboNamHocHocBa, cboHocSinhHocBa, lop_BUS.layMaLopTrenTree(cboNamHocHocBa, treLopHocBa));
            if (ds.Tables.Count<4)
            {
                MessageBox.Show("Học sinh chưa hoàn thành 3 năm học tại trường");
            }
            else
            {
                frmHiemThiReport show = new frmHiemThiReport("HocBa", ds, tenND);
                show.Show();
            }
            
        }

        private void cboNamhocBangDiem_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboNamhocBangDiem.SelectedValue != null)
            {
                treLopBangDiem.Nodes.Clear();
                hanhkiem_BUS.hienThiLopHoc(treLopBangDiem, cboNamhocBangDiem);
            }
        }

        private void treLopBangDiem_NodeClick(object sender, DevComponents.AdvTree.TreeNodeMouseEventArgs e)
        {
            if (treLopBangDiem.SelectedNode.Name.Substring(0, 1) == "L" && cboNamhocBangDiem.SelectedValue != null)
            {
                hocSinh_BUS.HienThicbodsHocSinh(cboHocsinhBangDiem, cboNamhocBangDiem.SelectedValue.ToString(), treLopBangDiem.SelectedNode.Name.ToString());
            }
        }

        private void btnInbangdiem_Click(object sender, EventArgs e)
        {
            if (cboHocsinhBangDiem.SelectedValue != null)
            {
                frmHiemThiReport frmBangDiem = new frmHiemThiReport("frmBangDiem", baoCao_BUS.bangDiemHocSinh(cboNamhocBangDiem.SelectedValue.ToString(), treLopBangDiem.SelectedNode.Name.ToString(), cboHocsinhBangDiem.SelectedValue.ToString()));
                frmBangDiem.Show();
            }
            else
            {
                MessageBox.Show("Phải chọn Học sinh cần in bảng điểm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cboNHTongKetHK_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboNHTongKetHK.SelectedValue != null)
            {
                treLopTongKetHK.Nodes.Clear();
                hanhkiem_BUS.hienThiLopHoc(treLopTongKetHK, cboNHTongKetHK);
            }
        }

        private void btnInTongKetHK_Click(object sender, EventArgs e)
        {
            if (treLopTongKetHK.SelectedNode == null || treLopTongKetHK.SelectedNode.Parent == null)
            {
                MessageBox.Show("Phải chọn một lớp");
            }
            else
            {
                DataSet ds = baoCao_BUS.layThongTinKQTheoHocKy(cboNHTongKetHK, cboHKTongKetHK, lop_BUS.layMaLopTrenTree(cboNHTongKetHK, treLopTongKetHK));
                frmHiemThiReport show = new frmHiemThiReport("TongKetHK", ds, tenND);
                show.Show();
            }
        }

        private void treLopTongKetHK_NodeDoubleClick(object sender, DevComponents.AdvTree.TreeNodeMouseEventArgs e)
        {
            if (treLopTongKetHK.SelectedNode.Parent == null)
            {
            }
            else
            {
                DataSet ds = baoCao_BUS.layThongTinKQTheoHocKy(cboNHTongKetHK, cboHKTongKetHK, lop_BUS.layMaLopTrenTree(cboNHTongKetHK, treLopTongKetHK));
                frmHiemThiReport show = new frmHiemThiReport("TongKetHK", ds, tenND);
                show.Show();
            }
        }

        private void treLopMH_NodeDoubleClick(object sender, DevComponents.AdvTree.TreeNodeMouseEventArgs e)
        {
            if (treLopMH.SelectedNode.Parent == null)
            {
            }
            else
            {
                DataSet ds = baoCao_BUS.baoCaoDiemTheoMonHoc(cboNamHocMH, cboHocKyMH, cboMonHocMH, lop_BUS.layMaLopTrenTree(cboNamHocMH, treLopMH));
                frmHiemThiReport show = new frmHiemThiReport("DiemTheoMonHoc", ds, tenND);
                show.Show();
            }
        }

        private void treHSG_NodeDoubleClick(object sender, DevComponents.AdvTree.TreeNodeMouseEventArgs e)
        {
            if (treLopMH.SelectedNode.Parent == null)
            {
            }
            else
            {
                DataSet ds = baoCao_BUS.HSGTheoHocKy(cboNamHocHSG, cboHocKyHSG, lop_BUS.layMaLopTrenTree(cboNamHocHSG, treHSG));
                frmHiemThiReport show = new frmHiemThiReport("HSG", ds, tenND);
                show.Show();
            }
        }

        private void treLopHocBa_NodeClick(object sender, DevComponents.AdvTree.TreeNodeMouseEventArgs e)
        {
            if (treLopHocBa.SelectedNode.Parent == null)
            {
            }
            else
            {
                if (cboNamHocHocBa.SelectedValue!=null)
                {
                    hocSinh_BUS.HienThicbodsHocSinh(cboHocSinhHocBa, cboNamHocHocBa.SelectedValue.ToString(), lop_BUS.layMaLopTrenTree(cboNamHocHocBa, treLopHocBa));
                }               
            }
        }

        private void cboNamHocHocBa_SelectedValueChanged(object sender, EventArgs e)
        {
            treLopHocBa.Nodes.Clear();
            if (cboNamHocHocBa.SelectedValue != null)
            {
                lop_BUS.hienThiTreeLopTheoNamHoc(cboNamHocHocBa.SelectedValue.ToString(), treLopHocBa);
            }
        }
    }
}
