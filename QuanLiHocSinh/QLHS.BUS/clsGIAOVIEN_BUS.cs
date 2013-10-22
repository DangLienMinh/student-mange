using System;
using System.Collections.Generic;
using System.Text;
using QLHS.DAO;
using QLHS.DTO;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;
using System.Windows.Forms;
namespace QLHS.BUS
{
    public class clsGIAOVIEN_BUS
    {
        clsGIAOVIEN_DAO giaoVien_DAO=new clsGIAOVIEN_DAO();
        clsGIAOVIEN_DTO giaoVien_DTO;

        public clsGIAOVIEN_BUS() 
        {
            //clsGIAOVIEN_DAO giaoVien_DAO = new clsGIAOVIEN_DAO();
        }

        public void hienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.Items.Add("Nam");
            comboBox.Items.Add("Nữ");
            comboBox.Items.Add("Gay");
            comboBox.SelectedItem = "Nam";
        }

        public void hienThiDanhSach(DataGridViewX drgGV)
        {
            drgGV.DataSource = giaoVien_DAO.danhSachGiaoVien();
        }

        public void xoaGiaoVien(string maGV) 
        {
            giaoVien_DTO=new clsGIAOVIEN_DTO();
            giaoVien_DTO.Magv = maGV;
            giaoVien_DAO.xoaGiaoVien(giaoVien_DTO);        
        }

        public void themGiaoVien(string maGV,string TenGV, DateTimeInput ngaySinh,string DienThoai,string gioiTinh,string diaChi,string HinhAnh)
        {
            giaoVien_DTO = new clsGIAOVIEN_DTO();
            giaoVien_DTO.Magv = maGV;
            giaoVien_DTO.Tengv = TenGV;
            giaoVien_DTO.Gioitinhgv = gioiTinh;
            giaoVien_DTO.Diachigv = diaChi;
            giaoVien_DTO.Hinhanhgv = HinhAnh;
            giaoVien_DTO.Ngsinhgv = ngaySinh.Value;
            giaoVien_DTO.Dienthoaigv = DienThoai;
            giaoVien_DAO.themGiaoVien(giaoVien_DTO);
        }

    }
}
