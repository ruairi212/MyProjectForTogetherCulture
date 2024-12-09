using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using MySql.Data.MySqlClient;

namespace member_space
{
    internal class dataBaseHelper
    {
        // Connection string to the database
        public string connectionString = "Server=127.0.0.1;Database=together_culture;Uid=root;Pwd=;";

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

        // Method to insert data into logindetails and nonmember tables
        public bool InsertLogindetailsAndNonmember(string firstName, string lastName, string email, string password, string securityQuestion, string securityAnswer, string DOB, string interests, string intentions, out string errorMessage)
        {
            try
            {
                // First, check if the email already exists in the logindetails or nonmember table
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string checkEmailQuery = "SELECT COUNT(*) FROM logindetails WHERE Email = @Email";
                    using (MySqlCommand cmd = new MySqlCommand(checkEmailQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        long emailCount = (long)cmd.ExecuteScalar();

                        if (emailCount > 0)
                        {
                            errorMessage = "A record with the same email already exists.";
                            return false; // Stop execution if email exists
                        }
                    }

                    // Proceed with the insertion if email does not exist
                    string queryLogindetails = "INSERT INTO logindetails (Email, Password, Security_questions, Security_questions_answers) VALUES (@Email, @Password, @Security_questions, @Security_questions_answers)";
                    using (MySqlCommand command = new MySqlCommand(queryLogindetails, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Security_questions", securityQuestion);
                        command.Parameters.AddWithValue("@Security_questions_answers", securityAnswer);
                        command.ExecuteNonQuery();
                    }

                    // Insert into nonmember table with Interests and Intentions
                    string queryNonmember = "INSERT INTO nonmember (Email, FirstName, LastName, DOB, Interests, Intentions) VALUES (@Email, @FirstName, @LastName, @DOB, @Interests, @Intentions)";
                    using (MySqlCommand command = new MySqlCommand(queryNonmember, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@DOB", DOB);
                        command.Parameters.AddWithValue("@Interests", interests);
                        command.Parameters.AddWithValue("@Intentions", intentions);
                        command.ExecuteNonQuery();
                    }
                }

                errorMessage = null;
                return true;
            }
            catch (MySqlException ex)
            {
                errorMessage = "Database error: " + ex.Message;
                Console.WriteLine($"Error inserting data: {errorMessage}");
                return false;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return false;
            }
        }
    }
}
