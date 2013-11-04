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
            SqlCommand command = new SqlCommand("SP_DanhSachPhanCon", con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }
        public void themPhanCong(clsGIANGDAY_DTO giangday)
        {
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_ThemGiangDay", con);
            command.Parameters.Add("@MAMH", SqlDbType.VarChar).Value = giangday.Mamh;
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = giangday.Manh;
            command.Parameters.Add("@MAGV", SqlDbType.Char).Value = giangday.Magv;
            command.Parameters.Add("@MALOP", SqlDbType.VarChar).Value = giangday.Malop;
            command.ExecuteNonQuery();
            con.Close();
        }
    }
}
