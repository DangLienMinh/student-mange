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

        public void hienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = hocKy_DAO.danhSachHocKy();
            comboBox.DisplayMember = "TENHK";
            comboBox.ValueMember = "MAHK";
        }

        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cboColumn)
        {
            cboColumn.DataSource = hocKy_DAO.danhSachHocKy();
            cboColumn.DisplayMember = "TENHK";
            cboColumn.ValueMember = "MAHK";
            cboColumn.DataPropertyName = "MAHK";
        }
        //public void hienThiComboBox(ComboBoxEx comboBox)
        //{
        //    comboBox.Items.Add("Học kỳ 1");
        //    comboBox.Items.Add("Học kỳ 2");
        //    comboBox.SelectedItem = "Học kỳ 1";
        //}

    }
}
