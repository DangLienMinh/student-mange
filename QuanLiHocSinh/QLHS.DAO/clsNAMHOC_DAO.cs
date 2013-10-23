using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using QLHS.DTO;

namespace QLHS.DAO
{
    public class clsNAMHOC_DAO
    {
         private clsConnectDatabase connection;
        private SqlConnection con;

        public clsNAMHOC_DAO()
        {
            connection = new clsConnectDatabase();
            con = connection.KetNoi();
        }

        public DataTable danhSachNamHoc()
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SP_ThongTinNamHoc", con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.kiemTraKetNoi(con);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        public void themNamHoc(clsNAMHOC_DTO namHoc)
        {
            SqlCommand command = new SqlCommand("SP_ThemNamHoc", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = namHoc.Manh;
            command.Parameters.Add("@TENNH", SqlDbType.NVarChar).Value = namHoc.Tenh;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }

        public void suaNamHoc(clsNAMHOC_DTO namHoc)
        {
            SqlCommand command = new SqlCommand("SP_SuaNamHoc", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = namHoc.Manh;
            command.Parameters.Add("@TENNH", SqlDbType.NVarChar).Value = namHoc.Tenh;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }
    }
}
