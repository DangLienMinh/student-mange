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
        public clsDIEM_DAO()
        {
            connection = new clsConnectDatabase();
            con = connection.KetNoi();
        }

        public int demDiem(clsDIEM_DTO diem_DTO)
        {
            connection.kiemTraKetNoi(con);
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

        public void themDiemTheoHS(clsDIEM_DTO diem_DTO)
        {
            SqlCommand command = new SqlCommand("SP_ThemDiemTheoHS", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MANH", SqlDbType.VarChar, 6).Value = diem_DTO.Manh;
            command.Parameters.Add("@MAHK", SqlDbType.VarChar, 10).Value = diem_DTO.Mahk;
            command.Parameters.Add("@MALD", SqlDbType.VarChar, 15).Value = diem_DTO.Mald;
            command.Parameters.Add("@MAMH", SqlDbType.VarChar, 10).Value = diem_DTO.Mamh;
            command.Parameters.Add("@MAHS", SqlDbType.VarChar, 8).Value = diem_DTO.Mahs;
            command.Parameters.Add("@DIEMSO", SqlDbType.Char, 2).Value = diem_DTO.Diemso;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();   
            con.Close();
        }

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

        public void suaDiemTheoHS(clsDIEM_DTO diem_DTO)
        {
            SqlCommand command = new SqlCommand("SP_SuaDiemTheoHS", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@STT", SqlDbType.Int).Value = diem_DTO.Stt;
            command.Parameters.Add("@DIEMSO", SqlDbType.Char, 2).Value = diem_DTO.Diemso;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }

        public void xoaDiemTheoHS(clsDIEM_DTO diem_DTO)
        {
            SqlCommand command = new SqlCommand("SP_XoaDiemTheoHS", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@STT", SqlDbType.Int).Value = diem_DTO.Stt;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }
    }
}
