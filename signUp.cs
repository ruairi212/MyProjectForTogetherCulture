using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace member_space
{
    public partial class signUp : Form
    { 

         
        public signUp()
        {
            InitializeComponent();
        }

        private void signUp_Load(object sender, EventArgs e)
        {

        }

        private void Lpassword_Click(object sender, EventArgs e)
        {

        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            if (txtbUsername.Text == "" && txtbPassword.Text == "" && txtbConfirmpass.Text == "")

            { 
            MessageBox.Show("Username and Password field  are empty", "Registration Failed"


     }
        }
    }
}
