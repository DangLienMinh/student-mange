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

        //danh sách học sinh  SP_ThongTinHocSinh
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

        //tên học sinh theo mã học sinh SP_TenHocSinhMaHS
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

        //theem học sinh mới SP_ThemHocSinh
        public void themHocSinh(clsHOCSINH_DTO hocSinh_DTO)
        {
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_ThemHocSinh", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAHS", SqlDbType.VarChar).Value = hocSinh_DTO.Mahs;
            command.Parameters.Add("@TENHS", SqlDbType.NVarChar).Value = hocSinh_DTO.Tenhs;
            command.Parameters.Add("@NGSINHHS", SqlDbType.SmallDateTime).Value = hocSinh_DTO.Ngaysinhhs;
            command.Parameters.Add("@GIOITINHHS", SqlDbType.Char).Value = hocSinh_DTO.Gioitinh;
            command.Parameters.Add("@DIACHIHS", SqlDbType.NVarChar).Value = hocSinh_DTO.Diachihs;
            command.Parameters.Add("@DIENTHOAIHS", SqlDbType.VarChar).Value = hocSinh_DTO.Dienthoaihs;
            command.Parameters.Add("@NGNHAPHOC", SqlDbType.SmallDateTime).Value = hocSinh_DTO.Ngnhaphoc;
            command.Parameters.Add("@HINHANHHS", SqlDbType.VarChar).Value = hocSinh_DTO.Hinhanhhs;
            command.Parameters.Add("@DANTOC", SqlDbType.NVarChar).Value = hocSinh_DTO.Dantoc;
            command.ExecuteNonQuery();
            con.Close();
        }

        //sửa học sinh SP_SuaHocSinh
        public void suaHocSinh(clsHOCSINH_DTO hocSinh_DTO)
        {
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_SuaHocSinh", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAHS", SqlDbType.VarChar).Value = hocSinh_DTO.Mahs;
            command.Parameters.Add("@TENHS", SqlDbType.NVarChar).Value = hocSinh_DTO.Tenhs;
            command.Parameters.Add("@NGSINHHS", SqlDbType.SmallDateTime).Value = hocSinh_DTO.Ngaysinhhs;
            command.Parameters.Add("@GIOITINHHS", SqlDbType.Char).Value = hocSinh_DTO.Gioitinh;
            command.Parameters.Add("@DIACHIHS", SqlDbType.NVarChar).Value = hocSinh_DTO.Diachihs;
            command.Parameters.Add("@DIENTHOAIHS", SqlDbType.VarChar).Value = hocSinh_DTO.Dienthoaihs;
            command.Parameters.Add("@NGNHAPHOC", SqlDbType.SmallDateTime).Value = hocSinh_DTO.Ngnhaphoc;
            command.Parameters.Add("@HINHANHHS", SqlDbType.VarChar).Value = hocSinh_DTO.Hinhanhhs;
            command.Parameters.Add("@DANTOC", SqlDbType.NVarChar).Value = hocSinh_DTO.Dantoc;
            command.ExecuteNonQuery();
            con.Close();
        }

        //xóa học sinh SP_XoaHocSinh
        public void xoaHocSinh(clsHOCSINH_DTO hocSinh_DTO)
        {
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_XoaHocSinh", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAHS", SqlDbType.VarChar).Value = hocSinh_DTO.Mahs;
            command.ExecuteNonQuery();
            con.Close();
        }

        //Danh sách học sinh học lớp ,học kỳ của năm học hiện tất cả SP_DanhSachHocSinh_LOP_NAMHOC_HOCKY_TATCA
        public DataTable danhSachHocSinhMALOPMANHMAHKTatCa(string maLop, string maNH, string maHK)
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_DanhSachHocSinh_LOP_NAMHOC_HOCKY_TATCA", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MALOP", SqlDbType.VarChar).Value = maLop;
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = maNH;
            command.Parameters.Add("@MAHK", SqlDbType.VarChar).Value = maHK;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        //Danh sách học sinh học lớp, học kỳ của năm học mà chưa nhập SP_DanhSachHocSinh_LOP_NAMHOC_HOCKY
        public DataTable danhSachHocSinhMALOPMANHMAHKChuaNhap(string maLop, string maNH, string maHK)
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_DanhSachHocSinh_LOP_NAMHOC_HOCKY", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MALOP", SqlDbType.VarChar).Value = maLop;
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = maNH;
            command.Parameters.Add("@MAHK", SqlDbType.VarChar).Value = maHK;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        // REPORT Danh sách học sinh theo lớp và năm học SP_DanhSachHocSinh_NH_LOP 
        public DataSet danhSachHocSinh_NH_LOP(string MaNh, string Malop)
        {
            DataSet ds = new DataSet();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_ThongTinHocSinhTheoLop", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = MaNh;
            command.Parameters.Add("@MALOP", SqlDbType.VarChar).Value = Malop;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(ds, "DanhSachHocSinh");
            con.Close();
            return ds;
        }

        //thông tin tuổi tối đa SP_TuoiToiDa
        public DataTable TuoiToiDa()
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_TuoiToiDa", con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        //thông tin tuổi tối thiểu SP_TuoiToiThieu
        public DataTable TuoiToiThieu()
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_TuoiToiThieu", con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }
       

        /*//////////////////////////////////////////////////////////////////////////*/
        /// <summary>
        /// FORM TÌM HỌC SINH
        /// ĐẶNG LIÊN MINH
        /// </summary>
        /// <param name="hocSinh_DTO"></param>
        /// <returns></returns>
        /// 

        //danh sách học sinh theo lớp, NĂM HỌC SP_ThongTinHocSinhTheoLop
        public DataTable danhSachHocSinhTheoLop(clsHOCSINH_DTO hocSinh_DTO)
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_ThongTinHocSinhTheoLop", con);
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = hocSinh_DTO.Manh;
            command.Parameters.Add("@MALOP", SqlDbType.VarChar).Value = hocSinh_DTO.Malop;
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        //danh sách phân lớp học sinh SP_ThongTinPhanLop
        public DataTable danhSachPhanLop(clsHOCSINH_DTO hocSinh_DTO)
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_ThongTinPhanLop", con);
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = hocSinh_DTO.Manh;
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        //danh sách mã học sinh, tên học sinh theo năm lớp SP_ThongTinMaHSTheoLop
        public DataTable danhSachMaHSTheoLop(clsLOP_DTO lop_DTO)
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_ThongTinMaHSTheoLop", con);
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = lop_DTO.Manh;
            command.Parameters.Add("@MALOP", SqlDbType.VarChar).Value = lop_DTO.Malop;
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        //danh sách học sinh chưa phân lớp SP_ThongTinHocSinhChuaPhanLop
        public DataTable danhSachHocSinhChuaPhanLop(clsHOCSINH_DTO hocSinh_DTO)
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_ThongTinHocSinhChuaPhanLop", con);
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = hocSinh_DTO.Manh;
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        //thêm phân lớp SP_ThemPhanLop
        public void themPhanLop(clsHOCSINH_DTO hocsinh, clsNAMHOC_DTO namHoc_DTO, clsLOP_DTO lop_DTO,DateTime thoiGianHieuLuc)
        {
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_ThemPhanLop", con);
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = namHoc_DTO.Manh;
            command.Parameters.Add("@MAHS", SqlDbType.VarChar).Value = hocsinh.Mahs;
            command.Parameters.Add("@MALOP", SqlDbType.VarChar).Value = lop_DTO.Malop;
            command.Parameters.Add("@THOIGIANHIEULUC", SqlDbType.SmallDateTime).Value = thoiGianHieuLuc;
            command.CommandType = CommandType.StoredProcedure;
            command.ExecuteNonQuery();
            con.Close();
        }

        //xóa phân lớp SP_XoaPhanLop
        public void xoaPhanLop(clsHOCSINH_DTO hocSinh_DTO, clsNAMHOC_DTO namHoc_DTO, clsLOP_DTO lop_DTO)
        {
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_XoaPhanLop", con);
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = namHoc_DTO.Manh;
            command.Parameters.Add("@MAHS", SqlDbType.VarChar).Value = hocSinh_DTO.Mahs;
            command.Parameters.Add("@MALOP", SqlDbType.VarChar).Value = lop_DTO.Malop;
            command.CommandType = CommandType.StoredProcedure;
            command.ExecuteNonQuery();
            con.Close();
        }

        //tìm học sinh theo mã học sinh SP_TimHocSinhMaHS
        public DataTable timHocSinhMaHS(clsHOCSINH_DTO hocSinh_DTO)
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_TimHocSinhMaHS", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAHS", SqlDbType.VarChar).Value = hocSinh_DTO.Mahs;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        //tìm học sinh chuyển lớp SP_TimHocSinhChuyenLop
        public DataTable timHocSinhChuyenLop(clsHOCSINH_DTO hocSinh_DTO)
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_TimHocSinhChuyenLop", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAHS", SqlDbType.VarChar).Value = hocSinh_DTO.Mahs;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        //tìm học sinh theo tên học sinh SP_TimHocSinhTenHS
        public DataTable timHocSinhTenHS(clsHOCSINH_DTO hocSinh_DTO)
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_TimHocSinhTenHS", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@TENHS", SqlDbType.NVarChar).Value = hocSinh_DTO.Tenhs;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        //tìm học sinh theo dân tộc SP_TimHocSinhDanToc
        public DataTable timHocSinhDanToc(clsHOCSINH_DTO hocSinh_DTO)
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_TimHocSinhDanToc", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@DANTOC", SqlDbType.VarChar).Value = hocSinh_DTO.Dantoc;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        //tìm học sinh theo ngày nhập học SP_TimHocSinhNgNhapHoc
        public DataTable timHocSinhNgNhapHoc(clsHOCSINH_DTO hocSinh_DTO)
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_TimHocSinhNgNhapHoc", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@NGNHAPHOC", SqlDbType.SmallDateTime).Value = hocSinh_DTO.Ngnhaphoc.ToString("yyyy-MM-dd");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        //tìm học sinh nâng cao
        public DataTable timHocSinhNangCao(clsHOCSINH_DTO hocSinh_DTO, string dieuKien)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string STRCMD = "";
            string Temp = "";
            if (hocSinh_DTO.Mahs != "")
            {
                Temp = " WHERE MAHS=" + "'" + hocSinh_DTO.Mahs + "' ";
                if (hocSinh_DTO.Tenhs != "")
                {
                    Temp += dieuKien + " TENHS=" + "N'" + hocSinh_DTO.Tenhs + "' ";
                }
                if (hocSinh_DTO.Dantoc != "")
                {
                    Temp += dieuKien + " DANTOC=" + "N'" + hocSinh_DTO.Dantoc + "' ";
                }
                if (hocSinh_DTO.Ngnhaphoc.GetHashCode() != 0)
                {
                    Temp += dieuKien + " NGNHAPHOC=" + "'" + hocSinh_DTO.Ngnhaphoc + "' ";
                }
            }
            else if (hocSinh_DTO.Tenhs != "")
            {
                Temp = " WHERE TENHS=" + "N'" + hocSinh_DTO.Tenhs + "' ";
                if (hocSinh_DTO.Mahs != "")
                {
                    Temp += dieuKien + " MAHS=" + "'" + hocSinh_DTO.Mahs + "' ";
                }
                if (hocSinh_DTO.Dantoc != "")
                {
                    Temp += dieuKien + " DANTOC=" + "N'" + hocSinh_DTO.Dantoc + "' ";
                }
                if (hocSinh_DTO.Ngnhaphoc.GetHashCode() != 0)
                {
                    Temp += dieuKien + " NGNHAPHOC=" + "'" + hocSinh_DTO.Ngnhaphoc + "' ";
                }
            }
            else if (hocSinh_DTO.Dantoc != "")
            {
                Temp = " WHERE DANTOC=" + "N'" + hocSinh_DTO.Dantoc + "' ";
                if (hocSinh_DTO.Mahs != "")
                {
                    Temp += dieuKien + " MAHS=" + "'" + hocSinh_DTO.Mahs + "' ";
                }
                if (hocSinh_DTO.Tenhs != "")
                {
                    Temp += dieuKien + " TENHS=" + "N'" + hocSinh_DTO.Tenhs + "' ";
                }
                if (hocSinh_DTO.Ngnhaphoc.GetHashCode() != 0)
                {
                    Temp += dieuKien + " NGNHAPHOC=" + "'" + hocSinh_DTO.Ngnhaphoc + "' ";
                }
            }
            else
            {
                Temp = " WHERE NGNHAPHOC=" + "'" + hocSinh_DTO.Ngnhaphoc + "' ";
                if (hocSinh_DTO.Mahs != "")
                {
                    Temp += dieuKien + " MAHS=" + "'" + hocSinh_DTO.Mahs + "' ";
                }
                if (hocSinh_DTO.Tenhs != "")
                {
                    Temp += dieuKien + " TENHS=" + "N'" + hocSinh_DTO.Tenhs + "' ";
                }
                if (hocSinh_DTO.Dantoc != "")
                {
                    Temp += dieuKien + " DANTOC=" + "N'" + hocSinh_DTO.Dantoc + "' ";
                }
            }

            STRCMD = @"SELECT * FROM HOCSINH" + Temp;
            connection.kiemTraKetNoi(con);
            SqlCommand sqlcmd = new SqlCommand(STRCMD, con);
            da = new SqlDataAdapter(sqlcmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
