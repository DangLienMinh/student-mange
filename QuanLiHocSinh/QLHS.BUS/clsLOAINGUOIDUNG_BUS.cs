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
    public class clsLOAINGUOIDUNG_BUS
    {
        clsLOAINGUOIDUNG_DAO loaiNguoiDung_DAO;
        clsLOAINGUOIDUNG_DTO loaiNguoiDung_DTO;
        DataTable tblLoaiNguoiDung;
        private DataRow dr;

        public clsLOAINGUOIDUNG_BUS() 
        {
            loaiNguoiDung_DAO = new clsLOAINGUOIDUNG_DAO();
            tblLoaiNguoiDung = new DataTable();
        }

        public DataTable hienThiDanhSach()
        {
            tblLoaiNguoiDung = loaiNguoiDung_DAO.danhSachLoaiNguoiDung();
           return tblLoaiNguoiDung;
        }

        public void xoaLoaiNguoiDung(string maLND) 
        {
            loaiNguoiDung_DTO=new clsLOAINGUOIDUNG_DTO();
            loaiNguoiDung_DTO.Malnd = maLND;
            loaiNguoiDung_DAO.xoaLoaiNguoiDung(loaiNguoiDung_DTO);        
        }

        public void themLoaiNguoiDung(string maLND,string TenLND)
        {
            loaiNguoiDung_DTO = new clsLOAINGUOIDUNG_DTO();
            loaiNguoiDung_DTO.Malnd = maLND;
            loaiNguoiDung_DTO.Tenlnd = TenLND;

            loaiNguoiDung_DAO.themLoaiNguoiDung(loaiNguoiDung_DTO);
        }

        public void suaLoaiNguoiDung(string maLND, string TenLND)
        {
            loaiNguoiDung_DTO = new clsLOAINGUOIDUNG_DTO();
            loaiNguoiDung_DTO.Malnd = maLND;
            loaiNguoiDung_DTO.Tenlnd = TenLND;
            loaiNguoiDung_DAO.suaLoaiNguoiDung(loaiNguoiDung_DTO);
        }

        

        private DataRow getDatarow()
        {
            dr = tblLoaiNguoiDung.NewRow();
            dr["MALND"] = loaiNguoiDung_DTO.Malnd;
            dr["TENLND"] = loaiNguoiDung_DTO.Tenlnd;  
            return dr;
        }

        //thêm dòng vừa được thêm vào table loại người dùng
        public void themDong() 
        {
            tblLoaiNguoiDung.Rows.Add(getDatarow());
        }

        //xóa loại người dùng trùng với mã loạingười dùng trên table loại người dùng
        public void xoaDong(string MaLND)
        {
            DataRow row = tblLoaiNguoiDung.Select("MALND='" + MaLND + "'")[0];
            row.Delete();         
        }

        public void suaDataGrid(DataGridViewX grdLoaiND)
        {
            foreach (DataRow row1 in tblLoaiNguoiDung.Rows)
            {
                if (row1["MALND"] != null)
                {
                    if (string.Compare(row1["MALND"].ToString().Trim(), loaiNguoiDung_DTO.Malnd.Trim()) == 0)
                    {
                        row1["TENLND"] = loaiNguoiDung_DTO.Tenlnd;
    
                    }
                }
            }
        }
    }
}
