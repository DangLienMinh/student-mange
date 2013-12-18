using System;
using System.Collections.Generic;
using QLHS.DAO;
using QLHS.DTO;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;
using DevComponents.AdvTree;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLHS.BUS
{
    public class clsBAOCAO_BUS
    {
        private clsBAOCAO_DAO baoCao_DAO;
        private clsHOCSINH_DAO hocSinh_DAO;
        private clsHOCSINH_DTO hocSinh_DTO;
        private clsBAOCAO_DTO baoCao_DTO;
        private clsDIEM_DTO diem_DTO;
        private clsLOP_BUS lop_BUS;
        private clsDIEM_DAO diem_DAO;

        public clsBAOCAO_BUS()
        {
            baoCao_DAO = new clsBAOCAO_DAO();
            hocSinh_DAO = new clsHOCSINH_DAO();
            hocSinh_DTO = new clsHOCSINH_DTO();
            baoCao_DTO = new clsBAOCAO_DTO();
            lop_BUS = new clsLOP_BUS();
            diem_DAO = new clsDIEM_DAO();
        }
        public DataSet bangDiemHocSinh(string manh, string malop, string mahs)
        {
            decimal TongdiemHK1 = 0;
            decimal TongdiemHK2 = 0;
            decimal TongdiemCN = 0;
            decimal DiemTBHK1 = 0;
            decimal DiemTBHK2 = 0;
            decimal DiemTBCN = 0;
            DataSet ds = baoCao_DAO.BangDiemHocSinh(manh, malop, mahs);
            if (ds.Tables["BangDiemHocSinh"].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables["BangDiemHocSinh"].Rows.Count; i++)
                {
                    if (ds.Tables["BangDiemHocSinh"].Rows[i]["MAHS"] != null)
                    {
                        if (ds.Tables["BangDiemHocSinh"].Rows[i]["MABAN"].ToString() == "B01")
                        {
                            if (ds.Tables["BangDiemHocSinh"].Rows[i]["TENMH"].ToString() == "Toán" || ds.Tables["BangDiemHocSinh"].Rows[i]["TENMH"].ToString() == "Văn")
                            {
                                TongdiemHK1 = TongdiemHK1 + 2 * (decimal.Parse(ds.Tables["BangDiemHocSinh"].Rows[i]["Học kỳ 1"].ToString()));
                                TongdiemHK2 = TongdiemHK2 + 2 * (decimal.Parse(ds.Tables["BangDiemHocSinh"].Rows[i]["Học kỳ 2"].ToString()));
                                TongdiemCN = TongdiemCN + 2 * (decimal.Parse(ds.Tables["BangDiemHocSinh"].Rows[i]["CANAM"].ToString()));
                            }
                            else
                            {
                                TongdiemHK1 = decimal.Parse(ds.Tables["BangDiemHocSinh"].Rows[i]["Học kỳ 1"].ToString());
                                TongdiemHK2 = decimal.Parse(ds.Tables["BangDiemHocSinh"].Rows[i]["Học kỳ 2"].ToString());
                                TongdiemCN = decimal.Parse(ds.Tables["BangDiemHocSinh"].Rows[i]["CANAM"].ToString());
                            }
                        }
                        else
                        {
                            if (ds.Tables["BangDiemHocSinh"].Rows[i]["MABAN"].ToString() == "B02")
                            {
                                if (ds.Tables["BangDiemHocSinh"].Rows[i]["TENMH"].ToString() == "Toán" || ds.Tables["BangDiemHocSinh"].Rows[i]["TENMH"].ToString() == "Lý" || ds.Tables["BangDiemHocSinh"].Rows[i]["TENMH"].ToString() == "Hóa" || ds.Tables["BangDiemHocSinh"].Rows[i]["TENMH"].ToString() == "Sinh")
                                {
                                    TongdiemHK1 = TongdiemHK1 + 2 * (decimal.Parse(ds.Tables["BangDiemHocSinh"].Rows[i]["Học kỳ 1"].ToString()));
                                    TongdiemHK2 = TongdiemHK2 + 2 * (decimal.Parse(ds.Tables["BangDiemHocSinh"].Rows[i]["Học kỳ 2"].ToString()));
                                    TongdiemCN = TongdiemCN + 2 * (decimal.Parse(ds.Tables["BangDiemHocSinh"].Rows[i]["CANAM"].ToString()));
                                }
                                else
                                {
                                    TongdiemHK1 = TongdiemHK1 + (decimal.Parse(ds.Tables["BangDiemHocSinh"].Rows[i]["Học kỳ 1"].ToString()));
                                    TongdiemHK2 = TongdiemHK2 + (decimal.Parse(ds.Tables["BangDiemHocSinh"].Rows[i]["Học kỳ 2"].ToString()));
                                    TongdiemCN = TongdiemCN + (decimal.Parse(ds.Tables["BangDiemHocSinh"].Rows[i]["CANAM"].ToString()));
                                }
                            }
                            else
                            {
                                if (ds.Tables["BangDiemHocSinh"].Rows[i]["TENMH"].ToString() == "Văn" || ds.Tables["BangDiemHocSinh"].Rows[i]["TENMH"].ToString() == "Sử" || ds.Tables["BangDiemHocSinh"].Rows[i]["TENMH"].ToString() == "Địa" || ds.Tables["BangDiemHocSinh"].Rows[i]["TENMH"].ToString() == "Anh")
                                {
                                    TongdiemHK1 = TongdiemHK1 + 2 * (decimal.Parse(ds.Tables["BangDiemHocSinh"].Rows[i]["Học kỳ 1"].ToString()));
                                    TongdiemHK2 = TongdiemHK2 + 2 * (decimal.Parse(ds.Tables["BangDiemHocSinh"].Rows[i]["Học kỳ 2"].ToString()));
                                    TongdiemCN = TongdiemCN + 2 * (decimal.Parse(ds.Tables["BangDiemHocSinh"].Rows[i]["CANAM"].ToString()));
                                }
                                else
                                {
                                    TongdiemHK1 = TongdiemHK1 + (decimal.Parse(ds.Tables["BangDiemHocSinh"].Rows[i]["Học kỳ 1"].ToString()));
                                    TongdiemHK2 = TongdiemHK2 + (decimal.Parse(ds.Tables["BangDiemHocSinh"].Rows[i]["Học kỳ 2"].ToString()));
                                    TongdiemCN = TongdiemCN + (decimal.Parse(ds.Tables["BangDiemHocSinh"].Rows[i]["CANAM"].ToString()));
                                }
                            }
                        }
                    }
                    if (ds.Tables["BangDiemHocSinh"].Rows[i]["GIOITINHHS"].ToString() == "1")
                    {
                        ds.Tables["BangDiemHocSinh"].Rows[i]["GIOITINHHS"] = "Nam";
                    }
                    else
                    {
                        ds.Tables["BangDiemHocSinh"].Rows[i]["GIOITINHHS"] = "Nữ";
                    }

                }
                if (ds.Tables["BangDiemHocSinh"].Rows[0]["MABAN"].ToString() == "B01")
                {
                    DiemTBHK1 = Math.Round((TongdiemHK1 / 15), 1);
                    DiemTBHK2 = Math.Round((TongdiemHK2 / 15), 1);
                    DiemTBCN = Math.Round((TongdiemCN / 15), 1);
                }
                else
                {
                    DiemTBHK1 = Math.Round((TongdiemHK1 / 17), 1);
                    DiemTBHK2 = Math.Round((TongdiemHK2 / 17), 1);
                    DiemTBCN = Math.Round((TongdiemCN / 17), 1);
                }
                DataColumn DIEMTBHK1 = new DataColumn("DIEMTBHK1",typeof(decimal));
                DataColumn DIEMTBHK2 = new DataColumn("DIEMTBHK2", typeof(decimal));
                DataColumn DIEMTBNAM = new DataColumn("DIEMTBNAM", typeof(decimal));
                ds.Tables["BangDiemHocSinh"].Columns.Add(DIEMTBHK1);
                ds.Tables["BangDiemHocSinh"].Columns.Add(DIEMTBHK2);
                ds.Tables["BangDiemHocSinh"].Columns.Add(DIEMTBNAM);
                foreach (DataRow row in ds.Tables["BangDiemHocSinh"].Rows)
                {
                    row["DIEMTBHK1"]=DiemTBHK1;
                    row["DIEMTBHK2"]=DiemTBHK2;
                    row["DIEMTBNAM"]=DiemTBCN;
                }
            }
            return ds;
        }
        public DataSet layThongTinKQTheoHocKy(ComboBoxEx namHoc, ComboBoxEx hocKy, string maLop)
        {
            DataTable tableTemp = new DataTable();
            DataSet ds = new DataSet();
            baoCao_DTO = new clsBAOCAO_DTO();
            baoCao_DTO.Manh = namHoc.SelectedValue.ToString();
            baoCao_DTO.Mahk = hocKy.SelectedValue.ToString();
            baoCao_DTO.Malop = maLop;
            tableTemp = baoCao_DAO.HSGTheoHocKy(baoCao_DTO);
            tableTemp=tinhTrungBinhHSG(tableTemp, lop_BUS.layPhanBan(baoCao_DTO.Malop));
            ds.Tables.Add(tableTemp);
            return ds;
        }

        public DataSet layThongTinLuuBanTheoNamHoc(ComboBoxEx namHoc, ComboBoxEx khoi)
        {
            DataTable tableNH = new DataTable();
            DataTable tableHK1 = new DataTable();
            DataTable tableHK2 = new DataTable();
            DataSet ds = new DataSet();
            baoCao_DTO = new clsBAOCAO_DTO();
            baoCao_DTO.Manh = namHoc.SelectedValue.ToString();
            baoCao_DTO.Makhoi = khoi.SelectedValue.ToString();
            baoCao_DTO.Mahk = "HK1";      
            tableHK1 = baoCao_DAO.HSLuuBanTheoHK(baoCao_DTO);
            baoCao_DTO.Mahk = "HK2";   
            tableHK2 = baoCao_DAO.HSLuuBanTheoHK(baoCao_DTO);
            tableHK1 = tinhTrungBinhLuuBanHK(tableHK1);
            tableHK2 = tinhTrungBinhLuuBanHK(tableHK2);
            tableNH = tinhTrungBinhLuuBanNH(tableHK1, tableHK2);
            tableNH = tinhTrungBinhLuuBanHK(tableNH);
            ds.Tables.Add(tableNH);
            return ds;
        }

      

        private DataTable tinhTrungBinhHSG(DataTable trungBinhHk, string maBan)
        {
            //kiểm tra 2 môn toán văn trên 8.0 và không môn nào dưới 6.5
            int flag = 0;
            //đếm số cột điểm lớn hơn 6.5
            int count = 0;

            trungBinhHk.Columns.Add("TBMon");
            trungBinhHk.Columns.Add("HocLuc");
            foreach (DataRow row in trungBinhHk.Rows)
            {
                double tong = 0;
                int soCot = 0;
                switch (maBan)
                {
                    case "B02":
                        {
                            for (int i = 6; i <= 17; i++)
                            {
                                double diem = 0;
                                if (row[i].ToString() != "")
                                {
                                    diem = double.Parse(row[i].ToString());
                                }

                                if (diem > 0)
                                {
                                    if (i >= 6 && i <= 9)
                                    {
                                        tong += (diem * 2);
                                        soCot += 2;
                                        //toán trên 8
                                        if (i == 6)
                                        {
                                            if (diem >= 8)
                                            {
                                                flag = 1;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        tong += diem;
                                        soCot += 1;
                                    }
                                }
                            }

                        }
                        break;
                    case "B03":
                        {
                            for (int i = 6; i <= 17; i++)
                            {
                                double diem = 0;

                                if (row[i].ToString() != "")
                                {
                                    diem = double.Parse(row[i].ToString());
                                }
                                if (diem > 0)
                                {
                                    if (i >= 10 && i <= 13)
                                    {
                                        tong += (diem * 2);
                                        soCot += 2;
                                        //văn trên 8
                                        if (i == 10)
                                        {
                                            if (diem >= 8)
                                            {
                                                flag = 1;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        tong += diem;
                                        soCot += 1;
                                    }

                                }

                            }

                        }
                        break;
                    case "B01":
                        {
                            double max = 0;
                            for (int i = 6; i <= 17; i++)
                            {
                                double diem = 0;

                                if (row[i].ToString() != "")
                                {
                                    diem = double.Parse(row[i].ToString());
                                }
                                if (diem > 0)
                                {
                                    if (i == 10 || i == 6)
                                    {
                                        tong += (diem * 2);
                                        soCot += 2;
                                        if (i ==6)
                                        {
                                            max = diem;
                                        }
                                        if (i == 10)
                                        {
                                            if (diem > max)
                                            {
                                                max = diem;
                                            }
                                            if (max >= 8)
                                            {
                                                flag = 1;
                                            }
                                        }
                                    }


                                    else
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
                double diemTB = Math.Round((tong / soCot), 1);
                row["TBMon"] = diemTB;
                for (int j = 6; j <= 17; j++)
                {
                    double diem = 0;
                    if (row[j].ToString() != "")
                    {
                        diem = double.Parse(row[j].ToString());
                    }
                    if ( diem >= 6.5)
                    {
                        ++count;
                    }

                }

                if (flag == 1 && diemTB >= 8 && count == 12 && (row["TENLHK"].ToString() == "Tốt"))
                {
                    row["HocLuc"] = "Giỏi";
                }
                else
                {
                    row["HocLuc"] = "KhongBiet";
                }
            }
            return trungBinhHk;
        }

        private DataTable tinhTrungBinhLuuBanHK(DataTable trungBinhHk)
        {
            //kiểm tra 2 môn toán văn trên 3.5 và không môn nào dưới 2
            int flag = 0;
            //đếm số cột điểm lớn hơn hoặc bằng 2
            int count = 0;
            if (trungBinhHk.Columns["HocLuc"] == null && trungBinhHk.Columns["TBMon"] == null)
            {
                trungBinhHk.Columns.Add("TBMon");
                trungBinhHk.Columns.Add("HocLuc");
            }
            
            foreach (DataRow row in trungBinhHk.Rows)
            {
                double tong = 0;
                int soCot = 0;
                switch (row["MABAN"].ToString())
                {
                    case "B02":
                        {
                            for (int i = 5; i <= 16; i++)
                            {
                                double diem = 0;
                                if (row[i].ToString() != "")
                                {
                                    diem = double.Parse(row[i].ToString());
                                }

                                if (diem > 0)
                                {
                                    if (i >= 5 && i <= 8)
                                    {
                                        tong += (diem * 2);
                                        soCot += 2;
                                        //toán trên 3.5
                                        if (i == 5)
                                        {
                                            if (diem >=3.5&&diem<5)
                                            {
                                                //loại tủng bình
                                                flag = 1;
                                            }
                                            else if (diem <3.5)
                                            {
                                                //loại yếu
                                                flag = 2;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        tong += diem;
                                        soCot += 1;
                                    }
                                }
                            }

                        }
                        break;
                    case "B03":
                        {
                            for (int i = 5; i <= 16; i++)
                            {
                                double diem = 0;

                                if (row[i].ToString() != "")
                                {
                                    diem = double.Parse(row[i].ToString());
                                }
                                if (diem > 0)
                                {
                                    if (i >= 9 && i <= 12)
                                    {
                                        tong += (diem * 2);
                                        soCot += 2;
                                        //văn trên 3.5
                                        if (i == 9)
                                        {
                                            if (diem >= 3.5 && diem < 5)
                                            {
                                                //loại tủng bình
                                                flag = 1;
                                            }
                                            else if (diem < 3.5)
                                            {
                                                //loại yếu
                                                flag = 2;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        tong += diem;
                                        soCot += 1;
                                    }
                                }
                            }

                        }
                        break;
                    case "B01":
                        {
                            double max = 0;
                            for (int i = 5; i <= 16; i++)
                            {
                                double diem = 0;

                                if (row[i].ToString() != "")
                                {
                                    diem = double.Parse(row[i].ToString());
                                }
                                if (diem > 0)
                                {
                                    if (i == 5 || i == 9)
                                    {
                                        tong += (diem * 2);
                                        soCot += 2;
                                        if (i == 5)
                                        {
                                            max = diem;
                                        }
                                        if (i == 9)
                                        {
                                            if (diem > max)
                                            {
                                                max = diem;
                                            }
                                            if (max >= 3.5 && max < 5)
                                            {
                                                //loại tủng bình
                                                flag = 1;
                                            }
                                            else if (max < 3.5)
                                            {
                                                //loại yếu
                                                flag = 2;
                                            }
                                        }
                                    }

                                    else
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
                double diemTB = Math.Round((tong / soCot), 1);
                row["TBMon"] = diemTB;
                for (int j= 5; j <= 16; j++)
                {
                    double diem = 0;
                    if (row[j].ToString() != "")
                    {
                        diem = double.Parse(row[j].ToString());
                    }
                    if (diem >=2)
                    {
                        ++count;
                    }

                }

                if (flag == 1 && diemTB >= 3.5 && count == 12)
                {
                    row["HocLuc"] = "Yếu";
                }
                else if (flag == 2)
                {
                    row["HocLuc"] = "Kém";
                }
                else
                {
                    row["HocLuc"] = "KhongBiet";
                }
            }
            return trungBinhHk;
        }

        private DataTable tinhTrungBinhLuuBanNH(DataTable HK1, DataTable HK2)
        {
            DataTable result = new DataTable();
            result = HK1.Clone();
            if (HK1.Rows.Count>0&&HK2.Rows.Count>0)
            {
                foreach (DataRow row in HK1.Rows)
                {
                    foreach (DataRow row1 in HK2.Rows)
                    {
                        if (row1["MAHS"].ToString() == row["MAHS"].ToString())
                        {
                            DataRow dong = result.NewRow();
                            dong["TENNH"] = row1["TENNH"];
                            dong["TENHS"] = row1["TENHS"];
                            dong["TENLOP"] = row1["TENLOP"];
                            dong["TENLHK"] = row1["TENLHK"];
                            dong["MABAN"] = row1["MABAN"];
                            dong["MAHS"] = row1["MAHS"];
                            for (int j = 5; j < 18; j++)
                            {
                                dong[j] = tinhDiem(row[j].ToString(), row1[j].ToString());
                            }
                            result.Rows.Add(dong);
                            break;
                        }
                        
                    }
                }
            
            }
            return result;
        }

        private double tinhDiem(string cot1, string cot2)
        {
            double result=0;
            if (cot1 != ""&&cot2!="")
            {
                result = Math.Round(((double.Parse(cot1) + double.Parse(cot2)*2)/3),1);
            }
            return result;
        }

        public DataSet baoCaoDiemTheoMonHoc(ComboBoxEx cboMaNH, ComboBoxEx cboMaHK, ComboBoxEx cboMaMH, string maLop)
        {
          
            baoCao_DTO = new clsBAOCAO_DTO();
            diem_DTO = new clsDIEM_DTO();
            hocSinh_DTO = new clsHOCSINH_DTO();
            baoCao_DTO.Mahk = cboMaHK.SelectedValue.ToString();
            baoCao_DTO.Manh = cboMaNH.SelectedValue.ToString();
            baoCao_DTO.Mamh = cboMaMH.SelectedValue.ToString();
            baoCao_DTO.Malop = maLop;

            diem_DTO.Mahk = cboMaHK.SelectedValue.ToString();
            diem_DTO.Manh = cboMaNH.SelectedValue.ToString();
            diem_DTO.Mamh = cboMaMH.SelectedValue.ToString();
            DataSet ds = new DataSet();
            DataTable result = baoCao_DAO.DiemTheoMonHoc(baoCao_DTO);
            DataTable tblDiem = new DataTable();
            foreach (DataRow row in result.Rows)
            {
                if (row["MAHS"] != null)
                {
                    int i = 1;
                    diem_DTO.Mald = "LD01";
                    diem_DTO.Mahs = row["MAHS"].ToString();
                    tblDiem = diem_DAO.thongTinDiemTheoMaLD(diem_DTO);
                    foreach (DataRow item in tblDiem.Rows)
                    {
                        row["LD01" + i.ToString()] = item[0].ToString();
                        ++i;
                    }

                    i = 1;
                    diem_DTO.Mald = "LD02";
                    diem_DTO.Mahs = row["MAHS"].ToString();
                    tblDiem = diem_DAO.thongTinDiemTheoMaLD(diem_DTO);
                    foreach (DataRow item in tblDiem.Rows)
                    {
                        row["LD02" + i.ToString()] = item[0].ToString();
                        ++i;
                    }

                    i = 1;
                    diem_DTO.Mald = "LD03";
                    diem_DTO.Mahs = row["MAHS"].ToString();
                    tblDiem = diem_DAO.thongTinDiemTheoMaLD(diem_DTO);
                    foreach (DataRow item in tblDiem.Rows)
                    {
                        row["LD03" + i.ToString()] = item[0].ToString();
                        ++i;
                    }

                    diem_DTO.Mald = "LD04";
                    diem_DTO.Mahs = row["MAHS"].ToString();
                    tblDiem = diem_DAO.thongTinDiemTheoMaLD(diem_DTO);
                    foreach (DataRow item in tblDiem.Rows)
                    {
                        row["LD041"] = item[0].ToString();
                    }

                    diem_DTO.Mald = "LD05";
                    diem_DTO.Mahs = row["MAHS"].ToString();
                    tblDiem = diem_DAO.thongTinDiemTheoMaLD(diem_DTO);
                    foreach (DataRow item in tblDiem.Rows)
                    {
                        row["LD051"] = item[0].ToString();
                    }

                }
            }
            ds.Tables.Add(result);
            return ds;
        }
    
    }
}

                    