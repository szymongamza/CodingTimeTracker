﻿using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTimeTracker
{
    public class CodingController
    {
        readonly String _connectionString;
        public CodingController()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["TimeDBConnectionString"].ConnectionString;
        }
        public void InsertRecord(string startTime, string endTime)
        {
            using(var connection = new SqliteConnection(_connectionString))
            {
                using(var command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandText = $"INSERT INTO time_stamps(StartDate, EndDate) VALUES(\"{startTime}\",\"{endTime}\")";
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
        public void DeleteRecord(int id)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                using (var command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandText = $"DELETE FROM time_stamps WHERE Id = {id}";
                    int rowAffected = command.ExecuteNonQuery();
                    if (rowAffected == 0)
                    {
                        Console.WriteLine($"There was no record with Id: {id}");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"Id: {id} has been deleted.");
                    }
                }
            }
        }

    }
}
