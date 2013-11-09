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

        public void hienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = khoi_DAO.danhSachKhoi();
            comboBox.DisplayMember = "TENKHOI";
            comboBox.ValueMember = "MAKHOI";
        }

        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cboColumn)
        {
            cboColumn.DataSource = khoi_DAO.danhSachKhoi();
            cboColumn.DisplayMember = "TENKHOI";
            cboColumn.ValueMember = "MAKHOI";
            cboColumn.DataPropertyName = "MAKHOI";
        }

        public void hienThiComboBox(ComboBoxEx cboKhoiCu,ComboBoxEx cboKhoiMoi)
        {
            khoi_DTO = new clsKHOI_DTO();
            khoi_DTO.Makhoi = cboKhoiCu.SelectedValue.ToString();
            cboKhoiMoi.DataSource = khoi_DAO.danhSachKhoiTheoMaKhoi(khoi_DTO);
            cboKhoiMoi.DisplayMember = "TENKHOI";
            cboKhoiMoi.ValueMember = "MAKHOI";
        }
    }
}
