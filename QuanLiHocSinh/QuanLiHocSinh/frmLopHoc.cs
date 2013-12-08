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
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;

namespace QuanLiHocSinh
{
    public partial class frmLopHoc : DevComponents.DotNetBar.Office2007Form
    {
        private BindingSource bs;
        private clsLOP_BUS lop_BUS;
        private clsKHOI_BUS khoi_BUS;
        private clsNAMHOC_BUS namHoc_BUS;
        private clsLOP_DTO lop_DTO;
        private clsGIAOVIEN_BUS giaoVien_BUS;
        private clsQUYDINH_BUS quyDinh_BUS;
        private Boolean flagInsert;
        private Boolean flagUpdate;

        public frmLopHoc()
        {
            InitializeComponent();
            lop_BUS = new clsLOP_BUS();
            namHoc_BUS = new clsNAMHOC_BUS();
            khoi_BUS = new clsKHOI_BUS();
            lop_DTO = new clsLOP_DTO();
            giaoVien_BUS = new clsGIAOVIEN_BUS();
            quyDinh_BUS = new clsQUYDINH_BUS();
            this.KeyPreview = true;
        }

        //hàm bindingData đặt binding source=lop_BUS.danhSachLop() sao đó cho nó dính vào datagrid
        private void bindingData()
        {
            //biding navigator
            bs = new BindingSource();
            bs.DataSource = lop_BUS.danhSachLop();
            grdLop.DataSource = bs;
            //lop_BUS.taiLaiDataGrid(grdLop);
            bnaLop.BindingSource = bs;
        }

        private void frmLopHoc_Load(object sender, EventArgs e)
        {
            //load dữ liệu vào comboBox năm học
            namHoc_BUS.hienThiComboBox(cboNamHoc);
            //load dữ liệu vào comboBox khối
            khoi_BUS.hienThiComboBox(cboKhoi);
            //load dữ liệu vào comboBox giáo viên chủ nhiệm
            lop_BUS.cboGiaoVienChuNhiem(cboGiaoVien);
            //load dữ liệu vào comboBox Ban học
            //lop_BUS.hienThiComboBoxBan(cboBan);
            //load dữ liệu vào comboBox Ban
            lop_BUS.cboBan(cboBan);

            //Hiển thị theo tên cho datagrid column ví dụ MAGV sẽ lấy tên hiển thị
            namHoc_BUS.HienThiDataGridViewComboBoxColumn(MANH1);
            giaoVien_BUS.HienThiDataGridViewComboBoxColumn(MAGV1);
            khoi_BUS.HienThiDataGridViewComboBoxColumn(MAKHOI1);
            lop_BUS.hienThiDataGridViewComboBoxColumnBan(MABAN1);
            //load danh sách lớp vào datagrid lớp
            bindingData();

            datagridMakeUp(grdLop);
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaLop.Text = lop_BUS.taoMaLop();
            txtTenLop.Focus();
            anHienButton(false);
            flagInsert = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            anHienButton(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtTenLop.Focus();
            anHienButton(false);
            flagUpdate = true;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            anHienButton(true);
            if (flagInsert == true)
            {
                if (kiemTraDuLieu() == 0)
                {
                    lop_DTO.Malop = txtMaLop.Text;
                    lop_DTO.Tenlop = txtTenLop.Text;
                    lop_DTO.Makhoi = cboKhoi.SelectedValue.ToString();
                    lop_DTO.Manh = cboNamHoc.SelectedValue.ToString();
                    lop_DTO.Magv = cboGiaoVien.SelectedValue.ToString();
                    lop_DTO.Siso = txtSiSo.Text;
                    lop_DTO.Maban = cboBan.SelectedValue.ToString();
                    //if (cboBan.SelectedItem.ToString() == "Cơ bản")
                    //{
                    //    lop_DTO.Maban = "CB";
                    //}
                    //else if (cboBan.SelectedItem.ToString() == "Khoa học tự nhiên")
                    //{
                    //    lop_DTO.Maban = "KHTN";
                    //}
                    //else
                    //{
                    //    lop_DTO.Maban = "KHXHNV";
                    //}
                    if (int.Parse(lop_DTO.Siso)>quyDinh_BUS.siSoToiDa())
                    {
                        MessageBox.Show("Sỉ số nhập vào không được vượt quá sỉ sổ tối đa"+quyDinh_BUS.siSoToiDa().ToString());
                    }
                    else if (int.Parse(lop_DTO.Siso)<quyDinh_BUS.siSoToiThieu())
                    {
                         MessageBox.Show("Sỉ số nhập vào không được nhỏ hơn sỉ số tối thiểu "+quyDinh_BUS.siSoToiThieu().ToString());
                    }
                    else
                    {
                        try
                        {
                            lop_BUS.themLopHoc(lop_DTO);
                            //lop_BUS.taiLaiDataGrid(grdLop, lop_BUS.danhSachLop());//tải lại danh sách sau khi thêm
                            bindingData();
                            MessageBox.Show("Thêm lớp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            flagInsert = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi !" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                if (flagUpdate == true)
                {
                    if (grdLop.SelectedRows.Count >= 1)
                    {
                        if (kiemTraDuLieu() == 0)
                        {
                            lop_DTO.Malop = txtMaLop.Text;
                            lop_DTO.Tenlop = txtTenLop.Text;
                            lop_DTO.Makhoi = cboKhoi.SelectedValue.ToString();
                            lop_DTO.Manh = cboNamHoc.SelectedValue.ToString();
                            lop_DTO.Magv = cboGiaoVien.SelectedValue.ToString();
                            lop_DTO.Siso = txtSiSo.Text;
                            lop_DTO.Maban = cboBan.SelectedValue.ToString();
                            try
                            {
                                lop_BUS.suaLop(lop_DTO);
                                flagUpdate = false;
                                //lop_BUS.taiLaiDataGrid(grdLop, lop_BUS.danhSachLop());//Load lại danh sách sau khi sửa
                                bindingData();
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
                            lop_DTO.Malop = txtMaLop.Text;
                            lop_DTO.Manh = cboNamHoc.SelectedValue.ToString();
                            lop_BUS.xoaLop(lop_DTO);
                            //lop_BUS.taiLaiDataGrid(grdLop, lop_BUS.danhSachLop());//Load lại danh sách sau khi xóa
                            bindingData();
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
            anHienButton(true);
        }
        public void anHienButton(Boolean b)
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
        public int kiemTraDuLieu()
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
            if (cboGiaoVien.SelectedValue==null)
            {
                MessageBox.Show("Chưa chọn giáo viên chủ nhiệm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dem++;
            }
            if (cboKhoi.SelectedValue == null)
            {
                MessageBox.Show("Chưa chọn khối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dem++;
            }
            if (cboNamHoc.SelectedValue == null)
            {
                MessageBox.Show("Chưa chọn năm học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            cboNamHoc.SelectedValue = grdLop.CurrentRow.Cells["MANH1"].Value.ToString();
            cboBan.SelectedValue = grdLop.CurrentRow.Cells["MABAN1"].Value.ToString();
            anHienButton(true);
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Yellow;
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            txtSiSo.BackColor = Color.White;
            txtTenLop.BackColor = Color.White;
        }

        private void frmLopHoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtSiSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ nhập số, không nhập chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            anHienButton(false);
            
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        private void move_Click(object sender, EventArgs e)
        {
            txtMaLop.Text = grdLop.CurrentRow.Cells["MALOP1"].Value.ToString();
            txtTenLop.Text = grdLop.CurrentRow.Cells["TENLOP1"].Value.ToString();
            txtSiSo.Text = grdLop.CurrentRow.Cells["SISO1"].Value.ToString();
            cboGiaoVien.SelectedValue = grdLop.CurrentRow.Cells["MAGV1"].Value.ToString();
            cboKhoi.SelectedValue = grdLop.CurrentRow.Cells["MAKHOI1"].Value.ToString();
            cboNamHoc.SelectedValue = grdLop.CurrentRow.Cells["MANH1"].Value.ToString();
            cboBan.SelectedValue = grdLop.CurrentRow.Cells["MABAN1"].Value.ToString();
            anHienButton(true);
        }
    }
}
