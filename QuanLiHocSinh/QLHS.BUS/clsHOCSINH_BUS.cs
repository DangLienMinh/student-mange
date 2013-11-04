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
        private clsHOCSINH_DAO hocSinh_DAO;
        private clsNAMHOC_DAO namHoc_DAO;
        private clsLOP_DAO lop_DAO;
        private clsLOP_DTO lop_DTO;
        private clsNAMHOC_DTO namHoc_DTO;
        private clsHOCSINH_DTO hocSinh_DTO;
        private DataTable tblLop,tbHocSinh;

        public clsHOCSINH_BUS()
        {
            lop_DTO = new clsLOP_DTO();
            hocSinh_DAO = new clsHOCSINH_DAO();
            namHoc_DAO = new clsNAMHOC_DAO();
            lop_DAO = new clsLOP_DAO();
            namHoc_DTO = new clsNAMHOC_DTO();
            hocSinh_DTO = new clsHOCSINH_DTO(); 
            tblLop = new DataTable();
            tbHocSinh = new DataTable();
        }

        //lấy danh sách học sinh theo combobox mã năm học chứ không load hết vì rất nhiều 
        public DataTable danhSachHocSinh(ComboBoxEx comboBox)
        {
            return hocSinh_DAO.danhSachHocSinh(comboBox.SelectedValue.ToString());
        }


        public void themHocSinh(clsHOCSINH_DTO hs)
        {
            hocSinh_DAO.themHocSinh(hs);
        }

        public void suaHocSinh(clsHOCSINH_DTO hs,DataGridViewX grdHocSinh)
        {
            foreach (DataGridViewRow row1 in grdHocSinh.Rows)
            {
                if (row1.Cells["MAHS"].Value != null)
                {
                    if (string.Compare(row1.Cells["MAHS"].Value.ToString().Trim(), hs.Mahs.Trim()) == 0)
                    {
                        hocSinh_DAO.suaHocSinh(hs, row1.Cells["MANH"].Value.ToString(), row1.Cells["MALOP"].Value.ToString());
                    }
                }
            }
           
        }

        public void xoaHocSinh(clsHOCSINH_DTO hs)
        {
            hocSinh_DAO.xoaHocSinh(hs);
        }

        public void cboGioiTinh(ComboBoxEx comboBox)
        {
            comboBox.Items.Add("Nam");
            comboBox.Items.Add("Nữ");
            comboBox.SelectedItem = "Nam";
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

        //tạo mã học sinh dựa trên cboNamHoc 
        public string taoMaHocSinh(ComboBoxEx comboBox)
        {
            string tam = "";
            string maHS;
            string str;
            str = DateTime.Now.Year.ToString();
            string namHienTai = str; 
            string maKhoiTao = namHienTai.Trim() + "0000";
            //số học sinh của năm học đó
            int soDong = hocSinh_DAO.danhSachHocSinh(comboBox.SelectedValue.ToString()).Rows.Count;
            if (soDong == 0)
            {
                maHS = maKhoiTao;
            }
            else
            {
                int max = 0;
                for (int i = 0; i < hocSinh_DAO.danhSachHocSinh(comboBox.SelectedValue.ToString()).Rows.Count; i++)
                {
                    tam = hocSinh_DAO.danhSachHocSinh(comboBox.SelectedValue.ToString()).Rows[i]["MAHS"].ToString();
                    int tam1 = int.Parse(tam);
                    if (max < tam1)
                    {
                        max = tam1;
                    }
                }
                max++;
                maHS = namHienTai + max.ToString().Trim().Substring(4, 4);
            }
            return maHS;
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
            hocSinh_DTO.Manh = comboBox.SelectedValue.ToString();
            lop_DTO = new clsLOP_DTO();
            lop_DTO.Manh = comboBox.SelectedValue.ToString();
            tblLop = lop_DAO.danhSachLopTheoNamHoc(lop_DTO);
            foreach (DataRow row in tblLop.Rows)
            {
                if (row["TENLOP"].ToString() == tree.SelectedNode.ToString())
                {
                    temp = row["MALOP"].ToString();
                }
            }
            hocSinh_DTO.Malop = temp;
            return hocSinh_DAO.danhSachHocSinhTheoLop(hocSinh_DTO);
        }

        public void danhSachHocSinhTheoLop(ComboBoxEx comboNamHoc, ComboBoxEx comboLop,ListViewEx list)
        {
            list.Items.Clear();   
            hocSinh_DTO.Manh = comboNamHoc.SelectedValue.ToString();
            hocSinh_DTO.Malop = comboLop.SelectedValue.ToString();
            tbHocSinh=hocSinh_DAO.danhSachHocSinhTheoLop(hocSinh_DTO);
            foreach (DataRow row in tbHocSinh.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = row["MAHS"].ToString();
                item.SubItems.Add(row["TENHS"].ToString());

                list.Items.Add(item);
            }
        }

        public DataTable danhSachPhanLop(ComboBoxEx comboNamHoc)
        {
            hocSinh_DTO.Manh = comboNamHoc.SelectedValue.ToString();
            tbHocSinh = hocSinh_DAO.danhSachPhanLop(hocSinh_DTO);
            return tbHocSinh;
        }



        public void themPhanLop(ComboBoxEx comboNamHoc, ComboBoxEx comboLop,ListViewEx lstHocSinh)
        {
            lop_DTO = new clsLOP_DTO();
            namHoc_DTO = new clsNAMHOC_DTO();

            lop_DTO.Malop = comboLop.SelectedValue.ToString();
            namHoc_DTO.Manh = comboNamHoc.SelectedValue.ToString();
            foreach (ListViewItem item in lstHocSinh.Items)
            {
                hocSinh_DTO = new clsHOCSINH_DTO();
                hocSinh_DTO.Mahs = item.SubItems[0].Text.ToString();
                hocSinh_DAO.themPhanLop(hocSinh_DTO,namHoc_DTO,lop_DTO);
            }
        }

        public void timHocSinhMaHS(DataGridViewX grdHocSinh,TextBoxX maHS)
        {
            clsHOCSINH_DTO hs = new clsHOCSINH_DTO();
            hs.Mahs = maHS.Text;
            grdHocSinh.DataSource=hocSinh_DAO.timHocSinhMaHS(hs);
        }

        public void timHocSinhTenHS(DataGridViewX grdHocSinh, TextBoxX tenHS)
        {
            clsHOCSINH_DTO hs = new clsHOCSINH_DTO();
            hs.Tenhs = tenHS.Text;
            grdHocSinh.DataSource = hocSinh_DAO.timHocSinhTenHS(hs); ;
        }

        public void timHocSinhDanToc(DataGridViewX grdHocSinh, TextBoxX danToc)
        {
            clsHOCSINH_DTO hs = new clsHOCSINH_DTO();
            hs.Dantoc = danToc.Text;
            grdHocSinh.DataSource = hocSinh_DAO.timHocSinhDanToc(hs);
        }

        public void timHocSinhNgNhapHoc(DataGridViewX grdHocSinh,DateTimeInput ngNhapHoc)
        {
            clsHOCSINH_DTO hs = new clsHOCSINH_DTO();
            hs.Ngnhaphoc = ngNhapHoc.Value;
            grdHocSinh.DataSource = hocSinh_DAO.timHocSinhNgNhapHoc(hs);
        }

        public DataTable timHocSinhNangCao(clsHOCSINH_DTO hs,ComboBoxEx dieuKien)
        {
            return hocSinh_DAO.timHocSinhNangCao(hs, dieuKien.SelectedItem.ToString());
        }

        public void cbDieuKien(ComboBoxEx dieuKien)
        {
            dieuKien.Items.Add("AND");
            dieuKien.Items.Add("OR");
            dieuKien.SelectedItem = "AND";
        }
    }     
}
