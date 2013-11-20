using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLHS.DTO;
using System.Data;
using System.Data.SqlClient;
namespace QLHS.DAO
{
    public class clsGIANGDAY_DAO
    {
        private SqlConnection con;
        private clsConnectDatabase connection;
        public clsGIANGDAY_DAO()
        {
            connection = new clsConnectDatabase();
            con = connection.KetNoi();
        }
        public DataTable danhsachPhancong()
        {
            connection.kiemTraKetNoi(con);
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SP_DanhSachPhanCong", con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }
        public void themPhanCong(clsGIANGDAY_DTO giangDay_DTO)
        {
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_ThemGiangDay", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAMH", SqlDbType.VarChar,10).Value = giangDay_DTO.Mamh;
            command.Parameters.Add("@MANH", SqlDbType.VarChar,6).Value = giangDay_DTO.Manh;
            command.Parameters.Add("@MAGV", SqlDbType.Char,5).Value = giangDay_DTO.Magv;
            command.Parameters.Add("@MALOP", SqlDbType.VarChar,10).Value = giangDay_DTO.Malop;
            command.ExecuteNonQuery();
            con.Close();
        }
        public void suaPhanCong(clsGIANGDAY_DTO giangdaymoi, clsGIANGDAY_DTO giangdaycu)
        {
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_SuaGiangDay", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAMH", SqlDbType.VarChar, 10).Value = giangdaymoi.Mamh;
            command.Parameters.Add("@MANH", SqlDbType.VarChar, 6).Value = giangdaymoi.Manh;
            command.Parameters.Add("@MAGV", SqlDbType.Char, 5).Value = giangdaymoi.Magv;
            command.Parameters.Add("@MALOP", SqlDbType.VarChar, 10).Value = giangdaycu.Malop;
            command.Parameters.Add("@MAMH1", SqlDbType.VarChar, 10).Value = giangdaycu.Mamh;
            command.Parameters.Add("@MANH1", SqlDbType.VarChar, 6).Value = giangdaycu.Manh;
            command.Parameters.Add("@MAGV1", SqlDbType.Char, 5).Value = giangdaycu.Magv;
            command.Parameters.Add("@MALOP1", SqlDbType.VarChar, 10).Value = giangdaycu.Malop;
            command.ExecuteNonQuery();
            con.Close();
            
        }
        public void xoaPhanCong(clsGIANGDAY_DTO giangDay_DTO)
        {
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_XoaGiangDay", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAMH", SqlDbType.VarChar, 10).Value = giangDay_DTO.Mamh;
            command.Parameters.Add("@MANH", SqlDbType.VarChar, 6).Value = giangDay_DTO.Manh;
            command.Parameters.Add("@MAGV", SqlDbType.Char, 5).Value = giangDay_DTO.Magv;
            command.Parameters.Add("@MALOP", SqlDbType.VarChar, 10).Value = giangDay_DTO.Malop;
            command.ExecuteNonQuery();
            con.Close();
        }
        public DataTable timPhanCong(clsGIAOVIEN_DTO giaoVien_DTO, clsLOP_DTO lop_DTO)
        {
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_TimGiangDay", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@TENGV", SqlDbType.NVarChar).Value = giaoVien_DTO.Tengv;
            command.Parameters.Add("@TENLOP", SqlDbType.NVarChar).Value = lop_DTO.Tenlop;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            con.Close();
            return table;
        }
    }
}
