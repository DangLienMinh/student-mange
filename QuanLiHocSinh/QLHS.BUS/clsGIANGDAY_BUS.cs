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
using DevComponents.AdvTree;
using System.Windows.Forms;
namespace QLHS.BUS
{
    public class clsGIANGDAY_BUS
    {
        private clsGIANGDAY_DAO giangday_dao;
        private clsGIAOVIEN_DAO giaovien_dao;
        private clsLOP_DAO lop_dao;
        private clsNAMHOC_DAO namhoc_dao;
        private clsMONHOC_DAO monhoc_dao;
        public clsGIANGDAY_BUS()
        {
            giangday_dao=new clsGIANGDAY_DAO();
            giaovien_dao = new clsGIAOVIEN_DAO();
            lop_dao = new clsLOP_DAO();
            namhoc_dao = new clsNAMHOC_DAO();
            monhoc_dao = new clsMONHOC_DAO();
        }
        public void hienthiLop(ComboBoxEx cboLop)
        {
            cboLop.DataSource = lop_dao.danhSachLop();
            cboLop.DisplayMember = "TENLOP";
            cboLop.ValueMember = "MALOP";
        }
        public void hienthiNamhoc(ComboBoxEx cboNamhoc)
        {
            cboNamhoc.DataSource = namhoc_dao.danhSachNamHoc();
            cboNamhoc.DisplayMember = "TENNH";
            cboNamhoc.ValueMember = "MANH";
        }
        public void hienthiGiaovien(ComboBoxEx cboGiaovien)
        {
            cboGiaovien.DataSource = giaovien_dao.danhSachGiaoVien();
            cboGiaovien.DisplayMember = "TENGV";
            cboGiaovien.ValueMember = "MAGV";
        }
        public void hienthiMonhoc(ComboBoxEx cboMonhoc)
        {
            cboMonhoc.DataSource = monhoc_dao.danhSachMonhoc();
            cboMonhoc.DisplayMember = "TENMH";
            cboMonhoc.ValueMember = "MAMH";
        }
        public void themGiangday(clsGIANGDAY_DTO giangday)
        {
            giangday_dao.themPhanCong(giangday);
        }
        public DataTable danhsachPhanCong()
        {
            return giangday_dao.danhsachPhancong();
        }
        public void suaPhanCong(clsGIANGDAY_DTO giangdaymoi, clsGIANGDAY_DTO giangdaycu)
        {
            giangday_dao.suaPhanCong(giangdaymoi, giangdaycu);
        }
        public void xoaPhanCong(clsGIANGDAY_DTO giangday)
        {
            giangday_dao.xoaPhanCong(giangday);
        }
        public DataTable timPhanCong(clsGIAOVIEN_DTO giaovien, clsLOP_DTO lop)
        {
            return giangday_dao.timPhanCong(giaovien, lop);
        }
    }
}
