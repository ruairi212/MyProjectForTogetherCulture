using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace member_space
{
    internal class dataBaseHelper
    {
        // Connection string to the database
        public string connectionString = "Server=127.0.0.1;Database=software;Uid=root;Pwd=;";

        // Method to fetch and display all rows from a specific table
        public void QueryTable(string tableName)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine($"Connected to the database successfully! Fetching data from {tableName}");

                    string query = $"SELECT * FROM {tableName}";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    Console.Write($"{reader.GetName(i)}: {reader.GetValue(i)}  ");
                                }
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching data from table {tableName}: {ex.Message}");
            }
        }

        // Method to fetch all table names from the database
        public List<string> GetAllTableNames()
        {
            List<string> tableNames = new List<string>();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Fetching all table names...");

                    string query = "SHOW TABLES";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tableNames.Add(reader.GetString(0)); // First column contains table names
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching table names: {ex.Message}");
            }

            return tableNames;
        }

        // Method to fetch all data from all tables
        public void QueryAllTables()
        {
            try
            {
                // Get all table names
                List<string> tableNames = GetAllTableNames();

                // Query data from each table
                foreach (string tableName in tableNames)
                {
                    Console.WriteLine($"\n--- Data from table: {tableName} ---");
                    QueryTable(tableName);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error querying all tables: {ex.Message}");
            }
        }
    }
}
