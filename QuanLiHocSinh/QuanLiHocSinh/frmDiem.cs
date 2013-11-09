using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLHS.BUS;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;

namespace QuanLiHocSinh
{
    public partial class frmDiem : DevComponents.DotNetBar.Office2007Form
    {
        private frmLoaiDiem frm_LoaiDiem = null;
        private clsNAMHOC_BUS namHoc_BUS;
        private clsLOP_BUS lop_BUS;
        private clsHOCKY_BUS hocKy_BUS;
        private clsLOAIDIEM_BUS loaiDiem_BUS;
        private clsMONHOC_BUS monHoc_BUS;
        private clsHOCSINH_BUS hocSinh_BUS;

        public frmDiem()
        {
            InitializeComponent();
            namHoc_BUS=new clsNAMHOC_BUS();
            lop_BUS=new clsLOP_BUS();
            hocKy_BUS=new clsHOCKY_BUS();
            loaiDiem_BUS = new clsLOAIDIEM_BUS();
            monHoc_BUS = new clsMONHOC_BUS();
            hocSinh_BUS = new clsHOCSINH_BUS();
        }

        private void cbNamHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            treKhoi.Nodes.Clear();
            lop_BUS.hienThiTreeLopTheoNamHoc(cboNamHoc.SelectedValue.ToString(), treKhoi);
        }

        private void frmDiem_Load(object sender, EventArgs e)
        {
            namHoc_BUS.hienThiComboBox(cboNamHoc);
            namHoc_BUS.hienThiComboBox(cboNamHoc1);
            hocKy_BUS.hienThiComboBox(cboHocKy1);
            hocKy_BUS.hienThiComboBox(cboHocKy);
            monHoc_BUS.hienThiComboBox(cboMonHoc);
            monHoc_BUS.hienThiComboBox(cboMonHoc1);
            loaiDiem_BUS.hienThiComboBox(cboLoaiDiem1);

           
            tabControl1.SelectedTab = btnItemLop;
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {

        }

        private void btnLoaiDiem_Click(object sender, EventArgs e)
        {
            if (frm_LoaiDiem == null || frm_LoaiDiem.IsDisposed)
            {
                frm_LoaiDiem = new frmLoaiDiem();
                frm_LoaiDiem.FormBorderStyle = FormBorderStyle.None;
                frm_LoaiDiem.MdiParent = frmMain.ActiveForm;
                frm_LoaiDiem.Show();
            }
            else
                frm_LoaiDiem.Activate(); 
        }

        private void cboNamHoc1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc1.SelectedValue!=null)
            {
                lop_BUS.hienThiCboLopTheoNamHoc(cboNamHoc1.SelectedValue.ToString(), cboLop1);
            }
        }

        private void cboLop1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboLop1.SelectedValue!=null && cboNamHoc1.SelectedValue!=null)
            {
                hocSinh_BUS.danhSachHocSinhTheoLop(cboNamHoc1, cboLop1, cboHocSinh1);
            }
        }
    }
}
