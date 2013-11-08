using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using QLHS.DTO;

namespace QLHS.DAO
{
    public class clsNGUOIDUNG_DAO
    {
        private clsConnectDatabase connection;
        private SqlConnection con;

        public clsNGUOIDUNG_DAO()
        {
            connection = new clsConnectDatabase();
            con = connection.KetNoi();
        }

        public DataTable danhSachNguoiDung()
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SP_ThongTinNguoiDung", con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.kiemTraKetNoi(con);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        public DataTable danhSachNguoiDungTheoTENDN(string tenDN)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SP_ThongTinNguoiDungTheoTENDN", con);
            command.Parameters.Add("@TENDN", SqlDbType.VarChar).Value = tenDN;
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.kiemTraKetNoi(con);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        public int soNguoiDung()
        {
            int temp = -1;
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SP_ThongTinSoNguoiDung", con);
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

        //public DataTable timGVMaGV(clsNGUOIDUNG_DTO nguoidung)
        //{
        //    DataTable table = new DataTable();
        //    SqlCommand command = new SqlCommand("SP_TimNguoiDungMaGV", con);
        //    command.CommandType = CommandType.StoredProcedure;
        //    command.Parameters.Add("@MAGV", SqlDbType.Char).Value = nguoidung.Magv;
        //    SqlDataAdapter adapter = new SqlDataAdapter(command);
        //    connection.kiemTraKetNoi(con);
        //    adapter.Fill(table);
        //    con.Close();
        //    return table;
        //}

        //public DataTable timGVTenGV(clsNGUOIDUNG_DTO nguoidung)
        //{
        //    DataTable table = new DataTable();
        //    SqlCommand command = new SqlCommand("SP_TimNguoiDungTenGV", con);
        //    command.CommandType = CommandType.StoredProcedure;
        //    command.Parameters.Add("@TENGV", SqlDbType.NVarChar).Value = nguoidung.Tengv;
        //    SqlDataAdapter adapter = new SqlDataAdapter(command);
        //    connection.kiemTraKetNoi(con);
        //    adapter.Fill(table);
        //    con.Close();
        //    return table;
        //}

        public void themNguoiDung(clsNGUOIDUNG_DTO nguoidung)
        {
            SqlCommand command = new SqlCommand("SP_ThemNguoiDung", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAND", SqlDbType.Char).Value = nguoidung.Mand;
            command.Parameters.Add("@TENND", SqlDbType.NVarChar).Value = nguoidung.Tennd;
            command.Parameters.Add("@MALND", SqlDbType.VarChar).Value = nguoidung.Malnd;
            command.Parameters.Add("@TENDN", SqlDbType.VarChar).Value = nguoidung.Tendn;
            command.Parameters.Add("@MATKHAU", SqlDbType.VarChar).Value = nguoidung.Matkhau;
            
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }

        public void suaNguoiDung(clsNGUOIDUNG_DTO nguoidung)
        {
            SqlCommand command = new SqlCommand("SP_SuaNguoiDung", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAND", SqlDbType.Char).Value = nguoidung.Mand;
            command.Parameters.Add("@TENND", SqlDbType.NVarChar).Value = nguoidung.Tennd;
            command.Parameters.Add("@MALND", SqlDbType.VarChar).Value = nguoidung.Malnd;
            command.Parameters.Add("@TENDN", SqlDbType.VarChar).Value = nguoidung.Tendn;
            command.Parameters.Add("@MATKHAU", SqlDbType.VarChar).Value = nguoidung.Matkhau;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }

        public void xoaNguoiDung(clsNGUOIDUNG_DTO nguoidung)
        {
            SqlCommand command = new SqlCommand("SP_XoaNguoiDung", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAND", SqlDbType.Char).Value = nguoidung.Mand;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }
    }
}
