using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLHS.DTO;
using QLHS.DAO;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;
namespace QLHS.BUS
{
    public class clsHOCSINH_BUS
    {
        private clsHOCSINH_DAO hocsinh_dao;
        private clsNAMHOC_DAO namhoc_dao;
        private clsLOP_DAO lop;
        public clsHOCSINH_BUS()
        {
            hocsinh_dao = new clsHOCSINH_DAO();
            namhoc_dao = new clsNAMHOC_DAO();
            lop = new clsLOP_DAO();
        }
        public DataTable danhsachHocSinh()
        {
            return hocsinh_dao.danhsachHocSinh();
        }
        ////public DataTable danhsachNamhoc()
        ////{
        ////    return namhoc.danhSachNamHoc();
        ////}
        ////public DataTable danhsachLophoc()
        ////{
        ////    return lop.danhsachLop();
        ////}
        public void themHocsinh(clsHOCSINH_DTO hs)
        {
            hocsinh_dao.themHocsinh(hs);
        }
        public void suaHocsinh(clsHOCSINH_DTO hs)
        {
            hocsinh_dao.suaHocsinh(hs);
        }
        public void xoaHocsinh(clsHOCSINH_DTO hs)
        {
            hocsinh_dao.xoaHocsinh(hs);
        }
        public void cboGioitinh(ComboBoxEx comboBox)
        {
            comboBox.Items.Add("Nam");
            comboBox.Items.Add("Nữ");
            comboBox.SelectedItem = "Nam";
        }
        public void cboNamhoc(ComboBoxEx comboBox)
        {
            comboBox.DataSource = namhoc_dao.danhSachNamHoc();
            comboBox.DisplayMember = "TENNH";
            comboBox.ValueMember = "MANH";
            comboBox.SelectedItem = "Nam";
        }
        public void hienthiNgaySinh(DateTimeInput dtingaysinh)
        {

        }
    }
}
