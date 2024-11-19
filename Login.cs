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
                using (OleDbConnection con = new OleDbConnection(connectionString))
                {
                    con.Open();

                    // Check if the user is an administrator
                    string adminLogin = "SELECT * FROM tbl_administrator WHERE username = @username AND passwords = @passwords";
                    using (OleDbCommand adminCmd = new OleDbCommand(adminLogin, con))
                    {
                        adminCmd.Parameters.AddWithValue("@username", txtbLogUsername.Text);
                        adminCmd.Parameters.AddWithValue("@passwords", txtbLogPassword.Text);

                        using (OleDbDataReader adminDr = adminCmd.ExecuteReader())
                        {
                            if (adminDr.Read())
                            {
                                new AdminDashboard().Show();
                                this.Hide();
                                return;
                            }
                        }
                    }

                    // Check if the user is a member
                    string memberLogin = "SELECT * FROM tbl_users WHERE username = @username AND passwords = @passwords";
                    using (OleDbCommand memberCmd = new OleDbCommand(memberLogin, con))
                    {
                        memberCmd.Parameters.AddWithValue("@username", txtbLogUsername.Text);
                        memberCmd.Parameters.AddWithValue("@passwords", txtbLogPassword.Text);

                        using (OleDbDataReader memberDr = memberCmd.ExecuteReader())
                        {
                            if (memberDr.Read())
                            {
                                new Members_Dashboard().Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Username or Password, Please Try Again or Press Forget Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
