using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
namespace QLHS.DAO
{
    public class connectDatabase
    {
        public SqlConnection moKetNoi() {
            string connectionStr = @"server=.\SQLEXPRESS;Initial Catalog=QuanLiHocSinh1;Integrated Security=True";
            //string data1 = "Server=.;AttachDbFilename=" + data + ";Initial Catalog=libraryManage;Integrated Security=True;User Instance = True";
            // MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            //string data1 = "Server=.;AttachDbFilename=|DataDirectory|" + data2 + ";Integrated Security=True;Connect Timeout=30";
            //string data1 = @"Data Source=.\SQLEXPRESS;AttachDbFilename="+data+@"\Database\libraryManage.mdf;Integrated Security=True;Connect Timeout=30;User Instance = True"; 

            //string data11 = Directory.GetCurrentDirectory() + @"\Database\QuanLyHocSinh1.mdf;";
            //string data1 = @"Data Source=DANGLIENMINH\SQLEXPRESS;AttachDbFilename=" + data11 + "Integrated Security=True;Connect Timeout=30;User Instance = True";

            SqlConnection connection = new SqlConnection(connectionStr);
            return connection;    
        } 
    }
}
