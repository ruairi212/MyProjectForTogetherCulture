using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using member_space;

namespace member_space
{
    public partial class MemberInsightDashboard : Form
    {
        private member_dashBoard_Data member_Data;
        public MemberInsightDashboard()
        {
            InitializeComponent();
            member_Data = new member_dashBoard_Data();
        }
        private void Show_Members() 
        {
            int total_members = member_Data.Get_Totals();
            label3.Text = total_members.ToString();

        }
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void MemberInsightDashboard_Load(object sender, EventArgs e)
        {
            Show_Members();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
