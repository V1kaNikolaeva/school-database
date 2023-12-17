using MySql.Data.MySqlClient;

namespace School.db
{
    /// <summary>
    /// Служебный класс для работы с базой данных
    /// </summary>
    public class DBUtils
    {
        private static MySqlConnection connection = null;
        public static string databaseName = "school";
        public static string host = "127.0.0.1";
        public static int port = 3306;
        public static string userName = "root";
        public static string userPassword = "root";
        /// <summary>
        /// Статический метод для подключения к базе данных
        /// </summary>
        /// <returns>Объект подключения к базе данных класса SqlConnection</returns>
        public static MySqlConnection GetDBConnection()
        {
            if (connection == null)
            {
                connection = new MySqlConnection(
                    $"Server={host};Database={databaseName};port={port};User Id={userName};password={userPassword}"
                );
                connection.Open();
            }

            return connection;

        }
    }
}
