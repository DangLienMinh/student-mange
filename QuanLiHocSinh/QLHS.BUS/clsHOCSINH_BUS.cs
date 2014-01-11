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

        //thêm một học sinh mới
        public void themHocSinh(clsHOCSINH_DTO hs)
        {
            hocSinh_DAO.themHocSinh(hs);
        }

        //trả về tên học sinh dựa trên mã học sinh
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

        //sửa một học sinh
        public void suaHocSinh(clsHOCSINH_DTO hs)
        {
            hocSinh_DAO.suaHocSinh(hs);
        }

        //xóa một học sinh
        public void xoaHocSinh(clsHOCSINH_DTO hs)
        {
            hocSinh_DAO.xoaHocSinh(hs);
        }

        //hiển thị comboBox giới tính
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
                int tam2 = int.Parse(max.ToString().Substring(0, 4));
                if (tam2 != DateTime.Now.Year)
                {
                    maHS = DateTime.Now.Year.ToString() + "0000";
                }
                else
                {
                    maHS = namHienTai + max.ToString().Trim().Substring(4, 4);
                }
            }
            return maHS;
        }

        //danh sách học sinh
        public DataTable danhSachHocSinh()
        {
            DataTable table = hocSinh_DAO.danhSachHocSinh();
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    if (row["MAHS"] != null)
                    {
                        if (row["GIOITINHHS"].ToString() == "0")
                        {
                            row["GIOITINHHS"]= "Nữ";
                        }
                        else
                        {
                            row["GIOITINHHS"] = "Nam";
                        }
                    }
                }
            }
            return table;
        }

        //thông tin tuổi tối đa
        public int TuoiToiDa()
        {
           int tuoitoida = 0;
           DataTable table= hocSinh_DAO.TuoiToiDa();
           if (table.Rows.Count > 0)
           {
               tuoitoida = int.Parse(table.Rows[0]["GIATRI"].ToString());
           }
           return tuoitoida;
        }

        //thông tin tuổi tối thiểu
        public int TuoiToiThieu()
        {
            int tuoitoithieu = 0;
            DataTable table = hocSinh_DAO.TuoiToiThieu();
            if (table.Rows.Count > 0)
            {
                tuoitoithieu = int.Parse(table.Rows[0]["GIATRI"].ToString());
            }
            return tuoitoithieu;
        }

        // REPORT danh sách học sinh theo năm học và lớp
        public DataSet danhSachHocSinh_NH_LOP(string manh, string malop)
        {
            DataSet ds = hocSinh_DAO.danhSachHocSinh_NH_LOP(manh, malop);
            if (ds.Tables["DanhSachHocSinh"].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables["DanhSachHocSinh"].Rows)
                {
                    if (row["MAHS"] != null)
                    {
                        if (row["GIOITINHHS"].ToString() == "0")
                        {
                            row["GIOITINHHS"] = "Nữ";
                        }
                        else
                        {
                            row["GIOITINHHS"] = "Nam";
                        }
                    }
                }
            }
            return ds;
        }

        //hiển thị cboHocSinh theo mã năm học và mã lớp
        public void HienThicbodsHocSinh(ComboBoxEx cboHocSinh,string manh,string malop)
        {
            cboHocSinh.DataSource = hocSinh_DAO.danhSachHocSinh_NH_LOP(manh,malop).Tables["DanhSachHocSinh"];
            cboHocSinh.DisplayMember = "TENHS";
            cboHocSinh.ValueMember = "MAHS";

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

        //load ma lop dua vao ten lop
        public string layMaLop(ComboBoxEx comboBox, AdvTree tree)
        {
            string temp = "";
           
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
            return temp;
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

        //load danh sách học sinh vào list
        public void danhSachHocSinhTheoLop(ComboBoxEx cboNamHoc, ComboBoxEx cboLop,ListViewEx list,ComboBoxEx cboPhanBan)
        {
            list.Items.Clear();
            lop_DTO = new clsLOP_DTO();
            lop_DTO.Malop = cboLop.SelectedValue.ToString();
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
           
           cboPhanBan.SelectedValue = lop_DAO.phanBan(lop_DTO);
        }

        //load thông tin học sinh vào comBoBox theo năm học và lớp
        public void danhSachHocSinhTheoLop(ComboBoxEx comboNamHoc, ComboBoxEx comboLop,ComboBoxEx cboHocSinh)
        {
            hocSinh_DTO.Manh = comboNamHoc.SelectedValue.ToString();
            hocSinh_DTO.Malop = comboLop.SelectedValue.ToString();
            tbHocSinh = hocSinh_DAO.danhSachHocSinhTheoLop(hocSinh_DTO);
            cboHocSinh.DataSource = tbHocSinh;
            cboHocSinh.DisplayMember = "TENHS";
            cboHocSinh.ValueMember = "MAHS";
        }

        //danh sách phân lớp của học sinh theo năm học
        public DataTable danhSachPhanLop(ComboBoxEx comboNamHoc)
        {
            hocSinh_DTO.Manh = comboNamHoc.SelectedValue.ToString();
            tbHocSinh = hocSinh_DAO.danhSachPhanLop(hocSinh_DTO);
            return tbHocSinh;
        }

        //thêm phân lớp
        public void themPhanLop(ComboBoxEx comboNamHoc, ComboBoxEx comboLop,ListViewEx lstHocSinh)
        {
            lop_DTO = new clsLOP_DTO();
            namHoc_DTO = new clsNAMHOC_DTO();

            lop_DTO.Malop = comboLop.SelectedValue.ToString();
            namHoc_DTO.Manh = comboNamHoc.SelectedValue.ToString();
            DateTime thoiGianHieuLuc=DateTime.Now;
            foreach (ListViewItem item in lstHocSinh.Items)
            {
                hocSinh_DTO = new clsHOCSINH_DTO();
                hocSinh_DTO.Mahs = item.SubItems[1].Text.ToString();
                try
                {
                    hocSinh_DAO.themPhanLop(hocSinh_DTO, namHoc_DTO, lop_DTO, thoiGianHieuLuc);
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }

        //phân lớp cho học sinh vừa mới được tiếp nhận
        public void phanLopHocSinhLop10(ComboBoxEx comboNamHoc, ComboBoxEx comboLop, ListViewEx lstHocSinh)
        {
            lop_DTO = new clsLOP_DTO();
            namHoc_DTO = new clsNAMHOC_DTO();

            lop_DTO.Malop = comboLop.SelectedValue.ToString();
            namHoc_DTO.Manh = comboNamHoc.SelectedValue.ToString();
            DateTime thoiGianHieuLuc = DateTime.Now;
            foreach (ListViewItem item in lstHocSinh.Items)
            {
                hocSinh_DTO = new clsHOCSINH_DTO();
                hocSinh_DTO.Mahs = item.SubItems[1].Text.ToString();
                //hocSinh_DTO.Thoigianhieuluc = ;
                
                try
                {
                    hocSinh_DAO.themPhanLop(hocSinh_DTO, namHoc_DTO, lop_DTO,thoiGianHieuLuc);
                }
                catch (Exception)
                {
                    continue;
                }
                
            }
        }

        //xóa phân lớp dựa vào mã học sinh
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

        //tìm học sinh theo mã học sinh
        public DataTable timHocSinhMaHS(TextBoxX maHS)
        {
            clsHOCSINH_DTO hs = new clsHOCSINH_DTO();
            hs.Mahs = maHS.Text;
            return hocSinh_DAO.timHocSinhMaHS(hs);
        }

        //tìm học sinh chuyển lớp//////////////////////////////////////////////////////////////////////////
        public void timHocSinhChuyenLop(TextBoxX maHS, ComboBoxEx cboNamHoc, ComboBoxEx cboLop, ListViewEx lstHocSinh)
        {
            
            DataTable temp;
            clsHOCSINH_DTO hs = new clsHOCSINH_DTO();
            hs.Mahs = maHS.Text;
            temp = hocSinh_DAO.timHocSinhChuyenLop(hs);
            int i = 0;
            
            foreach (DataRow row in temp.Rows)
            {
                cboNamHoc.SelectedValue = row["MANH"];
                cboLop.SelectedValue = row["MALOP"];
                ++i;
                ListViewItem item = new ListViewItem();
                item.Text = i.ToString();
                item.SubItems.Add(row["MAHS"].ToString());
                item.SubItems.Add(row["TENHS"].ToString());

                lstHocSinh.Items.Clear();
                lstHocSinh.Items.Add(item);
            }

        }

        //tìm học sinh theo tên học sinh
        public DataTable timHocSinhTenHS(TextBoxX tenHS)
        {
            clsHOCSINH_DTO hs = new clsHOCSINH_DTO();
            hs.Tenhs = tenHS.Text;
           return hocSinh_DAO.timHocSinhTenHS(hs); ;
        }

        //tìm học sinh theo dân tộc
        public DataTable timHocSinhDanToc(TextBoxX danToc)
        {
            clsHOCSINH_DTO hs = new clsHOCSINH_DTO();
            hs.Dantoc = danToc.Text;
            return  hocSinh_DAO.timHocSinhDanToc(hs);
        }

        //tìm học sinh theo ngày nhập học
        public DataTable timHocSinhNgNhapHoc(DateTimeInput ngNhapHoc)
        {
            clsHOCSINH_DTO hs = new clsHOCSINH_DTO();
            hs.Ngnhaphoc = ngNhapHoc.Value;
            return hocSinh_DAO.timHocSinhNgNhapHoc(hs);
        }

        //tìm học sinh nâng cao
        public DataTable timHocSinhNangCao(clsHOCSINH_DTO hs,RadioButton dieuKien)
        {
            return hocSinh_DAO.timHocSinhNangCao(hs, dieuKien.Text);
        }

        //gợi ý thông tin người dùng nhập vào ô textbox
        public void autoComplete(TextBoxX textBox,string name)
        {
            AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
            switch (name)
            {
                case "MAHS":
                    {
                        foreach (DataRow row in danhSachHocSinh().Rows)
                        {
                            namesCollection.Add(row["MAHS"].ToString());
                        }
                        textBox.AutoCompleteMode = AutoCompleteMode.Append;
                    }
                    break;
                case "TENHS":
                    {
                        foreach (DataRow row in danhSachHocSinh().Rows)
                        {
                            namesCollection.Add(row["TENHS"].ToString());
                        }
                        textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                    }
                    break;
                case "DANTOC":
                    {
                        foreach (DataRow row in danhSachHocSinh().Rows)
                        {
                            namesCollection.Add(row["DANTOC"].ToString());
                        }
                        textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                    }
                    break;
                default:
                    break;
            }
                     
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox.AutoCompleteCustomSource = namesCollection;
        }

        

    }     
}