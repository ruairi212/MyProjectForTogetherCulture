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
    public partial class AdminDashboard : Form
    {
        private DatabaseConnection dbConnection = new DatabaseConnection(); // Instantiate the DatabaseConnection class
        private dataBaseHelper dbHelper = new dataBaseHelper(); // Instantiate the dataBaseHelper class
        private string email;

        public AdminDashboard(string email)
        {
            InitializeComponent();
            LoadFeedback();
            this.email= email;
        }
        private void LoadFeedback()
        {
            // Create a list to hold the feedback items
            List<Feedback> feedbackList = new List<Feedback>();

            // SQL query to fetch all feedback records from the database
            string query = "SELECT Type, Message FROM feedback";

            try
            {
                // Use the connection from DatabaseConnection class
                using (MySqlConnection conn = dbConnection.get_Connection())
                {
                    conn.Open(); // Open the connection
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Execute the query and retrieve the data
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Create a new Feedback object for each record
                                Feedback feedback = new Feedback
                                {
                                    Type = reader.GetString("Type"),
                                    Message = reader.GetString("Message")
                                };

                                // Add the feedback to the list
                                feedbackList.Add(feedback);
                            }
                        }
                    }
                }

                // Clear existing items in the ListBox before adding new feedback items
                listBoxFeedback.Items.Clear();

                // Add each feedback item to the ListBox
                foreach (var feedback in feedbackList)
                {
                    listBoxFeedback.Items.Add(feedback);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading feedback: " + ex.Message);
            }
        }

        public class Feedback
        {
            public string Type { get; set; }
            public string Message { get; set; }

            // Override ToString to format the output in the ListBox
            public override string ToString()
            {
                return $"{Type}: {Message}";
            }
        }



        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Eventavtivity eventavtivity = new Eventavtivity();  
            eventavtivity.ShowDialog();
        }

        private void buttonStafflist_Click(object sender, EventArgs e)
        {
            new staffList().Show();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updateCredButton_Click(object sender, EventArgs e)
        {
            new updateAdminCred().Show();
            this.Hide();
        }
    }
}
