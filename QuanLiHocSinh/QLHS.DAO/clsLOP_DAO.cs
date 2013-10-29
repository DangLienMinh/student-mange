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

        public DataTable danhSachLop()
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

        public DataTable danhSachLopTheoNamHoc(clsLOP_DTO lop)
        {
            connection.kiemTraKetNoi(con);
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SP_ThongTinLopNamHoc", con);
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = lop.Manh;
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        public DataTable danhSachLopTheoNamHocKhoi(clsLOP_DTO lop)
        {
            connection.kiemTraKetNoi(con);
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SP_ThongTinLopNamHocKhoi", con);
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = lop.Manh;
            command.Parameters.Add("@MAKHOI", SqlDbType.VarChar).Value = lop.Makhoi;
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        public int soLop(string nam)
        {
            int temp = -1;
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SP_ThongTinSoLop", con);
            command.Parameters.Add("@NAM", SqlDbType.Char).Value = nam;
            command.CommandType = CommandType.StoredProcedure;
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

        public DataTable chonLop10(string nam)
        {
            connection.kiemTraKetNoi(con);
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SP_ThongTinLop10", con);
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = nam;
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
            command.Parameters.Add("@MAKHOI", SqlDbType.VarChar).Value = lop.Makhoi;
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = lop.Manh;
            command.Parameters.Add("@MALOP", SqlDbType.VarChar).Value = lop.Malop;
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
            command.Parameters.Add("@MAKHOI", SqlDbType.VarChar).Value = lop.Makhoi;
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = lop.Manh;
            command.Parameters.Add("@MALOP", SqlDbType.VarChar).Value = lop.Malop;
            command.Parameters.Add("@TENLOP", SqlDbType.NVarChar).Value = lop.Tenlop;
            command.Parameters.Add("@SISO", SqlDbType.VarChar).Value = lop.Siso;
            command.Parameters.Add("@MAGV", SqlDbType.Char).Value = lop.Magv;
            command.ExecuteNonQuery();
            con.Close();
        }
        public void xoaLop(clsLOP_DTO lop)
        {
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_XoaLop", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MALOP", SqlDbType.VarChar).Value = lop.Malop;
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = lop.Manh;
            command.ExecuteNonQuery();
            con.Close();
        }
        public DataTable timLopMaLop(string tukhoa)
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_TimLopMaLop", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MALOP", SqlDbType.VarChar).Value = tukhoa;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
    }
}
