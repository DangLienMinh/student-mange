using System;
using System.Collections.Generic;
using System.Text;
using QLHS.DAO;
using QLHS.DTO;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;

namespace QLHS.BUS
{
    public class clsGIAOVIEN_BUS
    {
        clsGIAOVIEN_DAO giaoVien_DAO = new clsGIAOVIEN_DAO();

        public clsGIAOVIEN_BUS() { 
            
        }

        public void hienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.Items.Add("Nam");
            comboBox.Items.Add("Nữ");
            comboBox.Items.Add("Gay");
            comboBox.SelectedItem = "Nam";
        }


    }
}
