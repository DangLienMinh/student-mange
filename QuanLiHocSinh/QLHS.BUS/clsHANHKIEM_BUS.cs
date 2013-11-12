﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLHS.DAO;
using QLHS.DTO;
using DevComponents.AdvTree;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
namespace QLHS.BUS
{
    public class clsHANHKIEM_BUS
    {
        private clsHOCKY_DAO hocky;
        private clsNAMHOC_DAO namhoc;
        private clsKHOI_DAO khoi_dao;
        private clsLOP_DAO lop;
        private clsLOAIHANHKIEM_DAO loaihk;
        //private clsKHOI_DTO khoi_dto;
        public clsHANHKIEM_BUS()
        {
            hocky = new clsHOCKY_DAO();
            namhoc = new clsNAMHOC_DAO();
            //khoi_dto = new clsKHOI_DTO();
            khoi_dao = new clsKHOI_DAO();
            lop = new clsLOP_DAO();
            loaihk = new clsLOAIHANHKIEM_DAO();
        }
        public void hienThicboHK(ComboBoxEx comboBox)
        {
            comboBox.DataSource = hocky.danhSachHocKy();
            comboBox.DisplayMember = "TENHK";
            comboBox.ValueMember = "MAHK";
        }
        public void hienthicboNamHoc(ComboBoxEx comboBox)
        {
            comboBox.DataSource = namhoc.danhSachNamHoc();
            comboBox.DisplayMember = "TENNH";
            comboBox.ValueMember = "MANH";
        }
        public void hienthiLophoc(AdvTree trKhoi,ComboBoxEx cboNamhoc)
        {
            DataTable dsKhoi = new DataTable();
            DataTable dsLop = new DataTable();
            dsKhoi = khoi_dao.danhSachKhoi();
            for (int i = 0; i < dsKhoi.Rows.Count; i++)
            {
                if (dsKhoi.Rows[i]["MAKHOI"].ToString() != "")
                {
                    Node k = new Node();
                    k.Text = dsKhoi.Rows[i]["TENKHOI"].ToString();
                    k.Name = dsKhoi.Rows[i]["MAKHOI"].ToString();
                    trKhoi.Nodes.Add(k);
                    //TreeNode k2 = new TreeNode();
                    
                    string Makhoi=dsKhoi.Rows[i]["MAKHOI"].ToString();
                    dsLop = lop.danhsachLopMAKHOI(Makhoi,cboNamhoc.SelectedValue.ToString());
                    for (int j = 0; j < dsLop.Rows.Count; j++)
                    {
                        if (dsLop.Rows[j]["MALOP"].ToString() != "")
                        {
                            Node k1 = new Node();
                            k1.Text = dsLop.Rows[j]["TENLOP"].ToString();
                            k1.Name = dsLop.Rows[j]["MALOP"].ToString();
                            trKhoi.Nodes[i].Nodes.Add(k1);
                        }
                    }
                }
            }
        }
        public void hienthiCboLoaiHK(DataGridViewComboBoxColumn clnHanhkiem)
        {
            clnHanhkiem.DataSource = loaihk.danhsachLoaiHK();
            clnHanhkiem.DisplayMember = "TENLHK";
            clnHanhkiem.ValueMember = "MALHK";
            clnHanhkiem.DataPropertyName = "MALHK";
        }
        //public void 
    }
}
