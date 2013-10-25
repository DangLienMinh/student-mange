using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QLHS.DAO
{
    public class clsKHOI_DAO
    {
        private clsConnectDatabase connection;
        private SqlConnection con;
        public clsKHOI_DAO()
        {
            connection = new clsConnectDatabase();
            con = connection.KetNoi();
        }
        public DataTable danhsachKhoi()
        {
            DataTable table=new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command=new SqlCommand("SP_ThongTinKhoi",con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }
    }
}
