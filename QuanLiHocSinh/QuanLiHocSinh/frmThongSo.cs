using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLHS.DTO;
using QLHS.BUS;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;

namespace QuanLiHocSinh
{
    public partial class frmThongSo : DevComponents.DotNetBar.Office2007Form
    {
        private clsQUYDINH_BUS quyDinh_BUS;

        public frmThongSo()
        {
            InitializeComponent();
            quyDinh_BUS = new clsQUYDINH_BUS();
            this.KeyPreview = true;
        }

        private void frmThongSo_Load(object sender, EventArgs e)
        {
            quyDinh_BUS.hienThiDanhSach(txtTuoiTT, txtTuoiTD, txtSiSoTT, txtSiSoTD, txtTenTruong, txtDiaChi, txtDienThoai);
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (tabControlPanelSiSo.IsSelected)
            {
                if (txtSiSoTT.Value <= 10 || txtSiSoTD.Value >= 60)
                    MessageBox.Show("Sỉ số phải nằm trong khoảng giới hạn 10 - 60!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    quyDinh_BUS.suaThongTinSiSo(txtSiSoTT,txtSiSoTD);
                    MessageBox.Show("Cập nhật thành công quy định về sỉ số!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (tabControlPanelDoTuoi.IsSelected)
            {
                if (txtTuoiTT.Value <= 10 || txtTuoiTD.Value >= 30)
                    MessageBox.Show("Độ tuổi phải nằm trong khoảng giới hạn 10 - 30!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    quyDinh_BUS.suaThongTinTuoi(txtTuoiTT,txtTuoiTD);
                    MessageBox.Show("Cập nhật thành công quy định về độ tuổi!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (tabControlPanelTruong.IsSelected)
            {
                if (txtTenTruong.Text == ""||txtDiaChi.Text==""||txtDienThoai.Text=="")
                    MessageBox.Show("Phải nhập đầy đủ thông tin!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                else
                {
                    quyDinh_BUS.suaThongTinTruong(txtTenTruong,txtDiaChi,txtDienThoai);
                    MessageBox.Show("Cập nhật thành công thông tin trường học!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }           
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThongSo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ nhập số, không nhập chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
