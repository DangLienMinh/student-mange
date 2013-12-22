using System;
using System.Collections.Generic;
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

        //danh sách giáo viên
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

        //lấy thông tin dòng mới nhất thuộc mã giáo viên để tạo mã ví dụ GV001 sẽ lấy 001 
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

        //tìm giáo viên theo mã giáo viên
        public DataTable timGVMaGV(clsGIAOVIEN_DTO giaoVien_DTO)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SP_TimGiaoVienMaGV", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAGV", SqlDbType.Char).Value = giaoVien_DTO.Magv;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.kiemTraKetNoi(con);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        //tìm giáo viên theo tên giáo viên
        public DataTable timGVTenGV(clsGIAOVIEN_DTO giaoVien_DTO)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SP_TimGiaoVienTenGV", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@TENGV", SqlDbType.NVarChar).Value = giaoVien_DTO.Tengv;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.kiemTraKetNoi(con);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        //thêm một giáo viên mới
        public void themGiaoVien(clsGIAOVIEN_DTO giaoVien_DTO)
        {
            SqlCommand command = new SqlCommand("SP_ThemGiaoVien", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAGV", SqlDbType.Char).Value = giaoVien_DTO.Magv;
            command.Parameters.Add("@TENGV", SqlDbType.NVarChar).Value = giaoVien_DTO.Tengv;
            command.Parameters.Add("@NGSINHGV", SqlDbType.SmallDateTime).Value = giaoVien_DTO.Ngsinhgv.ToString("yyyy-MM-dd");
            command.Parameters.Add("@GIOITINHGV", SqlDbType.Char).Value = giaoVien_DTO.Gioitinhgv;
            command.Parameters.Add("@DIACHIGV", SqlDbType.NVarChar).Value = giaoVien_DTO.Diachigv;
            command.Parameters.Add("@DIENTHOAIGV", SqlDbType.NVarChar).Value = giaoVien_DTO.Dienthoaigv;
            command.Parameters.Add("@HINHANHGV", SqlDbType.NVarChar).Value = giaoVien_DTO.Hinhanhgv;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }

        //sửa một giáo viên
        public void suaGiaoVien(clsGIAOVIEN_DTO giaoVien_DTO)
        {
            SqlCommand command = new SqlCommand("SP_SuaGiaoVien", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAGV", SqlDbType.Char).Value = giaoVien_DTO.Magv;
            command.Parameters.Add("@TENGV", SqlDbType.NVarChar).Value = giaoVien_DTO.Tengv;
            command.Parameters.Add("@NGSINHGV", SqlDbType.SmallDateTime).Value = giaoVien_DTO.Ngsinhgv.ToString("yyyy-MM-dd");
            command.Parameters.Add("@GIOITINHGV", SqlDbType.Char).Value = giaoVien_DTO.Gioitinhgv;
            command.Parameters.Add("@DIACHIGV", SqlDbType.NVarChar).Value = giaoVien_DTO.Diachigv;
            command.Parameters.Add("@DIENTHOAIGV", SqlDbType.NVarChar).Value = giaoVien_DTO.Dienthoaigv;
            command.Parameters.Add("@HINHANHGV", SqlDbType.NVarChar).Value = giaoVien_DTO.Hinhanhgv;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }

        //xóa một giáo viên
        public void xoaGiaoVien(clsGIAOVIEN_DTO giaoVien_DTO)
        {
            SqlCommand command = new SqlCommand("SP_XoaGiaoVien", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAGV", SqlDbType.Char).Value = giaoVien_DTO.Magv;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }
    }
}
