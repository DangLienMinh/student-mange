using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLHS.DTO;
namespace QLHS.DAO
{
    public class clsLOP_DAO
    {
        private clsConnectDatabase connection;
        private SqlConnection con;
        public clsLOP_DAO()
        {
            connection = new clsConnectDatabase();
            con = connection.KetNoi();
        }
        public DataTable danhsachLop()
        {
            connection.kiemTraKetNoi(con);
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SP_ThongTinLop", con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }
        public void themLop(clsLOP_DTO lop)
        {
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_ThemLop", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAKHOI", SqlDbType.Char).Value = lop.Makhoi;
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = lop.Manh;
            command.Parameters.Add("@MALOP", SqlDbType.Char).Value = lop.Malop;
            command.Parameters.Add("@TENLOP", SqlDbType.NVarChar).Value = lop.Tenlop;
            command.Parameters.Add("@SISO", SqlDbType.VarChar).Value = lop.Siso;
            command.Parameters.Add("@MAGV", SqlDbType.Char).Value = lop.Magv;
            command.ExecuteNonQuery();
            con.Close();
        }
        public void suaLop(clsLOP_DTO lop)
        {
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_SuaLop", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAKHOI", SqlDbType.Char).Value = lop.Makhoi;
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = lop.Manh;
            command.Parameters.Add("@MALOP", SqlDbType.Char).Value = lop.Malop;
            command.Parameters.Add("@TENLOP", SqlDbType.NVarChar).Value = lop.Tenlop;
            command.Parameters.Add("@SISO", SqlDbType.VarChar).Value = lop.Siso;
            command.Parameters.Add("@MAGV", SqlDbType.Char).Value = lop.Magv;
            command.ExecuteNonQuery();
            con.Close();
        }
        public void xoaLop(clsLOP_DTO lop)
        {
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_SuaLop", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MALOP", SqlDbType.Char).Value = lop.Malop;
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = lop.Manh;
            command.ExecuteNonQuery();
            con.Close();
        }
    }
}
