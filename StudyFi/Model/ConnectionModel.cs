using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MySql.Data.MySqlClient;

namespace StudyFi.Model
{
    public class ConnectionModel
    {
        public static MySqlConnection getConnection()
        {
            string strConn = "server=localhost;user=root;database=studynow;port=3306;password=";
            return new MySqlConnection(strConn);
        }
    }
}