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
        public frmHanhKiem()
        {
            InitializeComponent();
            hanhkiem_dto = new clsHANHKIEM_DTO();
            hanhkiem_bus = new clsHANHKIEM_BUS();
            hocky_dto = new clsHOCKY_DTO();
            namhoc_dto = new clsNAMHOC_DTO();
        }
        private void frmHanhKiem_Load(object sender, EventArgs e)
        {
            treKhoi.Nodes.Clear();
            hanhkiem_bus.hienThicboHK(cboHocKy);//Hien thi danh sach hoc ky len combobox
            hanhkiem_bus.hienthicboNamHoc(cboNamHoc);//Hien thi danh sach hoc ky len combobox
            hanhkiem_bus.hienthiCboLoaiHK(MALHK);
            hanhkiem_bus.hienthiCboClnNamHoc(MANH);
            hanhkiem_bus.hienthiCboClnHocKy(MAHK);
        }

        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            treKhoi.Nodes.Clear();
            hanhkiem_bus.hienthiLophoc(treKhoi, cboNamHoc);//Hiển thị danh sách lớp theo năm học lên treeview
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
            manh = cboNamHoc.SelectedValue.ToString();
            mahk = cboHocKy.SelectedValue.ToString();
            malop = treKhoi.SelectedNode.Name;
            if (malop.Substring(0, 1).ToString().Trim() == "L")//Kiểm tra xem node vừa click có phải là node lớp không,nếu phải thì thực thi dòng lệnh bên trong
            {
                try
                {
                    grdHanhKiemChung.DataSource = hanhkiem_bus.danhsachHocsinhMALOPMANHMAHK(malop, manh, mahk);
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
    }
}
