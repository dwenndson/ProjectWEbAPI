using Microsoft.Extensions.Configuration;

namespace projetos.DataBase.Connection.DatabaseConfig
{
    public class DatabaseConfig
    {
        private string _connectionString;
        protected string ConnectionString => _connectionString;
        public DatabaseConfig(IConfiguration configuration)
        {
            _connectionString = configuration.GetValue<string>("ConnectionString:DatabaseName");
        }
    }
}