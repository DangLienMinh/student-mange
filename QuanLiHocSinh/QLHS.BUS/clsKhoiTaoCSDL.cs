using System;
using System.Collections.Generic;
using QLHS.DTO;
using QLHS.DAO;
using System.Text;
using System.Xml;

namespace QLHS.BUS
{
    public class clsKhoiTaoCSDL
    {
        private clsConnectDatabase connectDatabase;

        public clsKhoiTaoCSDL()
        {
            connectDatabase = new clsConnectDatabase();
        }

        public string layKetNoi()
        {
            return connectDatabase.layKetNoi();
        }

        public static void ConnectionString()
        {
            DataService.ConnectionString();
        }

        public static bool OpenConnection()
        {
            return DataService.OpenConnection();
        }

        public static XmlDocument XMLReader(String filename)
        {
           return  XML.XMLReader(filename);
        }

        public static void XMLWriter(String filename, String servname, String database, String costatus)
        {
            XML.XMLWriter(filename, servname, database, costatus);
        }

        public static void XMLWriter(String filename, String servname, String username, String password, String database, String costatus)
        {
            XML.XMLWriter(filename, servname,username, password,database, costatus);
        }

    }
}
