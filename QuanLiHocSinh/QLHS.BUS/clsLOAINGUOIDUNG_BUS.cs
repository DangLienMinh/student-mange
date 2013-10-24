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

        public void hienThiDanhSach(DataGridViewX grdLoaiND)
        {
            tblLoaiNguoiDung = loaiNguoiDung_DAO.danhSachLoaiNguoiDung();
            grdLoaiND.DataSource=tblLoaiNguoiDung;

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

        //add dong vua them vao
        public void themDong() 
        {
            tblLoaiNguoiDung.Rows.Add(getDatarow());
        }

        public void xoaDong(DataGridViewX grdLoaiND,string MaLND)
        {
            DataRow row = tblLoaiNguoiDung.Select("MALND='" + MaLND + "'")[0];
            row.Delete();
            grdLoaiND.DataSource = tblLoaiNguoiDung;
        }

        public void suaDataGrid(DataGridViewX grdLoaiND)
        {
            foreach (DataGridViewRow row1 in grdLoaiND.Rows)
            {
                if (row1.Cells["MALND"].Value != null)
                {
                    if (string.Compare(row1.Cells["MALND"].Value.ToString().Trim(), loaiNguoiDung_DTO.Malnd.Trim()) == 0)
                    {
                        row1.Cells["TENLND"].Value = loaiNguoiDung_DTO.Tenlnd;
    
                    }
                }
            }
        }
    }
}
