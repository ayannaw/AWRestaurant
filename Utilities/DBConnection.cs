using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

namespace AWRestaurant.Utilities
{
    public class DBConnection   //class to connect to the database and perform insert, update, delete
    {
        private string DBConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        private SqlConnection sqlConnection;

        public DBConnection()
        {
            sqlConnection = new SqlConnection(DBConnectionString);
        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}