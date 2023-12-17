using MySql.Data.MySqlClient;

namespace School.db
{
    public class DBUtils
    {
        private static MySqlConnection connection = null;
        public static string databaseName = "school";
        public static string host = "127.0.0.1";
        public static int port = 3306;
        public static string userName = "root";
        public static string userPassword = "root";
        public static MySqlConnection GetDBConnection()
        {
            if (connection == null)
            {
                connection = new MySqlConnection(
                    $"Server={host};" +
                    $"Database={databaseName};" +
                    $"port={port};" +
                    $"User Id={userName};" +
                    $"password={userPassword}"
                );
                connection.Open();
            }

            return connection;

        }
    }
}
