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

         public DataTable HSGTheoHocKy(clsHANHKIEM_DTO hanhKiem_DTO)
        {
            connection.kiemTraKetNoi(con);
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SP_HSG", con);
            command.Parameters.Add("@MANH", SqlDbType.VarChar, 6).Value = hanhKiem_DTO.Manh;
            command.Parameters.Add("@MAHK", SqlDbType.VarChar, 10).Value = hanhKiem_DTO.Mahk;
            command.Parameters.Add("@MALOP", SqlDbType.VarChar, 15).Value = hanhKiem_DTO.Malop;
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }
    }
}
