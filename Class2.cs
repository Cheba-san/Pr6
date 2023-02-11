using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1
{
    internal class Class2
    {
        public static MySqlConnection GetSqlConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "mydb";
            string user = "root";
            string password = "4444";

            return Class1.GetSqlConnection(host, port, database, user, password);
        }
    }
}
