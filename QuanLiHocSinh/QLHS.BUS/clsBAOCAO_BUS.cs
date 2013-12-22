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
        private clsHANHKIEM_BUS hanhKiem_BUS;

        public clsBAOCAO_BUS()
        {
            baoCao_DAO = new clsBAOCAO_DAO();
            hocSinh_DAO = new clsHOCSINH_DAO();
            hocSinh_DTO = new clsHOCSINH_DTO();
            baoCao_DTO = new clsBAOCAO_DTO();
            lop_BUS = new clsLOP_BUS();
            diem_DAO = new clsDIEM_DAO();
            hanhKiem_BUS=new clsHANHKIEM_BUS();
        }

        //report danh sách lớp
        public DataSet reportDanhSachLop()
        {
            return baoCao_DAO.reportDanhSachLop();
        }

        //report danh sác giáo viên
        public DataSet reportDanhSachGiaoVien()
        {
            return baoCao_DAO.reportDanhSachGiaoVien();
        }

        //report thẻ học sinh
        public DataSet reportTheHocSinh(string maLop)
        {
            return baoCao_DAO.reportTheHS(maLop);
        }

        //bản điểm học sinh
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

        //HSG
        public DataSet layThongTinHSGTheoHocKy(ComboBoxEx namHoc, ComboBoxEx hocKy, string maLop)
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

        //Ket Qua Theo Hoc Ky
        public DataSet layThongTinKQTheoHocKy(ComboBoxEx namHoc, ComboBoxEx hocKy, string maLop)
        {
            DataTable tableTemp = new DataTable();
            DataSet ds = new DataSet();
            baoCao_DTO = new clsBAOCAO_DTO();
            baoCao_DTO.Manh = namHoc.SelectedValue.ToString();
            baoCao_DTO.Mahk = hocKy.SelectedValue.ToString();
            baoCao_DTO.Malop = maLop;
            tableTemp = baoCao_DAO.HSGTheoHocKy(baoCao_DTO);
            tableTemp = tinhTrungBinhTheoHocKi(tableTemp, lop_BUS.layPhanBan(baoCao_DTO.Malop));
            ds.Tables.Add(tableTemp);
            return ds;
        }

       //thông tin học sinh lưu ban theo năm học
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

        //tính trung bình kết quả theo học kỳ
        private DataTable tinhTrungBinhTheoHocKi(DataTable trungBinhHk, string maBan)
        {
            //kiểm tra 2 môn toán văn trên 8.0 và không môn nào dưới 6.5
            //kiểm tra 2 môn toán văn trên 6.5  và không môn nào dưới 5.0
            //kiểm tra 2 môn toán văn trên 5.0  và không môn nào dưới 3.5
            //kiểm tra 2 môn toán văn trên 3.5  và không môn nào dưới 2
            int flag = 0;           

            //đếm số cột điểm lớn hơn theo loại
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
                            for (int i = 6; i <= 18; i++)
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
                                            else if (diem>=6.5)
                                            {
                                                flag = 2;
                                            }
                                            else if (diem>=5)
                                            {
                                                flag = 3;
                                            }
                                            else if (diem>=3.5)
                                            {
                                                flag = 4;
                                            }
                                            else
                                            {
                                                flag = 5;
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
                            for (int i = 6; i <= 18; i++)
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
                                            else if (diem >= 6.5)
                                            {
                                                flag = 2;
                                            }
                                            else if (diem >= 5)
                                            {
                                                flag = 3;
                                            }
                                            else if (diem >= 3.5)
                                            {
                                                flag = 4;
                                            }
                                            else
                                            {
                                                flag = 5;
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
                            for (int i = 6; i <= 18; i++)
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
                                        if (i == 6)
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
                                            else if (max >= 6.5)
                                            {
                                                flag = 2;
                                            }
                                            else if (max >= 5)
                                            {
                                                flag = 3;
                                            }
                                            else if (max >= 3.5)
                                            {
                                                flag = 4;
                                            }
                                            else
                                            {
                                                flag = 5;
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
                //dem so cot
                count = 0;
                for (int j = 6; j <= 17; j++)
                {
                    double diem = 0;
                    if (row[j].ToString() != "")
                    {
                        diem = double.Parse(row[j].ToString());
                    }
                    switch (flag)
                    {
                        case 1: 
                            {
                                if (diem>=6.5)
                                {
                                    ++count;
                                }
                            }
                        break;
                        case 2:
                        {
                            if (diem >= 5)
                            {
                                ++count;
                            }
                        }
                        break;
                        case 3:
                        {
                            if (diem >= 3.5)
                            {
                                ++count;
                            }
                        }
                        break;
                        case 4:
                        {
                            if (diem >= 2)
                            {
                                ++count;
                            }
                        }
                        break;
                        default:
                            break;
                    }

                }

                //kiem tra loai hoc luic

                switch (flag)
                {
                    case 1:
                        {
                            if (count == 13 && diemTB >= 8)
                            {
                                row["HocLuc"] = "Giỏi";
                            }
                            else
                            {
                                row["HocLuc"] = "Khá";
                            }

                        }
                        break;
                    case 2:
                        {
                            if (count == 13 && diemTB >= 6.5)
                            {
                                row["HocLuc"] = "Khá";
                            }
                            else
                            {
                                row["HocLuc"] = "TB";
                            }

                        }
                        break;
                    case 3:
                        {
                            if (count == 13 && diemTB >= 5)
                            {
                                row["HocLuc"] = "TB";
                            }
                            else
                            {
                                row["HocLuc"] = "Yếu";
                            }

                        }
                        break;
                    case 4:
                        {
                            if (count == 13 && diemTB >= 3.5)
                            {
                                row["HocLuc"] = "Yếu";
                            }
                            else
                            {
                                row["HocLuc"] = "Kém";
                            }

                        }
                        break;
                    default:
                        row["HocLuc"] = "Kém";
                        break;
                }

                
            }
            return trungBinhHk;
        }

        //tính trung bình học sinh giỏi theo học kỳ
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
                            for (int i = 6; i <= 18; i++)
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
                            for (int i = 6; i <= 18; i++)
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
                            for (int i = 6; i <= 18; i++)
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

                if (flag == 1 && diemTB >= 8 && count == 13)
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

        //tính trung bình lưu ban theo học kỳ
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
                            for (int i = 5; i <= 17; i++)
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
                            for (int i = 5; i <= 17; i++)
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
                            for (int i = 5; i <= 17; i++)
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

                if (flag == 1 && diemTB >= 3.5 && count == 13)
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

        //tính trung bình lưu ban theo năm học
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

        //tính điểm trung cả năm
        private double tinhDiem(string cot1, string cot2)
        {
            double result=0;
            if (cot1 != ""&&cot2!="")
            {
                result = Math.Round(((double.Parse(cot1) + double.Parse(cot2)*2)/3),1);
            }
            return result;
        }

        //báo cáo điểm theo môn học
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

        //học bạ năm
        public DataSet hocBaTheoNamHoc(ComboBoxEx cboMaNH, ComboBoxEx cboMaHS, string maLop)
        {
            DataSet ds = new DataSet();
            DataTable tblDSNamHoc = new DataTable();           
            
            tblDSNamHoc = baoCao_DAO.DanhSachCacNamHoc(cboMaHS.SelectedValue.ToString());
            if (tblDSNamHoc.Rows.Count==3)
            {
                DataTable tblTemp = new DataTable();
                DataTable tblKQ = new DataTable();
                baoCao_DTO = new clsBAOCAO_DTO();
                string maHS = "";
                foreach (DataRow row in tblDSNamHoc.Rows)
                {
                    diem_DTO = new clsDIEM_DTO();
                    if (row["MAHS"].ToString() != "" && row["MANH"].ToString() != "" && row["MALOP"].ToString() != "")
                    {
                        diem_DTO.Mahs = row["MAHS"].ToString();

                        diem_DTO.Manh = row["MANH"].ToString();

                        baoCao_DTO.Mahs = row["MAHS"].ToString();
                        baoCao_DTO.Manh = row["MANH"].ToString();
                        baoCao_DTO.Malop = row["MALOP"].ToString();
                        tblTemp = baoCao_DAO.HocBaTheoNamHoc(baoCao_DTO);
                        diemHocBa(tblTemp, diem_DTO);
                        ds.Tables.Add(tblTemp);
                    }
                    maHS = row["MAHS"].ToString();
                }
                hocSinh_DTO=new clsHOCSINH_DTO();
                hocSinh_DTO.Mahs=maHS;
                DataTable tblHocSinh=hocSinh_DAO.timHocSinhMaHS(hocSinh_DTO);
                ds.Tables.Add(tblHocSinh);
            }
            
            return ds;
        }

        //tính điểm trên học bạ
        private DataTable diemHocBa(DataTable diemHocBa,clsDIEM_DTO diem_DTO)
        {
           
            foreach (DataRow row in diemHocBa.Rows)
            {
                int flag = 0;
                int flag1 = 0;
                DataTable tblDiem = new DataTable();
                switch (row["MABAN"].ToString())
                {
                    case "B02":
                        {
                            double trungBinhHK1 = 0;
                            double trungBinhHK2 = 0;
                            for (int i = 1; i <= 13; i++)
                            {
                                double trungBinhMonCN=0;   
                                for (int j = 1; j < 4; j++)
                                {
                                    diem_DTO.Mald = "LD05";
                                    if (j == 1)
                                    {
                                        diem_DTO.Mahk = "HK1";
                                    }
                                    else if(j==2)
                                    {
                                        diem_DTO.Mahk = "HK2";
                                    }
                                    if (i<10)
                                    {
                                        
                                        diem_DTO.Mamh = "MH0" + i.ToString();
                                        tblDiem = diem_DAO.thongTinDiemTheoMaLD(diem_DTO);
                                        double diem = double.Parse(tblDiem.Rows[0][0].ToString());
                                        if (j == 1)
                                        {
                                            if (i>=1&&i<=4)
                                            {
                                                trungBinhHK1 += diem*2;
                                                if (i==1)
                                                {
                                                    if (diem >= 8)
                                                    {
                                                        flag = 1;
                                                    }
                                                    else if (diem >= 6.5)
                                                    {
                                                        flag = 2;
                                                    }
                                                    else if (diem >= 5)
                                                    {
                                                        flag = 3;
                                                    }
                                                    else if (diem >= 3.5)
                                                    {
                                                        flag = 4;
                                                    }
                                                    else
                                                    {
                                                        flag = 5;
                                                    }
                                                }
                                               
                                            }
                                            else
                                            {
                                                trungBinhHK1 += diem;
                                            }
                                            trungBinhMonCN += diem;
                                            row["MH0" + i.ToString() + j.ToString()] = diem;
                                        }
                                        else if(j==2)
                                        {
                                            if (i >= 1 && i <= 4)
                                            {
                                                trungBinhHK2 += diem * 2;
                                                if (i==1)
                                                {
                                                    if (diem >= 8)
                                                    {
                                                        flag1 = 1;
                                                    }
                                                    else if (diem >= 6.5)
                                                    {
                                                        flag1 = 2;
                                                    }
                                                    else if (diem >= 5)
                                                    {
                                                        flag1 = 3;
                                                    }
                                                    else if (diem >= 3.5)
                                                    {
                                                        flag1 = 4;
                                                    }
                                                    else
                                                    {
                                                        flag1 = 5;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                trungBinhHK2 += diem;
                                            }
                                            trungBinhMonCN += diem * 2;
                                            row["MH0" + i.ToString() + j.ToString()] = diem;
                                        }
                                        else
                                        {
                                            row["MH0" + i.ToString() + j.ToString()] = Math.Round(trungBinhMonCN/3,1);
                                        } 
                                    }
                                    else
                                    {
                                        diem_DTO.Mamh = "MH" + i.ToString();
                                        tblDiem = diem_DAO.thongTinDiemTheoMaLD(diem_DTO);
                                        double diem = double.Parse(tblDiem.Rows[0][0].ToString());
                                        if (j == 1)
                                        {
                                            trungBinhHK1 += diem;
                                            trungBinhMonCN += diem;
                                            row["MH" + i.ToString() + j.ToString()] = diem;
                                        }
                                        else if (j == 2)
                                        {
                                            trungBinhHK2 += diem;
                                            trungBinhMonCN += diem * 2;
                                            row["MH" + i.ToString() + j.ToString()] = diem;
                                        }
                                        else
                                        {
                                            row["MH" + i.ToString() + j.ToString()] = Math.Round(trungBinhMonCN / 3, 1);
                                        } 
                                    }
                                }
                            }
                            row["TB1"] = Math.Round(trungBinhHK1 / 17,1);
                            row["TB2"] = Math.Round(trungBinhHK2 / 17,1);
                            row["TB3"] = Math.Round(((trungBinhHK1 / 17) + (trungBinhHK2 / 17) * 2) / 3,1);
                            row["HK1"] =hanhKiem_BUS.hanhKiemTheoHocKiNamHoc(diem_DTO.Mahs, "HK1", diem_DTO.Manh);
                            row["HK2"] = hanhKiem_BUS.hanhKiemTheoHocKiNamHoc(diem_DTO.Mahs, "HK2", diem_DTO.Manh);
                            row["HK3"] = row["HK2"];
                            int count = 0;
                            for (int k = 1; k <= 13; k++)
                            {
                                double diem = 0;
                                if (k<10)
                                    {
                                        if (row["MH0"+k.ToString()+"1"].ToString() != "")
                                        {
                                            diem = double.Parse(row["MH0" + k.ToString() + "1"].ToString());
                                        }
                                    }
                                    else
                                    {
                                        if (row["MH" + k.ToString() + "1"].ToString() != "")
                                        {
                                            diem = double.Parse(row["MH" + k.ToString() + "1"].ToString());
                                        }
                                    }
                                switch (flag)
                                {
                                    case 1:
                                        {
                                            if (diem >= 6.5)
                                            {
                                                ++count;
                                            }
                                        }
                                        break;
                                    case 2:
                                        {
                                            if (diem >= 5)
                                            {
                                                ++count;
                                            }
                                        }
                                        break;
                                    case 3:
                                        {
                                            if (diem >= 3.5)
                                            {
                                                ++count;
                                            }
                                        }
                                        break;
                                    case 4:
                                        {
                                            if (diem >= 2)
                                            {
                                                ++count;
                                            }
                                        }
                                        break;
                                    default:
                                        break;
                                }

                            }

                            //kiem tra loai hoc luic

                            switch (flag)
                            {
                                case 1:
                                    {
                                        if (count == 13 && double.Parse(row["TB1"].ToString()) >= 8)
                                        {
                                            row["HL1"] = "Giỏi";
                                        }
                                        else
                                        {
                                            row["HL1"] = "Khá";
                                        }

                                    }
                                    break;
                                case 2:
                                    {
                                        if (count == 13 && double.Parse(row["TB1"].ToString()) >= 6.5)
                                        {
                                            row["HL1"] = "Khá";
                                        }
                                        else
                                        {
                                            row["HL1"] = "TB";
                                        }

                                    }
                                    break;
                                case 3:
                                    {
                                        if (count == 13 && double.Parse(row["TB1"].ToString()) >= 5)
                                        {
                                            row["HL1"] = "TB";
                                        }
                                        else
                                        {
                                            row["HL1"] = "Yếu";
                                        }

                                    }
                                    break;
                                case 4:
                                    {
                                        if (count == 13 && double.Parse(row["TB1"].ToString()) >= 3.5)
                                        {
                                            row["HL1"] = "Yếu";
                                        }
                                        else
                                        {
                                            row["HL1"] = "Kém";
                                        }

                                    }
                                    break;
                                default:
                                    row["HL1"] = "Kém";
                                    break;
                            }
                            //HL2
                            for (int k = 1; k <= 13; k++)
                            {
                                double diem = 0;
                                if (k < 10)
                                {
                                    if (row["MH0" + k.ToString() + "2"].ToString() != "")
                                    {
                                        diem = double.Parse(row["MH0" + k.ToString() + "1"].ToString());
                                    }
                                }
                                else
                                {
                                    if (row["MH" + k.ToString() + "2"].ToString() != "")
                                    {
                                        diem = double.Parse(row["MH" + k.ToString() + "1"].ToString());
                                    }
                                }
                                switch (flag1)
                                {
                                    case 1:
                                        {
                                            if (diem >= 6.5)
                                            {
                                                ++count;
                                            }
                                        }
                                        break;
                                    case 2:
                                        {
                                            if (diem >= 5)
                                            {
                                                ++count;
                                            }
                                        }
                                        break;
                                    case 3:
                                        {
                                            if (diem >= 3.5)
                                            {
                                                ++count;
                                            }
                                        }
                                        break;
                                    case 4:
                                        {
                                            if (diem >= 2)
                                            {
                                                ++count;
                                            }
                                        }
                                        break;
                                    default:
                                        break;
                                }

                            }

                            //kiem tra loai hoc luic

                            switch (flag1)
                            {
                                case 1:
                                    {
                                        if (count == 13 && double.Parse(row["TB2"].ToString()) >= 8)
                                        {
                                            row["HL2"] = "Giỏi";
                                        }
                                        else
                                        {
                                            row["HL2"] = "Khá";
                                        }

                                    }
                                    break;
                                case 2:
                                    {
                                        if (count == 13 && double.Parse(row["TB2"].ToString()) >= 6.5)
                                        {
                                            row["HL2"] = "Khá";
                                        }
                                        else
                                        {
                                            row["HL2"] = "TB";
                                        }

                                    }
                                    break;
                                case 3:
                                    {
                                        if (count == 13&& double.Parse(row["TB2"].ToString()) >= 5)
                                        {
                                            row["HL2"] = "TB";
                                        }
                                        else
                                        {
                                            row["HL2"] = "Yếu";
                                        }

                                    }
                                    break;
                                case 4:
                                    {
                                        if (count == 13 && double.Parse(row["TB2"].ToString()) >= 3.5)
                                        {
                                            row["HL2"] = "Yếu";
                                        }
                                        else
                                        {
                                            row["HL2"] = "Kém";
                                        }

                                    }
                                    break;
                                default:
                                    row["HL2"] = "Kém";
                                    break;
                            }
                            
                        }
                        break;
                    case "B03":
                        {
                            double trungBinhHK1 = 0;
                            double trungBinhHK2 = 0;
                            for (int i = 1; i <= 13; i++)
                            {
                                double trungBinhMonCN = 0;
                                for (int j = 1; j < 4; j++)
                                {
                                    diem_DTO.Mald = "LD05";
                                    if (j == 1)
                                    {
                                        diem_DTO.Mahk = "HK1";
                                    }
                                    else if (j == 2)
                                    {
                                        diem_DTO.Mahk = "HK2";
                                    }
                                    if (i < 10)
                                    {

                                        diem_DTO.Mamh = "MH0" + i.ToString();
                                        tblDiem = diem_DAO.thongTinDiemTheoMaLD(diem_DTO);
                                        double diem = double.Parse(tblDiem.Rows[0][0].ToString());
                                        if (j == 1)
                                        {
                                            if (i >= 5 && i <= 8)
                                            {
                                                trungBinhHK1 += diem * 2;
                                                if (i == 5)
                                                {
                                                    if (diem >= 8)
                                                    {
                                                        flag = 1;
                                                    }
                                                    else if (diem >= 6.5)
                                                    {
                                                        flag = 2;
                                                    }
                                                    else if (diem >= 5)
                                                    {
                                                        flag = 3;
                                                    }
                                                    else if (diem >= 3.5)
                                                    {
                                                        flag = 4;
                                                    }
                                                    else
                                                    {
                                                        flag = 5;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                trungBinhHK1 += diem;
                                            }
                                            trungBinhMonCN += diem;
                                            row["MH0" + i.ToString() + j.ToString()] = diem;
                                        }
                                        else if (j == 2)
                                        {
                                            if (i >= 5 && i <= 8)
                                            {
                                                trungBinhHK2 += diem * 2;
                                                if (i == 5)
                                                {
                                                    if (diem >= 8)
                                                    {
                                                        flag1 = 1;
                                                    }
                                                    else if (diem >= 6.5)
                                                    {
                                                        flag1 = 2;
                                                    }
                                                    else if (diem >= 5)
                                                    {
                                                        flag1 = 3;
                                                    }
                                                    else if (diem >= 3.5)
                                                    {
                                                        flag1 = 4;
                                                    }
                                                    else
                                                    {
                                                        flag1 = 5;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                trungBinhHK2 += diem;
                                            }
                                            trungBinhMonCN += diem * 2;
                                            row["MH0" + i.ToString() + j.ToString()] = diem;
                                        }
                                        else
                                        {
                                            row["MH0" + i.ToString() + j.ToString()] = Math.Round(trungBinhMonCN / 3, 1);
                                        }
                                    }
                                    else
                                    {
                                        diem_DTO.Mamh = "MH" + i.ToString();
                                        tblDiem = diem_DAO.thongTinDiemTheoMaLD(diem_DTO);
                                        double diem = double.Parse(tblDiem.Rows[0][0].ToString());
                                        if (j == 1)
                                        {
                                            trungBinhHK1 += diem;
                                            trungBinhMonCN += diem;
                                            row["MH" + i.ToString() + j.ToString()] = diem;
                                        }
                                        else if (j == 2)
                                        {
                                            trungBinhHK2 += diem;
                                            trungBinhMonCN += diem * 2;
                                            row["MH" + i.ToString() + j.ToString()] = diem;
                                        }
                                        else
                                        {
                                            row["MH" + i.ToString() + j.ToString()] = Math.Round(trungBinhMonCN / 3, 1);
                                        }
                                    }
                                }
                            }
                            row["TB1"] = Math.Round(trungBinhHK1 / 17,1);
                            row["TB2"] = Math.Round(trungBinhHK2 / 17,1);
                            row["TB3"] = Math.Round(((trungBinhHK1 / 17) + (trungBinhHK2 / 17) * 2) / 3,1);
                            row["HK1"] = hanhKiem_BUS.hanhKiemTheoHocKiNamHoc(diem_DTO.Mahs, "HK1", diem_DTO.Manh);
                            row["HK2"] = hanhKiem_BUS.hanhKiemTheoHocKiNamHoc(diem_DTO.Mahs, "HK2", diem_DTO.Manh);
                            row["HK3"] = row["HK2"];
                            int count = 0;
                            for (int k = 1; k <= 13; k++)
                            {
                                double diem = 0;
                                if (k < 10)
                                {
                                    if (row["MH0" + k.ToString() + "1"].ToString() != "")
                                    {
                                        diem = double.Parse(row["MH0" + k.ToString() + "1"].ToString());
                                    }
                                }
                                else
                                {
                                    if (row["MH" + k.ToString() + "1"].ToString() != "")
                                    {
                                        diem = double.Parse(row["MH" + k.ToString() + "1"].ToString());
                                    }
                                }
                                switch (flag)
                                {
                                    case 1:
                                        {
                                            if (diem >= 6.5)
                                            {
                                                ++count;
                                            }
                                        }
                                        break;
                                    case 2:
                                        {
                                            if (diem >= 5)
                                            {
                                                ++count;
                                            }
                                        }
                                        break;
                                    case 3:
                                        {
                                            if (diem >= 3.5)
                                            {
                                                ++count;
                                            }
                                        }
                                        break;
                                    case 4:
                                        {
                                            if (diem >= 2)
                                            {
                                                ++count;
                                            }
                                        }
                                        break;
                                    default:
                                        break;
                                }

                            }

                            //kiem tra loai hoc luic

                            switch (flag)
                            {
                                case 1:
                                    {
                                        if (count == 13 && double.Parse(row["TB1"].ToString()) >= 8)
                                        {
                                            row["HL1"] = "Giỏi";
                                        }
                                        else
                                        {
                                            row["HL1"] = "Khá";
                                        }

                                    }
                                    break;
                                case 2:
                                    {
                                        if (count == 13 && double.Parse(row["TB1"].ToString()) >= 6.5)
                                        {
                                            row["HL1"] = "Khá";
                                        }
                                        else
                                        {
                                            row["HL1"] = "TB";
                                        }

                                    }
                                    break;
                                case 3:
                                    {
                                        if (count == 13 && double.Parse(row["TB1"].ToString()) >= 5)
                                        {
                                            row["HL1"] = "TB";
                                        }
                                        else
                                        {
                                            row["HL1"] = "Yếu";
                                        }

                                    }
                                    break;
                                case 4:
                                    {
                                        if (count == 13 && double.Parse(row["TB1"].ToString()) >= 3.5)
                                        {
                                            row["HL1"] = "Yếu";
                                        }
                                        else
                                        {
                                            row["HL1"] = "Kém";
                                        }

                                    }
                                    break;
                                default:
                                    row["HL1"] = "Kém";
                                    break;
                            }
                            //HL2
                            for (int k = 1; k <= 13; k++)
                            {
                                double diem = 0;
                                if (k < 10)
                                {
                                    if (row["MH0" + k.ToString() + "2"].ToString() != "")
                                    {
                                        diem = double.Parse(row["MH0" + k.ToString() + "1"].ToString());
                                    }
                                }
                                else
                                {
                                    if (row["MH" + k.ToString() + "2"].ToString() != "")
                                    {
                                        diem = double.Parse(row["MH" + k.ToString() + "1"].ToString());
                                    }
                                }
                                switch (flag1)
                                {
                                    case 1:
                                        {
                                            if (diem >= 6.5)
                                            {
                                                ++count;
                                            }
                                        }
                                        break;
                                    case 2:
                                        {
                                            if (diem >= 5)
                                            {
                                                ++count;
                                            }
                                        }
                                        break;
                                    case 3:
                                        {
                                            if (diem >= 3.5)
                                            {
                                                ++count;
                                            }
                                        }
                                        break;
                                    case 4:
                                        {
                                            if (diem >= 2)
                                            {
                                                ++count;
                                            }
                                        }
                                        break;
                                    default:
                                        break;
                                }

                            }

                            //kiem tra loai hoc luic

                            switch (flag1)
                            {
                                case 1:
                                    {
                                        if (count == 13 && double.Parse(row["TB2"].ToString()) >= 8)
                                        {
                                            row["HL2"] = "Giỏi";
                                        }
                                        else
                                        {
                                            row["HL2"] = "Khá";
                                        }

                                    }
                                    break;
                                case 2:
                                    {
                                        if (count == 13 && double.Parse(row["TB2"].ToString()) >= 6.5)
                                        {
                                            row["HL2"] = "Khá";
                                        }
                                        else
                                        {
                                            row["HL2"] = "TB";
                                        }

                                    }
                                    break;
                                case 3:
                                    {
                                        if (count == 13 && double.Parse(row["TB2"].ToString()) >= 5)
                                        {
                                            row["HL2"] = "TB";
                                        }
                                        else
                                        {
                                            row["HL2"] = "Yếu";
                                        }

                                    }
                                    break;
                                case 4:
                                    {
                                        if (count == 13 && double.Parse(row["TB2"].ToString()) >= 3.5)
                                        {
                                            row["HL2"] = "Yếu";
                                        }
                                        else
                                        {
                                            row["HL2"] = "Kém";
                                        }

                                    }
                                    break;
                                default:
                                    row["HL2"] = "Kém";
                                    break;
                            }
                        }
                        break;
                    case "B01":
                        {
                            double trungBinhHK1 = 0;
                            double trungBinhHK2 = 0;
                            double max = 0;
                            for (int i = 1; i <= 13; i++)
                            {
                                double trungBinhMonCN = 0;
                                for (int j = 1; j < 4; j++)
                                {
                                    diem_DTO.Mald = "LD05";
                                    if (j == 1)
                                    {
                                        diem_DTO.Mahk = "HK1";
                                    }
                                    else if (j == 2)
                                    {
                                        diem_DTO.Mahk = "HK2";
                                    }
                                    if (i < 10)
                                    {

                                        diem_DTO.Mamh = "MH0" + i.ToString();
                                        tblDiem = diem_DAO.thongTinDiemTheoMaLD(diem_DTO);
                                        double diem = double.Parse(tblDiem.Rows[0][0].ToString());
                                        if (j == 1)
                                        {
                                            if (i == 1 || i == 5)
                                            {
                                                trungBinhHK1 += diem * 2;
                                                if (i == 1)
                                                {
                                                    max = diem;
                                                }
                                                if (i == 5)
                                                {
                                                    if (diem > max)
                                                    {
                                                        max = diem;
                                                    }

                                                    if (max >= 8)
                                                    {
                                                        flag = 1;
                                                    }
                                                    else if (max >= 6.5)
                                                    {
                                                        flag = 2;
                                                    }
                                                    else if (max >= 5)
                                                    {
                                                        flag = 3;
                                                    }
                                                    else if (max >= 3.5)
                                                    {
                                                        flag = 4;
                                                    }
                                                    else
                                                    {
                                                        flag = 5;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                trungBinhHK1 += diem;
                                            }
                                            trungBinhMonCN += diem;
                                            row["MH0" + i.ToString() + j.ToString()] = diem;
                                        }
                                        else if (j == 2)
                                        {
                                            if (i == 1 || i == 5)
                                            {
                                                trungBinhHK2 += diem * 2;
                                                if (i == 1)
                                                {
                                                    max = diem;
                                                }
                                                if (i == 5)
                                                {
                                                    if (diem > max)
                                                    {
                                                        max = diem;
                                                    }

                                                    if (max >= 8)
                                                    {
                                                        flag1 = 1;
                                                    }
                                                    else if (max >= 6.5)
                                                    {
                                                        flag1 = 2;
                                                    }
                                                    else if (max >= 5)
                                                    {
                                                        flag1 = 3;
                                                    }
                                                    else if (max >= 3.5)
                                                    {
                                                        flag1 = 4;
                                                    }
                                                    else
                                                    {
                                                        flag1 = 5;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                trungBinhHK2 += diem;
                                            }
                                            trungBinhMonCN += diem * 2;
                                            row["MH0" + i.ToString() + j.ToString()] = diem;
                                        }
                                        else
                                        {
                                            row["MH0" + i.ToString() + j.ToString()] = Math.Round(trungBinhMonCN / 3, 1);
                                        }
                                    }
                                    else
                                    {
                                        diem_DTO.Mamh = "MH" + i.ToString();
                                        tblDiem = diem_DAO.thongTinDiemTheoMaLD(diem_DTO);
                                        double diem = double.Parse(tblDiem.Rows[0][0].ToString());
                                        if (j == 1)
                                        {
                                            trungBinhHK1 += diem;
                                            trungBinhMonCN += diem;
                                            row["MH" + i.ToString() + j.ToString()] = diem;
                                        }
                                        else if (j == 2)
                                        {
                                            trungBinhHK2 += diem;
                                            trungBinhMonCN += diem * 2;
                                            row["MH" + i.ToString() + j.ToString()] = diem;
                                        }
                                        else
                                        {
                                            row["MH" + i.ToString() + j.ToString()] = Math.Round(trungBinhMonCN / 3, 1);
                                        }
                                    }
                                }
                            }
                            row["TB1"] = Math.Round(trungBinhHK1 / 15,1);
                            row["TB2"] = Math.Round(trungBinhHK2 / 15,1);
                            row["TB3"] = Math.Round(((trungBinhHK1 / 15) + (trungBinhHK2 / 15) * 2) / 3,1);
                            row["HK1"] = hanhKiem_BUS.hanhKiemTheoHocKiNamHoc(diem_DTO.Mahs, "HK1", diem_DTO.Manh);
                            row["HK2"] = hanhKiem_BUS.hanhKiemTheoHocKiNamHoc(diem_DTO.Mahs, "HK2", diem_DTO.Manh);
                            row["HK3"] = row["HK2"];
                            int count = 0;
                            for (int k = 1; k <= 13; k++)
                            {
                                double diem = 0;
                                if (k < 10)
                                {
                                    if (row["MH0" + k.ToString() + "1"].ToString() != "")
                                    {
                                        diem = double.Parse(row["MH0" + k.ToString() + "1"].ToString());
                                    }
                                }
                                else
                                {
                                    if (row["MH" + k.ToString() + "1"].ToString() != "")
                                    {
                                        diem = double.Parse(row["MH" + k.ToString() + "1"].ToString());
                                    }
                                }
                                switch (flag)
                                {
                                    case 1:
                                        {
                                            if (diem >= 6.5)
                                            {
                                                ++count;
                                            }
                                        }
                                        break;
                                    case 2:
                                        {
                                            if (diem >= 5)
                                            {
                                                ++count;
                                            }
                                        }
                                        break;
                                    case 3:
                                        {
                                            if (diem >= 3.5)
                                            {
                                                ++count;
                                            }
                                        }
                                        break;
                                    case 4:
                                        {
                                            if (diem >= 2)
                                            {
                                                ++count;
                                            }
                                        }
                                        break;
                                    default:
                                        break;
                                }

                            }

                            //kiem tra loai hoc luic

                            switch (flag)
                            {
                                case 1:
                                    {
                                        if (count == 13 && double.Parse(row["TB1"].ToString()) >= 8)
                                        {
                                            row["HL1"] = "Giỏi";
                                        }
                                        else
                                        {
                                            row["HL1"] = "Khá";
                                        }

                                    }
                                    break;
                                case 2:
                                    {
                                        if (count == 13 && double.Parse(row["TB1"].ToString()) >= 6.5)
                                        {
                                            row["HL1"] = "Khá";
                                        }
                                        else
                                        {
                                            row["HL1"] = "TB";
                                        }

                                    }
                                    break;
                                case 3:
                                    {
                                        if (count == 13 && double.Parse(row["TB1"].ToString()) >= 5)
                                        {
                                            row["HL1"] = "TB";
                                        }
                                        else
                                        {
                                            row["HL1"] = "Yếu";
                                        }

                                    }
                                    break;
                                case 4:
                                    {
                                        if (count == 13 && double.Parse(row["TB1"].ToString()) >= 3.5)
                                        {
                                            row["HL1"] = "Yếu";
                                        }
                                        else
                                        {
                                            row["HL1"] = "Kém";
                                        }

                                    }
                                    break;
                                default:
                                    row["HL1"] = "Kém";
                                    break;
                            }
                            //HL2
                            for (int k = 1; k <= 13; k++)
                            {
                                double diem = 0;
                                if (k < 10)
                                {
                                    if (row["MH0" + k.ToString() + "2"].ToString() != "")
                                    {
                                        diem = double.Parse(row["MH0" + k.ToString() + "1"].ToString());
                                    }
                                }
                                else
                                {
                                    if (row["MH" + k.ToString() + "2"].ToString() != "")
                                    {
                                        diem = double.Parse(row["MH" + k.ToString() + "1"].ToString());
                                    }
                                }
                                switch (flag1)
                                {
                                    case 1:
                                        {
                                            if (diem >= 6.5)
                                            {
                                                ++count;
                                            }
                                        }
                                        break;
                                    case 2:
                                        {
                                            if (diem >= 5)
                                            {
                                                ++count;
                                            }
                                        }
                                        break;
                                    case 3:
                                        {
                                            if (diem >= 3.5)
                                            {
                                                ++count;
                                            }
                                        }
                                        break;
                                    case 4:
                                        {
                                            if (diem >= 2)
                                            {
                                                ++count;
                                            }
                                        }
                                        break;
                                    default:
                                        break;
                                }
                            }

                            //kiem tra loai hoc luic

                            switch (flag1)
                            {
                                case 1:
                                    {
                                        if (count == 13 && double.Parse(row["TB2"].ToString()) >= 8)
                                        {
                                            row["HL2"] = "Giỏi";
                                        }
                                        else
                                        {
                                            row["HL2"] = "Khá";
                                        }

                                    }
                                    break;
                                case 2:
                                    {
                                        if (count == 13 && double.Parse(row["TB2"].ToString()) >= 6.5)
                                        {
                                            row["HL2"] = "Khá";
                                        }
                                        else
                                        {
                                            row["HL2"] = "TB";
                                        }

                                    }
                                    break;
                                case 3:
                                    {
                                        if (count == 13 && double.Parse(row["TB2"].ToString()) >= 5)
                                        {
                                            row["HL2"] = "TB";
                                        }
                                        else
                                        {
                                            row["HL2"] = "Yếu";
                                        }

                                    }
                                    break;
                                case 4:
                                    {
                                        if (count == 13 && double.Parse(row["TB2"].ToString()) >= 3.5)
                                        {
                                            row["HL2"] = "Yếu";
                                        }
                                        else
                                        {
                                            row["HL2"] = "Kém";
                                        }

                                    }
                                    break;
                                default:
                                    row["HL2"] = "Kém";
                                    break;
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            return diemHocBa;
        }
    }
}

                    