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
using static System.Net.WebRequestMethods;

namespace member_space
{
    public partial class signUp : Form
    {
        // Define the connection string for your database
       // private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=your_database_path.accdb"; 
       // Adjust the path accordingly



        public signUp()
        {
            InitializeComponent();

        }
        //database linking code

        private void signUp_Load(object sender, EventArgs e)
        {

        }

        private void Lpassword_Click(object sender, EventArgs e)
        {

        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbUsername.Text) || string.IsNullOrEmpty(txtbPassword.Text) || string.IsNullOrEmpty(txtbConfirmpass.Text))

            {
                MessageBox.Show("Username and Password field  are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else if (txtbPassword.Text == txtbConfirmpass.Text)
            {

               /* try
                {
                    using (OleDbConnection con = new OleDbConnection(connectionString))
                    {
                        con.Open();

                        string register = "INSERT INTO tbl_user (username, password) VALUES (@username, @password)";
                        using (OleDbCommand cmd = new OleDbCommand(register, con))
                        {
                            cmd.Parameters.AddWithValue("@username", txtbUsername.Text);
                            cmd.Parameters.AddWithValue("@password", txtbPassword.Text);

                            cmd.ExecuteNonQuery();
                        }
                    }
               */



                    txtbUsername.Text = "";
                txtbPassword.Text = "";
                txtbConfirmpass.Text = "";

                


                MessageBox.Show("Your account has been Successfullu created", "Registration Success", MessageBoxButtons.OK);
               // catch (Exception ex)
               // {
               //     MessageBox.Show("An error occurred: " + ex.Message, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
               // }


            }


            else
            {
                MessageBox.Show("Passwords does not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbPassword.Text = "";
                txtbConfirmpass.Text = "";
                txtbPassword.Focus();

            }
        }

        private void CHbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (CHbxShowPass.Checked)
            {
                txtbPassword.PasswordChar = '\0';
                txtbConfirmpass.PasswordChar = '\0';
            }
            else
            {
                txtbPassword.PasswordChar = '*';
                     txtbConfirmpass.PasswordChar = '*';

            }


        }

        private void LbacktoLogin_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
       }

        private void txtbPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

