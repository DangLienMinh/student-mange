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
        private DataRow dr;

        public clsKHOI_BUS() 
        {
            khoi_DAO = new clsKHOI_DAO();
            tblKhoi = new DataTable();
        }

        public void hienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = khoi_DAO.danhsachKhoi();
            comboBox.DisplayMember = "TENKHOI";
            comboBox.ValueMember = "MAKHOI";
        }

        public void hienThiComboBox(ComboBoxEx cboKhoiCu,ComboBoxEx cboKhoiMoi)
        {
            khoi_DTO = new clsKHOI_DTO();
            khoi_DTO.Makhoi = cboKhoiCu.SelectedValue.ToString();
            cboKhoiMoi.DataSource = khoi_DAO.danhsachKhoiTheoMaKhoi(khoi_DTO);
            cboKhoiMoi.DisplayMember = "TENKHOI";
            cboKhoiMoi.ValueMember = "MAKHOI";
        }
    }
}
