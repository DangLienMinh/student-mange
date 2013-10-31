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
    public partial class frmMonHoc : DevComponents.DotNetBar.Office2007Form
    {
        private clsMONHOC_BUS monHoc_BUS;
        private int flag;
        private int viTri, Tong;

        public frmMonHoc()
        {
            InitializeComponent();
            this.KeyPreview = true;
            datagridMakeUp(grdMonHoc);
            monHoc_BUS = new clsMONHOC_BUS();
            flag = 0;
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

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            //load danh sách môn học vào datagrid môn học
            monHoc_BUS.hienThiDanhSach(grdMonHoc);
            //load dữ liệu vào comboBox hê số
            monHoc_BUS.hienThiComboBox(cboHeSo);
            FlagDisable();
            flag = 0;
            sapXep();
            btnDau.Enabled = false;
            btnTruoc.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaMH.Focus();
            FlagEnable();
            flag = 1;
            resetAll();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            flag = 2;
            FlagEnable();
            txtMaMH.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 3;
            FlagEnable();
            txtMaMH.Enabled = false;
            txtTenMH.Focus();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (flag == 1) insert();
            if (flag == 2) delete();
            if (flag == 3) update();
            sapXep();
            txtMaMH.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            FlagDisable();
            flag = 0;
            txtMaMH.Enabled = true;
        }

        private void resetAll()
        {
            txtMaMH.Text = "";
            txtTenMH.Text = "";
            txtSoTiet.Text = "";
        }

        private void sapXep()
        {
            viTri = this.BindingContext[grdMonHoc.DataSource].Position;
            Tong = this.BindingContext[grdMonHoc.DataSource].Count;
            if (viTri!=-1)
            {
                txtHienTai.Text = "" + (viTri + 1).ToString() + "/" + Tong.ToString();
                txtMaMH.Text = grdMonHoc.Rows[viTri].Cells["MAMH"].Value.ToString();
                txtTenMH.Text = grdMonHoc.Rows[viTri].Cells["TENMH"].Value.ToString();
                txtSoTiet.Text = grdMonHoc.Rows[viTri].Cells["SOTIET"].Value.ToString();
                cboHeSo.SelectedItem = grdMonHoc.Rows[viTri].Cells["HESOMH"].Value.ToString(); 
            }
            
        }

        private void insert()
        {
            //cờ kiểm tra mã đã tồn tại trong CSSDL chưa
            int test = 1;

            if (string.IsNullOrEmpty(txtMaMH.Text) || string.IsNullOrEmpty(txtTenMH.Text) || string.IsNullOrEmpty(txtSoTiet.Text))
            {
                MessageBox.Show("Xin điền dữ liệu vào đầy đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (DataGridViewRow row1 in grdMonHoc.Rows)
                {
                    if (row1.Cells["MAMH"].Value != null)
                    {
                        //compare the text in txtMADG with each MADG row in datagrid Docgia, if it appear then let user know
                        if (string.Compare(row1.Cells["MAMH"].Value.ToString().Trim(), txtMaMH.Text.Trim()) == 0)
                        {
                            test = 0;
                            MessageBox.Show("Môn học này đã có trong Cơ Sở Dữ Liệu!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                if (test == 1)
                {
                    try
                    {
                        monHoc_BUS.themMonHoc(txtMaMH.Text, txtTenMH.Text,txtSoTiet.Text,cboHeSo.SelectedItem.ToString());
                        MessageBox.Show("Bạn đã thêm thành công!");
                        monHoc_BUS.themDong();
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
            if (grdMonHoc.SelectedRows.Count >= 1 && txtMaMH.Text != "")
            {    
                monHoc_BUS.suaMonHoc(txtMaMH.Text, txtTenMH.Text, txtSoTiet.Text,cboHeSo.SelectedItem.ToString());


                MessageBox.Show("Bạn đã sửa thành công!");

                //sửa trong datagrid view
                monHoc_BUS.suaDataGrid(grdMonHoc);
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
            if (grdMonHoc.SelectedRows.Count >= 1 && txtMaMH.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa môn học đã được lựa chọn ", "Xóa môn học", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    monHoc_BUS.xoaMonHoc(txtMaMH.Text);
                    foreach (DataGridViewRow row in grdMonHoc.Rows)
                    {
                        if (string.Compare(row.Cells["MAMH"].Value.ToString().Trim(), txtMaMH.Text.Trim()) == 0)
                        {
                            monHoc_BUS.xoaDong(grdMonHoc, txtMaMH.Text);
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
            viTri = this.BindingContext[grdMonHoc.DataSource].Position;
            this.BindingContext[grdMonHoc.DataSource].Position = 0;
            sapXep();
            btnTruoc.Enabled = false;
            btnDau.Enabled = false;
            btnCuoi.Enabled = true;
            btnSau.Enabled = true;
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            viTri = this.BindingContext[grdMonHoc.DataSource].Position;
            btnCuoi.Enabled = true;
            btnSau.Enabled = true;
            this.BindingContext[grdMonHoc.DataSource].Position = viTri - 1;
            sapXep();
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            viTri = this.BindingContext[grdMonHoc.DataSource].Position;
            btnDau.Enabled = true;
            btnTruoc.Enabled = true;
            this.BindingContext[grdMonHoc.DataSource].Position = viTri + 1;
            sapXep();
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            viTri = this.BindingContext[grdMonHoc.DataSource].Position;
            this.BindingContext[grdMonHoc.DataSource].Position = this.BindingContext[grdMonHoc.DataSource].Count - 1;
            sapXep();
            btnCuoi.Enabled = false;
            btnSau.Enabled = false;
            btnTruoc.Enabled = true;
            btnDau.Enabled = true;
        }

        private void grdMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMH.Text = grdMonHoc.CurrentRow.Cells["MAMH"].Value.ToString();
            txtTenMH.Text = grdMonHoc.CurrentRow.Cells["TENMH"].Value.ToString();
            txtSoTiet.Text = grdMonHoc.CurrentRow.Cells["SOTIET"].Value.ToString();
            cboHeSo.SelectedItem = grdMonHoc.CurrentRow.Cells["HESOMH"].Value.ToString();
            sapXep();        
        }

        private void txtSoTiet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
            if (!char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("Chỉ nhập số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Yellow;
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            txtMaMH.BackColor = Color.White;
            txtTenMH.BackColor = Color.White;
            txtSoTiet.BackColor = Color.White;
        }

        private void frmMonHoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
