using System;
using System.Collections.Generic;
using System.Text;
using QLHS.DTO;
using System.Data;
using System.Data.SqlClient;
namespace QLHS.DAO
{
    public class clsHOCSINH_DAO
    {
        private clsConnectDatabase connection;
        private SqlConnection con;

        public clsHOCSINH_DAO()
        {
            connection = new clsConnectDatabase();
            con = connection.KetNoi();
        }

        //danh sách học sinh theo combobox mã năm học
        public DataTable danhSachHocSinh()
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_ThongTinHocSinh", con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        //tên học sinh theo mã học sinh
        public DataTable tenHocSinh(string maHS)
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_TenHocSinhMaHS", con);
            command.Parameters.Add("@MAHS", SqlDbType.VarChar).Value = maHS;
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        //form đổi thành form tiếp nhận học sinh, vừa vào cho chỉ chọn mã lớp 10 cho học sinh
        public void themHocSinh(clsHOCSINH_DTO hocsinh)
        {
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_ThemHocSinh", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAHS", SqlDbType.VarChar).Value = hocsinh.Mahs;
            command.Parameters.Add("@TENHS", SqlDbType.NVarChar).Value = hocsinh.Tenhs;
            command.Parameters.Add("@NGSINHHS", SqlDbType.SmallDateTime).Value = hocsinh.Ngaysinhhs;
            command.Parameters.Add("@GIOITINHHS", SqlDbType.Char).Value = hocsinh.Gioitinh;
            command.Parameters.Add("@DIACHIHS", SqlDbType.NVarChar).Value = hocsinh.Diachihs;
            command.Parameters.Add("@DIENTHOAIHS", SqlDbType.VarChar).Value = hocsinh.Dienthoaihs;
            command.Parameters.Add("@NGNHAPHOC", SqlDbType.SmallDateTime).Value = hocsinh.Ngnhaphoc;
            command.Parameters.Add("@HINHANHHS", SqlDbType.VarChar).Value = hocsinh.Hinhanhhs;
            command.Parameters.Add("@DANTOC", SqlDbType.NVarChar).Value = hocsinh.Dantoc;
            command.ExecuteNonQuery();
            con.Close();
        }

        public void suaHocSinh(clsHOCSINH_DTO hocsinh)
        {
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_SuaHocSinh", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAHS", SqlDbType.VarChar).Value = hocsinh.Mahs;
            command.Parameters.Add("@TENHS", SqlDbType.NVarChar).Value = hocsinh.Tenhs;
            command.Parameters.Add("@NGSINHHS", SqlDbType.SmallDateTime).Value = hocsinh.Ngaysinhhs;
            command.Parameters.Add("@GIOITINHHS", SqlDbType.Char).Value = hocsinh.Gioitinh;
            command.Parameters.Add("@DIACHIHS", SqlDbType.NVarChar).Value = hocsinh.Diachihs;
            command.Parameters.Add("@DIENTHOAIHS", SqlDbType.VarChar).Value = hocsinh.Dienthoaihs;
            command.Parameters.Add("@NGNHAPHOC", SqlDbType.SmallDateTime).Value = hocsinh.Ngnhaphoc;
            command.Parameters.Add("@HINHANHHS", SqlDbType.VarChar).Value = hocsinh.Hinhanhhs;
            command.Parameters.Add("@DANTOC", SqlDbType.NVarChar).Value = hocsinh.Dantoc;
            command.ExecuteNonQuery();
            con.Close();
        }

        public void xoaHocSinh(clsHOCSINH_DTO hocsinh)
        {
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_XoaHocSinh", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAHS", SqlDbType.VarChar).Value = hocsinh.Mahs;
            command.ExecuteNonQuery();
            con.Close();
        }
        //Danh sách học sinh học lớp ,học kỳ của năm học
        public DataTable danhsachHocSinhMALOPMANHMAHK(string malop, string manh, string mahk)
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_DanhSachHocSinh_LOP_NAMHOC_HOCKY", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MALOP", SqlDbType.VarChar).Value = malop;
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = manh;
            command.Parameters.Add("@MAHK", SqlDbType.VarChar).Value = mahk;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }
//--DANH SACH HOC SINH THEO LON,NAM HOC,HOC KY
//CREATE CREATE PROC SP_DanhSachHocSinh_LOP_NAMHOC_HOCKY
//@MALOP VARCHAR(10),@MANH VARCHAR(6),@MAHK VARCHAR(10)
//AS
//    BEGIN
//        SELECT HOCSINH.MAHS,TENHS,NAMHOC.MANH,MAHK FROM HOCSINH,HOCLOP,NAMHOC,HOCKY WHERE HOCSINH.MAHS=HOCLOP.MAHS AND HOCLOP.MANH=NAMHOC.MANH AND HOCKY.MANH=NAMHOC.MANH AND MALOP=@MALOP AND NAMHOC.MANH=@MANH AND MAHK=@MAHK
//    END















        /*//////////////////////////////////////////////////////////////////////////*/
        /// <summary>
        /// FORM TÌM HỌC SINH
        /// ĐẶNG LIÊN MINH
        /// </summary>
        /// <param name="hocsinh"></param>
        /// <returns></returns>
        /// 

        public DataTable danhSachHocSinhTheoLop(clsHOCSINH_DTO hocsinh)
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_ThongTinHocSinhTheoLop", con);
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = hocsinh.Manh;
            command.Parameters.Add("@MALOP", SqlDbType.VarChar).Value = hocsinh.Malop;
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        public DataTable danhSachPhanLop(clsHOCSINH_DTO hocsinh)
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_ThongTinPhanLop", con);
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = hocsinh.Manh;
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        public DataTable danhSachMaHSTheoLop(clsLOP_DTO lop)
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_ThongTinMaHSTheoLop", con);
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = lop.Manh;
            command.Parameters.Add("@MALOP", SqlDbType.VarChar).Value = lop.Malop;
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        public DataTable danhSachHocSinhChuaPhanLop(clsHOCSINH_DTO hocsinh)
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_ThongTinHocSinhChuaPhanLop", con);
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = hocsinh.Manh;
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        public void themPhanLop(clsHOCSINH_DTO hocsinh,clsNAMHOC_DTO namhoc,clsLOP_DTO lop)
        {
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_ThemPhanLop", con);
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = namhoc.Manh;
            command.Parameters.Add("@MAHS", SqlDbType.VarChar).Value = hocsinh.Mahs;
            command.Parameters.Add("@MALOP", SqlDbType.VarChar).Value = lop.Malop;
            command.CommandType = CommandType.StoredProcedure;
            command.ExecuteNonQuery();
            con.Close();
        }

        public void xoaPhanLop(clsHOCSINH_DTO hocsinh, clsNAMHOC_DTO namhoc, clsLOP_DTO lop)
        {
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_XoaPhanLop", con);
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = namhoc.Manh;
            command.Parameters.Add("@MAHS", SqlDbType.VarChar).Value = hocsinh.Mahs;
            command.Parameters.Add("@MALOP", SqlDbType.VarChar).Value = lop.Malop;
            command.CommandType = CommandType.StoredProcedure;
            command.ExecuteNonQuery();
            con.Close();
        }

        public DataTable timHocSinhMaHS(clsHOCSINH_DTO hocsinh)
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_TimHocSinhMaHS", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAHS", SqlDbType.VarChar).Value = hocsinh.Mahs;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        public DataTable timHocSinhTenHS(clsHOCSINH_DTO hocsinh)
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_TimHocSinhTenHS", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@TENHS", SqlDbType.VarChar).Value = hocsinh.Tenhs;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        public DataTable timHocSinhDanToc(clsHOCSINH_DTO hocsinh)
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_TimHocSinhDanToc", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@DANTOC", SqlDbType.VarChar).Value = hocsinh.Dantoc;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        public DataTable timHocSinhNgNhapHoc(clsHOCSINH_DTO hocsinh)
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_TimHocSinhNgNhapHoc", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@NGNHAPHOC", SqlDbType.SmallDateTime).Value = hocsinh.Ngnhaphoc.ToString("yyyy-MM-dd");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        public  DataTable timHocSinhNangCao(clsHOCSINH_DTO hocsinh,string dieuKien)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string STRCMD = "";
            string Temp = "";
            if (hocsinh.Mahs != "")
            {
                Temp = " WHERE MAHS=" + "'" + hocsinh.Mahs + "' ";
                if (hocsinh.Tenhs != "")
                {
                    Temp += dieuKien + " TENHS=" + "N'" + hocsinh.Tenhs + "' ";
                }
                if (hocsinh.Dantoc != "")
                {
                    Temp += dieuKien + " DANTOC=" + "N'" + hocsinh.Dantoc + "' ";
                }
                if (hocsinh.Ngnhaphoc.GetHashCode()!=0)
                {
                    Temp += dieuKien + " NGNHAPHOC=" + "'" + hocsinh.Ngnhaphoc + "' ";
                }
            }
           else if (hocsinh.Tenhs != "")
            {
                Temp = " WHERE TENHS=" + "N'" + hocsinh.Tenhs + "' ";
                if (hocsinh.Mahs != "")
                {
                    Temp += dieuKien + " MAHS=" + "'" + hocsinh.Mahs + "' ";
                }
                if (hocsinh.Dantoc != "")
                {
                    Temp += dieuKien + " DANTOC=" + "N'" + hocsinh.Dantoc + "' ";
                }
                if (hocsinh.Ngnhaphoc.GetHashCode()!=0)
                {
                    Temp += dieuKien + " NGNHAPHOC=" + "'" + hocsinh.Ngnhaphoc + "' ";
                }
            }
            else if (hocsinh.Dantoc != "")
            {
                Temp = " WHERE DANTOC=" + "N'" + hocsinh.Dantoc + "' ";
                if (hocsinh.Mahs != "")
                {
                    Temp += dieuKien + " MAHS=" + "'" + hocsinh.Mahs + "' ";
                }
                if (hocsinh.Tenhs != "")
                {
                    Temp += dieuKien + " TENHS=" + "N'" + hocsinh.Tenhs + "' ";
                }
                if (hocsinh.Ngnhaphoc.GetHashCode()!=0)
                {
                    Temp += dieuKien + " NGNHAPHOC=" + "'" + hocsinh.Ngnhaphoc + "' ";
                }
            }
            else
            {
                Temp = " WHERE NGNHAPHOC=" + "'" + hocsinh.Ngnhaphoc + "' ";
                if (hocsinh.Mahs != "")
                {
                    Temp += dieuKien + " MAHS=" + "'" + hocsinh.Mahs + "' ";
                }
                if (hocsinh.Tenhs != "")
                {
                    Temp += dieuKien + " TENHS=" + "N'" + hocsinh.Tenhs + "' ";
                }
               if (hocsinh.Dantoc != "")
                {
                    Temp += dieuKien + " DANTOC=" + "N'" + hocsinh.Dantoc + "' ";
                }
            }
	
                STRCMD = @"SELECT * FROM HOCSINH" + Temp;
                connection.kiemTraKetNoi(con);
                SqlCommand sqlcmd = new SqlCommand(STRCMD,con);
                da = new SqlDataAdapter(sqlcmd);
                da.Fill(dt);
                con.Close();
                return dt;
            }
        /*////////////////////////////////////////////////////////////////THONG KE////////////////////////////////////////////////////////////////////*/
        //THONG KE DANH SACH HOC SINH
        //public DataTable danhSachHocSinh()
        //{
        //    DataTable table = new DataTable();
        //    connection.kiemTraKetNoi(con);
        //    SqlCommand command = new SqlCommand("SP_ThongTinHocSinh", con);
        //    command.CommandType = CommandType.StoredProcedure;
        //    SqlDataAdapter adapter = new SqlDataAdapter(command);
        //    adapter.Fill(table);
        //    con.Close();
        //    return table;
        //}
        }


   
}
