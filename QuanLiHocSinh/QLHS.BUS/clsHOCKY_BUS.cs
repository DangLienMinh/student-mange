using System;
using System.Collections.Generic;
using System.Linq;
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
        private clsHOCKY_DAO hocky;
        public clsHOCKY_BUS()
        {
            hocky=new clsHOCKY_DAO();
        }
        public void hienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = hocky.danhsachHocky();
            comboBox.DisplayMember = "TENHK";
            comboBox.ValueMember = "MAHK";
        }
    }
}
