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
        private DataRow dr;
        private clsGIAOVIEN_DAO giaovien_dao;

        public clsLOP_BUS()
        {
            lop_DAO = new clsLOP_DAO();
            tblLop = new DataTable();
            lop_DTO = new clsLOP_DTO();
            giaovien_dao = new clsGIAOVIEN_DAO();
        }


        public void cboGiaovienchunhiem(ComboBoxEx comboBox)
        {
            comboBox.DataSource = giaovien_dao.danhSachGiaoVien();
            comboBox.DisplayMember = "TENGV";
            comboBox.ValueMember = "MAGV";
        }

        public string taoMalop()
        {
            string malop = "LH";
            if (lop_DAO.danhsachLop().Rows.Count < 10)
            {
                malop = malop +"0"+ lop_DAO.danhsachLop().Rows.Count.ToString();
            }
            else
            {
                malop = malop + lop_DAO.danhsachLop().Rows.Count.ToString();
            }
            return malop;
        }
        public void themLophoc(clsLOP_DTO lop)
        {
            lop_DAO.themLop(lop);
        }
        public void suaLop(clsLOP_DTO lop)
        {
            lop_DAO.suaLop(lop);
        }
        public DataTable danhsachLop()
        {
            return lop_DAO.danhsachLop();
        }
        public void xoaLop(clsLOP_DTO lop)
        {
            lop_DAO.xoaLop(lop);
        }
        public void hienThiLopTheoNamHoc(string maNH, AdvTree tree)
        {
            Node temp;
            lop_DTO = new clsLOP_DTO();
            lop_DTO.Manh = maNH;
            tblLop = lop_DAO.danhsachLopTheoNamHoc(lop_DTO);
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
    }
}
