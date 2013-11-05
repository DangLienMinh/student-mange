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
        public void themPhanCong(clsGIANGDAY_DTO giangday)
        {
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_ThemGiangDay", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAMH", SqlDbType.VarChar,10).Value = giangday.Mamh;
            command.Parameters.Add("@MANH", SqlDbType.VarChar,6).Value = giangday.Manh;
            command.Parameters.Add("@MAGV", SqlDbType.Char,5).Value = giangday.Magv;
            command.Parameters.Add("@MALOP", SqlDbType.VarChar,10).Value = giangday.Malop;
            command.ExecuteNonQuery();
            con.Close();
        }
        public void xoaPhanCong(clsGIANGDAY_DTO giangday)
        {
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_XoaGiangDay", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAMH", SqlDbType.VarChar, 10).Value = giangday.Mamh;
            command.Parameters.Add("@MANH", SqlDbType.VarChar, 6).Value = giangday.Manh;
            command.Parameters.Add("@MAGV", SqlDbType.Char, 5).Value = giangday.Magv;
            command.Parameters.Add("@MALOP", SqlDbType.VarChar, 10).Value = giangday.Malop;
            command.ExecuteNonQuery();
            con.Close();
        }
    }
}
