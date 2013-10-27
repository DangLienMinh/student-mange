using System;
using System.Collections.Generic;
using System.Text;
using QLHS.DTO;
using System.Data;
using System.Data.SqlClient;
namespace QLHS.DAO
{
    public class clsHOCSINH_DAO
    {
        private clsConnectDatabase connection;
        private SqlConnection con;
        public clsHOCSINH_DAO()
        {
            connection = new clsConnectDatabase();
            con = connection.KetNoi();
        }

        public DataTable danhsachHocSinh(string maNH)
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_ThongTinHocSinh", con);
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = maNH;
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        public void themHocsinh(clsHOCSINH_DTO hocsinh)
        {
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_ThemHocSinh", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = hocsinh.Manh;
            command.Parameters.Add("@MALOP", SqlDbType.VarChar).Value = hocsinh.Malop;
            command.Parameters.Add("@MAHS", SqlDbType.VarChar).Value = hocsinh.Mahs;
            command.Parameters.Add("@TENHS", SqlDbType.NVarChar).Value = hocsinh.Tenhs;
            command.Parameters.Add("@NGSINHHS", SqlDbType.SmallDateTime).Value = hocsinh.Ngaysinhhs;
            command.Parameters.Add("@GIOITINHHS", SqlDbType.Char).Value = hocsinh.Gioitinh;
            command.Parameters.Add("@DIACHIHS", SqlDbType.NVarChar).Value = hocsinh.Diachihs;
            command.Parameters.Add("@DIENTHOAIHS", SqlDbType.VarChar).Value = hocsinh.Dienthoaihs;
            command.Parameters.Add("@NGNHAPHOC", SqlDbType.SmallDateTime).Value = hocsinh.Ngnhaphoc;
            command.Parameters.Add("@HINHANHHS", SqlDbType.VarChar).Value = hocsinh.Hinhanhhs;
            command.Parameters.Add("@DANTOC", SqlDbType.NVarChar).Value = hocsinh.Dantoc;
            command.ExecuteNonQuery();
            con.Close();
        }
        public void suaHocsinh(clsHOCSINH_DTO hocsinh,string maNHTruoc,string maLopTruoc)
        {
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_SuaHocSinh", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MANHTRUOC", SqlDbType.VarChar).Value = maNHTruoc;
            command.Parameters.Add("@MALOPTRUOC", SqlDbType.VarChar).Value = maLopTruoc;
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = hocsinh.Manh;
            command.Parameters.Add("@MALOP", SqlDbType.VarChar).Value = hocsinh.Malop;
            command.Parameters.Add("@MAHS", SqlDbType.VarChar).Value = hocsinh.Mahs;
            command.Parameters.Add("@TENHS", SqlDbType.NVarChar).Value = hocsinh.Tenhs;
            command.Parameters.Add("@NGSINHHS", SqlDbType.SmallDateTime).Value = hocsinh.Ngaysinhhs;
            command.Parameters.Add("@GIOITINHHS", SqlDbType.Char).Value = hocsinh.Gioitinh;
            command.Parameters.Add("@DIACHIHS", SqlDbType.NVarChar).Value = hocsinh.Diachihs;
            command.Parameters.Add("@DIENTHOAIHS", SqlDbType.VarChar).Value = hocsinh.Dienthoaihs;
            command.Parameters.Add("@NGNHAPHOC", SqlDbType.SmallDateTime).Value = hocsinh.Ngnhaphoc;
            command.Parameters.Add("@HINHANHHS", SqlDbType.VarChar).Value = hocsinh.Hinhanhhs;
            command.Parameters.Add("@DANTOC", SqlDbType.NVarChar).Value = hocsinh.Dantoc;
            command.ExecuteNonQuery();
            con.Close();
        }
        public void xoaHocsinh(clsHOCSINH_DTO hocsinh)
        {
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_XoaHocSinh", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAHS", SqlDbType.VarChar).Value = hocsinh.Mahs;
            command.ExecuteNonQuery();
            con.Close();
        }
        public DataTable timHocsinhMahs(clsHOCSINH_DTO hocsinh)
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_TimHocSinhMAHS", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAHS", SqlDbType.VarChar).Value = hocsinh.Mahs;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        public DataTable timHocsinhTenhs(clsHOCSINH_DTO hocsinh)
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_TimHocSinhTENHS", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@TENHS", SqlDbType.VarChar).Value = hocsinh.Tenhs;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }
    }
}
