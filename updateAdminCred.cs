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
    public partial class updateAdminCred : Form
    {
        private string connectionString = "Server=localhost;Database=together_culture;User ID=root;Password=;SslMode=none;";

        public updateAdminCred()
        {
            InitializeComponent();
        }

        // Update the admin password only
        private void updateButton_Click(object sender, EventArgs e)
        {
            // Check if Email or Password field is empty
            if (string.IsNullOrEmpty(textBoxEmail.Text) || string.IsNullOrEmpty(textBoxPass.Text))
            {
                MessageBox.Show("Email and Password fields cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE logindetails SET Password = @Password WHERE Email = @Email";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Password", textBoxPass.Text);
                    cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password updated successfully!");
                        AdminDashboard adminDashboard = new AdminDashboard(textBoxEmail.Text);
                        adminDashboard.Show();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Error: No user found with the specified email.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating the password: " + ex.Message);
                }
                finally
                {
                  
                    conn.Close();
                }
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            // Any additional functionality on email change (if required)
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            // Any additional functionality on password change (if required)
        }
    }
}
