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
        public void hienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.Items.Add("Học kỳ 1");
            comboBox.Items.Add("Học kỳ 2");
            comboBox.SelectedItem = "Học kỳ 1";
        }
    }
}
