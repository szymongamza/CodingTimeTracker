using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTimeTracker
{
    public class DBManager
    {
        readonly String _connectionString;
        public DBManager()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["TimeDBConnectionString"].ConnectionString;
            CreateTableIfNoExist();
        }
        public void CreateTableIfNoExist()
        {
            using(var connection = new SqliteConnection(_connectionString))
            {
                using(var command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandText = 
                        @"CREATE TABLE IF NOT EXISTS time_stamps (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        StartDate DATE,
                        EndDate DATE
                        )";
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SqliteException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

            }
        }
    }
}
