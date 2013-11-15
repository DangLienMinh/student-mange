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
            diem_DTO.Mahk = cboMaHK.SelectedValue.ToString();
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
            diem_DTO.Mahk = cboMaHK.SelectedValue.ToString();
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

        public void thongTinDiemTheoMaLD(ComboBoxEx cboMaNH, ComboBoxEx cboMaHK, ComboBoxEx cboMaMH, DataGridViewX grdDiem)
        {
            tblDiem = new DataTable();
            diem_DTO = new clsDIEM_DTO();
            hocSinh_DTO = new clsHOCSINH_DTO();
            diem_DTO.Mahk = cboMaHK.SelectedValue.ToString();
            diem_DTO.Manh = cboMaNH.SelectedValue.ToString();
            diem_DTO.Mamh = cboMaMH.SelectedValue.ToString();

            foreach (DataGridViewRow row in grdDiem.Rows)
            {
                if (row.Cells["MAHS"].Value!=null)
                {
                    int i=1;
                    diem_DTO.Mald="LD01";
                    diem_DTO.Mahs = row.Cells["MAHS"].Value.ToString();
                    tblDiem = diem_DAO.thongTinDiemTheoMaLD(diem_DTO);
                    foreach (DataRow item in tblDiem.Rows)
                    {
                        row.Cells["a" + i.ToString()].Value=item[0].ToString();
                        ++i;
                    }

                    i = 1;
                    diem_DTO.Mald = "LD02";
                    diem_DTO.Mahs = row.Cells["MAHS"].Value.ToString();
                    tblDiem = diem_DAO.thongTinDiemTheoMaLD(diem_DTO);
                    foreach (DataRow item in tblDiem.Rows)
                    {
                        row.Cells["b" + i.ToString()].Value = item[0].ToString();
                        ++i;
                    }

                    i = 1;
                    diem_DTO.Mald = "LD03";
                    diem_DTO.Mahs = row.Cells["MAHS"].Value.ToString();
                    tblDiem = diem_DAO.thongTinDiemTheoMaLD(diem_DTO);
                    foreach (DataRow item in tblDiem.Rows)
                    {
                        row.Cells["c" + i.ToString()].Value = item[0].ToString();
                        ++i;
                    }

                    diem_DTO.Mald = "LD04";
                    diem_DTO.Mahs = row.Cells["MAHS"].Value.ToString();
                    tblDiem = diem_DAO.thongTinDiemTheoMaLD(diem_DTO);
                    foreach (DataRow item in tblDiem.Rows)
                    {
                        row.Cells["d1"].Value = item[0].ToString();
                    }
                }
            }
        }

        public void xoaDiemTheoMaLD(ComboBoxEx cboMaNH, ComboBoxEx cboMaHK, ComboBoxEx cboMaMH, DataGridViewX grdDiem)
        {
            tblDiem = new DataTable();
            diem_DTO = new clsDIEM_DTO();
            hocSinh_DTO = new clsHOCSINH_DTO();
            diem_DTO.Mahk = cboMaHK.SelectedValue.ToString();
            diem_DTO.Manh = cboMaNH.SelectedValue.ToString();
            diem_DTO.Mamh = cboMaMH.SelectedValue.ToString();

            foreach (DataGridViewRow row in grdDiem.Rows)
            {
                if (row.Cells["MAHS"].Value != null)
                {
                    diem_DTO.Mald = "LD01";
                    diem_DTO.Mahs = row.Cells["MAHS"].Value.ToString();
                    diem_DAO.xoaDiemTheoMaLD(diem_DTO);
                    if (row.Cells["a1"].Value!=null)
                    {
                        diem_DTO.Diemso=row.Cells["a1"].Value.ToString();
                        diem_DAO.themDiemTheoHS(diem_DTO);
                    }
                    if (row.Cells["a2"].Value != null)
                    {
                        diem_DTO.Diemso = row.Cells["a2"].Value.ToString();
                        diem_DAO.themDiemTheoHS(diem_DTO);
                    }

                    diem_DTO.Mald = "LD02";
                    diem_DTO.Mahs = row.Cells["MAHS"].Value.ToString();
                    diem_DAO.xoaDiemTheoMaLD(diem_DTO);
                    for (int i = 1; i <=5; i++)
                    {
                        if (row.Cells["b"+i.ToString()].Value!=null)
                        {
                            diem_DTO.Diemso = row.Cells["b" + i.ToString()].Value.ToString();
                            diem_DAO.themDiemTheoHS(diem_DTO);
                        }
                    }

                    diem_DTO.Mald = "LD03";
                    diem_DTO.Mahs = row.Cells["MAHS"].Value.ToString();
                    diem_DAO.xoaDiemTheoMaLD(diem_DTO);
                    for (int i = 1; i <= 5; i++)
                    {
                        if (row.Cells["c" + i.ToString()].Value != null)
                        {
                            diem_DTO.Diemso = row.Cells["c" + i.ToString()].Value.ToString();
                            diem_DAO.themDiemTheoHS(diem_DTO);
                        }
                    }

                    diem_DTO.Mald = "LD04";
                    diem_DTO.Mahs = row.Cells["MAHS"].Value.ToString();
                    diem_DAO.xoaDiemTheoMaLD(diem_DTO);
                    if (row.Cells["d1"].Value != null)
                    {
                        diem_DTO.Diemso = row.Cells["d1"].Value.ToString();
                        diem_DAO.themDiemTheoHS(diem_DTO);
                    }
                }
            }
        }

        public int demDiem(ComboBoxEx cboMaNH,ComboBoxEx cboMaHK,ComboBoxEx cboMaLD,ComboBoxEx cboMaMH,ComboBoxEx cboMaHS)
        {
            diem_DTO = new clsDIEM_DTO();
            diem_DTO.Mahk = cboMaHK.SelectedValue.ToString();
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
