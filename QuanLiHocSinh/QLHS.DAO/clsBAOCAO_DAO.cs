using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLHS.DTO;

namespace QLHS.DAO
{
    public class clsBAOCAO_DAO
    {
        private SqlConnection con;
        private clsConnectDatabase connection;

        public clsBAOCAO_DAO()
        {
            connection = new clsConnectDatabase();
            con = connection.KetNoi();
        }

        //report học sinh giỏi SP_HSG
         public DataTable HSGTheoHocKy(clsBAOCAO_DTO baoCao_DTO)
        {
            connection.kiemTraKetNoi(con);
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SP_HSG", con);
            command.Parameters.Add("@MANH", SqlDbType.VarChar, 6).Value = baoCao_DTO.Manh;
            command.Parameters.Add("@MAHK", SqlDbType.VarChar, 10).Value = baoCao_DTO.Mahk;
            command.Parameters.Add("@MALOP", SqlDbType.VarChar, 15).Value = baoCao_DTO.Malop;
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

         //report học sinh lưu ban SP_LuuBan
         public DataTable HSLuuBanTheoHK(clsBAOCAO_DTO baoCao_DTO)
         {
             connection.kiemTraKetNoi(con);
             DataTable table = new DataTable();
             SqlCommand command = new SqlCommand("SP_LuuBan", con);
             command.Parameters.Add("@MANH", SqlDbType.VarChar, 6).Value = baoCao_DTO.Manh;
             command.Parameters.Add("@MAHK", SqlDbType.VarChar, 10).Value = baoCao_DTO.Mahk;
             command.Parameters.Add("@MAKHOI", SqlDbType.VarChar, 15).Value = baoCao_DTO.Makhoi;
             command.CommandType = CommandType.StoredProcedure;
             SqlDataAdapter adapter = new SqlDataAdapter(command);
             adapter.Fill(table);
             con.Close();
             return table;
         }

         //report bảng điểm học sinh SP_BANGDIEMHOCSINH
         public DataSet bangDiemHocSinh(string manh, string malop, string mahs)
         {
             connection.kiemTraKetNoi(con);
             DataSet bangdiem = new DataSet();
             SqlCommand command = new SqlCommand("SP_BANGDIEMHOCSINH", con);
             command.Parameters.Add("@MANH", SqlDbType.VarChar, 6).Value = manh;
             command.Parameters.Add("@MALOP", SqlDbType.VarChar, 10).Value = malop;
             command.Parameters.Add("@MAHS", SqlDbType.VarChar, 15).Value = mahs;
             command.CommandType = CommandType.StoredProcedure;
             SqlDataAdapter adapter = new SqlDataAdapter(command);
             adapter.Fill(bangdiem,"BangDiemHocSinh");
             con.Close();
             return bangdiem;
         }

         //report điểm theo môn học SP_DIEMTHEOMONHOC
         public DataTable DiemTheoMonHoc(clsBAOCAO_DTO baoCao_DTO)
         {
             connection.kiemTraKetNoi(con);
             DataTable table = new DataTable();
             SqlCommand command = new SqlCommand("SP_DIEMTHEOMONHOC", con);
             command.Parameters.Add("@MANH", SqlDbType.VarChar, 6).Value = baoCao_DTO.Manh;
             command.Parameters.Add("@MAHK", SqlDbType.VarChar, 10).Value = baoCao_DTO.Mahk;
             command.Parameters.Add("@MALOP", SqlDbType.VarChar, 15).Value = baoCao_DTO.Malop;
             command.Parameters.Add("@MAMH", SqlDbType.VarChar, 10).Value = baoCao_DTO.Mamh;
             command.CommandType = CommandType.StoredProcedure;
             SqlDataAdapter adapter = new SqlDataAdapter(command);
             adapter.Fill(table);
             con.Close();
             return table;
         }

        //report học bạ
         public DataTable HocBaTheoNamHoc(clsBAOCAO_DTO baoCao_DTO)
         {
             connection.kiemTraKetNoi(con);
             DataTable table = new DataTable();
             SqlCommand command = new SqlCommand("SP_HocBaTheoNamHoc", con);
             command.Parameters.Add("@MANH", SqlDbType.VarChar, 6).Value = baoCao_DTO.Manh;
             command.Parameters.Add("@MAHS", SqlDbType.VarChar, 10).Value = baoCao_DTO.Mahs;
             command.Parameters.Add("@MALOP", SqlDbType.VarChar, 10).Value = baoCao_DTO.Malop;

             command.CommandType = CommandType.StoredProcedure;
             SqlDataAdapter adapter = new SqlDataAdapter(command);
             adapter.Fill(table);
             con.Close();
             return table;
         }

         //danh sách các năm học của học sinh SP_DanhSachCacNamHoc
         public DataTable DanhSachCacNamHoc(string maHS)
         {
             connection.kiemTraKetNoi(con);
             DataTable table = new DataTable();
             SqlCommand command = new SqlCommand("SP_DanhSachCacNamHoc", con);
             command.Parameters.Add("@MAHS", SqlDbType.VarChar, 8).Value = maHS;
             command.CommandType = CommandType.StoredProcedure;
             SqlDataAdapter adapter = new SqlDataAdapter(command);
             adapter.Fill(table);
             con.Close();
             return table;
         }

         //report danh sách lớp SP_ReportDSLop
         public DataSet reportDanhSachLop()
         {
             connection.kiemTraKetNoi(con);
             DataSet ds = new DataSet();
             SqlCommand command = new SqlCommand("SP_ReportDSLop", con);
             command.CommandType = CommandType.StoredProcedure;
             SqlDataAdapter adapter = new SqlDataAdapter(command);
             adapter.Fill(ds, "Lop");
             con.Close();
             return ds;
         }

         //report danh sách các giáo viên SP_ReportDSGiaoVien
         public DataSet reportDanhSachGiaoVien()
         {
             connection.kiemTraKetNoi(con);
             DataSet ds = new DataSet();
             SqlCommand command = new SqlCommand("SP_ReportDSGiaoVien", con);
             command.CommandType = CommandType.StoredProcedure;
             SqlDataAdapter adapter = new SqlDataAdapter(command);
             adapter.Fill(ds, "GiaoVien");
             con.Close();
             return ds;
         }

         //TAO THE HOC SINH SP_ReportTheHocSinh
         public DataSet reportTheHS(string maLop)
         {
             DataSet ds = new DataSet();
             connection.kiemTraKetNoi(con);
             SqlCommand command = new SqlCommand("SP_ReportTheHocSinh", con);
             command.Parameters.Add("@MALOP", SqlDbType.VarChar).Value = maLop;
             command.CommandType = CommandType.StoredProcedure;
             SqlDataAdapter adapter = new SqlDataAdapter(command);
             adapter.Fill(ds, "TheHocSinh");
             con.Close();
             return ds;
         }
    }
}
