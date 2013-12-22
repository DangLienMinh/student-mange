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

        //danh sách ngừoi dùng hiện có
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

        //thông tin người dùng theo tên đăng nhập
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

        //lấy mã người dùng gần nhất để làm cơ sở tạo mã tự động
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

        //thêm một người dùng mới
        public void themNguoiDung(clsNGUOIDUNG_DTO nguoiDung_DTO)
        {
            SqlCommand command = new SqlCommand("SP_ThemNguoiDung", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAND", SqlDbType.Char).Value = nguoiDung_DTO.Mand;
            command.Parameters.Add("@TENND", SqlDbType.NVarChar).Value = nguoiDung_DTO.Tennd;
            command.Parameters.Add("@MALND", SqlDbType.VarChar).Value = nguoiDung_DTO.Malnd;
            command.Parameters.Add("@TENDN", SqlDbType.VarChar).Value = nguoiDung_DTO.Tendn;
            command.Parameters.Add("@MATKHAU", SqlDbType.VarChar).Value = nguoiDung_DTO.Matkhau;
            
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }

        //sửa thông tin một người dùng
        public void suaNguoiDung(clsNGUOIDUNG_DTO nguoiDung_DTO)
        {
            SqlCommand command = new SqlCommand("SP_SuaNguoiDung", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAND", SqlDbType.Char).Value = nguoiDung_DTO.Mand;
            command.Parameters.Add("@TENND", SqlDbType.NVarChar).Value = nguoiDung_DTO.Tennd;
            command.Parameters.Add("@MALND", SqlDbType.VarChar).Value = nguoiDung_DTO.Malnd;
            command.Parameters.Add("@TENDN", SqlDbType.VarChar).Value = nguoiDung_DTO.Tendn;
            command.Parameters.Add("@MATKHAU", SqlDbType.VarChar).Value = nguoiDung_DTO.Matkhau;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }

        //sửa mật khâu
        public void suaMatKhau(clsNGUOIDUNG_DTO nguoiDung_DTO)
        {
            SqlCommand command = new SqlCommand("SP_SuaMatKhau", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@TENDN", SqlDbType.VarChar).Value = nguoiDung_DTO.Tendn;
            command.Parameters.Add("@MATKHAU", SqlDbType.VarChar).Value = nguoiDung_DTO.Matkhau;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }

        //xóa một người dùng
        public void xoaNguoiDung(clsNGUOIDUNG_DTO nguoiDung_DTO)
        {
            SqlCommand command = new SqlCommand("SP_XoaNguoiDung", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAND", SqlDbType.Char).Value = nguoiDung_DTO.Mand;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }
    }
}
