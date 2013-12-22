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
    public class clsMONHOC_BUS
    {
        clsMONHOC_DAO monHoc_DAO;
        clsMONHOC_DTO monHoc_DTO;
        DataTable tblMonHoc;
        private DataRow dr;

        public clsMONHOC_BUS()
        {
            monHoc_DAO = new clsMONHOC_DAO();
            tblMonHoc = new DataTable();
        }

        public DataTable hienThiDanhSach()
        {
            tblMonHoc= monHoc_DAO.danhSachMonhoc();
            return tblMonHoc;
        }

        //tạo mã môn học tự động
        public string hienThiSoMon()
        {
            string result;
            int temp = monHoc_DAO.soMonHoc() + 1;
            if (temp < 10)
            {
                result = "0" + temp.ToString();
            }
            else
            {
                result = temp.ToString();
            }
            return result;
        }

        //hiển thị môn học trên datagrid comboBox column
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cboColumn)
        {
            cboColumn.DataSource = monHoc_DAO.danhSachMonhoc();
            cboColumn.DisplayMember = "TENMH";
            cboColumn.ValueMember = "MAMH";
            cboColumn.DataPropertyName = "MAMH";
        }

        //hiển thị môn học trên comboBox
        public void hienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = monHoc_DAO.danhSachMonhoc();
            comboBox.DisplayMember = "TENMH";
            comboBox.ValueMember = "MAMH";
        }

        //thêm một môn học mới
        public void themMonHoc(string maMH, string tenMH,string soTiet)
        {
            monHoc_DTO = new clsMONHOC_DTO();
            monHoc_DTO.Mamh = maMH;
            monHoc_DTO.Tenmh = tenMH;
            monHoc_DTO.Sotiet = soTiet;
            monHoc_DAO.themMonHoc(monHoc_DTO);
        }

        //sửa một môn học
        public void suaMonHoc(string maMH, string tenMH, string soTiet)
        {
            monHoc_DTO = new clsMONHOC_DTO();
            monHoc_DTO.Mamh = maMH;
            monHoc_DTO.Tenmh = tenMH;
            monHoc_DTO.Sotiet = soTiet;
            monHoc_DAO.suaMonHoc(monHoc_DTO);
        }

        //trả về một dòng của đối tượng môn học
        private DataRow getDatarow()
        {
            dr = tblMonHoc.NewRow();
            dr["MAMH"] = monHoc_DTO.Mamh;
            dr["TENMH"] = monHoc_DTO.Tenmh;
            dr["SOTIET"] = monHoc_DTO.Sotiet;
            return dr;
        }

        //thêm dòng vừa được thêm vào table môn học
        public void themDong()
        {
            tblMonHoc.Rows.Add(getDatarow());
        }

        //sửa thông tin trên datatable và dựa vào monHoc_DTO
        public void suaDataGrid()
        {
            foreach (DataRow row1 in tblMonHoc.Rows)
            {
                if (row1["MAMH"] != null)
                {
                    if (string.Compare(row1["MAMH"].ToString().Trim(), monHoc_DTO.Mamh.Trim()) == 0)
                    {
                        row1["TENMH"] = monHoc_DTO.Tenmh;
                        row1["SOTIET"]= monHoc_DTO.Sotiet;
                    }
                }
            }
        }

        //xóa một dòng trên datatable monHoc dựa vào MAMH
        public void xoaDong(string maMH)
        {
            DataRow row = tblMonHoc.Select("MAMH='" + maMH + "'")[0];
            row.Delete();
        }
    }
}
