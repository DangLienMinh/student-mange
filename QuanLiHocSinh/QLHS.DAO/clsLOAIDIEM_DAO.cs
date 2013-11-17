using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using QLHS.DTO;

namespace QLHS.DAO
{
    public class clsLOAIDIEM_DAO
    {
        private clsConnectDatabase connection;
        private SqlConnection con;

        public clsLOAIDIEM_DAO()
        {
            connection = new clsConnectDatabase();
            con = connection.KetNoi();
        }

        public DataTable danhSachLoaiDiem()
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SP_ThongTinLoaiDiem", con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.kiemTraKetNoi(con);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        public void themLoaiDiem(clsLOAIDIEM_DTO loaiDiem)
        {
            SqlCommand command = new SqlCommand("SP_ThemLoaiDiem", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MALD", SqlDbType.VarChar).Value = loaiDiem.Mald;
            command.Parameters.Add("@TENLD", SqlDbType.NVarChar).Value = loaiDiem.Tenld;
            command.Parameters.Add("@HESOLD", SqlDbType.Char).Value = loaiDiem.Hesold;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }

        public void suaLoaiDiem(clsLOAIDIEM_DTO loaiDiem)
        {
            SqlCommand command = new SqlCommand("SP_SuaLoaiDiem", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MALD", SqlDbType.VarChar).Value = loaiDiem.Mald;
            command.Parameters.Add("@TENLD", SqlDbType.NVarChar).Value = loaiDiem.Tenld;
            command.Parameters.Add("@HESOLD", SqlDbType.Char).Value = loaiDiem.Hesold;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }

        public void xoaLoaiDiem(clsLOAIDIEM_DTO loaiDiem)
        {
            SqlCommand command = new SqlCommand("SP_XoaLoaiDiem", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MALD", SqlDbType.VarChar).Value = loaiDiem.Mald;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }

        public int heSoLoaiDiem(clsLOAIDIEM_DTO loaiDiem)
        {
            int temp = -1;
            SqlCommand command = new SqlCommand("SP_HeSoLoaiDiem", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MALD", SqlDbType.VarChar).Value = loaiDiem.Mald;
            connection.kiemTraKetNoi(con);
            if (command.ExecuteScalar().ToString() != "")
            {
                temp = int.Parse(command.ExecuteScalar().ToString());
            }
            else
            {
                temp = 0;
            }

            con.Close();
            return temp;
        }
    }
}
