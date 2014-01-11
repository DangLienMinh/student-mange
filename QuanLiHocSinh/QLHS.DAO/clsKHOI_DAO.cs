using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLHS.DTO;

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

        //thông tin khối SP_ThongTinKhoi 
        public DataTable danhSachKhoi()
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

        //hiển thị danh sách khối theo mã khối được chọn ví dụ nếu chọn khối 10 thì chỉ xuất hiện khối 10  dùng cho việc chuyển lớp học sinh SP_HienThiKhoiChuyenLop
        public DataTable danhSachKhoiChuyenLop(clsKHOI_DTO khoi_DTO)
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_HienThiKhoiChuyenLop", con);
            command.Parameters.Add("@MAKHOI", SqlDbType.VarChar).Value = khoi_DTO.Makhoi;
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        //hiển thị danh sách khối theo mã khối được chọn ví dụ nếu chọn khối 10 thì chỉ xuất hiện khối 10 và 11 dùng cho việc phân lớp học sinh
        public DataTable danhSachKhoiTheoMaKhoi(clsKHOI_DTO khoi_DTO)
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_HienThiKhoi", con);
            command.Parameters.Add("@MAKHOI", SqlDbType.VarChar).Value = khoi_DTO.Makhoi;
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        //hiển thị thông tin khối 10 SP_HienThiKhoi10
        public DataTable danhSachKhoi10()
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_HienThiKhoi10", con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }
    }
}
