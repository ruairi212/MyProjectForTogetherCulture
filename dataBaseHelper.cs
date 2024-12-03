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
        public bool InsertLogindetailsAndNonmember(string firstName, string lastName, string email, string password, string securityQuestion, string securityAnswer, string DOB, out string errorMessage)

        {


            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Connected to the database successfully! Inserting data into logindetails and nonmember...");

                    // Insert into logindetails table 
                    string queryLogindetails = "INSERT INTO logindetails (Email, Password, Security_questions, Security_questions_answers) VALUES (@Email, @Password, @Security_questions, @Security_questions_answers)";
                    using (MySqlCommand command = new MySqlCommand(queryLogindetails, connection))
                    {
                        // Set LoginID 
                        
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Security_questions", securityQuestion);
                        command.Parameters.AddWithValue("@Security_questions_answers", securityAnswer);
                        command.ExecuteNonQuery();
                    }

                    // Format the DOB before adding it as a parameter
                  //  string formattedDOB = DateTime.Parse(DOB).ToV("yyyy-MM-dd");


                    // Insert into nonmember table
                    string queryNonmember = "INSERT INTO nonmember (Email, FirstName, LastName, DOB) VALUES (@Email, @FirstName, @LastName, @DOB)";
                    using (MySqlCommand command = new MySqlCommand(queryNonmember, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@DOB", DOB);
                     
                       command.ExecuteNonQuery();
                    }
                }

                errorMessage = null;
                return true;
            }
            catch (MySqlException ex) when (ex.Number == 1062) // Duplicate entry error
            {
                errorMessage = "A record with the same primary key already exists.";
                Console.WriteLine($"Error inserting data: {errorMessage}");
                return false;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                Console.WriteLine($"Error inserting data into logindetails and nonmember: {ex.Message}");
                return false;
            }
        }
    }
}
