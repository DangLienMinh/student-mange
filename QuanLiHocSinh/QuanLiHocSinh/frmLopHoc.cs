using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLHS.DTO;
using QLHS.BUS;
namespace QuanLiHocSinh
{
    public partial class frmLopHoc : DevComponents.DotNetBar.Office2007Form
    {
        private clsLOP_BUS lop_bus;
        private clsKHOI_BUS khoi_bus;
        private clsNAMHOC_BUS namHoc_bus;
        private clsLOP_DTO lop_dto;
        private Boolean flagInsert;
        private Boolean flagUpdate;
        private Boolean flagDelete;

        public frmLopHoc()
        {
            InitializeComponent();
            lop_bus = new clsLOP_BUS();
            namHoc_bus = new clsNAMHOC_BUS();
            khoi_bus = new clsKHOI_BUS();
            lop_dto = new clsLOP_DTO();
        }

        private void frmLopHoc_Load(object sender, EventArgs e)
        {
            namHoc_bus.hienThiComboBox(cboNamHoc);
            khoi_bus.hienThiComboBox(cboKhoi);
            lop_bus.cboGiaovienchunhiem(cboGiaoVien);
            grdLop.DataSource = lop_bus.danhsachLop();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaLop.Text = lop_bus.taoMalop();
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

        private void btnDongY_Click(object sender, EventArgs e)
        {
            anhienButton(true);
            if (flagInsert == true)
            {
                if (Kiemtradulieu() == 0)
                {
                    lop_dto.Malop = txtMaLop.Text;
                    lop_dto.Tenlop = txtTenLop.Text;
                    lop_dto.Makhoi = cboKhoi.SelectedValue.ToString();
                    lop_dto.Manh = cboNamHoc.SelectedValue.ToString();
                    lop_dto.Magv = cboGiaoVien.SelectedValue.ToString();
                    lop_dto.Siso = txtSiSo.Text;
                    try
                    {
                        lop_bus.themLophoc(lop_dto);
                        grdLop.DataSource = lop_bus.danhsachLop();//Load lại danh sách sau khi thêm
                        MessageBox.Show("Thêm lớp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        flagInsert = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi !" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (flagUpdate == true)
                {
                    if (grdLop.SelectedRows.Count >= 1)
                    {
                        if (Kiemtradulieu() == 0)
                        {
                            lop_dto.Malop = txtMaLop.Text;
                            lop_dto.Tenlop = txtTenLop.Text;
                            lop_dto.Makhoi = cboKhoi.SelectedValue.ToString();
                            lop_dto.Manh = cboNamHoc.SelectedValue.ToString();
                            lop_dto.Magv = cboGiaoVien.SelectedValue.ToString();
                            lop_dto.Siso = txtSiSo.Text;
                            try
                            {
                                lop_bus.suaLop(lop_dto);
                                flagUpdate = false;
                                grdLop.DataSource = lop_bus.danhsachLop();//Load lại danh sách sau khi sửa
                                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lỗi !" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lỗi ! Chưa chọn hàng cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (grdLop.SelectedRows.Count >= 1)
                    {
                        try
                        {
                            lop_dto.Malop = txtMaLop.Text;
                            lop_dto.Manh = cboNamHoc.SelectedValue.ToString();
                            lop_bus.xoaLop(lop_dto);
                            flagDelete = false;
                            grdLop.DataSource = lop_bus.danhsachLop();//Load lại danh sách sau khi xóa
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            {
                                MessageBox.Show("Lỗi !" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lỗi ! Chưa chọn hàng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
               
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            anhienButton(true);
        }
        public void anhienButton(Boolean b)
        {
            btnThem.Enabled = b;
            btnSua.Enabled = b;
            btnXoa.Enabled = b;
            if (b == true)
            {
                btnDongY.Enabled = false;
                btnHuy.Enabled = false;
            }
            else
            {
                btnDongY.Enabled = true;
                btnHuy.Enabled = true;
            }
        }
        public int Kiemtradulieu()
        {
            int dem=0;
            if (txtTenLop.Text == "")
            {
                MessageBox.Show("Chưa nhập Tên lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dem++;
            }
            if (txtSiSo.Text == "")
            {
                MessageBox.Show("Chưa nhập Sỉ số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dem++;
            }
            return dem;
        }

        private void grdLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLop.Text = grdLop.CurrentRow.Cells["MALOP1"].Value.ToString();
            txtTenLop.Text = grdLop.CurrentRow.Cells["TENLOP1"].Value.ToString();
            txtSiSo.Text = grdLop.CurrentRow.Cells["SISO1"].Value.ToString();
            cboGiaoVien.SelectedValue = grdLop.CurrentRow.Cells["MAGV1"].Value.ToString();
            cboKhoi.SelectedValue = grdLop.CurrentRow.Cells["MAKHOI1"].Value.ToString();
            cboNamHoc.SelectedValue = grdLop.CurrentRow.Cells["MANH"].Value.ToString();
        }
    }
}
