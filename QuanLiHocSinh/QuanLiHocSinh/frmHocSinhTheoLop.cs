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
    public partial class frmHocSinhTheoLop : DevComponents.DotNetBar.Office2007Form
    {
        private clsLOP_BUS lop_BUS;
        private clsNAMHOC_BUS namHoc_BUS;
        private clsHOCSINH_BUS hocSinh_BUS;
        private int viTri, Tong;
        private BindingSource bs;

        public frmHocSinhTheoLop()
        {
            InitializeComponent();
            this.KeyPreview = true;
            datagridMakeUp(grdHocSinh);
            grdHocSinh.DataSource = new DataTable();
            lop_BUS = new clsLOP_BUS();
            namHoc_BUS = new clsNAMHOC_BUS();
            hocSinh_BUS = new clsHOCSINH_BUS();
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

        private void frmHocSinhTheoLop_Load(object sender, EventArgs e)
        {
            namHoc_BUS.hienThiComboBox(cboNamHoc);
           // sapXep();
            //btnDau.Enabled = false;
            //btnTruoc.Enabled = false;
        }

        private void cboNamHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            treLop.Nodes.Clear();
            lop_BUS.hienThiTreeLopTheoNamHoc(cboNamHoc.SelectedValue.ToString(), treLop);
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            if (treLop.SelectedNode == null)
            {
                MessageBox.Show("Bạn phải chon một lớp");
            }
            else
                bindingData();
            if (grdHocSinh.Rows.Count > 1)
            {
                foreach (DataGridViewRow row in grdHocSinh.Rows)
                {
                    if (row.Cells["MAHS"].Value != null)
                    {
                        char x = char.Parse(row.Cells["GIOITINHHS"].Value.ToString());
                        if (x == '0')
                        {
                            row.Cells["GIOITINHHS"].Value = "Nam";
                        }
                        else
                        {
                            row.Cells["GIOITINHHS"].Value = "Nữ";
                        }
                    }

                }
            }
        }

        private void bindingData()
        {
            //biding navigator
            bs = new BindingSource();
            bs.DataSource = hocSinh_BUS.danhSachHocSinhTheoLop(cboNamHoc, treLop);
            grdHocSinh.DataSource = bs;
            bnaDanhSach.BindingSource = bs;
        }
        //private void btnDau_Click(object sender, EventArgs e)
        //{
        //    viTri = this.BindingContext[grdHocSinh.DataSource].Position;
        //    this.BindingContext[grdHocSinh.DataSource].Position = 0;
        //    sapXep();
        //    btnTruoc.Enabled = false;
        //    btnDau.Enabled = false;
        //    btnCuoi.Enabled = true;
        //    btnSau.Enabled = true;
        //}

        //private void btnTruoc_Click(object sender, EventArgs e)
        //{
        //    viTri = this.BindingContext[grdHocSinh.DataSource].Position;
        //    btnCuoi.Enabled = true;
        //    btnSau.Enabled = true;
        //    this.BindingContext[grdHocSinh.DataSource].Position = viTri - 1;
        //    sapXep();
        //}

        //private void btnSau_Click(object sender, EventArgs e)
        //{
        //    viTri = this.BindingContext[grdHocSinh.DataSource].Position;
        //    btnDau.Enabled = true;
        //    btnTruoc.Enabled = true;
        //    this.BindingContext[grdHocSinh.DataSource].Position = viTri + 1;
        //    sapXep();
        //}

        //private void btnCuoi_Click(object sender, EventArgs e)
        //{
        //    viTri = this.BindingContext[grdHocSinh.DataSource].Position;
        //    this.BindingContext[grdHocSinh.DataSource].Position = this.BindingContext[grdHocSinh.DataSource].Count - 1;
        //    sapXep();
        //    btnCuoi.Enabled = false;
        //    btnSau.Enabled = false;
        //    btnTruoc.Enabled = true;
        //    btnDau.Enabled = true;
        //}

        //private void sapXep()
        //{
        //    viTri = this.BindingContext[grdHocSinh.DataSource].Position;
        //    Tong = this.BindingContext[grdHocSinh.DataSource].Count;
        //    if (viTri != -1)
        //    {
        //        txtHienTai.Text = "" + (viTri + 1).ToString() + "/" + Tong.ToString();
        //    }

        //}

        //private void grdHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    sapXep();
        //}

        private void frmHocSinhTheoLop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }


    }
}
