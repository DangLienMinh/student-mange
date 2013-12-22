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

        public clsLOAIDIEM_BUS()
        {
            loaiDiem_DAO = new clsLOAIDIEM_DAO();
            tblLoaiDiem = new DataTable();
        }

        //Hệ số loại điểm
        public void hienThiComboBoxHeSo(ComboBoxEx comboBox)
        {
            comboBox.Items.Add("1");
            comboBox.Items.Add("2");
            comboBox.Items.Add("3");
            comboBox.SelectedItem = "1";
        }

        //hiển thị comboBox loại điểm
        public void hienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = loaiDiem_DAO.danhSachLoaiDiem();
            comboBox.DisplayMember = "TENLD";
            comboBox.ValueMember = "MALD";
        }

        //hiển thị comboBox loại điểm lên datagrid
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cboColumn)
        {
            cboColumn.DataSource = loaiDiem_DAO.danhSachLoaiDiem();
            cboColumn.DisplayMember = "TENLD";
            cboColumn.ValueMember = "MALD";
            cboColumn.DataPropertyName = "MALD";
        }      

        //hiển thị danh sách loại điểm vào datatable
        public DataTable hienThiDanhSach()
        {
            tblLoaiDiem = loaiDiem_DAO.danhSachLoaiDiem();
           return tblLoaiDiem;
        }

        //thêm một loại điểm mới
        public void themLoaiDiem(string maLD, string tenLD, string heSo)
        {
            loaiDiem_DTO = new clsLOAIDIEM_DTO();
            loaiDiem_DTO.Mald = maLD;
            loaiDiem_DTO.Tenld = tenLD;
            loaiDiem_DTO.Hesold = heSo;
            loaiDiem_DAO.themLoaiDiem(loaiDiem_DTO);
        }

        //sửa một loại điểm đã có
        public void suaLoaiDiem(string maLD, string tenLD,string heSo)
        {
            loaiDiem_DTO = new clsLOAIDIEM_DTO();
            loaiDiem_DTO.Mald = maLD;
            loaiDiem_DTO.Tenld = tenLD;
            loaiDiem_DTO.Hesold = heSo;
            loaiDiem_DAO.suaLoaiDiem(loaiDiem_DTO);
        }

        //xóaloại điểm
        public void xoaLoaiDiem(string maLD)
        {
            loaiDiem_DTO = new clsLOAIDIEM_DTO();
            loaiDiem_DTO.Mald = maLD;
            loaiDiem_DAO.xoaLoaiDiem(loaiDiem_DTO);
        }

        //trả về một dòng trên loại điểm
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

        //sửa trên datatable loại điểm để từ đó sửa trên grid
        public void suaDataGrid(DataGridViewX grdLoaiDiem)
        {
            foreach (DataRow row1 in tblLoaiDiem.Rows)
            {
                if (row1["MALD"] != null)
                {
                    if (string.Compare(row1["MALD"].ToString().Trim(), loaiDiem_DTO.Mald.Trim()) == 0)
                    {
                        row1["TENLD"] = loaiDiem_DTO.Tenld;
                        row1["HESOLD"] = loaiDiem_DTO.Hesold;
                    }
                }
            }
        }

        //xóa loại điểm trùng với mã loại điểm trên table loại điểm
        public void xoaDong( string maLD)
        {
            DataRow row = tblLoaiDiem.Select("MALD='" + maLD + "'")[0];
            row.Delete();
        }

        //trả về thông tin hệ số loại điểm
        public int heSoLoaiDiem(string maLD)
        {
            loaiDiem_DTO = new clsLOAIDIEM_DTO();
            loaiDiem_DTO.Mald = maLD;
            return loaiDiem_DAO.heSoLoaiDiem(loaiDiem_DTO);
        }
    }
}
