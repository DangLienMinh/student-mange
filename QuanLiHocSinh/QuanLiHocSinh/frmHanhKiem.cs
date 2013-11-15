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
        private clsHANHKIEM_DTO hanhkiem_dto;
        private clsHOCKY_DTO hocky_dto;
        private clsNAMHOC_DTO namhoc_dto;
        private clsHANHKIEM_BUS hanhkiem_bus;
        private clsLOP_DTO lop_dto;
        private Boolean flaglist=false;
        public frmHanhKiem()
        {
            InitializeComponent();
            hanhkiem_dto = new clsHANHKIEM_DTO();
            hanhkiem_bus = new clsHANHKIEM_BUS();
            hocky_dto = new clsHOCKY_DTO();
            namhoc_dto = new clsNAMHOC_DTO();
            lop_dto = new clsLOP_DTO();
        }
        private void frmHanhKiem_Load(object sender, EventArgs e)
        {
            treKhoi.Nodes.Clear();
            hanhkiem_bus.hienThicboHK(cboHocKy);//Hien thi danh sach hoc ky len combobox tab nhập theo lớp
            hanhkiem_bus.hienThicboHK(cboHocKy1);//Hien thi danh sach hoc ky len combobox tab nhập theo học sinh
            hanhkiem_bus.hienthicboNamHoc(cboNamHoc);//Hien thi danh sach hoc ky len combobox tab nhập theo lớp
            hanhkiem_bus.hienthicboNamHoc(cboNamHoc1);//HIên thi danh sach hoc ky len combobo tab nhập điểm theo học sinh
            lop_dto.Manh = cboNamHoc1.SelectedValue.ToString();
            hanhkiem_bus.hienthiCboLopHoc(lop_dto, cboLop1);
            hanhkiem_bus.hienthiCboHocSinh(cboLop1.SelectedValue.ToString(), cboNamHoc1.SelectedValue.ToString(), cboHocKy1.SelectedValue.ToString(), cboHocSinh1);
            hanhkiem_bus.hienthiCboHanhKiem(cboHanhKiem1);
            hanhkiem_bus.hienthiCboLoaiHK(MALHK);//Hien thi TenHanKiem Len Cobobox trong gridview cho nguoi dung chon
            hanhkiem_bus.hienthiCboClnNamHoc(MANH);//Hien thi Ten Nam Hoc Thay vi MANH TREN COMBOX BOX
            hanhkiem_bus.hienthiCboClnHocKy(MAHK);//Hien thi Ten HK thay vi hien thi MAHK ten combobox
        }

        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void treKhoi_Click(object sender, EventArgs e)
        {

        }

        private void treKhoi_NodeClick(object sender, DevComponents.AdvTree.TreeNodeMouseEventArgs e)
        {
            string malop;
            string manh;
            string mahk;
            MALHK.DisplayStyleForCurrentCellOnly = false;
            manh = cboNamHoc.SelectedValue.ToString();
            mahk = cboHocKy.SelectedValue.ToString();
            malop = treKhoi.SelectedNode.Name;
            hanhkiem_dto.Malop=malop;
            if (malop.Substring(0, 1).ToString().Trim() == "L")//Kiểm tra xem node vừa click có phải là node lớp không,nếu phải thì thực thi dòng lệnh bên trong
            {
                try
                {
                    if (flaglist != true)//Neu btnDanhsach duoc nhat thi khong hien thi danh sach chua nhap hanh kiem len
                    {
                        grdHanhKiemChung.DataSource = hanhkiem_bus.danhsachHocsinhMALOPMANHMAHK(treKhoi.SelectedNode.Name.ToString(), cboNamHoc.SelectedValue.ToString(), cboHocKy.SelectedValue.ToString());
                    }
                    hanhkiem_dto.Manh = manh;
                    hanhkiem_dto.Mahk = mahk;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void grdHanhKiemChung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnLuulai_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Bạn có chắc chắn muốn lưu lại", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                int khoa = 0;
                foreach (DataGridViewRow row in grdHanhKiemChung.Rows)
                {
                    if (row.Cells["MAHS"].Value != null)
                    {
                        
                        try
                        {
                            hanhkiem_dto.Malhk = row.Cells["MALHK"].Value.ToString();
                            hanhkiem_dto.Mahs = row.Cells["MAHS"].Value.ToString();
                            hanhkiem_bus.themHanhKiem(hanhkiem_dto);
                            khoa++;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                hanhkiem_dto.Mahs = "";
                hanhkiem_dto.Malhk = "";
                hanhkiem_dto.Manh = "";
                hanhkiem_dto.Mahk = "";
            }
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            btnLuulai.Enabled = false;
            flaglist = true;
            MALHK.DisplayStyleForCurrentCellOnly = true;
            grdHanhKiemChung.DataSource = hanhkiem_bus.danhsachHanhKiem(cboNamHoc.SelectedValue.ToString(), treKhoi.SelectedNode.Name.ToString(), cboHocKy.SelectedValue.ToString());
            
        }
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            btnLuulai.Enabled = true;
            flaglist = false;
            
        }

        private void cboNamHoc1_SelectedValueChanged(object sender, EventArgs e)
        {
            lop_dto.Manh = cboNamHoc1.SelectedValue.ToString();
            hanhkiem_bus.hienthiCboLopHoc(lop_dto, cboLop1);
            //hanhkiem_bus.hienthiCboHocSinh(cboLop1.SelectedValue.ToString(), cboNamHoc1.SelectedValue.ToString(), cboHocKy1.SelectedValue.ToString(), cboHocSinh1);
        }

        private void cboNamHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            treKhoi.Nodes.Clear();
            hanhkiem_bus.hienthiLophoc(treKhoi, cboNamHoc);//Hiển thị danh sách lớp theo năm học lên treeview
        }

        private void cboHocKy1_SelectedValueChanged(object sender, EventArgs e)
        {
            //hanhkiem_bus.hienthiCboHocSinh(cboLop1.SelectedValue.ToString(), cboNamHoc1.SelectedValue.ToString(), cboHocKy1.SelectedValue.ToString(), cboHocSinh1);
        }

        private void cboLop1_SelectedValueChanged(object sender, EventArgs e)
        {
            hanhkiem_bus.hienthiCboHocSinh(cboLop1.SelectedValue.ToString(), cboNamHoc1.SelectedValue.ToString(), cboHocKy1.SelectedValue.ToString(), cboHocSinh1);
        }
    }
}
