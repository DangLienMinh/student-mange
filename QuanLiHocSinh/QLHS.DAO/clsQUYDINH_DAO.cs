using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using QLHS.DTO;

using System.Text;

namespace QLHS.DAO
{
    public class clsQUYDINH_DAO
    {
        private clsConnectDatabase connection;
        private SqlConnection con;

        public clsQUYDINH_DAO()
        {
            connection = new clsConnectDatabase();
            con = connection.KetNoi();
        }

        //thông tin quy định SP_ThongTinQuyDinh
        public DataTable thongTinQuyDinh()
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SP_ThongTinQuyDinh", con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.kiemTraKetNoi(con);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        //sửa thông tin trường học trong bảng quy định SP_SuaTruongHoc
        public void suaTruongHoc(clsQUYDINH_DTO quyDinh_DTO)
        {
            SqlCommand command = new SqlCommand("SP_SuaTruongHoc", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@TENTRUONG", SqlDbType.NVarChar).Value = quyDinh_DTO.TenTruong;
            command.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = quyDinh_DTO.DiaChi;
            command.Parameters.Add("@DIENTHOAI", SqlDbType.NVarChar).Value = quyDinh_DTO.DienThoai;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }

        //sửa thông tin sỉ số tối thiểu hoặc tối đa trong bảng quy định SP_SuaSiSo
        public void suaSiSo(clsQUYDINH_DTO quyDinh_DTO)
        {
            SqlCommand command = new SqlCommand("SP_SuaSiSo", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@SISOTT", SqlDbType.NVarChar).Value = quyDinh_DTO.SiSoTT;
            command.Parameters.Add("@SISOTD", SqlDbType.NVarChar).Value = quyDinh_DTO.SiSoTD;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }

        //sửa thông tin tuổi tối thiểu, tuổi tối đa trong bảng quy định SP_SuaTuoi
        public void suaTuoi(clsQUYDINH_DTO quyDinh_DTO)
        {
            SqlCommand command = new SqlCommand("SP_SuaTuoi", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@TUOITT", SqlDbType.NVarChar).Value = quyDinh_DTO.TuoiTT;
            command.Parameters.Add("@TUOITD", SqlDbType.NVarChar).Value = quyDinh_DTO.TuoiTD;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }
    }
}
