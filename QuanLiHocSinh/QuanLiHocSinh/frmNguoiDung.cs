using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLHS.BUS;
using System.IO;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;

namespace QuanLiHocSinh
{
    public partial class frmNguoiDung : DevComponents.DotNetBar.Office2007Form
    {
        private clsNGUOIDUNG_BUS nguoiDung_BUS;
        private int flag = 0;
        private int viTri, Tong;

        public frmNguoiDung()
        {
            InitializeComponent();
            this.KeyPreview = true;
            datagridMakeUp(grdNguoiDung);
            nguoiDung_BUS = new clsNGUOIDUNG_BUS();
            flag = 0;
        }

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            nguoiDung_BUS.hienThiDanhSach(grdNguoiDung);
            nguoiDung_BUS.hienThiComboBox(cbLoaiND);
            FlagDisable();
            flag = 0;
            sapXep();
            btnDau.Enabled = false;
            btnTruoc.Enabled = false;
        }

        private void datagridMakeUp(DataGridViewX temp)
        {
            temp.AutoResizeRows();
            temp.AllowUserToResizeColumns = true;
            temp.DefaultCellStyle.WrapMode = DataGridViewTriState.NotSet;
            temp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            temp.ReadOnly = true;
        }

        private void FlagEnable()
        {
            btnDongY.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

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
            txtMaND.Focus();
            FlagEnable();
            flag = 1;
            resetAll();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            flag = 2;
            FlagEnable();
            txtMaND.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 3;
            FlagEnable();
            txtMaND.Enabled = false;
            txtTenND.Focus();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (flag == 1) insert();
            if (flag == 2) delete();
            if (flag == 3) update();
            sapXep();
            txtMaND.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            FlagDisable();
            flag = 0;
            txtMaND.Enabled = true;
        
        }

        private void resetAll()
        {
            txtMaND.Text = "";
            txtTenND.Text = "";
            txtTenDN.Text = "";
            txtMatKhau.Text = "";
        }

        private void sapXep()
        {
            viTri = this.BindingContext[grdNguoiDung.DataSource].Position;
            Tong = this.BindingContext[grdNguoiDung.DataSource].Count;
            if (viTri != -1)
            {
                txtHienTai.Text = "" + (viTri + 1).ToString() + "/" + Tong.ToString();
                txtMaND.Text = grdNguoiDung.Rows[viTri].Cells["MAND"].Value.ToString();
                txtTenND.Text = grdNguoiDung.Rows[viTri].Cells["TENND"].Value.ToString();
                txtTenDN.Text = grdNguoiDung.Rows[viTri].Cells["TENDN"].Value.ToString();
                txtMatKhau.Text = grdNguoiDung.Rows[viTri].Cells["MATKHAU"].Value.ToString();
                cbLoaiND.SelectedValue = grdNguoiDung.Rows[viTri].Cells["MALND"].Value.ToString();
            }

        }

        private void insert()
        {
            //cờ kiểm tra mã đã tồn tại trong CSSDL chưa
            int test = 1;

            if (string.IsNullOrEmpty(txtMaND.Text) || string.IsNullOrEmpty(txtTenND.Text) || string.IsNullOrEmpty(txtTenDN.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Xin điền dữ liệu vào đầy đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //else if (string.Compare(txtMatKhau.Text,txtNhapLai.Text)!=0)
            //{
            //    MessageBox.Show("Mật khẩu không trùng khớp ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            else
            {
                foreach (DataGridViewRow row1 in grdNguoiDung.Rows)
                {
                    if (row1.Cells["MAND"].Value != null)
                    {
                        //compare the text in txtMADG with each MADG row in datagrid Docgia, if it appear then let user know
                        if (string.Compare(row1.Cells["MAND"].Value.ToString().Trim(), txtMaND.Text.Trim()) == 0)
                        {
                            test = 0;
                            MessageBox.Show("Người dùng này đã có trong Cơ Sở Dữ Liệu!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                if (test == 1)
                {
                    try
                    {
                        nguoiDung_BUS.themNguoiDung(txtMaND.Text, txtTenND.Text,cbLoaiND.SelectedValue.ToString(), txtTenDN.Text,txtMatKhau.Text );
                        MessageBox.Show("Bạn đã thêm thành công!");
                        nguoiDung_BUS.themDong();
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
            if (grdNguoiDung.SelectedRows.Count >= 1 && txtMaND.Text != "")
            {
                nguoiDung_BUS.suaNguoiDung(txtMaND.Text, txtTenND.Text, cbLoaiND.SelectedValue.ToString(), txtTenDN.Text, txtMatKhau.Text);


                MessageBox.Show("Bạn đã sửa thành công!");

                //sửa trong datagrid view
                nguoiDung_BUS.suaDataGrid(grdNguoiDung);
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
            if (grdNguoiDung.SelectedRows.Count >= 1 && txtMaND.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa người dùng đã được lựa chọn ", "Xóa người dùng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    nguoiDung_BUS.xoaNguoiDung(txtMaND.Text);
                    foreach (DataGridViewRow row in grdNguoiDung.Rows)
                    {
                        if (string.Compare(row.Cells["MAND"].Value.ToString().Trim(), txtMaND.Text.Trim()) == 0)
                        {
                            nguoiDung_BUS.xoaDong(grdNguoiDung, txtMaND.Text);
                            resetAll();
                            FlagDisable();
                            flag = 0;
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn phải lựa chọn một hàng để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnDau_Click(object sender, EventArgs e)
        {
            viTri = this.BindingContext[grdNguoiDung.DataSource].Position;
            this.BindingContext[grdNguoiDung.DataSource].Position = 0;
            sapXep();
            btnTruoc.Enabled = false;
            btnDau.Enabled = false;
            btnCuoi.Enabled = true;
            btnSau.Enabled = true;
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            viTri = this.BindingContext[grdNguoiDung.DataSource].Position;
            btnCuoi.Enabled = true;
            btnSau.Enabled = true;
            this.BindingContext[grdNguoiDung.DataSource].Position = viTri - 1;
            sapXep();
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            viTri = this.BindingContext[grdNguoiDung.DataSource].Position;
            btnDau.Enabled = true;
            btnTruoc.Enabled = true;
            this.BindingContext[grdNguoiDung.DataSource].Position = viTri + 1;
            sapXep();
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            viTri = this.BindingContext[grdNguoiDung.DataSource].Position;
            this.BindingContext[grdNguoiDung.DataSource].Position = this.BindingContext[grdNguoiDung.DataSource].Count - 1;
            sapXep();
            btnCuoi.Enabled = false;
            btnSau.Enabled = false;
            btnTruoc.Enabled = true;
            btnDau.Enabled = true;
        }

        private void grdNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaND.Text = grdNguoiDung.CurrentRow.Cells["MAND"].Value.ToString();
            txtTenND.Text = grdNguoiDung.CurrentRow.Cells["TENND"].Value.ToString();
            txtTenDN.Text = grdNguoiDung.CurrentRow.Cells["TENDN"].Value.ToString();
            txtMatKhau.Text = grdNguoiDung.CurrentRow.Cells["MATKHAU"].Value.ToString();
            cbLoaiND.SelectedValue = grdNguoiDung.CurrentRow.Cells["MALND"].Value.ToString();
            
            sapXep();     
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Yellow;
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            txtMaND.BackColor = Color.White;
            txtTenND.BackColor = Color.White;
            txtTenDN.BackColor = Color.White;
            txtMatKhau.BackColor = Color.White;
        }

        private void frmNguoiDung_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnLND_Click(object sender, EventArgs e)
        {
            frmLoaiNguoiDung m_FrmLND = null;
            if (m_FrmLND == null || m_FrmLND.IsDisposed)
            {
                m_FrmLND = new frmLoaiNguoiDung();
                m_FrmLND.FormBorderStyle = FormBorderStyle.None;
                m_FrmLND.MdiParent = frmMain.ActiveForm;
                m_FrmLND.Show();
            }
            else
                m_FrmLND.Activate();
            
        }




    }
}
