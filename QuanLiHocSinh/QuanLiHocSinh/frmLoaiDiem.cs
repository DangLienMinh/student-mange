using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLHS.BUS;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;

namespace QuanLiHocSinh
{
    public partial class frmLoaiDiem : DevComponents.DotNetBar.Office2007Form
    {
        private clsLOAIDIEM_BUS loaiDiem_BUS;
        private int flag;
        private int viTri, Tong;

        public frmLoaiDiem()
        {
            InitializeComponent();
            this.KeyPreview = true;
            datagridMakeUp(grdLoaiDiem);
            loaiDiem_BUS = new clsLOAIDIEM_BUS();
            flag = 0;
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

        private void frmLoaiDiem_Load(object sender, EventArgs e)
        {
            loaiDiem_BUS.hienThiDanhSach(grdLoaiDiem);
            loaiDiem_BUS.hienThiComboBox(cbHeSo);
            FlagDisable();
            flag = 0;
            sapXep();
            btnDau.Enabled = false;
            btnTruoc.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaLD.Focus();
            FlagEnable();
            flag = 1;
            resetAll();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            flag = 2;
            FlagEnable();
            txtMaLD.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 3;
            FlagEnable();
            txtMaLD.Enabled = false;
            txtTenLD.Focus();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (flag == 1) insert();
            if (flag == 2) delete();
            if (flag == 3) update();
            sapXep();
            txtMaLD.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            FlagDisable();
            flag = 0;
            txtMaLD.Enabled = true;
        }

        private void resetAll()
        {
            txtMaLD.Text = "";
            txtTenLD.Text = "";
        }

        private void sapXep()
        {
            viTri = this.BindingContext[grdLoaiDiem.DataSource].Position;
            Tong = this.BindingContext[grdLoaiDiem.DataSource].Count;
            if (viTri != -1)
            {
                txtHienTai.Text = "" + (viTri + 1).ToString() + "/" + Tong.ToString();
                txtMaLD.Text = grdLoaiDiem.Rows[viTri].Cells["MALD"].Value.ToString();
                txtTenLD.Text = grdLoaiDiem.Rows[viTri].Cells["TENLD"].Value.ToString();
                cbHeSo.SelectedItem = grdLoaiDiem.Rows[viTri].Cells["HESOLD"].Value.ToString();
            }

        }

        private void insert()
        {
            //cờ kiểm tra mã đã tồn tại trong CSSDL chưa
            int test = 1;

            if (string.IsNullOrEmpty(txtMaLD.Text) || string.IsNullOrEmpty(txtTenLD.Text))
            {
                MessageBox.Show("Xin điền dữ liệu vào đầy đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (DataGridViewRow row1 in grdLoaiDiem.Rows)
                {
                    if (row1.Cells["MALD"].Value != null)
                    {
                        //compare the text in txtMADG with each MADG row in datagrid Docgia, if it appear then let user know
                        if (string.Compare(row1.Cells["MALD"].Value.ToString().Trim(), txtMaLD.Text.Trim()) == 0)
                        {
                            test = 0;
                            MessageBox.Show("loại điểm này đã có trong Cơ Sở Dữ Liệu!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                if (test == 1)
                {
                    try
                    {
                        loaiDiem_BUS.themLoaiDiem(txtMaLD.Text, txtTenLD.Text,cbHeSo.SelectedItem.ToString());
                        MessageBox.Show("Bạn đã thêm thành công!");
                        loaiDiem_BUS.themDong();
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
            if (grdLoaiDiem.SelectedRows.Count >= 1 && txtMaLD.Text != "")
            {
                loaiDiem_BUS.suaLoaiDiem(txtMaLD.Text, txtTenLD.Text, cbHeSo.SelectedItem.ToString());


                MessageBox.Show("Bạn đã sửa thành công!");

                //sửa trong datagrid view
                loaiDiem_BUS.suaDataGrid(grdLoaiDiem);
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
            if (grdLoaiDiem.SelectedRows.Count >= 1 && txtMaLD.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa loại điểm đã được lựa chọn ", "Xóa giáo viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    loaiDiem_BUS.xoaLoaiDiem(txtMaLD.Text);
                    foreach (DataGridViewRow row in grdLoaiDiem.Rows)
                    {
                        if (string.Compare(row.Cells["MALD"].Value.ToString().Trim(), txtMaLD.Text.Trim()) == 0)
                        {
                            loaiDiem_BUS.xoaDong(grdLoaiDiem, txtMaLD.Text);
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
            viTri = this.BindingContext[grdLoaiDiem.DataSource].Position;
            this.BindingContext[grdLoaiDiem.DataSource].Position = 0;
            sapXep();
            btnTruoc.Enabled = false;
            btnDau.Enabled = false;
            btnCuoi.Enabled = true;
            btnSau.Enabled = true;
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            viTri = this.BindingContext[grdLoaiDiem.DataSource].Position;
            btnCuoi.Enabled = true;
            btnSau.Enabled = true;
            this.BindingContext[grdLoaiDiem.DataSource].Position = viTri - 1;
            sapXep();
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            viTri = this.BindingContext[grdLoaiDiem.DataSource].Position;
            btnDau.Enabled = true;
            btnTruoc.Enabled = true;
            this.BindingContext[grdLoaiDiem.DataSource].Position = viTri + 1;
            sapXep();
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            viTri = this.BindingContext[grdLoaiDiem.DataSource].Position;
            this.BindingContext[grdLoaiDiem.DataSource].Position = this.BindingContext[grdLoaiDiem.DataSource].Count - 1;
            sapXep();
            btnCuoi.Enabled = false;
            btnSau.Enabled = false;
            btnTruoc.Enabled = true;
            btnDau.Enabled = true;
        }

        private void frmLoaiDiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void grdMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLD.Text = grdLoaiDiem.CurrentRow.Cells["MALD"].Value.ToString();
            txtTenLD.Text = grdLoaiDiem.CurrentRow.Cells["TENLD"].Value.ToString();
            cbHeSo.SelectedItem = grdLoaiDiem.CurrentRow.Cells["HESOLD"].Value.ToString();
            sapXep();      
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Yellow;
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            txtMaLD.BackColor = Color.White;
            txtTenLD.BackColor = Color.White;
        }
    }
}
