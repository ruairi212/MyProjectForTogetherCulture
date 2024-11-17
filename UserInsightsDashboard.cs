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
        string connectionString = "Server=127.0.0.1;Database=together_culture;Uid=root;Pwd=;";
        public UserInsightsDashboard()
        {
            InitializeComponent();
        }


        private void UserInsightsDashboard_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
