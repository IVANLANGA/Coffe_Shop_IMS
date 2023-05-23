using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeetleCaf
{
    public class DatabaseConnector
    {
        public static SqlConnection OpenConnection()
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter;
            SqlDataReader reader;
            DataSet dataset;

            string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database.mdf;Integrated Security=True";

            connection = new SqlConnection(conn);
            connection.Open();
            return connection;
        }
    }
}
