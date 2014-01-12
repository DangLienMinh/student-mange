using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QLHS.DTO;
using QLHS.BUS;
using DevComponents.DotNetBar.Controls;

namespace QuanLiHocSinh
{
    public partial class frmPhanCong : DevComponents.DotNetBar.Office2007Form
    {
        private BindingSource bs;
        private frmGiaoVien m_frmGiaovien;
        private frmLopHoc m_frmLophoc;
        private frmNamHoc m_frmNamhoc;
        private frmMonHoc m_frmMonhoc;
        private clsGIANGDAY_BUS giangday_bus;
        private Boolean flagInsert;
        private Boolean flagDelete;
        private clsGIANGDAY_DTO giangday_dto;
        private clsLOP_DTO lop_dto;
        private clsGIAOVIEN_DTO giaovien_dto;
        private clsGIAOVIEN_BUS giaoVien_BUS;
        private clsNAMHOC_BUS namHoc_BUS;
        private clsLOP_BUS lop_BUS;
        private clsMONHOC_BUS monHoc_BUS;

        public frmPhanCong()
        {
            InitializeComponent();
            giangday_bus = new clsGIANGDAY_BUS();
            namHoc_BUS = new clsNAMHOC_BUS();
            lop_BUS = new clsLOP_BUS();
            monHoc_BUS = new clsMONHOC_BUS();
            giaoVien_BUS = new clsGIAOVIEN_BUS();
            giangday_dto = new clsGIANGDAY_DTO();
            lop_dto = new clsLOP_DTO();
            giaovien_dto = new clsGIAOVIEN_DTO();
            flagInsert = false;
            flagDelete = false;
            m_frmGiaovien = null;
            m_frmLophoc = null;
            m_frmMonhoc = null;
            m_frmNamhoc = null;
            this.KeyPreview = true;
        }

        //hàm bindingData đặt binding source=giangday_bus.danhSachPhanCong() sao đó cho nó dính vào datagrid
        private void bindingData()
        {
            //biding navigator
            bs = new BindingSource();
            bs.DataSource = giangday_bus.danhSachPhanCong();
            grdPhanCong.DataSource = bs;
            bnaPhanCong.BindingSource = bs;
        }

        private void frmPhanCong_Load(object sender, EventArgs e)
        {
            giangday_bus.hienThiLop(cboLop);
            giangday_bus.hienThiNamHoc(cboNamHoc);
            giangday_bus.hienThiGiaoVien(cboGiaoVien);
            giangday_bus.hienThiMonHoc(cboMonHoc);

            //hiện tên thay vì hiện mã trong datagrid
            monHoc_BUS.HienThiDataGridViewComboBoxColumn(MAMH);
            lop_BUS.hienThiDataGridViewComboBoxColumn(MALOP);
            giaoVien_BUS.HienThiDataGridViewComboBoxColumn(MAGV);
            namHoc_BUS.HienThiDataGridViewComboBoxColumn(MANH);
            datagridMakeUp(grdPhanCong);

            bindingData();
        }

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
            anHienButton(false);
            flagInsert = true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            anHienButton(false);
            flagDelete = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            anHienButton(false);
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            anHienButton(true);
            if (flagInsert == true)//nếu button thêm được nhấn thì gọi đến hàm Insert
            {
                Insert();
                huyboDulieu();
                //grdPhanCong.DataSource = giangday_bus.danhSachPhanCong();
                bindingData();
            }
            else
            {
                if (flagDelete == true)//Nếu button sửa được nhấn htif gọi đến hàm Update
                {
                    Delete();
                    huyboDulieu();
                    bindingData();
                    //grdPhanCong.DataSource = giangday_bus.danhSachPhanCong();
                }
                else//Ngược lại thì gọi đến hàm Delete
                {
                    update();
                    huyboDulieu();
                    bindingData();
                    //grdPhanCong.DataSource = giangday_bus.danhSachPhanCong();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            anHienButton(true);
            huyboDulieu();
            flagDelete = false;
            flagInsert = false;
        }
        public void Insert()
        {
            int khoa = 0;
            giangday_dto.Malop = cboLop.SelectedValue.ToString();
            giangday_dto.Mamh = cboMonHoc.SelectedValue.ToString();
            giangday_dto.Manh = cboNamHoc.SelectedValue.ToString();
            giangday_dto.Magv = cboGiaoVien.SelectedValue.ToString();
            foreach (DataGridViewRow row in grdPhanCong.Rows)
            {
                if (row.Cells["MAMH"].Value != null)
                {
                    //Kiểm tra phân công đã có chưa
                    if (string.Compare(row.Cells["MAMH"].Value.ToString(), cboMonHoc.SelectedValue.ToString()) == 0 && string.Compare(row.Cells["MAGV"].Value.ToString(), cboGiaoVien.SelectedValue.ToString()) == 0 && string.Compare(row.Cells["MANH"].Value.ToString(), cboNamHoc.SelectedValue.ToString()) == 0 && string.Compare(row.Cells["MALOP"].Value.ToString(), cboLop.SelectedValue.ToString()) == 0)
                    {
                        khoa = 1;
                        break;
                    }
                }
            }
            if (khoa == 1)
            {
                MessageBox.Show("Lỗi ! Phân công đã tồn tại trong cơ sở dữ liệu ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flagInsert = false;
            }
            else
            {
                try
                {
                    giangday_bus.themGiangDay(giangday_dto);//Thêm phân công
                    MessageBox.Show("Thêm Phân công giảng dạy thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    flagInsert = false;//gán lại flagInsert để đảm bảo thực hiện thêm sửa xóa nhiều lần liên tục sẽ không gây ra lỗi
                }
                catch (Exception e)
                {
                    MessageBox.Show("Lỗi ! Thêm không thành công " + e.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flagInsert = false;//gán lại flagInsert để đảm bảo thực hiện thêm sửa xóa nhiều lần liên tục sẽ không gây ra lỗi
                }
            }
        }
        public void update()
        {
            int khoa = 0;
            clsGIANGDAY_DTO tam=new clsGIANGDAY_DTO();
            if (grdPhanCong.SelectedRows.Count >= 1)
            {
                giangday_dto.Malop = cboLop.SelectedValue.ToString();
                giangday_dto.Mamh = cboMonHoc.SelectedValue.ToString();
                giangday_dto.Manh = cboNamHoc.SelectedValue.ToString();
                giangday_dto.Magv = cboGiaoVien.SelectedValue.ToString();
                tam.Magv = grdPhanCong.CurrentRow.Cells["MAGV"].Value.ToString();
                tam.Malop = grdPhanCong.CurrentRow.Cells["MALOP"].Value.ToString();
                tam.Mamh = grdPhanCong.CurrentRow.Cells["MAMH"].Value.ToString();
                tam.Manh = grdPhanCong.CurrentRow.Cells["MANH"].Value.ToString();
                foreach (DataGridViewRow row in grdPhanCong.Rows)
                {
                    if (row.Cells["MAMH"].Value != null)
                    {
                        if (string.Compare(row.Cells["MAMH"].Value.ToString(), cboMonHoc.SelectedValue.ToString()) == 0 && string.Compare(row.Cells["MAGV"].Value.ToString(), cboGiaoVien.SelectedValue.ToString()) == 0 && string.Compare(row.Cells["MANH"].Value.ToString(), cboNamHoc.SelectedValue.ToString()) == 0 && string.Compare(row.Cells["MALOP"].Value.ToString(), cboLop.SelectedValue.ToString()) == 0)
                        {
                            khoa = 1;
                            break;
                        }
                    }
                }
                if (khoa == 1)
                {
                    MessageBox.Show("Lỗi ! Phân công đã tồn tại trong cơ sở dữ liệu ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        giangday_bus.suaPhanCong(giangday_dto, tam);
                        MessageBox.Show("Sửa Phân công giảng dạy thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Lỗi ! Sửa không thành công " + e.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {

            }
        }
        public void Delete()
        {
            if (grdPhanCong.SelectedRows.Count >= 1 && grdPhanCong.CurrentRow.Cells["MAMH"].Value.ToString() != "")
            {
                giangday_dto.Magv = grdPhanCong.CurrentRow.Cells["MAGV"].Value.ToString();
                giangday_dto.Malop = grdPhanCong.CurrentRow.Cells["MALOP"].Value.ToString();
                giangday_dto.Mamh = grdPhanCong.CurrentRow.Cells["MAMH"].Value.ToString();
                giangday_dto.Manh = grdPhanCong.CurrentRow.Cells["MANH"].Value.ToString();
                try
                {
                    giangday_bus.xoaPhanCong(giangday_dto);
                    flagDelete = false;
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    flagDelete = false;
                    MessageBox.Show("Lỗi !!!"+ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
            }
            else
            {
                flagDelete = false;
                MessageBox.Show("Lỗi ! Chưa chọn dòng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        public void huyboDulieu()
        {
            giangday_dto.Mamh = "";
            giangday_dto.Manh = "";
            giangday_dto.Malop = "";
            giangday_dto.Magv = "";
        }


        private void grdPhanCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cboGiaoVien.SelectedValue = grdPhanCong.CurrentRow.Cells["MAGV"].Value.ToString();
            cboLop.SelectedValue = grdPhanCong.CurrentRow.Cells["MALOP"].Value.ToString();
            cboMonHoc.SelectedValue = grdPhanCong.CurrentRow.Cells["MAMH"].Value.ToString();
            cboNamHoc.SelectedValue = grdPhanCong.CurrentRow.Cells["MANH"].Value.ToString();
            anHienButton(true);
        }
        //private void Hienthidulieu()
        //{
        //    vitri = this.BindingContext[grdPhanCong.DataSource].Position;
        //    tong = this.BindingContext[grdPhanCong.DataSource].Count;
        //    if (vitri != -1)
        //    {
        //        txtHienTai.Text = (vitri + 1).ToString() + "/" + tong.ToString();
        //        cboGiaoVien.SelectedValue = grdPhanCong.Rows[vitri].Cells["MAGV"].Value.ToString();
        //        cboLop.SelectedValue = grdPhanCong.Rows[vitri].Cells["MALOP"].Value.ToString();
        //        cboMonHoc.SelectedValue = grdPhanCong.Rows[vitri].Cells["MAMH"].Value.ToString();
        //        cboNamHoc.SelectedValue = grdPhanCong.Rows[vitri].Cells["MANH"].Value.ToString();
        //    }
        //}
        //private void btnDau_Click(object sender, EventArgs e)
        //{
        //    this.BindingContext[grdPhanCong.DataSource].Position = 0;
        //    Hienthidulieu();
        //    btnTruoc.Enabled = false;
        //    btnDau.Enabled = false;
        //    btnCuoi.Enabled = true;
        //    btnSau.Enabled = true;
        //}

        //private void btnTruoc_Click(object sender, EventArgs e)
        //{
        //    this.BindingContext[grdPhanCong.DataSource].Position = vitri - 1;
        //    Hienthidulieu();
        //    btnCuoi.Enabled = true;
        //    btnSau.Enabled = true;
        //}

        //private void btnSau_Click(object sender, EventArgs e)
        //{
        //    this.BindingContext[grdPhanCong.DataSource].Position = vitri + 1;
        //    Hienthidulieu();
        //    btnDau.Enabled = true;
        //    btnTruoc.Enabled = true;
        //}

        //private void btnCuoi_Click(object sender, EventArgs e)
        //{
        //    this.BindingContext[grdPhanCong.DataSource].Position = tong - 1;
        //    Hienthidulieu();
        //    btnCuoi.Enabled = false;
        //    btnSau.Enabled = false;
        //    btnDau.Enabled = true;
        //    btnTruoc.Enabled = true;
        //}

        private void btnNamHoc_Click(object sender, EventArgs e)
        {
            if (m_frmNamhoc == null || m_frmNamhoc.IsDisposed)
            {
                m_frmNamhoc = new frmNamHoc();
                m_frmNamhoc.FormBorderStyle = FormBorderStyle.None;
                m_frmNamhoc.MdiParent = frmMain.ActiveForm;
                m_frmNamhoc.Show();
            }
            else
                m_frmNamhoc.Activate(); 
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
             if (m_frmLophoc == null || m_frmLophoc.IsDisposed)
            {
                m_frmLophoc = new frmLopHoc();
                m_frmLophoc.FormBorderStyle = FormBorderStyle.None;
                m_frmLophoc.MdiParent = frmMain.ActiveForm;
                m_frmLophoc.Show();
            }
            else
                m_frmLophoc.Activate();
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            if (m_frmMonhoc == null || m_frmMonhoc.IsDisposed)
            {
                m_frmMonhoc = new frmMonHoc();
                m_frmMonhoc.FormBorderStyle = FormBorderStyle.None;
                m_frmMonhoc.MdiParent = frmMain.ActiveForm;
                m_frmMonhoc.Show();
            }
            else
                m_frmMonhoc.Activate();
        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            if (m_frmGiaovien == null || m_frmGiaovien.IsDisposed)
            {
                m_frmGiaovien = new frmGiaoVien();
                m_frmGiaovien.FormBorderStyle = FormBorderStyle.None;
                m_frmGiaovien.MdiParent = frmMain.ActiveForm;
                m_frmGiaovien.Show();
            }
            else
                m_frmGiaovien.Activate();
        }

        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void navigationPanePanel2_Click(object sender, EventArgs e)
        {

        }

        private void optMaGV_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTim.Text == "")
            {
                MessageBox.Show("Chưa nhập từ khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (optTenLop.Checked == true)
                {
                    lop_dto.Tenlop = txtTim.Text;
                    giaovien_dto.Tengv = "";
                    if (giangday_bus.timPhanCong(giaovien_dto, lop_dto).Rows.Count > 0)
                    {
                        grdPhanCong.DataSource = giangday_bus.timPhanCong(giaovien_dto, lop_dto);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy ! Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (optTenGV.Checked == true)
                    {
                        giaovien_dto.Tengv = txtTim.Text;
                        lop_dto.Tenlop = "";
                        if (giangday_bus.timPhanCong(giaovien_dto, lop_dto).Rows.Count > 0)
                        {
                            grdPhanCong.DataSource = giangday_bus.timPhanCong(giaovien_dto, lop_dto);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy ! Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Phải chọn Tìm kiếm theo Tên Giáo Viên hoặc tìm theo Tên Lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            anHienButton(false);
            Delete();
        }

        private void frmPhanCong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
