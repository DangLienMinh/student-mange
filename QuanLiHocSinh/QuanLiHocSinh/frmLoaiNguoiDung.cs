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
    public partial class frmLoaiNguoiDung : DevComponents.DotNetBar.Office2007Form
    {
        private clsLOAINGUOIDUNG_BUS loaiNguoiDung_BUS;
        private int flag;
        private BindingSource bs;

        public frmLoaiNguoiDung()
        {
            InitializeComponent();
            this.KeyPreview = true;
            datagridMakeUp(grdLoaiND);
            loaiNguoiDung_BUS = new clsLOAINGUOIDUNG_BUS();
            flag = 0;
        }

        private void frmLoaiNguoiDung_Load(object sender, EventArgs e)
        {
            //load danh sách loại người dùng vào grid loại người dùng
            bindingData();
            controlValue();
            FlagDisable();
            flag = 0;
        }

        private void bindingData()
        {
            //biding navigator
            bs = new BindingSource();
            bs.DataSource = loaiNguoiDung_BUS.hienThiDanhSach();
            grdLoaiND.DataSource = bs;
            bnaNguoiDung.BindingSource = bs;
        }

        //Trang trí datagrid như nền, canh chỉnh các hàng, ...
        private void datagridMakeUp(DataGridViewX temp)
        {
            temp.AutoResizeRows();
            temp.AllowUserToResizeColumns = true;
            temp.DefaultCellStyle.WrapMode = DataGridViewTriState.NotSet;
            temp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            temp.ReadOnly = true;
        }

        //bật cờ hiển thị button đồng ý và hủy, các button thêm, sửa, xóa bị mờ đi
        private void FlagEnable()
        {
            btnDongY.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        //tắt cờ hiển thị button đồng ý và hủy, các button thêm, sửa, xóa sáng lên
        private void FlagDisable()
        {
            btnDongY.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaLND.Focus();
            FlagEnable();
            flag = 1;
            resetAll();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            flag = 2;
            FlagEnable();
            txtMaLND.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 3;
            FlagEnable();
            txtMaLND.Enabled = false;
            txtTenLND.Focus();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (flag == 1) insert();
            if (flag == 2) delete();
            if (flag == 3) update();
            //sapXep();
            txtMaLND.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            FlagDisable();
            flag = 0;
            txtMaLND.Enabled = true;
        }

        private void resetAll()
        {
            txtMaLND.Text = "";
            txtTenLND.Text = "";
        }

        private void insert()
        {
            //cờ kiểm tra mã đã tồn tại trong CSSDL chưa
            int test = 1;

            if (string.IsNullOrEmpty(txtMaLND.Text) || string.IsNullOrEmpty(txtTenLND.Text))
            {
                MessageBox.Show("Xin điền dữ liệu vào đầy đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (DataGridViewRow row1 in grdLoaiND.Rows)
                {
                    if (row1.Cells["MALND"].Value != null)
                    {
                        //so sánh chuỗi trong textBox Mã loại người dùng với từng hàng trong datagrid loại người dùng, nếu giống nhau thì báo trùng
                        if (string.Compare(row1.Cells["MALND"].Value.ToString().Trim(), txtMaLND.Text.Trim()) == 0)
                        {
                            test = 0;
                            MessageBox.Show("Loại người dùng này đã có trong Cơ Sở Dữ Liệu!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                if (test == 1)
                {
                    try
                    {
                        loaiNguoiDung_BUS.themLoaiNguoiDung(txtMaLND.Text, txtTenLND.Text);
                        MessageBox.Show("Bạn đã thêm thành công!");
                        loaiNguoiDung_BUS.themDong();
                        FlagDisable();
                        flag = 0;

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Có lỗi trong quá trình chèn dữ liệu, xin thao tác lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }

            }
        }

        private void update()
        {
            if (grdLoaiND.SelectedRows.Count >= 1 && txtMaLND.Text != "")
            {
                loaiNguoiDung_BUS.suaLoaiNguoiDung(txtMaLND.Text, txtTenLND.Text);


                MessageBox.Show("Bạn đã sửa thành công!");

                //sửa trong datagridView
                loaiNguoiDung_BUS.suaDataGrid(grdLoaiND);
            }
            else
            {
                MessageBox.Show("Bạn phải lựa chọn một hàng để sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            FlagDisable();
            flag = 0;
        }

        private void delete()
        {
            if (grdLoaiND.SelectedRows.Count >= 1 && txtMaLND.Text != "")
            {

                loaiNguoiDung_BUS.xoaLoaiNguoiDung(txtMaLND.Text);
                foreach (DataGridViewRow row in grdLoaiND.Rows)
                {
                    if (string.Compare(row.Cells["MALND"].Value.ToString().Trim(), txtMaLND.Text.Trim()) == 0)
                    {
                        loaiNguoiDung_BUS.xoaDong(txtMaLND.Text);
                        resetAll();
                        FlagDisable();
                        flag = 0;
                        break;
                    }
                }

            }
            else
            {
                MessageBox.Show("Bạn phải lựa chọn một hàng để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void grdLoaiND_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLND.Text = grdLoaiND.CurrentRow.Cells["MALND"].Value.ToString();
            txtTenLND.Text = grdLoaiND.CurrentRow.Cells["TENLND"].Value.ToString();
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Yellow;
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            txtMaLND.BackColor = Color.White;
            txtTenLND.BackColor = Color.White;
        }

        private void frmLoaiNguoiDung_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa loại người dùng đã được lựa chọn ", "Xóa loại người dùng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                delete();
            }
        }

        private void move_Click(object sender, EventArgs e)
        {
            controlValue();
        }

        private void controlValue()
        {
            if (grdLoaiND.CurrentRow.Cells["MALND"].Value!=null)
            {
                txtMaLND.Text = grdLoaiND.CurrentRow.Cells["MALND"].Value.ToString();
                txtTenLND.Text = grdLoaiND.CurrentRow.Cells["TENLND"].Value.ToString();
            }
           
        }


    }
}
