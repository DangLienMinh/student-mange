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
using System.Windows.Forms;
using System.IO;
namespace QLHS.BUS
{
    public class clsHOCSINH_BUS
    {
        private clsHOCSINH_DAO hocsinh;
        private clsNAMHOC_DAO namhoc;
        private clsLOP_DAO lop;
        public clsHOCSINH_BUS()
        {
            hocsinh = new clsHOCSINH_DAO();
            namhoc = new clsNAMHOC_DAO();
            lop = new clsLOP_DAO();
        }
        public DataTable danhsachHocSinh()
        {
            return hocsinh.danhsachHocSinh();
        }
        public void themHocsinh(clsHOCSINH_DTO hs)
        {
            hocsinh.themHocsinh(hs);
        }
        public void suaHocsinh(clsHOCSINH_DTO hs)
        {
            hocsinh.suaHocsinh(hs);
        }
        public void xoaHocsinh(clsHOCSINH_DTO hs)
        {
            hocsinh.xoaHocsinh(hs);
        }
        public void cboGioitinh(ComboBoxEx comboBox)
        {
            comboBox.Items.Add("Nam");
            comboBox.Items.Add("Nữ");
            comboBox.SelectedItem = "Nam";
        }
        public void cboNamhoc(ComboBoxEx comboBox)
        {
            comboBox.DataSource = namhoc.danhSachNamHoc();
            comboBox.DisplayMember = "TENNH";
            comboBox.ValueMember = "MANH";
        }
        public void cboLophoc(ComboBoxEx comboBox)
        {
            comboBox.DataSource = lop.danhsachLop();
            comboBox.DisplayMember = "TENLOP";
            comboBox.ValueMember = "MALOP";
        }
        public void hienthiNgaySinh(DateTimeInput dtingaysinh)
        {

        }
        //public string taoMaHocSinh()
        //{
        //    string Mahs;
        //    string str;
        //    str = DateTime.Now.ToString().Trim();
        //    string Namhientai = str.Substring(6, 4);
        //    string makhoitao= Namhientai.Trim() + "0000";
        //    int intmahs = int.Parse(makhoitao) + hocsinh.danhsachHocSinh().Rows.Count;
        //    Mahs = intmahs.ToString();
        //    return Mahs;
        //}
        public string taoMaHocSinh()
        {
            string tam = "";
            string Mahs;
            string str;
            str = DateTime.Now.ToString().Trim();
            string Namhientai = str.Substring(6, 4);
            string makhoitao = Namhientai.Trim() + "0000";
            int soDong = hocsinh.danhsachHocSinh().Rows.Count;
            if (soDong == 0)
            {
                Mahs = makhoitao;
            }
            else
            {
                int max = 0;
                for (int i = 0; i < hocsinh.danhsachHocSinh().Rows.Count;i++ )
                {
                    tam = hocsinh.danhsachHocSinh().Rows[i]["MAHS"].ToString();
                    int tam1 = int.Parse(tam);
                    if (max < tam1)
                    {
                        max = tam1;
                    }
                }
                max++;
                Mahs = Namhientai + max.ToString().Trim().Substring(4, 4);
            }
            return Mahs;
        }
        public DataTable timHocsinhMahs(clsHOCSINH_DTO hs)
        {
            return hocsinh.timHocsinhMahs(hs);
        }
        public DataTable timHocsinhTenhs(clsHOCSINH_DTO hs)
        {
            return hocsinh.timHocsinhTenhs(hs);
        }
    }
    
      
}
