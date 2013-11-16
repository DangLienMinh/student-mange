using System;
using System.Collections.Generic;
using System.Text;
using QLHS.DAO;
using QLHS.DTO;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;
using System.Windows.Forms;
using System.Data;

namespace QLHS.BUS
{
    public class clsNGUOIDUNG_BUS
    {
        clsNGUOIDUNG_DAO nguoiDung_DAO;
        clsLOAINGUOIDUNG_DAO loaiNguoiDung_DAO;
        clsNGUOIDUNG_DTO nguoiDung_DTO;
        DataTable tblNguoiDung;
        private DataRow dr;
        
        public clsNGUOIDUNG_BUS() 
        {
            nguoiDung_DAO = new clsNGUOIDUNG_DAO();
            loaiNguoiDung_DAO = new clsLOAINGUOIDUNG_DAO();
            tblNguoiDung = new DataTable();
        }

        public void hienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = loaiNguoiDung_DAO.danhSachLoaiNguoiDung();
            comboBox.DisplayMember = "TENLND";
            comboBox.ValueMember = "MALND";         
        }

        public DataTable hienThiDanhSach()
        {
            tblNguoiDung = nguoiDung_DAO.danhSachNguoiDung();
            return tblNguoiDung;
        }

        //tạo mã người dùng
        public string hienThiSoNguoi()
        {
            string result;
            int temp = nguoiDung_DAO.soNguoiDung() + 1;
            if (temp<10)
            {
                result = "00" + temp.ToString();
            }
            else if (temp>=10&&temp<100)
            {
                result = "0" + temp.ToString();
            }
            else
            {
                result = temp.ToString();
            }
            return result;
        }

        //public void timGVMaND(DataGridViewX grdNguoiDung, string maND)
        //{
        //    nguoiDung_DTO = new clsNGUOIDUNG_DTO();
        //    nguoiDung_DTO.Mand = maND;
        //    tblNguoiDung = nguoiDung_DAO.timGVMaND(nguoiDung_DTO);
        //    grdNguoiDung.DataSource = tblNguoiDung;
        //}

        //public void timGVTenND(DataGridViewX grdNguoiDung,string tenGV)
        //{
        //    nguoiDung_DTO = new clsNGUOIDUNG_DTO();
        //    nguoiDung_DTO.Tengv = tenGV;
        //    tblNguoiDung = nguoiDung_DAO.timGVTenND(nguoiDung_DTO);
        //    grdNguoiDung.DataSource = tblNguoiDung;
        //}

        public void xoaNguoiDung(string maND) 
        {
            nguoiDung_DTO=new clsNGUOIDUNG_DTO();
            nguoiDung_DTO.Mand = maND;
            nguoiDung_DAO.xoaNguoiDung(nguoiDung_DTO);        
        }

        public void themNguoiDung(string maND,string TenND, string MaLND,string TenDN,string MatKhau)
        {
            nguoiDung_DTO = new clsNGUOIDUNG_DTO();
            nguoiDung_DTO.Mand = maND;
            nguoiDung_DTO.Tennd = TenND;
            nguoiDung_DTO.Malnd = MaLND;
            nguoiDung_DTO.Tendn = TenDN;
            nguoiDung_DTO.Matkhau = MatKhau;
            nguoiDung_DAO.themNguoiDung(nguoiDung_DTO);
        }

        public void suaNguoiDung(string maND, string TenND, string MaLND, string TenDN, string MatKhau)
        {
            nguoiDung_DTO = new clsNGUOIDUNG_DTO();
            nguoiDung_DTO.Mand = maND;
            nguoiDung_DTO.Tennd = TenND;
            nguoiDung_DTO.Malnd = MaLND;
            nguoiDung_DTO.Tendn = TenDN;
            nguoiDung_DTO.Matkhau = MatKhau;
            nguoiDung_DAO.suaNguoiDung(nguoiDung_DTO);
        }

        public void suaMatKhau(string TenDN, string MatKhau)
        {
            nguoiDung_DTO = new clsNGUOIDUNG_DTO();
            nguoiDung_DTO.Tendn = TenDN;
            nguoiDung_DTO.Matkhau = MatKhau;
            nguoiDung_DAO.suaMatKhau(nguoiDung_DTO);
        }

        
        private DataRow getDatarow()
        {
            dr = tblNguoiDung.NewRow();
            dr["MAND"] = nguoiDung_DTO.Mand;
            dr["TENND"] = nguoiDung_DTO.Tennd;
            dr["MALND"] =  nguoiDung_DTO.Malnd;
            dr["TENDN"] = nguoiDung_DTO.Tendn;
            dr["MATKHAU"] = nguoiDung_DTO.Matkhau;
            return dr;
        }

        //thêm dòng vừa được thêm vào table người dùng
        public void themDong() 
        {
            tblNguoiDung.Rows.Add(getDatarow());
        }

        //xóa người dùng trùng với mã người dùng trên table người dùng
        public void xoaDong(DataGridViewX grdNguoiDung,string MaND)
        {
            DataRow row = tblNguoiDung.Select("MAND='" + MaND + "'")[0];
            row.Delete();
        }

        public void suaDataGrid()
        {
            foreach (DataRow row1 in tblNguoiDung.Rows)
            {
                if (row1["MAND"] != null)
                {
                    if (string.Compare(row1["MAND"].ToString().Trim(), nguoiDung_DTO.Mand.Trim()) == 0)
                    {
                        row1["TENND"] = nguoiDung_DTO.Tennd;
                        row1["MALND"] = nguoiDung_DTO.Malnd;
                        row1["TENDN"] = nguoiDung_DTO.Tendn;
                        row1["MATKHAU"] = nguoiDung_DTO.Matkhau;
                    }
                }
            }
        }

        public int DangNhap(string tenDN, string matKhau,clsNGUOIDUNG_DTO nguoiDung_DTO)
        {

            DataTable nguoiDung = nguoiDung_DAO.danhSachNguoiDungTheoTENDN(tenDN);

            if (nguoiDung.Rows.Count == 0)
                return 0;
            //lấy mật khẩu hệ thống
            String matKhauHT = nguoiDung.Rows[0]["MATKHAU"].ToString();

            if (matKhauHT != matKhau)
                return 1;
            else
            {
                nguoiDung_DTO.Tendn = nguoiDung.Rows[0]["TenND"].ToString();
                nguoiDung_DTO.Malnd = nguoiDung.Rows[0]["MALND"].ToString();
                nguoiDung_DTO.Tennd = nguoiDung.Rows[0]["TENND"].ToString();
                return 2;
            }
        }
    }
}
