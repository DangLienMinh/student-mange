using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLHS.DTO;
namespace QLHS.DAO
{
    public class clsMONHOC_DAO
    {
        private clsConnectDatabase connection;
        private SqlConnection con;
        public clsMONHOC_DAO()
        {
            connection = new clsConnectDatabase();
            con = connection.KetNoi();
        }
        public DataTable danhsachMonhoc()
        {
            connection.kiemTraKetNoi(con);
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SP_ThongTinMonHoc", con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }
        public void themMonhoc(clsMONHOC_DTO monhoc)
        {
            SqlCommand command = new SqlCommand("SP_ThemMonHoc", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAMH", SqlDbType.VarChar).Value = monhoc.Mamh;
            command.Parameters.Add("@TENMH", SqlDbType.NVarChar).Value = monhoc.Tenmh;
            command.Parameters.Add("@HESOMH", SqlDbType.Char).Value = monhoc.Hesomh;
            command.Parameters.Add("@SOTIET", SqlDbType.Char).Value = monhoc.Sotiet;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }
        public void suaMonhoc(clsMONHOC_DTO monhoc)
        {
            SqlCommand command = new SqlCommand("SP_SuaMonHoc", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAMH", SqlDbType.VarChar).Value = monhoc.Mamh;
            command.Parameters.Add("@TENMH", SqlDbType.NVarChar).Value = monhoc.Tenmh;
            command.Parameters.Add("@HESOMH", SqlDbType.Char).Value = monhoc.Hesomh;
            command.Parameters.Add("@SOTIET", SqlDbType.Char).Value = monhoc.Sotiet;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }
        public void xoaMonhoc(clsMONHOC_DTO monhoc)
        {
            SqlCommand command = new SqlCommand("SP_XoaMonHoc", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAMH", SqlDbType.VarChar).Value = monhoc.Mamh;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }
    }
}
