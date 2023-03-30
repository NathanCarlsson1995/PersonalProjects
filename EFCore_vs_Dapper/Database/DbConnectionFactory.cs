using Microsoft.Data.Sqlite;
using System.Data;
using System.Data.Common;
using System.Data.Entity.Infrastructure;

namespace EFCore_vs_Dapper.Database
{
    public class SqliteConnectionFactory : IDbConnectionFactory
    {
        private readonly string _connectionString;

        public SqliteConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DbConnection CreateConnection(string connectionName)
        {
            var connection = new SqliteConnection(_connectionString);
            connection.Open();
            return connection;
        }

        public async Task<IDbConnection> CreateConnectionAsync()
        {
            var connection = new SqliteConnection(_connectionString);
            await connection.OpenAsync();
            return connection;
        }

    }
}
