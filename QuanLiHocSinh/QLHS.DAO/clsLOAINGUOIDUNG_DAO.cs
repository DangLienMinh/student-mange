using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using QLHS.DTO;

namespace QLHS.DAO
{
    public class clsLOAINGUOIDUNG_DAO
    {
        private clsConnectDatabase connection;
        private SqlConnection con;

        public clsLOAINGUOIDUNG_DAO()
        {
            connection = new clsConnectDatabase();
            con = connection.KetNoi();
        }

        public DataTable danhSachLoaiNguoiDung()
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SP_ThongTinLoaiNguoiDung", con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.kiemTraKetNoi(con);
            adapter.Fill(table);
            con.Close();
            return table;
        }
      

        public void themLoaiNguoiDung(clsLOAINGUOIDUNG_DTO loaiNguoiDung_DTO)
        {
            SqlCommand command = new SqlCommand("SP_ThemLoaiNguoiDung", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MALND", SqlDbType.VarChar).Value = loaiNguoiDung_DTO.Malnd;
            command.Parameters.Add("@TENLND", SqlDbType.NVarChar).Value = loaiNguoiDung_DTO.Tenlnd;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }

        public void suaLoaiNguoiDung(clsLOAINGUOIDUNG_DTO loaiNguoiDung_DTO)
        {
            SqlCommand command = new SqlCommand("SP_SuaLoaiNguoiDung", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MALND", SqlDbType.VarChar).Value = loaiNguoiDung_DTO.Malnd;
            command.Parameters.Add("@TENLND", SqlDbType.NVarChar).Value = loaiNguoiDung_DTO.Tenlnd;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }

        public void xoaLoaiNguoiDung(clsLOAINGUOIDUNG_DTO loaiNguoiDung)
        {
            SqlCommand command = new SqlCommand("SP_XoaLoaiNguoiDung", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MALND", SqlDbType.VarChar).Value = loaiNguoiDung.Malnd;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }
    }
}
