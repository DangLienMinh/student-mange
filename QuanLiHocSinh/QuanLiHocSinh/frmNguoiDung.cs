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
        private BindingSource bs;

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
            bindingData();
            nguoiDung_BUS.hienThiComboBox(cboLoaiND);
            FlagDisable();
            flag = 0;
        }

        private void bindingData()
        {
            //biding navigator
            bs = new BindingSource();
            bs.DataSource = nguoiDung_BUS.hienThiDanhSach();
            grdNguoiDung.DataSource = bs;
            bnaNguoiDung.BindingSource = bs;
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
            txtTenND.Focus();
            FlagEnable();
            flag = 1;
            resetAll();
            //tạo mã người dùng
            txtMaND.Text = "ND" + nguoiDung_BUS.hienThiSoNguoi().ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            flag = 2;
            FlagEnable();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 3;
            FlagEnable();
            txtTenND.Focus();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (flag == 1) insert();
            if (flag == 2) delete();
            if (flag == 3) update();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            FlagDisable();
            flag = 0;  
        }

        private void resetAll()
        {
            txtMaND.Text = "";
            txtTenND.Text = "";
            txtTenDN.Text = "";
            txtMatKhau.Text = "";
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
                        nguoiDung_BUS.themNguoiDung(txtMaND.Text, txtTenND.Text,cboLoaiND.SelectedValue.ToString(), txtTenDN.Text,txtMatKhau.Text );
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
                nguoiDung_BUS.suaNguoiDung(txtMaND.Text, txtTenND.Text, cboLoaiND.SelectedValue.ToString(), txtTenDN.Text, txtMatKhau.Text);


                MessageBox.Show("Bạn đã sửa thành công!");

                //sửa trong datagrid view
                nguoiDung_BUS.suaDataGrid();
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
            else
            {
                MessageBox.Show("Bạn phải lựa chọn một hàng để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void grdNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            controlValue();
            FlagDisable();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa người dùng đã được lựa chọn ", "Xóa người dùng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                delete();
            }
        }

        private void move_Click(object sender, EventArgs e)
        {
            controlValue();
        }

        //thay đổi thông tin trên grid
        private void controlValue()
        {
            if (grdNguoiDung.CurrentRow.Cells["MAND"].Value!=null)
            {
                txtMaND.Text = grdNguoiDung.CurrentRow.Cells["MAND"].Value.ToString();
                txtTenND.Text = grdNguoiDung.CurrentRow.Cells["TENND"].Value.ToString();
                txtTenDN.Text = grdNguoiDung.CurrentRow.Cells["TENDN"].Value.ToString();
                txtMatKhau.Text = grdNguoiDung.CurrentRow.Cells["MATKHAU"].Value.ToString();
                cboLoaiND.SelectedValue = grdNguoiDung.CurrentRow.Cells["MALND"].Value.ToString();
            }           
        }
    }
}
