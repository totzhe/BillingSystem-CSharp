using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace BillingSystem
{
    public static class ConnectionManager
    {
        private static string connectionString;

        public static void Init(string connectionString)
        {
            ConnectionManager.connectionString = connectionString;
        }

        public static MySqlConnection GetConnection()
        {
            if (connectionString != null)
            {
                MySqlConnection conn = new MySqlConnection(connectionString);
                return conn;
            }
            else
            {
                throw new ArgumentException("Connection cannot be obtained, connection string is null. Please call Init() method first");
            }
        }
    }
}
