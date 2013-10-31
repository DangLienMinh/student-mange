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

        public void cbogiaoVienChuNhiem(ComboBoxEx comboBox)
        {
            comboBox.DataSource = giaoVien_DAO.danhSachGiaoVien();
            comboBox.DisplayMember = "TENGV";
            comboBox.ValueMember = "MAGV";
        }

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
            //string malop;
            //string makhoitao = "LH0000";
            //int maMax = 0;
            //int soDong=lop_DAO.danhsachLop().Rows.Count;
            //if (soDong == 0)
            //{
            //    malop = makhoitao;
            //}
            //else
            //{
            //    for (int i = 0; i < lop_DAO.danhsachLop().Rows.Count; i++)
            //    {
            //        string tam = lop_DAO.danhsachLop().Rows[i]["MALOP"].ToString();
            //        string tam1 = tam.Substring(2, 4);
            //        int tam2 = int.Parse(tam1);
            //        if (tam2 > maMax)
            //            maMax = tam2;
            //    }
            //    maMax++;
            //    if (maMax < 10)
            //    {
            //        malop = "LH000" + maMax.ToString();
            //    }
            //    else
            //    {
            //        if (maMax < 100)
            //        {
            //            malop = "LH00" + maMax.ToString();
            //        }
            //        else
            //        {
            //            if (maMax < 1000)
            //            {
            //                malop = "LH0" + maMax.ToString();
            //            }
            //            else
            //            {
            //                malop = "LH" + maMax.ToString();
            //            }
            //        }
            //    }
            //}
            //return malop;
        }

        public void themLopHoc(clsLOP_DTO lop)
        {
            lop_DAO.themLop(lop);
        }

        public void suaLop(clsLOP_DTO lop)
        {
            lop_DAO.suaLop(lop);
        }

        public DataTable danhSachLop()
        {
            return lop_DAO.danhSachLop();
        }

        public void xoaLop(clsLOP_DTO lop)
        {
            lop_DAO.xoaLop(lop);
        }

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
        public void hienThiLopTheoNamHoc(string maNH, AdvTree tree)
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


    }
}
