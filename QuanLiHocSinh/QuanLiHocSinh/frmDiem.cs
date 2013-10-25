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
            treeKhoi.Nodes.Clear();
            lop_BUS.hienThiLopTheoNamHoc(cbNamHoc.SelectedValue.ToString(), treeKhoi);
        }

        private void frmDiem_Load(object sender, EventArgs e)
        {
            namHoc_BUS.hienThiComboBox(cbNamHoc);
            //lop_BUS.hienThiLopTheoNamHoc(cbNamHoc.SelectedValue.ToString(), treeKhoi);
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {

        }
    }
}
