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
    public class clsHOCKY_BUS
    {
        private clsHOCKY_DAO hocKy_DAO;
        public clsHOCKY_BUS()
        {
            hocKy_DAO=new clsHOCKY_DAO();
        }

        //hiển thị comboBox học kỳ
        public void hienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = hocKy_DAO.danhSachHocKy();
            comboBox.DisplayMember = "TENHK";
            comboBox.ValueMember = "MAHK";
        }

        //hiển thị comboBox học kỳ trên grid
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cboColumn)
        {
            cboColumn.DataSource = hocKy_DAO.danhSachHocKy();
            cboColumn.DisplayMember = "TENHK";
            cboColumn.ValueMember = "MAHK";
            cboColumn.DataPropertyName = "MAHK";
        }
    }
}
