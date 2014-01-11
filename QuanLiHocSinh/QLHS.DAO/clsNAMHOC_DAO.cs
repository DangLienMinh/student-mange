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

        //thông tin năm học SP_ThongTinNamHoc
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

        //thêm một năm học mới SP_ThemNamHoc
        public void themNamHoc(clsNAMHOC_DTO namHoc_DTO)
        {
            SqlCommand command = new SqlCommand("SP_ThemNamHoc", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = namHoc_DTO.Manh;
            command.Parameters.Add("@TENNH", SqlDbType.NVarChar).Value = namHoc_DTO.Tenh;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }

        //sửa một năm học SP_SuaNamHoc
        public void suaNamHoc(clsNAMHOC_DTO namHoc_DTO)
        {
            SqlCommand command = new SqlCommand("SP_SuaNamHoc", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = namHoc_DTO.Manh;
            command.Parameters.Add("@TENNH", SqlDbType.NVarChar).Value = namHoc_DTO.Tenh;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }
    }
}
