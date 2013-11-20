using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QLHS.DTO;
using QLHS.DAO;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;
using DevComponents.AdvTree;
using System.Windows.Forms;

namespace QLHS.BUS
{
    public class clsGIANGDAY_BUS
    {
        private clsGIANGDAY_DAO giangDay_DAO;
        private clsGIAOVIEN_DAO giaoVien_DAO;
        private clsLOP_DAO lop_DAO;
        private clsNAMHOC_DAO namHoc_DAO;
        private clsMONHOC_DAO monHoc_DAO;

        public clsGIANGDAY_BUS()
        {
            giangDay_DAO=new clsGIANGDAY_DAO();
            giaoVien_DAO = new clsGIAOVIEN_DAO();
            lop_DAO = new clsLOP_DAO();
            namHoc_DAO = new clsNAMHOC_DAO();
            monHoc_DAO = new clsMONHOC_DAO();
        }

        public void hienThiLop(ComboBoxEx cboLop)
        {
            cboLop.DataSource = lop_DAO.danhSachLop();
            cboLop.DisplayMember = "TENLOP";
            cboLop.ValueMember = "MALOP";
        }
        public void hienThiNamHoc(ComboBoxEx cboNamhoc)
        {
            cboNamhoc.DataSource = namHoc_DAO.danhSachNamHoc();
            cboNamhoc.DisplayMember = "TENNH";
            cboNamhoc.ValueMember = "MANH";
        }
        public void hienThiGiaoVien(ComboBoxEx cboGiaovien)
        {
            cboGiaovien.DataSource = giaoVien_DAO.danhSachGiaoVien();
            cboGiaovien.DisplayMember = "TENGV";
            cboGiaovien.ValueMember = "MAGV";
        }
        public void hienThiMonHoc(ComboBoxEx cboMonhoc)
        {
            cboMonhoc.DataSource = monHoc_DAO.danhSachMonhoc();
            cboMonhoc.DisplayMember = "TENMH";
            cboMonhoc.ValueMember = "MAMH";
        }
        public void themGiangDay(clsGIANGDAY_DTO giangday)
        {
            giangDay_DAO.themPhanCong(giangday);
        }
        public DataTable danhSachPhanCong()
        {
            return giangDay_DAO.danhsachPhancong();
        }
        public void suaPhanCong(clsGIANGDAY_DTO giangdaymoi, clsGIANGDAY_DTO giangdaycu)
        {
            giangDay_DAO.suaPhanCong(giangdaymoi, giangdaycu);
        }
        public void xoaPhanCong(clsGIANGDAY_DTO giangday)
        {
            giangDay_DAO.xoaPhanCong(giangday);
        }
        public DataTable timPhanCong(clsGIAOVIEN_DTO giaovien, clsLOP_DTO lop)
        {
            return giangDay_DAO.timPhanCong(giaovien, lop);
        }
    }
}
