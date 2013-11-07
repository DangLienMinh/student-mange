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
        private clsNAMHOC_BUS namHoc_BUS;
        private clsLOP_BUS lop_BUS;

        public frmDiem()
        {
            InitializeComponent();
            namHoc_BUS=new clsNAMHOC_BUS();
            lop_BUS=new clsLOP_BUS();
        }

        private void cbNamHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            treKhoi.Nodes.Clear();
            lop_BUS.hienThiLopTheoNamHoc(cboNamHoc.SelectedValue.ToString(), treKhoi);
        }

        private void frmDiem_Load(object sender, EventArgs e)
        {
            namHoc_BUS.hienThiComboBox(cboNamHoc);
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {

        }
    }
}
