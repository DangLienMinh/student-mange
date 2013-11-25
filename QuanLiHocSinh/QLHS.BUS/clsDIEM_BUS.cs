using System;
using System.Collections.Generic;
using System.Text;
using QLHS.DAO;
using QLHS.DTO;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;
using DevComponents.AdvTree;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace QLHS.BUS
{
    public class clsDIEM_BUS
    {
        clsDIEM_DAO diem_DAO;
        clsHOCSINH_BUS hocSinh_BUS;
        clsLOP_BUS lop_BUS;
        clsDIEM_DTO diem_DTO;
        clsLOAIDIEM_BUS loaiDiem_BUS;
        clsMONHOC_BUS monHoc_BUS;
        clsHOCSINH_DTO hocSinh_DTO;
        clsLOP_DTO lop_DTO;
        DataTable tblDiem;
        private DataRow dr;

        public clsDIEM_BUS() 
        {
            hocSinh_BUS = new clsHOCSINH_BUS();
            lop_BUS = new clsLOP_BUS();
            loaiDiem_BUS = new clsLOAIDIEM_BUS();
            monHoc_BUS = new clsMONHOC_BUS();
            diem_DAO = new clsDIEM_DAO();
            lop_DTO = new clsLOP_DTO();
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

        public DataTable thongTinDiemTheoHS(ComboBoxEx cboMaNH, ComboBoxEx cboMaHK, ComboBoxEx cboMaLD, ComboBoxEx cboMaMH, ComboBoxEx cboMaHS)
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
           return  tblDiem;
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

        public void ketQuaDiemHK(ComboBoxEx cboMaNH, string maBan, DataGridViewX grdDiem)
        {
            string namHoc = cboMaNH.SelectedValue.ToString();
            string maMH;
            
            foreach (DataGridViewRow row in grdDiem.Rows)
            {
                if (row.Cells["MAHS"].Value != null)
                {
                    string maHS = row.Cells["MAHS"].Value.ToString();

                    for (int i = 1; i <= 12; i++)
                    {
                        if (i < 10)
                        {
                            maMH = row.Cells["MH0" + i.ToString()].OwningColumn.Name;
                            double diem= Math.Round((diemTBTheoHocKiMonHoc(maHS, "HK1", maMH, namHoc) + diemTBTheoHocKiMonHoc(maHS, "HK2", maMH, namHoc) * 2) / 3, 1);
                            if (diem<5&&diem>0)
                            {
                                
                                row.Cells["MH0" + i.ToString()].Style.BackColor = Color.Yellow;
                            }
                            if (diem == 0)
                            {
                                row.Cells["MH0" + i.ToString()].Style.BackColor = Color.Red;
                            }
                            row.Cells["MH0" + i.ToString()].Value =diem;
                        }
                        else
                        {
                            maMH = row.Cells["MH" + i.ToString()].OwningColumn.Name;
                             double diem= Math.Round((diemTBTheoHocKiMonHoc(maHS, "HK1", maMH, namHoc) + diemTBTheoHocKiMonHoc(maHS, "HK2", maMH, namHoc) * 2) / 3, 1);
                             if (diem<5)
                            {
                                row.Cells["MH" + i.ToString()].Style.BackColor = Color.Red;
                            }
                             row.Cells["MH" + i.ToString()].Value = diem;
                        }
                    }
                    double tong = 0;
                    int soCot = 0;
                    switch (maBan)
                    {
                        case "KHTN":
                            {
                                for (int i = 1; i <= 12; i++)
                                {
                                    double diem = 0;
                                    if (i < 10)
                                    {
                                        diem = double.Parse(row.Cells["MH0" + i.ToString()].Value.ToString());
                                        if (diem > 0)
                                        {
                                            if (i>=1&&i<=4)
                                            {
                                                tong += (diem * 2);
                                                soCot += 2;
                                            }
                                            else
                                            {
                                                tong += diem ;
                                                soCot += 1;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        diem = double.Parse(row.Cells["MH" + i.ToString()].Value.ToString());
                                        if (diem > 0)
                                        {
                                            tong += diem;
                                            soCot += 1;
                                        }
                                    }
                                }
 
                            }
                            break;
                        case "KHXHNV":
                            {
                                for (int i = 1; i <= 12; i++)
                                {
                                    double diem = 0;
                                    if (i < 10)
                                    {
                                        diem = double.Parse(row.Cells["MH0" + i.ToString()].Value.ToString());
                                        if (diem > 0)
                                        {
                                            if (i >= 5 && i <= 8)
                                            {
                                                tong += (diem * 2);
                                                soCot += 2;
                                            }
                                            else
                                            {
                                                tong += diem;
                                                soCot += 1;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        diem = double.Parse(row.Cells["MH" + i.ToString()].Value.ToString());
                                        if (diem > 0)
                                        {
                                            tong += diem;
                                            soCot += 1;
                                        }
                                    }
                                }
                            }
                            break;
                        case "CB":
                            {
                                for (int i = 1; i <= 12; i++)
                                {
                                    double diem = 0;
                                    if (i < 10)
                                    {
                                        diem = double.Parse(row.Cells["MH0" + i.ToString()].Value.ToString());
                                        if (diem > 0)
                                        {
                                            if (i ==1 || i == 5)
                                            {
                                                tong += (diem * 2);
                                                soCot += 2;
                                            }
                                            else
                                            {
                                                tong += diem;
                                                soCot += 1;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        diem = double.Parse(row.Cells["MH" + i.ToString()].Value.ToString());
                                        if (diem > 0)
                                        {
                                            tong += diem;
                                            soCot += 1;
                                        }
                                    }
                                }
                            }
                            break;
                        default:
                            break;
                    }

                    if (tong == 0 || soCot == 0)
                    {
                        row.Cells["CN"].Value = 0;
                        row.Cells["CN"].Style.BackColor = Color.Red;
                    }
                    else
                    {
                        
                        if ( Math.Round((tong / soCot), 1)<5)
                        {
                            row.Cells["CN"].Style.BackColor = Color.Red;
                        }
                        row.Cells["CN"].Value = Math.Round((tong / soCot), 1);
                       
                    }

                }
            }
        }      

        //load danh sách học sinh theo mã năm học vào tree view
        public string layPhanBan(ComboBoxEx comboBox, AdvTree tree)
        {
           string maLop=lop_BUS.layMaLopTrenTree(comboBox,tree);
           return lop_BUS.layPhanBan(maLop);
        }

        public double diemTBTheoHocKiMonHoc(string maHS,string maHK,string maMH,string maNH)
        {
            float tongMieng=0,tong15=0, tongThi=0, tong1Tiet=0, tong=0;
            int heSoMieng=0,heSo15=0,heSo1iet=0,heSoThi=0,soCotMieng=0, soCot15=0,soCot1Tiet=0;
            DataTable temp = new DataTable();
            diem_DTO = new clsDIEM_DTO();
            diem_DTO.Mahk = maHK;
            diem_DTO.Manh = maNH;
            diem_DTO.Mamh = maMH;
            diem_DTO.Mahs = maHS;
            temp=diem_DAO.diemTBTheoHocKiMonHoc(diem_DTO);
            if (temp.Rows.Count>1)
            {
                foreach (DataRow row in temp.Rows)
                {
                    switch (row["MALD"].ToString())
                    {
                        case "LD01": 
                            {
                                tongMieng += float.Parse(row["DIEMSO"].ToString());
                                ++soCotMieng;
                                break;
                            }
                        case "LD02":
                            {
                                tong15 += float.Parse(row["DIEMSO"].ToString());
                                ++soCot15;
                                break;
                            }
                        case "LD03":
                            {
                                tong1Tiet += float.Parse(row["DIEMSO"].ToString());
                                ++soCot1Tiet;
                                break;
                            }
                        case "LD04":
                            {
                                tongThi += float.Parse(row["DIEMSO"].ToString());
                                break;
                            }
                        default:
                            break;
                    } 
                }
                //lay he so
                heSoMieng = loaiDiem_BUS.heSoLoaiDiem("LD01");
                heSo15 = loaiDiem_BUS.heSoLoaiDiem("LD02");
                heSo1iet = loaiDiem_BUS.heSoLoaiDiem("LD03");
                heSoThi = loaiDiem_BUS.heSoLoaiDiem("LD04");
                tong += (tongMieng * heSoMieng + tong15 * heSo15 + tong1Tiet * heSo1iet + tongThi * heSoThi) / (soCotMieng * heSoMieng + soCot15 * heSo15 + soCot1Tiet * heSo1iet + heSoThi);
            }
           return Math.Round((double)tong,1);
            //return tong.ToString("n2");
        }
    }
}
