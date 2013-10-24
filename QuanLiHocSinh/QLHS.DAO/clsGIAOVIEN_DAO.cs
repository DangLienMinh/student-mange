using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using QLHS.DTO;

namespace QLHS.DAO
{
    public class clsGIAOVIEN_DAO
    {
        private clsConnectDatabase connection;
        private SqlConnection con;

        public clsGIAOVIEN_DAO()
        {
            connection = new clsConnectDatabase();
            con = connection.KetNoi();
        }

        public DataTable danhSachGiaoVien()
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SP_ThongTinGiaoVien", con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.kiemTraKetNoi(con);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        public int soGiaoVien()
        {
            int temp = -1;
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SP_ThongTinSoGiaoVien", con);
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

        public DataTable timGVMaGV(clsGIAOVIEN_DTO giaovien)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SP_TimGiaoVienMaGV", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAGV", SqlDbType.Char).Value = giaovien.Magv;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.kiemTraKetNoi(con);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        public DataTable timGVTenGV(clsGIAOVIEN_DTO giaovien)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SP_TimGiaoVienTenGV", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@TENGV", SqlDbType.NVarChar).Value = giaovien.Tengv;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.kiemTraKetNoi(con);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        public void themGiaoVien(clsGIAOVIEN_DTO giaovien)
        {
            SqlCommand command = new SqlCommand("SP_ThemGiaoVien", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAGV", SqlDbType.Char).Value = giaovien.Magv;
            command.Parameters.Add("@TENGV", SqlDbType.NVarChar).Value = giaovien.Tengv;
            command.Parameters.Add("@NGSINHGV", SqlDbType.SmallDateTime).Value = giaovien.Ngsinhgv;
            command.Parameters.Add("@GIOITINHGV", SqlDbType.Char).Value = giaovien.Gioitinhgv;
            command.Parameters.Add("@DIACHIGV", SqlDbType.NVarChar).Value = giaovien.Diachigv;
            command.Parameters.Add("@DIENTHOAIGV", SqlDbType.NVarChar).Value = giaovien.Dienthoaigv;
            command.Parameters.Add("@HINHANHGV", SqlDbType.NVarChar).Value = giaovien.Hinhanhgv;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }

        public void suaGiaoVien(clsGIAOVIEN_DTO giaovien)
        {
            SqlCommand command = new SqlCommand("SP_SuaGiaoVien", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAGV", SqlDbType.Char).Value = giaovien.Magv;
            command.Parameters.Add("@TENGV", SqlDbType.NVarChar).Value = giaovien.Tengv;
            command.Parameters.Add("@NGSINHGV", SqlDbType.SmallDateTime).Value = giaovien.Ngsinhgv;
            command.Parameters.Add("@GIOITINHGV", SqlDbType.Char).Value = giaovien.Gioitinhgv;
            command.Parameters.Add("@DIACHIGV", SqlDbType.NVarChar).Value = giaovien.Diachigv;
            command.Parameters.Add("@DIENTHOAIGV", SqlDbType.NVarChar).Value = giaovien.Dienthoaigv;
            command.Parameters.Add("@HINHANHGV", SqlDbType.NVarChar).Value = giaovien.Hinhanhgv;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }

        public void xoaGiaoVien(clsGIAOVIEN_DTO giaovien)
        {
            SqlCommand command = new SqlCommand("SP_XoaGiaoVien", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAGV", SqlDbType.Char).Value = giaovien.Magv;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }


    }
}
