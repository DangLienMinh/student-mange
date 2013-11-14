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
    }
}
