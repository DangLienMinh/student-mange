using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLHS.BUS;
using QLHS.DTO;
using System.IO;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;
namespace QuanLiHocSinh
{
    public partial class frmHocSinh : DevComponents.DotNetBar.Office2007Form
    {
        private clsHOCSINH_BUS hocsinh_bus;
        private clsHOCSINH_DTO hocsinh_dto;
        private clsKHOI_BUS khoi_bus;
        private Boolean flagInsert;
        private Boolean flagUpdate;
        private Boolean flagDelete;
        private Boolean flagChonAnh;
        private string linkgoc;
        private int vitri;
        private int Tong;
        public frmHocSinh()
        {
            InitializeComponent();
            hocsinh_bus = new clsHOCSINH_BUS();
            hocsinh_dto = new clsHOCSINH_DTO();
            khoi_bus = new clsKHOI_BUS();
            flagInsert = false;
            flagUpdate = false;
            flagDelete = false;
            flagChonAnh = false;
        }

        private void btnItemTim_Click(object sender, EventArgs e)
        {

        }
        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            anhienButton(true);
            hocsinh_bus.cboGioitinh(cboGioiTinh);
            hocsinh_bus.cboNamhoc(cboNamHoc);
            khoi_bus.hienThiComboBox(cboKhoi);
            //txtMaHS.Text = hocsinh_bus.staoMaHocSinh();
            //txtMaHS.Text = hocsinh_bus.taoMaHocSinh();
            dtiNgaySinh.Value = DateTime.Now;
            dtiNgayNhapHoc.Value = DateTime.Now;
            grdHocSinh.DataSource = hocsinh_bus.danhsachHocSinh();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            flagChonAnh = true;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn hình ảnh";
            ofd.Filter = "jpg files (*.jpg)|*.jpg|png file (*.png)|*.png|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picHocSinh.Image = Image.FromFile(ofd.FileName);
                linkgoc = ofd.FileName;
                string linkimage;
                linkimage = Directory.GetCurrentDirectory() + @"\hinhAnh\" + ofd.SafeFileName;
                hocsinh_dto.Hinhanhhs = linkimage;
            }
        }
        public void anhienButton(Boolean b)
        {
            btnThem.Enabled = b;
            btnSua.Enabled = b;
            btnXoa.Enabled = b;
            if (b == true)
            {
                btnDongy.Enabled = false;
                btnHuy.Enabled = false;
            }
            else
            {
                btnDongy.Enabled = true;
                btnHuy.Enabled = true;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaHS.Text = hocsinh_bus.taoMaHocSinh();
            anhienButton(false);
            flagInsert = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            anhienButton(false);
            flagDelete = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            anhienButton(false);
            flagUpdate = true;
        }
        private void btnDongy_Click(object sender, EventArgs e)
        {
            anhienButton(true);
            if (flagInsert == true)
            {
                Insert();
            }
            else
            {
                if (flagDelete == true)
                {
                    Delete();
                }
                else
                {
                    Update();
                }
            }
            Hienthidulieu();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            anhienButton(true);
        }
        private void btnDau_Click(object sender, EventArgs e)
        {
            vitri = this.BindingContext[grdHocSinh.DataSource].Position;
            this.BindingContext[grdHocSinh.DataSource].Position = 0;
            Hienthidulieu();
            btnTruoc.Enabled = false;
            btnDau.Enabled = false;
            btnCuoi.Enabled = true;
            btnSau.Enabled = true;
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            vitri = this.BindingContext[grdHocSinh.DataSource].Position;
            btnCuoi.Enabled = true;
            btnSau.Enabled = true;
            this.BindingContext[grdHocSinh.DataSource].Position = vitri - 1;
            Hienthidulieu();
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            vitri = this.BindingContext[grdHocSinh.DataSource].Position;
            btnDau.Enabled = true;
            btnTruoc.Enabled = true;
            this.BindingContext[grdHocSinh.DataSource].Position = vitri + 1;
            Hienthidulieu();
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            vitri = this.BindingContext[grdHocSinh.DataSource].Position;
            this.BindingContext[grdHocSinh.DataSource].Position = this.BindingContext[grdHocSinh.DataSource].Count - 1;
            Hienthidulieu();
            btnCuoi.Enabled = false;
            btnSau.Enabled = false;
            btnTruoc.Enabled = true;
            btnDau.Enabled = true;
        }
        private void grdHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cboNamHoc.SelectedValue = grdHocSinh.CurrentRow.Cells["MANH"].Value.ToString();
            cboKhoi.SelectedValue = grdHocSinh.CurrentRow.Cells["MAKHOI"].Value.ToString();
            cboGioiTinh.SelectedValue = grdHocSinh.CurrentRow.Cells["GIOITINHHS"].Value.ToString();
            txtMaHS.Text = grdHocSinh.CurrentRow.Cells["MAHS"].Value.ToString();
            txtTenHS.Text = grdHocSinh.CurrentRow.Cells["TENHS"].Value.ToString();
            txtDiaChi.Text = grdHocSinh.CurrentRow.Cells["DIACHIHS"].Value.ToString();
            txtDantoc.Text = grdHocSinh.CurrentRow.Cells["DANTOC"].Value.ToString();
            txtDienThoai.Text = grdHocSinh.CurrentRow.Cells["DIENTHOAIHS"].Value.ToString();
            dtiNgaySinh.Text = grdHocSinh.CurrentRow.Cells["NGSINHHS"].Value.ToString();
            dtiNgayNhapHoc.Text = grdHocSinh.CurrentRow.Cells["NGNHAPHOC"].Value.ToString();
            if (grdHocSinh.CurrentRow.Cells["HINHANHHS"].Value.ToString() != "")
            {
                FileStream fs = new FileStream(grdHocSinh.CurrentRow.Cells["HINHANHHS"].Value.ToString(), FileMode.Open, FileAccess.Read);
                picHocSinh.Image = Image.FromStream(fs);
                fs.Close();
            }
        }
        public void resetALL()
        {
            picHocSinh.Image = null;
            txtMaHS.Text = "";
            txtTenHS.Text = "";
            txtDiaChi.Text = "";
            txtDantoc.Text = "";
            txtDienThoai.Text = "";
            dtiNgayNhapHoc.Value = DateTime.Now;
            dtiNgaySinh.Value = DateTime.Now;
        }
        public int kiemtraDulieu()
        {
            int dem = 0;
            if (picHocSinh.Image == null)
            {
                MessageBox.Show("Chưa Chọn hình ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dem++;
            }
            if (txtTenHS.Text == "")
            {
                MessageBox.Show("Chưa nhập Họ và Tên Học Sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dem++;
            }
            if (txtDantoc.Text == "")
            {
                MessageBox.Show("Chưa nhập Dân tộc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dem++;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Chưa nhập Địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dem++;
            }
            if (txtDantoc.Text == "")
            {
                MessageBox.Show("Chưa nhập Dân tộc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dem++;
            }
            if (linkgoc == "")
            {
                MessageBox.Show("Chưa Chọn hình ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dem++;
            }

            return dem;
        }
        public void Insert()
        {
            if (kiemtraDulieu() == 0)
            {
                hocsinh_dto.Mahs = txtMaHS.Text;
                hocsinh_dto.Tenhs = txtTenHS.Text;
                hocsinh_dto.Ngaysinhhs = DateTime.Parse(dtiNgaySinh.Text);
                if (cboGioiTinh.SelectedItem.ToString() == "Nam")
                {
                    hocsinh_dto.Gioitinh = "1";
                }
                else
                {
                    hocsinh_dto.Gioitinh = "0";
                }
                hocsinh_dto.Dantoc = txtDantoc.Text;
                hocsinh_dto.Dienthoaihs = txtDienThoai.Text;
                hocsinh_dto.Diachihs = txtDiaChi.Text;
                hocsinh_dto.Ngnhaphoc = DateTime.Parse(dtiNgayNhapHoc.Text);
                hocsinh_dto.Manh = cboNamHoc.SelectedValue.ToString();
                hocsinh_dto.Makhoi = cboKhoi.SelectedValue.ToString();
                //hocsinh_dto.Malop = "null";
                try
                {
                    File.Copy(linkgoc, hocsinh_dto.Hinhanhhs);
                    hocsinh_bus.themHocsinh(hocsinh_dto);
                    resetALL();
                    grdHocSinh.DataSource = hocsinh_bus.danhsachHocSinh();//tải lại danh sách sau khi thêm
                    flagChonAnh = false;
                    flagInsert = false;
                    MessageBox.Show("Đã thêm học sinh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void Delete()
        {
            hocsinh_dto.Mahs = txtMaHS.Text;
            if (grdHocSinh.SelectedRows.Count >= 1 && txtMaHS.Text != "")
            {
                try
                {
                    hocsinh_bus.xoaHocsinh(hocsinh_dto);
                    File.Delete(grdHocSinh.CurrentRow.Cells["HINHANHHS"].Value.ToString());
                    grdHocSinh.DataSource = hocsinh_bus.danhsachHocSinh();//tải lại danh sách sau khi xóa
                    flagDelete = false;
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn Dòng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Update()
        {
            if (kiemtraDulieu() == 0)
            {
                hocsinh_dto.Mahs = txtMaHS.Text;
                hocsinh_dto.Tenhs = txtTenHS.Text;
                hocsinh_dto.Ngaysinhhs = DateTime.Parse(dtiNgaySinh.Text);
                if (cboGioiTinh.SelectedItem.ToString() == "Nam")
                {
                    hocsinh_dto.Gioitinh = "1";
                }
                else
                {
                    hocsinh_dto.Gioitinh = "0";
                }
                hocsinh_dto.Dantoc = txtDantoc.Text;
                hocsinh_dto.Dienthoaihs = txtDienThoai.Text;
                hocsinh_dto.Diachihs = txtDiaChi.Text;
                hocsinh_dto.Ngnhaphoc = DateTime.Parse(dtiNgayNhapHoc.Text);
                hocsinh_dto.Manh = cboNamHoc.SelectedValue.ToString();
                hocsinh_dto.Makhoi = cboKhoi.SelectedValue.ToString();
                //hocsinh_dto.Malop = "null";
                try
                {
                    if (flagChonAnh == true)
                    {
                        File.Copy(linkgoc, hocsinh_dto.Hinhanhhs);
                        File.Delete(grdHocSinh.CurrentRow.Cells["HINHANHHS"].Value.ToString());
                        flagChonAnh = false;
                    }
                    else
                    {
                        hocsinh_dto.Hinhanhhs = grdHocSinh.CurrentRow.Cells["HINHANHHS"].Value.ToString();
                    }
                    hocsinh_bus.suaHocsinh(hocsinh_dto);
                    flagUpdate = false;
                    resetALL();
                    grdHocSinh.DataSource = hocsinh_bus.danhsachHocSinh();//tải lại danh sách sau khi thêm
                    MessageBox.Show("Đã sửa học sinh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void Hienthidulieu()
        {
            //int Tong;
            //int vitri;
            vitri = this.BindingContext[grdHocSinh.DataSource].Position;
            Tong = this.BindingContext[grdHocSinh.DataSource].Count;
            if (vitri != -1)
            {
                txtHienTai.Text = (vitri + 1).ToString() + "/" + Tong.ToString();
                txtMaHS.Text = grdHocSinh.Rows[vitri].Cells["MAHS"].Value.ToString();
                txtTenHS.Text = grdHocSinh.Rows[vitri].Cells["TENHS"].Value.ToString();
                txtDantoc.Text = grdHocSinh.Rows[vitri].Cells["DANTOC"].Value.ToString();
                txtDienThoai.Text = grdHocSinh.Rows[vitri].Cells["DIENTHOAIHS"].Value.ToString();
                txtDiaChi.Text = grdHocSinh.Rows[vitri].Cells["DIACHIHS"].Value.ToString();
                cboGioiTinh.SelectedValue = grdHocSinh.Rows[vitri].Cells["GIOITINHHS"].Value.ToString();
                cboKhoi.SelectedValue = grdHocSinh.Rows[vitri].Cells["MAKHOI"].Value.ToString();
                cboNamHoc.SelectedValue = grdHocSinh.Rows[vitri].Cells["MANH"].Value.ToString();
                dtiNgaySinh.Text = grdHocSinh.Rows[vitri].Cells["NGSINHHS"].Value.ToString();
                dtiNgayNhapHoc.Text = grdHocSinh.Rows[vitri].Cells["NGNHAPHOC"].Value.ToString();
                FileStream fs = new FileStream(grdHocSinh.Rows[vitri].Cells["HINHANHHS"].Value.ToString(), FileMode.Open, FileAccess.Read);
                picHocSinh.Image = Image.FromStream(fs);
                fs.Close();
            }
        }


    }
}
