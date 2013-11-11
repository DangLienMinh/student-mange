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
    public class clsDIEM_BUS
    {
        clsDIEM_DAO diem_DAO;
        clsHOCSINH_BUS hocSinh_BUS;
        clsLOP_BUS lop_BUS;
        clsDIEM_DTO diem_DTO;
        clsHOCSINH_DTO hocSinh_DTO;
        DataTable tblDiem;
        private DataRow dr;

        public clsDIEM_BUS() 
        {
            hocSinh_BUS = new clsHOCSINH_BUS();
            lop_BUS = new clsLOP_BUS();
            diem_DAO = new clsDIEM_DAO();
            tblDiem = new DataTable();
        }

        public void themDiemTheoHS(ComboBoxEx cboMaNH,ComboBoxEx cboMaHK,ComboBoxEx cboMaLD,ComboBoxEx cboMaMH,ComboBoxEx cboMaHS,TextBoxX txtDiem)
        {
            diem_DTO = new clsDIEM_DTO();
            if (string.Compare(cboMaHK.SelectedItem.ToString(),"Học kỳ 1")==0)
            {
                diem_DTO.Mahk = "HK1";
            }
            else
            {
                diem_DTO.Mahk = "HK2";
            }
            diem_DTO.Manh = cboMaNH.SelectedValue.ToString();
            diem_DTO.Mamh = cboMaMH.SelectedValue.ToString();
            diem_DTO.Mahs = cboMaHS.SelectedValue.ToString();
            diem_DTO.Mald = cboMaLD.SelectedValue.ToString();
            diem_DTO.Diemso = txtDiem.Text;
            if (diem_DTO.Mahs != "" && diem_DTO.Manh != "")
            {
                diem_DTO.Tenhs = hocSinh_BUS.tenHocSinh(diem_DTO.Mahs);
                diem_DTO.Malop = lop_BUS.danhSachLop(diem_DTO.Mahs, diem_DTO.Manh);
            }
            diem_DAO.themDiemTheoHS(diem_DTO);
        }

        public void suaDiemTheoHS(string STT, TextBoxX txtDiem)
        {
            diem_DTO = new clsDIEM_DTO();
            diem_DTO.Diemso = txtDiem.Text;
            diem_DTO.Stt = int.Parse(STT);
            diem_DAO.suaDiemTheoHS(diem_DTO);
        }

        public void xoaDiemTheoHS(string STT)
        {
            diem_DTO = new clsDIEM_DTO();
            diem_DTO.Stt = int.Parse(STT);
            diem_DAO.xoaDiemTheoHS(diem_DTO);
        }

        public void xoaDong(DataGridViewX grdDiemRieng, string STT)
        {
            DataRow row = tblDiem.Select("STT='" + STT + "'")[0];
            row.Delete();
            grdDiemRieng.DataSource = tblDiem;
        }

        public void xoaGiaoVien(string STT)
        {
            diem_DTO = new clsDIEM_DTO();
            diem_DTO.Stt = int.Parse(STT);
            diem_DAO.xoaDiemTheoHS(diem_DTO);
        }

        public void suaDataGrid(DataGridViewX grdDiemRieng)
        {
            foreach (DataGridViewRow row1 in grdDiemRieng.Rows)
            {
                if (row1.Cells["STT"].Value!=null)
                {
                    if ((int.Parse(row1.Cells["STT"].Value.ToString().Trim()) == diem_DTO.Stt))
                    {
                        row1.Cells["DIEMSO1"].Value = diem_DTO.Diemso;
                    }
                    
                }
                
            }
        }

        public void thongTinDiemTheoHS(ComboBoxEx cboMaNH, ComboBoxEx cboMaHK, ComboBoxEx cboMaLD, ComboBoxEx cboMaMH, ComboBoxEx cboMaHS,DataGridViewX grdDiem)
        {
            diem_DTO = new clsDIEM_DTO();
            hocSinh_DTO = new clsHOCSINH_DTO();
            if (string.Compare(cboMaHK.SelectedItem.ToString(), "Học kỳ 1") == 0)
            {
                diem_DTO.Mahk = "HK1";
            }
            else
            {
                diem_DTO.Mahk = "HK2";
            }
            diem_DTO.Manh = cboMaNH.SelectedValue.ToString();
            diem_DTO.Mamh = cboMaMH.SelectedValue.ToString();
            diem_DTO.Mald = cboMaLD.SelectedValue.ToString();
            diem_DTO.Mahs = cboMaHS.SelectedValue.ToString();
            if (diem_DTO.Mahs!=""&&diem_DTO.Manh!="")
            {
                diem_DTO.Tenhs = hocSinh_BUS.tenHocSinh(diem_DTO.Mahs);
                diem_DTO.Malop = lop_BUS.danhSachLop(diem_DTO.Mahs, diem_DTO.Manh);
            }
           
            tblDiem = diem_DAO.thongTinDiemTheoHS(diem_DTO);
            grdDiem.DataSource = tblDiem;
        }

        public int demDiem(ComboBoxEx cboMaNH,ComboBoxEx cboMaHK,ComboBoxEx cboMaLD,ComboBoxEx cboMaMH,ComboBoxEx cboMaHS)
        {
            diem_DTO = new clsDIEM_DTO();
            diem_DTO.Mahk = cboMaHK.SelectedItem.ToString();
            diem_DTO.Manh = cboMaNH.SelectedValue.ToString();
            diem_DTO.Mamh = cboMaMH.SelectedValue.ToString();
            diem_DTO.Mald = cboMaLD.SelectedValue.ToString();
            diem_DTO.Mahs = cboMaHS.SelectedValue.ToString();
            return diem_DAO.demDiem(diem_DTO);
        }

        private DataRow getDatarow()
        {
            dr = tblDiem.NewRow();
            dr["MAHS"] = diem_DTO.Mahs;
            dr["MAHK"] = diem_DTO.Mahk;
            dr["MAMH"] = diem_DTO.Mamh;
            dr["MANH"] = diem_DTO.Manh;
            dr["MALD"] = diem_DTO.Mald;
            dr["DIEMSO"] = diem_DTO.Diemso;
            dr["MALOP"] = diem_DTO.Malop;
            dr["TENHS"] = diem_DTO.Tenhs;
            return dr;
        }

        //thêm dòng vừa được thêm vào table giáo viên
        public void themDong()
        {
            tblDiem.Rows.Add(getDatarow());
        }
    }
}
