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
        clsGIAOVIEN_DAO giaoVien_DAO=new clsGIAOVIEN_DAO();
        clsGIAOVIEN_DTO giaoVien_DTO;
        DataTable tblGiaoVien = new DataTable();
        private DataRow dr;
        //int viTri, Tong;

        
        public clsGIAOVIEN_BUS() 
        {
            //clsGIAOVIEN_DAO giaoVien_DAO = new clsGIAOVIEN_DAO();
        }

        //private void sapXep(Form form,TextBox txtCurrent)
        //{
        //    viTri = form.BindingContext[].Position;
        //    Tong = form.BindingContext[tblGiaoVien].Count;
        //    txtCurrent.Text = "" + (viTri + 1).ToString() + "/" + Tong.ToString();
        //    txtten.Text = dataGridView1.Rows[a].Cells[1].Value.ToString();
        //    txtmssv.Text = dataGridView1.Rows[a].Cells[0].Value.ToString();
        //    txtngaysinh.Text = dataGridView1.Rows[a].Cells[2].Value.ToString();
        //    txtdiachi.Text = dataGridView1.Rows[a].Cells[3].Value.ToString();
        //}

        public void hienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.Items.Add("Nam");
            comboBox.Items.Add("Nữ");
            comboBox.SelectedItem = "Nam";
        }

        public void hienThiDanhSach(DataGridViewX grdGV)
        {
            tblGiaoVien = giaoVien_DAO.danhSachGiaoVien();
            grdGV.DataSource=tblGiaoVien;

        }

        public void timGVMaGV(DataGridViewX grdGV, string maGV)
        {
            giaoVien_DTO = new clsGIAOVIEN_DTO();
            giaoVien_DTO.Magv = maGV;
            tblGiaoVien = giaoVien_DAO.timGVMaGV(giaoVien_DTO);
            grdGV.DataSource = tblGiaoVien;
        }

        public void timGVTenGV(DataGridViewX grdGV,string tenGV)
        {
            giaoVien_DTO = new clsGIAOVIEN_DTO();
            giaoVien_DTO.Tengv = tenGV;
            tblGiaoVien = giaoVien_DAO.timGVTenGV(giaoVien_DTO);
            grdGV.DataSource = tblGiaoVien;
        }

        public void xoaGiaoVien(string maGV) 
        {
            giaoVien_DTO=new clsGIAOVIEN_DTO();
            giaoVien_DTO.Magv = maGV;
            giaoVien_DAO.xoaGiaoVien(giaoVien_DTO);        
        }

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

        

        private DataRow getDatarow()
        {
            dr = tblGiaoVien.NewRow();
            dr["MAGV"] = giaoVien_DTO.Magv;
            dr["TENGV"] = giaoVien_DTO.Tengv;
            dr["NGSINHGV"] =  giaoVien_DTO.Ngsinhgv;
            dr["DIACHIGV"] = giaoVien_DTO.Diachigv;
            dr["GIOITINHGV"] = giaoVien_DTO.Gioitinhgv;
            dr["DIENTHOAIGV"] =  giaoVien_DTO.Dienthoaigv;
            dr["HINHANHGV"] = giaoVien_DTO.Hinhanhgv;
            return dr;
        }

        //add dong vua them vao
        public void themDong() 
        {
            tblGiaoVien.Rows.Add(getDatarow());
        }

        public void xoaDong(DataGridViewX grdGV,string MaGV)
        {
            DataRow row = tblGiaoVien.Select("MAGV='" + MaGV + "'")[0];
            row.Delete();
            grdGV.DataSource = tblGiaoVien;
        }

        public void suaDataGrid(DataGridViewX grdGV)
        {
            foreach (DataGridViewRow row1 in grdGV.Rows)
            {
                if (row1.Cells["MAGV"].Value != null)
                {
                    if (string.Compare(row1.Cells["MAGV"].Value.ToString().Trim(), giaoVien_DTO.Magv.Trim()) == 0)
                    {
                        row1.Cells["TENGV"].Value = giaoVien_DTO.Tengv;
                        row1.Cells["NGSINHGV"].Value = giaoVien_DTO.Ngsinhgv;
                        row1.Cells["DIACHIGV"].Value = giaoVien_DTO.Diachigv;
                        row1.Cells["GIOITINHGV"].Value = giaoVien_DTO.Gioitinhgv;
                        row1.Cells["DIENTHOAIGV"].Value = giaoVien_DTO.Dienthoaigv;
                        row1.Cells["HINHANHGV"].Value = giaoVien_DTO.Hinhanhgv;
                    }
                }
            }
        }

    }
}
