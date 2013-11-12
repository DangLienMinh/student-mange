using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLHS.DTO;
namespace QLHS.DAO
{

    public class clsHOCKY_DAO
    {
        private SqlConnection con;
        private clsConnectDatabase connection;
        public clsHOCKY_DAO()
        {
            connection = new clsConnectDatabase();
            con = connection.KetNoi();
        }
        public DataTable danhSachHocKy()
        {
            connection.kiemTraKetNoi(con);
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SP_ThongTinHocKy", con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }
    }
}


//CREATE PROC SP_ThongTinHocKy
//AS
//BEGIN
//SELECT distinct MAHK,TENHK FROM HOCKY
//END
//GO

//CREATE PROC SP_ThemNamHoc
//@MANH VARCHAR(6),@TENNH NVARCHAR(30)
//AS
//BEGIN
//INSERT INTO NAMHOC VALUES(@MANH,@TENNH)
//INSERT INTO HOCKY VALUES(@MANH,'HK1','Học kỳ 1')
//INSERT INTO HOCKY VALUES(@MANH,'HK2','Học kỳ 2')
//END
//GO