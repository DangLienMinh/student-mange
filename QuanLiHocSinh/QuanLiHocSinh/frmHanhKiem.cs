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
    public partial class frmHanhKiem : DevComponents.DotNetBar.Office2007Form
    {
        private BindingSource bsChung;
        private BindingSource bsRieng;
        private clsHOCSINH_BUS hocSinh_BUS;
        private clsHANHKIEM_DTO hanhkiem_dto;
        private clsHOCKY_DTO hocky_dto;
        private clsNAMHOC_DTO namhoc_dto;
        private clsHANHKIEM_BUS hanhkiem_bus;
        private clsLOP_DTO lop_dto;
        private Boolean flagInsert;
        private Boolean flagDelete;
        private DataGridViewColumn cbo;
        public frmHanhKiem()
        {
            InitializeComponent();
            hanhkiem_dto = new clsHANHKIEM_DTO();
            hanhkiem_bus = new clsHANHKIEM_BUS();
            hocky_dto = new clsHOCKY_DTO();
            namhoc_dto = new clsNAMHOC_DTO();
            lop_dto = new clsLOP_DTO();
            hocSinh_BUS = new clsHOCSINH_BUS();
            flagInsert = false;
            flagDelete = false;
            
        }
        private void frmHanhKiem_Load(object sender, EventArgs e)
        {
            treKhoi.Nodes.Clear();
            hanhkiem_bus.hienThiCboHK(cboHocKy);//Hien thi danh sach hoc ky len combobox tab nhập theo lớp
            hanhkiem_bus.hienThiCboHK(cboHocKy1);//Hien thi danh sach hoc ky len combobox tab nhập theo học sinh
            hanhkiem_bus.hienThiCboNamHoc(cboNamHoc);//Hien thi danh sach hoc ky len combobox tab nhập theo lớp
            hanhkiem_bus.hienThiCboNamHoc(cboNamHoc1);//HIên thi danh sach hoc ky len combobo tab nhập điểm theo học sinh
            hanhkiem_bus.hienThiCboHanhKiem(cboHanhKiem1);
            hanhkiem_bus.hienThiCboLoaiHK(MALHK);//Hien thi TenHanKiem Len Cobobox trong gridview cho nguoi dung chon
            hanhkiem_bus.hienThiCboClnNamHoc(MANH);//Hien thi Ten Nam Hoc Thay vi MANH TREN COMBOX BOX
            hanhkiem_bus.hienThiCboClnHocKy(MAHK);//Hien thi Ten HK thay vi hien thi MAHK ten combobox
        }
        private void treKhoi_NodeClick(object sender, DevComponents.AdvTree.TreeNodeMouseEventArgs e)
        {
            if (treKhoi.SelectedNode.Name.Substring(0, 1).ToString().Trim() == "L")//Kiểm tra xem node vừa click có phải là node lớp không,nếu phải thì thực thi dòng lệnh bên trong
            {
                try
                {
                    bidingSourceHKChung(hanhkiem_bus.danhSachHocSinhMALOPMANHMAHKChuaNhap(treKhoi.SelectedNode.Name.ToString(), cboNamHoc.SelectedValue.ToString(), cboHocKy.SelectedValue.ToString()));
                    //grdHanhKiemChung.DataSource = hanhkiem_bus.danhSachHocSinhMALOPMANHMAHKChuaNhap(treKhoi.SelectedNode.Name.ToString(), cboNamHoc.SelectedValue.ToString(), cboHocKy.SelectedValue.ToString());
                    if (grdHanhKiemChung.Columns.Count==4)
                    {
                        grdHanhKiemChung.Columns.Insert(grdHanhKiemChung.Columns.Count,cbo);
                        hanhkiem_bus.hienThiCboLoaiHK(MALHK);//Hien thi TenHanKiem Len Cobobox trong gridview cho nguoi dung chon
                    }
                    else
                    {
                        cbo = grdHanhKiemChung.Columns["MALHK"];
                    }
                    hanhkiem_dto.Manh = cboNamHoc.SelectedValue.ToString();
                    hanhkiem_dto.Mahk = cboHocKy.SelectedValue.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnLuulai_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Bạn có chắc chắn muốn lưu lại", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                int dem = 0;
                foreach (DataGridViewRow row in grdHanhKiemChung.Rows)
                {
                    if (row.Cells["MAHS"].Value != null)
                    {
                        
                        try
                        {
                            hanhkiem_dto.Malhk = row.Cells["MALHK"].Value.ToString();
                            hanhkiem_dto.Mahs = row.Cells["MAHS"].Value.ToString();
                            int test = hanhkiem_bus.TimHanhKiemHS(hanhkiem_dto).Rows.Count;
                            if (hanhkiem_bus.TimHanhKiemHS(hanhkiem_dto).Rows.Count == 0)
                            {
                                hanhkiem_bus.themHanhKiem(hanhkiem_dto);
                                dem++;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                 MessageBox.Show("Lưu thành công hạnh kiểm cho "+dem.ToString()+" Học sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                HuyBoDuLieu();
                
            }
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            if (treKhoi.SelectedNode == null || treKhoi.SelectedNode.Parent == null)
            {
                MessageBox.Show("Bạn phải chon một lớp");
            }
            else
            {
                btnLuulai.Enabled = false;
                //grdHanhKiemChung.DataSource = hanhkiem_bus.danhSachHanhKiem(cboNamHoc.SelectedValue.ToString(), treKhoi.SelectedNode.Name.ToString(), cboHocKy.SelectedValue.ToString());
                bidingSourceHKChung(hanhkiem_bus.danhSachHanhKiem(cboNamHoc.SelectedValue.ToString(), treKhoi.SelectedNode.Name.ToString(), cboHocKy.SelectedValue.ToString()));
            }
           
        }

        //hàm bidingSourceHKChung đặt binding source=datatable sao đó cho nó dính vào datagrid
        private void bidingSourceHKChung(DataTable table)
        {
            //binding source
            bsChung = new BindingSource();
            bsChung.DataSource = table;
            grdHanhKiemChung.DataSource = bsChung;
            bnaHanhKiemChung.BindingSource = bsChung;
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            btnLuulai.Enabled = true;
            if ((MessageBox.Show("Bạn có chắc chắn muốn Cập nhật", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                int dem = 0;
                foreach (DataGridViewRow row in grdHanhKiemChung.Rows)
                {
                    if (row.Cells["MAHS"].Value != null)
                    {

                        try
                        {
                            hanhkiem_dto.Malhk = row.Cells["MALHK"].Value.ToString();
                            hanhkiem_dto.Mahs = row.Cells["MAHS"].Value.ToString();
                            hanhkiem_bus.suaHanhKiem(hanhkiem_dto);
                            dem++;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                MessageBox.Show("Cập nhật thành công hạnh kiểm cho " + dem.ToString() + " Học sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grdHanhKiemChung.DataSource = hanhkiem_bus.danhSachHanhKiem(cboNamHoc.SelectedValue.ToString(), treKhoi.SelectedNode.Name.ToString(), cboHocKy.SelectedValue.ToString());
            }
        }

        private void cboNamHoc1_SelectedValueChanged(object sender, EventArgs e)
        {
            lop_dto.Manh = cboNamHoc1.SelectedValue.ToString();
            hanhkiem_bus.hienThiCboLopHoc(lop_dto, cboLop1);
        }

        private void cboNamHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            treKhoi.Nodes.Clear();
            hanhkiem_bus.hienThiLopHoc(treKhoi, cboNamHoc);//Hiển thị danh sách lớp theo năm học lên treeview
        }

        private void cboLop1_SelectedValueChanged(object sender, EventArgs e)
        {
            //hanhkiem_bus.hienthiCboLoaiHK(MALHK1);
            //hanhkiem_bus.hienthiCboClnHocKy(MAHK1);
            //hanhkiem_bus.hienthiCboClnNamHoc(MANH1);
            //hanhkiem_bus.hienthiCboHocSinh(cboLop1.SelectedValue.ToString(), cboNamHoc1.SelectedValue.ToString(), cboHocKy1.SelectedValue.ToString(), cboHocSinh1);
            //grdHanhKiemRieng.DataSource = hanhkiem_bus.danhsachHanhKiem(cboNamHoc1.SelectedValue.ToString(), cboLop1.SelectedValue.ToString(), cboHocKy1.SelectedValue.ToString());
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
                    update();
                }
            }
        }
        private void Insert()
        {
            flagInsert = false;
            hanhkiem_dto.Mahs = cboHocSinh1.SelectedValue.ToString();
            hanhkiem_dto.Malhk = cboHanhKiem1.SelectedValue.ToString();
            hanhkiem_dto.Mahk = cboHocKy1.SelectedValue.ToString();
            hanhkiem_dto.Manh = cboNamHoc1.SelectedValue.ToString();
            //hanhkiem_dto.Malop = cboLop1.SelectedValue.ToString();
            if (hanhkiem_bus.TimHanhKiemHS(hanhkiem_dto).Rows.Count>=1)
            {
                MessageBox.Show("Lỗi !Hạnh hiểm đã tồn tại trong database", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    hanhkiem_bus.themHanhKiem(hanhkiem_dto);
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grdHanhKiemRieng.DataSource = hanhkiem_bus.danhSachHanhKiem(cboNamHoc1.SelectedValue.ToString(), cboLop1.SelectedValue.ToString(), cboHocKy1.SelectedValue.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi !"+ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        private void update()
        {
            if (grdHanhKiemRieng.SelectedRows.Count >= 1)
            {
                hanhkiem_dto.Mahs = cboHocSinh1.SelectedValue.ToString();
                hanhkiem_dto.Malhk = cboHanhKiem1.SelectedValue.ToString();
                hanhkiem_dto.Mahk = cboHocKy1.SelectedValue.ToString();
                hanhkiem_dto.Manh = cboNamHoc1.SelectedValue.ToString();
                try
                {
                    hanhkiem_bus.suaHanhKiem(hanhkiem_dto);
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grdHanhKiemRieng.DataSource = hanhkiem_bus.danhSachHanhKiem(cboNamHoc1.SelectedValue.ToString(), cboLop1.SelectedValue.ToString(), cboHocKy1.SelectedValue.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi !" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lỗi !Phải chọn một dòng để sửa" , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Delete()
        {
            flagDelete = false;
            if (grdHanhKiemRieng.SelectedRows.Count >= 1)
            {
                hanhkiem_dto.Mahs = cboHocSinh1.SelectedValue.ToString();
                hanhkiem_dto.Mahk = cboHocKy1.SelectedValue.ToString();
                hanhkiem_dto.Manh = cboNamHoc1.SelectedValue.ToString();
                try
                {
                    hanhkiem_bus.xoaHanhKiem(hanhkiem_dto);
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grdHanhKiemRieng.DataSource = hanhkiem_bus.danhSachHanhKiem(cboNamHoc1.SelectedValue.ToString(), cboLop1.SelectedValue.ToString(), cboHocKy1.SelectedValue.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi !" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lỗi !Phải chọn một dòng để Xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            anHienButton(true);
            HuyBoDuLieu();
        }
        private void btnSau_Click(object sender, EventArgs e)
        {

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
        public void HuyBoDuLieu()
        {
            hanhkiem_dto.Mahs = "";
            hanhkiem_dto.Malhk = "";
            hanhkiem_dto.Manh = "";
            hanhkiem_dto.Mahk = "";
        }

        private void cboLop1_SelectedIndexChanged(object sender, EventArgs e)
        {
            hanhkiem_bus.hienThiCboLoaiHK(MALHK1);
            hanhkiem_bus.hienThiCboClnHocKy(MAHK1);
            hanhkiem_bus.hienThiCboClnNamHoc(MANH1);
            string mahk = cboHocKy1.SelectedValue.ToString();
            hanhkiem_bus.hienThiCboHocSinhTatCa(cboLop1.SelectedValue.ToString(), cboNamHoc1.SelectedValue.ToString(), mahk, cboHocSinh1);
             //grdHanhKiemRieng.DataSource = hanhkiem_bus.danhSachHanhKiem(cboNamHoc1.SelectedValue.ToString(), cboLop1.SelectedValue.ToString(), cboHocKy1.SelectedValue.ToString());

            //binding source
             bsRieng = new BindingSource();
             bsRieng.DataSource = hanhkiem_bus.danhSachHanhKiem(cboNamHoc1.SelectedValue.ToString(), cboLop1.SelectedValue.ToString(), cboHocKy1.SelectedValue.ToString());
             grdHanhKiemRieng.DataSource = bsRieng;
             bnaHanhKiemRieng.BindingSource = bsRieng;
        }

        private void grdHanhKiemRieng_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdHanhKiemRieng.CurrentRow.Cells["MAHS1"].Value.ToString() != "")
            {
                cboNamHoc1.SelectedValue = grdHanhKiemRieng.CurrentRow.Cells["MANH1"].Value.ToString();
                cboHocKy1.SelectedValue = grdHanhKiemRieng.CurrentRow.Cells["MAHK1"].Value.ToString();
                cboHocSinh1.SelectedValue = grdHanhKiemRieng.CurrentRow.Cells["MAHS1"].Value.ToString();
                cboHanhKiem1.SelectedValue = grdHanhKiemRieng.CurrentRow.Cells["MALHK1"].Value.ToString();
            }
            anHienButton(true);
        }

    }
}
