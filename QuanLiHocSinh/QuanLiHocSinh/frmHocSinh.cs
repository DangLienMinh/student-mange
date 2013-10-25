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
namespace QuanLiHocSinh
{
    public partial class frmHocSinh : DevComponents.DotNetBar.Office2007Form
    {
        private clsHOCSINH_BUS hocsinh_bus;
        private clsHOCSINH_DTO hocsinh_dto;
        private Boolean flagInsert;
        private Boolean flagUpdate;
        private Boolean flagDelete;
        private string linkimagehientai;
        public frmHocSinh()
        {
            InitializeComponent();
            hocsinh_bus = new clsHOCSINH_BUS();
            hocsinh_dto = new clsHOCSINH_DTO();
            flagInsert = false;
            flagUpdate = false;
            flagDelete = false;
        }

        private void btnItemTim_Click(object sender, EventArgs e)
        {

        }

        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            anhienButton(true);
            hocsinh_bus.cboGioitinh(cboGioiTinh);
            hocsinh_bus.cboNamhoc(cboNamHoc);
            hocsinh_bus.cboLophoc(cboLopHoc);
            txtMaHS.Text = hocsinh_bus.taoMaHocSinh();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picHocSinh.Image = Image.FromFile(ofd.FileName);
                linkimagehientai = ofd.FileName;
                string linkimage = Directory.GetCurrentDirectory() + @"\hinhAnh\" + ofd.SafeFileName;
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
        public int kiemtraDulieu()
        {
            int dem = 0;
            if (txtTenHS.Text == "")
            {
                MessageBox.Show("Chưa nhập Họ và Tên Học Sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dem++;
            }
            //if (dtiNgaySinh.Text.Length < 10)
            //{
            //    MessageBox.Show("Nhập ngày sinh chưa đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    dem++;
            //}
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
            //if (dtiNgayNhapHoc.Text.Length < 10)
            //{
            //    MessageBox.Show("Nhập ngày nhập học chưa đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    dem++;
            //}
            return dem;
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
                if (kiemtraDulieu() == 0)
                {
                    hocsinh_dto.Mahs=txtMaHS.Text;
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
                    hocsinh_dto.Malop = cboLopHoc.SelectedValue.ToString();
                    try
                    {
                        hocsinh_bus.themHocsinh(hocsinh_dto);
                        File.Copy(linkimagehientai, hocsinh_dto.Hinhanhhs);
                        MessageBox.Show("Đã thêm học sinh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            anhienButton(true);
        }
    }
}
