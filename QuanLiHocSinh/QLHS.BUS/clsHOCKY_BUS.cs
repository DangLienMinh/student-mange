using System;
using System.Collections.Generic;
using System.Text;
using QLHS.DAO;
using QLHS.DTO;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;
using System.Windows.Forms;
using System.Data;

namespace QLHS.BUS
{
    public class clsHOCKY_BUS
    {
        clsHOCKY_DAO hocKy_DAO;
        clsHOCKY_DTO hocKy_DTO;
        DataTable tblHocKy;
        private DataRow dr;

        public clsHOCKY_BUS()
        {
            hocKy_DAO = new clsHOCKY_DAO();
            tblHocKy = new DataTable();
        }

        public void hienThiDanhSach(DataGridViewX grdHocKy)
        {
            tblHocKy = hocKy_DAO.danhSachHocKy();
            grdHocKy.DataSource = tblHocKy;
        }

        //comboBox hệ số học kỳ
        public void hienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.Items.Add("1");
            comboBox.Items.Add("2");
            comboBox.Items.Add("3");
            comboBox.SelectedItem = "1";
        }

        public void themHocKy(string maHK, string tenHK,string heSo)
        {
            hocKy_DTO = new clsHOCKY_DTO();
            hocKy_DTO.Mahk = maHK;
            hocKy_DTO.Tenhk = tenHK;
            hocKy_DTO.Hesohk = heSo;
            hocKy_DAO.themHocKy(hocKy_DTO);
        }

        public void suaHocKy(string maHK, string tenHK, string heSo)
        {
            hocKy_DTO = new clsHOCKY_DTO();
            hocKy_DTO.Mahk = maHK;
            hocKy_DTO.Tenhk = tenHK;
            hocKy_DTO.Hesohk = heSo;
            hocKy_DAO.suaHocKy(hocKy_DTO);
        }

        private DataRow getDatarow()
        {
            dr = tblHocKy.NewRow();
            dr["MAHK"] = hocKy_DTO.Mahk;
            dr["TENHK"] = hocKy_DTO.Tenhk;
            dr["HESOHK"] = hocKy_DTO.Hesohk;
            return dr;
        }

        //thêm dòng vừa được thêm vào table học kỳ
        public void themDong()
        {
            tblHocKy.Rows.Add(getDatarow());
        }

        public void suaDataGrid(DataGridViewX grdHocKy)
        {
            foreach (DataGridViewRow row1 in grdHocKy.Rows)
            {
                if (row1.Cells["MAHK"].Value != null)
                {
                    if (string.Compare(row1.Cells["MAHK"].Value.ToString().Trim(), hocKy_DTO.Mahk.Trim()) == 0)
                    {
                        row1.Cells["TENHK"].Value = hocKy_DTO.Tenhk;
                        row1.Cells["HESOHK"].Value = hocKy_DTO.Hesohk;

                    }
                }
            }
        }

        public void xoaHocKy(string maHK)
        {
            hocKy_DTO = new clsHOCKY_DTO();
            hocKy_DTO.Mahk = maHK;
            hocKy_DAO.xoaHocKy(hocKy_DTO);
        }

        //xóa học kỳ trùng với mã học kỳ trên table học kỳ
        public void xoaDong(DataGridViewX grdGV, string maHK)
        {
            DataRow row = tblHocKy.Select("MAHK='" + maHK + "'")[0];
            row.Delete();
            grdGV.DataSource = tblHocKy;
        }
    }
}
