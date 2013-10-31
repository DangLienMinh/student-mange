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
    public class clsLOAIDIEM_BUS
    {
        clsLOAIDIEM_DAO loaiDiem_DAO;
        clsLOAIDIEM_DTO loaiDiem_DTO;
        DataTable tblLoaiDiem;
        private DataRow dr;

        //Hệ số loại điểm
        public void hienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.Items.Add("1");
            comboBox.Items.Add("2");
            comboBox.Items.Add("3");
            comboBox.SelectedItem = "1";
        }

        public clsLOAIDIEM_BUS()
        {
            loaiDiem_DAO = new clsLOAIDIEM_DAO();
            tblLoaiDiem = new DataTable();
        }

        public void hienThiDanhSach(DataGridViewX grdLoaiDiem)
        {
            tblLoaiDiem = loaiDiem_DAO.danhSachLoaiDiem();
            grdLoaiDiem.DataSource = tblLoaiDiem;
        }

        public void themLoaiDiem(string maLD, string tenLD,string heSo)
        {
            loaiDiem_DTO = new clsLOAIDIEM_DTO();
            loaiDiem_DTO.Mald = maLD;
            loaiDiem_DTO.Tenld = tenLD;
            loaiDiem_DTO.Hesold = heSo;
            loaiDiem_DAO.themLoaiDiem(loaiDiem_DTO);
        }

        public void suaLoaiDiem(string maLD, string tenLD,string heSo)
        {
            loaiDiem_DTO = new clsLOAIDIEM_DTO();
            loaiDiem_DTO.Mald = maLD;
            loaiDiem_DTO.Tenld = tenLD;
            loaiDiem_DTO.Hesold = heSo;
            loaiDiem_DAO.suaLoaiDiem(loaiDiem_DTO);
        }

        public void xoaLoaiDiem(string maLD)
        {
            loaiDiem_DTO = new clsLOAIDIEM_DTO();
            loaiDiem_DTO.Mald = maLD;
            loaiDiem_DAO.xoaLoaiDiem(loaiDiem_DTO);
        }

        private DataRow getDatarow()
        {
            dr = tblLoaiDiem.NewRow();
            dr["MALD"] = loaiDiem_DTO.Mald;
            dr["TENLD"] = loaiDiem_DTO.Tenld;
            dr["HESOLD"] = loaiDiem_DTO.Hesold;
           
            return dr;
        }

        //thêm dòng vừa được thêm vào table loại điểm
        public void themDong()
        {
            tblLoaiDiem.Rows.Add(getDatarow());
        }

        public void suaDataGrid(DataGridViewX grdLoaiDiem)
        {
            foreach (DataGridViewRow row1 in grdLoaiDiem.Rows)
            {
                if (row1.Cells["MALD"].Value != null)
                {
                    if (string.Compare(row1.Cells["MALD"].Value.ToString().Trim(), loaiDiem_DTO.Mald.Trim()) == 0)
                    {
                        row1.Cells["TENLD"].Value = loaiDiem_DTO.Tenld;
                        row1.Cells["HESOLD"].Value = loaiDiem_DTO.Hesold;
                    }
                }
            }
        }

        //xóa loại điểm trùng với mã loại điểm trên table loại điểm
        public void xoaDong(DataGridViewX grdLoaiDiem, string maLD)
        {
            DataRow row = tblLoaiDiem.Select("MALD='" + maLD + "'")[0];
            row.Delete();
            grdLoaiDiem.DataSource = tblLoaiDiem;
        }
    }
}
