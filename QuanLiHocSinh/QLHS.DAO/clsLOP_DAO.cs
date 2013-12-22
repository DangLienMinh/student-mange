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

        //thông tin lớp hiện có trong CSDL
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

        //thông tin phân ban
        public DataTable danhSachBan()
        {
            connection.kiemTraKetNoi(con);
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SP_ThongTinBan", con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        //nguy hiểm cần coi lại .................................................................................
        public DataTable danhSachLop(string maHS,string maNH)
        {
            connection.kiemTraKetNoi(con);
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SP_ThongTinLopMaHSMaNH", con);
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = maNH;
            command.Parameters.Add("@MAHS", SqlDbType.VarChar).Value = maHS;
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        //thông tin sỉ số của lớp đó
        public int siSoLop(clsLOP_DTO lop_DTO)
        {
            int result = -1;
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_ThongTinSiSoLop", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MALOP", SqlDbType.VarChar).Value = lop_DTO.Malop;
            result=int.Parse(command.ExecuteScalar().ToString());
            con.Close();
            return result;

        }

        //thông tin lớp theo năm học
        public DataTable danhSachLopTheoNamHoc(clsLOP_DTO lop_DTO)
        {
            connection.kiemTraKetNoi(con);
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SP_ThongTinLopNamHoc", con);
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = lop_DTO.Manh;
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        //danh sách lớp theo năm học và khối
        public DataTable danhSachLopTheoNamHocKhoi(clsLOP_DTO lop_DTO)
        {
            connection.kiemTraKetNoi(con);
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SP_DanhSachLopMAKHOIMANH", con);
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = lop_DTO.Manh;
            command.Parameters.Add("@MAKHOI", SqlDbType.VarChar).Value = lop_DTO.Makhoi;
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        //public DataTable danhsachLopMAKHOI(string maKhoi, string maNH)
        //{
        //    DataTable table = new DataTable();
        //    connection.kiemTraKetNoi(con);
        //    SqlCommand command = new SqlCommand("SP_DanhSachLopMAKHOIMANH", con);
        //    command.CommandType = CommandType.StoredProcedure;
        //    command.Parameters.Add("@MAKHOI", SqlDbType.VarChar).Value = maKhoi;
        //    command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = maNH;
        //    SqlDataAdapter adapter = new SqlDataAdapter(command);
        //    adapter.Fill(table);
        //    con.Close();
        //    return table;
        //}

        //lấy thông tin malop để tạo mã lớp tự động

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

        //???? .............................................chọn lớp 10
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

        //thêm một lớp mới
        public void themLop(clsLOP_DTO lop_DTO)
        {
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_ThemLop", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAKHOI", SqlDbType.VarChar).Value = lop_DTO.Makhoi;
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = lop_DTO.Manh;
            command.Parameters.Add("@MALOP", SqlDbType.VarChar).Value = lop_DTO.Malop;
            command.Parameters.Add("@TENLOP", SqlDbType.NVarChar).Value = lop_DTO.Tenlop;
            command.Parameters.Add("@SISO", SqlDbType.VarChar).Value = lop_DTO.Siso;
            command.Parameters.Add("@MAGV", SqlDbType.Char).Value = lop_DTO.Magv;
            command.Parameters.Add("@MABAN", SqlDbType.VarChar).Value = lop_DTO.Maban;
            command.ExecuteNonQuery();
            con.Close();
        }

        //sửa thông tin một lớp
        public void suaLop(clsLOP_DTO lop_DTO)
        {
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_SuaLop", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAKHOI", SqlDbType.VarChar).Value = lop_DTO.Makhoi;
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = lop_DTO.Manh;
            command.Parameters.Add("@MALOP", SqlDbType.VarChar).Value = lop_DTO.Malop;
            command.Parameters.Add("@TENLOP", SqlDbType.NVarChar).Value = lop_DTO.Tenlop;
            command.Parameters.Add("@SISO", SqlDbType.VarChar).Value = lop_DTO.Siso;
            command.Parameters.Add("@MAGV", SqlDbType.Char).Value = lop_DTO.Magv;
            command.Parameters.Add("@MABAN", SqlDbType.VarChar).Value = lop_DTO.Maban;
            command.ExecuteNonQuery();
            con.Close();
        }

        //xóa thông tin một lớp
        public void xoaLop(clsLOP_DTO lop_DTO)
        {
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_XoaLop", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MALOP", SqlDbType.VarChar).Value = lop_DTO.Malop;
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = lop_DTO.Manh;
            command.ExecuteNonQuery();
            con.Close();
        }

        //tìm lớp theo mã lớp
        public DataTable timLopMaLop(string tuKhoa)
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_TimLopMaLop", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MALOP", SqlDbType.VarChar).Value = tuKhoa;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        
        //thông tin mã ban theo mã lớp
        public string phanBan(clsLOP_DTO lop_DTO)
        {
            string temp = "";
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SP_ThongTinPhanBanTheoLop", con);
            command.Parameters.Add("@MALOP", SqlDbType.VarChar).Value = lop_DTO.Malop;
            command.CommandType = CommandType.StoredProcedure;
            connection.kiemTraKetNoi(con);
            if (command.ExecuteScalar().ToString() != "")
            {
                temp =command.ExecuteScalar().ToString();
            }
            else
            {
                temp = "";
            }

            con.Close();
            return temp;
        }
    }
}
