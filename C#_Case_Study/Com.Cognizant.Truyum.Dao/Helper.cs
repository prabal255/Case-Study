﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace Com.Cognizant.Truyum.Dao
{
    public class Helper
    {
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString;
            }
        }
        public static SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            return con;

        }
        public class FileNotFoundException : System.IO.IOException
        {

        }

    }
}
