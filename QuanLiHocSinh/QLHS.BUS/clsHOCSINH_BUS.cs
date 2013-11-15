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

       
        public DataTable danhSachHocSinh()
        {
            DataTable table = hocSinh_DAO.danhSachHocSinh();
            return table;
        }
        
        public void themHocSinh(clsHOCSINH_DTO hs)
        {
            hocSinh_DAO.themHocSinh(hs);
        }

        public string tenHocSinh(string maHS)
        {
            DataTable table=new DataTable();
            table=hocSinh_DAO.tenHocSinh(maHS);
            if (table.Rows.Count > 0)
            {
                return table.Rows[0][0].ToString();
            }
            else return "";
        }

        public void suaHocSinh(clsHOCSINH_DTO hs)
        {
            hocSinh_DAO.suaHocSinh(hs);
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
       //tạo mã học sinh
        public string taoMaHocSinh()
        {
            string tam = "";
            string maHS;
            string str;
            str = DateTime.Now.Year.ToString();
            string namHienTai = str; 
            string maKhoiTao = namHienTai.Trim() + "0000";
            int soDong = hocSinh_DAO.danhSachHocSinh().Rows.Count;
            if (soDong == 0)
            {
                maHS = maKhoiTao;
            }
            else
            {
                int max = 0;
                for (int i = 0; i < hocSinh_DAO.danhSachHocSinh().Rows.Count; i++)
                {
                    tam = hocSinh_DAO.danhSachHocSinh().Rows[i]["MAHS"].ToString();
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
        public void tailaiDataGrid(DataGridViewX grdHocSinh, DataTable dsHocsinh)
        {
            grdHocSinh.DataSource = dsHocsinh;
            if (grdHocSinh.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in grdHocSinh.Rows)
                {
                    if (row.Cells["MAHS"].Value != null)
                    {
                        if (row.Cells["GIOITINHHS"].Value.ToString() == "0")
                        {
                            row.Cells["GIOITINHHS"].Value = "Nữ";
                        }
                        else
                        {
                            row.Cells["GIOITINHHS"].Value = "Nam";
                        }
                    }
                }
            }
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

        //load danh sách mahs ,ten học sinh theo manh malop 
        public DataTable danhSachMaHSTheoLop(ComboBoxEx cboMaNH, AdvTree tree)
        {
            if (tree.SelectedNode!=null)
            {
                string temp = "";
                lop_DTO = new clsLOP_DTO();
                lop_DTO.Manh = cboMaNH.SelectedValue.ToString();
                tblLop = lop_DAO.danhSachLopTheoNamHoc(lop_DTO);
                foreach (DataRow row in tblLop.Rows)
                {
                    if (row["TENLOP"].ToString() == tree.SelectedNode.ToString())
                    {
                        temp = row["MALOP"].ToString();
                    }
                }
                lop_DTO.Malop = temp;
                return hocSinh_DAO.danhSachMaHSTheoLop(lop_DTO);
            }
            else
            {
                return tblLop;
            }
           
        }

        //load danh sách học sinh chưa phân lớp theo mã năm học vào ListViewEx 
        public void danhSachHocSinhChuaPhanLop(ComboBoxEx cboNamHoc, ListViewEx list)
        {
            list.Items.Clear();
            hocSinh_DTO.Manh = cboNamHoc.SelectedValue.ToString();
            tbHocSinh = hocSinh_DAO.danhSachHocSinhChuaPhanLop(hocSinh_DTO);
            int i = 0;
            foreach (DataRow row in tbHocSinh.Rows)
            {
                ++i;
                ListViewItem item = new ListViewItem();
                item.Text = i.ToString();
                item.SubItems.Add (row["MAHS"].ToString());
                item.SubItems.Add(row["TENHS"].ToString());

                list.Items.Add(item);
            }
            
        }

        public void danhSachHocSinhTheoLop(ComboBoxEx cboNamHoc, ComboBoxEx cboLop,ListViewEx list)
        {
            list.Items.Clear();   
            hocSinh_DTO.Manh = cboNamHoc.SelectedValue.ToString();
            hocSinh_DTO.Malop = cboLop.SelectedValue.ToString();
            tbHocSinh=hocSinh_DAO.danhSachHocSinhTheoLop(hocSinh_DTO);
            int i=0;
            foreach (DataRow row in tbHocSinh.Rows)
            {
                ++i;
                ListViewItem item = new ListViewItem();
                item.Text = i.ToString();
                item.SubItems.Add(row["MAHS"].ToString());
                item.SubItems.Add(row["TENHS"].ToString());

                list.Items.Add(item);

               
            }
        }

        public void danhSachHocSinhTheoLop(ComboBoxEx comboNamHoc, ComboBoxEx comboLop,ComboBoxEx cboHocSinh)
        {
            hocSinh_DTO.Manh = comboNamHoc.SelectedValue.ToString();
            hocSinh_DTO.Malop = comboLop.SelectedValue.ToString();
            tbHocSinh = hocSinh_DAO.danhSachHocSinhTheoLop(hocSinh_DTO);
            cboHocSinh.DataSource = tbHocSinh;
            cboHocSinh.DisplayMember = "TENHS";
            cboHocSinh.ValueMember = "MAHS";
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
                hocSinh_DTO.Mahs = item.SubItems[1].Text.ToString();
                hocSinh_DAO.themPhanLop(hocSinh_DTO,namHoc_DTO,lop_DTO);
            }
        }

        public void phanLopHocSinhLop10(ComboBoxEx comboNamHoc, ComboBoxEx comboLop, ListViewEx lstHocSinh)
        {
            lop_DTO = new clsLOP_DTO();
            namHoc_DTO = new clsNAMHOC_DTO();

            lop_DTO.Malop = comboLop.SelectedValue.ToString();
            namHoc_DTO.Manh = comboNamHoc.SelectedValue.ToString();
            foreach (ListViewItem item in lstHocSinh.Items)
            {
                hocSinh_DTO = new clsHOCSINH_DTO();
                hocSinh_DTO.Mahs = item.SubItems[1].Text.ToString();
                try
                {
                    hocSinh_DAO.themPhanLop(hocSinh_DTO, namHoc_DTO, lop_DTO);
                }
                catch (Exception)
                {
                    continue;
                }
                
            }
        }

        //public void xoaPhanLop(ComboBoxEx comboNamHoc, ComboBoxEx comboLop, ListViewEx lstHocSinh)
        //{
        //    lop_DTO = new clsLOP_DTO();
        //    namHoc_DTO = new clsNAMHOC_DTO();

        //    lop_DTO.Malop = comboLop.SelectedValue.ToString();
        //    namHoc_DTO.Manh = comboNamHoc.SelectedValue.ToString();
        //    foreach (ListViewItem item in lstHocSinh.Items)
        //    {
        //        hocSinh_DTO = new clsHOCSINH_DTO();
        //        hocSinh_DTO.Mahs = item.SubItems[1].Text.ToString();
        //        hocSinh_DAO.xoaPhanLop(hocSinh_DTO, namHoc_DTO, lop_DTO);
        //    }
        //}

        public void xoaPhanLop(ComboBoxEx comboNamHoc, ComboBoxEx comboLop,string maHS)
        {
            lop_DTO = new clsLOP_DTO();
            namHoc_DTO = new clsNAMHOC_DTO();
            hocSinh_DTO = new clsHOCSINH_DTO();
            hocSinh_DTO.Mahs = maHS;
            lop_DTO.Malop = comboLop.SelectedValue.ToString();
            namHoc_DTO.Manh = comboNamHoc.SelectedValue.ToString();
        
            hocSinh_DAO.xoaPhanLop(hocSinh_DTO, namHoc_DTO, lop_DTO);
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

        public DataTable timHocSinhNangCao(clsHOCSINH_DTO hs,RadioButton dieuKien)
        {
            return hocSinh_DAO.timHocSinhNangCao(hs, dieuKien.Text);
        }

    }     
}