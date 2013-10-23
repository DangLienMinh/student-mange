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
    public class clsNAMHOC_BUS
    {
        clsNAMHOC_DAO namHoc_DAO;
        clsNAMHOC_DTO namHoc__DTO;
        DataTable tblNamHoc;
        private DataRow dr;

        public clsNAMHOC_BUS()
        {
            namHoc_DAO = new clsNAMHOC_DAO();
            tblNamHoc = new DataTable();
        }
        public void hienThiDanhSach(DataGridViewX grdNamHoc)
        {
            tblNamHoc = namHoc_DAO.danhSachNamHoc();
            grdNamHoc.DataSource = tblNamHoc;

        }

        public void themNamHoc(string maNH, string tenNH)
        {
            namHoc__DTO = new clsNAMHOC_DTO();
            namHoc__DTO.Manh = maNH;
            namHoc__DTO.Tenh = tenNH;

            namHoc_DAO.themNamHoc(namHoc__DTO);
        }

        public void suaNamHoc(string maNH, string tenNH)
        {
            namHoc__DTO = new clsNAMHOC_DTO();
            namHoc__DTO.Manh = maNH;
            namHoc__DTO.Tenh = tenNH;

            namHoc_DAO.suaNamHoc(namHoc__DTO);
        }

        private DataRow getDatarow()
        {
            dr = tblNamHoc.NewRow();
            dr["MANH"] = namHoc__DTO.Manh;
            dr["TENNH"] = namHoc__DTO.Tenh;
           
            return dr;
        }

        //add dong vua them vao
        public void themDong()
        {
            tblNamHoc.Rows.Add(getDatarow());
        }

        public void suaDataGrid(DataGridViewX grdNamHoc)
        {
            foreach (DataGridViewRow row1 in grdNamHoc.Rows)
            {
                if (row1.Cells["MANH"].Value != null)
                {
                    if (string.Compare(row1.Cells["MANH"].Value.ToString().Trim(), namHoc__DTO.Manh.Trim()) == 0)
                    {
                        row1.Cells["TENNH"].Value = namHoc__DTO.Tenh;

                    }
                }
            }
        }
    }
}
