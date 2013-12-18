using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLHS.DTO;

namespace QLHS.DAO
{
    public class clsBAOCAO_DAO
    {
        private SqlConnection con;
        private clsConnectDatabase connection;

        public clsBAOCAO_DAO()
        {
            connection = new clsConnectDatabase();
            con = connection.KetNoi();
        }

         public DataTable HSGTheoHocKy(clsBAOCAO_DTO baoCao_DTO)
        {
            connection.kiemTraKetNoi(con);
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SP_HSG", con);
            command.Parameters.Add("@MANH", SqlDbType.VarChar, 6).Value = baoCao_DTO.Manh;
            command.Parameters.Add("@MAHK", SqlDbType.VarChar, 10).Value = baoCao_DTO.Mahk;
            command.Parameters.Add("@MALOP", SqlDbType.VarChar, 15).Value = baoCao_DTO.Malop;
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

         public DataTable HSLuuBanTheoHK(clsBAOCAO_DTO baoCao_DTO)
         {
             connection.kiemTraKetNoi(con);
             DataTable table = new DataTable();
             SqlCommand command = new SqlCommand("SP_LuuBan", con);
             command.Parameters.Add("@MANH", SqlDbType.VarChar, 6).Value = baoCao_DTO.Manh;
             command.Parameters.Add("@MAHK", SqlDbType.VarChar, 10).Value = baoCao_DTO.Mahk;
             command.Parameters.Add("@MAKHOI", SqlDbType.VarChar, 15).Value = baoCao_DTO.Makhoi;
             command.CommandType = CommandType.StoredProcedure;
             SqlDataAdapter adapter = new SqlDataAdapter(command);
             adapter.Fill(table);
             con.Close();
             return table;
         }
         public DataSet BangDiemHocSinh(string manh, string malop, string mahs)
         {
             connection.kiemTraKetNoi(con);
             DataSet bangdiem = new DataSet();
             SqlCommand command = new SqlCommand("SP_BANGDIEMHOCSINH", con);
             command.Parameters.Add("@MANH", SqlDbType.VarChar, 6).Value = manh;
             command.Parameters.Add("@MALOP", SqlDbType.VarChar, 10).Value = malop;
             command.Parameters.Add("@MAHS", SqlDbType.VarChar, 15).Value = mahs;
             command.CommandType = CommandType.StoredProcedure;
             SqlDataAdapter adapter = new SqlDataAdapter(command);
             adapter.Fill(bangdiem,"BangDiemHocSinh");
             con.Close();
             return bangdiem;
         }

         public DataTable DiemTheoMonHoc(clsBAOCAO_DTO baoCao_DTO)
         {
             connection.kiemTraKetNoi(con);
             DataTable table = new DataTable();
             SqlCommand command = new SqlCommand("SP_DIEMTHEOMONHOC", con);
             command.Parameters.Add("@MANH", SqlDbType.VarChar, 6).Value = baoCao_DTO.Manh;
             command.Parameters.Add("@MAHK", SqlDbType.VarChar, 10).Value = baoCao_DTO.Mahk;
             command.Parameters.Add("@MALOP", SqlDbType.VarChar, 15).Value = baoCao_DTO.Malop;
             command.Parameters.Add("@MAMH", SqlDbType.VarChar, 10).Value = baoCao_DTO.Mamh;
             command.CommandType = CommandType.StoredProcedure;
             SqlDataAdapter adapter = new SqlDataAdapter(command);
             adapter.Fill(table);
             con.Close();
             return table;
         }
    }
}
