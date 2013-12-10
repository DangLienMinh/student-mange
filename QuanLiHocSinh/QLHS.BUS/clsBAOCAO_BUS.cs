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
        private clsHANHKIEM_DTO hanhKiem_DTO;
        private clsLOP_BUS lop_BUS;

        public clsBAOCAO_BUS()
        {
            baoCao_DAO = new clsBAOCAO_DAO();
            hocSinh_DAO = new clsHOCSINH_DAO();
            hocSinh_DTO = new clsHOCSINH_DTO();
            hanhKiem_DTO = new clsHANHKIEM_DTO();
            lop_BUS = new clsLOP_BUS();
        }

        public DataSet layThongTinKQTheoHocKy(ComboBoxEx namHoc, ComboBoxEx hocKy, string maLop)
        {
            DataTable tableTemp = new DataTable();
            DataSet ds = new DataSet();
            hanhKiem_DTO = new clsHANHKIEM_DTO();
            hanhKiem_DTO.Manh = namHoc.SelectedValue.ToString();
            hanhKiem_DTO.Mahk = hocKy.SelectedValue.ToString();
            hanhKiem_DTO.Malop = maLop;
            tableTemp = baoCao_DAO.HSGTheoHocKy(hanhKiem_DTO);
            tableTemp=tinhTrungBinhHSG(tableTemp, lop_BUS.layPhanBan(hanhKiem_DTO.Malop));
            //foreach (DataRow row in tableTemp.Rows)
            //{
                
            //}
            //if (tableTemp.Rows[0]["HocLuc"]=="Giỏi")
            //{
            //    ds.Tables.Add(tableTemp);
            //}
            ds.Tables.Add(tableTemp);
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


        //private DataTable tinhTrungBinhHSG(DataTable trungBinhHk,string maBan)
        //{
        //    //kiểm tra 2 môn toán văn trên 8.0 và không môn nào dưới 6.5
        //    int flag = 0;
        //    //đếm số cột điểm lớn hơn 6.5
        //    int count=0;
        //    trungBinhHk.Columns.Add("TBMon");
        //    trungBinhHk.Columns.Add("HocLuc");
        //    foreach (DataRow row in trungBinhHk.Rows)
        //    {
        //        double tong = 0;
        //        int soCot = 0;
        //        switch (maBan)
        //        {
        //            case "B02":
        //                {
        //                    for (int i = 3; i <= 14; i++)
        //                    {
        //                        double diem = 0;
        //                        if (row[i]!=null)
        //                        {
        //                            diem = double.Parse(row[i].ToString());
        //                        }
                                
        //                        if (diem > 0)
        //                        {
        //                            if (i >= 3 && i <= 6)
        //                            {
        //                                tong += (diem * 2);
        //                                soCot += 2;
        //                                //toán trên 8
        //                                if (i==3)
        //                                {
        //                                    if (diem >= 8)
        //                                    {
        //                                        flag = 1;
        //                                    }
        //                                    else if (diem >= 6.5 && diem < 8)
        //                                    {
        //                                        flag = 1;
        //                                    }
        //                                    else if (diem >= 5 && diem < 6.5)
        //                                    {
        //                                        flag = 3;
        //                                    }
        //                                    else if (diem >= 3.5 && diem < 5)
        //                                    {
        //                                        flag = 4;
        //                                    }
        //                                    else flag = 5;
        //                                }
        //                            }
        //                            else
        //                            {
        //                                tong += diem;
        //                                soCot += 1;
        //                            }
        //                        }                              
        //                    }
                            
        //                }
        //                break;
        //            case "B03":
        //                {
        //                    for (int i = 3; i <= 14; i++)
        //                    {
        //                        double diem = 0;

        //                        if (row[i] != null)
        //                        {
        //                            diem = double.Parse(row[i].ToString());
        //                        }
        //                        if (diem > 0)
        //                        {
        //                            if (i >= 7 && i <= 10)
        //                            {
        //                                tong += (diem * 2);
        //                                soCot += 2;
        //                                //toán trên 8
        //                                if (i == 7)
        //                                {
        //                                    if (diem >= 8)
        //                                    {
        //                                        flag = 1;
        //                                    }
        //                                    else if (diem >= 6.5 && diem < 8)
        //                                    {
        //                                        flag = 1;
        //                                    }
        //                                    else if (diem >= 5 && diem < 6.5)
        //                                    {
        //                                        flag = 3;
        //                                    }
        //                                    else if (diem >= 3.5 && diem < 5)
        //                                    {
        //                                        flag = 4;
        //                                    }
        //                                    else flag = 5;
        //                                }
        //                            }
        //                            else
        //                            {
        //                                tong += diem;
        //                                soCot += 1;
        //                            }

        //                        }

        //                    }

        //                }
        //                break;
        //            case "B01":
        //                {
        //                    double max=0;
        //                    for (int i = 3; i <= 14; i++)
        //                    {
        //                        double diem = 0;

        //                        if (row[i] != null)
        //                        {
        //                            diem = double.Parse(row[i].ToString());
        //                        }
        //                        if (diem > 0)
        //                        {
        //                            if (i == 7 || i == 3)
        //                            {
        //                                tong += (diem * 2);
        //                                soCot += 2;
        //                                if (i==3)
        //                                {
        //                                    max = diem;
        //                                }
        //                                if (i==7)
        //                                {
        //                                    if (diem>max)
        //                                    {
        //                                        max = diem;
        //                                    }
        //                                    if (max >= 8)
        //                                    {
        //                                        flag = 1;
        //                                    }
        //                                    else if (max >= 6.5 && max < 8)
        //                                    {
        //                                        flag = 1;
        //                                    }
        //                                    else if (max >= 5 && max < 6.5)
        //                                    {
        //                                        flag = 3;
        //                                    }
        //                                    else if (max >= 3.5 && max < 5)
        //                                    {
        //                                        flag = 4;
        //                                    }
        //                                    else flag = 5;
        //                                }
        //                            }


        //                            else
        //                            {
        //                                tong += diem;
        //                                soCot += 1;
        //                            }

        //                        }
        //                    }
        //                }
        //                break;
        //            default:
        //                break;
        //        }
        //        double diemTB= Math.Round((tong / soCot), 1);
        //        row["TBMon"] = diemTB;
        //        for (int j = 3; j <= 14; j++)
        //        {
        //            double diem = 0;
        //            if (row[j] != null)
        //            {
        //                diem = double.Parse(row[j].ToString());
        //            }
        //            if (flag == 1 && diem >= 6.5)
        //            {
        //                ++count;
        //            }
        //            else if (flag == 2 && diem >= 5)
        //            {
        //                ++count;
        //            }
        //            else if (flag == 3 && diem >= 3.5)
        //            {
        //                ++count;
        //            }
        //            else if (flag == 4 && diem >= 2)
        //            {
        //                ++count;
        //            }

        //        }

        //        if (flag == 1 && diemTB>=8&&count==12&&(row["TENLHK"]=="Tốt"))
        //        {
        //            row["HocLuc"] = "Giỏi";
        //        }
        //        else if (flag == 2 && diemTB>=6.5&&count==12&&(row["TENLHK"]=="Khá"||row["TENLHK"]=="Tốt"))
        //        {
        //            row["HocLuc"] = "Khá";
        //        }
        //        else if (flag == 3 && diemTB >= 5 && count == 12 && (row["TENLHK"] == "Yếu" ))
        //        {
        //            row["HocLuc"] = "Trung Bình";
        //        }
        //        else if (flag == 4 && diemTB >= 3.5 && count == 12)
        //        {
        //            row["HocLuc"] = "Yếu";
        //        }
        //        else
        //        {
        //            row["HocLuc"] = "Kém";
        //        }
        //    }
        //    return trungBinhHk;
        //}
    }
}

                    