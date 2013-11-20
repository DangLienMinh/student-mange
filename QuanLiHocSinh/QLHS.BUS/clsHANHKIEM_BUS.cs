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
        private clsHOCKY_DAO hocKy_DAO;
        private clsNAMHOC_DAO namHoc_DAO;
        private clsKHOI_DAO khoi_DAO;
        private clsLOP_DAO lop_DAO;
        private clsLOAIHANHKIEM_DAO loaiHanhKiem_DAO;
        private clsHOCSINH_DAO hocSinh_DAO;
        private clsHANHKIEM_DAO hanhKiem_DAO;
        private clsHANHKIEM_DTO hanhKiem_DTO;

        public clsHANHKIEM_BUS()
        {
            hocKy_DAO = new clsHOCKY_DAO();
            namHoc_DAO = new clsNAMHOC_DAO();
            khoi_DAO = new clsKHOI_DAO();
            lop_DAO = new clsLOP_DAO();
            loaiHanhKiem_DAO = new clsLOAIHANHKIEM_DAO();
            hocSinh_DAO = new clsHOCSINH_DAO();
            hanhKiem_DAO = new clsHANHKIEM_DAO();
        }
        public void hienThiCboHK(ComboBoxEx comboBox)
        {
            comboBox.DataSource = hocKy_DAO.danhSachHocKy();
            comboBox.DisplayMember = "TENHK";
            comboBox.ValueMember = "MAHK";
            comboBox.SelectedValue = "HK1";
        }
        public void hienThiCboNamHoc(ComboBoxEx comboBox)
        {
            comboBox.DataSource = namHoc_DAO.danhSachNamHoc();
            comboBox.DisplayMember = "TENNH";
            comboBox.ValueMember = "MANH";
        }
        public void hienThiLopHoc(AdvTree treKhoi,ComboBoxEx cboNamhoc)
        {
            DataTable dsKhoi = new DataTable();
            DataTable dsLop = new DataTable();
            dsKhoi = khoi_DAO.danhSachKhoi();
            for (int i = 0; i < dsKhoi.Rows.Count; i++)
            {
                if (dsKhoi.Rows[i]["MAKHOI"].ToString() != "")
                {
                    Node k = new Node();
                    k.Text = dsKhoi.Rows[i]["TENKHOI"].ToString();
                    k.Name = dsKhoi.Rows[i]["MAKHOI"].ToString();
                    treKhoi.Nodes.Add(k);
                    
                    string makhoi=dsKhoi.Rows[i]["MAKHOI"].ToString();
                    dsLop = lop_DAO.danhsachLopMAKHOI(makhoi,cboNamhoc.SelectedValue.ToString());
                    for (int j = 0; j < dsLop.Rows.Count; j++)
                    {
                        if (dsLop.Rows[j]["MALOP"].ToString() != "")
                        {
                            Node k1 = new Node();
                            k1.Text = dsLop.Rows[j]["TENLOP"].ToString();
                            k1.Name = dsLop.Rows[j]["MALOP"].ToString();
                            treKhoi.Nodes[i].Nodes.Add(k1);
                        }
                    }
                }
            }
        }
        public void hienThiCboLoaiHK(DataGridViewComboBoxColumn clnHanhKiem)//ComboboxColumnHanhKiem
        {
            clnHanhKiem.DataSource = loaiHanhKiem_DAO.danhsachLoaiHK();
            clnHanhKiem.DisplayMember = "TENLHK";
            clnHanhKiem.ValueMember = "MALHK";
            clnHanhKiem.DataPropertyName = "MALHK";
        }
        public void hienThiCboClnNamHoc(DataGridViewComboBoxColumn clnNamHoc)
        {
            clnNamHoc.DataSource = namHoc_DAO.danhSachNamHoc();
            clnNamHoc.DisplayMember = "TENNH";
            clnNamHoc.ValueMember = "MANH";
            clnNamHoc.DataPropertyName = "MANH";
        }
        public void hienThiCboClnHocKy(DataGridViewComboBoxColumn clnHocKy)
        {
            clnHocKy.DataSource = hocKy_DAO.danhSachHocKy();
            clnHocKy.DisplayMember = "TENHK";
            clnHocKy.ValueMember = "MAHK";
            clnHocKy.DataPropertyName = "MAHK";
        }
        public void hienThiCboLopHoc(clsLOP_DTO lop_dto,ComboBoxEx cboLop)
        {
            cboLop.DataSource = lop_DAO.danhSachLopTheoNamHoc(lop_dto);
            cboLop.DisplayMember = "TENLOP";
            cboLop.ValueMember = "MALOP";
        }
        public void hienThiCboHanhKiem(ComboBoxEx cboHanhKiem)
        {
            cboHanhKiem.DataSource = loaiHanhKiem_DAO.danhsachLoaiHK();
            cboHanhKiem.DisplayMember = "TENLHK";
            cboHanhKiem.ValueMember = "MALHK";
        }

        

        public void hienThiCboHocSinhTatCa(string maLop,string maNH,string maHK,ComboBoxEx cboHocsinh)
        {
            cboHocsinh.DataSource = hocSinh_DAO.danhSachHocSinhMALOPMANHMAHKTatCa(maLop, maNH, maHK);
            cboHocsinh.DisplayMember = "TENHS";
            cboHocsinh.ValueMember = "MAHS";
        }

        public DataTable danhSachHocSinhMALOPMANHMAHKChuaNhap(string maLop, string maNH, string maHK)
        {
            return hocSinh_DAO.danhSachHocSinhMALOPMANHMAHKChuaNhap(maLop, maNH, maHK);
        }
        public void themHanhKiem(clsHANHKIEM_DTO hanhKiem)
        {
            hanhKiem_DAO.ThemHanhKiem(hanhKiem);
        }
        public void suaHanhKiem(clsHANHKIEM_DTO hanhKiem)
        {
            hanhKiem_DAO.suaHanhKiem(hanhKiem);
        }
        public void xoaHanhKiem(clsHANHKIEM_DTO hanhKiem)
        {
            hanhKiem_DAO.xoaHanhKiem(hanhKiem);
        }
        
        public DataTable danhSachHanhKiem(string maNH, string maLop, string maHK)
        {
            return hanhKiem_DAO.danhsachHanhKiem(maNH, maLop, maHK);
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
            temp = hanhKiem_DAO.hanhKiemTheoHocKiNamHoc(hanhKiem_DTO);
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
