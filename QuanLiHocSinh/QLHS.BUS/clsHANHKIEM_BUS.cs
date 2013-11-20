using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QLHS.DAO;
using QLHS.DTO;
using DevComponents.AdvTree;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
namespace QLHS.BUS
{
    public class clsHANHKIEM_BUS
    {
        private clsHOCKY_DAO hocky;
        private clsNAMHOC_DAO namhoc;
        private clsKHOI_DAO khoi_dao;
        private clsLOP_DAO lop;
        private clsLOAIHANHKIEM_DAO loaihk;
        private clsHOCSINH_DAO hocsinh;
        private clsHANHKIEM_DAO hanhkiem_dao;
        private clsHANHKIEM_DTO hanhKiem_DTO;

        public clsHANHKIEM_BUS()
        {
            hocky = new clsHOCKY_DAO();
            namhoc = new clsNAMHOC_DAO();
            khoi_dao = new clsKHOI_DAO();
            lop = new clsLOP_DAO();
            loaihk = new clsLOAIHANHKIEM_DAO();
            hocsinh = new clsHOCSINH_DAO();
            hanhkiem_dao = new clsHANHKIEM_DAO();
        }
        public void hienThicboHK(ComboBoxEx comboBox)
        {
            comboBox.DataSource = hocky.danhSachHocKy();
            comboBox.DisplayMember = "TENHK";
            comboBox.ValueMember = "MAHK";
            comboBox.SelectedValue = "HK1";
        }
        public void hienthicboNamHoc(ComboBoxEx comboBox)
        {
            comboBox.DataSource = namhoc.danhSachNamHoc();
            comboBox.DisplayMember = "TENNH";
            comboBox.ValueMember = "MANH";
        }
        public void hienthiLophoc(AdvTree trKhoi,ComboBoxEx cboNamhoc)
        {
            DataTable dsKhoi = new DataTable();
            DataTable dsLop = new DataTable();
            dsKhoi = khoi_dao.danhSachKhoi();
            for (int i = 0; i < dsKhoi.Rows.Count; i++)
            {
                if (dsKhoi.Rows[i]["MAKHOI"].ToString() != "")
                {
                    Node k = new Node();
                    k.Text = dsKhoi.Rows[i]["TENKHOI"].ToString();
                    k.Name = dsKhoi.Rows[i]["MAKHOI"].ToString();
                    trKhoi.Nodes.Add(k);
                    //TreeNode k2 = new TreeNode();
                    
                    string Makhoi=dsKhoi.Rows[i]["MAKHOI"].ToString();
                    dsLop = lop.danhsachLopMAKHOI(Makhoi,cboNamhoc.SelectedValue.ToString());
                    for (int j = 0; j < dsLop.Rows.Count; j++)
                    {
                        if (dsLop.Rows[j]["MALOP"].ToString() != "")
                        {
                            Node k1 = new Node();
                            k1.Text = dsLop.Rows[j]["TENLOP"].ToString();
                            k1.Name = dsLop.Rows[j]["MALOP"].ToString();
                            trKhoi.Nodes[i].Nodes.Add(k1);
                        }
                    }
                }
            }
        }
        public void hienthiCboLoaiHK(DataGridViewComboBoxColumn clnHanhkiem)//ComboboxColumnHanhKiem
        {
            clnHanhkiem.DataSource = loaihk.danhsachLoaiHK();
            clnHanhkiem.DisplayMember = "TENLHK";
            clnHanhkiem.ValueMember = "MALHK";
            clnHanhkiem.DataPropertyName = "MALHK";
        }
        public void hienthiCboClnNamHoc(DataGridViewComboBoxColumn clnNamHoc)
        {
            clnNamHoc.DataSource = namhoc.danhSachNamHoc();
            clnNamHoc.DisplayMember = "TENNH";
            clnNamHoc.ValueMember = "MANH";
            clnNamHoc.DataPropertyName = "MANH";
        }
        public void hienthiCboClnHocKy(DataGridViewComboBoxColumn clnHocKy)
        {
            clnHocKy.DataSource = hocky.danhSachHocKy();
            clnHocKy.DisplayMember = "TENHK";
            clnHocKy.ValueMember = "MAHK";
            clnHocKy.DataPropertyName = "MAHK";
        }
        public void hienthiCboLopHoc(clsLOP_DTO lop_dto,ComboBoxEx cboLop)
        {
            cboLop.DataSource = lop.danhSachLopTheoNamHoc(lop_dto);
            cboLop.DisplayMember = "TENLOP";
            cboLop.ValueMember = "MALOP";
        }
        public void hienthiCboHanhKiem(ComboBoxEx cbohanhKiem)
        {
            cbohanhKiem.DataSource = loaihk.danhsachLoaiHK();
            cbohanhKiem.DisplayMember = "TENLHK";
            cbohanhKiem.ValueMember = "MALHK";
        }

        

        public void hienthiCboHocSinhTatCa(string malop,string manh,string mahk,ComboBoxEx cboHocsinh)
        {
            cboHocsinh.DataSource = hocsinh.danhsachHocSinhMALOPMANHMAHKTatCa(malop, manh, mahk);
            cboHocsinh.DisplayMember = "TENHS";
            cboHocsinh.ValueMember = "MAHS";
        }

        public DataTable danhsachHocsinhMALOPMANHMAHKChuaNhap(string malop, string manh, string mahk)
        {
            return hocsinh.danhsachHocSinhMALOPMANHMAHKChuaNhap(malop, manh, mahk);
        }
        public void themHanhKiem(clsHANHKIEM_DTO hanhkiem)
        {
            hanhkiem_dao.ThemHanhKiem(hanhkiem);
        }
        public void suaHanhKiem(clsHANHKIEM_DTO hanhkiem)
        {
            hanhkiem_dao.suaHanhKiem(hanhkiem);
        }
        public void xoaHanhKiem(clsHANHKIEM_DTO hanhkiem)
        {
            hanhkiem_dao.xoaHanhKiem(hanhkiem);
        }
        
        public DataTable danhsachHanhKiem(string manh, string malop, string mahk)
        {
            return hanhkiem_dao.danhsachHanhKiem(manh, malop, mahk);
        }

        //FORM KET QUA
        public void hanhKiemTheoHocKiNamHoc(ComboBoxEx cboMaNH, DataGridViewX grdHanhKiem)
        {
            string ketQua = "";
            string namHoc = cboMaNH.SelectedValue.ToString();
            foreach (DataGridViewRow row in grdHanhKiem.Rows)
            {
                if (row.Cells["MAHS"].Value != null)
                {
                    string maHS = row.Cells["MAHS"].Value.ToString();


                    string hanhKiemHK1 = hanhKiemTheoHocKiNamHoc(maHS, "HK1", namHoc);
                    string hanhKiemHK2 = hanhKiemTheoHocKiNamHoc(maHS, "HK2", namHoc);
                    ketQua = hanhKiemHK2;
                }
                row.Cells["HANHKIEM"].Value = ketQua;
            }
            
        }

        public string hanhKiemTheoHocKiNamHoc(string maHS, string maHK, string maNH)
        {
            string result = "";
            DataTable temp = new DataTable();
            hanhKiem_DTO = new clsHANHKIEM_DTO();
            hanhKiem_DTO.Mahk = maHK;
            hanhKiem_DTO.Manh = maNH;
            hanhKiem_DTO.Mahs = maHS;
            temp = hanhkiem_dao.hanhKiemTheoHocKiNamHoc(hanhKiem_DTO);
            if (temp.Rows.Count > 1)
            {
                foreach (DataRow row in temp.Rows)
                {
                    result = row[0].ToString();
                }
            }
            return result;
        }
    }
}
