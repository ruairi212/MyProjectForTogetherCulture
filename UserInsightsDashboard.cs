using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace member_space
{
    public partial class UserInsightsDashboard : Form

    {
        //Testing the connection to DB
        public static void DbConnectionTest()

        {
            //Establishing connection to the MySql Server
            string connectionString = "Server=127.0.0.1;Database=together_culture;Uid=root;Pwd=;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MessageBox.Show("Connected to MySQL!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
       
        public UserInsightsDashboard()
        {
            InitializeComponent();
            DbConnectionTest();
            
        }

        private static void FillingData(UserInsightsDashboard form) 
        {
            try 
            {
                string connectionString = "Server=127.0.0.1;Database=together_culture;Uid=root;Pwd=;";
                using (MySqlConnection connection = new MySqlConnection(connectionString)) 
                {
                    connection.Open();
                    string query = "SELECT Event_Name FROM events WHERE Event_Name = 'Yoga'";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection)) 
                    {
                        
                        using (MySqlDataReader reader = cmd.ExecuteReader()) 
                        {
                            if (reader.Read()) 
                            {
                                form.label3.Text = reader.GetString("Event_Name");
                            }
                            else 
                            {
                                form.label3.Text = "No event found with that name";
                            }
                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        
        private void UserInsightsDashboard_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
