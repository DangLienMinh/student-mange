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
    public class clsLOP_BUS
    {
        clsLOP_DAO lop_DAO;
        clsLOP_DTO lop_DTO;
        DataTable tblLop;
        private DataRow dr;

        public clsLOP_BUS()
        {
            lop_DAO = new clsLOP_DAO();
            tblLop = new DataTable();
        }
        public void hienThiLopTheoMonHoc(string maNH)
        {
            lop_DTO = new clsLOP_DTO();
            lop_DTO.Manh = maNH;
            tblLop = lop_DAO.danhsachLopTheoNamHoc(lop_DTO);
            grdMonHoc.DataSource = tblLop;
        }
    }
}
