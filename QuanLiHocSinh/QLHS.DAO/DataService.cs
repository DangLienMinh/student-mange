using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace QLHS.DAO
{
    public partial class DataService : DataTable
    {
        #region Fields
        private static SqlConnection m_Connection;
        public static String m_ConnectString = "";
        #endregion

        #region Constructor
        public DataService()
        {

        }
        #endregion

        #region Hàm lấy lệnh connection
        public static void ConnectionString()
        {
            //đọc file 
            XmlDocument xmlDoc = XML.XMLReader("ConnectString.con");
            XmlElement xmlEle = xmlDoc.DocumentElement;

            try
            {
                //nếu với quyền windows
                if (xmlEle.SelectSingleNode("costatus").InnerText == "true")
                {
                    m_ConnectString = "Data Source=" + xmlEle.SelectSingleNode("servname").InnerText + ";Initial Catalog=" + xmlEle.SelectSingleNode("database").InnerText + ";Integrated Security=True;";
                    SaveConnectionString("con", m_ConnectString);
                }
                    //ngược lại là quyền sql server
                else
                {
                    m_ConnectString = "Data Source=" + xmlEle.SelectSingleNode("servname").InnerText + ";Initial Catalog=" + xmlEle.SelectSingleNode("database").InnerText + ";User Id=" + xmlEle.SelectSingleNode("username").InnerText + ";Password=" + xmlEle.SelectSingleNode("password").InnerText + ";";
                    SaveConnectionString("con", m_ConnectString);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối đến cơ sở dữ liệu! Xin vui lòng thiết lập lại kết nối...", "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        #endregion

        //kiểm tra connectionSstring
        #region OpenConnection
        public static bool OpenConnection()
        {
            if (m_ConnectString == "")
                ConnectionString();
            try
            {
                if (m_Connection == null)
                    m_Connection = new SqlConnection(m_ConnectString);
                if (m_Connection.State == ConnectionState.Closed)
                    m_Connection.Open();
                return true;
            }
            catch
            {
                m_Connection.Close();
                return false;
            }
        }
        #endregion

        //Lưu vào file config
        private static void SaveConnectionString(string connectionName, string newValue)
        {
            // lấy thông tin file config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //lấy thông tin config với tên là con
            ConnectionStringSettings csSetting = config.ConnectionStrings.ConnectionStrings[connectionName];
            if (csSetting == null & !connectionName.Contains(".Properties.Settings."))
            {
                //bắt đầu ghi vào file
                string settingName = ".Properties.Settings." + connectionName;
                foreach (ConnectionStringSettings cs in config.ConnectionStrings.ConnectionStrings)
                {
                    if (cs.Name.EndsWith(settingName, System.StringComparison.CurrentCultureIgnoreCase))
                    {
                        csSetting = cs;
                        connectionName = cs.Name;
                        break;
                    }
                }
            }
            if (csSetting != null)
            {
                csSetting.ConnectionString = newValue;
            }
            else
            {
                string provideName = "System.Data.SqlClient";
                csSetting = new ConnectionStringSettings(connectionName, newValue, provideName);
                config.ConnectionStrings.ConnectionStrings.Add(csSetting);
            }
            // lưu thông tin file config
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(connectionName );
        }
    }

}
