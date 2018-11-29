using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WcfService.Database
{
    public class DatabaseManager
    {
        public static SqlConnection getConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["EKE-DB"].ConnectionString;
            return conn;
        }
    }
}