using System;
using System.Collections.Generic;
using System.Text;
using QLHS.DAO;
using QLHS.DTO;
using DevComponents.DotNetBar.Controls;
using DevComponents.AdvTree;
using DevComponents.Editors.DateTimeAdv;
using System.Windows.Forms;
using System.Data;

namespace QLHS.BUS
{
    public class clsKHOI_BUS
    {
        clsKHOI_DAO khoi_DAO;
        clsKHOI_DTO khoi_DTO;
        DataTable tblKhoi;

        public clsKHOI_BUS() 
        {
            khoi_DAO = new clsKHOI_DAO();
            tblKhoi = new DataTable();
        }

        //hiển thị comboBox khối 
        public void hienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = khoi_DAO.danhSachKhoi();
            comboBox.DisplayMember = "TENKHOI";
            comboBox.ValueMember = "MAKHOI";
        }

        //hiển thị comboBox khối 10
        public void hienThiComboBoxKhoi10(ComboBoxEx comboBox)
        {
            comboBox.DataSource = khoi_DAO.danhSachKhoi10();
            comboBox.DisplayMember = "TENKHOI";
            comboBox.ValueMember = "MAKHOI";
        }

        //hiển thị comboBox khối lên grid
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cboColumn)
        {
            cboColumn.DataSource = khoi_DAO.danhSachKhoi();
            cboColumn.DisplayMember = "TENKHOI";
            cboColumn.ValueMember = "MAKHOI";
            cboColumn.DataPropertyName = "MAKHOI";
        }

        //hiển thị comboBox khối theo một khối khác dùng cho phân lớp
        public void hienThiComboBox(ComboBoxEx cboKhoiCu,ComboBoxEx cboKhoiMoi)
        {
            khoi_DTO = new clsKHOI_DTO();
            if (cboKhoiCu.SelectedValue!=null)
            {
                khoi_DTO.Makhoi = cboKhoiCu.SelectedValue.ToString();
                cboKhoiMoi.DataSource = khoi_DAO.danhSachKhoiTheoMaKhoi(khoi_DTO);
                cboKhoiMoi.DisplayMember = "TENKHOI";
                cboKhoiMoi.ValueMember = "MAKHOI";
            }           
        }

        //hiển thị comboBox khối theo một khối khác dùng cho chuyển lớp
        public void hienThiComboBoxChuyenLop(ComboBoxEx cboKhoiCu, ComboBoxEx cboKhoiMoi)
        {
            khoi_DTO = new clsKHOI_DTO();
            if (cboKhoiCu.SelectedValue != null)
            {
                khoi_DTO.Makhoi = cboKhoiCu.SelectedValue.ToString();
                cboKhoiMoi.DataSource = khoi_DAO.danhSachKhoiChuyenLop(khoi_DTO);
                cboKhoiMoi.DisplayMember = "TENKHOI";
                cboKhoiMoi.ValueMember = "MAKHOI";
            }
        }
    }
}
