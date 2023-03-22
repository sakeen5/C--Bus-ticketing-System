using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    class Database
    {
        private static string serverName = @"DESKTOP-M2DIHE0";
        private static string databaseName = @"FinalProject";
        private static string connectionString = String.Format(@"Server={0};Database={1};Integrated Security=true;", serverName, databaseName);

        private static SqlConnection connection = new SqlConnection(connectionString);
        public static SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
