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
        private clsNAMHOC_BUS namHoc_BUS;
        private int flag = 0;
        private BindingSource bs;
        public frmNamHoc()
        {
            InitializeComponent();
            this.KeyPreview = true;
            namHoc_BUS = new clsNAMHOC_BUS();
            datagridMakeUp(grdNamHoc);
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

        private void frmNamHoc_Load(object sender, EventArgs e)
        {

            //tạo mã năm học
            txtMaNH.Text = "NH" + DateTime.Now.ToString("yy") + DateTime.Now.AddYears(1).ToString("yy");
            bindingData();
            FlagDisable();
        }

        private void bindingData()
        {
            //biding navigator
            bs = new BindingSource();
            bs.DataSource = namHoc_BUS.hienThiDanhSach();
            grdNamHoc.DataSource = bs;
            bnaNamHoc.BindingSource = bs;
        }

        //bật cờ hiển thị button đồng ý và hủy, các button thêm, sửa, xóa bị mờ đi
        private void FlagEnable()
        {
            btnAccept.Enabled = true;
            btnCancel.Enabled = true;
            btnAdd.Enabled = false;
            btnChange.Enabled = false;
        }

        //tắt cờ hiển thị button đồng ý và hủy, các button thêm, sửa, xóa sáng lên
        private void FlagDisable()
        {
            btnAccept.Enabled = false;
            btnCancel.Enabled = false;
            btnAdd.Enabled = true;
            btnChange.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //tạo mã năm học
            txtMaNH.Text = "NH" + DateTime.Now.ToString("yy") + DateTime.Now.AddYears(1).ToString("yy");
            txtTenNH.Focus();
            FlagEnable();
            flag = 1;
            resetAll();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            flag = 3;
            FlagEnable();
            txtTenNH.Focus();
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
                namHoc_BUS.suaDataGrid();
            }
            else
            {
                MessageBox.Show("Bạn phải lựa chọn một hàng để sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            FlagDisable();
            flag = 0;
        }


        private void grdNamHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            controlValue();
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Yellow;
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            txtTenNH.BackColor = Color.White;
        }

        private void frmNamHoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void move_Click(object sender, EventArgs e)
        {
            controlValue();
        }

        private void controlValue()
        {
            if (grdNamHoc.CurrentRow.Cells["MANH"].Value!=null)
            {
                txtMaNH.Text = grdNamHoc.CurrentRow.Cells["MANH"].Value.ToString();
                txtTenNH.Text = grdNamHoc.CurrentRow.Cells["TENNH"].Value.ToString();
            }
           
        }
    }
}
