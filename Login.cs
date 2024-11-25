using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace member_space
{
   

    public partial class Login : Form
    {
        public string connectionString = "Server=127.0.0.1;Database=software;Uid=root;Pwd=;";
        public Login()
        {
            InitializeComponent();

        }

      

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbLogUsername.Text) || string.IsNullOrEmpty(txtbLogPassword.Text))
            {
                MessageBox.Show("Username and Password fields cannot be empty", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Initialize the database helper
                dataBaseHelper dbHelper = new dataBaseHelper();
                dbHelper.QueryTable("logindetails");

                // SQL Query to check the username and password
                string query = "SELECT * FROM logindetails WHERE Email = @Email AND Password = @Password";

                using (MySqlConnection connection = new MySqlConnection(dbHelper.connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@Email", txtbLogUsername.Text);
                        command.Parameters.AddWithValue("@Password", txtbLogPassword.Text);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // If a match is found, proceed with login
                                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Open the appropriate form for the user
                                new Form1().Show();
                                this.Hide();
                            }
                            else
                            {
                                // If no match is found, show an error message
                                MessageBox.Show("Invalid Username or Password. Please Try Again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                // Clear the input fields
                                txtbLogUsername.Text = "";
                                txtbLogPassword.Text = "";
                                txtbLogUsername.Focus();
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        private void CHbxLogShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (CHbxLogShowPass.Checked)
            {
                txtbLogPassword.PasswordChar = '\0';
                
            }
            else
            {
                txtbLogPassword.PasswordChar = '*';
               

            }
        }

        private void LcreateAccount_Click(object sender, EventArgs e)
        {
            new signUp().Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtbLogUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonForgetPass_Click(object sender, EventArgs e)
        {
          new  ForgetPassword().Show();
        }
    }
}
