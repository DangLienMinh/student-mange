using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLHS.DTO;
using QLHS.BUS;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;

namespace QuanLiHocSinh
{
    public partial class frmPhanLop : DevComponents.DotNetBar.Office2007Form
    {
        private clsLOP_BUS lop_bus;
        private clsKHOI_BUS khoi_bus;
        private clsNAMHOC_BUS namHoc_bus;
        private clsHOCSINH_BUS hocsinh_bus;

        public frmPhanLop()
        {
            InitializeComponent();
            lop_bus = new clsLOP_BUS();
            khoi_bus = new clsKHOI_BUS();
            namHoc_bus = new clsNAMHOC_BUS();
            hocsinh_bus = new clsHOCSINH_BUS();
        }

        private void frmPhanLop_Load(object sender, EventArgs e)
        {
            khoi_bus.hienThiComboBox(cboKhoiLopCu);
            namHoc_bus.hienThiComboBox(cboNamHocCu);
            khoi_bus.hienThiComboBox(cboKhoiLopMoi);
            namHoc_bus.hienThiComboBox(cboNamHocMoi);
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {

        }

        private void cboNamHocCu_SelectedValueChanged(object sender, EventArgs e)
        {         
            lop_bus.hienThiCbLopTheoNamHocKhoi(cboNamHocCu.SelectedValue.ToString(), cboLopCu,cboKhoiLopCu.SelectedValue.ToString());
        }

        private void cboKhoiLopCu_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboNamHocCu.SelectedValue!=null)
            {
                lop_bus.hienThiCbLopTheoNamHocKhoi(cboNamHocCu.SelectedValue.ToString(), cboLopCu, cboKhoiLopCu.SelectedValue.ToString());
                if (cboLopCu.Items.Count<=0)
                {
                    cboLopCu.Text = "";
                }
            }
            
        }

        private void cboNamHocMoi_SelectedValueChanged(object sender, EventArgs e)
        {
            lop_bus.hienThiCbLopTheoNamHocKhoi(cboNamHocMoi.SelectedValue.ToString(), cboLopMoi, cboKhoiLopMoi.SelectedValue.ToString());
        }

  
        private void cboKhoiLopMoi_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboNamHocMoi.SelectedValue != null)
            {
                lop_bus.hienThiCbLopTheoNamHocKhoi(cboNamHocMoi.SelectedValue.ToString(), cboLopMoi, cboKhoiLopMoi.SelectedValue.ToString());
                if (cboLopMoi.Items.Count <= 0)
                {
                    cboLopMoi.Text = "";
                }
            }
        }

        private void cboLopCu_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboNamHocCu.SelectedValue != null && cboLopCu.SelectedValue != null)
            {
                hocsinh_bus.danhSachHocSinhTheoLop(cboNamHocCu, cboLopCu, lstLopCu);
            }
        }




       
    }
}
