using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLHS.DAO;
using QLHS.DTO;
namespace QLHS.DAO
{
    public class clsHANHKIEM_DAO
    {
        private clsConnectDatabase connection;
        private SqlConnection con;
        public clsHANHKIEM_DAO()
        {
            connection = new clsConnectDatabase();
            con = connection.KetNoi();
        }
        public void ThemHanhKiem(clsHANHKIEM_DTO hanhkiem)
        {
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_ThemHanhKiem", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MALHK", SqlDbType.VarChar).Value = hanhkiem.Malhk;
            command.Parameters.Add("@MAHS", SqlDbType.VarChar).Value = hanhkiem.Mahs;
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = hanhkiem.Manh;
            command.Parameters.Add("@MAHK", SqlDbType.VarChar).Value = hanhkiem.Mahk;
            command.ExecuteNonQuery();
            con.Close();
        }
        public void suaHanhKiem(clsHANHKIEM_DTO hanhkiem)
        {
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_SuaHanhKiem", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MALHK", SqlDbType.VarChar).Value = hanhkiem.Malhk;
            command.Parameters.Add("@MAHS", SqlDbType.VarChar).Value = hanhkiem.Mahs;
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = hanhkiem.Manh;
            command.Parameters.Add("@MAHK", SqlDbType.VarChar).Value = hanhkiem.Mahk;
            command.ExecuteNonQuery();
            con.Close();
        }
        public void xoaHanhKiem(clsHANHKIEM_DTO hanhkiem)
        {
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_XoaHanhKiem", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAHS", SqlDbType.VarChar).Value = hanhkiem.Mahs;
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = hanhkiem.Manh;
            command.Parameters.Add("@MAHK", SqlDbType.VarChar).Value = hanhkiem.Mahk;
            command.ExecuteNonQuery();
            con.Close();
        }

        public DataTable danhsachHanhKiem(string manh, string malop, string mahk)
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_DanhSachHanhKiem", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = manh;
            command.Parameters.Add("@MAHK", SqlDbType.VarChar).Value = mahk;
            command.Parameters.Add("@MALOP", SqlDbType.VarChar).Value = malop;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        //form kết quả
        public DataTable hanhKiemTheoHocKiNamHoc(clsHANHKIEM_DTO hanhKiem_DTO)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SP_HanhKiemTheoHocKiNamHoc", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MANH", SqlDbType.VarChar, 6).Value = hanhKiem_DTO.Manh;
            command.Parameters.Add("@MAHK", SqlDbType.VarChar, 10).Value = hanhKiem_DTO.Mahk;
            command.Parameters.Add("@MAHS", SqlDbType.VarChar, 8).Value = hanhKiem_DTO.Mahs;
            connection.kiemTraKetNoi(con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }
    }
}
