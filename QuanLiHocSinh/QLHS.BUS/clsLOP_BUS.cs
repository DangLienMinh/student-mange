using System;
using System.Collections.Generic;
using System.Text;
using QLHS.DAO;
using QLHS.DTO;
using DevComponents.DotNetBar.Controls;
using DevComponents.AdvTree;
using DevComponents.Editors.DateTimeAdv;
using System.Windows.Forms;
using System.Data;


namespace QLHS.BUS
{
    public class clsLOP_BUS
    {
        private clsLOP_DAO lop_DAO;
        private clsLOP_DTO lop_DTO;
        private DataTable tblLop;
        private clsGIAOVIEN_DAO giaoVien_DAO;

        public clsLOP_BUS()
        {
            lop_DAO = new clsLOP_DAO();
            tblLop = new DataTable();
            lop_DTO = new clsLOP_DTO();
            giaoVien_DAO = new clsGIAOVIEN_DAO();
        }

        public DataSet reportDanhSachLop()
        {
            return lop_DAO.reportDanhSachLop();
        }

        public void cboGiaoVienChuNhiem(ComboBoxEx comboBox)
        {
            comboBox.DataSource = giaoVien_DAO.danhSachGiaoVien();
            comboBox.DisplayMember = "TENGV";
            comboBox.ValueMember = "MAGV";
        }

        public void cboBan(ComboBoxEx comboBox)
        {
            comboBox.DataSource = lop_DAO.danhSachBan();
            comboBox.DisplayMember = "TENBAN";
            comboBox.ValueMember = "MABAN";
        }

        public int siSoLop(ComboBoxEx cboMaLop)
        {
            lop_DTO=new clsLOP_DTO();
            lop_DTO.Malop=cboMaLop.SelectedValue.ToString();
            return lop_DAO.siSoLop(lop_DTO);
 
        }

        public void hienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cboColumn)
        {
            cboColumn.DataSource = lop_DAO.danhSachLop();
            cboColumn.DisplayMember = "TENLOP";
            cboColumn.ValueMember = "MALOP";
            cboColumn.DataPropertyName = "MALOP";
        }

        public void hienThiDataGridViewComboBoxColumnBan(DataGridViewComboBoxColumn cboColumn)
        {
            cboColumn.DataSource = lop_DAO.danhSachBan();
            cboColumn.DisplayMember = "TENBAN";
            cboColumn.ValueMember = "MABAN";
            cboColumn.DataPropertyName = "MABAN";
        }

        //public void hienThiComboBoxBan(ComboBoxEx comboBox)
        //{
        //    comboBox.Items.Add("Khoa học tự nhiên");
        //    comboBox.Items.Add("Khoa học xã hội và Nhân văn");
        //    comboBox.Items.Add("Cơ bản");
        //    comboBox.SelectedItem = "Khoa học tự nhiên";
        //}

        //tạo mã lớp dựa vào năm hiện hành 
        public string taoMaLop()
        {
            string result;
            string year=DateTime.Now.Year.ToString();
            int temp = lop_DAO.soLop(year) + 1;
            if (temp < 10)
            {
                result = "L"+year.Substring(year.Length-2)+"0" + temp.ToString();
            }
            else
            {
                result = "L"+year.Substring(year.Length-2)+temp.ToString();
            }
            return result;
        }

        public void themLopHoc(clsLOP_DTO lop)
        {
            lop_DAO.themLop(lop);
        }

        public void suaLop(clsLOP_DTO lop)
        {
            lop_DAO.suaLop(lop);
        }

       

        public string danhSachLop(string maHS,string maNH)
        {
            string text = "";
            DataTable temp = new DataTable();
            temp=lop_DAO.danhSachLop(maHS, maNH);
            if (temp.Rows.Count>0)
            {
                return temp.Rows[0][0].ToString();
                
            }
            return text;
            
        }

        public void xoaLop(clsLOP_DTO lop)
        {
            lop_DAO.xoaLop(lop);
        }

        public DataTable danhSachLop()
        {
            DataTable table= lop_DAO.danhSachLop();
            return table;
        }

        
        //public void taiLaiDataGrid(DataGridViewX grdLop)
        //{
        //    if (grdLop.Rows.Count > 0)
        //    {
        //        foreach (DataGridViewRow row in grdLop.Rows)
        //        {
        //            if (row.Cells["MALOP1"].Value != null)
        //            {
        //                if (row.Cells["BAN1"].Value.ToString() == "KHTN")
        //                {
        //                    row.Cells["BAN1"].Value = "Khoa học tự nhiên";
        //                }
        //                else if (row.Cells["BAN1"].Value.ToString() == "CB")
        //                {
        //                    row.Cells["BAN1"].Value = "Cơ bản";
        //                }
        //                else
        //                {
        //                    row.Cells["BAN1"].Value = "Khoa học xã hội và Nhân văn";
        //                }
        //            }
        //        }
        //    }
        //}

       

        //public void taiLaiDataGrid(DataGridViewX grdLop, DataTable dsLop)
        //{
        //    grdLop.DataSource = dsLop;
        //    if (grdLop.Rows.Count > 0)
        //    {
        //        foreach (DataGridViewRow row in grdLop.Rows)
        //        {
        //            if (row.Cells["MALOP1"].Value != null)
        //            {
        //                if (row.Cells["BAN1"].Value.ToString() == "KHTN")
        //                {
        //                    row.Cells["BAN1"].Value = "Khoa học tự nhiên";
        //                }
        //                else if (row.Cells["BAN1"].Value.ToString() == "CB")
        //                {
        //                    row.Cells["BAN1"].Value = "Cơ bản";
        //                }
        //                else
        //                {
        //                    row.Cells["BAN1"].Value = "Khoa học xã hội và Nhân văn";
        //                }
        //            }
        //        }
        //    }
        //}

        //chỉ chọn lớp 10 của năm học đó
        public void cboLop10(ComboBoxEx comboBox, string nam)
        {
            comboBox.DataSource = lop_DAO.chonLop10(nam);
            comboBox.DisplayMember = "TENLOP";
            comboBox.ValueMember = "MALOP";
        }

















        ////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// form danh sách học sinh theo lớp
        /// Minh
        /// </summary>
        /// <param name="maNH"></param>
        /// <param name="tree"></param>
        public void hienThiTreeLopTheoNamHoc(string maNH, AdvTree tree)
        {
            Node temp;
            lop_DTO = new clsLOP_DTO();
            lop_DTO.Manh = maNH;
            tblLop = lop_DAO.danhSachLopTheoNamHoc(lop_DTO);
            Node k10 = new Node("Khối 10");
            Node k11 = new Node("Khối 11");
            Node k12 = new Node("Khối 12");

            foreach (DataRow row in tblLop.Rows)
            {
                if (row["MAKHOI"].ToString().IndexOf("10") != -1)
                {
                    temp = new Node(row["TENLOP"].ToString());
                    k10.Nodes.Add(temp);
                }
                else if (row["MAKHOI"].ToString().IndexOf("11") != -1)
                {
                    temp = new Node(row["TENLOP"].ToString());
                    k11.Nodes.Add(temp);
                }
                else
                {
                    temp = new Node(row["TENLOP"].ToString());
                    k12.Nodes.Add(temp);
                }

            }

            tree.Nodes.Add(k10);
            tree.Nodes.Add(k11);
            tree.Nodes.Add(k12);
        }

        public void hienThiCboLopTheoNamHoc(string maNH, ComboBoxEx cboLop)
        {
            lop_DTO = new clsLOP_DTO();
            lop_DTO.Manh = maNH;
            tblLop = lop_DAO.danhSachLopTheoNamHoc(lop_DTO);
            cboLop.DataSource = tblLop;
            cboLop.DisplayMember = "TENLOP";
            cboLop.ValueMember = "MALOP";
        }

        public void hienThiCbLopTheoNamHocKhoi(string maNH, ComboBoxEx comboBoxLop, string maKhoi)
        {
            
            lop_DTO = new clsLOP_DTO();
            lop_DTO.Manh = maNH;
            lop_DTO.Makhoi = maKhoi;
            tblLop = lop_DAO.danhSachLopTheoNamHocKhoi(lop_DTO);
           
            comboBoxLop.DataSource = tblLop;
            comboBoxLop.DisplayMember = "TENLOP";
            comboBoxLop.ValueMember = "MALOP";
        }

        public string layMaLopTrenTree(ComboBoxEx comboBox, AdvTree tree)
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

        public string layPhanBan(string maLop)
        {
            lop_DTO = new clsLOP_DTO();
            lop_DTO.Malop = maLop;
             return  lop_DAO.phanBan(lop_DTO);
        }

    }
}
