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
    public partial class EventBooking : Form
    {
        private DateTime clicked_Date;
        private string clicked_Event_Name;
        public EventBooking(DateTime date, string event_Name)
        {
            InitializeComponent();
            clicked_Date = date;
            clicked_Event_Name = event_Name;
            DisplayDate();

        }
        private void DisplayDate()
        {
            label4.Text = "Selected Date: " + clicked_Date.ToString("D");
        }
        private void DisplayEvent() 
        {
            textBox3.Text = "Selected Event: " + clicked_Event_Name;
        }
        private void EventBooking_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
