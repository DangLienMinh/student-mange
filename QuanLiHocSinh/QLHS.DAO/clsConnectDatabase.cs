using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
namespace QLHS.DAO
{
    public class clsConnectDatabase
    {
        public SqlConnection KetNoi() {
                string connectionStr = @"server=.\SQLEXPRESS;Initial Catalog=QuanLyHocSinh1;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionStr);
                return connection;
        }
        public void kiemTraKetNoi(SqlConnection con)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
    }
}
