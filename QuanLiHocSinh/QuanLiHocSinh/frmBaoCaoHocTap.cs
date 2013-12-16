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
    public partial class frmBaoCaoHocTap : DevComponents.DotNetBar.Office2007Form
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

        public frmBaoCaoHocTap()
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

        public frmBaoCaoHocTap(string TenND)
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
            hocKy_BUS.hienThiComboBox(cboHocKyHSG);
            namHoc_BUS.hienThiComboBox(cboNamHocLuuBan);
            khoi_BUS.hienThiComboBox(cboKhoiLuuBan);

            monHoc_BUS.hienThiComboBox(cboMonHocMH);
            namHoc_BUS.hienThiComboBox(cboNamHocMH);
            hocKy_BUS.hienThiComboBox(cboHocKyMH);
            
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
                DataSet ds = baoCao_BUS.layThongTinKQTheoHocKy(cboNamHocHSG, cboHocKyHSG, lop_BUS.layMaLopTrenTree(cboNamHocHSG, treHSG));
                frmHiemThiReport show = new frmHiemThiReport("HSG", ds, tenND);
                show.Show();
                //ReportDocument document = new ReportDocument();
                //DataSet ds = baoCao_BUS.layThongTinKQTheoHocKy(cboNamHocHSG, cboHocKy, lop_BUS.layMaLopTrenTree(cboNamHocHSG, treHSG));
                //ds.WriteXmlSchema(Application.StartupPath + @"\HSG.xsd");

                //document.Load(Directory.GetParent(Directory.GetParent(Application.StartupPath).ToString()) + @"\report\HSG.rpt");
                //document.SetDataSource(ds.Tables[0]);
                //rptView.ReportSource = document;
                //rptView.RefreshReport();
 
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
    }
}
