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
    public partial class frmKetQua : DevComponents.DotNetBar.Office2007Form
    {
        private clsLOP_BUS lop_BUS;
        private BindingSource bs;
        private clsHOCSINH_BUS hocSinh_BUS;
        private clsDIEM_BUS diem_BUS;
        private clsHOCKY_BUS hocKy_BUS;
        private clsNAMHOC_BUS namHoc_BUS;
        private clsHANHKIEM_BUS hanhKiem_BUS;

        public frmKetQua()
        {
            InitializeComponent();
            lop_BUS = new clsLOP_BUS();
            hocSinh_BUS = new clsHOCSINH_BUS();
            diem_BUS = new clsDIEM_BUS();
            hocKy_BUS = new clsHOCKY_BUS();
            namHoc_BUS = new clsNAMHOC_BUS();
            hanhKiem_BUS = new clsHANHKIEM_BUS();
            grdKQ.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
        }

        private void frmKetQua_Load(object sender, EventArgs e)
        {
            //load dữ liệu vào comboBox 
            namHoc_BUS.hienThiComboBox(cboNamHoc);
        }

        //Trang trí datagrid như nền, canh chỉnh các hàng, ...
        private void datagridMakeUp(DataGridViewX temp)
        {
            temp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            temp.AutoResizeRows();
            temp.AllowUserToResizeColumns = true;
            temp.DefaultCellStyle.WrapMode = DataGridViewTriState.NotSet;
            temp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            temp.ReadOnly = true;
        }

        private void cboNamHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            treLop.Nodes.Clear();
            if (cboNamHoc.SelectedValue!=null)
            {
                lop_BUS.hienThiTreeLopTheoNamHoc(cboNamHoc.SelectedValue.ToString(), treLop);
            } 
        }

        private void loadDuLieu()
        {


            //.biding navigator
            bs = new BindingSource();
            bs.DataSource = hocSinh_BUS.danhSachMaHSTheoLop(cboNamHoc, treLop);
            grdKQ.DataSource = bs;
            bnaKQ.BindingSource = bs;
            string maLop = lop_BUS.layPhanBan(lop_BUS.layMaLopTrenTree(cboNamHoc, treLop));
            diem_BUS.ketQuaDiemHK(cboNamHoc, maLop, grdKQ);
            hanhKiem_BUS.hanhKiemTheoHocKiNamHoc(cboNamHoc, grdKQ);


        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            if (treLop.SelectedNode == null || treLop.SelectedNode.Parent == null)
            {
                MessageBox.Show("Bạn phải chon một lớp");
            }
            else
            {
                loadDuLieu();
            }
        }

        private void treLop_NodeDoubleClick(object sender, DevComponents.AdvTree.TreeNodeMouseEventArgs e)
        {
            //if (treLop.SelectedNode == null || treLop.SelectedNode.Parent == null)
            //{
            //    MessageBox.Show("Bạn phải chon một lớp");
            //}
            //else
            //{
            //    //.biding navigator
            //    bs = new BindingSource();
            //    bs.DataSource = hocSinh_BUS.danhSachMaHSTheoLop(cboNamHoc, treLop);
            //    grdKQ.DataSource = bs;
            //    bnaKQ.BindingSource = bs;
            //   string maLop=lop_BUS.layPhanBan(lop_BUS.layMaLopTrenTree(cboNamHoc,treLop));
            //   diem_BUS.ketQuaDiemHK(cboNamHoc, maLop, grdKQ);
            //   hanhKiem_BUS.hanhKiemTheoHocKiNamHoc(cboNamHoc, grdKQ);
            //}
            if (treLop.SelectedNode.Parent == null)
            {
            }
            else
            loadDuLieu();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //if (treLop.SelectedNode == null || treLop.SelectedNode.Parent == null)
            //{
            //    MessageBox.Show("Bạn phải chon một lớp");
            //}
            //else
            //{
            //    //.biding navigator
            //    bs = new BindingSource();
            //    bs.DataSource = hocSinh_BUS.danhSachMaHSTheoLop(cboNamHoc, treLop);
            //    grdKQ.DataSource = bs;
            //    bnaKQ.BindingSource = bs;
            //    string maLop = lop_BUS.layPhanBan(lop_BUS.layMaLopTrenTree(cboNamHoc, treLop));
            //    diem_BUS.ketQuaDiemHK(cboNamHoc, maLop, grdKQ);
            //    hanhKiem_BUS.hanhKiemTheoHocKiNamHoc(cboNamHoc, grdKQ);
            //}
            if (treLop.SelectedNode.Parent == null)
            {
            }
            else
            loadDuLieu();
        }


    }
}
