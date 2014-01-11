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
        clsNAMHOC_DTO namHoc_DTO;
        DataTable tblNamHoc;
        private DataRow dr;

        public clsNAMHOC_BUS()
        {
            namHoc_DAO = new clsNAMHOC_DAO();
            tblNamHoc = new DataTable();
        }

        //trả về bảng năm học
        public DataTable hienThiDanhSach()
        {
            tblNamHoc = namHoc_DAO.danhSachNamHoc();
            return tblNamHoc;
        }

        //hiển thị comboBox năm học
        public void hienThiComboBox(ComboBoxEx cb)
        {
            cb.DataSource = namHoc_DAO.danhSachNamHoc();
            cb.DisplayMember = "TENNH";
            cb.ValueMember = "MANH";
        }

        //hiển thị comboBox năm học trên datagrid combobox column
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cboColumn)
        {
            cboColumn.DataSource = namHoc_DAO.danhSachNamHoc();
            cboColumn.DisplayMember = "TENNH";
            cboColumn.ValueMember = "MANH";
            cboColumn.DataPropertyName = "MANH";
        }

        //thêm một năm học mới
        public void themNamHoc(string maNH, string tenNH)
        {
            namHoc_DTO = new clsNAMHOC_DTO();
            namHoc_DTO.Manh = maNH;
            namHoc_DTO.Tenh = tenNH;
            namHoc_DAO.themNamHoc(namHoc_DTO);
        }

        //sửa thông tin một năm học
        public void suaNamHoc(string maNH, string tenNH)
        {
            namHoc_DTO = new clsNAMHOC_DTO();
            namHoc_DTO.Manh = maNH;
            namHoc_DTO.Tenh = tenNH;
            namHoc_DAO.suaNamHoc(namHoc_DTO);
        }

        //trả về datarow namHoc_DTO
        private DataRow getDatarow()
        {
            dr = tblNamHoc.NewRow();
            dr["MANH"] = namHoc_DTO.Manh;
            dr["TENNH"] = namHoc_DTO.Tenh;
            return dr;
        }

        //thêm dòng vừa được thêm vào table năm học
        public void themDong()
        {
            tblNamHoc.Rows.Add(getDatarow());
        }

        //sửa thông tin năm học trên table năm học dựa vào namHoc_DTO
        public void suaDataGrid()
        {
            foreach (DataRow row1 in tblNamHoc.Rows)
            {
                if (row1["MANH"] != null)
                {
                    if (string.Compare(row1["MANH"].ToString().Trim(), namHoc_DTO.Manh.Trim()) == 0)
                    {
                        row1["TENNH"] = namHoc_DTO.Tenh;

                    }
                }
            }
        }
    }
}
