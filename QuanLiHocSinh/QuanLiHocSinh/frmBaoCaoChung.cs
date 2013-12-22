using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using QLHS.BUS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace QuanLiHocSinh
{
    public partial class frmBaoCaoChung : DevComponents.DotNetBar.Office2007Form
    {
        private clsNAMHOC_BUS namHoc_BUS;
        private clsHOCSINH_BUS hocSinh_BUS;
        private clsHANHKIEM_BUS hanhkiem_BUS;
        private clsHOCKY_BUS hocKy_BUS;
        private clsBAOCAO_BUS baoCao_BUS;
        private clsLOP_BUS lop_BUS;

        private string tenND;

        public frmBaoCaoChung()
        {
            InitializeComponent();
            namHoc_BUS = new clsNAMHOC_BUS();
            hocSinh_BUS = new clsHOCSINH_BUS();
            hanhkiem_BUS = new clsHANHKIEM_BUS();
            hocKy_BUS = new clsHOCKY_BUS();
            baoCao_BUS = new clsBAOCAO_BUS();
            lop_BUS = new clsLOP_BUS();
        }

        public frmBaoCaoChung(string TenND)
        {
            this.tenND = TenND;
            InitializeComponent();
            namHoc_BUS = new clsNAMHOC_BUS();
            hocSinh_BUS = new clsHOCSINH_BUS();
            hanhkiem_BUS = new clsHANHKIEM_BUS();
            hocKy_BUS = new clsHOCKY_BUS();
            baoCao_BUS = new clsBAOCAO_BUS();
            lop_BUS = new clsLOP_BUS();
        }

        private void frmBaoCaoChung_Load(object sender, EventArgs e)
        {
            namHoc_BUS.hienThiComboBox(cboNamHocDSLop);
            namHoc_BUS.hienThiComboBox(cboNamHocTheHS);
            namHoc_BUS.hienThiComboBox(cboNamHoc);
            btnDshocsinh.Enabled = false;
        }

        private void btnInDSGiaoVien_Click(object sender, EventArgs e)
        {
            ReportDocument document = new ReportDocument();
            DataSet ds = baoCao_BUS.reportDanhSachGiaoVien();
            ds.WriteXmlSchema(Application.StartupPath + @"\DSGiaoVien.xsd");

            document.Load(Directory.GetParent(Directory.GetParent(Application.StartupPath).ToString()) + @"\report\DSGiaoVien.rpt");
            document.SetDataSource(ds.Tables["GiaoVien"]);
            TextObject text = (TextObject)document.ReportDefinition.ReportObjects["NguoiLap"];
            text.Text = tenND;
            rptView.ReportSource = document;
            rptView.RefreshReport();
        }

        private void btnInTheHS_Click(object sender, EventArgs e)
        {
            if (treLop.SelectedNode == null || treLop.SelectedNode.Parent == null)
            {
                MessageBox.Show("Phải chọn một lớp");
            }
            else
            {
                ReportDocument document = new ReportDocument();
                DataSet ds = baoCao_BUS.reportTheHocSinh(hocSinh_BUS.layMaLop(cboNamHocTheHS, treLopTheHS));
                ds.WriteXmlSchema(Application.StartupPath + @"\TheHocSinh.xsd");

                document.Load(Directory.GetParent(Directory.GetParent(Application.StartupPath).ToString()) + @"\report\TheHocSinh.rpt");
                document.SetDataSource(ds.Tables["TheHocSinh"]);
                rptView.ReportSource = document;
                rptView.RefreshReport();
            }
        }

        private void btnInDSLop_Click(object sender, EventArgs e)
        {
            if (cboNamHocDSLop.SelectedValue != null)
            {
                ReportDocument document = new ReportDocument();
                DataSet ds = baoCao_BUS.reportDanhSachLop();
                ds.WriteXmlSchema(Application.StartupPath + @"\DSLop.xsd");

                document.Load(Directory.GetParent(Directory.GetParent(Application.StartupPath).ToString()) + @"\report\DSLop.rpt");
                document.SetDataSource(ds.Tables["Lop"].Select("MANH='" + cboNamHocDSLop.SelectedValue+"'").CopyToDataTable());
                //document.SetParameterValue("NguoiLap1", "your parameter value");
                TextObject text = (TextObject)document.ReportDefinition.ReportObjects["NguoiLap1"];
                text.Text = tenND;
                rptView.ReportSource = document;
                rptView.RefreshReport();
            }
        }

        private void btnDshocsinh_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.SelectedValue != null)
            {
                if (treLop.SelectedNode.Name.ToString().Substring(0, 1).ToString() == "L")
                {
                    ReportDocument document = new ReportDocument();
                    DataSet ds = hocSinh_BUS.danhSachHocSinh_NH_LOP(cboNamHoc.SelectedValue.ToString(), treLop.SelectedNode.Name.ToString());
                    ds.WriteXmlSchema(Application.StartupPath + @"\DanhSachHocSinh.xsd");
                    document.Load(Directory.GetParent(Directory.GetParent(Application.StartupPath).ToString()) + @"\report\DSHS_Lop.rpt");
                    document.SetDataSource(ds.Tables["DanhSachHocSinh"]);
                    rptView.ReportSource = document;
                    rptView.RefreshReport();
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

        private void cboNamHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            treLop.Nodes.Clear();
            hanhkiem_BUS.hienThiLopHoc(treLop, cboNamHoc);
        }

        private void treLop_NodeClick(object sender, DevComponents.AdvTree.TreeNodeMouseEventArgs e)
        {
            btnDshocsinh.Enabled = true;
        }

        private void treLop_NodeDoubleClick(object sender, DevComponents.AdvTree.TreeNodeMouseEventArgs e)
        {
            if (treLop.SelectedNode.Parent == null)
            {
            }
            else
            {
                if (cboNamHoc.SelectedValue != null)
                {
                    if (treLop.SelectedNode.Name.ToString().Substring(0, 1).ToString() == "L")
                    {
                        ReportDocument document = new ReportDocument();
                        DataSet ds = hocSinh_BUS.danhSachHocSinh_NH_LOP(cboNamHoc.SelectedValue.ToString(), treLop.SelectedNode.Name.ToString());
                        ds.WriteXmlSchema(Application.StartupPath + @"\DanhSachHocSinh.xsd");
                        document.Load(Directory.GetParent(Directory.GetParent(Application.StartupPath).ToString()) + @"\report\DSHS_Lop.rpt");
                        document.SetDataSource(ds.Tables["DanhSachHocSinh"]);
                        rptView.ReportSource = document;
                        rptView.RefreshReport();
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
        }

        private void cboNamHocTheHS_Click(object sender, EventArgs e)
        {

        }

        private void treLopTheHS_NodeDoubleClick(object sender, DevComponents.AdvTree.TreeNodeMouseEventArgs e)
        {
            if (treLopTheHS.SelectedNode.Parent == null)
            {
            }
            else
            {
                ReportDocument document = new ReportDocument();
                DataSet ds = baoCao_BUS.reportTheHocSinh(hocSinh_BUS.layMaLop(cboNamHocTheHS, treLopTheHS));
                ds.WriteXmlSchema(Application.StartupPath + @"\TheHocSinh.xsd");

                document.Load(Directory.GetParent(Directory.GetParent(Application.StartupPath).ToString()) + @"\report\TheHocSinh.rpt");
                document.SetDataSource(ds.Tables["TheHocSinh"]);
                rptView.ReportSource = document;
                rptView.RefreshReport();
            }
        }

        private void cboNamHocTheHS_SelectedValueChanged(object sender, EventArgs e)
        {
            treLopTheHS.Nodes.Clear();
            if (cboNamHocTheHS.SelectedValue != null)
            {
                lop_BUS.hienThiTreeLopTheoNamHoc(cboNamHocTheHS.SelectedValue.ToString(), treLopTheHS);
            }
        }
    }
}
