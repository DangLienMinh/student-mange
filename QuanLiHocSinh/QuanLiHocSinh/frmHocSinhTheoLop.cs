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

        private void frmHocSinhTheoLop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }


    }
}
