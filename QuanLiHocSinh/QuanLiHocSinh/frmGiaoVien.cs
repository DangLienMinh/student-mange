using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLHS.BUS;
using System.IO;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;

namespace QuanLiHocSinh
{
    public partial class frmGiaoVien : DevComponents.DotNetBar.Office2007Form
    {
        private clsGIAOVIEN_BUS giaoVien_BUS = new clsGIAOVIEN_BUS();
        private OpenFileDialog open=new OpenFileDialog();
        private int flag = 0;
        private int viTri, Tong;
        
        
        public frmGiaoVien()
        {
            InitializeComponent();
            this.KeyPreview = true;
            datagridMakeUp(grdGiaoVien);
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

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            giaoVien_BUS.hienThiDanhSach(grdGiaoVien);
            giaoVien_BUS.hienThiComboBox(cbGioiTinh);
            FlagDisable();
            flag = 0;
            sapXep();
            btnDau.Enabled = false;
            btnTruoc.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaGV.Focus();
            FlagEnable();
            flag = 1;
            resetAll();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            DialogResult result = open.ShowDialog();
            if (result == DialogResult.OK)
            {
                picGiaoVien.Image = Image.FromFile(open.FileName);
            }
        }

        private void insert()
        {
            
            if (string.IsNullOrEmpty(txtMaGV.Text) || string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrEmpty(txtDienThoai.Text) || string.IsNullOrEmpty(txtTenGV.Text) || picGiaoVien.Image==null)
            {
                MessageBox.Show("Xin điền dữ liệu vào đầy đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string txtGioiTinh = "";
                if (cbGioiTinh.SelectedItem == "Nam")
                {
                    txtGioiTinh = "0";
                }
                else
                {
                    txtGioiTinh = "1";
                }
                string linkimage = Directory.GetCurrentDirectory() + @"\hinhAnh\" + open.SafeFileName;
                File.Copy(open.FileName, linkimage);
                
                //reset all openfiledialog
                open.Reset();

                giaoVien_BUS.themGiaoVien(txtMaGV.Text, txtTenGV.Text, dtiNgaySinh, txtDienThoai.Text, txtGioiTinh, txtDiaChi.Text, linkimage);
                MessageBox.Show("Bạn đã thêm thành công!");
                giaoVien_BUS.themDong();
                FlagDisable();
                flag = 0;
            } 
        }

        private void update()
        {
            if (grdGiaoVien.SelectedRows.Count >= 1 && txtMaGV.Text != "")
            {
                string txtGioiTinh = "";
                if (cbGioiTinh.SelectedItem == "Nam")
                {
                    txtGioiTinh = "0";
                }
                else
                {
                    txtGioiTinh = "1";
                }

                if (open.FileName != "")
                {
                    string linkimage = Directory.GetCurrentDirectory() + @"\hinhAnh\" + open.SafeFileName;
                    File.Copy(open.FileName, linkimage);
                    if (string.Compare(grdGiaoVien.CurrentRow.Cells["HINHANHGV"].Value.ToString(), linkimage) == -1)
                    {
                        giaoVien_BUS.suaGiaoVien(txtMaGV.Text, txtTenGV.Text, dtiNgaySinh, txtDienThoai.Text, txtGioiTinh, txtDiaChi.Text, linkimage);

                        // sử dụng filestream để có thể xóa hình ảnh mafkhoong bị thằng picturebox chiếm giữ
                        FileStream fs = new FileStream(linkimage, FileMode.Open, FileAccess.Read);
                        picGiaoVien.Image = Image.FromStream(fs);
                        fs.Close();

                        File.Delete(grdGiaoVien.CurrentRow.Cells["HINHANHGV"].Value.ToString());
                    }
                }
                else
                {
                    giaoVien_BUS.suaGiaoVien(txtMaGV.Text, txtTenGV.Text, dtiNgaySinh, txtDienThoai.Text, txtGioiTinh, txtDiaChi.Text, grdGiaoVien.CurrentRow.Cells["HINHANHGV"].Value.ToString());

                }

                MessageBox.Show("Bạn đã sửa thành công!");

                //sửa trong datagrid view
                giaoVien_BUS.suaDataGrid(grdGiaoVien);

                FlagDisable();
                flag = 0;

            }
            else
            {
                MessageBox.Show("Bạn phải lựa chọn một hàng để sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void grdGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dong = e.RowIndex;
            //txtMaGV.Text = grdGiaoVien.Rows[dong].Cells[0].Value.ToString();
            //txtTenGV.Text = grdGiaoVien.Rows[dong].Cells[1].Value.ToString();
            //txtDiaChi.Text = grdGiaoVien.Rows[dong].Cells[4].Value.ToString();
            //txtDienThoai.Text = grdGiaoVien.Rows[dong].Cells[5].Value.ToString();

            //string ngaySinh = grdGiaoVien.Rows[dong].Cells[2].Value.ToString();
            //string gioiTinh = grdGiaoVien.Rows[dong].Cells[3].Value.ToString();

            //dong = e.RowIndex;
            txtMaGV.Text = grdGiaoVien.CurrentRow.Cells["MAGV"].Value.ToString();
            txtTenGV.Text = grdGiaoVien.CurrentRow.Cells["TENGV"].Value.ToString();
            txtDiaChi.Text = grdGiaoVien.CurrentRow.Cells["DIACHIGV"].Value.ToString();
            txtDienThoai.Text = grdGiaoVien.CurrentRow.Cells["DIENTHOAIGV"].Value.ToString();

            string ngaySinh = grdGiaoVien.CurrentRow.Cells["NGSINHGV"].Value.ToString();
            string gioiTinh = grdGiaoVien.CurrentRow.Cells["GIOITINHGV"].Value.ToString();

            if (gioiTinh == "0")
            {
                cbGioiTinh.SelectedItem = "Nam";
            }
            else
            {
                cbGioiTinh.SelectedItem = "Nữ";
            }

            if (ngaySinh != "")
            {
                DateTime d = new DateTime();
                d = DateTime.Parse(ngaySinh);
                dtiNgaySinh.Value = d;
            }

            // sử dụng filestream để có thể xóa hình ảnh mà không bị thằng picturebox chiếm giữ
            if (grdGiaoVien.CurrentRow.Cells["HINHANHGV"].Value.ToString() != "")
            {
                string imageLink = grdGiaoVien.CurrentRow.Cells["HINHANHGV"].Value.ToString();
                FileStream fs = new FileStream(imageLink, FileMode.Open, FileAccess.Read);
                picGiaoVien.Image = Image.FromStream(fs);
                fs.Close();
            }
            sapXep();               
        }

        private void delete() 
        {
            if (grdGiaoVien.SelectedRows.Count >= 1 && txtMaGV.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa giáo viên đã được lựa chọn ", "Xóa giáo viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    giaoVien_BUS.xoaGiaoVien(txtMaGV.Text);
                    foreach (DataGridViewRow row in grdGiaoVien.Rows)
                    {
                        if (string.Compare(row.Cells["MAGV"].Value.ToString().Trim(), txtMaGV.Text.Trim()) == 0)
                        {
                            
                            File.Delete(row.Cells["HINHANHGV"].Value.ToString());
                            giaoVien_BUS.xoaDong(grdGiaoVien, txtMaGV.Text);
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            flag = 2;
            //resetAll();
            FlagEnable();
        }

        private void resetAll()
        {
            txtMaGV.Text = "";
            txtTenGV.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            dtiNgaySinh.Value = DateTime.Now;
            picGiaoVien.Image = null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 3;
            FlagEnable();
        }

        private void sapXep()
        {
            viTri = this.BindingContext[grdGiaoVien.DataSource].Position;
            Tong = this.BindingContext[grdGiaoVien.DataSource].Count;
            txtHienTai.Text = "" + (viTri + 1).ToString() + "/" + Tong.ToString();
            txtMaGV.Text = grdGiaoVien.Rows[viTri].Cells["MAGV"].Value.ToString();
            txtTenGV.Text = grdGiaoVien.Rows[viTri].Cells["TENGV"].Value.ToString();
            txtDiaChi.Text = grdGiaoVien.Rows[viTri].Cells["DIACHIGV"].Value.ToString();
            txtDienThoai.Text = grdGiaoVien.Rows[viTri].Cells["DIENTHOAIGV"].Value.ToString();

            string ngaySinh = grdGiaoVien.Rows[viTri].Cells["NGSINHGV"].Value.ToString();
            string gioiTinh = grdGiaoVien.Rows[viTri].Cells["GIOITINHGV"].Value.ToString();

            if (gioiTinh == "0")
            {
                cbGioiTinh.SelectedItem = "Nam";
            }
            else
            {
                cbGioiTinh.SelectedItem = "Nữ";
            }

            if (ngaySinh != "")
            {
                DateTime d = new DateTime();
                d = DateTime.Parse(ngaySinh);
                dtiNgaySinh.Value = d;
            }

            // sử dụng filestream để có thể xóa hình ảnh mà không bị thằng picturebox chiếm giữ
            if ( grdGiaoVien.Rows[viTri].Cells["HINHANHGV"].Value.ToString()!="")
            {
                string imageLink = grdGiaoVien.Rows[viTri].Cells["HINHANHGV"].Value.ToString();
                FileStream fs = new FileStream(imageLink, FileMode.Open, FileAccess.Read);
                picGiaoVien.Image = Image.FromStream(fs);
                fs.Close(); 
            }  
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            viTri = this.BindingContext[grdGiaoVien.DataSource].Position;
            this.BindingContext[grdGiaoVien.DataSource].Position = 0;
            sapXep();
            btnTruoc.Enabled = false;
            btnDau.Enabled = false;
            btnCuoi.Enabled = true;
            btnSau.Enabled = true;
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            viTri = this.BindingContext[grdGiaoVien.DataSource].Position;
            btnDau.Enabled = true;
            btnTruoc.Enabled = true;
            this.BindingContext[grdGiaoVien.DataSource].Position = this.BindingContext[grdGiaoVien.DataSource].Count - 1;
            sapXep();
            btnCuoi.Enabled = false;
            btnSau.Enabled = false;
            btnTruoc.Enabled = true;
            btnDau.Enabled = true;
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            viTri = this.BindingContext[grdGiaoVien.DataSource].Position;
            btnCuoi.Enabled = true;
            btnSau.Enabled = true;
            this.BindingContext[grdGiaoVien.DataSource].Position = viTri - 1;
            sapXep();
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            viTri = this.BindingContext[grdGiaoVien.DataSource].Position;
            btnDau.Enabled = true;
            btnTruoc.Enabled = true;
            this.BindingContext[grdGiaoVien.DataSource].Position = viTri + 1;
            sapXep();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTim.Text))
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin vào");
            }
            else
	        {
                if (optMaGV.Checked)
                {
                    giaoVien_BUS.timGVMaGV(grdGiaoVien,txtTim.Text);
                }
                else
                {
                    giaoVien_BUS.timGVTenGV(grdGiaoVien,txtTim.Text);
                }

	        }
            sapXep();
            
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
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
            txtDiaChi.BackColor = Color.White;
            txtDienThoai.BackColor = Color.White;
            txtMaGV.BackColor = Color.White;
            txtTenGV.BackColor = Color.White;
        }

        private void frmGiaoVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

    }
}
