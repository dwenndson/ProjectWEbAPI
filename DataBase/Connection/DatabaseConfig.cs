using Microsoft.Extensions.Configuration;

namespace projetos.DataBase.Connection.DatabaseConfig
{
    public class DatabaseConfig
    {
        public string Connection { get; }
        public DatabaseConfig(string _connection) => Connection = _connection;
    }
}