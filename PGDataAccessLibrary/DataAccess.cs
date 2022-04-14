using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGDataAccessLibrary
{
    public class DataAccess
    {
        public List<T> LoadData<T, U>(string sql, U parameters, string connectionString)
        {
            using var conn = new NpgsqlConnection(connectionString);
            return conn.Query<T>(sql, parameters).ToList();
        }
        public void SaveData<T>(string sql, T parameters, string connectionString)
        {
            using var conn = new NpgsqlConnection(connectionString);
            conn.Execute(sql, parameters);
        }
    }
}
