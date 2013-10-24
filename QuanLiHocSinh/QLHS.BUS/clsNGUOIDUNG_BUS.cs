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
            
            //comboBox.Items.Add("Nam");
            //comboBox.Items.Add("Nữ");
            //comboBox.SelectedItem = "Nam";
        }

        public void hienThiDanhSach(DataGridViewX grdNguoiDung)
        {
            tblNguoiDung = nguoiDung_DAO.danhSachNguoiDung();
            grdNguoiDung.DataSource=tblNguoiDung;

        }

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

        //add dong vua them vao
        public void themDong() 
        {
            tblNguoiDung.Rows.Add(getDatarow());
        }

        public void xoaDong(DataGridViewX grdNguoiDung,string MaND)
        {
            DataRow row = tblNguoiDung.Select("MAND='" + MaND + "'")[0];
            row.Delete();
            grdNguoiDung.DataSource = tblNguoiDung;
        }

        public void suaDataGrid(DataGridViewX grdNguoiDung)
        {
            foreach (DataGridViewRow row1 in grdNguoiDung.Rows)
            {
                if (row1.Cells["MAND"].Value != null)
                {
                    if (string.Compare(row1.Cells["MAND"].Value.ToString().Trim(), nguoiDung_DTO.Mand.Trim()) == 0)
                    {
                        row1.Cells["TENND"].Value = nguoiDung_DTO.Tennd;
                        row1.Cells["MALND"].Value = nguoiDung_DTO.Malnd;
                        row1.Cells["TENDN"].Value = nguoiDung_DTO.Tendn;
                        row1.Cells["MATKHAU"].Value = nguoiDung_DTO.Matkhau;
                    }
                }
            }
        }
    }
}
