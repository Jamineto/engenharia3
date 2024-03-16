using Microsoft.AspNetCore.Hosting.Server;
using MySql.Data.MySqlClient;

namespace EngenhariaWeb.Util
{
    public class Singleton
    {

        private string connectionString;

        private static Singleton instance;

        public static Singleton getInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }

            return instance;
        }

        public MySqlConnection ConnectionStart()
        {
            return connection("127.0.0.1", "engenharia", "LucasIsquerdo", "Lucas_eg07");
        }

        public MySqlConnection connection(string server, string db, string user, string password)
        {
            connectionString = $"Server={server};Database={db};Uid={user};Pwd={password};";
            return new MySqlConnection(connectionString);
        }
    }
}
