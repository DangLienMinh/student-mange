using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLHS.DTO;
namespace QLHS.DAO
{
    public class clsLOAIHANHKIEM_DAO
    {
        private clsConnectDatabase connection;
        private SqlConnection con;
        public clsLOAIHANHKIEM_DAO()
        {
            connection = new clsConnectDatabase();
            con = connection.KetNoi();
        }

        //thông tin loại hạnh kiểm SP_ThongTinLoaiHanhKiem
        public DataTable danhsachLoaiHK()
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_ThongTinLoaiHanhKiem", con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }
    }
}
