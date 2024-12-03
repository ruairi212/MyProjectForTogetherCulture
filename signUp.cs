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

        private void signUp_Load(object sender, EventArgs e)
        {
            // Populate the combo box with security questions
            combobxSecurityQues.Items.Add("Name of the city you were born in?");
            combobxSecurityQues.Items.Add("Name of the first school you went to?");
            combobxSecurityQues.Items.Add("Name of your first pet?");
        }

        private void Lpassword_Click(object sender, EventArgs e)
        {

        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            /* if (string.IsNullOrEmpty(txtbUsername.Text) || 
                 string.IsNullOrEmpty(txtbPassword.Text) || 
                 string.IsNullOrEmpty(txtbConfirmpass.Text) ||
                 combobxSecurityQues.SelectedItem == null ||
                 string.IsNullOrEmpty(textbSecurityQuesAns.Text))

             {
                 MessageBox.Show("Username and Password field  are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);


             }

             else if (txtbPassword.Text == txtbConfirmpass.Text)
             {

                  try
                  {
                      using (OleDbConnection con = new OleDbConnection(connectionString))
                      {
                          con.Open();

                          string register = "INSERT INTO tbl_user (username, password, security_question, security_answer) VALUES (@username, @password, @security_question, @security_answer)";
                          using (OleDbCommand cmd = new OleDbCommand(register, con))
                          {
                              cmd.Parameters.AddWithValue("@username", txtbUsername.Text);
                              cmd.Parameters.AddWithValue("@password", txtbPassword.Text);
                              cmd.Parameters.AddWithValue("@security_question", combobxSecurityQues.SelectedItem.ToString());
                              cmd.Parameters.AddWithValue("@security_answer", textbSecurityQuesAns.Text);
                              cmd.ExecuteNonQuery();
                          }
                      }
                 



            txtbUsername.Text = "";
                txtbPassword.Text = "";
                txtbConfirmpass.Text = "";
                combobxSecurityQues.SelectedItem = null;
                textbSecurityQuesAns.Text = "";



                MessageBox.Show("Your account has been Successfullu created", "Registration Success", MessageBoxButtons.OK);
                // catch (Exception ex)
                // {
                //     MessageBox.Show("An error occurred: " + ex.Message, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // }

                //new nonmember().Show();

            } 


            else
            {
                MessageBox.Show("Passwords does not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbPassword.Text = "";
                txtbConfirmpass.Text = "";
                txtbPassword.Focus();

            }*/
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
           this.Close();
       }

        private void txtbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbSecurityQuesAns_TextChanged(object sender, EventArgs e)
        {

        }

        private void combobxSecurityQues_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LAnswer_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtbConfirmpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

