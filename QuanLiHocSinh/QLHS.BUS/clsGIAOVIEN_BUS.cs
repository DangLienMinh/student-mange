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
    public class clsGIAOVIEN_BUS
    {
        clsGIAOVIEN_DAO giaoVien_DAO;
        clsGIAOVIEN_DTO giaoVien_DTO;
        DataTable tblGiaoVien;
        private DataRow dr;
        
        public clsGIAOVIEN_BUS() 
        {
            giaoVien_DAO = new clsGIAOVIEN_DAO();
            tblGiaoVien = new DataTable();
        }

        //hiển thị comboBox giới tính
        public void hienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.Items.Add("Nam");
            comboBox.Items.Add("Nữ");
            comboBox.SelectedItem = "Nam";
        }

        //hiển thị thông tin giáo viên lên comboBox trên grid
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cboColumn)
        {
            cboColumn.DataSource = giaoVien_DAO.danhSachGiaoVien();
            cboColumn.DisplayMember = "TenGV";
            cboColumn.ValueMember = "MaGV";
            cboColumn.DataPropertyName = "MAGV";
        }

        //trảvề datatable giáo viên
        public DataTable hienThiDanhSach()
        {
            tblGiaoVien = giaoVien_DAO.danhSachGiaoVien();
            return tblGiaoVien;
        }

        //tạo mã giáo viên
        public string hienThiSoNguoi()
        {
            string result;
            int temp = giaoVien_DAO.soGiaoVien() + 1;
            if (temp < 10)
            {
                result = "00" + temp.ToString();
            }
            else if (temp >= 10 && temp < 100)
            {
                result = "0" + temp.ToString();
            }
            else
            {
                result = temp.ToString();
            }
            return result;
        }

        //tìm giáo viên teo mã giáo viên
        public DataTable timGVMaGV(string maGV)
        {
            giaoVien_DTO = new clsGIAOVIEN_DTO();
            giaoVien_DTO.Magv = maGV;
            tblGiaoVien = giaoVien_DAO.timGVMaGV(giaoVien_DTO);
            return  tblGiaoVien;
        }

        //tìm giáo viên theo tên giáo viên
        public DataTable timGVTenGV(string tenGV)
        {
            giaoVien_DTO = new clsGIAOVIEN_DTO();
            giaoVien_DTO.Tengv = tenGV;
            tblGiaoVien = giaoVien_DAO.timGVTenGV(giaoVien_DTO);
            return tblGiaoVien;
        }

        //xóa giáo viên
        public void xoaGiaoVien(string maGV) 
        {
            giaoVien_DTO=new clsGIAOVIEN_DTO();
            giaoVien_DTO.Magv = maGV;
            giaoVien_DAO.xoaGiaoVien(giaoVien_DTO);        
        }

        //thêm một giáo viên mới
        public void themGiaoVien(string maGV,string TenGV, DateTimeInput ngaySinh,string DienThoai,string gioiTinh,string diaChi,string HinhAnh)
        {
            giaoVien_DTO = new clsGIAOVIEN_DTO();
            giaoVien_DTO.Magv = maGV;
            giaoVien_DTO.Tengv = TenGV;
            giaoVien_DTO.Gioitinhgv = gioiTinh;
            giaoVien_DTO.Diachigv = diaChi;
            giaoVien_DTO.Hinhanhgv = HinhAnh;
            giaoVien_DTO.Ngsinhgv = ngaySinh.Value;
            giaoVien_DTO.Dienthoaigv = DienThoai;
            giaoVien_DAO.themGiaoVien(giaoVien_DTO);
        }

        //sửa thông tin giáo viên
        public void suaGiaoVien(string maGV, string TenGV, DateTimeInput ngaySinh, string DienThoai, string gioiTinh, string diaChi, string HinhAnh)
        {
            giaoVien_DTO = new clsGIAOVIEN_DTO();
            giaoVien_DTO.Magv = maGV;
            giaoVien_DTO.Tengv = TenGV;
            giaoVien_DTO.Gioitinhgv = gioiTinh;
            giaoVien_DTO.Diachigv = diaChi;
            giaoVien_DTO.Hinhanhgv = HinhAnh;
            giaoVien_DTO.Ngsinhgv = ngaySinh.Value;
            giaoVien_DTO.Dienthoaigv = DienThoai;
            giaoVien_DAO.suaGiaoVien(giaoVien_DTO);
        }

        //trả về một datarow của table giáo viên
        private DataRow getDatarow()
        {
            dr = tblGiaoVien.NewRow();
            dr["MAGV"] = giaoVien_DTO.Magv;
            dr["TENGV"] = giaoVien_DTO.Tengv;
            dr["NGSINHGV"] = giaoVien_DTO.Ngsinhgv.ToString("dd/MM/yyyy");
            dr["DIACHIGV"] = giaoVien_DTO.Diachigv;
            if (string.Compare(giaoVien_DTO.Gioitinhgv,"0")==0)
            {
                dr["GIOITINHGV"] = "Nam";
            }
            else
            {
                dr["GIOITINHGV"] = "Nữ";
            }

            dr["DIENTHOAIGV"] =  giaoVien_DTO.Dienthoaigv;
            dr["HINHANHGV"] = giaoVien_DTO.Hinhanhgv;
            return dr;
        }

        //thêm dòng vừa được thêm vào table giáo viên
        public void themDong() 
        {
            tblGiaoVien.Rows.Add(getDatarow());
        }

        //xóa giáo viên theo mã giáo viên khỏi table giáo viên
        public void xoaDong(string MaGV)
        {
            DataRow row = tblGiaoVien.Select("MAGV='" + MaGV + "'")[0];
            row.Delete();
        }

        //sửa thông tin trên datatable giáo viên dựa vào giaoVien_DTO
        public void suaDataGrid()
        {
            foreach (DataRow row1 in tblGiaoVien.Rows)
            {
                if (row1["MAGV"] != null)
                {
                    if (string.Compare(row1["MAGV"].ToString().Trim(), giaoVien_DTO.Magv.Trim()) == 0)
                    {
                        row1["TENGV"] = giaoVien_DTO.Tengv;
                        row1["NGSINHGV"] = giaoVien_DTO.Ngsinhgv;
                        row1["DIACHIGV"] = giaoVien_DTO.Diachigv;
                        if (string.Compare(giaoVien_DTO.Gioitinhgv, "0") == 0)
                        {
                            row1["GIOITINHGV"] = "Nam";
                        }
                        else
                        {
                            row1["GIOITINHGV"] = "Nữ";
                        }

                        row1["DIENTHOAIGV"] = giaoVien_DTO.Dienthoaigv;
                        row1["HINHANHGV"] = giaoVien_DTO.Hinhanhgv;
                    }
                }
            }
            //foreach (DataGridViewRow row1 in grdGV.Rows)
            //{
            //    if (row1.Cells["MAGV"].Value != null)
            //    {
            //        if (string.Compare(row1.Cells["MAGV"].Value.ToString().Trim(), giaoVien_DTO.Magv.Trim()) == 0)
            //        {
            //            row1.Cells["TENGV"].Value = giaoVien_DTO.Tengv;
            //            row1.Cells["NGSINHGV"].Value = giaoVien_DTO.Ngsinhgv;
            //            row1.Cells["DIACHIGV"].Value = giaoVien_DTO.Diachigv;
            //            if (string.Compare(giaoVien_DTO.Gioitinhgv, "0") == 0)
            //            {
            //                row1.Cells["GIOITINHGV"].Value = "Nam";
            //            }
            //            else
            //            {
            //                row1.Cells["GIOITINHGV"].Value = "Nữ";
            //            }

            //            row1.Cells["DIENTHOAIGV"].Value = giaoVien_DTO.Dienthoaigv;
            //            row1.Cells["HINHANHGV"].Value = giaoVien_DTO.Hinhanhgv;
            //        }
            //    }
            //}
        }
    }
}
