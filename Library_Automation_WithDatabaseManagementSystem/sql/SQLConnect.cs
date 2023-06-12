using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Library_Automation_WithDatabaseManagementSystem.sql
{
    public class SQLConnect
    {
        public static NpgsqlConnection connect = new NpgsqlConnection("server=localhost; port=5432;" +
                "Database=LibraryManagementSystem; User Id=postgres; password=by20012006");

        public static void CheckConnection(NpgsqlConnection conn)
        {
            if (conn.State==ConnectionState.Closed)
            {
                conn.Open();
                //MessageBox.Show("bağlandı");
            }
        }
    }
    public class SQLConnectManager
    {
        public static NpgsqlConnection connect = new NpgsqlConnection("server=localhost; port=5432;" +
                "Database=LibraryManagementSystem; User Id=manager; password=12345");

        public static void CheckConnection(NpgsqlConnection conn)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                //MessageBox.Show("bağlandı");
            }
        }
    }

    public class SQLConnectEmploye
    {
        public static NpgsqlConnection connect = new NpgsqlConnection("server=localhost; port=5432;" +
                "Database=LibraryManagementSystem; User Id=employe; password=1234");

        public static void CheckConnection(NpgsqlConnection conn)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                //MessageBox.Show("bağlandı");
            }
        }
    }

}
