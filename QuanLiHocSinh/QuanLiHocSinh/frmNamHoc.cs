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
    public partial class frmNamHoc : DevComponents.DotNetBar.Office2007Form
    {
        private clsNAMHOC_BUS namHoc_BUS = new clsNAMHOC_BUS();
        private clsHOCKY_BUS hocKy_BUS = new clsHOCKY_BUS();
        private int flag = 0;
        private int flag1=0;
        private int viTri, Tong;
        private int viTri1, Tong1;

        public frmNamHoc()
        {
            InitializeComponent();
            this.KeyPreview = true;
            datagridMakeUp(grdNamHoc);
            datagridMakeUp(grdHocKy);
        }

        private void datagridMakeUp(DataGridViewX temp)
        {
            temp.AutoResizeRows();
            temp.AllowUserToResizeColumns = true;
            temp.DefaultCellStyle.WrapMode = DataGridViewTriState.NotSet;
            temp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            temp.ReadOnly = true;
        }

        private void frmNamHoc_Load(object sender, EventArgs e)
        {
            txtMaNH.Text = "NH" + DateTime.Now.ToString("yy") + DateTime.Now.AddYears(1).ToString("yy");
            namHoc_BUS.hienThiDanhSach(grdNamHoc);
            hocKy_BUS.hienThiDanhSach(grdHocKy);
            hocKy_BUS.hienThiComboBox(cbHeSoHK);
            FlagDisable();
            FlagDisable1();
            sapXep();
            sapXep1();
            btnFirst.Enabled = false;
            btnPrev.Enabled = false;
            btnDau.Enabled = false;
            btnTruoc.Enabled = false;
        }

        private void FlagEnable()
        {
            btnAccept.Enabled = true;
            btnCancel.Enabled = true;
            btnAdd.Enabled = false;
            btnChange.Enabled = false;
        }

        private void FlagEnable1()
        {
            btnDongY.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void FlagDisable()
        {
            btnAccept.Enabled = false;
            btnCancel.Enabled = false;
            btnAdd.Enabled = true;
            btnChange.Enabled = true;
        }

        private void FlagDisable1()
        {
            btnDongY.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtTenNH.Focus();
            FlagEnable();
            flag = 1;
            resetAll();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            flag = 3;
            FlagEnable();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (flag == 1) insert();
            if (flag == 3) update();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FlagDisable();
            flag = 0;
        }

        private void resetAll()
        {
            txtTenNH.Text = "";
        }

        private void resetAll1()
        {
           txtMaHK.Text="";
            txtTenHK.Text="";
        }
        
        private void insert()
        {
            //cờ kiểm tra mã đã tồn tại trong CSSDL chưa
            int test = 1;

            if (string.IsNullOrEmpty(txtTenNH.Text))
            {
                MessageBox.Show("Xin điền dữ liệu vào đầy đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (DataGridViewRow row1 in grdNamHoc.Rows)
                {
                    if (row1.Cells["MANH"].Value != null)
                    {
                        //compare the text in txtMADG with each MADG row in datagrid Docgia, if it appear then let user know
                        if (string.Compare(row1.Cells["MANH"].Value.ToString().Trim(), txtMaNH.Text.Trim()) == 0)
                        {
                            test = 0;
                            MessageBox.Show("Năm học này đã có trong Cơ Sở Dữ Liệu!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                if (test==1)
                {
                    try
                    {
                        namHoc_BUS.themNamHoc(txtMaNH.Text, txtTenNH.Text);
                        MessageBox.Show("Bạn đã thêm thành công!");
                        namHoc_BUS.themDong();
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
            if (grdNamHoc.SelectedRows.Count >= 1 && txtMaNH.Text != "")
            {
                namHoc_BUS.suaNamHoc(txtMaNH.Text, txtTenNH.Text);
                MessageBox.Show("Bạn đã sửa thành công!");

                //sửa trong datagrid view
                namHoc_BUS.suaDataGrid(grdNamHoc);

                FlagDisable();
                flag = 0;

            }
            else
            {
                MessageBox.Show("Bạn phải lựa chọn một hàng để sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void sapXep()
        {
            viTri = this.BindingContext[grdNamHoc.DataSource].Position;
            Tong = this.BindingContext[grdNamHoc.DataSource].Count;
            if (viTri==-1)
            {
                viTri = 0;
            }
            else
            {
                txtCurrent.Text = "" + (viTri + 1).ToString() + "/" + Tong.ToString();
                txtMaNH.Text = grdNamHoc.Rows[viTri].Cells["MANH"].Value.ToString();
                txtTenNH.Text = grdNamHoc.Rows[viTri].Cells["TENNH"].Value.ToString();
            }
            
            
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            viTri = this.BindingContext[grdNamHoc.DataSource].Position;
            btnLast.Enabled = true;
            btnNext.Enabled = true;
            this.BindingContext[grdNamHoc.DataSource].Position = viTri - 1;
            sapXep();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            viTri = this.BindingContext[grdNamHoc.DataSource].Position;
            btnFirst.Enabled = true;
            btnPrev.Enabled = true;
            this.BindingContext[grdNamHoc.DataSource].Position = viTri + 1;
            sapXep();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            viTri = this.BindingContext[grdNamHoc.DataSource].Position;
            this.BindingContext[grdNamHoc.DataSource].Position = 0;
            sapXep();
            btnPrev.Enabled = false;
            btnFirst.Enabled = false;
            btnLast.Enabled = true;
            btnNext.Enabled = true;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            viTri = this.BindingContext[grdNamHoc.DataSource].Position;
            this.BindingContext[grdNamHoc.DataSource].Position = this.BindingContext[grdNamHoc.DataSource].Count - 1;
            sapXep();
            btnLast.Enabled = false;
            btnNext.Enabled = false;
            btnPrev.Enabled = true;
            btnFirst.Enabled = true;
        }

        /*BAT DAU TAB HOC KY*/

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaHK.Focus();
            FlagEnable1();
            flag1 = 1;
            resetAll1();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            flag1 = 2;
            FlagEnable1();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag1 = 3;
            FlagEnable1();
            txtMaHK.Enabled = false;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (flag1 == 1) them();
            if (flag1 == 2) xoa();
            if (flag1 == 3) sua();
            txtMaHK.Enabled = true;
        }

        private void them()
        {
            //cờ kiểm tra mã đã tồn tại trong CSSDL chưa
            int test = 1;

            if (string.IsNullOrEmpty(txtMaHK.Text) || string.IsNullOrEmpty(txtTenHK.Text))
            {
                MessageBox.Show("Xin điền dữ liệu vào đầy đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (DataGridViewRow row1 in grdHocKy.Rows)
                {
                    if (row1.Cells["MAHK"].Value != null)
                    {
                        //compare the text in txtMADG with each MADG row in datagrid Docgia, if it appear then let user know
                        if (string.Compare(row1.Cells["MAHK"].Value.ToString().Trim(), txtMaHK.Text.Trim()) == 0)
                        {
                            test = 0;
                            MessageBox.Show("Học kỳ này đã có trong Cơ Sở Dữ Liệu!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                if (test == 1)
                {
                    try
                    {
                        hocKy_BUS.themHocKy(txtMaHK.Text, txtTenHK.Text,cbHeSoHK.SelectedItem.ToString());
                        MessageBox.Show("Bạn đã thêm thành công!");
                        hocKy_BUS.themDong();
                        FlagDisable1();
                        flag1 = 0;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Có lỗi trong quá trình chèn dữ liệu, xin thao tác lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
            }
        }

        private void sua()
        {
            if (grdHocKy.SelectedRows.Count >= 1 && txtMaHK.Text != "")
            {
                hocKy_BUS.suaHocKy(txtMaHK.Text, txtTenHK.Text,cbHeSoHK.SelectedItem.ToString());
                MessageBox.Show("Bạn đã sửa thành công!");

                //sửa trong datagrid view
                hocKy_BUS.suaDataGrid(grdHocKy);

                FlagDisable1();
                flag1 = 0;

            }
            else
            {
                MessageBox.Show("Bạn phải lựa chọn một hàng để sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void xoa()
        {
            if (grdHocKy.SelectedRows.Count >= 1 && txtMaHK.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa học kỳ đã được lựa chọn ", "Xóa học kỳ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    hocKy_BUS.xoaHocKy(txtMaHK.Text);
                    foreach (DataGridViewRow row in grdHocKy.Rows)
                    {
                        if (string.Compare(row.Cells["MAHK"].Value.ToString().Trim(), txtMaHK.Text.Trim()) == 0)
                        {


                            hocKy_BUS.xoaDong(grdHocKy, txtMaHK.Text);
                            resetAll1();
                            FlagDisable1();
                            flag1 = 0;
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            FlagDisable1();
            flag1 = 0;
            txtMaHK.Enabled = true;
        }

        private void sapXep1()
        {
            viTri1 = this.BindingContext[grdHocKy.DataSource].Position;
            Tong1 = this.BindingContext[grdHocKy.DataSource].Count;
            if (viTri1 == -1)
            {
                viTri1 = 0;
            }
            else
            {
                txtHienTai.Text = "" + (viTri1 + 1).ToString() + "/" + Tong1.ToString();
                txtMaHK.Text = grdHocKy.Rows[viTri1].Cells["MAHK"].Value.ToString();
                txtTenHK.Text = grdHocKy.Rows[viTri1].Cells["TENHK"].Value.ToString();
                cbHeSoHK.SelectedItem = grdHocKy.Rows[viTri1].Cells["HESOHK"].Value.ToString();
            }

           
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            viTri1 = this.BindingContext[grdHocKy.DataSource].Position;
            this.BindingContext[grdHocKy.DataSource].Position = 0;
            sapXep1();
            btnTruoc.Enabled = false;
            btnDau.Enabled = false;
            btnCuoi.Enabled = true;
            btnSau.Enabled = true;
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            viTri1 = this.BindingContext[grdHocKy.DataSource].Position;
            this.BindingContext[grdHocKy.DataSource].Position = this.BindingContext[grdNamHoc.DataSource].Count - 1;
            sapXep1();
            btnCuoi.Enabled = false;
            btnSau.Enabled = false;
            btnTruoc.Enabled = true;
            btnDau.Enabled = true;
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            viTri1 = this.BindingContext[grdHocKy.DataSource].Position;
            btnCuoi.Enabled = true;
            btnSau.Enabled = true;
            this.BindingContext[grdHocKy.DataSource].Position = viTri1 - 1;
            sapXep1();
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            viTri1 = this.BindingContext[grdHocKy.DataSource].Position;
            btnTruoc.Enabled = true;
            btnPrev.Enabled = true;
            this.BindingContext[grdHocKy.DataSource].Position = viTri1 + 1;
            sapXep1();
        }

        private void grdHocKy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHK.Text = grdHocKy.CurrentRow.Cells["MAHK"].Value.ToString();
            txtTenHK.Text = grdHocKy.CurrentRow.Cells["TENHK"].Value.ToString();
            cbHeSoHK.SelectedItem = grdHocKy.CurrentRow.Cells["HESOHK"].Value.ToString();
           
            sapXep1();       
        }

        private void grdNamHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNH.Text = grdHocKy.CurrentRow.Cells["MANH"].Value.ToString();
            txtTenNH.Text = grdHocKy.CurrentRow.Cells["TENNH"].Value.ToString();

            sapXep();       
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Yellow;
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            txtMaHK.BackColor = Color.White;
            txtTenHK.BackColor = Color.White;
            txtTenNH.BackColor = Color.White;
        }

    }
}
