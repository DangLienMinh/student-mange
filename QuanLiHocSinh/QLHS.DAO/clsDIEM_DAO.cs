using System;
using System.Collections.Generic;
using System.Text;
using QLHS.DTO;
using System.Data;
using System.Data.SqlClient;

namespace QLHS.DAO
{
    public class clsDIEM_DAO
    {
        private SqlConnection con;
        private clsConnectDatabase connection;
        //mở kết nối trong hàm khời tạo
        public clsDIEM_DAO()
        {
            connection = new clsConnectDatabase();
            con = connection.KetNoi();
        }

        //đếm số lần xuất hiên của một loại điểm SP_DemDiem
        public int demDiem(clsDIEM_DTO diem_DTO)
        {
            int temp;
            SqlCommand command = new SqlCommand("SP_DemDiem", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MANH", SqlDbType.VarChar, 6).Value = diem_DTO.Manh;
            command.Parameters.Add("@MAHK", SqlDbType.VarChar, 10).Value = diem_DTO.Mahk;
            command.Parameters.Add("@MALD", SqlDbType.VarChar, 15).Value =diem_DTO.Mald;
            command.Parameters.Add("@MAMH", SqlDbType.VarChar, 10).Value = diem_DTO.Mamh;
            command.Parameters.Add("@MAHS", SqlDbType.VarChar, 8).Value = diem_DTO.Mahs;
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

        //thêm một điểm mới cho học sinh SP_ThemDiemTheoHS
        public void themDiemTheoHS(clsDIEM_DTO diem_DTO)
        {
            SqlCommand command = new SqlCommand("SP_ThemDiemTheoHS", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MANH", SqlDbType.VarChar, 6).Value = diem_DTO.Manh;
            command.Parameters.Add("@MAHK", SqlDbType.VarChar, 10).Value = diem_DTO.Mahk;
            command.Parameters.Add("@MALD", SqlDbType.VarChar, 15).Value = diem_DTO.Mald;
            command.Parameters.Add("@MAMH", SqlDbType.VarChar, 10).Value = diem_DTO.Mamh;
            command.Parameters.Add("@MAHS", SqlDbType.VarChar, 8).Value = diem_DTO.Mahs;
            command.Parameters.Add("@DIEMSO", SqlDbType.VarChar, 4).Value = diem_DTO.Diemso;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();   
            con.Close();
        }

        //lấy thông tin điểm học sinh theo MANH, MAHK, MAMH, MAHS SP_DiemTBTheoHocKiMonHoc
        public DataTable diemTBTheoHocKiMonHoc(clsDIEM_DTO diem_DTO)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SP_DiemTBTheoHocKiMonHoc", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MANH", SqlDbType.VarChar, 6).Value = diem_DTO.Manh;
            command.Parameters.Add("@MAHK", SqlDbType.VarChar, 10).Value = diem_DTO.Mahk;
            command.Parameters.Add("@MAMH", SqlDbType.VarChar, 10).Value = diem_DTO.Mamh;
            command.Parameters.Add("@MAHS", SqlDbType.VarChar, 8).Value = diem_DTO.Mahs;
            connection.kiemTraKetNoi(con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        //lấy tất cả thông tin điểm học sinh theo MANH,MAHK,MAMH,MAHS,MALD SP_ThongTinDiemTheoHS
        public DataTable thongTinDiemTheoHS(clsDIEM_DTO diem_DTO)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SP_ThongTinDiemTheoHS", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MANH", SqlDbType.VarChar, 6).Value = diem_DTO.Manh;
            command.Parameters.Add("@MAHK", SqlDbType.VarChar, 10).Value = diem_DTO.Mahk;
            command.Parameters.Add("@MALD", SqlDbType.VarChar, 15).Value = diem_DTO.Mald;
            command.Parameters.Add("@MAMH", SqlDbType.VarChar, 10).Value = diem_DTO.Mamh;
            command.Parameters.Add("@MAHS", SqlDbType.VarChar, 8).Value = diem_DTO.Mahs;
            connection.kiemTraKetNoi(con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        //chỉ lấy điểm số của học sinh theo thông tin nhập vào SP_ThongTinDiemHSTheoMaLD
        public DataTable thongTinDiemTheoMaLD(clsDIEM_DTO diem_DTO)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SP_ThongTinDiemHSTheoMaLD", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MANH", SqlDbType.VarChar, 6).Value = diem_DTO.Manh;
            command.Parameters.Add("@MAHK", SqlDbType.VarChar, 10).Value = diem_DTO.Mahk;
            command.Parameters.Add("@MALD", SqlDbType.VarChar, 15).Value = diem_DTO.Mald;
            command.Parameters.Add("@MAMH", SqlDbType.VarChar, 10).Value = diem_DTO.Mamh;
            command.Parameters.Add("@MAHS", SqlDbType.VarChar, 8).Value = diem_DTO.Mahs;
            connection.kiemTraKetNoi(con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        //sửa điểm số của học sinh SP_SuaDiemTheoHS
        public void suaDiemTheoHS(clsDIEM_DTO diem_DTO)
        {
            SqlCommand command = new SqlCommand("SP_SuaDiemTheoHS", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@STT", SqlDbType.Int).Value = diem_DTO.Stt;
            command.Parameters.Add("@DIEMSO", SqlDbType.VarChar, 4).Value = diem_DTO.Diemso;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }

        //xóa điểm học sinh SP_XoaDiemTheoHS
        public void xoaDiemTheoHS(clsDIEM_DTO diem_DTO)
        {
            SqlCommand command = new SqlCommand("SP_XoaDiemTheoHS", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@STT", SqlDbType.Int).Value = diem_DTO.Stt;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }

        //xóa tất cả các điểm học sinh theo mã loại điểm SP_XoaDiemHSTheoMaLD
        public void xoaDiemTheoMaLD(clsDIEM_DTO diem_DTO)
        {
            SqlCommand command = new SqlCommand("SP_XoaDiemHSTheoMaLD", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MANH", SqlDbType.VarChar, 6).Value = diem_DTO.Manh;
            command.Parameters.Add("@MAHK", SqlDbType.VarChar, 10).Value = diem_DTO.Mahk;
            command.Parameters.Add("@MALD", SqlDbType.VarChar, 15).Value = diem_DTO.Mald;
            command.Parameters.Add("@MAMH", SqlDbType.VarChar, 10).Value = diem_DTO.Mamh;
            command.Parameters.Add("@MAHS", SqlDbType.VarChar, 8).Value = diem_DTO.Mahs;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }
    }
}
