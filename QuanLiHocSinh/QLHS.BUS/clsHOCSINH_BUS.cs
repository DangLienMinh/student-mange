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
using System.IO;
namespace QLHS.BUS
{
    public class clsHOCSINH_BUS
    {
        private clsHOCSINH_DAO hocsinh;
        private clsNAMHOC_DAO namhoc;
        private clsLOP_DAO lop;
        private clsLOP_DTO lop_dto;
        private clsHOCSINH_DTO hocsinh_dto;
        private DataTable tblLop,tbHocSinh;

        public clsHOCSINH_BUS()
        {
            lop_dto = new clsLOP_DTO();
            hocsinh = new clsHOCSINH_DAO();
            namhoc = new clsNAMHOC_DAO();
            lop = new clsLOP_DAO();
            hocsinh_dto = new clsHOCSINH_DTO(); 
            tblLop = new DataTable();
            tbHocSinh = new DataTable();
        }

        //lấy danh sách học sinh theo combobox mã năm học chứ không load hết vì rất nhiều 
        public DataTable danhSachHocSinh(ComboBoxEx comboBox)
        {
            return hocsinh.danhSachHocSinh(comboBox.SelectedValue.ToString());
        }


        public void themHocSinh(clsHOCSINH_DTO hs)
        {
            hocsinh.themHocSinh(hs);
        }

        public void suaHocSinh(clsHOCSINH_DTO hs,DataGridViewX grdHocSinh)
        {
            foreach (DataGridViewRow row1 in grdHocSinh.Rows)
            {
                if (row1.Cells["MAHS"].Value != null)
                {
                    if (string.Compare(row1.Cells["MAHS"].Value.ToString().Trim(), hs.Mahs.Trim()) == 0)
                    {
                        hocsinh.suaHocSinh(hs, row1.Cells["MANH"].Value.ToString(), row1.Cells["MALOP"].Value.ToString());
                    }
                }
            }
           
        }

        public void xoaHocSinh(clsHOCSINH_DTO hs)
        {
            hocsinh.xoaHocSinh(hs);
        }

        public void cboGioiTinh(ComboBoxEx comboBox)
        {
            comboBox.Items.Add("Nam");
            comboBox.Items.Add("Nữ");
            comboBox.SelectedItem = "Nam";
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

        public string taoMaHocSinh(ComboBoxEx comboBox)
        {
            string tam = "";
            string Mahs;
            string str;
            str = DateTime.Now.ToString().Trim();
            string Namhientai = str.Substring(6, 4); 
            string makhoitao = Namhientai.Trim() + "0000";
            int soDong = hocsinh.danhSachHocSinh(comboBox.SelectedValue.ToString()).Rows.Count;
            if (soDong == 0)
            {
                Mahs = makhoitao;
            }
            else
            {
                int max = 0;
                for (int i = 0; i < hocsinh.danhSachHocSinh(comboBox.SelectedValue.ToString()).Rows.Count; i++)
                {
                    tam = hocsinh.danhSachHocSinh(comboBox.SelectedValue.ToString()).Rows[i]["MAHS"].ToString();
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


















        ////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// FORM TÌM HỌC SINH
        /// LIÊN MINH
        /// </summary>

        //load danh sách học sinh theo mã năm học vào tree view
        public DataTable danhSachHocSinhTheoLop(ComboBoxEx comboBox, AdvTree tree)
        {
            string temp = "";
            hocsinh_dto.Manh = comboBox.SelectedValue.ToString();
            lop_dto = new clsLOP_DTO();
            lop_dto.Manh = comboBox.SelectedValue.ToString();
            tblLop = lop.danhSachLopTheoNamHoc(lop_dto);
            foreach (DataRow row in tblLop.Rows)
            {
                if (row["TENLOP"].ToString() == tree.SelectedNode.ToString())
                {
                    temp = row["MALOP"].ToString();
                }
            }
            hocsinh_dto.Malop = temp;
            return hocsinh.danhSachHocSinhTheoLop(hocsinh_dto);
        }

        public void danhSachHocSinhTheoLop(ComboBoxEx comboNamHoc, ComboBoxEx comboLop,ListViewEx list)
        {
            list.Items.Clear();   
            hocsinh_dto.Manh = comboNamHoc.SelectedValue.ToString();
            hocsinh_dto.Malop = comboLop.SelectedValue.ToString();
            tbHocSinh=hocsinh.danhSachHocSinhTheoLop(hocsinh_dto);
            foreach (DataRow row in tbHocSinh.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = row["MAHS"].ToString();
                item.SubItems.Add(row["TENHS"].ToString());

                list.Items.Add(item);
            }
        }

        public void timHocSinhMaHS(DataGridViewX grdHocSinh,TextBoxX maHS)
        {
            clsHOCSINH_DTO hs = new clsHOCSINH_DTO();
            hs.Mahs = maHS.Text;
            grdHocSinh.DataSource=hocsinh.timHocSinhMaHS(hs);
        }

        public void timHocSinhTenHS(DataGridViewX grdHocSinh, TextBoxX tenHS)
        {
            clsHOCSINH_DTO hs = new clsHOCSINH_DTO();
            hs.Tenhs = tenHS.Text;
            grdHocSinh.DataSource = hocsinh.timHocSinhTenHS(hs); ;
        }

        public void timHocSinhDanToc(DataGridViewX grdHocSinh, TextBoxX danToc)
        {
            clsHOCSINH_DTO hs = new clsHOCSINH_DTO();
            hs.Dantoc = danToc.Text;
            grdHocSinh.DataSource = hocsinh.timHocSinhDanToc(hs);
        }

        public void timHocSinhNgNhapHoc(DataGridViewX grdHocSinh,DateTimeInput ngNhapHoc)
        {
            clsHOCSINH_DTO hs = new clsHOCSINH_DTO();
            hs.Ngnhaphoc = ngNhapHoc.Value;
            grdHocSinh.DataSource = hocsinh.timHocSinhNgNhapHoc(hs);
        }

        public DataTable timHocSinhNangCao(clsHOCSINH_DTO hs,ComboBoxEx dieuKien)
        {
            return hocsinh.timHocSinhNangCao(hs, dieuKien.SelectedItem.ToString());
        }

        public void cbDieuKien(ComboBoxEx dieuKien)
        {
            dieuKien.Items.Add("AND");
            dieuKien.Items.Add("OR");
            dieuKien.SelectedItem = "AND";
        }
    }     
}
